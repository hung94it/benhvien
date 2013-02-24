using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Accord.Controls;
using Accord.MachineLearning.Bayes;
using Accord.Math;
using Accord.Statistics.Analysis;
using Accord.Statistics.Distributions.Univariate;
using Accord.Statistics.Formats;
using Accord.Statistics.Filters;

namespace DiabetesDido.View
{
    public partial class Form2 : Form
    {
        DiabetesDido.DAL.DiabetesDataSetTableAdapters.TrainingSetTableAdapter trainingSetTA = new DiabetesDido.DAL.DiabetesDataSetTableAdapters.TrainingSetTableAdapter();
        DiabetesDido.DAL.DiabetesDataSetTableAdapters.BayesObjectTableAdapter BayesTA = new DiabetesDido.DAL.DiabetesDataSetTableAdapters.BayesObjectTableAdapter();
        DiabetesDido.DAL.DiabetesDataSetTableAdapters.TestSetTableAdapter testSetTA = new DiabetesDido.DAL.DiabetesDataSetTableAdapters.TestSetTableAdapter();
        double[,][] traingResult;
        public Form2()
        {
            InitializeComponent();
            //this.datasourceTableAdapter = new DiabetesDido.DiabetesDataSetTableAdapters.DatasourceTableAdapter();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'diabetesDataSet.TestSet' table. You can move, or remove it, as needed.
            this.testSetTableAdapter.Fill(this.diabetesDataSet.TestSet);
            // TODO: This line of code loads data into the 'diabetesDataSet.BayesObject' table. You can move, or remove it, as needed.
            this.bayesObjectTableAdapter.Fill(this.diabetesDataSet.BayesObject);
            // TODO: This line of code loads data into the 'diabetesDataSet.TrainingSet' table. You can move, or remove it, as needed.
            this.trainingSetTableAdapter.Fill(this.diabetesDataSet.TrainingSet);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dtTraining = trainingSetTA.GetData();
            DataTable dtBayes = BayesTA.GetData();
            Codification codebook = new Codification(dtTraining);

            DataTable symbols = codebook.Apply(dtTraining);
            int[][] inputs = symbols.ToIntArray("Tuoi", "GioiTinh", "Cholesterol", "HDL_Cholesterol", "Triglyceride", "LDL_Cholesterol","Glucose", "SGOT", "SGPT", "Urea", "WBC", "LYM", "MONO", "GRAN", "TyLeLYM", "TyLeMONO", "TyLeGRAN", "HGB", "RBC", "HTC", "MCV", "MCH", "MCHC", "RDW_CV", "PLT", "MPV", "PDW", "PCT", "Na", "K", "Cl", "Ca");
            int[] outputs = symbols.ToIntArray("TieuDuong").GetColumn(0);

            int[] symbolCounts =
               {
                 codebook["Tuoi"].Symbols,     
                 codebook["GioiTinh"].Symbols,
                 codebook["Cholesterol"].Symbols,
                 codebook["HDL_Cholesterol"].Symbols,
                 codebook["Triglyceride"].Symbols,     
                 codebook["LDL_Cholesterol"].Symbols,
                 codebook["Glucose"].Symbols,
                 codebook["SGOT"].Symbols,
                 codebook["SGPT"].Symbols,
                 codebook["Urea"].Symbols,     
                 codebook["WBC"].Symbols,
                 codebook["LYM"].Symbols,
                 codebook["MONO"].Symbols,
                 codebook["GRAN"].Symbols,     
                 codebook["TyLeLYM"].Symbols,
                 codebook["TyLeMONO"].Symbols,
                 codebook["TyLeGRAN"].Symbols,
                 codebook["HGB"].Symbols,     
                 codebook["RBC"].Symbols,
                 codebook["HTC"].Symbols,
                 codebook["MCV"].Symbols,
                 codebook["MCH"].Symbols,
                 codebook["MCHC"].Symbols,
                 codebook["RDW_CV"].Symbols,
                 codebook["PLT"].Symbols,     
                 codebook["MPV"].Symbols,
                 codebook["PDW"].Symbols,
                 codebook["PCT"].Symbols,
                 codebook["Na"].Symbols,     
                 codebook["K"].Symbols,
                 codebook["Cl"].Symbols,
                 codebook["Ca"].Symbols,
               };
            int classCount = codebook["TieuDuong"].Symbols;

            NaiveBayes target = new NaiveBayes(classCount, symbolCounts);

            target.Estimate(inputs, outputs);
            traingResult = target.Distributions;
            int ggh = traingResult.Length;
            for (int i = 0; i < classCount; i++)
            {
                String iTieuDuong = "Yes";
                if (i == 1) iTieuDuong = "No";
                for (int j = 0; j < codebook.Columns.Count-1; j++)
                {
                    String iTenThuocTinh = codebook.Columns[j].ColumnName;
                    List<String> lstRoiRac = codebook.Columns[j].Mapping.Keys.ToList();
                    for (int k = 0; k < lstRoiRac.Count; k++)
                    {
                        String iKhoangRoiRac = lstRoiRac[k];
                        double iGiaTri = Math.Round(traingResult[i, j][k],3);
                        DataRow dtRow = dtBayes.Select("TieuDuong='"+iTieuDuong.ToString()+"' and TenThuocTinh='"+iTenThuocTinh.ToString()+"' and KhoangRoiRac='"+iKhoangRoiRac.ToString()+"'")[0];
                        dtRow[3] = Convert.ToDecimal(iGiaTri);
                        int g = BayesTA.Update(dtRow);
                    }
                }
            }
            this.bayesObjectTableAdapter.Fill(this.diabetesDataSet.BayesObject);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            DataTable dtResultSet = testSetTA.GetData();
            DataTable dtTestSet = Form2.NaiveBayes(testSetTA.GetData());
            dataGridView1.DataSource = dtTestSet;
            dataGridView2.DataSource = dtResultSet;
            Dictionary<String, int> iDictionary = Form2.TinhThongSo(dtTestSet, dtResultSet);
            int iTruePossive = iDictionary["TruePossive"];
            int iFalseNegative = iDictionary["FalseNegative"];
            int iTrueNegative = iDictionary["TrueNegative"];
            int iFalsePossive = iDictionary["FalsePossive"];
            decimal iRecall = Form2.Recall(iTruePossive, iFalseNegative);
            decimal iPrecision = Form2.Precision(iTruePossive, iFalsePossive);
            decimal iAccuracy = Form2.Accuracy(iTruePossive, iTrueNegative, iFalsePossive, iFalseNegative);
            /*
            // Creates a matrix from the source data table
            double[,] sourceMatrix = datasourceTableAdapter.GetData().ToMatrix();


            // Get only the input vector values
            double[][] inputs = sourceMatrix.Submatrix(null, 0, 29).ToArray();

            // Get only the label outputs
            int[] expected = new int[sourceMatrix.GetLength(0)];
            for (int i = 0; i < expected.Length; i++)
                expected[i] = (int)sourceMatrix[i, 30];

            // Compute the machine outputs
            int[] output = new int[inputs.Length];
            for (int i = 0; i < inputs.Length; i++)
                output[i] = bayes.Compute(inputs[i]);


            // Use confusion matrix to compute some statistics.
            ConfusionMatrix confusionMatrix = new ConfusionMatrix(output, expected, 1, 0);
            dataGridView2.DataSource = new List<ConfusionMatrix> { confusionMatrix };

            foreach (DataGridViewColumn col in dataGridView2.Columns)
                col.Visible = true;
            //Column1.Visible = Column2.Visible = false;
             */
            //khởi tạo dictionary           
        }

        private void trainingSetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.trainingSetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.diabetesDataSet);
        }

         //Hàm dùng để tính kết quả của một bảng trong bộ thử nghiệm
        public static DataTable NaiveBayes( DataTable dtTestSet)
        {
            DiabetesDido.DAL.DiabetesDataSetTableAdapters.BayesObjectTableAdapter bayesTA= new DiabetesDido.DAL.DiabetesDataSetTableAdapters.BayesObjectTableAdapter();
            DataTable dtBayes = bayesTA.GetData();
            int possiveNumber = dtTestSet.Select("TieuDuong='Yes'").Count();
            int negativeNumber = dtTestSet.Select("TieuDuong='No'").Count();
            int allNumber = possiveNumber + negativeNumber;
            foreach (DataRow dtRow in dtTestSet.Rows)
            {
                Decimal pYes = 1;
                Decimal pNo = 1;
                for (int i = 1; i < dtTestSet.Columns.Count-1; i++)
                {
                    String colName = dtTestSet.Columns[i].ColumnName;
                    String khoangRoiRac = dtRow[i].ToString();
                    DataRow possiveRow = dtBayes.Select("TenThuocTinh='" + colName + "' and KhoangRoiRac='" + khoangRoiRac + "' and TieuDuong='Yes'")[0];
                    DataRow negativeRow = dtBayes.Select("TenThuocTinh='" + colName + "' and KhoangRoiRac='" + khoangRoiRac + "' and TieuDuong='No'")[0];
                    Decimal _pYes = Convert.ToDecimal(possiveRow[3]);
                    Decimal _pNo = Convert.ToDecimal(negativeRow[3]);
                    pYes = pYes * _pYes;
                    pNo = pNo * _pNo;
                }
                pYes = pYes * possiveNumber / allNumber;
                pNo = pNo * negativeNumber / allNumber;
                if (pYes > pNo)
                    dtRow[33] = "Yes";
                else
                    dtRow[33] = "No";
            }
            return dtTestSet;
        }
        //Hàm dùng để tính độ bao phủ Recall (Độ nhạy Sensitivity)
        public static decimal Recall(int truePossive, int falseNegative)
        {
            decimal iRecall = 1;
            decimal iTruePossive = Convert.ToDecimal(truePossive);
            decimal iFalseNegative = Convert.ToDecimal(falseNegative);
            iRecall = iTruePossive / (iTruePossive + iFalseNegative);
            iRecall = Math.Round(iRecall, 3);
            return iRecall;
        }
        //Hàm  dùng để tính độ chính xác Precision
        public static decimal Precision(int truePossive, int falsePossive)
        {
            decimal iPrecision = 1;
            decimal iTruePossive = Convert.ToDecimal(truePossive);
            decimal iFalsePossive = Convert.ToDecimal(falsePossive);
            iPrecision = iTruePossive / (iTruePossive + iFalsePossive);
            iPrecision = Math.Round(iPrecision, 3);
            return iPrecision;
        }
        //Hàm dùng để tính độ chính xác Accuracy
        public static decimal Accuracy(int truePossive, int trueNegative, int falsePossive, int falseNegative)
        {
            decimal iAccuracy = 1;
            decimal iTruePossive = Convert.ToDecimal(truePossive);
            decimal iFalseNegative = Convert.ToDecimal(falseNegative);
            decimal iTrueNegative = Convert.ToDecimal(trueNegative);
            decimal iFalsePossive = Convert.ToDecimal(falsePossive);
            iAccuracy = (iTrueNegative + iTruePossive) / (iTruePossive + iTrueNegative + iFalseNegative + iFalsePossive);
            iAccuracy = Math.Round(iAccuracy, 3);
            return iAccuracy;
        }
        //Hàm dùng để tính độ đó F1
        public static decimal F1(decimal iRecall, decimal iPrecision)
        {
            decimal iF1 = 0;
            iF1 = 2 * iPrecision * iRecall / (iRecall + iPrecision);
            iF1 = Math.Round(iF1, 3);
            return iF1;
        }
        //Hàm dùng để trả về các thông số dùng để đánh giá một giải thuật máy học gồm: true possive, false possive, true negative, false negative
        public static Dictionary<String, int> TinhThongSo(DataTable dtTest, DataTable dtResult)
        {
            Dictionary<String, int> iDictionary = new Dictionary<string, int>();
            int iTruePossive = 0;
            int iFalsePossive = 0;
            int iTrueNegative = 0;
            int iFalseNegative = 0;
            int iCount = dtTest.Columns.Count;
            for (int i = 0; i < dtTest.Rows.Count; i++)
            {
                //2 biến dùng để chứa cột "TieuDuong" của table
                String iTest = dtTest.Rows[i][iCount - 1].ToString();
                String iResult = dtResult.Rows[i][iCount - 1].ToString();
                switch (iResult)
                {
                    case "Yes":
                        {
                            if (iTest == "Yes")
                                iTruePossive++;
                            else
                                iFalseNegative++;
                            break;
                        }
                    case "No":
                        {
                            if (iTest == "Yes")
                                iFalsePossive++;
                            else
                                iTrueNegative++;
                            break;
                        }
                }
            }
            iDictionary.Add("TruePossive", iTruePossive);
            iDictionary.Add("FalseNegative", iFalseNegative);
            iDictionary.Add("TrueNegative", iTrueNegative);
            iDictionary.Add("FalsePossive", iFalsePossive);
            return iDictionary;
        }
    }    
}
