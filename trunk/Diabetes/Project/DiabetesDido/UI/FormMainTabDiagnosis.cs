using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DiabetesDido.DAL.DiabetesDataSetBTableAdapters;
using DiabetesDido.ClassificationLogic;
using Accord.Math;
using System.Data.OleDb;
using System.Windows.Forms;

namespace DiabetesDido.UI
{
    public partial class FormMain
    {

        Function function = new Function();
        static DAL.DiabetesDataSetTableAdapters.DataSetTableAdapter datasetTA = new DAL.DiabetesDataSetTableAdapters.DataSetTableAdapter();
        static DAL.DiabetesDataSetTableAdapters.DataSetTempTableAdapter datasetTempTA = new DAL.DiabetesDataSetTableAdapters.DataSetTempTableAdapter();
        static DAL.DiabetesDataSetTableAdapters.BayesObjectTableAdapter bayesObjectTA = new DAL.DiabetesDataSetTableAdapters.BayesObjectTableAdapter();
        static DataTable dtForDiagnosis = new DataTable();

        public void InitializeTabDiagnosis()
        {
            
        }

        private void buttonXDiagnosis_Click(object sender, EventArgs e)
        {
            TrainningData trainningData = new TrainningData(this.trainningDataTableAdapter.GetData());

            int[,] result = new int[trainningData.TrainningAttributes.GetLength(0), 0];

            foreach (var model in this.modelList)
            {
                //int[] temp = model.Value.ComputeModel(trainningData.TrainningAttributes);
                //result = result.InsertColumn<int>(temp);
                result = result.InsertColumn<int>(model.Value.ComputeModel(trainningData.TrainningAttributes));
            }
            this.dataGridViewXDiagnosisResult.DataSource = result.ToDouble().ToTable();
        }
        private void buttonXImportData_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            textBoxXFilePath.Text = ofd.ShowDialog() == DialogResult.OK ? ofd.FileName : "";
            if (!ValidInput(textBoxXFilePath.Text))
                return;
            dtForDiagnosis = ReadDataFromExcelFile(textBoxXFilePath.Text);
            dataGridViewXDiagnosis.DataSource = dtForDiagnosis;
        }
        //Hàm dùng để kiếm tra đường dẫn tới file excel
        private bool ValidInput(String filePath)
        {
            if (filePath.Trim() == "")
            {
                MessageBox.Show("Chưa chọn tập tin cần nạp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //MessageBox.Show(ex.ToString());
                return false;
            }
            return true;
        }
        //Hàm dùng để đọc file excel ** Lưu ý: Chỉ đọc file .xls
        private DataTable ReadDataFromExcelFile(String filePath)
        {
            string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + filePath.Trim() + ";Extended Properties=Excel 8.0";
            // Tạo đối tượng kết nối
            OleDbConnection oledbConn = new OleDbConnection(connectionString);
            DataTable data = null;
            try
            {
                // Mở kết nối
                oledbConn.Open();

                // Tạo đối tượng OleDBCommand và query data từ sheet có tên "Sheet1"
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM [Sheet1$]", oledbConn);

                // Tạo đối tượng OleDbDataAdapter để thực thi việc query lấy dữ liệu từ tập tin excel
                OleDbDataAdapter oleda = new OleDbDataAdapter();

                oleda.SelectCommand = cmd;

                // Tạo đối tượng DataSet để hứng dữ liệu từ tập tin excel
                DataSet ds = new DataSet();

                // Đổ đữ liệu từ tập excel vào DataSet
                oleda.Fill(ds);

                data = ds.Tables[0];
            }
            catch(Exception ex)
            {
                MessageBox.Show("Chương trình không đọc được dữ liệu!! Yêu cầu kiểm tra tập tin đã chọn!!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                //MessageBox.Show(ex.ToString());
            }
            finally
            {
                // Đóng chuỗi kết nối
                oledbConn.Close();
            }
            return data;
        }
        //Hàm dùng để rời rác hóa dataset trước khi thực hiện chẩn đoán
        public DataTable DataDiscretization(DataTable dt)
        {
            DataTable dtDataSetTemp = datasetTempTA.GetData();
            dtDataSetTemp.Clear();
            DataTable dtBayesObject = bayesObjectTA.GetData();
            int Count = 1;
            try
            {
                foreach (DataRow dtRow in dt.Rows)
                {
                    DataRow newRow = dtDataSetTemp.NewRow();
                    newRow[0] = Count;
                    foreach (DataColumn dtCol in dt.Columns)
                    {
                        String colName = dtCol.ColumnName;
                        int colIndex = dt.Columns.IndexOf(colName);
                        switch (colName)
                        {
                            //case "ID":
                            //    break;
                            case "MaBn":
                                newRow[colName] = dtRow[colName].ToString();
                                break;
                            //case "NgayKham":
                            //    break;
                            //case "HoTen":
                            //    break;
                            case "TieuDuong":
                                newRow[colName] = Convert.ToBoolean(dtRow[colName]);
                                break;
                            case "GioiTinh":
                                newRow[colName] = dtRow[colName].ToString();
                                break;
                            case "NamSinh":
                                int namSinh = Convert.ToInt16(dtRow[colName]);
                                int tuoiHienTai = DateTime.Now.Year - namSinh;
                                String Tuoi = function.RoiRacHoaTuoi(tuoiHienTai);
                                newRow["Tuoi"] = Tuoi;
                                break;
                            default:
                                decimal colValue = Convert.ToDecimal(dtRow[colName]);
                                //int khoang = Function.XacDinhKhoang(colName);
                                String giaTriRoiRac = Function.DataDiscretizationForDiagnosis(colValue, colName);
                                newRow[colName] = giaTriRoiRac;
                                break;
                        }
                    }
                    Count++;
                    dtDataSetTemp.Rows.Add(newRow);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return dtDataSetTemp;
        }
    }
}
