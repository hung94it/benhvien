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
        public decimal TinhTrungBinhKhoang(DataTable dataTable,String colName, int khoang)
        {
            decimal minValue = Convert.ToDecimal(dataTable.Compute("min(" + colName + ")", string.Empty));
            decimal maxValue = Convert.ToDecimal(dataTable.Compute("max(" + colName + ")", string.Empty));
            decimal giaTriTrungBinh = Math.Round((minValue + maxValue) / khoang, 3);
            return giaTriTrungBinh;
        }
        public String TinhGiaTriRoiRac(decimal giaTri, decimal giaTriTrungBinh, int khoang)
        {
            int i = 0;
            decimal giaTriBanDau = giaTriTrungBinh;
            do
            {

                if (giaTriTrungBinh < giaTri)
                {
                    giaTriTrungBinh += giaTriBanDau;
                    i++;
                }
            }
            while (giaTriTrungBinh < giaTri);
            if (i == 0)
                return "<" + giaTriTrungBinh.ToString();
            else if (i == khoang)
                return giaTriTrungBinh.ToString() + ">";
            else
                return (giaTriBanDau * i).ToString() + "_" + giaTriTrungBinh.ToString();
        }
        public void CapNhapBangSauKhiRoiRacHoa(DiabetesDataSetTableAdapters.DataSetTempTableAdapter dataSetTempTA, decimal maBN, String colName, String giaTri)
        {
            DataTable dataSetTempTable = dataSetTempTA.GetDataByOne(maBN);
            DataRow newRow = dataSetTempTable.NewRow();
            foreach(DataRow dtRow in dataSetTempTable.Rows)
            {
                newRow = dtRow;
            }
            int colIndex = dataSetTempTA.GetData().Columns.IndexOf(colName);
            newRow[colIndex] = giaTri;
            dataSetTempTA.Update(newRow);
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
