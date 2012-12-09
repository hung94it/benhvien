using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Accord.Controls;
using Accord.MachineLearning.Bayes;
using Accord.Math;
using Accord.Statistics.Analysis;
using Accord.Statistics.Distributions.Univariate;
using Accord.Statistics.Formats;
using ZedGraph;

namespace DiabetesDido
{
    public partial class Form2 : Form
    {
        //private DiabetesDataSetTableAdapters.DatasourceTableAdapter datasourceTableAdapter;
        private NaiveBayes<NormalDistribution> bayes;

        string[] sourceColumns;
        string[] sourceClasses;

        public Form2()
        {
            InitializeComponent();

            //this.datasourceTableAdapter = new DiabetesDido.DiabetesDataSetTableAdapters.DatasourceTableAdapter();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'diabetesDataSet.Datasource' table. You can move, or remove it, as needed.
            this.datasourceTableAdapter.Fill(this.diabetesDataSet.Datasource);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            sourceClasses = new string[] { "G1", "G2" };


            // Finishes and save any pending changes to the given data
            datasourceDataGridView.EndEdit();

            // Creates a matrix from the source data table
            double[,] sourceMatrix = datasourceTableAdapter.GetData().ToMatrix(out sourceColumns);

            // Get only the input vector values
            double[][] inputs = sourceMatrix.Submatrix(null, 0, 29).ToArray();

            // Get only the label outputs
            int[] outputs = sourceMatrix.GetColumn(30).ToInt32();
            string[] colNames = sourceColumns.Submatrix(first: 30);


            // Create the Bayes classifier and perform classification
            bayes = new NaiveBayes<NormalDistribution>(2, 30, new NormalDistribution());
            double error = bayes.Estimate(inputs, outputs);


            // Show the estimated distributions and class probabilities
            dataGridView1.DataSource = new ArrayDataView(bayes.Distributions, colNames, sourceClasses);





        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Creates a matrix from the source data table
            double[,] sourceMatrix = datasourceTableAdapter.GetData().ToMatrix();


            // Get only the input vector values
            double[][] inputs = sourceMatrix.Submatrix(null, 0, 29).ToArray();

            // Get only the label outputs
            int[] expected = new int[sourceMatrix.GetLength(0)];
            for (int i = 0; i < expected.Length; i++)
                expected[i] = (int)sourceMatrix[i, 30];

            // Compute the machine outputs
            int[] output = new int[inputs.Length];
            for (int i = 0; i < inputs.Length; i++)
                output[i] = bayes.Compute(inputs[i]);


            // Use confusion matrix to compute some statistics.
            ConfusionMatrix confusionMatrix = new ConfusionMatrix(output, expected, 1, 0);
            dataGridView2.DataSource = new List<ConfusionMatrix> { confusionMatrix };

            foreach (DataGridViewColumn col in dataGridView2.Columns)
                col.Visible = true;
            //Column1.Visible = Column2.Visible = false;
        }


    }
}
