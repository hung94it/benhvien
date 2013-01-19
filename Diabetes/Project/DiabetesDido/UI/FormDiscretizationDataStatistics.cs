using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DiabetesDido.DAL.DiabetesDataSetTableAdapters;

namespace DiabetesDido.UI
{
    public partial class FormDiscretizationDataStatistics : DevComponents.DotNetBar.Metro.MetroForm
    {
        private String ColName = "";
        public FormDiscretizationDataStatistics()
        {
            InitializeComponent();
        }
        public FormDiscretizationDataStatistics(String colName)
        {
            InitializeComponent();
            this.ColName = colName;
        }
        private void FormDiscretizationDataStatistics_Load(object sender, EventArgs e)
        {
            BayesObjectTableAdapter bayesObjectTableAdapter=new BayesObjectTableAdapter();
            DataSetTempTableAdapter dataSetTempTableAdapter=new DataSetTempTableAdapter();
            DataTable dtBayes = bayesObjectTableAdapter.GetData();
            DataTable dtSetTemp = dataSetTempTableAdapter.GetData();
            DataRow[] bayesRows = bayesObjectTableAdapter.GetData().Select("TenThuocTinh='" + ColName + "'");
            dtBayes.Clear();
            int iCount=0;
            foreach (DataRow bayesRow in bayesRows)
            {
                
                String tenThuocTinh = bayesRow["TenThuocTinh"].ToString();
                String khoangRoiRac = bayesRow["KhoangRoiRac"].ToString();
                String tieuDuong = bayesRow["TieuDuong"].ToString();
                int tongSoLuong = 0;
                String iQuery = "" + tenThuocTinh + "='" + khoangRoiRac + "' and TieuDuong='" + tieuDuong + "'";
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
            dataGridViewXDiscretizationDataStatistics.DataSource = dtBayes;
            bindingSourceDiscretizationDataStatistics.DataSource=dtBayes;
            bindingNavigatorExDiscretizationDataStatistics.BindingSource = bindingSourceDiscretizationDataStatistics;
            dataGridViewXDiscretizationDataStatistics.Columns[0].Visible = true;
            dataGridViewXDiscretizationDataStatistics.Columns["GiaTri"].Name = "SoLuong";
        }
    }
}