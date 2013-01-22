using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DiabetesDido.DAL.DiabetesDataSetTableAdapters;

namespace DiabetesDido.UI
{
    public partial class FormCustomDataDiscretization : DevComponents.DotNetBar.Metro.MetroForm
    {
        private String ColName = "";
        private int Interval = 0;
        private List<String> listInterval = new List<string>();
        private List<double> listIntervalValue = new List<double>();
        public FormCustomDataDiscretization()
        {
            InitializeComponent();
        }
        public FormCustomDataDiscretization(String colName,int invertal)
        {
            InitializeComponent();
            this.ColName = colName;
            this.Interval = invertal;

        }
        private void FormCustomDataDiscretization_Load(object sender, EventArgs e)
        {
            groupPanel.Text = this.ColName;
            for (int i = 0; i < this.Interval; i++)
            {
                listInterval.Add("Khoảng " + (i + 1).ToString());
                listIntervalValue.Add(0);
                comboBoxExInterval.Items.Add(listInterval[i]);
            }
            comboBoxExInterval.SelectedIndex = -1;
        }

        private void comboBoxExInterval_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = comboBoxExInterval.SelectedIndex;
            if (i == 0)
                buttonXInputIntervalValue.Enabled = false;
            else
                buttonXInputIntervalValue.Enabled = true;
            doubleInputIntervalValue.Value = listIntervalValue[i];
        }

        private void buttonXInputIntervalValue_Click(object sender, EventArgs e)
        {

            int selectedIndex = comboBoxExInterval.SelectedIndex;
            double inputValue = doubleInputIntervalValue.Value;
            if (selectedIndex != -1)
                listIntervalValue[selectedIndex] = inputValue;
        }

        private void buttonXDataDiscretization_Click(object sender, EventArgs e)
        {
            int illegalInputCount = 0;
            BayesObjectTableAdapter bayesObjectTableAdapter = new BayesObjectTableAdapter();
            DataSetTempTableAdapter dataSetTempTableAdapter = new DataSetTempTableAdapter();
            DataSetTableAdapter dataSetTableAdapter = new DataSetTableAdapter();
            DataTable dtDataSetForPreProcessing = dataSetTableAdapter.GetData();

            for (int i = listIntervalValue.Count - 1; i > 0; i--)
            {
                double currentValue = listIntervalValue[i];
                double previousValue = listIntervalValue[i - 1];
                if (currentValue <= previousValue)
                {
                    illegalInputCount++;
                    break;
                }
                
            }
            if (illegalInputCount > 0)
                MessageBox.Show("Giá trị của từng khoảng nhập vào không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                bayesObjectTableAdapter.DeleteByOne(this.ColName);
                foreach (DataRow dtRow in dtDataSetForPreProcessing.Rows)
                {
                    decimal colValue = Convert.ToDecimal(dtRow[this.ColName]);
                    decimal maBn = Convert.ToDecimal(dtRow["MaBn"]);
                    String discretizationValue = DataDiscretization(colValue, this.listIntervalValue);
                    UpdateDataSetTemp(maBn, this.ColName, discretizationValue);
                }
                CreateBayesObject(this.ColName, this.listIntervalValue);
            }
            this.Close();
        }
        private void UpdateDataSetTemp(decimal maBn, String colName, String discretizationValue)
        {
            DataSetTempTableAdapter dataSetTempTableAdapter = new DataSetTempTableAdapter();
            DataTable dtDataSetTemp = dataSetTempTableAdapter.GetDataByOne(maBn);
            DataRow newRow = dtDataSetTemp.NewRow();
            foreach (DataRow dtRow in dtDataSetTemp.Rows)
            {
                newRow = dtRow;
            }
            newRow[colName] = discretizationValue;
            dataSetTempTableAdapter.Update(newRow);
        }
        public static String DataDiscretization(decimal colValue, List<double> listInputIntervalValue)
        {
            String DiscretizationValue = "";
            for (int i = 0; i < listInputIntervalValue.Count; i++)
            {
                double currentValue = listInputIntervalValue[i];
                double nextValue = 0;
                if (i == listInputIntervalValue.Count - 1 && Convert.ToDouble(colValue) >= currentValue)
                {
                    DiscretizationValue = "[" + currentValue.ToString() + ",+)";
                }
                else 
                {
                    nextValue = listInputIntervalValue[i + 1];
                    if (Convert.ToDouble(colValue) >= currentValue && Convert.ToDouble(colValue) < nextValue)
                    {
                        DiscretizationValue = "[" + currentValue.ToString() + "," + nextValue.ToString() + ")";
                        break;
                    }
                }
            }
            return DiscretizationValue;
        }
        private void CreateBayesObject(String colName, List<double> listInputIntervalValue)
        {
            BayesObjectTableAdapter bayesObjectTableAdapter = new BayesObjectTableAdapter();
            for (int i = 0; i < listInputIntervalValue.Count; i++)
            {
                String InputIntervalValue = "";
                double currentValue=listInputIntervalValue[i];
                double nextValue = 0;
                if (i == listInputIntervalValue.Count - 1)
                    InputIntervalValue = "[" + currentValue.ToString() + ",+)";
                else
                {
                    nextValue = listInputIntervalValue[i + 1];
                    InputIntervalValue = "[" + currentValue.ToString() + "," + nextValue.ToString() + ")";
                }
                bayesObjectTableAdapter.Insert(colName, InputIntervalValue, 0, "TRUE");
                bayesObjectTableAdapter.Insert(colName, InputIntervalValue, 0, "FALSE");
            }
        }
    }
}