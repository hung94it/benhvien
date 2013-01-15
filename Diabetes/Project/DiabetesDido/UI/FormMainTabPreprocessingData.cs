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

            string[] columnNames;
            double[,] data = (this.bindingSourcePreprocessingData.DataSource as DataTable).ToMatrix(out columnNames);

            this.analysis = new DescriptiveAnalysis(data, columnNames);
            this.analysis.Compute();
                        
        }

        private void buttonXCleaningData_Click(object sender, EventArgs e)
        {
            string[] acolumnNames;

            this.orginalData = this.bindingSourcePreprocessingData.DataSource as DataTable;

            // Get columns's name
            List<string> listColumnNames = new List<string>();
            
            foreach (DataColumn column in orginalData.Columns)
            {
                if (column.DataType == typeof(System.Decimal))
                    listColumnNames.Add(column.ColumnName);
            }

            // Remove rows which have null value
            Elimination elimination = new Elimination(listColumnNames.ToArray());
                                    
            this.bindingSourcePreprocessingData.DataSource = elimination.Apply(this.orginalData);

            double[,] data = (this.bindingSourcePreprocessingData.DataSource as DataTable).ToMatrix(out acolumnNames);

            this.analysis = new DescriptiveAnalysis(data, acolumnNames);
            this.analysis.Compute();

            //double[,] temp = new double[this.analysis.Variables, 0];

            //temp = temp.InsertColumn<double>(this.analysis.Distinct.ToDouble());
            //temp = temp.InsertColumn<double>(this.analysis.Sums);
            
        }

        private void buttonXDiscretizationData_Click(object sender, EventArgs e)
        {

        }
    }
}
