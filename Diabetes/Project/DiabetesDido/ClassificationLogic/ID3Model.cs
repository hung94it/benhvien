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
        public override void TrainningModel(TrainningData trainningData)
        {
            // Get data for trainning tree
            Codification codification = trainningData.DiscreteCodification;
            int[][] inputs = trainningData.TrainningAttributes.ToInt32();
            int[] outputs = trainningData.ClassifierAttribute;

            // Create tree
            this.Tree = this.CreateDecisionTree(codification);

            // Create a new instance of the ID3 algorithm
            ID3Learning id3learning = new ID3Learning(this.Tree);

            // Learn the training instances!
            id3learning.Run(inputs, outputs);
        }

    }
}
