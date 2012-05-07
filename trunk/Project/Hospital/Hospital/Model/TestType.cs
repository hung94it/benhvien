using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Hospital.Model
{
    class TestType
    {
        private int testTypeID;
        private int testName;

        public int TestName
        {
            get { return testName; }
            set { testName = value; }
        }

        public int TestTypeID
        {
            get { return testTypeID; }
            set { testTypeID = value; }
        }
        
        public DataTable GetListTestType()
        {
            DataTable dtT = new DataTable();

            return dtT;
        }
        public TestType GetTestType()
        {
            TestType newTestType = new TestType();

            return newTestType;
        }
    }
}
