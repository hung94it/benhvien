using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Hospital.Functional;
namespace Hospital.Model
{
    class HeathMonitoringNote
    {
        public int HNID { get; set; }
        public int PatientID { get; set; }
        public int StaffID { get; set; }
        public DateTime Date{ get; set; }
        public String Weight { get; set; }
        public String BloodPressure { get; set; }
        public String PatientState { get; set; }

        public static int InsertHN(HeathMonitoringNote newHN)
        {
            String sqlInsert = @"INSERT INTO HEATHMONITORINGNOTE(PATIENTID, STAFFID, DATE, WEIGHT, BLOODPRESSURE, PATIENTSTATE)
                                VALUES        (@PATIENTID,@STAFFID,@DATE,@WEIGHT,@BLOODPRESSURE,@PATIENTSTATE)";
            SqlParameter[] sqlParameters = { new SqlParameter("@PATIENTID", newHN.PatientID),
                                            new SqlParameter("@STAFFID", newHN.StaffID),
                                            new SqlParameter("@DATE", newHN.Date),
                                            new SqlParameter("@WEIGHT", newHN.Weight),
                                            new SqlParameter("@BLOODPRESSURE", newHN.BloodPressure),
                                           new SqlParameter("@PATIENTSTATE",newHN.PatientState)};
            return SqlResult.ExecuteNonQuery(sqlInsert, sqlParameters);
        }
        public static int UpdateHN(HeathMonitoringNote updateHN)
        {
            string sqlUpdate = @"UPDATE       HEATHMONITORINGNOTE
                                SET                PATIENTID =@PATIENTID, DATE =@DATE, WEIGHT =@WEIGHT, BLOODPRESSURE =@BLOODPRESSURE, PATIENTSTATE =@PATIENTSTATE
                                WHERE         HNID=@HNID ";
            SqlParameter[] sqlParameters = { new SqlParameter("@HNID", updateHN.HNID),
                                            new SqlParameter("@PATIENTID", updateHN.PatientID),
                                           new SqlParameter("@DATE", updateHN.Date),
                                           new SqlParameter("@WEIGHT", updateHN.Weight),
                                           new SqlParameter("@BLOODPRESSURE", updateHN.BloodPressure),
                                           new SqlParameter("@PATIENTSTATE", updateHN.PatientState)};
            return SqlResult.ExecuteNonQuery(sqlUpdate, sqlParameters);
        }
        public static int DeleteHN(int hNID)
        {
            string sqlDelete = @"DELETE FROM HEATHMONITORINGNOTE
                                WHERE        (HNID=@HNID)";
            SqlParameter[] sqlParameters = { new SqlParameter("@HNID", hNID) };
            return SqlResult.ExecuteNonQuery(sqlDelete, sqlParameters);
        }
        public static DataTable GetListHN()
        {
            DataTable dtHN = new DataTable();
            string sqlSelect = @"SELECT        HNID, PATIENTID, STAFFID, DATE, WEIGHT, BLOODPRESSURE, PATIENTSTATE
                                FROM            HEATHMONITORINGNOTE
                                ";

            dtHN = SqlResult.ExecuteQuery(sqlSelect);
            dtHN.Columns[0].ColumnName = "Mã phiếu theo dõi sức khỏe";
            dtHN.Columns[1].ColumnName = "Mã bệnh nhân";
            dtHN.Columns[2].ColumnName = "Mã nhân viên";
            dtHN.Columns[3].ColumnName = "Ngày lập";
            dtHN.Columns[4].ColumnName = "Cân nặng";
            dtHN.Columns[5].ColumnName = "Huyết áp";
            dtHN.Columns[6].ColumnName = "Tình trạng bệnh nhân";
            return dtHN;
        }
        public static DataTable GetListHN(int hNID)
        {
            DataTable dtHN = new DataTable();
            string sqlSelect = @"SELECT        HNID, PATIENTID, STAFFID, DATE, WEIGHT, BLOODPRESSURE, PATIENTSTATE
                                FROM            HEATHMONITORINGNOTE
                                WHERE        HNID=@HNID";
            SqlParameter[] sqlParameters = { new SqlParameter("@HNID", hNID) };
            dtHN = SqlResult.ExecuteQuery(sqlSelect,sqlParameters);
            dtHN.Columns[0].ColumnName = "Mã phiếu theo dõi sức khỏe";
            dtHN.Columns[1].ColumnName = "Mã bệnh nhân";
            dtHN.Columns[2].ColumnName = "Mã nhân viên";
            dtHN.Columns[3].ColumnName = "Ngày lập";
            dtHN.Columns[4].ColumnName = "Cân nặng";
            dtHN.Columns[5].ColumnName = "Huyết áp";
            dtHN.Columns[6].ColumnName = "Tình trạng bệnh nhân";
            return dtHN;
        }
        public HeathMonitoringNote GetHN()
        {
            HeathMonitoringNote hN = new HeathMonitoringNote();

            return hN;
        }
    }
}
