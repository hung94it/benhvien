using System;
using System.Collections.Generic;
using Accord.MachineLearning.DecisionTrees;
using Accord.Statistics.Filters;

namespace DiabetesDido.ClassificationLogic
{
    [Serializable]
    public abstract class DecisionTreeModel : ClassificationModel
    {
        private DecisionTree tree;

        public DecisionTree Tree
        {
            get { return tree; }
            protected set { tree = value; }
        }        

        // Create decision tree
        protected DecisionTree CreateDecisionTree(Codification codification)
        {
            int lastIndex = codification.Columns.Count - 1;
            int numberOfClass = codification[lastIndex].Symbols;

            List<DecisionVariable> attributes = new List<DecisionVariable>();

            for (int indexColumn = 0; indexColumn < lastIndex; indexColumn++)
            {
                attributes.Add(new DecisionVariable(codification.Columns[indexColumn].ColumnName,
                    codification[indexColumn].Symbols));
            }

            return new DecisionTree(attributes.ToArray(), numberOfClass);
        }

        public override int[] ComputeModel(double[][] inputs)
        {
            int[] predicted = new int[inputs.Length];

            for (int i = 0; i < inputs.Length; i++)
                try
                {
                    predicted[i] = this.Tree.Compute(inputs[i]);
                }
                catch
                {
                }
            return predicted;
        }
    }
}
