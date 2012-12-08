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
            DiabetesDataSetTableAdapters.DataSetTableAdapter dataSetTA = new DiabetesDataSetTableAdapters.DataSetTableAdapter();
            DataTable dt = dataSetTA.GetData();
            decimal giaTriTrungBinh = 0;
            decimal doLechChuan = 0;
            decimal giaTriLonNhat = 0;
            decimal giaTriNhoNhat = 0;
            txtKhoang.Text = "";
            if (cboThuocTinh.SelectedIndex == -1)
            {
                lblDoLechChuan.Text = lblDoLechChuan.Text + " 0";
                lblLonNhat.Text = lblLonNhat.Text + " 0";
                lblNhoNhat.Text = lblNhoNhat.Text + " 0";
                lblTrungBinh.Text = lblTrungBinh.Text + " 0";
            }
            else
            {
                String colName = cboThuocTinh.Text;
                doLechChuan = Convert.ToDecimal(dt.Compute("STDEV("+colName+")",string.Empty));
                doLechChuan = Math.Round(doLechChuan, 3);
                giaTriTrungBinh=Convert.ToDecimal(dt.Compute("avg("+colName+")",string.Empty));
                giaTriTrungBinh = Math.Round(giaTriTrungBinh, 3);
                giaTriLonNhat = Convert.ToInt16(dt.Compute("max("+colName+")", string.Empty));
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
                DiabetesDataSetTableAdapters.DataSetTableAdapter dataSetTA = new DiabetesDataSetTableAdapters.DataSetTableAdapter();
                DiabetesDataSetTableAdapters.DataSetTempTableAdapter dataSetTempTA= new DiabetesDataSetTableAdapters.DataSetTempTableAdapter();
                DiabetesDataSetTableAdapters.BayesObjectTableAdapter dataBayesTA = new DiabetesDataSetTableAdapters.BayesObjectTableAdapter();
                DataTable dataSetTable=dataSetTA.GetData();
                Function function = new Function();
                int dataSetColIndex = dataSetTable.Columns.IndexOf(colName);
                prBar.Minimum = 1;
                prBar.Maximum = dataSetTable.Rows.Count;
                dataBayesTA.DeleteByOne(colName);
                foreach (DataRow dtRow in dataSetTable.Rows)
                {
                    decimal giaTri = Convert.ToDecimal(dtRow[dataSetColIndex]);
                    decimal id = Convert.ToDecimal(dtRow[0]);
                    String giaTriRoiRac = Function.TinhGiaTriRoiRac(giaTri, colName, khoangRoiRac);
                    decimal maBN = Convert.ToDecimal(dtRow[1]);
                    Boolean tieuDuong = Convert.ToBoolean(dtRow[5]);
                    Function.CapNhapDataSetTemp(dataSetTempTA, maBN, colName, giaTriRoiRac);
                    prBar.Minimum++;
                }
                Function.TaoBayesObject(colName, khoangRoiRac);
                prBar.Refresh();
                this.dataSetTempTableAdapter.Fill(this.diabetesDataSet.DataSetTemp);
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            DiabetesDataSetTableAdapters.DataSetTableAdapter dataSetTA = new DiabetesDataSetTableAdapters.DataSetTableAdapter();
        }

        private void btnChiaDuLieu_Click(object sender, EventArgs e)
        {
            Function function = new Function();
            if (txtPhanTramDuLieu.Text == "")
            {
                MessageBox.Show("Chưa nhập lượng dữ liệu cần chia", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int phanTramDuLieu = Convert.ToInt16(txtPhanTramDuLieu.Text);
                DiabetesDataSetTableAdapters.TrainingSetTableAdapter trainingSetTA = new DiabetesDataSetTableAdapters.TrainingSetTableAdapter();
                if (trainingSetTA.GetData().Count > 0)
                {
                    DialogResult dR = MessageBox.Show("Hiện đã có một tập dữ liệu huấn luyện trong Cơ sở dữ liệu. Bạn có muốn thay mới?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dR == DialogResult.Yes)
                    {
                        function.ChiaDuLieu(phanTramDuLieu);
                        MessageBox.Show("Chia dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    function.ChiaDuLieu(phanTramDuLieu);
                    MessageBox.Show("Chia dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            txtPhanTramDuLieu.Text = "";
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

        private void btnHuyenLuyen_Click(object sender, EventArgs e)
        {
            DuLieuHuanLuyen huanLuyen = new DuLieuHuanLuyen();
            huanLuyen.Show();
        }

    }
}
