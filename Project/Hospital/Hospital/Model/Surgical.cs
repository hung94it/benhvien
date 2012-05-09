using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Hospital.Model
{
    class Surgical
    {
        private int surgicalID;
        private int patientID;
        private DateTime date;
        private String description;
        private int state;

        public int State
        {
            get { return state; }
            set { state = value; }
        }

        public String Description
        {
            get { return description; }
            set { description = value; }
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

        public int SurgicalID
        {
            get { return surgicalID; }
            set { surgicalID = value; }
        }
        public Boolean InsertSurgical()
        {
            return true;
        }
        public Boolean UpdateSurgical()
        {
            return true;
        }
        public Boolean DeleteSurgical()
        {
            return true;
        }
        public DataTable GetListSurgical()
        {
            DataTable dtS = new DataTable();

            return dtS;
        }
        public Surgical GetSurgical()
        {
            Surgical newSurgical = new Surgical();

            return newSurgical;
        }
    }
}
