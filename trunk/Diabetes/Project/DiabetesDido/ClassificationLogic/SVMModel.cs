using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Accord.MachineLearning.VectorMachines;
using Accord.Statistics.Filters;
using Accord.MachineLearning.VectorMachines.Learning;
using Accord.Statistics.Kernels;
using Accord.Math;

namespace DiabetesDido.ClassificationLogic
{
    [Serializable]
    class SVMModel : ClassificationModel
    {
        private SupportVectorMachine svm;
        //private KernelSupportVectorMachine machine;

        public SupportVectorMachine SVM
        {
            get { return svm; }
            private set { svm = value; }
        }

        public override void TrainningModel(TrainningData trainningData)
        {
            //double[][] inputs = trainningData.DiscreteValueDatatable.ToArray();
            //inputs = inputs.RemoveColumn(
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

            //// Create a Kernel Support Vector Machine for the given inputs
            //this.machine = new KernelSupportVectorMachine(new Gaussian(0.1), inputs[0].Length);

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
            int[] predicted = new int[inputs.Length];
            for (int i = 0; i < inputs.Length; i++)
            {
                predicted[i] = System.Math.Sign(this.svm.Compute(inputs[0]));
                // Change output back to 0
                if (predicted[i] == -1)
                    predicted[i] = 0;                
            }
            return predicted;
        }

        public override string ToString()
        {
            return "SVM";
        }
    }
}
