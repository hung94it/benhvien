using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Accord.MachineLearning.Bayes;
using Accord.Math;
using Accord.Statistics.Analysis;
using Accord.Statistics.Filters;
using Accord.Statistics.Distributions;
using Accord.Statistics.Distributions.Univariate;

namespace DiabetesDido.ClassificationLogic
{
    [Serializable]
    public class NaiveBayesModel : ClassificationModel
    {
        private NaiveBayes bayes;        

        public override void TrainningModel(TrainningData trainningData)
        {
            Codification codification = trainningData.CodificationData;            
            int[][] inputs = trainningData.TrainningAttributes.ToInt32();
            int[] outputs = trainningData.ClassifierAttribute;

            int lastIndex = codification.Columns.Count - 1;            

            List<int> symbolCounts = new List<int>();

            for (int indexColumn = 0; indexColumn < lastIndex; indexColumn++)
            {
                symbolCounts.Add(codification[indexColumn].Symbols);
            }

            this.bayes = new NaiveBayes(2, symbolCounts.ToArray());
            this.bayes.Estimate(inputs, outputs); 
        }

        public override int[] ComputeModel(double[][] inputs)
        {
            int[] predicted = new int[inputs.Length];

            for (int i = 0; i < inputs.Length; i++)
                try
                {
                    predicted[i] = this.bayes.Compute(inputs[i].ToInt32());                    
                }
                catch {
                    predicted[i] = Properties.Settings.Default.negativeValue;
                }
                
            return predicted;
        }

        public override string ToString()
        {
            return "Naive Bayes";
        }
    }
}
