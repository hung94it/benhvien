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
    public partial class RoiRacHoaDuLieu : Form
    {
        public RoiRacHoaDuLieu()
        {
            InitializeComponent();
        }

        private void dataSetTempBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dataSetTempBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.diabetesDataSet);

        }

        private void RoiRacHoaDuLieucs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'diabetesDataSet.DataSetTemp' table. You can move, or remove it, as needed.
            this.dataSetTempTableAdapter.Fill(this.diabetesDataSet.DataSetTemp);
            cboThuocTinh.Items.Clear();
            cboThuocTinh.SelectedIndex = -1;
            DataTable dataSetTempTalbe = dataSetTempTableAdapter.GetData();
            for (int i = 0; i < dataSetTempTalbe.Columns.Count; i++)
            {
                if (i > 4)
                    cboThuocTinh.Items.Add(dataSetTempTalbe.Columns[i].ColumnName);
            }
        }

        private void RoiRacHoaDuLieu_FormClosed(object sender, FormClosedEventArgs e)
        {
            TienXuDuLieu tienXuDuLieu = new TienXuDuLieu();
            tienXuDuLieu.Show();
        }

        private void cboThuocTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtKhoang.Text = "";
        }

        private void btnRoiRacHoa_Click(object sender, EventArgs e)
        {
            if (cboThuocTinh.SelectedIndex == -1 || txtKhoang.Text == "" || txtKhoang.Text =="0")
            {
                MessageBox.Show("Bạn chưa chọn cột hoặc chưa nhập giá trị khoảng","Thiếu dữ liệu",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                String colName = cboThuocTinh.Text;
                int khoangRoiRac = Convert.ToInt16(txtKhoang.Text);
                DiabetesDataSetTableAdapters.DataSetTableAdapter dataSetTA = new DiabetesDataSetTableAdapters.DataSetTableAdapter();
                DiabetesDataSetTableAdapters.DataSetTempTableAdapter dataSetTempTA= new DiabetesDataSetTableAdapters.DataSetTempTableAdapter();
                DataTable dataSetTable=dataSetTA.GetData();
                Function function = new Function();
                decimal giaTriTrungBinh = function.TinhTrungBinhKhoang(dataSetTable, colName, khoangRoiRac);
                int dataSetColIndex = dataSetTable.Columns.IndexOf(colName);
                prBar.Minimum = 1;
                prBar.Maximum = dataSetTable.Rows.Count;
                foreach (DataRow dtRow in dataSetTable.Rows)
                {
                    decimal giaTri = Convert.ToDecimal(dtRow[dataSetColIndex]);
                    String giaTriRoiRac = function.TinhGiaTriRoiRac(giaTri, giaTriTrungBinh, khoangRoiRac);
                    decimal maBN = Convert.ToDecimal(dtRow[1]);
                    function.CapNhapBangSauKhiRoiRacHoa(dataSetTempTA, maBN, colName, giaTriRoiRac);
                    prBar.Minimum++;
                }
                prBar.Refresh();
                this.dataSetTempTableAdapter.Fill(this.diabetesDataSet.DataSetTemp);
            }
        }

    }
}
