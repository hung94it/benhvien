using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Hospital.Functional;
namespace Hospital.Model
{
    public class AssignmentDetail
    {
        public int PatientID { get; set; }
        public int AssignID { get; set; }
        public int StaffID { get; set; }


        public static int  InsertAssignmentDetails(AssignmentDetail newAD)
        {
            String sqlInsert = @"INSERT INTO ASSIGNMENTDETAIL(ASSIGNID, PATIENTID, STAFFID)
                                VALUES        (@ASSIGNID,@PATIENTID,@STAFFID)";
            SqlParameter[] sqlParameters = { new SqlParameter("@ASSIGNID", newAD.AssignID),
                                            new SqlParameter("@PATIENTID", newAD.PatientID),
                                            new SqlParameter("@STAFFID", newAD.StaffID)};
            return SqlResult.ExecuteNonQuery(sqlInsert, sqlParameters);
        }
        public static int DeleteAssignmentDetails(AssignmentDetail deleteAD)
        {
            string sqlDelete = @"DELETE FROM ASSIGNMENTDETAIL
                                WHERE        (ASSIGNID=@ASSIGNID AND PATIENTID=@PATIENTID AND STAFFID=@STAFFID)";
            SqlParameter[] sqlParameters = { new SqlParameter("@ASSIGNID", deleteAD.AssignID),
                                               new SqlParameter("@PATIENTID", deleteAD.PatientID),
                                                 new SqlParameter("@STAFFID", deleteAD.StaffID)};
            return SqlResult.ExecuteNonQuery(sqlDelete, sqlParameters);
        }
        public static int DeleteAssignmentDetails(int assignmentID)
        {
            string sqlDelete = @"DELETE FROM ASSIGNMENTDETAIL
                                WHERE        (ASSIGNID=@ASSIGNID)";
            SqlParameter[] sqlParameters = { new SqlParameter("@ASSIGNID", assignmentID)};
            return SqlResult.ExecuteNonQuery(sqlDelete, sqlParameters);
        }
        public static DataTable GetListAssignmentDetails(int assignmentID)
        {
            DataTable dtAD = new DataTable();
            string sqlSelect = @"SELECT        ASSIGNMENTDETAIL.ASSIGNID, ASSIGNMENTDETAIL.PATIENTID, ASSIGNMENTDETAIL.STAFFID, STAFF.LASTNAME, STAFF.FIRSTNAME
                                FROM            ASSIGNMENTDETAIL INNER JOIN STAFF ON ASSIGNMENTDETAIL.STAFFID = STAFF.STAFFID
                                WHERE        (ASSIGNMENTDETAIL.ASSIGNID=@ASSIGNID)";
            SqlParameter[] sqlParameters = { new SqlParameter("@ASSIGNID", assignmentID) };
            dtAD = SqlResult.ExecuteQuery(sqlSelect,sqlParameters);
            dtAD.Columns[0].ColumnName = "Mã phân công";
            dtAD.Columns[1].ColumnName = "Mã bệnh nhân";
            dtAD.Columns[2].ColumnName = "Mã nhân viên";
            dtAD.Columns[3].ColumnName = "Họ nhân viên";
            dtAD.Columns[4].ColumnName = "Tên nhân viên";
            return dtAD;
        }
    }
}
