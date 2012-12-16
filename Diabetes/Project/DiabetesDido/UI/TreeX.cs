using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Accord.MachineLearning.Bayes;
using Accord.MachineLearning.DecisionTrees;
using Accord.MachineLearning.DecisionTrees.Learning;
using Accord.Math;
using Accord.Statistics.Analysis;
using Accord.Statistics.Distributions.Univariate;
using Accord.Statistics.Filters;

namespace DiabetesDido.UI
{
    public partial class TreeX : Form
    {
        private DAL.DiabetesDataSetBTableAdapters.TrainingSetTableAdapter trainingSetTableAdapter;
        private DAL.DiabetesDataSetBTableAdapters.TestSetTableAdapter testSetTableAdapter;

        private DecisionTree decisionTree;
        private NaiveBayes naiveBayes;

        LearningAlgorithm learningAlgorithm;

        private TrainningData trainningDataForAlgorithm;

        internal TrainningData TrainningDataForAlgorithm
        {
            get { return trainningDataForAlgorithm; }
            private set { trainningDataForAlgorithm = value; }
        }

        public DecisionTree DecisionTree
        {
            get { return decisionTree; }
            private set { decisionTree = value; }
        }
        
        public NaiveBayes NaiveBayes
        {
            get { return naiveBayes; }
            private set { naiveBayes = value; }
        }
        
        internal LearningAlgorithm LearningAlgorithm
        {
            get { return learningAlgorithm; }
            private set { learningAlgorithm = value; }
        }
        
        public TreeX()
        {
            InitializeComponent();

            this.trainingSetTableAdapter = new DAL.DiabetesDataSetBTableAdapters.TrainingSetTableAdapter();
            this.testSetTableAdapter = new DAL.DiabetesDataSetBTableAdapters.TestSetTableAdapter();

            this.radioButtonC45.Checked = true;
            this.learningAlgorithm = LearningAlgorithm.C45;
        }

        private void TreeX_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = trainingSetTableAdapter.GetData();
            
        }

        //Create model
        private void button1_Click(object sender, EventArgs e)
        {
            this.TrainningDataForAlgorithm = new TrainningData(this.dataGridView1.DataSource as DataTable);
            Codification codification = this.TrainningDataForAlgorithm.DiscreteCodification;
            double[][] inputs = this.TrainningDataForAlgorithm.DoubleTrainningAttributes;
            int[] outputs = this.TrainningDataForAlgorithm.ClassifierAttribute;

            //DataTable discreteDataTable = trainingSetTableAdapter.GetData();

            //// Create a new codification to convert strings into integer symbols
            //Codification codification = new Codification(discreteDataTable);
            //DataTable IntergerDiscreteDataTable = codification.Apply(discreteDataTable);

            //List<string> columnNames = new List<string>();

            //// Get column's name of training data

            //for (int columnIndex = 0; columnIndex < discreteDataTable.Columns.Count - 1; columnIndex++)
            //{
            //    columnNames.Add(discreteDataTable.Columns[columnIndex].ColumnName);
            //}

            //// Create input data for algorithm 
            //double[][] inputs = IntergerDiscreteDataTable.ToArray(columnNames.ToArray());

            //// Create classification data for algorithm
            //string lastColumnName = IntergerDiscreteDataTable.Columns[IntergerDiscreteDataTable.Columns.Count - 1].ColumnName;
            //int[] outputs = IntergerDiscreteDataTable.ToIntArray(lastColumnName).GetColumn(0);

            // Run selected algorithm
            switch (this.learningAlgorithm)
            {
                case LearningAlgorithm.C45:
                    this.DecisionTree = CreateDecisionTree(codification);
                    C45Learning c45;
                    // Creates a new instance of the C4.5 learning algorithm
                    c45 = new C45Learning(this.decisionTree);

                    // Learn the decision tree
                    double error = c45.Run(inputs, outputs);
                    break;

                case LearningAlgorithm.ID3:
                    this.DecisionTree = CreateDecisionTree(codification);
                    // Create a new instance of the ID3 algorithm
                    ID3Learning id3learning = new ID3Learning(this.decisionTree);

                    // Learn the training instances!
                    id3learning.Run(inputs.ToInt32(), outputs);
                    break;
                case LearningAlgorithm.NaiveBayes:
                    int lastIndex = codification.Columns.Count - 1;
                    int numberOfClass = codification[lastIndex].Symbols;

                    List<int> symbolCounts = new List<int>();

                    for (int indexColumn = 0; indexColumn < lastIndex; indexColumn++)
                    {
                        symbolCounts.Add(codification[indexColumn].Symbols);
                    }

                    naiveBayes = new NaiveBayes(numberOfClass, symbolCounts.ToArray());

                    naiveBayes.Estimate(inputs.ToInt32(), outputs);

                    break;
            }
        }

        // Create Decision tree
        private DecisionTree CreateDecisionTree(Codification codification)
        {
            int lastIndex = codification.Columns.Count - 1;
            int numberOfClass = codification[lastIndex].Symbols;

            List<DecisionVariable> attributes = new List<DecisionVariable>();

            for (int indexColumn = 0; indexColumn < lastIndex; indexColumn++)
            {
                attributes.Add(new DecisionVariable(codification.Columns[indexColumn].ColumnName,
                    codification[indexColumn].Symbols));
            }

            return new DecisionTree(attributes.ToArray(), numberOfClass);            
        }

        // Test data
        private void button2_Click(object sender, EventArgs e)
        {
            bool haveModel = false;

            switch (this.learningAlgorithm)
            { 
                case LearningAlgorithm.C45:
                case LearningAlgorithm.ID3:
                    haveModel = (this.decisionTree != null ? true : false);
                    break;
                case LearningAlgorithm.NaiveBayes:
                    haveModel = (this.naiveBayes != null ? true : false);
                    break;
            }

            if (!haveModel)
            {
                MessageBox.Show("Chọn thuật toán rồi tạo mô hình đi ku", "Vậy mà cũng ko biết", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            //DataTable discreteDataTable = testSetTableAdapter.GetData();
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

            // Compute the machine outputs
            int[] predicted = new int[inputs.Length];

            // Compute predicted value with selected algorithm
            switch (this.learningAlgorithm)
            { 
                case LearningAlgorithm.C45:
                case LearningAlgorithm.ID3:
                    for (int i = 0; i < inputs.Length; i++)
                        predicted[i] = this.decisionTree.Compute(inputs[i]);
                    break;
                case LearningAlgorithm.NaiveBayes:
                    for (int i = 0; i < inputs.Length; i++)
                        predicted[i] = this.naiveBayes.Compute(inputs[i].ToInt32());
                    break;
            }
            
            // Get expected
            string lastColumnName = discreteDataTable.Columns[discreteDataTable.Columns.Count - 1].ColumnName;
            int[] expected = discreteDataTableTemp.ToIntArray(lastColumnName).GetColumn(0);


            // Use confusion matrix to compute some statistics.
            ConfusionMatrix confusionMatrix = new ConfusionMatrix(predicted, expected, 0, 1);
            dataGridView2.DataSource = new List<ConfusionMatrix> { confusionMatrix };
        }


        // View model
        private void buttonViewModel_Click(object sender, EventArgs e)
        {
            if (decisionTree == null)
                MessageBox.Show("Tạo mô hình đi ku!", "Lỗi nặng rồi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            else
                (new FormDecisionTree(decisionTree)).Show();
        }

        // Get selected learning algorithm
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton checkedRadioButton = sender as RadioButton;

            if (checkedRadioButton == null)
            {
                MessageBox.Show("Sender is not a RadioButton");
                return;
            }

            // Ensure that the RadioButton.Checked property changed to true.             
            if (checkedRadioButton.Checked)
            {
                switch (checkedRadioButton.Text)
                {
                    case "C4.5":
                        this.learningAlgorithm = LearningAlgorithm.C45;
                        break;
                    case "ID3":
                        this.learningAlgorithm = LearningAlgorithm.ID3;
                        break;
                    case "NaiveBayes":
                        this.learningAlgorithm = LearningAlgorithm.NaiveBayes;
                        break;
                }
            }
        }
    }

    enum LearningAlgorithm
    {
        ID3,
        C45,
        NaiveBayes,
    }
}
