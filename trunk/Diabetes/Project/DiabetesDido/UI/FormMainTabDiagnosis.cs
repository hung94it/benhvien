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
        public void InitializeTabDiagnosis()
        {
            
        }

        // View diagnosis result
        private void buttonXDiagnosis_Click(object sender, EventArgs e)
        {
            if (this.modelList.Count < 1)
            {
                MessageBox.Show("Chưa có mô hình!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }            

            if (this.dataGridViewXDiagnosis.DataSource != null)
            {
                if (this.trainningDataTabDianosis == null)                
                {
                    this.dataGridViewXDiagnosis.DataSource = DiscretizationData
                        .DataDiscretizationForDiagnosis(this.dataGridViewXDiagnosis.DataSource as DataTable);                    
                }
            }
            else {
                MessageBox.Show("Chưa có dữ liệu để chuẩn đoán", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            DataTable diagnosisDataTable = (this.dataGridViewXDiagnosis.DataSource as DataTable)
                .DefaultView.ToTable(false, TableMetaData.AllAttributes);
            this.trainningDataTabDianosis = new TrainningData(diagnosisDataTable, this.codification);
            
            DataTable resultTable = new DataTable();
            List<int[]> modelResults = new List<int[]>();
            string classColumnName = TableMetaData.ClassAttribute;
            DataRow row;

            // Add column
            foreach (var model in this.modelList)
            {
                if (model.Value.ToString() != "NaiveBayesS")
                {
                    resultTable.Columns.Add(model.Value.ToString(), typeof(String));
                    modelResults.Add(model.Value.ComputeModel(this.trainningDataTabDianosis.TrainningAttributes));
                }
            }            

            // Add row
            int columnIndex;
            for (int rowIndex = 0; rowIndex < modelResults[0].Length; rowIndex++)
            {                
                row = resultTable.NewRow();
                columnIndex = 0;
                foreach (DataColumn column in resultTable.Columns)
                {
                    row[column] = this.trainningDataTabDianosis.CodificationData
                        .Translate(classColumnName, modelResults[columnIndex++][rowIndex]);                    
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
            }
        }

        private void dataGridViewXDiagnosisResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = this.dataGridViewXDiagnosisResult.SelectedRows[0].Index;
            this.dataGridViewXDiagnosis.Rows[rowIndex].Selected = true;
        }

        // View rule at selected row
        private void buttonXGetRule_Click(object sender, EventArgs e)
        {
            if (!canGetRule())
            {
                return;
            }

            int rowIndex = this.dataGridViewXDiagnosis.CurrentCell.RowIndex;
            ClassificationModel treeModel = this.modelList[LearningAlgorithm.C45];
            textBoxXDiagnosis.Text = Compute(this.trainningDataTabDianosis.TrainningAttributes[rowIndex]
                , (treeModel as C45Model).Tree);            
        }

        private bool canGetRule()
        {
            if (this.dataGridViewXDiagnosis.DataSource == null)
            {
                MessageBox.Show("Chưa có dữ liệu",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (this.dataGridViewXDiagnosisResult.DataSource == null)
            {
                MessageBox.Show("Dữ liệu chưa rời rạc",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!this.modelList.ContainsKey(LearningAlgorithm.C45))
            {
                MessageBox.Show("Chưa có mô hình C45!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
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
                    // This is a leaf node. The decision proccess thus should stop here.                    
                    return rule.Trim();
                }

                // This node is not a leaf. Continue the decisioning proccess following the childs
                // Get the next attribute to guide reasoning
                int attribute = current.Branches.AttributeIndex;

                // Check which child is responsible for dealing which the particular value of the attribute
                DecisionNode nextNode = null;                

                foreach (DecisionNode branch in current.Branches)
                {
                    if (branch.Compute(input[attribute]))
                    {
                        // This is the child node responsible for dealing which this particular attribute value. Choose it
                        // to continue reasoning.

                        nextNode = branch;
                        attributeName = nextNode.Owner.Attributes[nextNode.Parent.Branches.AttributeIndex].Name;
                        attributeValue = this.trainningDataTabDianosis.CodificationData.Translate(attributeName,
                            Convert.ToInt32(nextNode.Value));
                        rule += attributeName + "=" + attributeValue + " ";                        
                        break;
                    }
                }                
                current = nextNode;
            }

            // Normal execution should not reach here.
            throw new InvalidOperationException("The tree is degenerated.");
        }

        private void buttonXViewTreeRule_Click(object sender, EventArgs e)
        {
            if (!canGetRule())
            {
                return;
            }

            int rowIndex = this.dataGridViewXDiagnosis.CurrentCell.RowIndex;
            ClassificationModel treeModel = this.modelList[LearningAlgorithm.C45];
            textBoxXDiagnosis.Text = Compute(this.trainningDataTabDianosis.TrainningAttributes[rowIndex]
                , (treeModel as C45Model).Tree);
            (new FormTreeRule((treeModel as C45Model).Tree, this.trainningDataTabDianosis.CodificationData,
                textBoxXDiagnosis.Text)).Show();

        }

        private void buttonXImportData_Click(object sender, EventArgs e)
        {
            this.dataGridViewXDiagnosis.DataSource = null;
            this.dataGridViewXDiagnosisResult.DataSource = null;

            this.openFileDialogMain.Filter = "Excel file (*.xls)|*.xls";

            if (this.openFileDialogMain.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            this.textBoxXFilePathDiagnosis.Text = this.openFileDialogMain.FileName;            

            this.dataGridViewXDiagnosis.DataSource = ReadDataFromExcelFile(this.openFileDialogMain.FileName);
                      
            dataGridViewXDiagnosis.Columns["TieuDuong"].Visible = false;
            dataGridViewXDiagnosis.Columns["GRAN"].Visible = false;
            dataGridViewXDiagnosis.Columns["TyLeGRAN"].Visible = false;
            dataGridViewXDiagnosis.Columns["Na"].Visible = false;
            dataGridViewXDiagnosis.Columns["K"].Visible = false;
            dataGridViewXDiagnosis.Columns["Ca"].Visible = false;
            dataGridViewXDiagnosis.Columns["Cl"].Visible = false;

            this.trainningDataTabDianosis = null;            
        }

        //Hàm dùng để đọc file excel ** Lưu ý: Chỉ đọc file .xls
        private DataTable ReadDataFromExcelFile(String filePath)
        {
            string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + filePath.Trim() 
                + ";Extended Properties=Excel 8.0";
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
            catch(Exception)
            {
                MessageBox.Show("Chương trình không đọc được dữ liệu!! Yêu cầu kiểm tra tập tin đã chọn!!"
                    ,"Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
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
            DiabetesDataSetB.TrainningDataTable trainningDataTable = new DiabetesDataSetB.TrainningDataTable();
            trainningDataTable.Columns.Add("MaBn", typeof(decimal));
            trainningDataTable.Columns["MaBn"].SetOrdinal(0);

            DataTable dtBayesObject = bayesObjectTA.GetData();

            try
            {
                foreach (DataRow dtRow in dt.Rows)
                {
                    DataRow newRow = trainningDataTable.NewRow();
                    
                    foreach (DataColumn dtCol in dt.Columns)
                    {
                        String colName = dtCol.ColumnName;        
                
                        switch (colName)
                        {
                            case "ID":                            
                            case "NgayKham":
                            case "HoTen":
                            case "GRAN":
                            case "TyLeGRAN":
                            case "Na":
                            case "K":
                            case "Cl":
                            case "Ca":
                                break;
                            case "MaBn":
                                newRow[colName] = dtRow[colName];
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
                                String Tuoi = DiscretizationData.RoiRacHoaTuoi(tuoiHienTai);
                                newRow["Tuoi"] = Tuoi;
                                break;
                            default:
                                decimal colValue = Convert.ToDecimal(dtRow[colName]);                                
                                String giaTriRoiRac = DiscretizationData.DataDiscretizationForDiagnosis(colValue, colName);
                                newRow[colName] = giaTriRoiRac;
                                break;
                        }
                    }                    
                    trainningDataTable.Rows.Add(newRow);
                }
            }            
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
           
            return trainningDataTable;
        }
    }
}
