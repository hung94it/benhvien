using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Hospital.Functional;
namespace Hospital.Model
{
    class TestDetail
    {
        public int TestTypeID { get; set; }
        public int TCID { get; set; }
        public String Result { get; set; }


        public TestDetail() { }
        public TestDetail(int testTypeID, int tcID, String result)
        {
            this.TestTypeID = testTypeID;
            this.TCID = tcID;
            this.Result = result;
        }
        public static int InsertTestDetail(TestDetail newTD)
        {
            String sqlInsert = @"INSERT INTO TESTDETAIL(TCID, TESTTYPEID, RESULT)
                                VALUES        (@TCID,@TESTTYPEID,@RESULT)";
            SqlParameter[] sqlParameters = { new SqlParameter("@TCID", newTD.TCID),
                                            new SqlParameter("@TESTTYPEID", newTD.TestTypeID),
                                           new SqlParameter("@RESULT",newTD.Result)};
            return SqlResult.ExecuteNonQuery(sqlInsert, sqlParameters);
        }
        public Boolean UpdateTestDetail()
        {
            return true;
        }
        public static int DeleteTestDetail(int tCID, int testTypeID)
        {
            string sqlDelete = @"DELETE FROM TESTDETAIL
                                WHERE TCID=@TCID AND TESTTYPEID=@TESTTYPEID";
            SqlParameter[] sqlParameters = { new SqlParameter("@TCID", tCID),
                                           new SqlParameter("@TESTTYPEID", testTypeID)};
            return SqlResult.ExecuteNonQuery(sqlDelete, sqlParameters);
        }
        public static int DeleteTestDetail(int tCID)
        {
            string sqlDelete = @"DELETE FROM TESTDETAIL
                                WHERE TCID=@TCID";
            SqlParameter[] sqlParameters = { new SqlParameter("@TCID", tCID)};
            return SqlResult.ExecuteNonQuery(sqlDelete, sqlParameters);
        }
        public static  DataTable GetTestDetail(int tCID)
        {
            DataTable dtTD = new DataTable();
            string sqlSelect = @"SELECT        TCID, TESTTYPEID, RESULT
                                FROM            TESTDETAIL
                                WHERE        TCID=@TCID";
            SqlParameter[] sqlParameters = { new SqlParameter("@TCID", tCID) };
            dtTD = SqlResult.ExecuteQuery(sqlSelect, sqlParameters);
            dtTD.Columns[0].ColumnName = "Mã giấy xét nghiệm";
            dtTD.Columns[1].ColumnName = "Mã loại xét nghiệm";
            dtTD.Columns[2].ColumnName = "Kết quả";
            return dtTD;
        }
    }
}
