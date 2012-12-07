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
        public static String TinhGiaTriRoiRac(decimal giaTri,decimal giaTriTrungBinh,decimal doLechChuan, int khoang)
        {
            String giaTriRoiRac = "";
            int iCount=1;
            doLechChuan = Math.Round(doLechChuan, 0);
            decimal giaTriMoi = giaTriTrungBinh + doLechChuan;
            while (giaTriMoi < giaTri)
            {
                iCount++;
                if (iCount == khoang) break;
                giaTriMoi = giaTriMoi + doLechChuan;
                
            };
            if (iCount == 1)
                giaTriRoiRac = "<" + giaTriMoi.ToString();
            else if (iCount == khoang)
                giaTriRoiRac = "" + giaTriMoi.ToString() + "" + ">";
            else
                giaTriRoiRac = (giaTriMoi - doLechChuan).ToString() + "_" + giaTriMoi.ToString();
            return giaTriRoiRac;
        }
        //Hàm dùng để tại ra các khoảng giá trị đã rời rạc
        public static void TaoBayesObject(String colName,int khoang, decimal giaTriTrungBinh, decimal doLechChuan)
        {
            DiabetesDataSetTableAdapters.BayesObjectTableAdapter BayesObjectTA = new DiabetesDataSetTableAdapters.BayesObjectTableAdapter();
            decimal giaTriMoi=giaTriTrungBinh+doLechChuan;
            for (int i = 1; i <= khoang; i++)
            {
                String khoangRoiRac="";
                if (i == 1)
                    khoangRoiRac = "<" + giaTriMoi.ToString();
                else if (i == khoang)
                    khoangRoiRac = giaTriMoi.ToString() + ">";
                else
                    khoangRoiRac = (giaTriMoi - doLechChuan).ToString() + "_" + giaTriMoi.ToString();
                BayesObjectTA.Insert(colName, khoangRoiRac, 0, false);
                BayesObjectTA.Insert(colName, khoangRoiRac, 0, true);
                giaTriMoi = giaTriMoi + doLechChuan;
            }
        }
        public static void CapNhapBangSauKhiRoiRacHoa(DiabetesDataSetTableAdapters.DataSetTempTableAdapter dataSetTempTA, decimal maBN, String colName, String giaTriRoiRac)
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
        //Hàm dùng để chia dữ liệu theo tỉ lệ nhập vào
        public void ChiaDuLieu(int phanTramDuLieu)
        {
            DiabetesDataSetTableAdapters.TrainingSetTableAdapter trainingSetTA = new DiabetesDataSetTableAdapters.TrainingSetTableAdapter();
            DiabetesDataSetTableAdapters.ResultSetTableAdapter resultSetTA = new DiabetesDataSetTableAdapters.ResultSetTableAdapter();
            DiabetesDataSetTableAdapters.TestSetTableAdapter testSetTA = new DiabetesDataSetTableAdapters.TestSetTableAdapter();
            DiabetesDataSetTableAdapters.DataSetTempTableAdapter dataSetTempTA = new DiabetesDataSetTableAdapters.DataSetTempTableAdapter();
            DataTable dtSetTemp=dataSetTempTA.GetData();
            int luongDuLieu = dtSetTemp.Rows.Count * phanTramDuLieu / 100;
            int iCount = 0;
            trainingSetTA.DeleteAll();
            resultSetTA.DeleteAll();
            testSetTA.DeleteAll();
            foreach (DataRow dtRow in dtSetTemp.Rows)
            {
                
                if (iCount < luongDuLieu)
                {
                    trainingSetTA.Insert(dtRow[2].ToString(),Convert.ToBoolean(dtRow[3]),dtRow[4].ToString(),dtRow[5].ToString(),dtRow[6].ToString(),dtRow[7].ToString(),dtRow[8].ToString(),dtRow[9].ToString(),dtRow[10].ToString(),dtRow[11].ToString(),
                                         dtRow[12].ToString(),dtRow[13].ToString(),dtRow[14].ToString(),dtRow[15].ToString(),dtRow[16].ToString(),dtRow[17].ToString(),dtRow[18].ToString(),dtRow[19].ToString(),dtRow[20].ToString(),dtRow[21].ToString(),
                                         dtRow[22].ToString(), dtRow[23].ToString(), dtRow[24].ToString(), dtRow[25].ToString(), dtRow[26].ToString(), dtRow[27].ToString(), dtRow[28].ToString(), dtRow[29].ToString(), dtRow[30].ToString(), dtRow[31].ToString(), dtRow[32].ToString(), dtRow[33].ToString());
                }
                else
                {
                    testSetTA.Insert(Convert.ToDecimal(dtRow[1]),dtRow[2].ToString(), false, dtRow[4].ToString(), dtRow[5].ToString(), dtRow[6].ToString(), dtRow[7].ToString(), dtRow[8].ToString(), dtRow[9].ToString(), dtRow[10].ToString(), dtRow[11].ToString(),
                                         dtRow[12].ToString(), dtRow[13].ToString(), dtRow[14].ToString(), dtRow[15].ToString(), dtRow[16].ToString(), dtRow[17].ToString(), dtRow[18].ToString(), dtRow[19].ToString(), dtRow[20].ToString(), dtRow[21].ToString(),
                                         dtRow[22].ToString(), dtRow[23].ToString(), dtRow[24].ToString(), dtRow[25].ToString(), dtRow[26].ToString(), dtRow[27].ToString(), dtRow[28].ToString(), dtRow[29].ToString(), dtRow[30].ToString(), dtRow[31].ToString(), dtRow[32].ToString(), dtRow[33].ToString());
                    resultSetTA.Insert(Convert.ToDecimal(dtRow[1]), dtRow[2].ToString(), Convert.ToBoolean(dtRow[3]), dtRow[4].ToString(), dtRow[5].ToString(), dtRow[6].ToString(), dtRow[7].ToString(), dtRow[8].ToString(), dtRow[9].ToString(), dtRow[10].ToString(), dtRow[11].ToString(),
                                         dtRow[12].ToString(), dtRow[13].ToString(), dtRow[14].ToString(), dtRow[15].ToString(), dtRow[16].ToString(), dtRow[17].ToString(), dtRow[18].ToString(), dtRow[19].ToString(), dtRow[20].ToString(), dtRow[21].ToString(),
                                         dtRow[22].ToString(), dtRow[23].ToString(), dtRow[24].ToString(), dtRow[25].ToString(), dtRow[26].ToString(), dtRow[27].ToString(), dtRow[28].ToString(), dtRow[29].ToString(), dtRow[30].ToString(), dtRow[31].ToString(), dtRow[32].ToString(), dtRow[33].ToString());
                }
                iCount++;
            }

        }
        //Hàm dùng để đếm số lần xuất hiện của khoảng của một phân lớp
        public int DemSoLuongKhoang(String tenThuocTinh,String khoangRoiRac,Boolean tieuDuong)
        {
            int soLuong = 0;
            DiabetesDataSetTableAdapters.DataSetTempTableAdapter dtAdapter = new DiabetesDataSetTableAdapters.DataSetTempTableAdapter();
            DataTable dt = dtAdapter.GetData();
            soLuong = dt.Select("TenThuocTinh='" + tenThuocTinh + "' and KhoangRoiRac='" + khoangRoiRac + "' and tieuDuong=" + tieuDuong + "").Count();
            return soLuong;
        }
        //Hàm dùng để huấn luyện dữ liệu dành cho thuật toán Naive Bayes
        public void HuanLuyenBayes()
        {
            DiabetesDataSetTableAdapters.BayesObjectTableAdapter dtBayesAdapter = new DiabetesDataSetTableAdapters.BayesObjectTableAdapter();
            DiabetesDataSetTableAdapters.DataSetTempTableAdapter dtSetTempAdapter = new DiabetesDataSetTableAdapters.DataSetTempTableAdapter();
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
    }
}
