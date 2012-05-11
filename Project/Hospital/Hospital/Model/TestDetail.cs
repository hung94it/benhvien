using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Hospital.Functional;
namespace Hospital.Model
{
    class TestDetail
    {
        public int TestTypeID;
        public int TCID;
        public int Result;

        public TestDetail() { }
        public TestDetail(int testTypeID, int tcID, String result)
        {
            this.TestTypeID = testTypeID;
            this.TCID = tcID;
            this.Result = result;
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
