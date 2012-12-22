using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Accord.MachineLearning.DecisionTrees.Learning;
using Accord.Math;
using Accord.Statistics.Analysis;
using Accord.Statistics.Filters;

namespace DiabetesDido.ClassificationLogic
{
    public class ID3Model : DecisionTreeModel
    {
        // Trainning decision tree with ID3 algorithm
        public override void TrainningModel(ClassificationData classificationData)
        {
            // Get data for trainning tree
            Codification codification = classificationData.DiscreteCodification;
            int[][] inputs = classificationData.IntTrainningAttributes;
            int[] outputs = classificationData.ClassifierAttribute;

            // Create tree
            this.Tree = this.CreateDecisionTree(codification);

            // Create a new instance of the ID3 algorithm
            ID3Learning id3learning = new ID3Learning(this.Tree);

            // Learn the training instances!
            id3learning.Run(inputs, outputs);
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
