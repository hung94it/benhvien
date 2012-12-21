using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Accord.Statistics.Filters;
using Accord.Math;

namespace DiabetesDido.ClassificationLogic
{
    public class ClassificationData
    {
        private DataTable integerDiscreteDatatable;
        private Codification discreteCodification;
        private double[][] doubleTrainningAttributes;
        private int[][] intTrainningAttributes;
        private int[] classifierAttribute;
        private string[] columnNames;

        public string[] ColumnNames
        {
            get { return columnNames; }
            set { columnNames = value; }
        }

        public int[][] IntTrainningAttributes
        {
            get { return intTrainningAttributes; }
            private set { intTrainningAttributes = value; }
        }

        public int[] ClassifierAttribute
        {
            get { return classifierAttribute; }
            private set { classifierAttribute = value; }
        }

        public double[][] DoubleTrainningAttributes
        {
            get { return doubleTrainningAttributes; }
            private set { doubleTrainningAttributes = value; }
        }

        public Codification DiscreteCodification
        {
            get { return discreteCodification; }
            private set { discreteCodification = value; }
        }

        public DataTable IntegerDiscreteDatatable
        {
            get { return integerDiscreteDatatable; }
            private set { integerDiscreteDatatable = value; }
        }

        public ClassificationData(DataTable dataTable)
        {
            Initialize(dataTable);
        }

        private void Initialize(DataTable dataTable)
        {
            this.DiscreteCodification = new Codification(dataTable);
            this.IntegerDiscreteDatatable = this.DiscreteCodification.Apply(dataTable);

            List<string> columnNames = new List<string>();

            // Get column's name of training data
            for (int columnIndex = 0; columnIndex < IntegerDiscreteDatatable.Columns.Count - 1; columnIndex++)
            {
                columnNames.Add(IntegerDiscreteDatatable.Columns[columnIndex].ColumnName);
            }

            this.ColumnNames = columnNames.ToArray();

            // Create input data
            this.DoubleTrainningAttributes = IntegerDiscreteDatatable.ToArray(this.ColumnNames);
            this.IntTrainningAttributes = this.DoubleTrainningAttributes.ToInt32();

            // Create classifier data for trainning
            string lastColumnName = IntegerDiscreteDatatable.Columns[IntegerDiscreteDatatable.Columns.Count - 1].ColumnName;
            this.ClassifierAttribute = IntegerDiscreteDatatable.ToIntArray(lastColumnName).GetColumn(0);

        }


    }
}
