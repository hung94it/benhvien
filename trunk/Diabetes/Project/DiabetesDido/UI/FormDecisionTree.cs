using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Accord.MachineLearning.DecisionTrees;
using DiabetesDido.ClassificationLogic;

namespace DiabetesDido.UI
{
    public partial class FormDecisionTree : Form
    {
        private TrainningData trainningData;

        private FormDecisionTree()
        {
            InitializeComponent();
        }

        public FormDecisionTree(DecisionTree tree, TrainningData data)
            : this()
        {
            this.trainningData = data;

            // Show the learned tree in the view
            decisionTreeView.TreeSource = tree;
            decisionTreeView.SetNodeName(this.trainningData);
            
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
                attributeName = this.trainningData.LastColumnName;
                attributeValue = this.trainningData.DiscreteCodification.Translate(attributeName, Convert.ToInt32(node.Output));

                if (node.Output.HasValue)
                {
                    if (attributeValue.Equals("Yes"))
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
                    attributeValue = this.trainningData.DiscreteCodification.Translate(attributeName, Convert.ToInt32(child.Value));

                    connectSymbol = stringTemp.Equals("") ? "" : " & ";

                    CreateRuleList(child, stringTemp + connectSymbol + attributeName + " = " + attributeValue);                   
                }
            }
        }
    }
}
