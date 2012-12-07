using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DiabetesDido
{
    public partial class ThongKeDuLieuRoiRac : Form
    {
        public String ColName = "";
        public ThongKeDuLieuRoiRac()
        {
            InitializeComponent();
        }
        public ThongKeDuLieuRoiRac(String colName)
        {
            InitializeComponent();
            this.ColName = colName;
        }
        private void ThongKeDuLieuRoiRac_Load(object sender, EventArgs e)
        {
            this.Text = "Bảng thống kê dữ liệu của thuộc tính: " + ColName;
            DiabetesDataSetTableAdapters.DataSetTempTableAdapter dataSetTempTA = new DiabetesDataSetTableAdapters.DataSetTempTableAdapter();
            DiabetesDataSetTableAdapters.BayesObjectTableAdapter bayesTA = new DiabetesDataSetTableAdapters.BayesObjectTableAdapter();
            DataRow[] bayesRows=bayesTA.GetData().Select("TenThuocTinh='"+ColName+"'");
            DataTable dtBayes = bayesTA.GetData();
            DataTable dtSetTemp = dataSetTempTA.GetData();
            dtBayes.Clear();
            int iCount=0;
            foreach (DataRow bayesRow in bayesRows)
            {
                String tenThuocTinh = bayesRow[1].ToString();
                String khoangRoiRac = bayesRow[2].ToString();
                Boolean tieuDuong = Convert.ToBoolean(bayesRow[4]);
                int tongSoLuong = 0;
                String iQuery = "" + tenThuocTinh + "='" + khoangRoiRac + "' and TieuDuong=" + tieuDuong + "";
                tongSoLuong = dtSetTemp.Select(iQuery).Count();
                DataRow newRow = dtBayes.NewRow();
                iCount++;
                newRow[0] = iCount;
                newRow[1] = tenThuocTinh;
                newRow[2] = khoangRoiRac;
                newRow[3] = tongSoLuong;
                newRow[4] = tieuDuong;
                dtBayes.Rows.Add(newRow);
            }
            viewThongKe.DataSource = dtBayes;
            viewThongKe.Columns[0].Visible = true;
            bindingSourceThongKe.DataSource = dtBayes;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
