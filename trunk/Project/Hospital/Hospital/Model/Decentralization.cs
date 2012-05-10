using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Hospital.Functional;
namespace Hospital.Model
{
    class Decentralization
    {
        public int DecentID { get; set; }
        public String DecentName { get; set; }

        public Decentralization() { }
        public Decentralization(int decentID, String decentName)
        {
            this.DecentID = decentID;
            this.DecentName = decentName;
        }
        public static int InsertDecentralization(Decentralization newDecent)
        {
            String sqlInsert = @"INSERT INTO DECENTRALIZATION (DECENTRALIZATIONNAME)
                                VALUES        (@DECENTRALIZATIONNAME)";
            SqlParameter[] sqlParameters = { new SqlParameter("@DECENTRALIZATIONNAME", newDecent.DecentName) };
            return SqlResult.ExecuteNonQuery(sqlInsert, sqlParameters);
        }
        public static int UpdateDecentralization(Decentralization updateDecent)
        {
            string sqlUpdate = @"UPDATE       DECENTRALIZATION
                                SET                DECENTRALIZATIONNAME =@DECENTNAME
                                WHERE          (DECENTRALIZATIONID=@DECENTID)";
            SqlParameter[] sqlParameters = { new SqlParameter("@DECENTNAME", updateDecent.DecentName),
                                           new SqlParameter("@DECENTID", updateDecent.DecentID)};
            return SqlResult.ExecuteNonQuery(sqlUpdate, sqlParameters);
        }
        public static int DeleteDecentralization(int decentID)
        {
            string sqlDelete = @"DELETE FROM DECENTRALIZATION
                                WHERE          (DECENTRALIZATIONID=@DECENTID)";
            SqlParameter[] sqlParameters = { new SqlParameter("@DECENTID", decentID) };
            return SqlResult.ExecuteNonQuery(sqlDelete, sqlParameters);
        }
        public static DataTable GetListDecentralization()
        {
            DataTable dtDecent = new DataTable();
            string sqlSelect = @"SELECT        DECENTRALIZATIONID, DECENTRALIZATIONNAME
                                FROM            DECENTRALIZATION";
            dtDecent = SqlResult.ExecuteQuery(sqlSelect);
            dtDecent.Columns[0].ColumnName = "Mã phân quyền";
            dtDecent.Columns[1].ColumnName = "Tên phân quyền";
            return dtDecent;
        }
        public static Decentralization GetDecentralization(int decentID)
        {
            int tempInterger;
            Decentralization newDecent =new Decentralization();
            string sqlSelect = @"SELECT DISEASEID, DISEASENAME
                                FROM DISEASE
                                WHERE (DISEASEID = @DISEASEID)";
            SqlParameter[] sqlParameters = { new SqlParameter("@DISEASEID", decentID) };
            DataTable dataTable = SqlResult.ExecuteQuery(sqlSelect,sqlParameters);
            int.TryParse(dataTable.Rows[0][0].ToString(), out tempInterger);
            newDecent.DecentID = tempInterger;
            newDecent.DecentName = dataTable.Rows[0][1].ToString();
            return newDecent;
        }
    }
}
