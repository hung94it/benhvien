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
using DiabetesDido.DAL;

namespace DiabetesDido.UI
{
    public partial class FormMain
    {
        public void InitializeTabPreprocessingData()
        {
            this.dataGridViewXPreProcessingData.DataSource = this.bindingSourcePreprocessingData;
            this.bindingNavigatorExPreprocessingData.BindingSource = this.bindingSourcePreprocessingData;

            buttonXDiscretizationDataStatistics.Enabled = false;
            buttonXDataDiscretizationRun.Enabled = false;
            buttonXCustomDataDiscretization.Enabled = false;
            integerInputIntervalDiscretization.Enabled = false;
            checkBoxXDiscreteAllColumn.Enabled = false;
            checkedListBoxColumnName.Enabled = false;

            comboBoxExDataCleanning.SelectedIndex = 0;
        }

        private void buttonXDataCleanning_Click(object sender, EventArgs e)
        {
            if (this.continuousDataTable == null)
            {
                MessageBox.Show("Chưa có dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // List of attribute column name
            List<string> columnNames = new List<string>(TableMetaData.TestingAttributes);

            foreach (DataColumn column in this.continuousDataTable.Columns)
            {
                // Only fill value of attribute column name
                if (!columnNames.Contains(column.ColumnName))
                {
                    continue;
                }

                switch (comboBoxExDataCleanning.SelectedItem.ToString())
                {
                    case "Trung bình":

                        //Fill database by average value
                        // Get average of True value
                        var averageTrue = this.continuousDataTable.AsEnumerable()
                            .Where(x => x.Field<decimal>(column.ColumnName) != 0
                                && x.Field<string>(TableMetaData.ClassAttribute)
                                .Equals(TableMetaData.PositiveString))
                            .Average(x => x.Field<decimal>(column.ColumnName));
                        averageTrue = Math.Round(averageTrue, 3);

                        // Get average of False value
                        var averageFalse = this.continuousDataTable.AsEnumerable()
                            .Where(x => x.Field<decimal>(column.ColumnName) != 0
                                && x.Field<string>(TableMetaData.ClassAttribute)
                                .Equals(TableMetaData.NegativeString))
                            .Average(x => x.Field<decimal>(column.ColumnName));
                        averageFalse = Math.Round(averageFalse, 3);

                        foreach (DataRow row in this.continuousDataTable.Rows)
                        {
                            if ((decimal)row[column] == 0)
                            {
                                if (row["TieuDuong"].ToString().Equals(TableMetaData.PositiveString))
                                {
                                    row[column] = averageTrue;
                                }
                                else
                                {
                                    row[column] = averageFalse;
                                }
                            }
                        }
                        break;
                    case "Ngẫu nhiên":
                        //Filling data by random value
                        //Get min of True value
                        var minTrue = this.continuousDataTable.AsEnumerable()
                            .Where(x => x.Field<decimal>(column.ColumnName) != 0 && x.Field<string>(TableMetaData.ClassAttribute)
                                .Equals(TableMetaData.PositiveString)).Min(x => x.Field<decimal>(column.ColumnName));
                        //Get max of True value
                        var maxTrue = this.continuousDataTable.AsEnumerable()
                            .Where(x => x.Field<decimal>(column.ColumnName) != 0 && x.Field<string>(TableMetaData.ClassAttribute)
                                .Equals(TableMetaData.PositiveString)).Max(x => x.Field<decimal>(column.ColumnName));
                        //Get min for False value
                        var minFalse = this.continuousDataTable.AsEnumerable()
                            .Where(x => x.Field<decimal>(column.ColumnName) != 0 && x.Field<string>(TableMetaData.ClassAttribute)
                                .Equals(TableMetaData.NegativeString)).Min(x => x.Field<decimal>(column.ColumnName));
                        //Get max of False value
                        var maxFalse = this.continuousDataTable.AsEnumerable()
                            .Where(x => x.Field<decimal>(column.ColumnName) != 0 && x.Field<string>(TableMetaData.ClassAttribute)
                                .Equals(TableMetaData.NegativeString)).Max(x => x.Field<decimal>(column.ColumnName));
                        Random random = new Random();
                        foreach (DataRow row in this.continuousDataTable.Rows)
                        {
                            if ((decimal)row[column] == 0)
                            {

                                if (row["TieuDuong"].ToString().Equals(TableMetaData.PositiveString))
                                {
                                    decimal newValue = Convert.ToDecimal(random.NextDouble()) * Math.Abs(maxTrue - minTrue) + minTrue;
                                    newValue = Math.Round(newValue, 3);
                                    row[column] = newValue;

                                }
                                else
                                {
                                    decimal newValue = Convert.ToDecimal(random.NextDouble()) * Math.Abs(maxFalse - minFalse) + minFalse;
                                    newValue = Math.Round(newValue, 3);
                                    row[column] = newValue;
                                }
                            }
                        }
                        break;
                    case "Loại bỏ":
                        int rowIndex = 0;
                        while (rowIndex < this.continuousDataTable.Rows.Count)
                        {                            
                            if ((decimal)this.continuousDataTable.Rows[rowIndex][column.ColumnName] == 0)
                            {
                                //this.continuousDataTable.Rows.Remove(this.continuousDataTable.Rows[rowIndex]);
                                this.continuousDataTable.Rows[rowIndex].Delete();
                                rowIndex++;
                            }
                            else
                            {
                                rowIndex++;
                            }
                        }
                        this.continuousDataTableAdapter.Update(this.continuousDataTable);
                        break;
                }
            }
            if (comboBoxExDataCleanning.SelectedItem.ToString().Equals("Loại bỏ"))
            {
                for (int i = 0; i < 19; i++)
                {
                    this.continuousDataTable.Rows[i].Delete();
                }
            }

            this.continuousDataTableAdapter.Update(this.continuousDataTable);
            ResetDataGridViewPreprocessingData();
        }

        private void buttonXViewContinousData_Click(object sender, EventArgs e)
        {
            ResetDataGridViewPreprocessingData();
        }

        private void ResetDataGridViewPreprocessingData()
        {
            this.continuousDataTableAdapter.ClearBeforeFill = true;
            this.continuousDataTableAdapter.Fill(this.continuousDataTable);
            this.bindingSourcePreprocessingData.DataSource = null;
            this.bindingSourcePreprocessingData.DataSource = this.continuousDataTable;

            string[] columnNames = TableMetaData.TestingAttributes;

            DataTable data = this.bindingSourcePreprocessingData.DataSource as DataTable;
            data = data.DefaultView.ToTable(false, columnNames);

            this.dataGridViewXDescriptiveData.DataSource = AnalysisData(data);

            buttonXImportDataSet.Enabled = true;
            buttonXDataCleanning.Enabled = true;
            comboBoxExDataCleanning.Enabled = true;

            buttonXDiscretizationDataStatistics.Enabled = false;
            buttonXDataDiscretizationRun.Enabled = false;
            buttonXCustomDataDiscretization.Enabled = false;
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
                MessageBox.Show("Chưa chọn thuộc tính để thực hiện rời rạc", "Thông báo"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show("Thuộc tính Tuoi và GioiTinh không cần thực hiện rời rạc", "Thông báo"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    DiabetesDataSet.DataSetTempDataTable dataSetTempDataTable = datasetTempTA.GetData();
                    InputInterval = integerInputIntervalDiscretization.Value;

                    for (int i = 0; i < listBoxSelectedField.Items.Count; i++)
                    {
                        String colName = listBoxSelectedField.Items[i].ToString();
                        dataSetColIndex = dtDataSetForPreProcessing.Columns.IndexOf(colName);
                        bayesObjectTA.DeleteByOne(colName);

                        int rowIndex = 0;
                        foreach (DataRow dtRow in dtDataSetForPreProcessing.Rows)
                        {
                            decimal currentValue = Convert.ToDecimal(dtRow[dataSetColIndex]);
                            String discreteValue = DiscretizationData.DataDiscretization(currentValue, colName, InputInterval, dtDataSetForPreProcessing);
                            //String discreteValue = DiscretizationData.DataDiscretization(currentValue, colName, InputInterval);
                            //decimal id = Convert.ToDecimal(dtRow[0]);
                            //decimal maBN = Convert.ToDecimal(dtRow[1]);
                            //String tieuDuong = dtRow[36].ToString();
                            //DiscretizationData.CapNhapDataSetTemp(datasetTempTA, maBN, colName, discreteValue);

                            dataSetTempDataTable[rowIndex][colName] = discreteValue;
                            rowIndex++;
                        }
                        DiscretizationData.TaoBayesObject(colName, InputInterval, dtDataSetForPreProcessing);
                    }

                    datasetTempTA.Update(dataSetTempDataTable);
                }
                dtDataSetTempForPreProcessing.Clear();
                dtDataSetTempForPreProcessing = newDataSetTempTA.GetData();
                this.bindingSourcePreprocessingData.DataSource = this.dtDataSetTempForPreProcessing;

                this.codification = null;
            }
        }

        private void buttonXDataDiscretizationDataView_Click(object sender, EventArgs e)
        {
            if ((datasetTempTA.CountRows() as int?) == 0)
            {
                DataTable newDataSet = datasetTA.GetData();
                DiabetesDataSet.DataSetTempDataTable dataSetTempDataTable = new DiabetesDataSet.DataSetTempDataTable();
                foreach (DataRow dtRow in newDataSet.Rows)
                {
                    var row = dataSetTempDataTable.NewDataSetTempRow();

                    row["MaBn"] = Convert.ToDecimal(dtRow["MaBn"]);
                    decimal TuoiHienTai = DateTime.Now.Year - Convert.ToDecimal(dtRow["NamSinh"]);
                    row["Tuoi"] = DiscretizationData.RoiRacHoaTuoi(TuoiHienTai);
                    row["GioiTinh"] = dtRow["GioiTinh"].ToString();
                    row["Cholesterol"] = dtRow["Cholesterol"].ToString();
                    row["HDL_Cholesterol"] = dtRow["HDL_Cholesterol"].ToString();
                    row["Triglyceride"] = dtRow["Triglyceride"].ToString();
                    row["LDL_Cholesterol"] = dtRow["LDL_Cholesterol"].ToString();
                    row["Glucose"] = dtRow["Glucose"].ToString();
                    row["SGOT"] = dtRow["SGOT"].ToString();
                    row["SGPT"] = dtRow["SGPT"].ToString();
                    row["Urea"] = dtRow["Urea"].ToString();
                    row["WBC"] = dtRow["WBC"].ToString();
                    row["LYM"] = dtRow["LYM"].ToString();
                    row["MONO"] = dtRow["MONO"].ToString();
                    row["GRAN"] = dtRow["GRAN"].ToString();
                    row["TyLeLYM"] = dtRow["TyLeLYM"].ToString();
                    row["TyLeMONO"] = dtRow["TyLeMONO"].ToString();
                    row["TyLeGRAN"] = dtRow["TyLeGRAN"].ToString();
                    row["HGB"] = dtRow["HGB"].ToString();
                    row["RBC"] = dtRow["RBC"].ToString();
                    row["HTC"] = dtRow["HTC"].ToString();
                    row["MCV"] = dtRow["MCV"].ToString();
                    row["MCH"] = dtRow["MCH"].ToString();
                    row["MCHC"] = dtRow["MCHC"].ToString();
                    row["RDW_CV"] = dtRow["RDW_CV"].ToString();
                    row["PLT"] = dtRow["PLT"].ToString();
                    row["MPV"] = dtRow["MPV"].ToString();
                    row["PDW"] = dtRow["PDW"].ToString();
                    row["PCT"] = dtRow["PCT"].ToString();
                    row["Na"] = dtRow["Na"].ToString();
                    row["K"] = dtRow["K"].ToString();
                    row["Cl"] = dtRow["Cl"].ToString();
                    row["Ca"] = dtRow["Ca"].ToString();
                    row["TieuDuong"] = dtRow["TieuDuong"].ToString();

                    dataSetTempDataTable.AddDataSetTempRow(row);
                    //InsertDataSetTempRow(dtRow);
                }
                datasetTempTA.Update(dataSetTempDataTable);
            }
            dtDataSetTempForPreProcessing = newDataSetTempTA.GetData();
            this.bindingSourcePreprocessingData.DataSource = null;
            this.bindingSourcePreprocessingData.DataSource = dtDataSetTempForPreProcessing;

            this.dataGridViewXDescriptiveData.DataSource = null;

            if (checkedListBoxColumnName.Items.Count > 0)
                checkedListBoxColumnName.Items.Clear();

            for (int i = 3; i < dtDataSetTempForPreProcessing.Columns.Count - 1; i++)
            {

                String colName = dtDataSetTempForPreProcessing.Columns[i].ColumnName;
                checkedListBoxColumnName.Items.Add(colName, false);
            }

            buttonXImportDataSet.Enabled = false;
            buttonXDataCleanning.Enabled = false;
            comboBoxExDataCleanning.Enabled = false; ;

            buttonXDiscretizationDataStatistics.Enabled = true;
            buttonXDataDiscretizationRun.Enabled = true;
            integerInputIntervalDiscretization.Enabled = true;
            checkBoxXDiscreteAllColumn.Enabled = true;
            checkedListBoxColumnName.Enabled = true;
            buttonXCustomDataDiscretization.Enabled = true;
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
                if (checkedListBoxColumnName.Items[selectedIndex].ToString() == "Tuoi"
                    || checkedListBoxColumnName.Items[selectedIndex].ToString() == "GioiTinh")
                {
                    MessageBox.Show("Thuộc tính Tuoi và GioiTinh không cần thực hiện rời rạc"
                        , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    String colName = checkedListBoxColumnName.SelectedItem.ToString();
                    int interval = integerInputIntervalDiscretization.Value;
                    FormCustomDataDiscretization newFormCustomDataDiscretization =
                        new FormCustomDataDiscretization(colName, interval);
                    newFormCustomDataDiscretization.FormClosed += buttonXDataDiscretizationDataView_Click;
                    newFormCustomDataDiscretization.Show();
                }
            }
        }

        private void buttonXImportDataSet_Click(object sender, EventArgs e)
        {
            this.openFileDialogMain.Filter = "Excel file (*.xls)|*.xls";

            if (this.openFileDialogMain.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            this.textBoxXFilePathPreprocessing.Text = this.openFileDialogMain.FileName;

            DataTable dtNewDataSet = ReadDataFromExcelFile(this.openFileDialogMain.FileName);

            if ((datasetTA.CountRows() as int?) > 0)
            {
                DialogResult dR = MessageBox.Show("Hiện đã có dữ liệu!! Bạn có muốn nạp mới dữ liệu??"
                    , "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dR == DialogResult.No)
                {
                    return;
                }
            }

            datasetTA.DeleteAllData();
            datasetTempTA.DeleteAllData();
            bayesObjectTA.DeleteAll();

            DiabetesDataSet.DataSetDataTable dataSetDataTable = new DiabetesDataSet.DataSetDataTable();

            foreach (DataRow dtRow in dtNewDataSet.Rows)
            {
                var row = dataSetDataTable.NewDataSetRow();

                row["MaBn"] = Convert.ToDecimal(dtRow["MaBn"]);
                row["HoTen"] = dtRow["HoTen"].ToString();
                row["NamSinh"] = Convert.ToDecimal(dtRow["NamSinh"]);
                row["NgayKham"] = Convert.ToDateTime(dtRow["NgayKham"]);
                row["GioiTinh"] = dtRow["GioiTinh"].ToString();
                row["Cholesterol"] = Convert.ToDecimal(dtRow["Cholesterol"]);
                row["HDL_Cholesterol"] = Convert.ToDecimal(dtRow["HDL_Cholesterol"]);
                row["Triglyceride"] = Convert.ToDecimal(dtRow["Triglyceride"]);
                row["LDL_Cholesterol"] = Convert.ToDecimal(dtRow["LDL_Cholesterol"]);
                row["Glucose"] = Convert.ToDecimal(dtRow["Glucose"]);
                row["SGOT"] = Convert.ToDecimal(dtRow["SGOT"]);
                row["SGPT"] = Convert.ToDecimal(dtRow["SGPT"]);
                row["Urea"] = Convert.ToDecimal(dtRow["Urea"]);
                row["WBC"] = Convert.ToDecimal(dtRow["WBC"]);
                row["LYM"] = Convert.ToDecimal(dtRow["LYM"]);
                row["MONO"] = Convert.ToDecimal(dtRow["MONO"]);
                row["GRAN"] = Convert.ToDecimal(dtRow["GRAN"]);
                row["TyLeLYM"] = Convert.ToDecimal(dtRow["TyLeLYM"]);
                row["TyLeMONO"] = Convert.ToDecimal(dtRow["TyLeMONO"]);
                row["TyLeGRAN"] = Convert.ToDecimal(dtRow["TyLeGRAN"]);
                row["HGB"] = Convert.ToDecimal(dtRow["HGB"]);
                row["RBC"] = Convert.ToDecimal(dtRow["RBC"]);
                row["HTC"] = Convert.ToDecimal(dtRow["HTC"]);
                row["MCV"] = Convert.ToDecimal(dtRow["MCV"]);
                row["MCH"] = Convert.ToDecimal(dtRow["MCH"]);
                row["MCHC"] = Convert.ToDecimal(dtRow["MCHC"]);
                row["RDW_CV"] = Convert.ToDecimal(dtRow["RDW_CV"]);
                row["PLT"] = Convert.ToDecimal(dtRow["PLT"]);
                row["MPV"] = Convert.ToDecimal(dtRow["MPV"]);
                row["PDW"] = Convert.ToDecimal(dtRow["PDW"]);
                row["PCT"] = Convert.ToDecimal(dtRow["PCT"]);
                row["Na"] = Convert.ToDecimal(dtRow["Na"]);
                row["K"] = Convert.ToDecimal(dtRow["K"]);
                row["Cl"] = Convert.ToDecimal(dtRow["Cl"]);
                row["Ca"] = Convert.ToDecimal(dtRow["Ca"]);
                row["TieuDuong"] = dtRow["TieuDuong"].ToString();

                dataSetDataTable.AddDataSetRow(row);
                //InsertDataSetRow(dtRow);
            }
            datasetTA.Update(dataSetDataTable);

            AgeDiscretization();
            GenderDiscretization();

            this.codification = null;

            ResetDataGridViewPreprocessingData();
        }

        //public void InsertDataSetTempRow(DataRow dtRow)
        //{
        //    decimal MaBn = Convert.ToDecimal(dtRow["MaBn"]);
        //    decimal TuoiHienTai = DateTime.Now.Year - Convert.ToDecimal(dtRow["NamSinh"]);
        //    String Tuoi = DiscretizationData.RoiRacHoaTuoi(TuoiHienTai);
        //    String GioiTinh = dtRow["GioiTinh"].ToString();
        //    String Cholesterol = dtRow["Cholesterol"].ToString();
        //    String HDL_Cholesterol = dtRow["HDL_Cholesterol"].ToString();
        //    String Triglyceride = dtRow["Triglyceride"].ToString();
        //    String LDL_Cholesterol = dtRow["LDL_Cholesterol"].ToString();
        //    String Glucose = dtRow["Glucose"].ToString();
        //    String SGOT = dtRow["SGOT"].ToString();
        //    String SGPT = dtRow["SGPT"].ToString();
        //    String Urea = dtRow["Urea"].ToString();
        //    String WBC = dtRow["WBC"].ToString();
        //    String LYM = dtRow["LYM"].ToString();
        //    String MONO = dtRow["MONO"].ToString();
        //    String GRAN = dtRow["GRAN"].ToString();
        //    String TyLeLYM = dtRow["TyLeLYM"].ToString();
        //    String TyLeMONO = dtRow["TyLeMONO"].ToString();
        //    String TyLeGRAN = dtRow["TyLeGRAN"].ToString();
        //    String HGB = dtRow["HGB"].ToString();
        //    String RBC = dtRow["RBC"].ToString();
        //    String HTC = dtRow["HTC"].ToString();
        //    String MCV = dtRow["MCV"].ToString();
        //    String MCH = dtRow["MCH"].ToString();
        //    String MCHC = dtRow["MCHC"].ToString();
        //    String RDW_CV = dtRow["RDW_CV"].ToString();
        //    String PLT = dtRow["PLT"].ToString();
        //    String MPV = dtRow["MPV"].ToString();
        //    String PDW = dtRow["PDW"].ToString();
        //    String PCT = dtRow["PCT"].ToString();
        //    String Na = dtRow["Na"].ToString();
        //    String K = dtRow["K"].ToString();
        //    String Cl = dtRow["Cl"].ToString();
        //    String Ca = dtRow["Ca"].ToString();
        //    String TieuDuong = dtRow["TieuDuong"].ToString();

        //    datasetTempTA.Insert(MaBn, Tuoi, GioiTinh, Cholesterol, HDL_Cholesterol, Triglyceride
        //        , LDL_Cholesterol, Glucose, SGOT, SGPT, Urea, WBC, LYM, MONO, GRAN, TyLeLYM, TyLeMONO, TyLeGRAN
        //        , HGB, RBC, HTC, MCV, MCH, MCHC, RDW_CV, PLT, MPV, PDW, PCT, Na, K, Cl, Na, TieuDuong);
        //}

        //public void InsertDataSetRow(DataRow dtRow)
        //{
        //    decimal MaBn = Convert.ToDecimal(dtRow["MaBn"]);
        //    String HoTen = dtRow["HoTen"].ToString();
        //    decimal NamSinh = Convert.ToDecimal(dtRow["NamSinh"]);
        //    DateTime NgayKham = Convert.ToDateTime(dtRow["NgayKham"]);
        //    String GioiTinh = dtRow["GioiTinh"].ToString();
        //    decimal Cholesterol = Convert.ToDecimal(dtRow["Cholesterol"]);
        //    decimal HDL_Cholesterol = Convert.ToDecimal(dtRow["HDL_Cholesterol"]);
        //    decimal Triglyceride = Convert.ToDecimal(dtRow["Triglyceride"]);
        //    decimal LDL_Cholesterol = Convert.ToDecimal(dtRow["LDL_Cholesterol"]);
        //    decimal Glucose = Convert.ToDecimal(dtRow["Glucose"]);
        //    decimal SGOT = Convert.ToDecimal(dtRow["SGOT"]);
        //    decimal SGPT = Convert.ToDecimal(dtRow["SGPT"]);
        //    decimal Urea = Convert.ToDecimal(dtRow["Urea"]);
        //    decimal WBC = Convert.ToDecimal(dtRow["WBC"]);
        //    decimal LYM = Convert.ToDecimal(dtRow["LYM"]);
        //    decimal MONO = Convert.ToDecimal(dtRow["MONO"]);
        //    decimal GRAN = Convert.ToDecimal(dtRow["GRAN"]);
        //    decimal TyLeLYM = Convert.ToDecimal(dtRow["TyLeLYM"]);
        //    decimal TyLeMONO = Convert.ToDecimal(dtRow["TyLeMONO"]);
        //    decimal TyLeGRAN = Convert.ToDecimal(dtRow["TyLeGRAN"]);
        //    decimal HGB = Convert.ToDecimal(dtRow["HGB"]);
        //    decimal RBC = Convert.ToDecimal(dtRow["RBC"]);
        //    decimal HTC = Convert.ToDecimal(dtRow["HTC"]);
        //    decimal MCV = Convert.ToDecimal(dtRow["MCV"]);
        //    decimal MCH = Convert.ToDecimal(dtRow["MCH"]);
        //    decimal MCHC = Convert.ToDecimal(dtRow["MCHC"]);
        //    decimal RDW_CV = Convert.ToDecimal(dtRow["RDW_CV"]);
        //    decimal PLT = Convert.ToDecimal(dtRow["PLT"]);
        //    decimal MPV = Convert.ToDecimal(dtRow["MPV"]);
        //    decimal PDW = Convert.ToDecimal(dtRow["PDW"]);
        //    decimal PCT = Convert.ToDecimal(dtRow["PCT"]);
        //    decimal Na = Convert.ToDecimal(dtRow["Na"]);
        //    decimal K = Convert.ToDecimal(dtRow["K"]);
        //    decimal Cl = Convert.ToDecimal(dtRow["Cl"]);
        //    decimal Ca = Convert.ToDecimal(dtRow["Ca"]);
        //    String TieuDuong = dtRow["TieuDuong"].ToString();

        //    datasetTA.Insert(MaBn, HoTen, NamSinh, NgayKham, GioiTinh, Cholesterol, HDL_Cholesterol, Triglyceride
        //        , LDL_Cholesterol, Glucose, SGOT, SGPT, Urea, WBC, LYM, MONO, GRAN, TyLeLYM, TyLeMONO, TyLeGRAN, HGB
        //        , RBC, HTC, MCV, MCH, MCHC, RDW_CV, PLT, MPV, PDW, PCT, Na, K, Cl, Na, TieuDuong);
        //}

        //Hàm để tạo các khoảng rời rạc của tuổi và giới tính. Sử dụng khi nạp 1 data set mới
        public void AgeDiscretization()
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
                String intervalValue = "";
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
        public void GenderDiscretization()
        {
            bayesObjectTA.Insert("GioiTinh", "Nam", 0, "True");
            bayesObjectTA.Insert("GioiTInh", "Nam", 0, "False");
            bayesObjectTA.Insert("GioiTinh", "Nữ", 0, "True");
            bayesObjectTA.Insert("GioiTInh", "Nữ", 0, "False");
        }
    }
}
