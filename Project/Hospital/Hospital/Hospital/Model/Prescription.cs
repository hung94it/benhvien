using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Hospital.Model
{
    class Prescription
    {
        private int prescriptionID;
        private int staffID;
        private int patientID;
        private DateTime date;

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
        public int PrescriptionID
        {
            get { return prescriptionID; }
            set { prescriptionID = value; }
        }
        public Boolean InsertPrescription()
        {
            return true;
        }
        public Boolean UpdatePrescription()
        {
            return true;
        }
        public Boolean DeletePrescription()
        {
            return true;
        }
        public DataTable GetListPrescription()
        {
            DataTable dtP = new DataTable();

            return dtP;

        }
        public Prescription GetPrescription()
        {
            Prescription newPrescription = new Prescription();

            return newPrescription;
        }


    }
}
