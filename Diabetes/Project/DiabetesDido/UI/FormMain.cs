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
        private Dictionary<LearningAlgorithm, ClassificationModel> modelList;

        // Tab Dianosis's variables
        private TrainningData trainningDataTabDianosis;

        // Tab Create Model's variables               
        private LearningAlgorithm activeLearningAlgorithm;                

        // Tab Preprocessing Data's variables               
        private DiabetesDataSetB.ContinuousDataDataTable continuousDataTable;
        private DataTable dtDataSetTempForPreProcessing;
        private DataTable dtDataSetForPreProcessing;

        public FormMain()
        {
            InitializeComponent();
                               
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
                    int totalAttributeFormDatabase = (int)discreteIntervalTableAdapter.TotalAttributes();
                    int totalAttributeFromSetting = getColumnNames().Length;

                    if (totalAttributeFormDatabase + 1== totalAttributeFromSetting)
                    {
                        refreshTabCreateModel();
                        if (this.codification == null)
                        {
                            this.codification = new Codification(getDataTableForCodification());
                        }
                    }
                    else {
                        (sender as SuperTabControl).SelectedTabIndex = 0;
                        MessageBox.Show("Chưa có dữ liệu rời rạc!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }


                    //DataTable codificationDatatable = getDataTableForCodification();

                    //if (this.isDiscreteTabProcessingData)
                    //{
                    //    refreshTabCreateModel();
                    //    this.codification = new Codification(codificationDatatable);
                    //}
                    //else 
                    //{
                    //    (sender as SuperTabControl).SelectedTabIndex = 0;
                    //    MessageBox.Show("Chưa có dữ liệu rời rạc!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //    return;
                    //}
                    break;
                default:
                    break;
            }
        }
        
        // Include only attributes in test
        private string[] getContinuosColumnNames()
        {
            return Properties.Settings.Default.AttributeColumnNames.Split(',');
        }

        // Include other attributes for trainning
        private string[] getTrainningColumnNames()
        {
            List<string> columnNamesList = new List<string>(new string[] { "Tuoi", "GioiTinh" });            
            columnNamesList.AddRange(getContinuosColumnNames());            

            return columnNamesList.ToArray();
        }

        // Include all attributes
        private string[] getColumnNames()
        {
            List<string> columnNamesList = new List<string>(getTrainningColumnNames());
            columnNamesList.Add(Properties.Settings.Default.ClassColumnName);

            return columnNamesList.ToArray();
        }

    }
}