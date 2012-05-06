using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
        public List<Disease> GetListDisease()
        {
            List<Disease> lstDisease = new List<Disease>();

            return lstDisease;
        }
        public Disease GetDisease()
        {
            Disease newDisease = new Disease();

            return newDisease;
        }
    }
}
