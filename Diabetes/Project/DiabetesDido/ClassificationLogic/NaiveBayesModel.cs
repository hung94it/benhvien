﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Accord.MachineLearning.Bayes;
using Accord.Math;
using Accord.Statistics.Analysis;
using Accord.Statistics.Filters;

namespace DiabetesDido.ClassificationLogic
{
    [Serializable]
    public class NaiveBayesModel : ClassificationModel
    {
        private NaiveBayes bayes;
        public NaiveBayes Bayes
        {
            get { return bayes; }
            private set { bayes = value; }
        }

        public override void TrainningModel(TrainningData trainningData)
        {
            Codification codification = trainningData.CodificationData;
            int[][] inputs = trainningData.TrainningAttributes.ToInt32();
            int[] outputs = trainningData.ClassifierAttribute;

            int lastIndex = codification.Columns.Count - 1;
            int numberOfClass = codification[lastIndex].Symbols;

            List<int> symbolCounts = new List<int>();

            for (int indexColumn = 0; indexColumn < lastIndex; indexColumn++)
            {
                symbolCounts.Add(codification[indexColumn].Symbols);
            }

            this.Bayes = new NaiveBayes(numberOfClass, symbolCounts.ToArray());
            this.Bayes.Estimate(inputs, outputs); 
        }

        public override int[] ComputeModel(double[][] inputs)
        {
            int[] predicted = new int[inputs.Length];

            for (int i = 0; i < inputs.Length; i++)
                try
                {
                    predicted[i] = this.Bayes.Compute(inputs[i].ToInt32());
                }
                catch {
                    predicted[i] = Properties.Settings.Default.negativeValue;
                }
                //predicted[i] = this.Bayes.Compute(inputs[i].ToInt32());
            return predicted;
        }

        public override string ToString()
        {
            return "Naive Bayes";
        }
    }
}