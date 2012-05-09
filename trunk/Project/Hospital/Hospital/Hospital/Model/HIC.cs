using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Hospital.Model
{
    class HIC
    {
        private int hICID;
        private int patientID;
        private DateTime expireDate;
        private DateTime issueDate;

        public DateTime IssueDate
        {
            get { return issueDate; }
            set { issueDate = value; }
        }

        public DateTime ExpireDate
        {
            get { return expireDate; }
            set { expireDate = value; }
        }
        public int PatientID
        {
            get { return patientID; }
            set { patientID = value; }
        }
        public int HICID
        {
            get { return hICID; }
            set { hICID = value; }
        }
        public DataTable GetHIC()
        {
            DataTable dtHIC = new DataTable();

            return dtHIC;
        }
        public Boolean CheckHIC()
        {
            return true;
        }

    }
}
