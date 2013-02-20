using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Accord.MachineLearning.VectorMachines;
using Accord.Statistics.Filters;
using Accord.MachineLearning.VectorMachines.Learning;

namespace DiabetesDido.ClassificationLogic
{
    [Serializable]
    class SVMModel : ClassificationModel
    {
        private SupportVectorMachine svm;

        public SupportVectorMachine SVM
        {
            get { return svm; }
            private set { svm = value; }
        }

        public override void TrainningModel(TrainningData trainningData)
        {
            Codification codification = trainningData.CodificationData;
            double[][] inputs = trainningData.TrainningAttributes;
            int[] outputs = (int[])trainningData.ClassifierAttribute.Clone();

            // Create output for SVM (-1 or 1)
            for (int index = 0; index < outputs.Length; index++)
            {
                if (outputs[index] == 0)
                {
                    outputs[index] = -1;
                }
            }

            // Create a Support Vector Machine for the given inputs
            this.svm = new SupportVectorMachine(inputs[0].Length);

            // Instantiate a new learning algorithm for SVMs
            SequentialMinimalOptimization smo = new SequentialMinimalOptimization(svm, inputs, outputs);

            // Set up the learning algorithm
            smo.Complexity = 1.0;

            // Run the learning algorithm 
            double error = smo.Run();
        } 

        // Compute given input
        public override int[] ComputeModel(double[][] inputs)
        {            
            double[] temp = new double[inputs.Length];

            for (int i = 0; i < inputs.Length; i++)
                temp[i] = svm.Compute(inputs[0]);

            int[] predicted = new int[inputs.Length];
            for (int i = 0; i < inputs.Length; i++)
            {
                predicted[i] = System.Math.Sign(svm.Compute(inputs[0]));
                // Change output back to (0 or 1)
                if (predicted[i] == -1)
                {
                    predicted[i] = 0;
                }
            }
            return predicted;
        }

        public override string ToString()
        {
            return "SVM";
        }
    }
}
