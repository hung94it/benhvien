using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Accord.Controls;
using Accord.MachineLearning.Bayes;
using Accord.MachineLearning.DecisionTrees;
using Accord.MachineLearning.DecisionTrees.Learning;
using Accord.Math;
using Accord.Statistics.Analysis;
using Accord.Statistics.Distributions.Univariate;
using Accord.Statistics.Filters;
using DiabetesDido.ClassificationLogic;

namespace DiabetesDido.UI
{
    public partial class TreeX : Form
    {
        // Active model
        private LearningAlgorithm activeLearningAlgorithm;
        // Dictionary contains model
        private Dictionary<LearningAlgorithm, ModelType> modelList;
        private ClassificationData classificationData;
        private DataTable trainningData;
        private DataTable testData;

        internal Dictionary<LearningAlgorithm, ModelType> ModelList
        {
            get { return modelList; }
            set { modelList = value; }
        }

        internal LearningAlgorithm ActiveLearningAlgorithm
        {
            get { return activeLearningAlgorithm; }
            set { activeLearningAlgorithm = value; }
        }

        public TreeX()
        {
            InitializeComponent();            
            
            this.radioButtonC45.Checked = true;
            this.ActiveLearningAlgorithm = LearningAlgorithm.C45;
            this.ModelList = new Dictionary<LearningAlgorithm, ModelType>();

            // TrainningSet & TestSet without Na, K, Cl, Ca
            DAL.DiabetesDataSetBTableAdapters.DataTable1TableAdapter dataTable1TableAdapter = new DAL.DiabetesDataSetBTableAdapters.DataTable1TableAdapter();
            this.trainningData = dataTable1TableAdapter.GetData();            
            DAL.DiabetesDataSetBTableAdapters.TestSet1TableAdapter testSet1TableAdapter = new DAL.DiabetesDataSetBTableAdapters.TestSet1TableAdapter();
            this.testData = testSet1TableAdapter.GetData();

            //// TrainningSet & TestSet with Na, K, Cl, Ca
            //DAL.DiabetesDataSetBTableAdapters.TrainingSetTableAdapter trainingSetTableAdapter = new DAL.DiabetesDataSetBTableAdapters.TrainingSetTableAdapter();
            //this.trainningData = trainingSetTableAdapter.GetData();
            //DAL.DiabetesDataSetBTableAdapters.TestSetTableAdapter testSetTableAdapter = new DAL.DiabetesDataSetBTableAdapters.TestSetTableAdapter();
            //this.testData = testSetTableAdapter.GetData();

            //// Test data same as trainning data
            //this.testData = this.trainningData;

            this.dataGridView1.DataSource = this.trainningData;
        }

        // buttonCreateModel click event
        private void buttonCreateModel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            this.classificationData = new ClassificationData(this.trainningData);

            // Ask user what to do when selected model already exists
            if (this.HaveModel())
            {
                dialogResult = MessageBox.Show("Model này đã có. Bạn có muốn tạo mô hình mới", "Tạo mới", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == System.Windows.Forms.DialogResult.Yes)
                {
                    this.CreateModel(this.classificationData);
                }
            }
            else // If selected model not exists then create new model
            {
                this.CreateModel(this.classificationData);
            }

        }

        // buttonTestModel click event
        private void buttonTestModel_Click(object sender, EventArgs e)
        {
            if (!this.HaveModel())
            {
                MessageBox.Show("Chọn thuật toán rồi tạo mô hình đi ku", "Vậy mà cũng ko biết", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }               

            ClassificationData data = new ClassificationData(this.testData);
            // Show test result
            dataGridView2.DataSource = this.ModelList[ActiveLearningAlgorithm].TestModel(data);
        }


        // buttonViewModel click event
        private void buttonViewModel_Click(object sender, EventArgs e)
        {
            if (this.HaveModel())
            {                
                switch (this.ActiveLearningAlgorithm)
                {

                    case LearningAlgorithm.C45:
                    case LearningAlgorithm.ID3:
                        new FormDecisionTree((this.GetModel() as DecisionTreeModel).Tree, this.classificationData).Show();
                        break;
                    case LearningAlgorithm.NaiveBayes:
                        MessageBox.Show("Chưa làm");
                        break;
                }
            }
            else
            {
                MessageBox.Show("Chưa có model cho thuật toán này");
            }
        }        

        // Get selected learning algorithm from user
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton checkedRadioButton = sender as RadioButton;

            // Ensure that the RadioButton.Checked property changed to true.             
            if (checkedRadioButton.Checked)
            {
                this.ActiveLearningAlgorithm =
                    (LearningAlgorithm)Enum.Parse(typeof(LearningAlgorithm), checkedRadioButton.Tag as string);
            }
        }

        // Get active model
        public ModelType GetModel()
        {
            return this.ModelList[this.ActiveLearningAlgorithm];
        }

        // Create model base on active learning algorithm
        private void CreateModel(ClassificationData classificationData)
        {
            // Check dictionary already have active model. If not add new model
            if (!this.ModelList.ContainsKey(this.ActiveLearningAlgorithm))
            {
                this.ModelList.Add(this.ActiveLearningAlgorithm, ModelType.CreateModel(this.ActiveLearningAlgorithm));
            }

            // Trainning model
            this.ModelList[ActiveLearningAlgorithm].TrainningModel(classificationData);
        }

        // Check activeAlgorithm already have model or not
        public bool HaveModel()
        {
            if (!this.ModelList.ContainsKey(this.ActiveLearningAlgorithm))
            {
                return false;
            }
            return (this.ModelList[this.ActiveLearningAlgorithm] != null ? true : false);
        }
    }

}
