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
    }

    public abstract class ModelType
    {
        // Factory method return new ModelType
        public static ModelType CreateModel(LearningAlgorithm learningAlgorithm)
        {
            switch (learningAlgorithm)
            { 
                case LearningAlgorithm.C45:
                    return new C45Model();
                    
                case LearningAlgorithm.ID3:
                    return new ID3Model();
                    
                case LearningAlgorithm.NaiveBayes:
                    return new NaiveBayesModel();        
                case LearningAlgorithm.SVM:
                    return new SVMModel();
                default :
                    throw new ArgumentException("Not yet implement model");
            }
        }

        abstract public void TrainningModel(TrainningData trainningData);
        abstract public List<ConfusionMatrix> TestModel(TrainningData trainningData);
        abstract public int[] ComputeModel(double[][] inputs);
    }
}
