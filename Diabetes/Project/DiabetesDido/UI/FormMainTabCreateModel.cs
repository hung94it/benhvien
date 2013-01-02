using System;
using System.Collections.Generic;
using System.Linq;
//using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Accord.Controls;
using Accord.MachineLearning.Bayes;
using Accord.MachineLearning.DecisionTrees;
using Accord.MachineLearning.DecisionTrees.Learning;
using Accord.Math;
using Accord.Statistics.Analysis;
//using Accord.Statistics.Distributions.Univariate;
using Accord.Statistics.Filters;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using DiabetesDido.ClassificationLogic;
using DiabetesDido.DAL.DiabetesDataSetBTableAdapters;

namespace DiabetesDido.UI
{
    public partial class FormMain
    {
        private TrainningDataTableAdapter trainningDataTAbleAdapter;
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
            private set { modelList = value; }
        }

        internal LearningAlgorithm ActiveLearningAlgorithm
        {
            get { return activeLearningAlgorithm; }
            set { activeLearningAlgorithm = value; }
        }

        public void InitializeTabCreateModel()
        {            
            this.checkBoxXNaiveBayes.Checked = true;
            this.ActiveLearningAlgorithm = LearningAlgorithm.NaiveBayes;
            this.ModelList = new Dictionary<LearningAlgorithm, ModelType>();

            trainningDataTAbleAdapter = new TrainningDataTableAdapter();            
            this.trainningData = trainningDataTAbleAdapter.GetData();
            
            //// TrainningSet & TestSet without Na, K, Cl, Ca
            //DataTable1TableAdapter dataTable1TableAdapter = new DataTable1TableAdapter();
            //this.trainningData = dataTable1TableAdapter.GetData();            
            //TestSet1TableAdapter testSet1TableAdapter = new TestSet1TableAdapter();
            //this.testData = testSet1TableAdapter.GetData();

            //// TrainningSet & TestSet with Na, K, Cl, Ca
            //TrainingSetTableAdapter trainingSetTableAdapter = new TrainingSetTableAdapter();
            //this.trainningData = trainingSetTableAdapter.GetData();
            //TestSetTableAdapter testSetTableAdapter = new TestSetTableAdapter();
            //this.testData = testSetTableAdapter.GetData();

            // Test data same as trainning data
            this.testData = this.trainningData;

            this.dataGridViewXTrainning.DataSource = this.trainningData;

            List<Percent> percent = new List<Percent>();
            //percent.Add(new Percent("50%", 50));
            //percent.Add(new Percent("60%", 60));
            //percent.Add(new Percent("70%", 70));
            //percent.Add(new Percent("80%", 80));
            percent.Add(new Percent("90%", 90));
            percent.Add(new Percent("100%", 0));

            comboBoxExTrainningDataPercent.DataSource = percent;
            comboBoxExTrainningDataPercent.DisplayMember = "Name";
            comboBoxExTrainningDataPercent.ValueMember = "Value";
            if (this.comboBoxExTrainningDataPercent.Items.Count > 0)
            {
                this.comboBoxExTrainningDataPercent.SelectedIndex = 0;
            }
        }

        // buttonXCreateModel click event
        private void buttonXCreateModel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            DataTable trainningTable = this.trainningData.Clone();
            int countTrainningData = 0;

            if (this.comboBoxExTrainningDataPercent.SelectedValue != null)
            {
                countTrainningData = Convert.ToInt32(Math.Truncate((int)comboBoxExTrainningDataPercent.SelectedValue * 1.0 * this.trainningData.Rows.Count / 100));
            }

            var query = this.trainningData.Rows.Cast<DataRow>().Skip(countTrainningData);
            this.testData = query.CopyToDataTable<DataRow>();

            if (countTrainningData == 0)
            {
                trainningTable = this.trainningData;
            }
            else
            {
                query = this.trainningData.Rows.Cast<DataRow>().Take(countTrainningData);
                trainningTable = query.CopyToDataTable<DataRow>();
            }
            
            this.classificationData = new ClassificationData(trainningTable);

            //this.classificationData = new ClassificationData(this.trainningData);

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

        // buttonXTestModel click event
        private void buttonXTestModel_Click(object sender, EventArgs e)
        {
            if (!this.HaveModel())
            {
                MessageBox.Show("Chọn thuật toán rồi tạo mô hình đi ku", "Vậy mà cũng ko biết", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }               

            ClassificationData data = new ClassificationData(this.testData);
            // Show test result
            dataGridViewXTrainningResult.DataSource = this.ModelList[ActiveLearningAlgorithm].TestModel(data);
        }


        // buttonXViewModel click event
        private void buttonXViewModel_Click(object sender, EventArgs e)
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
        private void checkBoxXTabCreateModel_CheckedChanged(object sender, EventArgs e)
        {
            CheckBoxX checkedRadioButton = sender as CheckBoxX;

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
