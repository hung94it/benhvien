using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Hospital.Functional;
namespace Hospital.Model
{
    class Prescription
    {
        public int PrescriptionID { get; set; }
        public int StaffID{ get; set; }
        public int PatientID { get; set; }
        public DateTime Date { get; set; }

        public Prescription() { }
        public Prescription(int pID, int staffID, int patientID, DateTime date)
        {
            this.PrescriptionID = pID;
            this.PatientID = patientID;
            this.StaffID = staffID;
            this.Date = date;
        }

        public static int InsertPrescription(Prescription newP)
        {
            String sqlInsert = @"INSERT INTO PRESCRIPTION(STAFFID, PATIENTID, DATE)
                                VALUES        (@STAFFID,@PATIENTID,@DATE)";
            SqlParameter[] sqlParameters = { new SqlParameter("@STAFFID", newP.StaffID),
                                            new SqlParameter("@PATIENTID", newP.PatientID),
                                           new SqlParameter("@DATE",newP.Date)};
            return SqlResult.ExecuteNonQuery(sqlInsert, sqlParameters);
        }
        public static int UpdatePrescription(Prescription updateP)
        {
            string sqlUpdate = @"UPDATE       PRESCRIPTION
                                SET                PATIENTID =@PATIENTID, DATE =@DATE
                                WHERE         PRESCRIPTIONID=@PRESCRIPTIONID ";
            SqlParameter[] sqlParameters = { new SqlParameter("@PRESCRIPTIONID", updateP.PrescriptionID),
                                            new SqlParameter("@PATIENTID", updateP.PatientID),
                                           new SqlParameter("@DATE", updateP.Date)};
            return SqlResult.ExecuteNonQuery(sqlUpdate, sqlParameters);
        }
        public static int DeletePrescription(int pID)
        {
            string sqlDelete = @"DELETE FROM PRESCRIPTION
                                WHERE        (PRESCRIPTIONID=@PRESCRIPTIONID)";
            SqlParameter[] sqlParameters = { new SqlParameter("@PRESCRIPTIONID", pID) };
            return SqlResult.ExecuteNonQuery(sqlDelete, sqlParameters);
        }
        public static DataTable GetListPrescription()
        {
            DataTable dtP = new DataTable();
            string sqlSelect = @"SELECT        PRESCRIPTIONID, STAFFID, PATIENTID, DATE
                                FROM            PRESCRIPTION";
            dtP = SqlResult.ExecuteQuery(sqlSelect);
            dtP.Columns[0].ColumnName = "Mã đơn thuốc";
            dtP.Columns[1].ColumnName = "Mã nhân viên";
            dtP.Columns[2].ColumnName = "Mã bệnh nhân";
            dtP.Columns[3].ColumnName = "Ngày lập";
            return dtP;

        }
        public Prescription GetPrescription(int pID)
        {
            Prescription newPrescription = new Prescription();
            int tempInterger;
            string sqlSelect = @"SELECT        PRESCRIPTIONID, STAFFID, PATIENTID, DATE
                                FROM            PRESCRIPTION
                                WHERE        PRESCRIPTIONID=@PRESCRIPTIONID";
            SqlParameter[] sqlParameters = { new SqlParameter("@PRESCRIPTIONID", pID) };
            DataTable dataTable = SqlResult.ExecuteQuery(sqlSelect, sqlParameters);
            int.TryParse(dataTable.Rows[0][0].ToString(), out tempInterger);
            newPrescription.PrescriptionID = tempInterger;
            newPrescription.StaffID = int.Parse(dataTable.Rows[0][1].ToString());
            newPrescription.PatientID = int.Parse(dataTable.Rows[0][2].ToString());
            newPrescription.Date = DateTime.Parse(dataTable.Rows[0][3].ToString());
            return newPrescription;
        }


    }
}
