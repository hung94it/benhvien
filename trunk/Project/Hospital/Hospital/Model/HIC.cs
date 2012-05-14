using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Hospital.Functional;
namespace Hospital.Model
{
    public class HIC
    {
        public int HICID { get; set; }
        public int PatientID { get; set; }
        public DateTime ExpireDate { get; set; }
        public DateTime IssueDate { get; set; }

        public HIC() { }
        public HIC(int hICID, int patientID, DateTime expireDate, DateTime issueDate) 
        {
            this.HICID = hICID;
            this.PatientID = patientID;
            this.ExpireDate = expireDate;
            this.IssueDate = issueDate;
        }
        public static int InsertHIC(HIC newHIC)
        {
            String sqlInsert = @"INSERT INTO HIC(HICID, PATIENTID, EXPIREDATE, ISSUEDATE)
                                VALUES        (@HICID,@PATIENTID,@EXPIREDATE,@ISSUEDATE)";
            SqlParameter[] sqlParameters = { new SqlParameter("@HICID", newHIC.HICID),
                                            new SqlParameter("@PATIENTID", newHIC.PatientID),
                                            new SqlParameter("@EXPIREDATE", newHIC.ExpireDate),
                                            new SqlParameter("@ISSUEDATE", newHIC.IssueDate),};
            return SqlResult.ExecuteNonQuery(sqlInsert, sqlParameters);
        }
        public static int UpdateHIC(HIC updateHIC)
        {
            string sqlUpdate = @"UPDATE       HIC
                                SET                PATIENTID =@PATIENTID, EXPIREDATE =@EXPIREDATE, ISSUEDATE =@ISSUEDATE
                                WHERE         HICID=@HICID ";
            SqlParameter[] sqlParameters = { new SqlParameter("@PATIENTID", updateHIC.PatientID ),
                                            new SqlParameter("@EXPIREDATE", updateHIC.ExpireDate),
                                           new SqlParameter("@ISSUEDATE",updateHIC.IssueDate)};
            return SqlResult.ExecuteNonQuery(sqlUpdate, sqlParameters);
        }
        public static int DeleteHIC(int hICID)
        {
            string sqlDelete = @"DELETE FROM HIC
                                WHERE        (HICID=@HICID)";
            SqlParameter[] sqlParameters = { new SqlParameter("@HICID", hICID) };
            return SqlResult.ExecuteNonQuery(sqlDelete, sqlParameters);
        }
        public static DataTable GetListHIC(int patientID)
        {
            DataTable dtHIC = new DataTable();
            string sqlSelect = @"SELECT        HICID, PATIENTID, EXPIREDATE, ISSUEDATE
                                FROM            HIC
                                WHERE           PATIENTID=@PATIENTID";
            SqlParameter[] sqlParameters = { new SqlParameter("@PATIENTID", patientID ) };
            dtHIC = SqlResult.ExecuteQuery(sqlSelect,sqlParameters);
            dtHIC.Columns[0].ColumnName = "Số thẻ bảo hiểm";
            dtHIC.Columns[1].ColumnName = "Mã bệnh nhân";
            dtHIC.Columns[2].ColumnName = "Ngày hết hạn";
            dtHIC.Columns[3].ColumnName = "Ngày phát hành";
            return dtHIC;
        }
        public static HIC GetHIC(int hICID)
        {
            HIC newHIC = new HIC();
            string sqlSelect = @"SELECT        HICID, PATIENTID, EXPIREDATE, ISSUEDATE
                                FROM            HIC
                                WHERE           HICID=@HICID";
            SqlParameter[] sqlParameters = { new SqlParameter("@HICID", hICID) };
            DataTable dataTable = SqlResult.ExecuteQuery(sqlSelect, sqlParameters);
            if (dataTable.Rows.Count > 0)
            {
                newHIC.HICID = (int)dataTable.Rows[0][0];
                newHIC.PatientID = (int)dataTable.Rows[0][1];
                newHIC.ExpireDate = (DateTime)dataTable.Rows[0][2];
                newHIC.IssueDate = (DateTime)dataTable.Rows[0][3];
            }
            return newHIC;
        }
        public Boolean CheckHIC()
        {
            return true;
        }

    }
}
