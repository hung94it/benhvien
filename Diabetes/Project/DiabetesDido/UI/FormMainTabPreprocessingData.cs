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
using Accord.Math;
using Accord.Controls;

namespace DiabetesDido.UI
{
    public partial class FormMain
    {
        private OrginalDataTableAdapter orginalDataTableAdapter;
        private DataTable orginalData;
        DescriptiveAnalysis analysis;

        public void InitializeTabPreprocessingData()
        {


            this.orginalDataTableAdapter = new OrginalDataTableAdapter();

            this.bindingSourcePreprocessingData.DataSource = this.orginalDataTableAdapter.GetData();
            this.dataGridViewXPreProcessingData.DataSource = this.bindingSourcePreprocessingData;
            this.bindingNavigatorExPreprocessingData.BindingSource = this.bindingSourcePreprocessingData;

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

            double[,] arrayData = (this.orginalData.ToMatrix(out columnNames)).Submatrix<double>(null, 0, this.orginalData.Columns.Count - 2);

            columnNames = columnNames.RemoveAt<string>(columnNames.Length - 1);

            // Analysis Data
            this.analysis = new DescriptiveAnalysis(arrayData, columnNames);
            this.analysis.Compute();

            double[,] analysisData = new double[0, arrayData.GetLength(1)];

            analysisData = analysisData.InsertRow<double>(this.analysis.Distinct.ToDouble(), analysisData.GetLength(0));
            analysisData = analysisData.InsertRow<double>(this.analysis.Means, analysisData.GetLength(0));
            analysisData = analysisData.InsertRow<double>(this.analysis.Medians, analysisData.GetLength(0));
            analysisData = analysisData.InsertRow<double>(this.analysis.Modes, analysisData.GetLength(0));
            analysisData = analysisData.InsertRow<double>(this.analysis.StandardDeviations, analysisData.GetLength(0));
            analysisData = analysisData.InsertRow<double>(this.analysis.Variances, analysisData.GetLength(0));
            analysisData = analysisData.InsertRow<double>(this.analysis.Sums, analysisData.GetLength(0));

            string[] rowNames = { "Distinct", "Means", "Medians", "Modes", "StandardDeviations", "Variances", "Sums" };            

            ArrayDataView arrayDataView = new ArrayDataView(analysisData, columnNames, rowNames);
            dataGridViewXDescriptiveData.DataSource = arrayDataView;
        }

        private void buttonXDiscretizationData_Click(object sender, EventArgs e)
        {

        }
    }
}
