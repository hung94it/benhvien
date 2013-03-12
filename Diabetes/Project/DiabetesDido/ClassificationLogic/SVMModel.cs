using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Accord.MachineLearning.VectorMachines;
using Accord.Statistics.Filters;
using Accord.MachineLearning.VectorMachines.Learning;
using Accord.Statistics.Kernels;
using Accord.Math;
using System.Data;
using DiabetesDido.DAL.DiabetesDataSetBTableAdapters;
using Accord.Statistics.Analysis;

namespace DiabetesDido.ClassificationLogic
{
    [Serializable]
    class SVMModel : ClassificationModel
    {
        //private SupportVectorMachine svm;
        private KernelSupportVectorMachine svm;

        //public SupportVectorMachine SVM
        //{
        //    get { return svm; }
        //    private set { svm = value; }
        //}

        public override void TrainningModel(TrainningData trainningData)
        {
            ContinuousDataTableAdapter continuousDataTableAdapter = new ContinuousDataTableAdapter();

            DataTable continuousDataTable = continuousDataTableAdapter.GetData();
            DataTable dataTable = continuousDataTable.DefaultView.ToTable(false, TableMetaData.TestingAttributes);
            string[] columnNames;
            double[][] inputs = dataTable.ToArray(out columnNames);
            int[] outputs = (int[])trainningData.ClassificationAttribute.Clone();

            // Create output for SVM (-1 or 1)
            for (int index = 0; index < outputs.Length; index++)
            {
                if (outputs[index] == 0)
                {
                    outputs[index] = -1;
                }
            }

            // Create a Support Vector Machine for the given inputs
            //this.svm = new SupportVectorMachine(inputs[0].Length);

            //// Create a Kernel Support Vector Machine for the given inputs
            this.svm = new KernelSupportVectorMachine(new Gaussian(0.1), inputs[0].Length);

            // Instantiate a new learning algorithm for SVMs
            SequentialMinimalOptimization smo = new SequentialMinimalOptimization(svm, inputs, outputs);

            // Set up the learning algorithm
            smo.Complexity = 1.0;

            // Run the learning algorithm 
            double error = smo.Run();
        }

        public override List<ConfusionMatrix> TestModel(TrainningData trainningData)
        {
            ContinuousDataTableAdapter continuousDataTableAdapter = new ContinuousDataTableAdapter();

            DataTable continuousDataTable = continuousDataTableAdapter.GetData();
            DataTable dataTable = continuousDataTable.DefaultView.ToTable(false, TableMetaData.TestingAttributes);
            string[] columnNames;
            double[][] inputs = dataTable.ToArray(out columnNames);

            int[] expected = trainningData.ClassificationAttribute;
            int[] predicted = ComputeModel(inputs);
            int positiveValue = trainningData.PositiveValue;
            int negativeValue = trainningData.NegativeValue;

            ConfusionMatrix confusionMatrix = new ConfusionMatrix(predicted, expected, positiveValue, negativeValue);
            return new List<ConfusionMatrix> { confusionMatrix };
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
