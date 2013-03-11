// Accord Statistics Controls Library
// The Accord.NET Framework
// http://accord.googlecode.com
//
// Copyright © César Souza, 2009-2012
// cesarsouza at gmail.com
//
//    This library is free software; you can redistribute it and/or
//    modify it under the terms of the GNU Lesser General Public
//    License as published by the Free Software Foundation; either
//    version 2.1 of the License, or (at your option) any later version.
//
//    This library is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
//    Lesser General Public License for more details.
//
//    You should have received a copy of the GNU Lesser General Public
//    License along with this library; if not, write to the Free Software
//    Foundation, Inc., 51 Franklin St, Fifth Floor, Boston, MA  02110-1301  USA
//

namespace DiabetesDido.UI
{
    using System.Windows.Forms;
    using Accord.MachineLearning.DecisionTrees;
    using DiabetesDido.ClassificationLogic;
    using System;
    using Accord.Statistics.Filters;
    using System.Drawing;

    /// <summary>
    ///   Decision Tree (DT) Viewer.
    /// </summary>
    /// 
    public partial class DecisionTreeViewDiabetes : UserControl
    {
        private DecisionTree treeSource;
        
        private Codification codification;

        /// <summary>
        ///   Initializes a new instance of the <see cref="DecisionTreeViewDiabetes"/> class.
        /// </summary>
        /// 
        public DecisionTreeViewDiabetes()
        {
            InitializeComponent();

        }

        /// <summary>
        ///   Gets or sets the currently displayed
        ///   <see cref="DecisionTree">Decision Tree</see>.
        /// </summary>
        /// 
        /// <value>The decision tree being displayed.</value>
        /// 
        public DecisionTree TreeSource
        {
            get { return treeSource; }
            private set
            {
                    treeSource = value;
            }
        }

        // Create tree
        public void SetTree(DecisionTree tree, Codification codification)
        {
            this.treeSource = tree;            
            this.codification = codification;

            treeView1.Nodes.Clear();

            if (treeSource != null && treeSource.Root != null)
                treeView1.Nodes.Add(convert(TreeSource.Root));
            
        }

        public void viewRule(string rule)
        {
            TreeNode node = treeView1.Nodes[0];
            node.Expand();
            

            string[] attribute = rule.Split(' ');

            for (int i = 0; i < attribute.Length; i++)
            {
                foreach (TreeNode childNode in node.Nodes)
                {
                    if (childNode.Text.Equals(attribute[i]))
                    {            
                        node = node.Nodes[childNode.Index];
                        node.Expand();
                        node.ForeColor = Color.Blue;
                        break;
                    }
                }
            }
        }

        // Regress tree
        private TreeNode convert(DecisionNode node)
        {
            string attributeName;
            string attributeValue;

            TreeNode treeNode;

            // Add root
            if (node.IsRoot)
            {
                treeNode = new TreeNode(node.ToString());
            }
            else
            {
                attributeName = node.Owner.Attributes[node.Parent.Branches.AttributeIndex].Name;
                attributeValue = this.codification.Translate(attributeName, Convert.ToInt32(node.Value));

                // Create new treeNode to TreeView
                treeNode = new TreeNode(attributeName + "=" + attributeValue);
            }
                                    
            // If node is leaf
            if (node.IsLeaf)
            {
                // If node has value add classifier value
                if (node.Output.HasValue)
                {
                    attributeName = Properties.Settings.Default.ClassColumnName;
                    attributeValue = this.codification.Translate(attributeName, Convert.ToInt32(node.Output));

                    treeNode.Nodes.Add(new TreeNode(attributeValue));
                }
                    // Add ""
                else
                { 
                    treeNode.Nodes.Add(new TreeNode(node.Output.ToString()));
                }
            }
                // Regress all child nodes
            else
            {
                foreach (var child in node.Branches)
                {
                    treeNode.Nodes.Add(convert(child));
                }
            }

            return treeNode;
        }
    }


}
