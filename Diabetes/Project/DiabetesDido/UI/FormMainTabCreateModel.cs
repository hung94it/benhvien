using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using DevComponents.DotNetBar.Controls;
using DiabetesDido.ClassificationLogic;
using DiabetesDido.DAL.DiabetesDataSetBTableAdapters;
using Accord.Statistics.Filters;
using DiabetesDido.DAL;

namespace DiabetesDido.UI
{
    public partial class FormMain
    {
        public void InitializeTabCreateModel()
        {
            this.checkBoxXNaiveBayes.Checked = true;
            this.activeLearningAlgorithm = LearningAlgorithm.NaiveBayes;
            this.modelList = new Dictionary<LearningAlgorithm, ClassificationModel>();

            refreshTabCreateModel();

            List<Percent> percent = new List<Percent>();
            //percent.Add(new Percent("50%", 50));
            //percent.Add(new Percent("60%", 60));
            percent.Add(new Percent("70%", 70));
            percent.Add(new Percent("80%", 80));
            percent.Add(new Percent("90%", 90));
            percent.Add(new Percent("100%", 0));

            comboBoxExTrainningDataPercent.DataSource = percent;
            comboBoxExTrainningDataPercent.DisplayMember = "Name";
            comboBoxExTrainningDataPercent.ValueMember = "Value";
            if (this.comboBoxExTrainningDataPercent.Items.Count > 0)
            {
                this.comboBoxExTrainningDataPercent.SelectedIndex = 0;
            }
        }

        private void refreshTabCreateModel()
        {
            this.dataGridViewXTrainning.DataSource = this.trainningTableAdapter.GetData();
        }

        // buttonXCreateModel click event
        private void buttonXCreateModel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            DataTable orginalTrainningTable = this.dataGridViewXTrainning.DataSource as DataTable;
            DataTable tableForTrainning;
            int numberOfTrainningRows = 0;

            // Get number of row form percent
            if (this.comboBoxExTrainningDataPercent.SelectedValue != null)
            {
                numberOfTrainningRows = Convert.ToInt32(Math.Truncate(
                    ((int)comboBoxExTrainningDataPercent.SelectedValue * 1.0 * orginalTrainningTable.Rows.Count) / 100));
            }

            // Set trainning data
            if (numberOfTrainningRows == 0)
            {
                tableForTrainning = orginalTrainningTable;
            }
            else
            {
                var query = orginalTrainningTable.AsEnumerable().Take(numberOfTrainningRows);
                tableForTrainning = query.CopyToDataTable<DataRow>();
            }

            TrainningData trainningData = new TrainningData(tableForTrainning, this.codification);

            Properties.Settings.Default.negativeValue = trainningData.NegativeValue;

            // Ask user what to do when selected model already exists
            if (this.HaveModel())
            {
                dialogResult = MessageBox.Show("Mô hình này đã có. Bạn có muốn tạo mô hình mới?", "Lỗi",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.No || dialogResult == DialogResult.Cancel)
                {
                    return;
                }
            }

            // Check dictionary already have active model. If not add new model
            if (!this.modelList.ContainsKey(this.activeLearningAlgorithm))
            {
                this.modelList.Add(this.activeLearningAlgorithm, ClassificationModel.CreateModel(this.activeLearningAlgorithm));
            }

            // Trainning model
            this.modelList[activeLearningAlgorithm].TrainningModel(trainningData);

        }

        // buttonXTestModel click event
        private void buttonXTestModel_Click(object sender, EventArgs e)
        {
            int numberOfTrainningRows = 0;
            DataTable orginalTrainningTable = this.dataGridViewXTrainning.DataSource as DataTable;
            DataTable testTable;

            // Get number of row form percent
            if (this.comboBoxExTrainningDataPercent.SelectedValue != null)
            {
                numberOfTrainningRows = Convert.ToInt32(Math.Truncate(
                    ((int)comboBoxExTrainningDataPercent.SelectedValue * 1.0 * orginalTrainningTable.Rows.Count) / 100));
            }

            // Set test data
            var query = orginalTrainningTable.AsEnumerable().Skip(numberOfTrainningRows);
            testTable = query.CopyToDataTable<DataRow>();

            if (!HaveModel())
            {
                MessageBox.Show("Chưa có mô hình!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            TrainningData data = new TrainningData(testTable, this.codification);
            // Show test result
            dataGridViewXTrainningResult.DataSource = this.modelList[activeLearningAlgorithm].TestModel(data);

            List<int> hideColumns = new List<int>(new int[] { 11, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 });

            for (int indexColum = 0; indexColum < this.dataGridViewXTrainningResult.Columns.Count; indexColum++)
            {
                if (hideColumns.Contains(indexColum))
                {
                    this.dataGridViewXTrainningResult.Columns[indexColum].Visible = false;
                }
            }
        }


        // buttonXViewModel click event
        private void buttonXViewModel_Click(object sender, EventArgs e)
        {
            if (this.modelList.ContainsKey(LearningAlgorithm.C45))
            {
                new FormTreeView((this.GetModel() as C45Model).Tree, this.codification).Show();
            }
            else
            {
                MessageBox.Show("Chưa có mô hình C4.5!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Get selected learning algorithm from user
        private void checkBoxXTabCreateModel_CheckedChanged(object sender, EventArgs e)
        {
            CheckBoxX checkedRadioButton = sender as CheckBoxX;

            // Ensure that the RadioButton.Checked property changed to true.             
            if (checkedRadioButton.Checked)
            {
                Enum.TryParse<LearningAlgorithm>(checkedRadioButton.Tag as string, out this.activeLearningAlgorithm);
            }
        }

        // Get active model
        public ClassificationModel GetModel()
        {
            return this.modelList[this.activeLearningAlgorithm];
        }

        // Check activeAlgorithm already have model or not
        public bool HaveModel()
        {
            if (!this.modelList.ContainsKey(this.activeLearningAlgorithm))
            {
                return false;
            }
            return (this.modelList[this.activeLearningAlgorithm] != null ? true : false);
        }

        private void buttonXSave_Click(object sender, EventArgs e)
        {
            // Check selected algothrim have model yet, if not return
            if (!HaveModel())
            {
                MessageBox.Show("Chưa có mô hình!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string fileName = this.modelList[this.activeLearningAlgorithm].ToString();

            saveFileDialogMain.FileName = fileName;
            DialogResult result = saveFileDialogMain.ShowDialog();

            if (result == DialogResult.OK)
            {
                Stream stream = saveFileDialogMain.OpenFile();
                IFormatter formatter = new BinaryFormatter();
                // Serialize active model to file stream
                formatter.Serialize(stream, this.modelList[this.activeLearningAlgorithm]);
                stream.Close();
            }
        }

        private void buttonXLoad_Click(object sender, EventArgs e)
        {
            this.openFileDialogMain.Filter = "Model file (*.model)|*model";
            DialogResult result = this.openFileDialogMain.ShowDialog();

            if (result == DialogResult.OK)
            {
                if (HaveModel())
                {
                    DialogResult dialogResult = MessageBox.Show("Mô hình này đã có. Bạn có muốn nạp mô hình mới?", "Lỗi",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.No || dialogResult == DialogResult.Cancel)
                    {
                        return;
                    }
                }

                IFormatter formatter = new BinaryFormatter();
                Stream stream = openFileDialogMain.OpenFile();
                this.modelList[this.activeLearningAlgorithm] = (ClassificationModel)formatter.Deserialize(stream);
                stream.Close();
            }
        }

        private DataTable getDataTableForCodification()
        {            
            int? maxRow = this.discreteIntervalTableAdapter.MaxRow();

            DiabetesDataSetB.TrainningDataTable dataTable = new DiabetesDataSetB.TrainningDataTable();

            DataRow newRow;
            DataTable attributeInterval;
            int indexLastColumn = dataTable.Columns.Count - 1;

            // Add max row
            for (int i = 0; i < maxRow; i++)
            {
                newRow = dataTable.NewRow();
                newRow[indexLastColumn] = TableMetaData.PositiveString;
                dataTable.Rows.Add(newRow);
            }

            // Add value for each column
            foreach (DataColumn column in dataTable.Columns)
            {
                attributeInterval = this.discreteIntervalTableAdapter.GetDataByTenThuocTinh(column.ColumnName);

                // Add value for each row
                for (int rowIndex = 0; rowIndex < dataTable.Rows.Count; rowIndex++)
                {
                    
                    if (rowIndex < attributeInterval.Rows.Count)
                    {
                        dataTable.Rows[rowIndex][column] = attributeInterval.Rows[rowIndex][1].ToString();
                    }
                    else
                    {
                        if (!column.ColumnName.Equals(TableMetaData.ClassAttribute))
                        {                            
                            dataTable.Rows[rowIndex][column] = attributeInterval.Rows[0][1].ToString();
                        }
                    }                    
                }
            }
            dataTable.Rows[0][indexLastColumn] = TableMetaData.NegativeString;            

            return dataTable;
        }

    }
}
