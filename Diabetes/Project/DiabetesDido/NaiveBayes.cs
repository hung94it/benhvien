using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DiabetesDido
{
    public partial class NaiveBayes : Form
    {
        public NaiveBayes()
        {
            InitializeComponent();
        }

        private void trainingSetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.trainingSetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.diabetesDataSet);

        }

        private void NaiveBayes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'diabetesDataSet.TrainingSet' table. You can move, or remove it, as needed.
            this.trainingSetTableAdapter.Fill(this.diabetesDataSet.TrainingSet);

        }
    }
}
