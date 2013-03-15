using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Accord.Statistics.Analysis;
using System.Data;
using Accord.Math;
using DiabetesDido.DAL.DiabetesDataSetTableAdapters;
using DiabetesDido.ClassificationLogic;
using DiabetesDido.DAL;

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

            HuanLuyenBayes(trainningData.TrainningAttributes.GetLength(0));                        
        }

        public override int[] ComputeModel(double[][] inputs)
        {

            int[] predicted = new int[inputs.Length];
            DiabetesDido.DAL.DiabetesDataSetTableAdapters.NewDataSetTempTableAdapter newDataSetTempTA = new DAL.DiabetesDataSetTableAdapters.NewDataSetTempTableAdapter();
            var query = newDataSetTempTA.GetData().AsEnumerable().Skip(newDataSetTempTA.GetData().Rows.Count - inputs.Length);
            DataTable testData = query.CopyToDataTable<DataRow>();

            DataTable predictData = NaiveBayes(testData);
            for (int i = 0; i < predictData.Rows.Count - 1; i++)
            {
                String expectValue = testData.Rows[i][TableMetaData.ClassAttribute].ToString();
                String predictValue = predictData.Rows[i][TableMetaData.ClassAttribute].ToString();
                if (predictValue == TableMetaData.PositiveString)
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
        public static void HuanLuyenBayes(int row)
        {
            BayesObjectTableAdapter dtBayesAdapter = new BayesObjectTableAdapter();
            DataSetTempTableAdapter dtSetTempTA = new DataSetTempTableAdapter();

            int rowCount = row;
            DataTable dataForTraining = dtSetTempTA.GetDataByNumber(rowCount);
            DiabetesDataSet.BayesObjectDataTable dtBayes = dtBayesAdapter.GetData();
            foreach (DataRow dtRow in dtBayes.Rows)
            {
                String colName = dtRow[1].ToString();
                String khoangRoiRac = dtRow[2].ToString();
                String tieuDuong = dtRow[4].ToString();
                String iQuery = "" + colName + "='" + khoangRoiRac + "' and TieuDuong='" + tieuDuong + "'";
                int soLuong = dataForTraining.Select(iQuery).Count();
                if (soLuong == 0)
                    soLuong = 1;

                dtRow[3] = soLuong;
                dtBayesAdapter.Update((dtBayes));
            }
        }

        //Hàm dùng để tính kết quả của một bảng trong bộ thử nghiệm
        public static DataTable NaiveBayes(DataTable dtTestSet)
        {
            BayesObjectTableAdapter bayesTA = new BayesObjectTableAdapter();
            DataSetTempTableAdapter dataSetTempTA = new DataSetTempTableAdapter();
            int dataForTrainingRowsCount = (int)dataSetTempTA.CountRows() - dtTestSet.Rows.Count;
            DataTable dtBayes = bayesTA.GetData();
            DataTable dtdataSetTemp = dataSetTempTA.GetDataByNumber(dataForTrainingRowsCount);
            int possiveNumber = dtdataSetTemp.Select("TieuDuong='True'").Count();
            int negativeNumber = dtdataSetTemp.Select("TieuDuong='False'").Count();
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
