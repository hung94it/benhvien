﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
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

        public static int InsertDisease(Disease newDisease)
        {
            String sqlInsert = @"INSERT INTO DISEASE(DISEASENAME)
                                VALUES        (@DISEASENAME)";
            SqlParameter[] sqlParameters = { new SqlParameter("@DISEASENAME", newDisease.DiseaseName) };
            return SqlResult.ExecuteNonQuery(sqlInsert, sqlParameters);
        }
        public static int UpdateDisease(Disease updateDisease)
        {
            string sqlUpdate = @"UPDATE DISEASE
                                SET DISEASENAME = @DISEASENAME
                                WHERE (DISEASEID =@DISEASEeID)";
            SqlParameter[] sqlParameters = { new SqlParameter("@DISEASEID", updateDisease.DiseaseID),
                                           new SqlParameter("@DISEASENAME", updateDisease.DiseaseName)};
            return SqlResult.ExecuteNonQuery(sqlUpdate, sqlParameters);
        }
        public static int DeleteDisease(Disease deleteDisease)
        {
            string sqlDelete = @"DELETE FROM DISEASE
                                WHERE (DISEASEID = @DISEASEID)";
            SqlParameter[] sqlParameters = { new SqlParameter("@DISEASEID", deleteDisease.DiseaseID) };
            return SqlResult.ExecuteNonQuery(sqlDelete, sqlParameters);
        }
        public static DataTable GetListDisease()
        {
            DataTable dtDisease = new DataTable();
            string sqlSelect = @"SELECT DISEASEID,DISEASEID
                                FROM DISEASE";
            dtDisease = SqlResult.ExecuteQuery(sqlSelect);
            dtDisease.Columns[0].ColumnName = "Mã bệnh";
            dtDisease.Columns[1].ColumnName = "Tên bệnh";
            dtDisease.Columns[2].ColumnName = "Triệu chứng";
            return dtDisease;
        }
        public static Disease GetDisease(int diseaseID)
        {
            int tempInterger;
            Disease newDisease=new Disease();
            string sqlSelect = @"SELECT DISEASEID, DISEASENAME
                                FROM DISEASE
                                WHERE (DISEASEID = @DISEASEID)";
            DataTable dataTable = SqlResult.ExecuteQuery(sqlSelect);
            int.TryParse(dataTable.Rows[0][0].ToString(), out tempInterger);
            newDisease.DiseaseID = tempInterger;
            newDisease.DiseaseName = dataTable.Rows[0][1].ToString();
            newDisease.Symptom = dataTable.Rows[0][2].ToString();
            return newDisease;
        }
    }
}