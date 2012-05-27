using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Hospital.Functional;
namespace Hospital.Model
{
    public class Assignment
    {
        public int AssignID { get; set; }
        public DateTime Date { get; set; }
        public DateTime DischargedDate { get; set; }
        public DateTime HospitalizateDate { get; set; }

        public Assignment() { }
        public Assignment(int assignID, DateTime date, DateTime dischargedDate, DateTime hospitalizateDate)
        {
            this.AssignID = assignID;
            this.Date = date;
            this.DischargedDate = dischargedDate;
            this.HospitalizateDate = hospitalizateDate;
        }
        public static int InsertAssignment(Assignment newAssignmet)
        {
            String sqlInsert = @"INSERT INTO ASSIGNMENT (DATE, DISCHARGEDDATE, HOPITALIZATEDATE)
                                VALUES        (@DATE,@DISCHARGEDDATE,@HOPITALIZATEDATE)";
            SqlParameter[] sqlParameters = { new SqlParameter("@DATE", newAssignmet.Date),
                                            new SqlParameter("@DISCHARGEDDATE", newAssignmet.DischargedDate),
                                            new SqlParameter("@HOPITALIZATEDATE", newAssignmet.HospitalizateDate)};
            return SqlResult.ExecuteNonQuery(sqlInsert, sqlParameters);
        }
        public static int UpdateAssignment(Assignment updateAssignment)
        {
            string sqlUpdate = @"UPDATE       ASSIGNMENT
                                SET                DATE =@DATE, DISCHARGEDDATE =@DISCHARGEDDATE
                                WHERE         ASSIGNID =@ASSIGNID  ";
            SqlParameter[] sqlParameters = { new SqlParameter("@ASSIGNID", updateAssignment.AssignID ),
                                            new SqlParameter("@DATE", updateAssignment.Date),
                                            new SqlParameter("@DISCHARGEDDATE", updateAssignment.DischargedDate)};
            return SqlResult.ExecuteNonQuery(sqlUpdate, sqlParameters);
        }
        public static int DeleteAssignment(int assignmentID)
        {
            string sqlDelete = @"DELETE FROM ASSIGNMENT
                                WHERE        (ASSIGNID=@ASSIGNID)";
            SqlParameter[] sqlParameters = { new SqlParameter("@ASSIGNID", assignmentID) };
            return SqlResult.ExecuteNonQuery(sqlDelete, sqlParameters);
        }
        public static DataTable GetListAssignment()
        {
            DataTable dtAssignment = new DataTable();
            string sqlSelect = @"SELECT        ASSIGNID, DATE, DISCHARGEDDATE, HOPITALIZATEDATE
                                FROM            ASSIGNMENT";
            dtAssignment = SqlResult.ExecuteQuery(sqlSelect);
            //dtAssignment.Columns[0].ColumnName = "Mã phân công";
            //dtAssignment.Columns[1].ColumnName = "Ngày lập";
            //dtAssignment.Columns[2].ColumnName = "Ngày xuất viện";
            //dtAssignment.Columns[3].ColumnName = "Ngày nhập viện";
            return dtAssignment;
        }
        public static Assignment GetAssignment(int assignID)
        {
            Assignment assign = new Assignment();
            string sqlSelect = @"SELECT        ASSIGNID, DATE, DISCHARGEDDATE, HOPITALIZATEDATE
                                FROM            ASSIGNMENT
                                WHERE        ASSIGNID=@ASSIGNID";
            SqlParameter[] sqlParameters = { new SqlParameter("@ASSIGNID", assignID) };
            DataTable dataTable = SqlResult.ExecuteQuery(sqlSelect, sqlParameters);
            if (dataTable.Rows.Count > 0)
            {
                assign.AssignID = (int)dataTable.Rows[0][0];
                assign.Date = (DateTime)dataTable.Rows[0][1];
                assign.DischargedDate = (DateTime)dataTable.Rows[0][2];
                assign.HospitalizateDate = (DateTime)dataTable.Rows[0][3];
            }
            return assign;
        }
    }
}
