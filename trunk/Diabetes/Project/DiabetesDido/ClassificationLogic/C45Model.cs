using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Accord.MachineLearning.DecisionTrees.Learning;
using Accord.Statistics.Analysis;
using Accord.Statistics.Filters;

namespace DiabetesDido.ClassificationLogic
{
    public class C45Model : DecisionTreeModel
    {
        // Trainning decision tree with C4.5 algorithm
        public override void TrainningModel(TrainningData trainningData)
        {
            Codification codification = trainningData.DiscreteCodification;
            double[][] inputs = trainningData.DoubleTrainningAttributes;
            int[] outputs = trainningData.ClassifierAttribute;            

            // Create tree
            this.Tree = this.CreateDecisionTree(codification);            
            // Creates a new instance of the C4.5 learning algorithm
            C45Learning c45 = new C45Learning(this.Tree);

            // Learn the decision tree
            double error = c45.Run(inputs, outputs);
        }

        //// Test decision tree
        //public override List<Accord.Statistics.Analysis.ConfusionMatrix> TestModel(ClassificationData classificationData)
        //{
        //    int[] expected = classificationData.ClassifierAttribute;
        //    double[][] inputs = classificationData.DoubleTrainningAttributes;
        //    int[] predicted = new int[inputs.Length];

        //    for (int i = 0; i < inputs.Length; i++)
        //        predicted[i] = this.Tree.Compute(inputs[i]);

        //    ConfusionMatrix confusionMatrix = new ConfusionMatrix(predicted, expected, 0, 1);
        //    return new List<ConfusionMatrix> { confusionMatrix };
        //}
    }
}
