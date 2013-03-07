using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Accord.Controls;
using Accord.Math;
using Accord.Statistics.Analysis;
using Accord.Statistics.Filters;
using DiabetesDido.ClassificationLogic;
using DiabetesDido.DAL.DiabetesDataSetBTableAdapters;
using DiabetesDido.DAL.DiabetesDataSetTableAdapters;

namespace DiabetesDido.UI
{
    public partial class FormMain
    {
        public void InitializeTabPreprocessingData()
        {            
            buttonXDiscretizationDataStatistics.Enabled = false;
            buttonXDataDiscretizationRun.Enabled = false;
            integerInputIntervalDiscretization.Enabled = false;
            checkBoxXDiscreteAllColumn.Enabled = false;
            checkedListBoxColumnName.Enabled = false;
        }

        private void buttonXCleaningData_Click(object sender, EventArgs e)
        {
            //DataTable orginalData = this.bindingSourcePreprocessingData.DataSource as DataTable;
            
            //string[] columnNames = orginalData.Columns.Cast<DataColumn>().Select(column => column.ColumnName).ToArray();
                                                
            //columnNames = columnNames.RemoveAt<string>(columnNames.Length - 1);

            //// Remove rows which have null value
            //Elimination elimination = new Elimination(columnNames);

            //orginalData = elimination.Apply(orginalData);            
        }

        private void buttonXDataCleanning_Click(object sender, EventArgs e)
        {
            if (this.continuousDataTable == null)
            {
                MessageBox.Show("Chưa có dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<string> columnNames = new List<string>(this.getAttributeColumnNames());            

            foreach (DataColumn column in this.continuousDataTable.Columns)
            {
                if (column.DataType != typeof(decimal) || !columnNames.Contains(column.ColumnName))
                {                    
                    continue;                    
                }
                var averageTrue = this.continuousDataTable.AsEnumerable()
                    .Where(x => x.Field<decimal>(column.ColumnName) != 0 && x.Field<string>("TieuDuong") == "True" )
                    .Average(x => x.Field<decimal>(column.ColumnName));
                averageTrue = Math.Round(averageTrue, 2);

                var averageFalse = this.continuousDataTable.AsEnumerable()
                    .Where(x => x.Field<decimal>(column.ColumnName) != 0 && x.Field<string>("TieuDuong") == "False")
                    .Average(x => x.Field<decimal>(column.ColumnName));
                averageFalse = Math.Round(averageFalse, 2);

                foreach (DataRow row in this.continuousDataTable.Rows)
                {
                    if ((decimal)row[column] == 0)
                    {
                        if (row["TieuDuong"].ToString().Equals("True"))
                        {
                            row[column] = averageTrue;
                        }
                        else {
                            row[column] = averageFalse;
                        } 
                    }
                }
                 
            }

            //this.continuousDataTableAdapter.Update(
        }

        private void buttonXViewContinousData_Click(object sender, EventArgs e)
        {
            this.continuousDataTableAdapter.Fill(this.continuousDataTable);
            this.bindingSourcePreprocessingData.DataSource = null;
            this.bindingSourcePreprocessingData.DataSource = this.continuousDataTable;
            this.dataGridViewXPreProcessingData.DataSource = this.bindingSourcePreprocessingData;
            this.bindingNavigatorExPreprocessingData.BindingSource = this.bindingSourcePreprocessingData;

            string[] columnNames = { "Cholesterol", "HDL_Cholesterol", "Triglyceride", "LDL_Cholesterol", "Glucose", "Urea",
                                       "SGOT", "SGPT", "WBC", "LYM", "MONO", "TyLeLYM", "TyLeMONO", "HGB", "RBC", "HTC",
                                       "MCV", "MCH", "MCHC", "RDW_CV", "PLT", "MPV", "PDW", "PCT" };
            DataTable data = this.bindingSourcePreprocessingData.DataSource as DataTable;
            data = data.DefaultView.ToTable(false, columnNames);
            this.dataGridViewXDescriptiveData.DataSource = AnalysisData(data);
            
            buttonXImportDataSet.Enabled = true;

            buttonXDiscretizationDataStatistics.Enabled = false;
            buttonXDataDiscretizationRun.Enabled = false;
            integerInputIntervalDiscretization.Enabled = false;
            checkBoxXDiscreteAllColumn.Enabled = false;
            checkedListBoxColumnName.Enabled = false;
        }

        private ArrayDataView AnalysisData(DataTable dataTable)
        {
            DescriptiveAnalysis analysis;
            string[] columnNames;

            double[,] arrayData = dataTable.ToMatrix(out columnNames);            

            // Analysis Data
            analysis = new DescriptiveAnalysis(arrayData, columnNames);
            analysis.Compute();

            double[,] analysisData = new double[0, arrayData.GetLength(1)];

            analysisData = analysisData.InsertRow<double>(analysis.Distinct.ToDouble(), analysisData.GetLength(0));
            analysisData = analysisData.InsertRow<double>(analysis.Means, analysisData.GetLength(0));
            analysisData = analysisData.InsertRow<double>(analysis.Medians, analysisData.GetLength(0));
            analysisData = analysisData.InsertRow<double>(analysis.Modes, analysisData.GetLength(0));
            analysisData = analysisData.InsertRow<double>(analysis.StandardDeviations, analysisData.GetLength(0));
            analysisData = analysisData.InsertRow<double>(analysis.Variances, analysisData.GetLength(0));
            analysisData = analysisData.InsertRow<double>(analysis.Sums, analysisData.GetLength(0));
            
            string[] rowNames = { "Distinct", "Means", "Medians", "Modes", "StandardDeviations", "Variances", "Sums" };

            return new ArrayDataView(analysisData, columnNames, rowNames);            
        }

        private void buttonXDiscretizationData_Click(object sender, EventArgs e)
        {
            ListBox listBoxSelectedField = new ListBox();
            dtDataSetForPreProcessing = datasetTA.GetData();
            int InputInterval = 0;//Biến dùng để chứa khoảng rời rạc mà người dùng nhập vào
            int Count = 0;//Biến dùng để kiếm tra xem người dùng có phải chỉ chọn 2 Field Tuoi & GioiTinh hay không
            int dataSetColIndex = 0;//Biến dùng để lưu lại index của Field cần rời rạc
            if (checkedListBoxColumnName.CheckedItems.Count == 0)
                MessageBox.Show("Chưa chọn thuộc tính để thực hiện rời rạc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                for (int i = 0; i < checkedListBoxColumnName.CheckedItems.Count; i++)
                {
                    String checkedValue = checkedListBoxColumnName.CheckedItems[i].ToString();
                    if (checkedValue != "Tuoi" && checkedValue != "GioiTinh")
                        listBoxSelectedField.Items.Add(checkedValue);
                    else
                        Count++;
                }
                if (Count == checkedListBoxColumnName.CheckedItems.Count)
                    MessageBox.Show("Thuộc tính Tuoi và GioiTinh không cần thực hiện rời rạc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    InputInterval = integerInputIntervalDiscretization.Value;
                    for (int i = 0; i < listBoxSelectedField.Items.Count; i++)
                    {
                        String colName = listBoxSelectedField.Items[i].ToString();
                        dataSetColIndex = dtDataSetForPreProcessing.Columns.IndexOf(colName);
                        bayesObjectTA.DeleteByOne(colName);

                        foreach (DataRow dtRow in dtDataSetForPreProcessing.Rows)
                        {
                            decimal currentValue = Convert.ToDecimal(dtRow[dataSetColIndex]);
                            decimal id = Convert.ToDecimal(dtRow[0]);
                            String discreteValue = DiscretizationData.DataDiscretization(currentValue, colName, InputInterval);
                            decimal maBN = Convert.ToDecimal(dtRow[1]);
                            String tieuDuong = dtRow[36].ToString();
                            DiscretizationData.CapNhapDataSetTemp(datasetTempTA, maBN, colName, discreteValue);
                        }
                        DiscretizationData.TaoBayesObject(colName, InputInterval);
                    }
                }
                dtDataSetTempForPreProcessing.Clear();
                dtDataSetTempForPreProcessing = datasetTempTA.GetData();
                this.bindingSourcePreprocessingData.DataSource = this.dtDataSetTempForPreProcessing;
                this.dataGridViewXPreProcessingData.DataSource = this.dtDataSetTempForPreProcessing;
                this.bindingNavigatorExPreprocessingData.BindingSource = this.bindingSourcePreprocessingData;
            }            
        }

        private void buttonXDataDiscretizationDataView_Click(object sender, EventArgs e)
        {
            if (datasetTempTA.GetData().Rows.Count == 0)
            {
                DataTable newDataSet = datasetTA.GetData();
                foreach (DataRow dtRow in newDataSet.Rows)
                {
                    InsertDataSetTempRow(dtRow);
                }
            }
            dtDataSetTempForPreProcessing = newDataSetTempTA.GetData();
            this.bindingSourcePreprocessingData.DataSource = null;
            this.bindingSourcePreprocessingData.DataSource = newDataSetTempTA.GetData();
            this.dataGridViewXPreProcessingData.DataSource = this.bindingSourcePreprocessingData;
            this.bindingNavigatorExPreprocessingData.BindingSource = this.bindingSourcePreprocessingData;
            this.dataGridViewXDescriptiveData.DataSource = null;
            if (checkedListBoxColumnName.Items.Count > 0)
                checkedListBoxColumnName.Items.Clear();
            for (int i = 1; i < dtDataSetTempForPreProcessing.Columns.Count - 1; i++)
            {
                
                String colName = dtDataSetTempForPreProcessing.Columns[i].ColumnName;
                checkedListBoxColumnName.Items.Add(colName, false);                
            }

            buttonXImportDataSet.Enabled = false;

            buttonXDiscretizationDataStatistics.Enabled = true;
            buttonXDataDiscretizationRun.Enabled = true;
            integerInputIntervalDiscretization.Enabled = true;
            checkBoxXDiscreteAllColumn.Enabled = true;
            checkedListBoxColumnName.Enabled = true;
        }
        private void checkBoxXDiscreteAllColumn_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxXDiscreteAllColumn.Checked == true)
                for (int i = 0; i < checkedListBoxColumnName.Items.Count; i++)
                    checkedListBoxColumnName.SetItemChecked(i, true);
            else
                for (int i = 0; i < checkedListBoxColumnName.Items.Count; i++)
                    checkedListBoxColumnName.SetItemChecked(i, false);
        }
        private void buttonXDiscretizationDataStatistics_Click(object sender, EventArgs e)
        {
            if (checkedListBoxColumnName.SelectedIndex == -1)
                MessageBox.Show("Chưa chọn thuộc tính để xem thống kê", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                String colName = checkedListBoxColumnName.SelectedItem.ToString();
                BayesObjectTableAdapter bayesObjectTableAdapter = new BayesObjectTableAdapter();
                DataSetTempTableAdapter dataSetTempTableAdapter = new DataSetTempTableAdapter();
                DataTable dtBayesForStatistics = bayesObjectTableAdapter.GetData();
                DataTable dtSetTempForStatistics = dataSetTempTableAdapter.GetData();
                DataRow[] bayesRows = bayesObjectTableAdapter.GetData().Select("TenThuocTinh='" + colName + "'");
                dtBayesForStatistics.Clear();
                int iCount = 0;
                foreach (DataRow bayesRow in bayesRows)
                {

                    String tenThuocTinh = bayesRow["TenThuocTinh"].ToString();
                    String khoangRoiRac = bayesRow["KhoangRoiRac"].ToString();
                    String tieuDuong = bayesRow["TieuDuong"].ToString();
                    int tongSoLuong = 0;
                    String iQuery = "" + tenThuocTinh + "='" + khoangRoiRac + "' and TieuDuong='" + tieuDuong + "'";
                    tongSoLuong = dtSetTempForStatistics.Select(iQuery).Count();
                    DataRow newRow = dtBayesForStatistics.NewRow();
                    iCount++;
                    newRow[0] = iCount;
                    newRow[1] = tenThuocTinh;
                    newRow[2] = khoangRoiRac;
                    newRow[3] = tongSoLuong;
                    newRow[4] = tieuDuong;
                    dtBayesForStatistics.Rows.Add(newRow);
                }
                dataGridViewXDescriptiveData.DataSource = dtBayesForStatistics;
                dataGridViewXDescriptiveData.Columns["ID"].Visible = true;
            }
        }
        private void buttonXCustomDataDiscretization_Click(object sender, EventArgs e)
        {
            int selectedIndex = checkedListBoxColumnName.SelectedIndex;
            if (selectedIndex == -1)
                MessageBox.Show("Chưa chọn thuộc tính để rời rạc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (checkedListBoxColumnName.Items[selectedIndex].ToString() == "Tuoi" || checkedListBoxColumnName.Items[selectedIndex].ToString() == "GioiTinh")
                {
                    MessageBox.Show("Thuộc tính Tuoi và GioiTinh không cần thực hiện rời rạc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    String colName = checkedListBoxColumnName.SelectedItem.ToString();
                    int interval = integerInputIntervalDiscretization.Value;
                    FormCustomDataDiscretization newFormCustomDataDiscretization = new FormCustomDataDiscretization(colName, interval);
                    newFormCustomDataDiscretization.FormClosed += buttonXDataDiscretizationDataView_Click;
                    newFormCustomDataDiscretization.Show();
                }
            }
        }
        private void buttonXImportDataSet_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            this.textBoxXFilePathPreprocessing.Text = ofd.ShowDialog() == DialogResult.OK ? ofd.FileName : "";
            if (this.textBoxXFilePathPreprocessing.Text.Equals(""))
                return;
            DataTable dtNewDataSet = ReadDataFromExcelFile(this.textBoxXFilePathPreprocessing.Text);
            if (datasetTA.GetData().Rows.Count > 0)
            {
                DialogResult dR = MessageBox.Show("Hiện đã có dữ liệu!! Bạn có muốn nạp mới dữ liệu??", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dR == DialogResult.Yes)
                {                   
                    datasetTA.DeleteAllData();
                    datasetTempTA.DeleteAllData();
                    bayesObjectTA.DeleteAll();
                    this.isDiscreteTabProcessingData = false;

                    foreach (DataRow dtRow in dtNewDataSet.Rows)
                    {
                        InsertDataSetRow(dtRow);
                    }
                    AgeDiscretization();
                    GenderDiscretization();
                }
            }
            else
            {
                foreach (DataRow dtRow in dtNewDataSet.Rows)
                {
                    InsertDataSetRow(dtRow);
                }
                AgeDiscretization();
                GenderDiscretization();
            }
            this.bindingSourcePreprocessingData.DataSource = null;
            this.bindingSourcePreprocessingData.DataSource = dtNewDataSet;
            this.dataGridViewXPreProcessingData.DataSource = this.bindingSourcePreprocessingData;
            this.bindingNavigatorExPreprocessingData.BindingSource = this.bindingSourcePreprocessingData;
        }
        public static void InsertDataSetTempRow(DataRow dt)
        {            
            decimal MaBn = Convert.ToDecimal(dt["MaBn"]);
            decimal TuoiHienTai = DateTime.Now.Year - Convert.ToDecimal(dt["NamSinh"]);
            String Tuoi = DiscretizationData.RoiRacHoaTuoi(TuoiHienTai);
            String GioiTinh = dt["GioiTinh"].ToString();
            String Cholesterol = dt["Cholesterol"].ToString();
            String HDL_Cholesterol = dt["HDL_Cholesterol"].ToString();
            String Triglyceride = dt["Triglyceride"].ToString();
            String LDL_Cholesterol = dt["LDL_Cholesterol"].ToString();
            String Glucose = dt["Glucose"].ToString();
            String SGOT = dt["SGOT"].ToString();
            String SGPT = dt["SGPT"].ToString();
            String Urea = dt["Urea"].ToString();
            String WBC = dt["WBC"].ToString();
            String LYM = dt["LYM"].ToString();
            String MONO = dt["MONO"].ToString();
            String GRAN = dt["GRAN"].ToString();
            String TyLeLYM = dt["TyLeLYM"].ToString();
            String TyLeMONO = dt["TyLeMONO"].ToString();
            String TyLeGRAN = dt["TyLeGRAN"].ToString();
            String HGB = dt["HGB"].ToString();
            String RBC = dt["RBC"].ToString();
            String HTC = dt["HTC"].ToString();
            String MCV = dt["MCV"].ToString();
            String MCH = dt["MCH"].ToString();
            String MCHC = dt["MCHC"].ToString();
            String RDW_CV = dt["RDW_CV"].ToString();
            String PLT = dt["PLT"].ToString();
            String MPV = dt["MPV"].ToString();
            String PDW = dt["PDW"].ToString();
            String PCT = dt["PCT"].ToString();
            String Na = dt["Na"].ToString();
            String K = dt["K"].ToString();
            String Cl = dt["Cl"].ToString();
            String Ca = dt["Ca"].ToString();
            String TieuDuong = dt["TieuDuong"].ToString();

            datasetTempTA.Insert(MaBn,Tuoi, GioiTinh, Cholesterol, HDL_Cholesterol, Triglyceride, LDL_Cholesterol, Glucose, SGOT, SGPT, Urea, WBC, LYM, MONO, GRAN, TyLeLYM, TyLeMONO, TyLeGRAN, HGB, RBC, HTC, MCV, MCH, MCHC, RDW_CV, PLT, MPV, PDW, PCT, Na, K, Cl, Na, TieuDuong);
        }
        public static void InsertDataSetRow(DataRow dt)
        {
            decimal MaBn = Convert.ToDecimal(dt["MaBn"]);
            String HoTen = dt["HoTen"].ToString();
            decimal NamSinh = Convert.ToDecimal(dt["NamSinh"]);
            DateTime NgayKham= Convert.ToDateTime(dt["NgayKham"]);
            String GioiTinh = dt["GioiTinh"].ToString();
            decimal Cholesterol = Convert.ToDecimal(dt["Cholesterol"]);
            decimal HDL_Cholesterol = Convert.ToDecimal(dt["HDL_Cholesterol"]);
            decimal Triglyceride = Convert.ToDecimal(dt["Triglyceride"]);
            decimal LDL_Cholesterol = Convert.ToDecimal(dt["LDL_Cholesterol"]);
            decimal Glucose = Convert.ToDecimal(dt["Glucose"]);
            decimal SGOT = Convert.ToDecimal(dt["SGOT"]);
            decimal SGPT = Convert.ToDecimal(dt["SGPT"]);
            decimal Urea = Convert.ToDecimal(dt["Urea"]);
            decimal WBC = Convert.ToDecimal(dt["WBC"]);
            decimal LYM = Convert.ToDecimal(dt["LYM"]);
            decimal MONO = Convert.ToDecimal(dt["MONO"]);
            decimal GRAN = Convert.ToDecimal(dt["GRAN"]);
            decimal TyLeLYM = Convert.ToDecimal(dt["TyLeLYM"]);
            decimal TyLeMONO = Convert.ToDecimal(dt["TyLeMONO"]);
            decimal TyLeGRAN = Convert.ToDecimal(dt["TyLeGRAN"]);
            decimal HGB = Convert.ToDecimal(dt["HGB"]);
            decimal RBC = Convert.ToDecimal(dt["RBC"]);
            decimal HTC = Convert.ToDecimal(dt["HTC"]);
            decimal MCV = Convert.ToDecimal(dt["MCV"]);
            decimal MCH = Convert.ToDecimal(dt["MCH"]);
            decimal MCHC = Convert.ToDecimal(dt["MCHC"]);
            decimal RDW_CV = Convert.ToDecimal(dt["RDW_CV"]);
            decimal PLT = Convert.ToDecimal(dt["PLT"]);
            decimal MPV = Convert.ToDecimal(dt["MPV"]);
            decimal PDW = Convert.ToDecimal(dt["PDW"]);
            decimal PCT = Convert.ToDecimal(dt["PCT"]);
            decimal Na = Convert.ToDecimal(dt["Na"]);
            decimal K = Convert.ToDecimal(dt["K"]);
            decimal Cl = Convert.ToDecimal(dt["Cl"]);
            decimal Ca = Convert.ToDecimal(dt["Ca"]);
            String TieuDuong = dt["TieuDuong"].ToString();

            datasetTA.Insert(MaBn, HoTen, NamSinh, NgayKham, GioiTinh, Cholesterol, HDL_Cholesterol, Triglyceride, LDL_Cholesterol, Glucose, SGOT, SGPT, Urea, WBC, LYM, MONO, GRAN, TyLeLYM, TyLeMONO, TyLeGRAN, HGB, RBC, HTC, MCV, MCH, MCHC, RDW_CV, PLT, MPV, PDW, PCT, Na, K, Cl, Na, TieuDuong);
        }
        //Hàm để tạo các khoảng rời rạc của tuổi và giới tính. Sử dụng khi nạp 1 data set mới
        public static void AgeDiscretization()
        {
            List<int> ListAge = new List<int>();
            for (int i = 0; i < 9; i++)
            {
                ListAge.Add(i * 10);
            }
            for (int i = 0; i < ListAge.Count; i++)
            {
                int currentValue = ListAge[i];
                int nextValue = 0;
                String intervalValue="";
                if (i != ListAge.Count - 1)
                {
                    nextValue = ListAge[i + 1];
                    intervalValue = "[" + currentValue.ToString() + "," + nextValue + ")";
                }
                else
                {
                    intervalValue = "[" + currentValue.ToString() + ",+)";
                }
                bayesObjectTA.Insert("Tuoi", intervalValue, 0, "True");
                bayesObjectTA.Insert("Tuoi", intervalValue, 0, "False");
            }
        }
        public static void GenderDiscretization()
        {
            bayesObjectTA.Insert("GioiTinh", "Nam", 0, "True");
            bayesObjectTA.Insert("GioiTInh", "Nam", 0, "False");
            bayesObjectTA.Insert("GioiTinh", "Nữ", 0, "True");
            bayesObjectTA.Insert("GioiTInh", "Nữ", 0, "False");
        }
    }
}
