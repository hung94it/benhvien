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
    public partial class TienXuDuLieu : Form
    {
        public TienXuDuLieu()
        {
            InitializeComponent();
        }

        private void dataSetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dataSetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.diabetesDataSet);

        }

        private void TienXuDuLieu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'diabetesDataSet.DataSet' table. You can move, or remove it, as needed.
            this.dataSetTableAdapter.Fill(this.diabetesDataSet.DataSet);

        }

        private void btnLamSachDuLieu_Click(object sender, EventArgs e)
        {
            Function xuLy = new Function();
            List<decimal> danhSachTrungLap = new List<decimal>();
            int tongBoDuLieu=dataSetTableAdapter.GetData().Count;
            xuLy.LamSachDuLieu(dataSetTableAdapter.GetData(), danhSachTrungLap);
            for (int i = 0; i < danhSachTrungLap.Count; i++)
            {
                MessageBox.Show(danhSachTrungLap[i].ToString());
            }
            MessageBox.Show("Số bộ dữ liệu đã quét: " + tongBoDuLieu.ToString() + "\nSố bộ dữ liệu trùng lặp: " + danhSachTrungLap.Count.ToString(), "Kết quả làm sạch dữ liệu", MessageBoxButtons.OK,MessageBoxIcon.Information);
            
        }
    }
}
