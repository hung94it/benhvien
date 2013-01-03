using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DiabetesDido.DAL.DiabetesDataSetBTableAdapters;

namespace DiabetesDido.UI
{
    public partial class FormMain
    {
        private OrginalDataTableAdapter orginalDataTableAdapter;
        private DataTable orginalData;

        public void InitializeTabPreprocessingData()
        {
            this.orginalDataTableAdapter = new OrginalDataTableAdapter();

            this.orginalData = this.orginalDataTableAdapter.GetData();
            this.dataGridViewXPreProcessingData.DataSource = this.orginalData;
        }

        private void buttonXCleaningData_Click(object sender, EventArgs e)
        {

        }

        private void buttonXDiscretizationData_Click(object sender, EventArgs e)
        {

        }
    }
}
