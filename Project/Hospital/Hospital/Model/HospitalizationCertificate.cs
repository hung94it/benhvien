using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Hospital.Model
{
    class HospitalizationCertificate
    {
        private int hCID;
        private int patientID;
        private int staffID;
        private String reason;
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

        public String Reason
        {
            get { return reason; }
            set { reason = value; }
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

        public int HCID
        {
            get { return hCID; }
            set { hCID = value; }
        }
        public Boolean InsertHC()
        {
            return true;
        }
        public Boolean UpdateHC()
        {
            return true;
        }
        public Boolean DeleteHC()
        {
            return true;
        }
        public Boolean ConfirmHC()
        {
            return true;
        }
        public Boolean ChangeHCState()
        {
            return true;
        }
        public DataTable GetListHC()
        {
            DataTable dtHC = new DataTable();

            return dtHC;
        }
        public HospitalizationCertificate GetHC()
        {
            HospitalizationCertificate hC = new HospitalizationCertificate();

            return hC;
        }
    }
}
