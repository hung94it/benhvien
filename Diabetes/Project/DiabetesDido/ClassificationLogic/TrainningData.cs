using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Accord.Statistics.Filters;
using Accord.Math;
using DiabetesDido.ClassificationLogic;

namespace DiabetesDido.ClassificationLogic
{
    public class TrainningData
    {        
        private Codification codificationData;
        private double[][] trainningAttributes;
        private int[] classificationAttribute;
        private string[] trainningColumnNames;        
        private int positiveValue = 1;
        private int negativeValue = 0;        

        public string[] TrainningColumnNames
        {
            get { return trainningColumnNames; }
            set { trainningColumnNames = value; }
        }

        public int NegativeValue
        {
            get { return negativeValue; }
            set { negativeValue = value; }
        }

        public int PositiveValue
        {
            get { return positiveValue; }
            set { positiveValue = value; }
        }

        public int[] ClassificationAttribute
        {
            get { return classificationAttribute; }
            private set { classificationAttribute = value; }
        }

        public double[][] TrainningAttributes
        {
            get { return trainningAttributes; }
            private set { trainningAttributes = value; }
        }

        public Codification CodificationData
        {
            get { return codificationData; }
            private set { codificationData = value; }
        }

        public TrainningData(DataTable dataTable, Codification codification)
        {
            Initialize(dataTable, codification);
        }

        private void Initialize(DataTable dataTable, Codification codification)
        {
            this.codificationData = codification;
            
            DataTable discreteValueDatatable = this.codificationData.Apply(dataTable);

            List<string> columnNames = new List<string>();

            // Get column's name of training data
            for (int columnIndex = 0; columnIndex < discreteValueDatatable.Columns.Count - 1; columnIndex++)
            {
                columnNames.Add(discreteValueDatatable.Columns[columnIndex].ColumnName);
            }  

            // Create trainning data
            this.trainningAttributes = discreteValueDatatable.ToArray(columnNames.ToArray());
            
            // Create classifier data for trainning            
            this.classificationAttribute = discreteValueDatatable.ToIntArray(TableMetaData.ClassAttribute).GetColumn(0);
            //this.classificationAttribute = discreteValueDatatable.ToArray<int>(ClassColumnName);

            string classificationColumnName = TableMetaData.ClassAttribute;

            // Set positive, negative value to test model            
            if (this.codificationData.Columns[classificationColumnName].Mapping.ContainsKey(TableMetaData.PositiveString))
            {
                this.positiveValue = this.codificationData.Columns[classificationColumnName].Mapping[TableMetaData.PositiveString];
            }

            if (this.codificationData.Columns[classificationColumnName].Mapping.ContainsKey(TableMetaData.NegativeString))
            {
                this.negativeValue = this.codificationData.Columns[classificationColumnName].Mapping[TableMetaData.NegativeString];
            }            
        }
    }
}
