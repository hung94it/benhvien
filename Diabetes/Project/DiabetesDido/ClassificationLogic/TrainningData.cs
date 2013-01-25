using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Accord.Statistics.Filters;
using Accord.Math;

namespace DiabetesDido.ClassificationLogic
{
    public class TrainningData
    {
        private DataTable integerDiscreteDatatable;
        private Codification codificationData;
        private double[][] trainningAttributes;        
        private int[] classifierAttribute;
        private string[] columnNames;
        private string lastColumnName;
        private int[] classifierAttributeForSVM;

        public int[] ClassifierAttributeForSVM
        {
            get { return classifierAttributeForSVM; }
            private set { classifierAttributeForSVM = value; }
        }

        public string LastColumnName
        {
            get { return lastColumnName; }
            private set { lastColumnName = value; }
        }

        public string[] ColumnNames
        {
            get { return columnNames; }
            private set { columnNames = value; }
        }

        public int[] ClassifierAttribute
        {
            get { return classifierAttribute; }
            private set { classifierAttribute = value; }
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

        public TrainningData(DataTable dataTable)
        {
            Initialize(dataTable);
        }

        private void Initialize(DataTable dataTable)
        {
            this.codificationData = new Codification(dataTable);
            this.integerDiscreteDatatable = this.codificationData.Apply(dataTable);

            List<string> columnNames = new List<string>();

            // Get column's name of training data
            for (int columnIndex = 0; columnIndex < this.integerDiscreteDatatable.Columns.Count - 1; columnIndex++)
            {
                columnNames.Add(this.integerDiscreteDatatable.Columns[columnIndex].ColumnName);
            }
          
            this.ColumnNames = columnNames.ToArray();
            this.lastColumnName = this.integerDiscreteDatatable.Columns[this.integerDiscreteDatatable.Columns.Count - 1].ColumnName;

            // Create trainning data
            this.trainningAttributes = this.integerDiscreteDatatable.ToArray(this.ColumnNames);            

            // Create classifier data for trainning
            string lastColumnName = this.integerDiscreteDatatable.Columns[integerDiscreteDatatable.Columns.Count - 1].ColumnName;
            this.classifierAttribute = this.integerDiscreteDatatable.ToIntArray(lastColumnName).GetColumn(0);

            this.classifierAttributeForSVM = new int[this.classifierAttribute.Length];
            for (int index = 0; index < this.classifierAttribute.Length; index++)
            {
                if (this.classifierAttribute[index] == 0)
                    this.classifierAttributeForSVM[index] = -1;
                else
                    this.classifierAttributeForSVM[index] = 1;
            }
        }


    }
}
