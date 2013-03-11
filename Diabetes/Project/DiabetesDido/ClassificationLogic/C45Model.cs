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
    public class C45Model : ClassificationModel
    {
        private DecisionTree tree;

        public DecisionTree Tree
        {
            get { return tree; }
            private set { tree = value; }
        }

        
        //public static C45Model CreateC45Model(Codification codification)
        //{
        //    int lastIndex = codification.Columns.Count - 1;

        //    List<DecisionVariable> attributes = new List<DecisionVariable>();

        //    for (int indexColumn = 0; indexColumn < lastIndex; indexColumn++)
        //    {
        //        attributes.Add(new DecisionVariable(codification.Columns[indexColumn].ColumnName,
        //            codification[indexColumn].Symbols));
        //    }

        //    C45Model model = new C45Model(new DecisionTree(attributes.ToArray(), 2));

        //    return model;
        //}

        //public C45Model(DecisionTree tree)
        //{
        //    this.Tree = tree;
        //}

        // Trainning decision tree with C4.5 algorithm
        public override void TrainningModel(TrainningData trainningData)
        {
            // Get data for trainning tree
            Codification codification = trainningData.CodificationData;
            double[][] inputs = trainningData.TrainningAttributes;
            int[] outputs = trainningData.ClassificationAttribute;

            // Create tree
            this.Tree = this.CreateDecisionTree(codification); 
            //var attributes = DecisionVariable.FromCodebook(codification, inputColumns);
            //DecisionTree tree = new DecisionTree(attributes, outputClasses: 5);

           
            // Creates a new instance of the C4.5 learning algorithm
            C45Learning c45 = new C45Learning(this.Tree);

            // Learn the decision tree
            double error = c45.Run(inputs, outputs);        
        }

        // Create decision tree
        protected DecisionTree CreateDecisionTree(Codification codification)
        {
            int lastIndex = codification.Columns.Count - 1;

            List<DecisionVariable> attributes = new List<DecisionVariable>();

            for (int indexColumn = 0; indexColumn < lastIndex; indexColumn++)
            {
                attributes.Add(new DecisionVariable(codification.Columns[indexColumn].ColumnName,
                    codification[indexColumn].Symbols));
            }

            return new DecisionTree(attributes.ToArray(), 2);
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
                    predicted[i] = Properties.Settings.Default.negativeValue;
                }
            return predicted;
        }

        public override string ToString()
        {
            return "C45";
        }
    }
}
