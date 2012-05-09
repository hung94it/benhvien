using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Hospital.Functional;

namespace Hospital.Model
{
    class Disease
    {
        public int DiseaseID { get; set; }
        public String DiseaseName { get; set; }
        public String Symptom { get; set; }
       
        public Disease() { }

        public Disease(int diseaseID,String diseaseName,String symptom)
        {
            this.DiseaseID = diseaseID;
            this.DiseaseName = diseaseName;
            this.Symptom = symptom;
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
            string sqlSelect = @"SELECT *
                                FROM DISEASE";
            dtDisease = SqlResult.ExecuteQuery(sqlSelect);
            return dtDisease;
        }
        public Disease GetDisease(int diseaseID)
        {
            int tempInterger;
            Disease newDisease=new Disease();
            string sqlSelect = @"SELECT MAJORID, MAJORNAME
                                FROM MAJOR
                                WHERE (MAJORID = @MajorID)";
            DataTable dataTable = SqlResult.ExecuteQuery(sqlSelect);
            int.TryParse(dataTable.Rows[0][0].ToString(), out tempInterger);
            newDisease.DiseaseID = tempInterger;
            newDisease.DiseaseName = dataTable.Rows[0][1].ToString();
            newDisease.Symptom = dataTable.Rows[0][2].ToString();
            return newDisease;
        }
    }
}
