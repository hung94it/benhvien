using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DiabetesDido.ClassificationLogic;
using Accord.MachineLearning.DecisionTrees;
using Accord.Statistics.Filters;

namespace DiabetesDido.UI
{
    public partial class FormTreeView : DevComponents.DotNetBar.Metro.MetroForm
    {        
        private Codification codification;

        public FormTreeView()
        {
            InitializeComponent();
        }

        public FormTreeView(DecisionTree tree, Codification codification)
            : this()
        {
            this.codification = codification;

            // Show the learned tree in the view            
            decisionTreeView.SetTree(tree, codification);
            
            if (tree != null && tree.Root != null)
                CreateRuleList(tree.Root, "");
        }

        private void CreateRuleList(DecisionNode node, string stringTemp)
        {
            string attributeName;
            string attributeValue;
            string connectSymbol = "";

            if (node.IsLeaf)
            {
                attributeName = Properties.Settings.Default.ClassColumnName;
                attributeValue = this.codification.Translate(attributeName, Convert.ToInt32(node.Output));

                if (node.Output.HasValue)
                {
                    if (attributeValue.Equals(Properties.Settings.Default.positiveString))
                    {
                        textBoxYesRules.Text += stringTemp + " ==> " + attributeValue + Environment.NewLine + Environment.NewLine;
                    }
                    else
                    {
                        textBoxNoRules.Text += stringTemp + " ==> " + attributeValue + Environment.NewLine + Environment.NewLine;
                    }
                }
            }
            else
            {
                foreach (var child in node.Branches)
                {
                    attributeName = child.Owner.Attributes[child.Parent.Branches.AttributeIndex].Name;
                    attributeValue = this.codification.Translate(attributeName, Convert.ToInt32(child.Value));

                    connectSymbol = stringTemp.Equals("") ? "" : " & ";

                    CreateRuleList(child, stringTemp + connectSymbol + attributeName + " = " + attributeValue);                   
                }
            }
        }
    }
}