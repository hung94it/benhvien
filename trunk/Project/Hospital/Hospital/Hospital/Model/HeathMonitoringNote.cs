using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Hospital.Model
{
    class HeathMonitoringNote
    {
        private int hNID;
        private int patientID;
        private int staffID;
        private DateTime date;
        private String weight;
        private String bloodPressure;
        private String patientState;

        public String PatientState
        {
            get { return patientState; }
            set { patientState = value; }
        }

        public String BloodPressure
        {
            get { return bloodPressure; }
            set { bloodPressure = value; }
        }

        public String Weight
        {
            get { return weight; }
            set { weight = value; }
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
        public int HNID
        {
            get { return hNID; }
            set { hNID = value; }
        }
        public Boolean InsertHN()
        {
            return true;
        }
        public Boolean UpdateHN()
        {
            return true;
        }
        public Boolean DeleteHN()
        {
            return true;
        }
        public DataTable GetListHN()
        {
            DataTable dtHN = new DataTable();

            return dtHN;
        }
        public HeathMonitoringNote GetHN()
        {
            HeathMonitoringNote hN = new HeathMonitoringNote();

            return hN;
        }
    }
}
