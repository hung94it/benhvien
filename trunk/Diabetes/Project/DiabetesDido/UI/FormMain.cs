using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Accord.Statistics.Filters;
using DevComponents.DotNetBar;
using DiabetesDido.ClassificationLogic;
using DiabetesDido.DAL.DiabetesDataSetBTableAdapters;
using DiabetesDido.DAL;

namespace DiabetesDido.UI
{
    public partial class FormMain : DevComponents.DotNetBar.Metro.MetroForm
    {
        static DAL.DiabetesDataSetTableAdapters.DataSetTableAdapter datasetTA = new DAL.DiabetesDataSetTableAdapters.DataSetTableAdapter();
        static DAL.DiabetesDataSetTableAdapters.DataSetTempTableAdapter datasetTempTA = new DAL.DiabetesDataSetTableAdapters.DataSetTempTableAdapter();
        static DAL.DiabetesDataSetTableAdapters.BayesObjectTableAdapter bayesObjectTA = new DAL.DiabetesDataSetTableAdapters.BayesObjectTableAdapter();
        static DAL.DiabetesDataSetTableAdapters.NewDataSetTempTableAdapter newDataSetTempTA = new DAL.DiabetesDataSetTableAdapters.NewDataSetTempTableAdapter();

        // All tab's variables
        private Codification codification;
        // Dictionary contains model
        private Dictionary<LearningAlgorithm, ClassificationModel> modelList;

        // Tab Dianosis's variables
        private TrainningData trainningDataTabDianosis;
        private bool isDiscreteTabDianosis;

        // Tab Create Model's variables
        private TrainningTableAdapter trainningTableAdapter;
        // Selecting model
        private LearningAlgorithm activeLearningAlgorithm;        
        private TrainningData trainningDataTabCreate;

        // Tab Preprocessing Data's variables
        private bool isDiscreteTabProcessingData;
        private ContinuousDataTableAdapter continuousDataTableAdapter;
        private DiabetesDataSetB.ContinuousDataDataTable continuousDataTable;
        private DataTable dtDataSetTempForPreProcessing;
        private DataTable dtDataSetForPreProcessing;

        public FormMain()
        {
            InitializeComponent();

            this.isDiscreteTabProcessingData = true;
            this.continuousDataTableAdapter = new ContinuousDataTableAdapter();
            this.trainningTableAdapter = new TrainningTableAdapter();
            this.continuousDataTable = new DiabetesDataSetB.ContinuousDataDataTable();

            InitializeTabPreprocessingData();
            InitializeTabCreateModel();
            InitializeTabDiagnosis();
            
        }

        private void superTabControlMain_SelectedTabChanged(object sender, SuperTabStripSelectedTabChangedEventArgs e)
        {            
            switch ((sender as SuperTabControl).SelectedTabIndex)
            { 
                case 1:
                    DataTable codificationDatatable = getCodification();

                    if (this.isDiscreteTabProcessingData)
                    {
                        refreshTabCreateModel();
                        this.codification = new Codification(codificationDatatable);
                    }
                    else 
                    {
                        (sender as SuperTabControl).SelectedTabIndex = 0;
                        MessageBox.Show("Chưa có dữ liệu rời rạc!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    break;
                default:
                    break;
            }
        }

        private string[] getAttributeColumnNames()
        {
            return Properties.Settings.Default.AttributeColumnNames.Split(',');
        }

        private string[] getAllColumnNames()
        {
            List<string> columnNamesList = new List<string>();
            columnNamesList.AddRange(new string[] { "Tuoi", "GioiTinh" });
            columnNamesList.AddRange(getAttributeColumnNames());
            columnNamesList.Add(Properties.Settings.Default.ClassColumnName);

            return columnNamesList.ToArray();
        }

    }
}