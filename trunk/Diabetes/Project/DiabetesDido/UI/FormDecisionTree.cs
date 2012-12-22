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
    public partial class FormDecisionTree : Form
    {
        private FormDecisionTree()
        {
            InitializeComponent();
        }

        public FormDecisionTree(DecisionTree tree)
            : this()
        {
            // Show the learned tree in the view
            decisionTreeView1.TreeSource = tree;
            
            //TreeNode node = decisionTreeView1.no

            //textBox1.Text 
            if (tree != null && tree.Root != null)
                convert(tree.Root, "");
        }




        private TreeNode convert(DecisionNode node, string stringTemp)
        {
            TreeNode treeNode = new TreeNode(node.ToString());

            if (node.IsLeaf)
            {
                treeNode.Nodes.Add(new TreeNode(node.Output.ToString()));
                textBox1.Text += stringTemp + Environment.NewLine + Environment.NewLine;
            }
            else
            {
                foreach (var child in node.Branches)
                    treeNode.Nodes.Add(convert(child, stringTemp + " & " + child.ToString()));
            }

            return treeNode;
        }
    }
}
