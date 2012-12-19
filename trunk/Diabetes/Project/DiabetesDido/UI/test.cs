using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using DiabetesDido.ClassificationLogic;

namespace DiabetesDido.UI
{
    public partial class test : Form
    {
        private DAL.DiabetesDataSetBTableAdapters.TrainingSetTableAdapter trainingSetTableAdapter;
        private DAL.DiabetesDataSetBTableAdapters.TestSetTableAdapter testSetTableAdapter;
        private DAL.DiabetesDataSetBTableAdapters.TestTableAdapter testTableAdapter;
        private DAL.DiabetesDataSetBTableAdapters.DataTable1TableAdapter dataTAble1TableAdapter;

        private DecisionTree decisionTree;
        private NaiveBayes naiveBayes;

        LearningAlgorithm learningAlgorithm;

        public test()
        {
            InitializeComponent();

            this.trainingSetTableAdapter = new DAL.DiabetesDataSetBTableAdapters.TrainingSetTableAdapter();
            this.testSetTableAdapter = new DAL.DiabetesDataSetBTableAdapters.TestSetTableAdapter();
            this.testTableAdapter = new DAL.DiabetesDataSetBTableAdapters.TestTableAdapter();
            this.dataTAble1TableAdapter = new DAL.DiabetesDataSetBTableAdapters.DataTable1TableAdapter();

            //this.learningAlgorithm = LearningAlgorithm.C45;
        }

        private void test_Load(object sender, EventArgs e)
        {

            this.dataGridView1.DataSource = this.dataTAble1TableAdapter.GetData();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            DataTable continuousAttributeTable = this.dataTAble1TableAdapter.GetData();

            Discretization a = new Discretization();
            a.Detect(continuousAttributeTable);

            DataTable temp = continuousAttributeTable.Copy();
            temp.Columns.RemoveAt(temp.Columns.Count - 1);

            DataTable b = a.Apply(temp);

            //Codification codification2 = new Codification(b);
            //DataTable ef = codification2.Apply(b);

            this.dataGridView2.DataSource = b;

            string[] sourceColumns;
            double[,] sourceMatrix = continuousAttributeTable.ToMatrix(out sourceColumns);
            // Get only the input vector values
            double[][] inputs = sourceMatrix.Submatrix(null, 0, continuousAttributeTable.Columns.Count - 2).ToArray();

            //Get only the label outputs
            int[] outputs = sourceMatrix.GetColumn(continuousAttributeTable.Columns.Count - 1).ToInt32();

            //DecisionVariable[] attributes = 
            //{
            //    //new DecisionVariable("NamSinh", DecisionAttributeKind.Continuous),
            //    new DecisionVariable("Cholesterol", DecisionAttributeKind.Continuous),
            //    new DecisionVariable("HDL_Cholesterol", DecisionAttributeKind.Continuous),
            //    new DecisionVariable("Triglyceride", DecisionAttributeKind.Continuous),
            //    new DecisionVariable("LDL_Cholesterol", DecisionAttributeKind.Continuous),
            //    new DecisionVariable("Glucose", DecisionAttributeKind.Continuous),
            //    new DecisionVariable("SGOT", DecisionAttributeKind.Continuous),
            //    new DecisionVariable("SGPT", DecisionAttributeKind.Continuous),
            //    new DecisionVariable("Urea", DecisionAttributeKind.Continuous),
            //    new DecisionVariable("WBC", DecisionAttributeKind.Continuous),
            //    new DecisionVariable("LYM", DecisionAttributeKind.Continuous),
            //    new DecisionVariable("MONO", DecisionAttributeKind.Continuous),
            //    new DecisionVariable("GRAN", DecisionAttributeKind.Continuous),
            //    new DecisionVariable("TyLeLYM", DecisionAttributeKind.Continuous),
            //    new DecisionVariable("TyLeMONO", DecisionAttributeKind.Continuous),
            //    new DecisionVariable("TyLeGRAN", DecisionAttributeKind.Continuous),
            //    new DecisionVariable("HGB", DecisionAttributeKind.Continuous),
            //    new DecisionVariable("RBC", DecisionAttributeKind.Continuous),
            //    new DecisionVariable("HTC", DecisionAttributeKind.Continuous),
            //    new DecisionVariable("MCV", DecisionAttributeKind.Continuous),
            //    new DecisionVariable("MCH", DecisionAttributeKind.Continuous),
            //    new DecisionVariable("MCHC", DecisionAttributeKind.Continuous),
            //    new DecisionVariable("RDW_CV", DecisionAttributeKind.Continuous),
            //    new DecisionVariable("PLT", DecisionAttributeKind.Continuous),
            //    new DecisionVariable("MPV", DecisionAttributeKind.Continuous),
            //    new DecisionVariable("PDW", DecisionAttributeKind.Continuous),
            //    new DecisionVariable("PCT", DecisionAttributeKind.Continuous),
            //    new DecisionVariable("Na", DecisionAttributeKind.Continuous),
            //    new DecisionVariable("K", DecisionAttributeKind.Continuous),
            //    new DecisionVariable("Cl", DecisionAttributeKind.Continuous),
            //    new DecisionVariable("Ca", DecisionAttributeKind.Continuous),
            //    //new DecisionVariable("GioiTinh", 2),
            //    //new DecisionVariable("GioiTinh", DecisionAttributeKind.Continuous),
            //};

            //this.decisionTree = new DecisionTree(attributes, inputs[0].Length);

            List<DecisionVariable> attributes = new List<DecisionVariable>();
            int lastIndex = continuousAttributeTable.Columns.Count - 1;

            for (int indexColumn = 0; indexColumn < lastIndex; indexColumn++)
            {
                attributes.Add(new DecisionVariable(continuousAttributeTable.Columns[indexColumn].ColumnName,
                    DecisionAttributeKind.Continuous));
            }

            this.decisionTree = new DecisionTree(attributes.ToArray(), 2);

            C45Learning c45;
            // Creates a new instance of the C4.5 learning algorithm
            c45 = new C45Learning(this.decisionTree);

            // Learn the decision tree
            double error = c45.Run(inputs, outputs);

            decisionTreeView1.TreeSource = decisionTree;
        }
    }
}
