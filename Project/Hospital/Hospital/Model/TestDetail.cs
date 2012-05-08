using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Hospital.Model
{
    class TestDetail
    {
        private int testTypeID;
        private int tCID;
        private int result;

        public int Result
        {
            get { return result; }
            set { result = value; }
        }

        public int TCID
        {
            get { return tCID; }
            set { tCID = value; }
        }

        public int TestTypeID
        {
            get { return testTypeID; }
            set { testTypeID = value; }
        }

        public Boolean InsertTestDetail()
        {
            return true;
        }
        public Boolean UpdateTestDetail()
        {
            return true;
        }
        public Boolean DeleteTestDetail()
        {
            return true;
        }
        public DataTable GetTestDetail()
        {
            DataTable dtTD = new DataTable();

            return dtTD;
        }
    }
}
