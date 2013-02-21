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
            Function.HuanLuyenBayes(trainningData.discreteValueDatatable);
            
        }

        public override int[] ComputeModel(double[][] inputs)
        {
            
            int[] predicted = new int[inputs.Length];
            DiabetesDido.DAL.DiabetesDataSetTableAdapters.DataSetTempTableAdapter dataSetTempTA = new DAL.DiabetesDataSetTableAdapters.DataSetTempTableAdapter();
            var query = dataSetTempTA.GetData().AsEnumerable().Skip(dataSetTempTA.GetData().Rows.Count - inputs.Length);
            DataTable testData = query.CopyToDataTable<DataRow>();
            //DataTable testData = inputs.ToTable();
            DataTable predictData = Function.NaiveBayes(testData);
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
    }
}
