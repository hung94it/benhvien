using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DiabetesDido.DAL.DiabetesDataSetBTableAdapters;
using Accord.Statistics.Filters;

namespace DiabetesDido.UI
{
    public partial class FormMain
    {
        private OrginalDataTableAdapter orginalDataTableAdapter;
        private DataTable orginalData;

        public void InitializeTabPreprocessingData()
        {
            this.orginalDataTableAdapter = new OrginalDataTableAdapter();

            this.bindingSourcePreprocessingData.DataSource = this.orginalDataTableAdapter.GetData();
            this.dataGridViewXPreProcessingData.DataSource = this.bindingSourcePreprocessingData;
            this.bindingNavigatorEx1.BindingSource = this.bindingSourcePreprocessingData;

            this.orginalData = this.orginalDataTableAdapter.GetData();
            //this.dataGridViewXPreProcessingData.DataSource = this.orginalData;
        }

        private void buttonXCleaningData_Click(object sender, EventArgs e)
        {
            // Get columns's name
            List<string> columnNames = new List<string>();
            
            foreach (DataColumn column in orginalData.Columns)
            {
                if (column.DataType == typeof(System.Decimal))
                    columnNames.Add(column.ColumnName);
            }

            // Remove rows which have null value
            Elimination elimination = new Elimination(columnNames.ToArray());            
            this.orginalData = elimination.Apply(this.orginalData);

            this.dataGridViewXPreProcessingData.DataSource = this.orginalData;
        }

        private void buttonXDiscretizationData_Click(object sender, EventArgs e)
        {

        }
    }
}
