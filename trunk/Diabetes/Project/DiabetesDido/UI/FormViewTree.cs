using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Accord.MachineLearning.DecisionTrees;

namespace DiabetesDido.UI
{
    public partial class FormViewTree : Form
    {
        private FormViewTree()
        {
            InitializeComponent();
        }

        public FormViewTree(DecisionTree tree)
            : this()
        {
            // Show the learned tree in the view
            decisionTreeView1.TreeSource = tree;
        }


    }
}
