using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Accord.Statistics.Analysis;

namespace DiabetesDido.ClassificationLogic
{
    public enum LearningAlgorithm
    {
        ID3,
        C45,
        NaiveBayes,
        SVM,
        NaiveBayesS,
    }

    [Serializable]
    public abstract class ClassificationModel
    {
        // Factory method return new ModelType
        public static ClassificationModel CreateModel(LearningAlgorithm learningAlgorithm)
        {
            switch (learningAlgorithm)
            { 
                case LearningAlgorithm.C45:
                    //return new C45Model();
                    
                case LearningAlgorithm.NaiveBayesS:
                    return new NaiveBayesSModel();
                    
                case LearningAlgorithm.NaiveBayes:
                    return new NaiveBayesModel();        
                case LearningAlgorithm.SVM:
                    return new SVMModel();
                default :
                    throw new ArgumentException("Not yet implement model");
            }
        }

        public abstract void TrainningModel(TrainningData trainningData);       
        public abstract int[] ComputeModel(double[][] inputs);

        public virtual List<ConfusionMatrix> TestModel(TrainningData trainningData)
        {
            int[] expected = trainningData.ClassifierAttribute;
            int[] predicted = ComputeModel(trainningData.TrainningAttributes);
            int positiveValue = trainningData.PositiveValue;
            int negativeValue = trainningData.NegativeValue;

            ConfusionMatrix confusionMatrix = new ConfusionMatrix(predicted, expected, positiveValue, negativeValue);
            return new List<ConfusionMatrix> { confusionMatrix };
        }
    }
}
