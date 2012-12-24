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

    /// <summary>
    ///   Decision Tree (DT) Viewer.
    /// </summary>
    /// 
    public partial class DecisionTreeView : UserControl
    {
        private DecisionTree treeSource;

        private ClassificationData classificationData;

        /// <summary>
        ///   Initializes a new instance of the <see cref="DecisionTreeView"/> class.
        /// </summary>
        /// 
        public DecisionTreeView()
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
            set
            {
                if (treeSource != value)
                {
                    treeSource = value;
                    update();
                }
            }
        }


        private void update()
        {
            treeView1.Nodes.Clear();

            if (treeSource != null && treeSource.Root != null)
                treeView1.Nodes.Add(convert(TreeSource.Root));
        }

        private TreeNode convert(DecisionNode node)
        {
            TreeNode treeNode = new TreeNode(node.ToString());

            if (node.IsLeaf)
            {
                treeNode.Nodes.Add(new TreeNode(node.Output.ToString()));
            }
            else
            {
                foreach (var child in node.Branches)
                    treeNode.Nodes.Add(convert(child));
            }

            return treeNode;
        }

        public void SetNodeName(ClassificationData data)
        {
            this.classificationData = data;

            treeView1.Nodes.Clear();

            if (treeSource != null && treeSource.Root != null)
                treeView1.Nodes.Add(CreateRuleList(TreeSource.Root));
        }

        private TreeNode CreateRuleList(DecisionNode node)
        {
            string attributeName;
            string attributeValue;

            TreeNode treeNode;

            if (node.IsRoot)
            {
                treeNode = new TreeNode(node.ToString());
            }
            else
            {
                attributeName = node.Owner.Attributes[node.Parent.Branches.AttributeIndex].Name;
                attributeValue = this.classificationData.DiscreteCodification.Translate(attributeName, Convert.ToInt32(node.Value));

                treeNode = new TreeNode(attributeName + " = " + attributeValue);
            }
                                    
            if (node.IsLeaf)
            {
                if (node.Output.HasValue)
                {
                    attributeName = this.classificationData.LastColumnName;
                    attributeValue = this.classificationData.DiscreteCodification.Translate(attributeName, Convert.ToInt32(node.Output));

                    treeNode.Nodes.Add(new TreeNode(attributeValue));
                }
                else
                { 
                    treeNode.Nodes.Add(new TreeNode(node.Output.ToString()));
                }
            }
            else
            {
                foreach (var child in node.Branches)
                {
                    //if (child.IsLeaf && !child.Output.HasValue)
                    //    break;
                    treeNode.Nodes.Add(CreateRuleList(child));
                }
            }

            return treeNode;
        }
    }


}
