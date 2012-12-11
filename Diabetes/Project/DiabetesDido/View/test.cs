using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Accord.Statistics.Filters;
using Accord.MachineLearning.Bayes;
using Accord.Math;
using Accord.MachineLearning;
using Accord.MachineLearning.DecisionTrees;
using Accord.MachineLearning.DecisionTrees.Learning;
using Accord.Statistics.Analysis;

namespace DiabetesDido.View
{
    public partial class test : Form
    {
        private DiabetesDataSetTableAdapters.ContinuousAttributesTableAdapter continuousAttributesTableAdapter;
        private DiabetesDataSetTableAdapters.DiscreteAttributesTableAdapter discreteAttributesTableAdapter;
        private DiabetesDataSetTableAdapters.DataSetTableAdapter dataSetTableAdapter;
        private DecisionTree tree;

        string[] sourceColumns;

        public test()
        {
            InitializeComponent();

            dataSetTableAdapter = new DiabetesDido.DiabetesDataSetTableAdapters.DataSetTableAdapter();
            continuousAttributesTableAdapter = new DiabetesDido.DiabetesDataSetTableAdapters.ContinuousAttributesTableAdapter();
            discreteAttributesTableAdapter = new DiabetesDido.DiabetesDataSetTableAdapters.DiscreteAttributesTableAdapter();

            dataGridView1.DataSource = dataSetTableAdapter.GetData();
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            DataTable continuousAttributeTable = continuousAttributesTableAdapter.GetData();
            //dataGridView1.DataSource = temp1;
            double[,] sourceMatrix = continuousAttributeTable.ToMatrix(out sourceColumns);
            // Get only the input vector values
            double[][] inputs = sourceMatrix.Submatrix(null, 0, continuousAttributeTable.Columns.Count - 2).ToArray();

            // Get only the label outputs
            int[] outputs = sourceMatrix.GetColumn(continuousAttributeTable.Columns.Count - 1).ToInt32();


            DataTable discreteAttributeTable = discreteAttributesTableAdapter.GetData();
            //dataGridView1.DataSource = discreteAttributeTable;

            // Create a new codification codebook to  
            // convert strings into integer symbols
            Codification codificationTemp = new Codification(discreteAttributeTable);
            DataTable continuousTable2 = codificationTemp.Apply(discreteAttributeTable);

            List<string> columnNames = new List<string>();

            foreach (DataColumn col in discreteAttributeTable.Columns)
            {
                columnNames.Add(col.ColumnName);
            }

            double[][] inputs2 = continuousTable2.ToArray(columnNames.ToArray());

            inputs = inputs.Concatenate<double>(inputs2);

            DecisionVariable[] attributes = 
            {
                new DecisionVariable("NamSinh", DecisionAttributeKind.Continuous),
                new DecisionVariable("Cholesterol", DecisionAttributeKind.Continuous),
                new DecisionVariable("HDL_Cholesterol", DecisionAttributeKind.Continuous),
                new DecisionVariable("Triglyceride", DecisionAttributeKind.Continuous),
                new DecisionVariable("LDL_Cholesterol", DecisionAttributeKind.Continuous),
                //new DecisionVariable("Glucose", DecisionAttributeKind.Continuous),
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
                new DecisionVariable("GioiTinh", 2),
                //new DecisionVariable("GioiTinh", DecisionAttributeKind.Continuous),
            };

            // Create the Decision tree
            tree = new DecisionTree(attributes, inputs[0].Length);

            C45Learning c45;
            // Creates a new instance of the C4.5 learning algorithm
            c45 = new C45Learning(tree);

            // Learn the decision tree
            double error = c45.Run(inputs, outputs);

            // Show the learned tree in the view
            decisionTreeView1.TreeSource = tree;

            int[] expected = sourceMatrix.GetColumn(continuousAttributeTable.Columns.Count - 1).ToInt32();
            //int[] expected = new int[sourceMatrix.GetLength(0)];
            //for (int i = 0; i < expected.Length; i++)
            //    expected[i] = (int)sourceMatrix[i, 30];

            // Compute the machine outputs
            int[] output = new int[inputs.Length];
            for (int i = 0; i < inputs.Length; i++)
                output[i] = tree.Compute(inputs[i]);


            // Use confusion matrix to compute some statistics.
            ConfusionMatrix confusionMatrix = new ConfusionMatrix(output, expected, 1, 0);
            dataGridView2.DataSource = new List<ConfusionMatrix> { confusionMatrix };
        }


        //private void button2_Click(object sender, EventArgs e)
        //{
            //DataTable data = new DataTable("Mitchell's Tennis Example");

            //data.Columns.Add("Day");
            //data.Columns.Add("Outlook");
            //data.Columns.Add("Temperature");
            //data.Columns.Add("Humidity");
            //data.Columns.Add("Wind");
            //data.Columns.Add("PlayTennis");

            //data.Rows.Add("D1", "Sunny", "Hot", "High", "Weak", "No");
            //data.Rows.Add("D2", "Sunny", "Hot", "High", "Strong", "No");
            //data.Rows.Add("D3", "Overcast", "Hot", "High", "Weak", "Yes");
            //data.Rows.Add("D4", "Rain", "Mild", "High", "Weak", "Yes");
            //data.Rows.Add("D5", "Rain", "Cool", "Normal", "Weak", "Yes");
            //data.Rows.Add("D6", "Rain", "Cool", "Normal", "Strong", "No");
            //data.Rows.Add("D7", "Overcast", "Cool", "Normal", "Strong", "Yes");
            //data.Rows.Add("D8", "Sunny", "Mild", "High", "Weak", "No");
            //data.Rows.Add("D9", "Sunny", "Cool", "Normal", "Weak", "Yes");
            //data.Rows.Add("D10", "Rain", "Mild", "Normal", "Weak", "Yes");
            //data.Rows.Add("D11", "Sunny", "Mild", "Normal", "Strong", "Yes");
            //data.Rows.Add("D12", "Overcast", "Mild", "High", "Strong", "Yes");
            //data.Rows.Add("D13", "Overcast", "Hot", "Normal", "Weak", "Yes");
            //data.Rows.Add("D14", "Rain", "Mild", "High", "Strong", "No");

            //// Create a new codification codebook to  
            //// convert strings into integer symbols
            //Codification codebook = new Codification(data);

            //// Translate our training data into integer symbols using our codebook:
            //DataTable symbols = codebook.Apply(data);
            //int[][] inputs = symbols.ToIntArray("Outlook", "Temperature", "Humidity", "Wind");

            ////inputs = Matrix.Concatenate<int>(inputs, inputs);
            ////inputs = inputs.Concatenate<int>(inputs);

            //int[] outputs = symbols.ToIntArray("PlayTennis").GetColumn(0);

            //// Gather information about decision variables 
            //int[] symbolCounts =
            //{
            //    codebook["Outlook"].Symbols,     // 3 possible values (Sunny, overcast, rain)
            //    codebook["Temperature"].Symbols, // 3 possible values (Hot, mild, cool)
            //    codebook["Humidity"].Symbols,    // 2 possible values (High, normal)
            //    codebook["Wind"].Symbols         // 2 possible values (Weak, strong)
            //};

            //int classCount = codebook["PlayTennis"].Symbols; // 2 possible values (yes, no) 

            //// Create a new Naive Bayes classifiers for the two classes
            //Accord.MachineLearning.Bayes.NaiveBayes target = new Accord.MachineLearning.Bayes.NaiveBayes(classCount, symbolCounts);

            //// Compute the Naive Bayes model
            //target.Estimate(inputs, outputs);
            //double[,][] result = target.Distributions;
        //}


    }
}
