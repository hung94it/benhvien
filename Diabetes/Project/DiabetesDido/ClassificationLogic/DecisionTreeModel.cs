using System.Collections.Generic;
using Accord.MachineLearning.DecisionTrees;
using Accord.Statistics.Analysis;
using Accord.Statistics.Filters;

namespace DiabetesDido.ClassificationLogic
{
    public abstract class DecisionTreeModel : ModelType
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

        // Test decision tree
        public override List<Accord.Statistics.Analysis.ConfusionMatrix> TestModel(TrainningData trainningData)
        {
            int[] expected = trainningData.ClassifierAttribute;
            double[][] inputs = trainningData.DoubleTrainningAttributes;
            int[] predicted = new int[inputs.Length];

            for (int i = 0; i < inputs.Length; i++)
                try
                {
                    predicted[i] = this.Tree.Compute(inputs[i]);
                }
                catch { 
                }

            ConfusionMatrix confusionMatrix = new ConfusionMatrix(predicted, expected, 0, 1);
            return new List<ConfusionMatrix> { confusionMatrix };
        }
    }
}
