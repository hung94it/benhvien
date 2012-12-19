using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Accord.MachineLearning.Bayes;
using Accord.Controls;

namespace DiabetesDido.UI
{
    public partial class FormNaiveBayes : Form
    {
        private NaiveBayes naiveBayes;
        private string[] columnNames;

        private FormNaiveBayes()
        {
            InitializeComponent();
        }

        public FormNaiveBayes(NaiveBayes naiveBayes, string[] columnNames)
            : this()
        {
            this.naiveBayes = naiveBayes;
            this.columnNames = columnNames;
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormNaiveBayes_Load(object sender, EventArgs e)
        {
            string[] sourceClasses = new string[] { "g1", "g2" };
            this.dataGridView1.DataSource = new ArrayDataView(this.naiveBayes.Distributions, this.columnNames, sourceClasses);

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.Visible = true;
            }
        }
    }
}
