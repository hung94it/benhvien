using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Hospital.Model
{
    class Disease
    {
        private int diseaseID;
        private String diseaseName;
        private String symptom;

        public String Symptom
        {
            get { return symptom; }
            set { symptom = value; }
        }

        public String DiseaseName
        {
            get { return diseaseName; }
            set { diseaseName = value; }
        }

        public int DiseaseID
        {
            get { return diseaseID; }
            set { diseaseID = value; }
        }
        public Boolean InsertDisease()
        {
            return true;
        }
        public Boolean UpdateDisease()
        {
            return true;
        }
        public Boolean DeleteDisease()
        {
            return true;
        }
        public DataTable GetListDisease()
        {
            DataTable dtDisease = new DataTable();

            return dtDisease;
        }
        public Disease GetDisease()
        {
            Disease newDisease = new Disease();

            return newDisease;
        }
    }
}
