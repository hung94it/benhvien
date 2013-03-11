using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Accord.MachineLearning;
using Accord.MachineLearning.VectorMachines.Learning;
using Accord.MachineLearning.VectorMachines;
using Accord.Statistics.Kernels;
using Accord.Math;

namespace DiabetesDido.UI
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private void continuousDataBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.continuousDataBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.diabetesDataSetB);

        }

        private void Test_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'diabetesDataSetB.ContinuousData' table. You can move, or remove it, as needed.
            this.continuousDataTableAdapter.Fill(this.diabetesDataSetB.ContinuousData);

            // This is a sample code on how to use Cross-Validation 
            // to access the performance of Support Vector Machines. 

            // Consider the example binary data. We will be trying 
            // to learn a XOR problem and see how well does SVMs 
            // perform on this data. 

            double[][] data =
{
    new double[] { -1, -1 }, new double[] {  1, -1 },
    new double[] { -1,  1 }, new double[] {  1,  1 },
    new double[] { -1, -1 }, new double[] {  1, -1 },
    new double[] { -1,  1 }, new double[] {  1,  1 },
    new double[] { -1, -1 }, new double[] {  1, -1 },
    new double[] { -1,  1 }, new double[] {  1,  1 },
    new double[] { -1, -1 }, new double[] {  1, -1 },
    new double[] { -1,  1 }, new double[] {  1,  1 },
};

            int[] xor = // result of xor for the sample input data
{
    -1,       1,
     1,      -1,
    -1,       1,
     1,      -1,
    -1,       1,
     1,      -1,
    -1,       1,
     1,      -1,
};


            // Create a new Cross-validation algorithm passing the data set size and the number of folds 
            var crossvalidation = new CrossValidation<KernelSupportVectorMachine>(size: data.Length, folds: 3);

            // Define a fitting function using Support Vector Machines. The objective of this 
            // function is to learn a SVM in the subset of the data dicted by cross-validation.

            crossvalidation.Fitting = delegate(int k, int[] indicesTrain, int[] indicesValidation)
            {
                // The fitting function is passing the indices of the original set which 
                // should be considered training data and the indices of the original set 
                // which should be considered validation data. 

                // Lets now grab the training data: 
                var trainingInputs = data.Submatrix(indicesTrain);
                var trainingOutputs = xor.Submatrix(indicesTrain);

                // And now the validation data: 
                var validationInputs = data.Submatrix(indicesValidation);
                var validationOutputs = xor.Submatrix(indicesValidation);


                // Create a Kernel Support Vector Machine to operate on the set 
                var svm = new KernelSupportVectorMachine(new Polynomial(2), 2);

                // Create a training algorithm and learn the training data 
                var smo = new SequentialMinimalOptimization(svm, trainingInputs, trainingOutputs);

                double trainingError = smo.Run();

                // Now we can compute the validation error on the validation data: 
                double validationError = smo.ComputeError(validationInputs, validationOutputs);

                // Return a new information structure containing the model and the errors achieved. 
                return new CrossValidationValues<KernelSupportVectorMachine>(svm, trainingError, validationError);
            };

            //crossvalidation.CreatePartitions(2, data,out xor);

            // Compute the cross-validation 
            var result = crossvalidation.Compute();

            // Finally, access the measured performance. 
            double trainingErrors = result.Training.Mean;
            double validationErrors = result.Validation.Mean;



        }

    }
}
