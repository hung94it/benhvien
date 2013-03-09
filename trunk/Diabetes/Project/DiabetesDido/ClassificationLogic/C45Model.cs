using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Accord.MachineLearning.DecisionTrees.Learning;
using Accord.Statistics.Filters;
using Accord.MachineLearning.DecisionTrees;

namespace DiabetesDido.ClassificationLogic
{
    [Serializable]
    public class C45Model : DecisionTreeModel
    {

        public static C45Model CreateC45Model(Codification codification)
        {
            int lastIndex = codification.Columns.Count - 1;

            List<DecisionVariable> attributes = new List<DecisionVariable>();

            for (int indexColumn = 0; indexColumn < lastIndex; indexColumn++)
            {
                attributes.Add(new DecisionVariable(codification.Columns[indexColumn].ColumnName,
                    codification[indexColumn].Symbols));
            }

            C45Model model = new C45Model(new DecisionTree(attributes.ToArray(), 2));

            return model;
        }

        public C45Model(DecisionTree tree)
        {
            this.Tree = tree;
        }

        // Trainning decision tree with C4.5 algorithm
        public override void TrainningModel(TrainningData trainningData)
        {
            // Get data for trainning tree
            Codification codification = trainningData.CodificationData;
            double[][] inputs = trainningData.TrainningAttributes;
            int[] outputs = trainningData.ClassifierAttribute;

            // Create tree
            this.Tree = this.CreateDecisionTree(codification); 
           
            // Creates a new instance of the C4.5 learning algorithm
            C45Learning c45 = new C45Learning(this.Tree);

            // Learn the decision tree
            double error = c45.Run(inputs, outputs);
        }

        public override string ToString()
        {
            return "C45";
        }
    }
}
