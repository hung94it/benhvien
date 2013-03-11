using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using Accord.Statistics.Filters;
using Accord.MachineLearning.DecisionTrees;

namespace DiabetesDido.UI
{
    public partial class FormTreeRule : DevComponents.DotNetBar.Metro.MetroForm
    {
        private Codification codification;

        public FormTreeRule()
        {
            InitializeComponent();
        }

        public FormTreeRule(DecisionTree tree, Codification codification, string rule)
            : this()
        {
            this.codification = codification;

            // Show the learned tree in the view            
            decisionTreeView.SetTree(tree, codification);
            decisionTreeView.viewRule(rule);
            
        }

        private void decisionTreeViewDiabetes1_Load(object sender, EventArgs e)
        {

        }
    }
}