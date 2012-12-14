using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Accord.MachineLearning.DecisionTrees;
using Accord.MachineLearning.DecisionTrees.Learning;
using Accord.Math;
using Accord.Statistics.Filters;
using Accord.MachineLearning.Bayes;
using Accord.Statistics.Distributions.Univariate;
using Accord.Statistics.Analysis;

namespace DiabetesDido.UI
{
    public partial class TreeX : Form
    {
        private DAL.DiabetesDataSetBTableAdapters.CountDiscreteValueTableAdapter countDiscreteValueTableAdapter;
        private DAL.DiabetesDataSetBTableAdapters.TrainingSetTableAdapter trainingSetTableAdapter;
        private DAL.DiabetesDataSetBTableAdapters.TestSetTableAdapter testSetTableAdapter;

        private DecisionTree tree;

        
        public TreeX()
        {
            InitializeComponent();

            this.countDiscreteValueTableAdapter = new DAL.DiabetesDataSetBTableAdapters.CountDiscreteValueTableAdapter();
            this.trainingSetTableAdapter = new DAL.DiabetesDataSetBTableAdapters.TrainingSetTableAdapter();
            this.testSetTableAdapter = new DAL.DiabetesDataSetBTableAdapters.TestSetTableAdapter();
        }

        private void DecisionTree_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = trainingSetTableAdapter.GetData();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable discreteDataTable = trainingSetTableAdapter.GetData();

            // Create a new codification codebook to convert strings into integer symbols
            Codification codificationTemp = new Codification(discreteDataTable);
            DataTable discreteDataTableTemp = codificationTemp.Apply(discreteDataTable);

            List<string> columnNames = new List<string>();

            // Get column's name for learning's input
            for (int columnIndex = 0; columnIndex < discreteDataTable.Columns.Count - 1; columnIndex++)
            {
                columnNames.Add(discreteDataTable.Columns[columnIndex].ColumnName);
            }

            // Get input form discrete data 
            double[][] inputs = discreteDataTableTemp.ToArray(columnNames.ToArray());

            // Get output
            string lastColumnName = discreteDataTable.Columns[discreteDataTable.Columns.Count - 1].ColumnName;

            int[] outputs = discreteDataTableTemp.ToIntArray(lastColumnName).GetColumn(0);

            List<DecisionVariable> attributes = new List<DecisionVariable>();

            DataTable countDiscreteAttributesDataTable = countDiscreteValueTableAdapter.GetData();
            int discreteValue;
            lastColumnName = 
                countDiscreteAttributesDataTable.Columns[countDiscreteAttributesDataTable.Columns.Count - 1].ColumnName;
            int numberOfClass = 0;

            foreach (DataColumn column in countDiscreteAttributesDataTable.Columns)
            {
                if (column.Equals(countDiscreteAttributesDataTable.Columns[lastColumnName]))
                {
                    numberOfClass = (int)countDiscreteAttributesDataTable.Rows[0][column];
                    continue;
                }
                discreteValue = (int)countDiscreteAttributesDataTable.Rows[0][column];
                attributes.Add(new DecisionVariable(column.ColumnName, discreteValue));
            }

            // Create the Decision tree
            tree = new DecisionTree(attributes.ToArray(), numberOfClass);

            C45Learning c45;
            // Creates a new instance of the C4.5 learning algorithm
            c45 = new C45Learning(tree);

            // Learn the decision tree
            double error = c45.Run(inputs, outputs);

            // Show the learned tree in the view
            decisionTreeView1.TreeSource = tree;

            //// Create a new instance of the ID3 algorithm
            //ID3Learning id3learning = new ID3Learning(tree);

            //// Learn the training instances!
            //id3learning.Run(inputs, outputs);



        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable discreteDataTable = testSetTableAdapter.GetData();

            // Create a new codification codebook to convert strings into integer symbols
            Codification codificationTemp = new Codification(discreteDataTable);
            DataTable discreteDataTableTemp = codificationTemp.Apply(discreteDataTable);

            List<string> columnNames = new List<string>();

            // Get column's name for learning's input
            for (int columnIndex = 0; columnIndex < discreteDataTable.Columns.Count - 1; columnIndex++)
            {
                columnNames.Add(discreteDataTable.Columns[columnIndex].ColumnName);
            }

            // Get input form discrete data 
            double[][] inputs = discreteDataTableTemp.ToArray(columnNames.ToArray());
            
            // Compute the machine outputs
            int[] output = new int[inputs.Length];
            for (int i = 0; i < inputs.Length; i++)
                output[i] = tree.Compute(inputs[i]);

            // Get expected
            string lastColumnName = discreteDataTable.Columns[discreteDataTable.Columns.Count - 1].ColumnName;

            int[] expected = discreteDataTableTemp.ToIntArray(lastColumnName).GetColumn(0);


            // Use confusion matrix to compute some statistics.
            ConfusionMatrix confusionMatrix = new ConfusionMatrix(output, expected, 0, 1);
            dataGridView2.DataSource = new List<ConfusionMatrix> { confusionMatrix };
        }
    }
}
