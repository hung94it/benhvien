using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using DiabetesDido.UI;
using DiabetesDido.DAL;
using DiabetesDido.DAL.DiabetesDataSetTableAdapters;

namespace DiabetesDido.ClassificationLogic
{
    public class DiscretizationData
    {       
        public static String RoiRacHoaTuoi(decimal namSinh)
        {
            if (namSinh < 10)
                return "[0,10)";
            else if (namSinh < 20)
                return "[10,20)";
            else if (namSinh < 30)
                return "[20,30)";
            else if (namSinh < 40)
                return "[30,40)";
            else if (namSinh < 50)
                return "[40,50)";
            else if (namSinh < 60)
                return "[50,60)";
            else if (namSinh < 70)
                return "[60,70)";
            else if (namSinh < 80)
                return "[70,80)";
            else
                return "[80,+)";
        }        

        //Hàm dùng để rời rạc giá trị của cột trong bảng dữ liệu chẩn đoán
        public static String DataDiscretizationForDiagnosis(decimal colValue, String colName)
        {
            
            List<double> listIntervalValues = GetListIntervalValue(colName);
            String DiscretizationValue = FormCustomDataDiscretization.DataDiscretization(colValue, listIntervalValues);
            return DiscretizationValue;
        }

        //Hàm dùng để lấy một tập gồm các khoảng rời rạc của một cột
        public static List<double> GetListIntervalValue(String colName)
        {
            List<double> listIntervalValues = new List<double>();
            if (colName != "GioiTinh")
            {
                BayesObjectTableAdapter bayesObjectTableAdapter = new BayesObjectTableAdapter();
                DataRow[] dtIntervalValue = bayesObjectTableAdapter.GetData().Select("TenThuocTinh='" + colName + "'");
                foreach (DataRow dtRow in dtIntervalValue)
                {
                    String[] listString = dtRow[2].ToString().Split(',');
                    String str = listString[0].Substring(1, listString[0].Length - 1);
                    double intervalValue = Convert.ToDouble(str);
                    if (!listIntervalValues.Contains(intervalValue))
                        listIntervalValues.Add(intervalValue);
                    //Dành cho trường hợp thuộc tính chỉ có 1 khoảng
                    if (dtIntervalValue.Count() == 2)
                    {
                        String secondStr = listString[1].Substring(0, listString[1].Length - 1);
                        double secondIntervalValue = Convert.ToDouble(secondStr);
                        if (!listIntervalValues.Contains(secondIntervalValue))
                            listIntervalValues.Add(secondIntervalValue);
                    }
                }
            }
            return listIntervalValues;
        }
        //Hàm dùng để rời rạc giá trị của cột trong bảng dữ liệu
        public static String DataDiscretization(decimal giaTri,String colName, int khoang, DataTable dt)
        {
            decimal minValue = Convert.ToDecimal(dt.Compute("min(" + colName + ")", string.Empty));
            decimal maxValue = Convert.ToDecimal(dt.Compute("max(" + colName + ")", string.Empty));
            decimal giaTriMoi=Math.Round((minValue+maxValue)/khoang,3);
            decimal giaTriTrungBinhKhoang = giaTriMoi;
            String giaTriRoiRac = "";
            int iCount=1;

            while (giaTriMoi < giaTri)
            {
                iCount++;
                if (iCount == khoang) break;
                giaTriMoi = giaTriMoi + giaTriTrungBinhKhoang;
                
            };
            if (iCount == 1)
                giaTriRoiRac = "[0," + giaTriMoi.ToString("0.###") + ")";
            else if (iCount == khoang)
                giaTriRoiRac = "[" + giaTriMoi.ToString("0.###") + ",+)";
                
            else
                giaTriRoiRac = "[" + (giaTriMoi - giaTriTrungBinhKhoang).ToString("0.###") + ","
                    + giaTriMoi.ToString("0.###") + ")";
            return giaTriRoiRac;
        }

        //Hàm dùng để tại ra các khoảng giá trị đã rời rạc
        public static void TaoBayesObject(String colName, int khoang, DataTable dt)
        {
            BayesObjectTableAdapter BayesObjectTA = new BayesObjectTableAdapter();
            //DataSetTableAdapter dataSetTA = new DataSetTableAdapter();
            //DataTable dt = dataSetTA.GetData();
            decimal minValue = Convert.ToDecimal(dt.Compute("min(" + colName + ")", string.Empty));
            decimal maxValue = Convert.ToDecimal(dt.Compute("max(" + colName + ")", string.Empty));
            decimal giaTriMoi=Math.Round((minValue+maxValue)/khoang,3);
            decimal giaTriTrungBinhKhoang = giaTriMoi;
            for (int i = 1; i <= khoang; i++)
            {
                String khoangRoiRac="";
                if (i == 1)
                    khoangRoiRac = "[0," + giaTriMoi.ToString("0.###") + ")";
                else if (i == khoang)
                    khoangRoiRac = "[" + giaTriMoi.ToString("0.###") + ",+)";
                else
                    khoangRoiRac = "[" + (giaTriMoi - giaTriTrungBinhKhoang).ToString("0.###") + "," 
                        + giaTriMoi.ToString("0.###") + ")";
                BayesObjectTA.Insert(colName, khoangRoiRac, 0, "True");
                BayesObjectTA.Insert(colName, khoangRoiRac, 0, "False");
                if (i != khoang - 1)
                    giaTriMoi = giaTriMoi + giaTriTrungBinhKhoang;
            }
        }

        //Hàm dùng để rời rác hóa dataset trước khi thực hiện chẩn đoán
        public static DataTable DataDiscretizationForDiagnosis(DataTable dt)
        {
            DiabetesDataSetB.TrainningDataTable trainningDataTable = new DiabetesDataSetB.TrainningDataTable();
            trainningDataTable.Columns.Add("MaBn", typeof(decimal));
            trainningDataTable.Columns["MaBn"].SetOrdinal(0);

            try
            {
                foreach (DataRow dtRow in dt.Rows)
                {
                    DataRow newRow = trainningDataTable.NewRow();

                    foreach (DataColumn dtCol in dt.Columns)
                    {
                        String colName = dtCol.ColumnName;

                        switch (colName)
                        {
                            case "ID":
                            case "NgayKham":
                            case "HoTen":
                            case "GRAN":
                            case "TyLeGRAN":
                            case "Na":
                            case "K":
                            case "Cl":
                            case "Ca":
                                break;
                            case "MaBn":
                                newRow[colName] = dtRow[colName];
                                break;
                            case "TieuDuong":
                                newRow[colName] = Convert.ToBoolean(dtRow[colName]);
                                break;
                            case "GioiTinh":
                                newRow[colName] = dtRow[colName].ToString();
                                break;
                            case "NamSinh":
                                int namSinh = Convert.ToInt16(dtRow[colName]);
                                int tuoiHienTai = DateTime.Now.Year - namSinh;
                                String Tuoi = DiscretizationData.RoiRacHoaTuoi(tuoiHienTai);
                                newRow["Tuoi"] = Tuoi;
                                break;
                            default:
                                decimal colValue = Convert.ToDecimal(dtRow[colName]);
                                String giaTriRoiRac = DiscretizationData.DataDiscretizationForDiagnosis(colValue, colName);
                                newRow[colName] = giaTriRoiRac;
                                break;
                        }
                    }
                    trainningDataTable.Rows.Add(newRow);
                }
            }
            catch (Exception)
            {
                
            }
            return trainningDataTable;
        }
        
    }
}
