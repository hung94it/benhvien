using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DiabetesDido.ClassificationLogic;

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
            List<decimal> danhSachTrungLap = new List<decimal>();
            int tongBoDuLieu=dataSetTableAdapter.GetData().Count;
            Function.LamSachDuLieu(dataSetTableAdapter.GetData(), danhSachTrungLap);
            for (int i = 0; i < danhSachTrungLap.Count; i++)
            {
                dataSetTableAdapter.DeleteData(danhSachTrungLap[i]);
            }
            MessageBox.Show("Số bộ dữ liệu đã quét: " + tongBoDuLieu.ToString() + "\nSố bộ dữ liệu trùng lặp: " + danhSachTrungLap.Count.ToString(), "Kết quả làm sạch dữ liệu", MessageBoxButtons.OK,MessageBoxIcon.Information);
            this.tableAdapterManager.UpdateAll(this.diabetesDataSet);
        }

        private void btnRoiRacHoa_Click(object sender, EventArgs e)
        {
            RoiRacHoaDuLieu roiRacHoaDuLieu = new RoiRacHoaDuLieu();
            DiabetesDido.DAL.DiabetesDataSetTableAdapters.DataSetTempTableAdapter dataSetTempTA = new DiabetesDido.DAL.DiabetesDataSetTableAdapters.DataSetTempTableAdapter();
            //int convert to int16??
            int iCount = Convert.ToInt16(dataSetTempTA.GetData().Rows.Count);
            if (iCount > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Hiện đã có một bảng dữ liệu đã được rời rạc hóa sẵn. Bạn có muốn tiếp tục với bảng dữ liệu này không?", "Thông báo", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.No)
                {
                    dataSetTempTA.DeleteAllData();
                    DiabetesDido.DAL.DiabetesDataSetTableAdapters.DataSetTableAdapter dataSetTA = new DiabetesDido.DAL.DiabetesDataSetTableAdapters.DataSetTableAdapter();
                    DataTable dataSetTable = dataSetTA.GetData();
                    foreach (DataRow i in dataSetTable.Rows)
                    {
                        decimal namSinh = DateTime.Now.Year - Convert.ToDecimal(i[3]);
                        String doTuoi = "";                        
                        doTuoi = Function.RoiRacHoaTuoi(namSinh);
                        dataSetTempTA.Insert(Convert.ToDecimal(i[1]), doTuoi, i[5].ToString(), i[6].ToString(),i[7].ToString(),i[8].ToString(),i[9].ToString(),i[10].ToString(),i[11].ToString(),i[12].ToString(),i[13].ToString(),i[14].ToString(),i[15].ToString(),i[16].ToString(),i[17].ToString(),i[18].ToString(),i[19].ToString(),i[20].ToString(),i[21].ToString(),i[22].ToString(),i[23].ToString(),i[24].ToString(),i[25].ToString(),i[26].ToString(),i[27].ToString(),i[28].ToString(),i[29].ToString(),i[30].ToString(),i[31].ToString(),i[32].ToString(),i[33].ToString(),i[34].ToString(),i[35].ToString(),i[36].ToString());
                    }
                }
            }
            else
            {
                DiabetesDido.DAL.DiabetesDataSetTableAdapters.DataSetTableAdapter dataSetTA = new DiabetesDido.DAL.DiabetesDataSetTableAdapters.DataSetTableAdapter();
                DataTable dataSetTable = dataSetTA.GetData();
                foreach (DataRow i in dataSetTable.Rows)
                {
                    decimal namSinh = DateTime.Now.Year - Convert.ToDecimal(i[3]);
                    String doTuoi = "";                    
                    doTuoi = Function.RoiRacHoaTuoi(namSinh);
                    dataSetTempTA.Insert(Convert.ToDecimal(i[1]), doTuoi, i[5].ToString(), i[6].ToString(), i[7].ToString(), i[8].ToString(), i[9].ToString(), i[10].ToString(), i[11].ToString(), i[12].ToString(), i[13].ToString(), i[14].ToString(), i[15].ToString(), i[16].ToString(), i[17].ToString(), i[18].ToString(), i[19].ToString(), i[20].ToString(), i[21].ToString(), i[22].ToString(), i[23].ToString(), i[24].ToString(), i[25].ToString(), i[26].ToString(), i[27].ToString(), i[28].ToString(), i[29].ToString(), i[30].ToString(), i[31].ToString(), i[32].ToString(), i[33].ToString(), i[34].ToString(), i[35].ToString(), i[36].ToString());
                }
            }
            this.Hide();
            roiRacHoaDuLieu.Show();
        }

        private void dataSetBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.dataSetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.diabetesDataSet);
        }
    }
}
