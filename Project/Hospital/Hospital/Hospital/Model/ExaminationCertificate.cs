using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Hospital.Model
{
    class ExaminationCertificate
    {
        private int eCID;
        private int patientID;
        private int staffID;
        private DateTime date;
        private String result;
        private int state;

        public int State
        {
            get { return state; }
            set { state = value; }
        }

        public String Result
        {
            get { return result; }
            set { result = value; }
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public int StaffID
        {
            get { return staffID; }
            set { staffID = value; }
        }

        public int PatientID
        {
            get { return patientID; }
            set { patientID = value; }
        }

        public int ECID
        {
            get { return eCID; }
            set { eCID = value; }
        }
        public Boolean InsertEC()
        {
            return true;
        }
        public Boolean UpdateEC()
        {
            return true;
        }
        public Boolean DeleteEC()
        {
            return true;
        }
        public DataTable GetListEC()
        {
            DataTable dtEC = new DataTable();

            return dtEC;
        }
        public ExaminationCertificate GetEC()
        {
            ExaminationCertificate eC = new ExaminationCertificate();

            return eC;
        }
    }
}
