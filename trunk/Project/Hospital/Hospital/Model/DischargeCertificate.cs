using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Hospital.Model
{
    class DischargeCertificate
    {
        private int dCID;
        private int staffID;
        private int patientID;
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
        public int PatientID
        {
            get { return patientID; }
            set { patientID = value; }
        }
        public int StaffID
        {
            get { return staffID; }
            set { staffID = value; }
        }
        public int DCID
        {
            get { return dCID; }
            set { dCID = value; }
        }
        public Boolean InsertDC()
        {
            return true;
        }
        public Boolean UpdateDC()
        {
            return true;
        }
        public Boolean DeleteDC()
        {
            return true;
        }
        public DataTable GetListDC()
        {
            DataTable dtDC = new DataTable();

            return dtDC;
        }
        public DischargeCertificate GetDC()
        {
            DischargeCertificate dC = new DischargeCertificate();

            return dC;
        }
        public Boolean ChangeDCState()
        {
            return true;
        }
    }
}
