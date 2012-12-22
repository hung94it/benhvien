using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DiabetesDido.ClassificationLogic;

namespace DiabetesDido.UI
{
    public partial class c45test : Form
    {
        public c45test()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DAL.DiabetesDataSetBTableAdapters.TrainingSetTableAdapter trainingSetTableAdapter = new DAL.DiabetesDataSetBTableAdapters.TrainingSetTableAdapter();  
            DataTable trainningDataTable = trainingSetTableAdapter.GetData();
            this.dataGridView1.DataSource = trainningDataTable;
            ClassificationData classificationDataForApp = new ClassificationData(this.dataGridView1.DataSource as DataTable);
        }
    }
}
