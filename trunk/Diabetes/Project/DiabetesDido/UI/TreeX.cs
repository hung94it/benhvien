using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Accord.Controls;
using Accord.MachineLearning.Bayes;
using Accord.MachineLearning.DecisionTrees;
using Accord.MachineLearning.DecisionTrees.Learning;
using Accord.Math;
using Accord.Statistics.Analysis;
using Accord.Statistics.Distributions.Univariate;
using Accord.Statistics.Filters;
using DiabetesDido.ClassificationLogic;

namespace DiabetesDido.UI
{
    public partial class TreeX : Form
    {
        private DAL.DiabetesDataSetBTableAdapters.TrainingSetTableAdapter trainingSetTableAdapter;
        private DAL.DiabetesDataSetBTableAdapters.TestSetTableAdapter testSetTableAdapter;

        private DecisionTree decisionTree;
        private NaiveBayes naiveBayes;

        private LearningAlgorithm learningAlgorithm;

        private ClassificationData classificationDataForApp;

        private ClassificationModel classificationModelForApp;

        internal ClassificationData ClassificationDataForApp
        {
            get { return classificationDataForApp; }
            set { classificationDataForApp = value; }
        }

        internal ClassificationModel ClassificationModelForApp
        {
            get { return classificationModelForApp; }
            set { classificationModelForApp = value; }
        }

        internal ClassificationData TrainningDataForAlgorithm
        {
            get { return classificationDataForApp; }
            set { classificationDataForApp = value; }
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
            //this.learningAlgorithm = LearningAlgorithm.C45;

            this.ClassificationModelForApp = new ClassificationModel();
            this.ClassificationModelForApp.ActiveLearningAlgorithm = LearningAlgorithm.C45;
        }

        private void TreeX_Load(object sender, EventArgs e)
        {
            DataTable trainningDataTable = trainingSetTableAdapter.GetData();
            this.dataGridView1.DataSource = trainningDataTable;
            this.classificationDataForApp = new ClassificationData(this.dataGridView1.DataSource as DataTable);
        }

        //Create model
        private void buttonCreateModel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            if (this.ClassificationModelForApp.haveModel())
            {
                dialogResult = MessageBox.Show("Model này đã có. Bạn có muốn tạo mô hình mới", "Tạo mới", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == System.Windows.Forms.DialogResult.Yes)
                {
                    this.ClassificationModelForApp.CreateModel(this.ClassificationDataForApp);
                }
            }
            else
            {
                this.ClassificationModelForApp.CreateModel(this.ClassificationDataForApp);
            }

        }

        // Test data
        private void buttonTestModel_Click(object sender, EventArgs e)
        {
            if (this.ClassificationModelForApp.haveModel())
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
            if (this.ClassificationModelForApp.haveModel())
            {
                switch (this.ClassificationModelForApp.ActiveLearningAlgorithm)
                {

                    case LearningAlgorithm.C45:
                    case LearningAlgorithm.ID3:
                        new FormDecisionTree(this.ClassificationModelForApp.GetModel() as DecisionTree).Show();
                        break;
                    case LearningAlgorithm.NaiveBayes:
                        MessageBox.Show("Chưa làm");
                        break;

                }
            }
            else
            {
                MessageBox.Show("Chưa có model cho thuật toán này");
            }
        }

        // Get selected learning algorithm from user
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton checkedRadioButton = sender as RadioButton;

            // Ensure that the RadioButton.Checked property changed to true.             
            if (checkedRadioButton.Checked)
            {
                this.ClassificationModelForApp.ActiveLearningAlgorithm =
                    (LearningAlgorithm)Enum.Parse(typeof(LearningAlgorithm), checkedRadioButton.Tag as string);
            }
        }
    }

}
