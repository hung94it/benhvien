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
        private DAL.DiabetesDataSetBTableAdapters.TrainingSetTableAdapter trainingSetTableAdapter;
        private ClassificationData classificationDataForApp;
        // Active model
        private LearningAlgorithm activeLearningAlgorithm;
        // Dictionary contains model
        private Dictionary<LearningAlgorithm, ModelType> modelList;

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

        internal ClassificationData ClassificationDataForApp
        {
            get { return classificationDataForApp; }
            set { classificationDataForApp = value; }
        }

        public TreeX()
        {
            InitializeComponent();

            this.trainingSetTableAdapter = new DAL.DiabetesDataSetBTableAdapters.TrainingSetTableAdapter();                              

            //this.ClassificationModelForApp = new ClassificationModel();
            this.radioButtonC45.Checked = true;
            this.ActiveLearningAlgorithm = LearningAlgorithm.C45;
            this.ModelList = new Dictionary<LearningAlgorithm, ModelType>();
            
        }

        private void TreeX_Load(object sender, EventArgs e)
        {
            //DAL.DiabetesDataSetBTableAdapters.DataTable1TableAdapter testSet1TableAdapter = new DAL.DiabetesDataSetBTableAdapters.DataTable1TableAdapter();
            //DataTable trainningDataTable = testSet1TableAdapter.GetData();

            DataTable trainningDataTable = trainingSetTableAdapter.GetData();
            this.dataGridView1.DataSource = trainningDataTable;
            this.classificationDataForApp = new ClassificationData(this.dataGridView1.DataSource as DataTable);
        }

        // buttonCreateModel click event
        private void buttonCreateModel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;

            // Ask user what to do when selected model already exists
            if (this.haveModel())
            {
                dialogResult = MessageBox.Show("Model này đã có. Bạn có muốn tạo mô hình mới", "Tạo mới", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == System.Windows.Forms.DialogResult.Yes)
                {
                    this.CreateModel(this.ClassificationDataForApp);
                }
            }
            else // If selected model not exists then create new model
            {
                this.CreateModel(this.ClassificationDataForApp);
            }

        }

        // buttonTestModel click event
        private void buttonTestModel_Click(object sender, EventArgs e)
        {
            if (!this.haveModel())
            {
                MessageBox.Show("Chọn thuật toán rồi tạo mô hình đi ku", "Vậy mà cũng ko biết", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            //DAL.DiabetesDataSetBTableAdapters.TestSet1TableAdapter testSet1TableAdapter = new DAL.DiabetesDataSetBTableAdapters.TestSet1TableAdapter();
            //DataTable discreteDataTable = testSet1TableAdapter.GetData();

            DAL.DiabetesDataSetBTableAdapters.TestSetTableAdapter testSetTableAdapter = new DAL.DiabetesDataSetBTableAdapters.TestSetTableAdapter();
            DataTable discreteDataTable = testSetTableAdapter.GetData();

            //DataTable discreteDataTable = trainingSetTableAdapter.GetData();    

            ClassificationData data = new ClassificationData(discreteDataTable);

            dataGridView2.DataSource = this.ModelList[ActiveLearningAlgorithm].TestModel(data);
        }


        // buttonViewModel click event
        private void buttonViewModel_Click(object sender, EventArgs e)
        {
            if (this.haveModel())
            {                
                switch (this.ActiveLearningAlgorithm)
                {

                    case LearningAlgorithm.C45:
                    case LearningAlgorithm.ID3:
                        new FormDecisionTree((this.GetModel() as DecisionTreeModel).Tree).Show();
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
