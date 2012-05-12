using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Hospital.Functional;

namespace Hospital.Model
{
    class SurgicalDetail
    {
        public int SurgicalID { get; set; }
        public int StaffID { get; set; }
        public SurgicalDetail() { }
        public SurgicalDetail(int surgicalID, int staffID)
        {
            this.SurgicalID = surgicalID;
            this.StaffID = staffID;
        }
        public static int InsertSurgicalDetail(SurgicalDetail newSD)
        {
            String sqlInsert = @"INSERT INTO SURGICALDETAIL (SURGICALID, STAFFID)
                                VALUES        (@SURGICALID,@STAFFID)";
            SqlParameter[] sqlParameters = { new SqlParameter("@SURGICALID", newSD.SurgicalID),
                                            new SqlParameter("@STAFFID", newSD.StaffID)};
            return SqlResult.ExecuteNonQuery(sqlInsert, sqlParameters);
        }
        public Boolean UpdateSurgicalDetail()
        {
            return true;
        }
        public static int DeleteSurgicalDetail(int surgicalID,int staffID)
        {
            string sqlDelete = @"DELETE FROM SURGICALDETAIL
                                WHERE SURGICALID=@SURGICALID AND STAFFID=@STAFFID";
            SqlParameter[] sqlParameters = { new SqlParameter("@SURGICALID", surgicalID),
                                           new SqlParameter("@STAFFID", staffID)};
            return SqlResult.ExecuteNonQuery(sqlDelete, sqlParameters);
        }
        public static int DeleteSurgicalDetail(int surgicalID)
        {
            string sqlDelete = @"DELETE FROM SURGICALDETAIL
                                WHERE SURGICALID=@SURGICALID";
            SqlParameter[] sqlParameters = { new SqlParameter("@SURGICALID", surgicalID)};
            return SqlResult.ExecuteNonQuery(sqlDelete, sqlParameters);
        }
        public static DataTable GetListSurgicalDetail(int surgicalID)
        {
            DataTable dtSD = new DataTable();
            string sqlSelect = @"SELECT        SURGICALID, STAFFID
                                FROM            SURGICALDETAIL
                                WHERE        SURGICALID=@SURGICALID";
            SqlParameter[] sqlParameters = { new SqlParameter("@SURGICALID", surgicalID) };
            dtSD = SqlResult.ExecuteQuery(sqlSelect,sqlParameters);
            dtSD.Columns[0].ColumnName = "Mã ca phẩu thuật";
            dtSD.Columns[1].ColumnName = "Mã nhân viên";
            return dtSD;
        }
    }
}
