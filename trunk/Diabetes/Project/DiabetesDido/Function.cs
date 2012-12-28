using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DiabetesDido
{
    public class Function
    {
        public void LamSachDuLieu(DataTable dataSetDT,List<decimal> danhSachViTri)
        {
            for (int i = 0; i < dataSetDT.Rows.Count-1; i++)
            {
                int Flag=0;
                for (int j = 0; j < danhSachViTri.Count; j++)
                {
                    decimal iD=Convert.ToDecimal(dataSetDT.Rows[i][0]);
                    if ( iD == danhSachViTri[j])
                    {
                        Flag = 1;
                        break;
                    }
                }
                if (Flag == 0)
                {
                    for (int j = i + 1; j < dataSetDT.Rows.Count; j++)
                    {
                        decimal iMaBN = Convert.ToDecimal(dataSetDT.Rows[i][1]);
                        decimal jMaBN = Convert.ToDecimal(dataSetDT.Rows[j][1]);
                        if (iMaBN == jMaBN)
                            danhSachViTri.Add(Convert.ToDecimal(dataSetDT.Rows[j][0]));
                        else
                            break;
                    }
                }
            }
        }
        public String RoiRacHoaTuoi(decimal namSinh)
        {
            if (namSinh < 10)
                return "<10";
            else if (namSinh < 20)
                return "10_20";
            else if (namSinh < 30)
                return "20_30";
            else if (namSinh < 40)
                return "30_40";
            else if (namSinh < 50)
                return "40_50";
            else if (namSinh < 60)
                return "50_60";
            else if (namSinh < 70)
                return "60_70";
            else if (namSinh < 80)
                return "70_80";
            else
                return "80>";
        }
        //Hàm dùng để tính phương sai của một cột
        public static decimal TinhDoLechChuan(DataTable dt, String colName)
        {
            Double phuongSai = 0;
            Double doLechChuan=0;
            Double tienPhuongSai = 0;
            Double soLuongDuLieu = Convert.ToDouble(dt.Compute("count(" + colName + ")", string.Empty));
            Double giaTriTrungTinh = Convert.ToDouble(dt.Compute("avg(" + colName + ")", string.Empty));
            giaTriTrungTinh = Math.Round(giaTriTrungTinh, 3);
            int colIndex = dt.Columns.IndexOf(colName);
            foreach (DataRow dtRow in dt.Rows)
            {
                tienPhuongSai = tienPhuongSai + Math.Round(Math.Pow((Convert.ToDouble(dtRow[colIndex]) - giaTriTrungTinh),2),3);
            }
            phuongSai = tienPhuongSai / (soLuongDuLieu - 1);
            doLechChuan = Math.Round(Math.Sqrt(phuongSai), 2);
            return Convert.ToDecimal(doLechChuan);
        }
        //Hàm dùng để rời rạc giá trị của cột trong bảng dữ liệu
        public static String TinhGiaTriRoiRac(decimal giaTri,String colName, int khoang)
        {
            DiabetesDido.DAL.DiabetesDataSetTableAdapters.DataSetTableAdapter dataSetTA = new DiabetesDido.DAL.DiabetesDataSetTableAdapters.DataSetTableAdapter();
            DataTable dt = dataSetTA.GetData();
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
                giaTriRoiRac = "(0," + giaTriMoi.ToString()+")";
            else if (iCount == khoang)
                giaTriRoiRac = "[" + giaTriMoi.ToString() + ",+)";
            else
                giaTriRoiRac ="["+ (giaTriMoi - giaTriTrungBinhKhoang).ToString() + "," + giaTriMoi.ToString() + ")";
            return giaTriRoiRac;
        }
        //Hàm dùng để tại ra các khoảng giá trị đã rời rạc
        public static void TaoBayesObject(String colName,int khoang)
        {
            DiabetesDido.DAL.DiabetesDataSetTableAdapters.BayesObjectTableAdapter BayesObjectTA = new DiabetesDido.DAL.DiabetesDataSetTableAdapters.BayesObjectTableAdapter();
            DiabetesDido.DAL.DiabetesDataSetTableAdapters.DataSetTableAdapter dataSetTA = new DiabetesDido.DAL.DiabetesDataSetTableAdapters.DataSetTableAdapter();
            DataTable dt = dataSetTA.GetData();
            decimal minValue = Convert.ToDecimal(dt.Compute("min(" + colName + ")", string.Empty));
            decimal maxValue = Convert.ToDecimal(dt.Compute("max(" + colName + ")", string.Empty));
            decimal giaTriMoi=Math.Round((minValue+maxValue)/khoang,3);
            decimal giaTriTrungBinhKhoang = giaTriMoi;
            for (int i = 1; i <= khoang; i++)
            {
                String khoangRoiRac="";
                if (i == 1)
                    khoangRoiRac = "<" + giaTriMoi.ToString();
                else if (i == khoang)
                    khoangRoiRac = giaTriMoi.ToString() + ">";
                else
                    khoangRoiRac = (giaTriMoi - giaTriTrungBinhKhoang).ToString() + "_" + giaTriMoi.ToString();
                BayesObjectTA.Insert(colName, khoangRoiRac, 0, "Yes");
                BayesObjectTA.Insert(colName, khoangRoiRac, 0, "No");
                if (i != khoang - 1)
                    giaTriMoi = giaTriMoi + giaTriTrungBinhKhoang;
            }
        }
        //Hàm dùng để cập nhập lại bảng DataSetTemp sau khi rời rạc hóa một thuộc tính
        public static void CapNhapDataSetTemp(DiabetesDido.DAL.DiabetesDataSetTableAdapters.DataSetTempTableAdapter dataSetTempTA, decimal maBN, String colName, String giaTriRoiRac)
        {
            DataTable dataSetTempTable = dataSetTempTA.GetDataByOne(maBN);
            DataRow newRow = dataSetTempTable.NewRow();
            foreach(DataRow dtRow in dataSetTempTable.Rows)
            {
                newRow = dtRow;
            }
            int colIndex = dataSetTempTA.GetData().Columns.IndexOf(colName);
            newRow[colIndex] = giaTriRoiRac;
            dataSetTempTA.Update(newRow);
        }
        //Hàm dùng để huấn luyện dữ liệu cho thuật toán Bayes
        public static void HuyenLuyenBayes()
        { 
            
        }
        //Hàm dùng để chia dữ liệu theo tỉ lệ nhập vào
        public void ChiaDuLieu(int phanTramDuLieu)
        {
            DiabetesDido.DAL.DiabetesDataSetTableAdapters.TrainingSetTableAdapter trainingSetTA = new DiabetesDido.DAL.DiabetesDataSetTableAdapters.TrainingSetTableAdapter();
            DiabetesDido.DAL.DiabetesDataSetTableAdapters.TestSetTableAdapter testSetTA = new DiabetesDido.DAL.DiabetesDataSetTableAdapters.TestSetTableAdapter();
            DiabetesDido.DAL.DiabetesDataSetTableAdapters.DataSetTempTableAdapter dataSetTempTA = new DiabetesDido.DAL.DiabetesDataSetTableAdapters.DataSetTempTableAdapter();
            DataTable dtSetTemp=dataSetTempTA.GetData();
            int luongDuLieu = dtSetTemp.Rows.Count * phanTramDuLieu / 100;
            int iCount = 0;
            trainingSetTA.DeleteAll();
            testSetTA.DeleteAll();
            foreach (DataRow dtRow in dtSetTemp.Rows)
            {
                
                if (iCount < luongDuLieu)
                {
                    trainingSetTA.Insert(Convert.ToDecimal(dtRow[1]),dtRow[2].ToString(), dtRow[3].ToString(), dtRow[4].ToString(), dtRow[5].ToString(), dtRow[6].ToString(), dtRow[7].ToString(), dtRow[8].ToString(), dtRow[9].ToString(), dtRow[10].ToString(), dtRow[11].ToString(), dtRow[12].ToString(), dtRow[13].ToString(), dtRow[14].ToString(), dtRow[15].ToString(), dtRow[16].ToString(), dtRow[17].ToString(), dtRow[18].ToString(), dtRow[19].ToString(), dtRow[20].ToString(), dtRow[21].ToString(), dtRow[22].ToString(), dtRow[23].ToString(), dtRow[24].ToString(), dtRow[25].ToString(), dtRow[26].ToString(), dtRow[27].ToString(), dtRow[28].ToString(), dtRow[29].ToString(), dtRow[30].ToString(), dtRow[31].ToString(), dtRow[32].ToString(), dtRow[33].ToString(),dtRow[34].ToString());
                }
                else
                {
                    testSetTA.Insert(Convert.ToDecimal(dtRow[1]), dtRow[2].ToString(), dtRow[3].ToString(), dtRow[4].ToString(), dtRow[5].ToString(), dtRow[6].ToString(), dtRow[7].ToString(), dtRow[8].ToString(), dtRow[9].ToString(), dtRow[10].ToString(), dtRow[11].ToString(), dtRow[12].ToString(), dtRow[13].ToString(), dtRow[14].ToString(), dtRow[15].ToString(), dtRow[16].ToString(), dtRow[17].ToString(), dtRow[18].ToString(), dtRow[19].ToString(), dtRow[20].ToString(), dtRow[21].ToString(), dtRow[22].ToString(), dtRow[23].ToString(), dtRow[24].ToString(), dtRow[25].ToString(), dtRow[26].ToString(), dtRow[27].ToString(), dtRow[28].ToString(), dtRow[29].ToString(), dtRow[30].ToString(), dtRow[31].ToString(), dtRow[32].ToString(), dtRow[33].ToString(), dtRow[34].ToString());
                }
                iCount++;
            }

        }
        //Hàm dùng để huấn luyện dữ liệu dành cho thuật toán Naive Bayes
        public void HuanLuyenBayes()
        {
            DiabetesDido.DAL.DiabetesDataSetTableAdapters.BayesObjectTableAdapter dtBayesAdapter = new DiabetesDido.DAL.DiabetesDataSetTableAdapters.BayesObjectTableAdapter();
            DiabetesDido.DAL.DiabetesDataSetTableAdapters.DataSetTempTableAdapter dtSetTempAdapter = new DiabetesDido.DAL.DiabetesDataSetTableAdapters.DataSetTempTableAdapter();
            DataTable dtBayes = dtBayesAdapter.GetData();
            DataTable dtSetTemp = dtSetTempAdapter.GetData();
            foreach (DataRow dtRow in dtBayes.Rows)
            {
                String colName = dtRow[1].ToString();
                String khoangRoiRac = dtRow[2].ToString();
                Boolean tieuDuong = Convert.ToBoolean(dtRow[4]);
                String iQuery = "" + colName + "='" + khoangRoiRac + "' and TieuDuong=" + tieuDuong + "";
                int soLuong = dtSetTemp.Select(iQuery).Count();
                DataRow newRow = dtBayes.NewRow();
                newRow = dtRow;
                newRow[3] = soLuong;
                dtBayesAdapter.Update(newRow);
            }
        }
        //Hàm dùng để tính kết quả của một bảng trong bộ thử nghiệm
        public static DataTable NaiveBayes( DataTable dtTestSet)
        {
            DiabetesDido.DAL.DiabetesDataSetTableAdapters.BayesObjectTableAdapter bayesTA= new DiabetesDido.DAL.DiabetesDataSetTableAdapters.BayesObjectTableAdapter();
            DataTable dtBayes = bayesTA.GetData();
            int possiveNumber = dtTestSet.Select("TieuDuong='Yes'").Count();
            int negativeNumber = dtTestSet.Select("TieuDuong='No'").Count();
            int allNumber = possiveNumber + negativeNumber;
            foreach (DataRow dtRow in dtTestSet.Rows)
            {
                Decimal pYes = 1;
                Decimal pNo = 1;
                for (int i = 1; i < dtTestSet.Columns.Count-1; i++)
                {
                    String colName = dtTestSet.Columns[i].ColumnName;
                    String khoangRoiRac = dtRow[i].ToString();
                    DataRow possiveRow = dtBayes.Select("TenThuocTinh='" + colName + "' and KhoangRoiRac='" + khoangRoiRac + "' and TieuDuong='Yes'")[0];
                    DataRow negativeRow = dtBayes.Select("TenThuocTinh='" + colName + "' and KhoangRoiRac='" + khoangRoiRac + "' and TieuDuong='No'")[0];
                    Decimal _pYes = Convert.ToDecimal(possiveRow[3]);
                    Decimal _pNo = Convert.ToDecimal(negativeRow[3]);
                    pYes = pYes * _pYes;
                    pNo = pNo * _pNo;
                }
                pYes = pYes * possiveNumber / allNumber;
                pNo = pNo * negativeNumber / allNumber;
                if (pYes > pNo)
                    dtRow[33] = "Yes";
                else
                    dtRow[33] = "No";
            }
            return dtTestSet;
        }
        //Hàm dùng để tính độ bao phủ Recall (Độ nhạy Sensitivity)
        public static decimal Recall(int truePossive, int falseNegative)
        {
            decimal iRecall = 1;
            decimal iTruePossive = Convert.ToDecimal(truePossive);
            decimal iFalseNegative = Convert.ToDecimal(falseNegative);
            iRecall = iTruePossive / (iTruePossive + iFalseNegative);
            iRecall = Math.Round(iRecall, 3);
            return iRecall;
        }
        //Hàm  dùng để tính độ chính xác Precision
        public static decimal Precision(int truePossive, int falsePossive)
        {
            decimal iPrecision = 1;
            decimal iTruePossive = Convert.ToDecimal(truePossive);
            decimal iFalsePossive = Convert.ToDecimal(falsePossive);
            iPrecision = iTruePossive / (iTruePossive + iFalsePossive);
            iPrecision = Math.Round(iPrecision, 3);
            return iPrecision;
        }
        //Hàm dùng để tính độ chính xác Accuracy
        public static decimal Accuracy(int truePossive, int trueNegative, int falsePossive, int falseNegative)
        {
            decimal iAccuracy = 1;
            decimal iTruePossive = Convert.ToDecimal(truePossive);
            decimal iFalseNegative = Convert.ToDecimal(falseNegative);
            decimal iTrueNegative = Convert.ToDecimal(trueNegative);
            decimal iFalsePossive = Convert.ToDecimal(falsePossive);
            iAccuracy = (iTrueNegative + iTruePossive) / (iTruePossive + iTrueNegative + iFalseNegative + iFalsePossive);
            iAccuracy = Math.Round(iAccuracy, 3);
            return iAccuracy;
        }
        //Hàm dùng để tính độ đó F1
        public static decimal F1(decimal iRecall, decimal iPrecision)
        {
            decimal iF1 = 0;
            iF1 = 2 * iPrecision * iRecall / (iRecall + iPrecision);
            iF1 = Math.Round(iF1, 3);
            return iF1;
        }
        //Hàm dùng để trả về các thông số dùng để đánh giá một giải thuật máy học gồm: true possive, false possive, true negative, false negative
        public static Dictionary<String, int> TinhThongSo(DataTable dtTest, DataTable dtResult)
        {
            Dictionary<String, int> iDictionary = new Dictionary<string, int>();
            int iTruePossive = 0;
            int iFalsePossive = 0;
            int iTrueNegative = 0;
            int iFalseNegative = 0;
            int iCount = dtTest.Columns.Count;
            for (int i = 0; i < dtTest.Rows.Count; i++)
            {
                //2 biến dùng để chứa cột "TieuDuong" của table
                String iTest = dtTest.Rows[i][iCount - 1].ToString();
                String iResult = dtResult.Rows[i][iCount - 1].ToString();
                switch (iResult)
                {
                    case "Yes":
                        {
                            if (iTest == "Yes")
                                iTruePossive++;
                            else
                                iFalseNegative++;
                            break;
                        }
                    case "No":
                        {
                            if (iTest == "Yes")
                                iFalsePossive++;
                            else
                                iTrueNegative++;
                            break;
                        }
                }
            }
            iDictionary.Add("TruePossive", iTruePossive);
            iDictionary.Add("FalseNegative", iFalseNegative);
            iDictionary.Add("TrueNegative", iTrueNegative);
            iDictionary.Add("FalsePossive", iFalsePossive);
            return iDictionary;
        }
    }
}
