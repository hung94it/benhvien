using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Accord.Statistics.Analysis;
using System.Data;
using Accord.Math;

namespace DiabetesDido.ClassificationLogic
{
    class NaiveBayesSModel : ClassificationModel
    {
        public int possiveValue = 0;
        public int negativeValue = 0;
        public override void TrainningModel(TrainningData trainningData)
        {
            this.possiveValue = trainningData.PositiveValue;
            this.negativeValue = trainningData.NegativeValue;
            HuanLuyenBayes(trainningData.DiscreteValueDatatable);
            
        }

        public override int[] ComputeModel(double[][] inputs)
        {
            //inputs.GetLength(0);
            //DataTable temp = inputs.ToTable();
            int[] predicted = new int[inputs.Length];
            DiabetesDido.DAL.DiabetesDataSetTableAdapters.NewDataSetTempTableAdapter newDataSetTempTA = new DAL.DiabetesDataSetTableAdapters.NewDataSetTempTableAdapter();
            var query = newDataSetTempTA.GetData().AsEnumerable().Skip(newDataSetTempTA.GetData().Rows.Count - inputs.Length);
            DataTable testData = query.CopyToDataTable<DataRow>();
            //DataTable testData = inputs.ToTable();
            DataTable predictData = NaiveBayes(testData);
            for (int i = 0; i < predictData.Rows.Count - 1; i++)
            {
                String expectValue = testData.Rows[i]["TieuDuong"].ToString();
                String predictValue = predictData.Rows[i]["TieuDuong"].ToString();
                if (predictValue == "True")
                    predicted[i] = possiveValue;
                else
                    predicted[i] = negativeValue;
            }
            return predicted;
        }

        public override string ToString()
        {
            return "Naive Bayes S";
        }

        //Hàm dùng để huấn luyện dữ liệu dành cho thuật toán Naive Bayes
        public static void HuanLuyenBayes(DataTable trainingData)
        {
            DiabetesDido.DAL.DiabetesDataSetTableAdapters.BayesObjectTableAdapter dtBayesAdapter = new DiabetesDido.DAL.DiabetesDataSetTableAdapters.BayesObjectTableAdapter();
            DiabetesDido.DAL.DiabetesDataSetTableAdapters.DataSetTempTableAdapter dtSetTempTA = new DiabetesDido.DAL.DiabetesDataSetTableAdapters.DataSetTempTableAdapter();
            int rowCount = trainingData.Rows.Count;
            DataTable dataForTraining = dtSetTempTA.GetDataByNumber(rowCount);
            DataTable dtBayes = dtBayesAdapter.GetData();
            foreach (DataRow dtRow in dtBayes.Rows)
            {
                String colName = dtRow[1].ToString();
                String khoangRoiRac = dtRow[2].ToString();
                String tieuDuong = dtRow[4].ToString();
                String iQuery = "" + colName + "='" + khoangRoiRac + "' and TieuDuong='" + tieuDuong + "'";
                int soLuong = dataForTraining.Select(iQuery).Count();
                if (soLuong == 0)
                    soLuong = 1;
                DataRow newRow = dtBayes.NewRow();
                newRow = dtRow;
                newRow[3] = soLuong;
                dtBayesAdapter.Update(newRow);
            }
        }

        //Hàm dùng để tính kết quả của một bảng trong bộ thử nghiệm
        public static DataTable NaiveBayes(DataTable dtTestSet)
        {
            DiabetesDido.DAL.DiabetesDataSetTableAdapters.BayesObjectTableAdapter bayesTA =
                new DiabetesDido.DAL.DiabetesDataSetTableAdapters.BayesObjectTableAdapter();
            DiabetesDido.DAL.DiabetesDataSetTableAdapters.DataSetTempTableAdapter dataSetTempTA =
                new DAL.DiabetesDataSetTableAdapters.DataSetTempTableAdapter();
            int dataForTrainingRowsCount = dataSetTempTA.GetData().Rows.Count - dtTestSet.Rows.Count;
            DataTable dtBayes = bayesTA.GetData();
            int possiveNumber = dataSetTempTA.GetDataByNumber(dataForTrainingRowsCount).Select("TieuDuong='True'").Count();
            int negativeNumber = dataSetTempTA.GetDataByNumber(dataForTrainingRowsCount).Select("TieuDuong='False'").Count();
            int allNumber = possiveNumber + negativeNumber;
            int indexLastColumn = dtTestSet.Columns.Count - 1;

            foreach (DataRow dtRow in dtTestSet.Rows)
            {
                Decimal pColTrue = 1;
                Decimal pColFalse = 1;
                for (int i = 1; i < dtTestSet.Columns.Count - 2; i++)
                {
                    String colName = dtTestSet.Columns[i].ColumnName;
                    String khoangRoiRac = dtRow[i].ToString();
                    DataRow possiveRow = dtBayes.Select("TenThuocTinh='" + colName + "' and KhoangRoiRac='" + khoangRoiRac + "' and TieuDuong='True'")[0];
                    DataRow negativeRow = dtBayes.Select("TenThuocTinh='" + colName + "' and KhoangRoiRac='" + khoangRoiRac + "' and TieuDuong='False'")[0];
                    Decimal ColPossiveNumber = Convert.ToDecimal(possiveRow[3]);
                    Decimal ColNegativeNumber = Convert.ToDecimal(negativeRow[3]);
                    pColTrue = pColTrue * ColPossiveNumber / possiveNumber;
                    pColFalse = pColFalse * ColNegativeNumber / negativeNumber;
                }
                Decimal pRowTrue = pColTrue * possiveNumber / allNumber;
                Decimal pRowFalse = pColFalse * negativeNumber / allNumber;
                if (pRowFalse == 0)
                    dtRow["TieuDuong"] = "False";
                else
                {
                    if (pRowTrue > pRowFalse)
                        dtRow["TieuDuong"] = "True";
                    else
                        dtRow["TieuDuong"] = "False";
                }
            }
            return dtTestSet;
        }
    }
}
