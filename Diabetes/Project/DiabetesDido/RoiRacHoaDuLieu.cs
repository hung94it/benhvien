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
            // TODO: This line of code loads data into the 'diabetesDataSet.DataSetTemp' table. You can move, or remove it, as needed.
            this.dataSetTempTableAdapter.Fill(this.diabetesDataSet.DataSetTemp);
            cboThuocTinh.Items.Clear();
            cboThuocTinh.SelectedIndex = -1;
            DataTable dataSetTempTalbe = dataSetTempTableAdapter.GetData();
            for (int i = 0; i < dataSetTempTalbe.Columns.Count - 1; i++)
            {
                if (i > 1)
                    cboThuocTinh.Items.Add(dataSetTempTalbe.Columns[i].ColumnName);
            }
            lblDoLechChuan.Text = lblDoLechChuan.Text + " 0";
            lblLonNhat.Text = lblLonNhat.Text + " 0";
            lblNhoNhat.Text = lblNhoNhat.Text + " 0";
            lblTrungBinh.Text = lblTrungBinh.Text + " 0";
        }

        private void RoiRacHoaDuLieu_FormClosed(object sender, FormClosedEventArgs e)
        {
            TienXuDuLieu tienXuDuLieu = new TienXuDuLieu();
            tienXuDuLieu.Show();
        }

        private void cboThuocTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            DiabetesDido.DAL.DiabetesDataSetTableAdapters.DataSetTableAdapter dataSetTA = new DiabetesDido.DAL.DiabetesDataSetTableAdapters.DataSetTableAdapter();
            DataTable dt = dataSetTA.GetData();
            decimal giaTriTrungBinh = 0;
            decimal doLechChuan = 0;
            decimal giaTriLonNhat = 0;
            decimal giaTriNhoNhat = 0;
            txtKhoang.Text = "";
            if (cboThuocTinh.SelectedIndex <2)
            {
                lblDoLechChuan.Text = "Độ lệch chuẩn: 0";
                lblLonNhat.Text = "Giá trị lớn nhất: 0";
                lblNhoNhat.Text = "Giá trị nhỏ nhất: 0";
                lblTrungBinh.Text = "Giá trị trung bình: 0";
                btnRoiRacHoa.Enabled = false;
            }
            else
            {
                btnRoiRacHoa.Enabled = true;
                String colName = cboThuocTinh.Text;
                doLechChuan = Convert.ToDecimal(dt.Compute("STDEV(" + colName + ")", string.Empty));
                doLechChuan = Math.Round(doLechChuan, 3);
                giaTriTrungBinh = Convert.ToDecimal(dt.Compute("avg(" + colName + ")", string.Empty));
                giaTriTrungBinh = Math.Round(giaTriTrungBinh, 3);
                giaTriLonNhat = Convert.ToInt16(dt.Compute("max(" + colName + ")", string.Empty));
                giaTriNhoNhat = Convert.ToInt16(dt.Compute("min(" + colName + ")", string.Empty));

                lblDoLechChuan.Text = "Độ lệch chuẩn: " + doLechChuan.ToString();
                lblLonNhat.Text = "Giá trị lớn nhất: " + giaTriLonNhat.ToString();
                lblNhoNhat.Text = "Giá trị nhỏ nhất: " + giaTriNhoNhat.ToString();
                lblTrungBinh.Text = "Giá trị trung bình: " + giaTriTrungBinh.ToString();
            }
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
                DiabetesDido.DAL.DiabetesDataSetTableAdapters.DataSetTableAdapter dataSetTA = new DiabetesDido.DAL.DiabetesDataSetTableAdapters.DataSetTableAdapter();
                DiabetesDido.DAL.DiabetesDataSetTableAdapters.DataSetTempTableAdapter dataSetTempTA= new DiabetesDido.DAL.DiabetesDataSetTableAdapters.DataSetTempTableAdapter();
                DiabetesDido.DAL.DiabetesDataSetTableAdapters.BayesObjectTableAdapter dataBayesTA = new DiabetesDido.DAL.DiabetesDataSetTableAdapters.BayesObjectTableAdapter();
                DataTable dataSetTable=dataSetTA.GetData();
                Function function = new Function();
                int dataSetColIndex = dataSetTable.Columns.IndexOf(colName);

                dataBayesTA.DeleteByOne(colName);
                foreach (DataRow dtRow in dataSetTable.Rows)
                {
                    decimal giaTri = Convert.ToDecimal(dtRow[dataSetColIndex]);
                    decimal id = Convert.ToDecimal(dtRow[0]);
                    String giaTriRoiRac = Function.TinhGiaTriRoiRac(giaTri, colName, khoangRoiRac);
                    decimal maBN = Convert.ToDecimal(dtRow[1]);
                    String tieuDuong = dtRow[5].ToString();
                    Function.CapNhapDataSetTemp(dataSetTempTA, maBN, colName, giaTriRoiRac);

                }
                Function.TaoBayesObject(colName, khoangRoiRac);

                this.dataSetTempTableAdapter.Fill(this.diabetesDataSet.DataSetTemp);
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            DiabetesDido.DAL.DiabetesDataSetTableAdapters.DataSetTableAdapter dataSetTA = new DiabetesDido.DAL.DiabetesDataSetTableAdapters.DataSetTableAdapter();
        }     
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            if (cboThuocTinh.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn thuộc tính để xem thống kê", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                String colName = cboThuocTinh.Text;
                ThongKeDuLieuRoiRac thongKe = new ThongKeDuLieuRoiRac(colName);
                thongKe.Show();
            }
        }

        private void dataSetTempBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.dataSetTempBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.diabetesDataSet);

        }
    }
}
