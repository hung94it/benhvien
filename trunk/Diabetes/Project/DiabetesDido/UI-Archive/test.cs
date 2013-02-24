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
using DiabetesDido.DAL.DiabetesDataSetBTableAdapters;
using System.Collections;

namespace DiabetesDido.UI
{
    public partial class test : Form
    {
        private TestTableAdapter testTableAdapter;
        private TestEliminationTableAdapter testEliminationTableAdapter;

        DataTable datatable;

        private DecisionTree decisionTree;
        private NaiveBayes naiveBayes;

        LearningAlgorithm learningAlgorithm;

        public test()
        {
            InitializeComponent();

            this.testTableAdapter = new TestTableAdapter();
            this.testEliminationTableAdapter = new TestEliminationTableAdapter();

            //this.learningAlgorithm = LearningAlgorithm.C45;
        }

        private void test_Load(object sender, EventArgs e)
        {
            this.datatable = this.testEliminationTableAdapter.GetData();
            //this.dataGridView1.DataSource = this.testTableAdapter.GetData();
            this.dataGridView1.DataSource = this.datatable;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            //ArrayList array = new ArrayList();
            foreach (DataColumn column in datatable.Columns)
            { 
                if (column.DataType == typeof(System.Decimal))
                    list.Add(column.ColumnName);
            }


            Elimination elimination = new Elimination(list.ToArray()); 
            //elimination.Detect(this.datatable);
            dataGridView2.DataSource = elimination.Apply(this.datatable);
            label1.Text = (dataGridView2.DataSource as DataTable).Rows.Count.ToString();
            //DataTable continuousAttributeTable = this.testTableAdapter.GetData();          

            //string[] sourceColumns;
            //double[,] sourceMatrix = continuousAttributeTable.ToMatrix(out sourceColumns);
            //// Get only the input vector values
            //double[][] inputs = sourceMatrix.Submatrix(null, 0, continuousAttributeTable.Columns.Count - 2).ToArray();

            ////Get only the label outputs
            //int[] outputs = sourceMatrix.GetColumn(continuousAttributeTable.Columns.Count - 1).ToInt32();

            //List<DecisionVariable> attributes = new List<DecisionVariable>();
            //int lastIndex = continuousAttributeTable.Columns.Count - 1;

            //for (int indexColumn = 0; indexColumn < lastIndex; indexColumn++)
            //{
            //    attributes.Add(new DecisionVariable(continuousAttributeTable.Columns[indexColumn].ColumnName,
            //        DecisionAttributeKind.Continuous));
            //}

            //this.decisionTree = new DecisionTree(attributes.ToArray(), 2);

            //C45Learning c45;
            //// Creates a new instance of the C4.5 learning algorithm
            //c45 = new C45Learning(this.decisionTree);

            //// Learn the decision tree
            //double error = c45.Run(inputs, outputs);

            //decisionTreeView1.TreeSource = decisionTree;
        }
    }
}
