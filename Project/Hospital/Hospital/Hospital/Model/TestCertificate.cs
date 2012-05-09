using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Hospital.Model
{
    class TestCertificate
    {
        private int tCID;
        private int patientID;
        private int stafID;
        private DateTime date;
        private int state;

        public int State
        {
            get { return state; }
            set { state = value; }
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public int StafID
        {
            get { return stafID; }
            set { stafID = value; }
        }

        public int PatientID
        {
            get { return patientID; }
            set { patientID = value; }
        }

        public int TCID
        {
            get { return tCID; }
            set { tCID = value; }
        }
        public Boolean InsertTC()
        {
            return true;
        }
        public Boolean UpdateTC()
        {
            return true;
        }
        public Boolean DeleteTC()
        {
            return true;
        }
        public DataTable GetListTC()
        {
            DataTable dtTC = new DataTable();

            return dtTC;
        }
        public TestCertificate GetTC()
        {
            TestCertificate newTC = new TestCertificate();

            return newTC;
        }
    }
}
