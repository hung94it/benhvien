using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Accord.MachineLearning.DecisionTrees;
using DiabetesDido.ClassificationLogic;
using DiabetesDido.DAL;

namespace DiabetesDido.UI
{
    public partial class FormMain
    {        
        static DAL.DiabetesDataSetTableAdapters.DataSetTableAdapter datasetTA = new DAL.DiabetesDataSetTableAdapters.DataSetTableAdapter();
        static DAL.DiabetesDataSetTableAdapters.DataSetTempTableAdapter datasetTempTA = new DAL.DiabetesDataSetTableAdapters.DataSetTempTableAdapter();
        static DAL.DiabetesDataSetTableAdapters.BayesObjectTableAdapter bayesObjectTA = new DAL.DiabetesDataSetTableAdapters.BayesObjectTableAdapter();
        static DataTable dtForDiagnosis = new DataTable();
        private TrainningData diagnosisData;

        public void InitializeTabDiagnosis()
        {            
            //this.dataGridViewXDiagnosis.DataSource = this.trainningDataTableAdapter.GetData();

            //this.diagnosisData = new TrainningData(this.dataGridViewXDiagnosis.DataSource as DataTable);
        }

        // View diagnosis result
        private void buttonXDiagnosis_Click(object sender, EventArgs e)
        {
            if (this.modelList.Count < 1)
            {
                MessageBox.Show("Chưa có mô hình!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataTable discreteDataTable;

            if (this.dataGridViewXDiagnosis.DataSource != null)
            {
                discreteDataTable = DataDiscretization(this.dataGridViewXDiagnosis.DataSource as DataTable);
                this.dataGridViewXDiagnosis.DataSource = discreteDataTable;
            }
            else {
                MessageBox.Show("Chưa có dữ liệu để chuẩn đoán", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.diagnosisData = new TrainningData(this.dataGridViewXDiagnosis.DataSource as DataTable);
            
            DataTable resultTable = new DataTable();
            List<int[]> modelResults = new List<int[]>();            
            string columnName = this.diagnosisData.LastColumnName;
            DataRow row;

            // Add column
            foreach (var model in this.modelList)
            {
                resultTable.Columns.Add(model.Value.ToString(), typeof(String));
                modelResults.Add(model.Value.ComputeModel(this.diagnosisData.TrainningAttributes));
            }            

            // Add row
            int columnIndex;
            for (int rowIndex = 0; rowIndex < modelResults[0].Length; rowIndex++)
            {                
                row = resultTable.NewRow();
                columnIndex = 0;
                foreach (DataColumn column in resultTable.Columns)
                {
                    row[column] = this.diagnosisData.CodificationData.Translate(columnName, modelResults[columnIndex++][rowIndex]);                    
                }
                resultTable.Rows.Add(row);
            }

            this.dataGridViewXDiagnosisResult.DataSource = resultTable;
        }

        // Scrolling two gridviews
        private void dataGridViewXDiagnosis_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.ScrollOrientation == ScrollOrientation.VerticalScroll)
            {
                int index = this.dataGridViewXDiagnosis.FirstDisplayedScrollingRowIndex;
                if (this.dataGridViewXDiagnosisResult.FirstDisplayedScrollingRowIndex != -1)
                {
                    this.dataGridViewXDiagnosisResult.FirstDisplayedScrollingRowIndex = index;
                }
            }
        }

        private void dataGridViewXDiagnosisResult_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.ScrollOrientation == ScrollOrientation.VerticalScroll)
            {
                int index = this.dataGridViewXDiagnosisResult.FirstDisplayedScrollingRowIndex;
                this.dataGridViewXDiagnosis.FirstDisplayedScrollingRowIndex = index;
            }
        }

        private void dataGridViewXDiagnosis_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataGridViewXDiagnosisResult.RowCount > 1)
            {
                int rowIndex = this.dataGridViewXDiagnosis.SelectedRows[0].Index;
                this.dataGridViewXDiagnosisResult.Rows[rowIndex].Selected = true;
                //this.dataGridViewXDiagnosisResult.Rows[0].Cells[0].
            }
        }

        // View rule at selected row
        private void buttonXGetRule_Click(object sender, EventArgs e)
        {            
            int rowIndex = this.dataGridViewXDiagnosis.CurrentCell.RowIndex;
            ClassificationModel treeModel;

            if (this.modelList.ContainsKey(LearningAlgorithm.C45))
            {
                treeModel = this.modelList[LearningAlgorithm.C45];
            }
            else
            {
                MessageBox.Show("Chưa có mô hình C45!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            textBoxXDiagnosis.Text = Compute(this.diagnosisData.TrainningAttributes[rowIndex], (treeModel as C45Model).Tree);
            
        }

        public string Compute(double[] input, DecisionTree tree)
        {
            DecisionNode Root = tree.Root;
            string attributeName;
            string attributeValue;
            string rule = "";

            if (Root == null)
                throw new InvalidOperationException();

            DecisionNode current = Root;

            // Start reasoning
            while (current != null)
            {
                // Check if this is a leaf
                if (current.IsLeaf)
                {
                    // This is a leaf node. The decision
                    // proccess thus should stop here.                    
                    return rule;
                }

                // This node is not a leaf. Continue the
                // decisioning proccess following the childs

                // Get the next attribute to guide reasoning
                int attribute = current.Branches.AttributeIndex;

                // Check which child is responsible for dealing
                // which the particular value of the attribute
                DecisionNode nextNode = null;                

                foreach (DecisionNode branch in current.Branches)
                {
                    if (branch.Compute(input[attribute]))
                    {
                        // This is the child node responsible for dealing
                        // which this particular attribute value. Choose it
                        // to continue reasoning.

                        nextNode = branch;
                        attributeName = nextNode.Owner.Attributes[nextNode.Parent.Branches.AttributeIndex].Name;
                        attributeValue = trainningData.CodificationData.Translate(attributeName, Convert.ToInt32(nextNode.Value));
                        rule += attributeName + " = " + attributeValue + " ";                        
                        break;
                    }
                }                

                current = nextNode;
            }

            // Normal execution should not reach here.
            throw new InvalidOperationException("The tree is degenerated.");
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
            DiabetesDataSetB.TrainningDataDataTable dtDataSetTemp = new DiabetesDataSetB.TrainningDataDataTable();
            DataTable dtBayesObject = bayesObjectTA.GetData();
            //int Count = 1;

            try
            {
                foreach (DataRow dtRow in dt.Rows)
                {
                    DataRow newRow = dtDataSetTemp.NewRow();
                    //newRow[0] = Count;
                    foreach (DataColumn dtCol in dt.Columns)
                    {
                        String colName = dtCol.ColumnName;
                        //int colIndex = dt.Columns.IndexOf(colName);
                        switch (colName)
                        {
                            case "ID":
                            case "MaBn":
                            case "NgayKham":
                            case "HoTen":
                            case "GRAN":
                            case "TyLeGRAN":
                            case "Na":
                            case "K":
                            case "Cl":
                            case "Ca":
                                break;                                
                            case "TieuDuong":
                                newRow[colName] = Convert.ToBoolean(dtRow[colName]);
                                break;
                            case "GioiTinh":
                                newRow[colName] = dtRow[colName].ToString();
                                break;
                            case "NamSinh":
                                int namSinh = Convert.ToInt16(dtRow[colName]);
                                int tuoiHienTai = DateTime.Now.Year - namSinh;
                                String Tuoi = Function.RoiRacHoaTuoi(tuoiHienTai);
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
                    //Count++;
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
