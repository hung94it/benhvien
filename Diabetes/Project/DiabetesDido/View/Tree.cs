using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Accord.MachineLearning;
using Accord.MachineLearning.DecisionTrees;
using Accord.MachineLearning.DecisionTrees.Learning;
using Accord.Math;
using Accord.Statistics.Analysis;
using Accord.Statistics.Formats;
using ZedGraph;

namespace DiabetesDido.View
{
    public partial class Tree : Form
    {

        private DecisionTree tree;

        string[] sourceColumns;

        public Tree()
        {
            InitializeComponent();
        }

        private void Tree_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'diabetesDataSet.Datasource' table. You can move, or remove it, as needed.
            this.datasourceTableAdapter.Fill(this.diabetesDataSet.Datasource);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double[,] sourceMatrix = datasourceTableAdapter.GetData().ToMatrix(out sourceColumns);


            // Perform classification
            C45Learning c45;

            // Get only the input vector values
            double[][] inputs = sourceMatrix.Submatrix(null, 0, 29).ToArray();

            // Get only the label outputs
            int[] outputs = sourceMatrix.GetColumn(30).ToInt32();


            DecisionVariable[] attributes = 
            {
                new DecisionVariable("Cholesterol", DecisionAttributeKind.Continuous),
                new DecisionVariable("HDL_Cholesterol", DecisionAttributeKind.Continuous),
                new DecisionVariable("Triglyceride", DecisionAttributeKind.Continuous),
                new DecisionVariable("LDL_Cholesterol", DecisionAttributeKind.Continuous),
                new DecisionVariable("Glucose", DecisionAttributeKind.Continuous),
                new DecisionVariable("SGOT", DecisionAttributeKind.Continuous),
                new DecisionVariable("SGPT", DecisionAttributeKind.Continuous),
                new DecisionVariable("Urea", DecisionAttributeKind.Continuous),
                new DecisionVariable("WBC", DecisionAttributeKind.Continuous),
                new DecisionVariable("LYM", DecisionAttributeKind.Continuous),
                new DecisionVariable("MONO", DecisionAttributeKind.Continuous),
                new DecisionVariable("GRAN", DecisionAttributeKind.Continuous),
                new DecisionVariable("TyLeLYM", DecisionAttributeKind.Continuous),
                new DecisionVariable("TyLeMONO", DecisionAttributeKind.Continuous),
                new DecisionVariable("TyLeGRAN", DecisionAttributeKind.Continuous),
                new DecisionVariable("HGB", DecisionAttributeKind.Continuous),
                new DecisionVariable("RBC", DecisionAttributeKind.Continuous),
                new DecisionVariable("HTC", DecisionAttributeKind.Continuous),
                new DecisionVariable("MCV", DecisionAttributeKind.Continuous),
                new DecisionVariable("MCH", DecisionAttributeKind.Continuous),
                new DecisionVariable("MCHC", DecisionAttributeKind.Continuous),
                new DecisionVariable("RDW_CV", DecisionAttributeKind.Continuous),
                new DecisionVariable("PLT", DecisionAttributeKind.Continuous),
                new DecisionVariable("MPV", DecisionAttributeKind.Continuous),
                new DecisionVariable("PDW", DecisionAttributeKind.Continuous),
                new DecisionVariable("PCT", DecisionAttributeKind.Continuous),
                new DecisionVariable("Na", DecisionAttributeKind.Continuous),
                new DecisionVariable("K", DecisionAttributeKind.Continuous),
                new DecisionVariable("Cl", DecisionAttributeKind.Continuous),
                new DecisionVariable("Ca", DecisionAttributeKind.Continuous),
            };

            // Create the Decision tree
            tree = new DecisionTree(attributes, 30);

            // Creates a new instance of the C4.5 learning algorithm
            c45 = new C45Learning(tree);

            // Learn the decision tree
            double error = c45.Run(inputs, outputs);

            // Show the learned tree in the view
            decisionTreeView1.TreeSource = tree;
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
                output[i] = tree.Compute(inputs[i]);


            // Use confusion matrix to compute some statistics.
            ConfusionMatrix confusionMatrix = new ConfusionMatrix(output, expected, 1, 0);
            dataGridView1.DataSource = new List<ConfusionMatrix> { confusionMatrix };

            foreach (DataGridViewColumn col in dataGridView1.Columns)
                col.Visible = true;
        }
    }
}
