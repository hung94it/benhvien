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
using Accord.Statistics.Filters;

namespace DiabetesDido.View
{
    public partial class BayesTest : Form
    {
        DataTable dtTraining = new DataTable();
        double[,][] trainingResult;
        public BayesTest()
        {
            InitializeComponent();
        }

        private void BayesTest_Load(object sender, EventArgs e)
        {
            dtTraining.Columns.Add("age");
            dtTraining.Columns.Add("income");
            dtTraining.Columns.Add("student");
            dtTraining.Columns.Add("credit_rating");
            dtTraining.Columns.Add("buy_computer");

            dtTraining.Rows.Add("<=30", "High", "No", "fair", "No");
            dtTraining.Rows.Add("<=30", "High", "No", "excellent", "No");
            dtTraining.Rows.Add("30...40", "High", "No", "fair", "Yes");
            dtTraining.Rows.Add(">40", "Medium", "No", "fair", "Yes");
            dtTraining.Rows.Add(">40", "Low", "Yes", "fair", "Yes");
            dtTraining.Rows.Add(">40", "Low", "Yes", "excellent", "No");
            dtTraining.Rows.Add("30...40", "Low", "Yes", "excellent", "Yes");
            dtTraining.Rows.Add("<=30", "Medium", "No", "fair", "No");
            dtTraining.Rows.Add("<=30", "Low", "Yes", "fair", "Yes");
            dtTraining.Rows.Add(">40", "Medium", "Yes", "fair", "Yes");
            dtTraining.Rows.Add("<=30", "Medium", "Yes", "excellent", "Yes");
            dtTraining.Rows.Add("30...40", "Medium", "No", "excellent", "Yes");
            dtTraining.Rows.Add("30...40", "High", "Yes", "fair", "Yes");
            dtTraining.Rows.Add(">40", "Medium    ", "No", "excellent", "No");

            dataGridView1.DataSource = dtTraining;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create a new codification codebook to  
            // convert strings into integer symbols
            Codification codebook = new Codification(dtTraining);

            // Translate our training data into integer symbols using our codebook:
            DataTable symbols = codebook.Apply(dtTraining);
            int[][] inputs = symbols.ToIntArray("age", "income", "student", "credit_rating");
            int[] outputs = symbols.ToIntArray("buy_computer").GetColumn(0);

            // Gather information about decision variables 
            int[] symbolCounts =
            {
              codebook["age"].Symbols,     // 3 possible values (Sunny, overcast, rain)
              codebook["income"].Symbols, // 3 possible values (Hot, mild, cool)
              codebook["student"].Symbols,    // 2 possible values (High, normal)
              codebook["credit_rating"].Symbols         // 2 possible values (Weak, strong)
            };

            int classCount = codebook["buy_computer"].Symbols; // 2 possible values (yes, no) 

            // Create a new Naive Bayes classifiers for the two classes
            NaiveBayes target = new NaiveBayes(classCount, symbolCounts);

            // Compute the Naive Bayes model
            target.Estimate(inputs, outputs);
            trainingResult = target.Distributions;

        }
    }
}
