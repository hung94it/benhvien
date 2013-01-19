using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Accord.Statistics.Analysis;
using Accord.Statistics.Filters;
using DiabetesDido.DAL.DiabetesDataSetBTableAdapters;
using DiabetesDido.DAL.DiabetesDataSetTableAdapters;
using Accord.Math;
using Accord.Controls;

namespace DiabetesDido.UI
{
    public partial class FormMain
    {
        private OrginalDataTableAdapter orginalDataTableAdapter;
        private DataTable orginalData;
        private DataTable dtDataSetTempForPreProcessing;
        private DataTable dtDataSetForPreProcessing;

        public void InitializeTabPreprocessingData()
        {


            this.orginalDataTableAdapter = new OrginalDataTableAdapter();
            this.bindingSourcePreprocessingData.DataSource = this.orginalDataTableAdapter.GetData();
            this.dataGridViewXPreProcessingData.DataSource = this.bindingSourcePreprocessingData;
            this.bindingNavigatorExPreprocessingData.BindingSource = this.bindingSourcePreprocessingData;

            buttonXDiscretizationDataStatistics.Enabled = false;
            buttonXDataDiscretizationRun.Enabled = false;
            integerInputIntervalDiscretization.Enabled = false;
            checkBoxXDiscreteAllColumn.Enabled = false;
            checkedListBoxColumnName.Enabled = false;
        }

        private void buttonXCleaningData_Click(object sender, EventArgs e)
        {
            this.orginalData = this.bindingSourcePreprocessingData.DataSource as DataTable;

            string[] columnNames = this.orginalData.Columns.Cast<DataColumn>().Select(column => column.ColumnName).ToArray();
                                                
            columnNames = columnNames.RemoveAt<string>(columnNames.Length - 1);

            // Remove rows which have null value
            Elimination elimination = new Elimination(columnNames);

            this.orginalData = elimination.Apply(this.orginalData);
            this.bindingSourcePreprocessingData.DataSource = this.orginalData;

            AnalysisData();
        }

        private void AnalysisData()
        {
            DescriptiveAnalysis analysis;
            string[] columnNames;

            double[,] arrayData = (this.orginalData.ToMatrix(out columnNames)).Submatrix<double>(null, 0, this.orginalData.Columns.Count - 2);

            columnNames = columnNames.RemoveAt<string>(columnNames.Length - 1);

            // Analysis Data
            analysis = new DescriptiveAnalysis(arrayData, columnNames);
            analysis.Compute();

            double[,] analysisData = new double[0, arrayData.GetLength(1)];

            analysisData = analysisData.InsertRow<double>(analysis.Distinct.ToDouble(), analysisData.GetLength(0));
            analysisData = analysisData.InsertRow<double>(analysis.Means, analysisData.GetLength(0));
            analysisData = analysisData.InsertRow<double>(analysis.Medians, analysisData.GetLength(0));
            analysisData = analysisData.InsertRow<double>(analysis.Modes, analysisData.GetLength(0));
            analysisData = analysisData.InsertRow<double>(analysis.StandardDeviations, analysisData.GetLength(0));
            analysisData = analysisData.InsertRow<double>(analysis.Variances, analysisData.GetLength(0));
            analysisData = analysisData.InsertRow<double>(analysis.Sums, analysisData.GetLength(0));
            
            string[] rowNames = { "Distinct", "Means", "Medians", "Modes", "StandardDeviations", "Variances", "Sums" };

            ArrayDataView arrayDataView = new ArrayDataView(analysisData, columnNames, rowNames);
            this.dataGridViewXDescriptiveData.DataSource = arrayDataView;
        }

        private void buttonXDiscretizationData_Click(object sender, EventArgs e)
        {
            ListBox listBoxSelectedField = new ListBox();
            dtDataSetForPreProcessing = datasetTA.GetData();
            int InputInterval = 0;//Biến dùng để chứa khoảng rời rạc mà người dùng nhập vào
            int Count = 0;//Biến dùng để kiếm tra xem người dùng có phải chỉ chọn 2 Field Tuoi & GioiTinh hay không
            int dataSetColIndex = 0;//Biến dùng để lưu lại index của Field cần rời rạc
            if (checkedListBoxColumnName.CheckedItems.Count == 0)
                MessageBox.Show("Chưa chọn thuộc tính để thực hiện rời rạc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                for (int i = 0; i < checkedListBoxColumnName.CheckedItems.Count; i++)
                {
                    String checkedValue = checkedListBoxColumnName.CheckedItems[i].ToString();
                    if (checkedValue != "Tuoi" && checkedValue != "GioiTinh")
                        listBoxSelectedField.Items.Add(checkedValue);
                    else
                        Count++;
                }
                if (Count == checkedListBoxColumnName.CheckedItems.Count)
                    MessageBox.Show("Thuộc tính Tuoi và GioiTinh không cần thực hiện rời rạc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    InputInterval = integerInputIntervalDiscretization.Value;
                    for (int i = 0; i < listBoxSelectedField.Items.Count; i++)
                    {
                        String colName = listBoxSelectedField.Items[i].ToString();
                        dataSetColIndex = dtDataSetForPreProcessing.Columns.IndexOf(colName);
                        bayesObjectTA.DeleteByOne(colName);

                        foreach (DataRow dtRow in dtDataSetForPreProcessing.Rows)
                        {
                            decimal currentValue = Convert.ToDecimal(dtRow[dataSetColIndex]);
                            decimal id = Convert.ToDecimal(dtRow[0]);
                            String discreteValue = Function.DataDiscretization(currentValue, colName, InputInterval);
                            decimal maBN = Convert.ToDecimal(dtRow[1]);
                            String tieuDuong = dtRow[36].ToString();
                            Function.CapNhapDataSetTemp(datasetTempTA, maBN, colName, discreteValue);
                        }
                        Function.TaoBayesObject(colName, InputInterval);
                    }
                }
                dtDataSetTempForPreProcessing.Clear();
                dtDataSetTempForPreProcessing = datasetTempTA.GetData();
                this.bindingSourcePreprocessingData.DataSource = this.dtDataSetTempForPreProcessing;
                this.dataGridViewXPreProcessingData.DataSource = this.dtDataSetTempForPreProcessing;
                this.bindingNavigatorExPreprocessingData.BindingSource = this.bindingSourcePreprocessingData;
            }
            
        }

        private void buttonXDataCleaningView_Click(object sender, EventArgs e)
        {
            this.bindingSourcePreprocessingData.DataSource = this.orginalDataTableAdapter.GetData();
            this.dataGridViewXPreProcessingData.DataSource = this.orginalDataTableAdapter.GetData();

            buttonXDataCleaningRun.Enabled = true;
            buttonXDataCleaningStatistics.Enabled = true;

            buttonXDiscretizationDataStatistics.Enabled = false;
            buttonXDataDiscretizationRun.Enabled = false;
            integerInputIntervalDiscretization.Enabled = false;
            checkBoxXDiscreteAllColumn.Enabled = false;
            checkedListBoxColumnName.Enabled = false;
        }


        private void buttonXDataCleaningStatistics_Click(object sender, EventArgs e)
        {
            this.AnalysisData();
        }

        private void buttonXDataDiscretizationDataView_Click(object sender, EventArgs e)
        {
            dtDataSetTempForPreProcessing = datasetTempTA.GetData();
            this.bindingSourcePreprocessingData.DataSource = this.dtDataSetTempForPreProcessing;
            this.dataGridViewXPreProcessingData.DataSource = this.dtDataSetTempForPreProcessing;
            this.bindingNavigatorExPreprocessingData.BindingSource = this.bindingSourcePreprocessingData;
            if (checkedListBoxColumnName.Items.Count > 0)
                checkedListBoxColumnName.Items.Clear();
            for (int i = 2; i < dtDataSetTempForPreProcessing.Columns.Count - 1; i++)
            {
                String colName = dtDataSetTempForPreProcessing.Columns[i].ColumnName;
                checkedListBoxColumnName.Items.Add(colName, false);
            }

            buttonXDataCleaningRun.Enabled = false;
            buttonXDataCleaningStatistics.Enabled = false;

            buttonXDiscretizationDataStatistics.Enabled = true;
            buttonXDataDiscretizationRun.Enabled = true;
            integerInputIntervalDiscretization.Enabled = true;
            checkBoxXDiscreteAllColumn.Enabled = true;
            checkedListBoxColumnName.Enabled = true;
        }
        private void checkBoxXDiscreteAllColumn_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxXDiscreteAllColumn.Checked == true)
                for (int i = 0; i < checkedListBoxColumnName.Items.Count; i++)
                    checkedListBoxColumnName.SetItemChecked(i, true);
            else
                for (int i = 0; i < checkedListBoxColumnName.Items.Count; i++)
                    checkedListBoxColumnName.SetItemChecked(i, false);
        }
        private void buttonXDiscretizationDataStatistics_Click(object sender, EventArgs e)
        {
            if (checkedListBoxColumnName.SelectedIndex == -1)
                MessageBox.Show("Chưa chọn thuộc tính để xem thống kê", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                String colName = checkedListBoxColumnName.SelectedItem.ToString();
                FormDiscretizationDataStatistics newFormDiscretizationDataStatistics = new FormDiscretizationDataStatistics(colName);
                newFormDiscretizationDataStatistics.Show();
            }
        }
    }
}
