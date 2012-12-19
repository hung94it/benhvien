using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Accord.MachineLearning.DecisionTrees;
using Accord.MachineLearning.Bayes;
using Accord.Statistics.Filters;
using Accord.MachineLearning.DecisionTrees.Learning;
using Accord.Math;

namespace DiabetesDido.ClassificationLogic
{
    class ClassificationModel
    {
        private LearningAlgorithm activeLearningAlgorithm;

        private Dictionary<LearningAlgorithm, object> modelList;

        public ClassificationModel()
        {
            Initialize();
        }

        private void Initialize()
        {
            this.ModelList = new Dictionary<LearningAlgorithm, object>();
        }

        internal Dictionary<LearningAlgorithm, object> ModelList
        {
            get { return modelList; }
            private set { modelList = value; }
        }

        internal LearningAlgorithm ActiveLearningAlgorithm
        {
            get { return activeLearningAlgorithm; }
            set { activeLearningAlgorithm = value; }
        }

        public object GetModel()
        {
            return this.ModelList[this.ActiveLearningAlgorithm];
        }

        public void CreateModel(ClassificationData classificationData)
        {
            Codification codification = classificationData.DiscreteCodification;
            double[][] inputs = classificationData.DoubleTrainningAttributes;
            int[] outputs = classificationData.ClassifierAttribute;

            switch (this.ActiveLearningAlgorithm)
            {
                case LearningAlgorithm.C45:

                    if (!this.ModelList.ContainsKey(this.ActiveLearningAlgorithm))
                    {
                        //this.DecisionTreeC45 = CreateDecisionTree(codification);
                        this.ModelList.Add(LearningAlgorithm.C45, CreateDecisionTree(codification));
                        C45Learning c45;
                        // Creates a new instance of the C4.5 learning algorithm
                        c45 = new C45Learning(this.ModelList[LearningAlgorithm.C45] as DecisionTree);

                        // Learn the decision tree
                        double error = c45.Run(inputs, outputs);
                    }
                    break;
                case LearningAlgorithm.ID3:
                    if (!this.ModelList.ContainsKey(this.ActiveLearningAlgorithm))
                    {
                        //this.DecisionTreeID3 = CreateDecisionTree(codification);
                        this.ModelList.Add(LearningAlgorithm.ID3, CreateDecisionTree(codification));
                        // Create a new instance of the ID3 algorithm
                        ID3Learning id3learning = new ID3Learning(this.ModelList[LearningAlgorithm.ID3] as DecisionTree);

                        // Learn the training instances!
                        id3learning.Run(inputs.ToInt32(), outputs);
                    }
                    break;
                case LearningAlgorithm.NaiveBayes:
                    if (!this.ModelList.ContainsKey(this.ActiveLearningAlgorithm))
                    {
                        int lastIndex = codification.Columns.Count - 1;
                        int numberOfClass = codification[lastIndex].Symbols;

                        List<int> symbolCounts = new List<int>();

                        for (int indexColumn = 0; indexColumn < lastIndex; indexColumn++)
                        {
                            symbolCounts.Add(codification[indexColumn].Symbols);
                        }

                        this.ModelList.Add(LearningAlgorithm.NaiveBayes, new NaiveBayes(numberOfClass, symbolCounts.ToArray()));
                        ((NaiveBayes)this.ModelList[LearningAlgorithm.NaiveBayes]).Estimate(inputs.ToInt32(), outputs);

                        //this.naiveBayes = new NaiveBayes(numberOfClass, symbolCounts.ToArray());
                        //this.naiveBayes.Estimate(inputs.ToInt32(), outputs); 
                    }
                    break;
            }
        }

        private DecisionTree CreateDecisionTree(Codification codification)
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

        public bool haveModel()
        {
            if (!this.ModelList.ContainsKey(this.ActiveLearningAlgorithm))
            {
                return false;
            }
            return (this.ModelList[this.ActiveLearningAlgorithm] != null ? true : false);
        }

    }
}
