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
    public partial class DuLieuHuanLuyen : Form
    {
        public DuLieuHuanLuyen()
        {
            InitializeComponent();
        }

        private void trainingSetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.trainingSetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.diabetesDataSet);

        }

        private void DuLieuHuanLuyen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'diabetesDataSet.TrainingSet' table. You can move, or remove it, as needed.
            this.trainingSetTableAdapter.Fill(this.diabetesDataSet.TrainingSet);
            DiabetesDido.DAL.DiabetesDataSetTableAdapters.TrainingSetTableAdapter trainingSetTA = new DiabetesDido.DAL.DiabetesDataSetTableAdapters.TrainingSetTableAdapter();
            DataTable dt = trainingSetTA.GetData();
            int soThuocTinh = dt.Columns.Count;
            int soMacBenh = dt.Select("TieuDuong=True").Count();
            int soKhongMacBenh = dt.Rows.Count - soMacBenh;
            lblKhongMacBenh.Text = "Số bệnh nhân không mắc bệnh: " + soKhongMacBenh.ToString();
            lblMacBenh.Text = "Số bệnh nhân mắc bệnh: " + soMacBenh.ToString();
            lblSoThuocTinh.Text = "Số thuộc tính: " + soThuocTinh.ToString();
        }
    }
}
