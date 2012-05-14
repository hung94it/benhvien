using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Hospital.Functional;
namespace Hospital.Model
{
    public class Bill
    {
        public int BillID { get; set; }
        public int BillTypeID { get; set; }
        public int PatientID { get; set; }
        public int StaffID { get; set; }
        public DateTime Date { get; set; }
        public int TotalPrice { get; set; }
        public int State { get; set; }

        public Bill() { }
        public Bill(int billID, int billTypeID, int patientID, int staffID, DateTime date, int totalPrice, int state)
        {
            this.BillID = billID;
            this.BillTypeID = billTypeID;
            this.PatientID = patientID;
            this.StaffID = staffID;
            this.Date = date;
            this.TotalPrice = totalPrice;
            this.State = state;
        }
        public static int InsertBill(Bill newBill)
        {
            String sqlInsert = @"INSERT INTO BILL(BILLTYPEID, PATIENTID, STAFFID, DATE, STATE)
                                VALUES        (@BILLTYPEID,@PATIENTID,@STAFFID,@DATE,@STATE)";
            SqlParameter[] sqlParameters = { new SqlParameter("@BILLTYPEID", newBill.BillTypeID),
                                            new SqlParameter("@PATIENTID", newBill.PatientID),
                                            new SqlParameter("@STAFFID", newBill.StaffID),
                                            new SqlParameter("@DATE", newBill.Date),
                                            new SqlParameter("@STATE", newBill.State)};
            return SqlResult.ExecuteNonQuery(sqlInsert, sqlParameters);
        }
        public static int UpdateBill(Bill updateBill)
        {
            string sqlUpdate = @"INSERT INTO BILL(DATE, STATE)
                                VALUES        (@DATE,@STATE)
                                WHERE         BILLID=@BILLID ";
            SqlParameter[] sqlParameters = { new SqlParameter("@BILLID", updateBill.BillID),
                                            new SqlParameter("@DATE", updateBill.Date),
                                           new SqlParameter("@STATE",updateBill.State)};
            return SqlResult.ExecuteNonQuery(sqlUpdate, sqlParameters);
        }
        public static int UpdateBillTotal(Bill updateBill)
        {
            string sqlUpdate = @"INSERT INTO BILL(TOTALPRICE)
                                VALUES        (@TOTALPRICE)
                                WHERE         BILLID=@BILLID ";
            SqlParameter[] sqlParameters = { new SqlParameter("@BILLID", updateBill.BillID),
                                            new SqlParameter("@TOTALPRICE", updateBill.TotalPrice)};
            return SqlResult.ExecuteNonQuery(sqlUpdate, sqlParameters);
        }
        public static int DeleteBill(int billID)
        {
            string sqlDelete = @"DELETE FROM BILL
                                WHERE        (BILLID=@BILLID)";
            SqlParameter[] sqlParameters = { new SqlParameter("@BILLID", billID) };
            return SqlResult.ExecuteNonQuery(sqlDelete, sqlParameters);
        }       
        public static DataTable GetListBill()
        {
            DataTable dtBill = new DataTable();
            string sqlSelect = @"SELECT        BILLID, BILLTYPEID, PATIENTID, STAFFID, DATE, TOTALPRICE, STATE
                                FROM            BILL";
            dtBill = SqlResult.ExecuteQuery(sqlSelect);
            dtBill.Columns[0].ColumnName = "Mã hóa đơn";
            dtBill.Columns[1].ColumnName = "Mã loại hóa đơn";
            dtBill.Columns[2].ColumnName = "Mã bệnh nhân";
            dtBill.Columns[3].ColumnName = "Mã nhân viên";
            dtBill.Columns[4].ColumnName = "Ngày lập";
            dtBill.Columns[5].ColumnName = "Tổng tiền";
            dtBill.Columns[6].ColumnName = "Trạng thái";
            return dtBill;
        }
        public static DataTable GetListBill(int patientID)
        {
            DataTable dtBill = new DataTable();
            string sqlSelect = @"SELECT        BILLID, BILLTYPEID, PATIENTID, STAFFID, DATE, TOTALPRICE, STATE
                                FROM            BILL
                                WHERE        (BILLID=@BILLID)";
            SqlParameter[] sqlParameters = { new SqlParameter("@BILLID", patientID) };
            dtBill = SqlResult.ExecuteQuery(sqlSelect,sqlParameters);
            dtBill.Columns[0].ColumnName = "Mã hóa đơn";
            dtBill.Columns[1].ColumnName = "Mã loại hóa đơn";
            dtBill.Columns[2].ColumnName = "Mã bệnh nhân";
            dtBill.Columns[3].ColumnName = "Mã nhân viên";
            dtBill.Columns[4].ColumnName = "Ngày lập";
            dtBill.Columns[5].ColumnName = "Tổng tiền";
            dtBill.Columns[6].ColumnName = "Trạng thái";
            return dtBill;
        }
        public void Billing()
        { 
        
        }
        public static Bill GetBill(int billID)
        {
            Bill newBill = new Bill();
            string sqlSelect = @"SELECT        BILLID, BILLTYPEID, PATIENTID, STAFFID, DATE, TOTALPRICE, STATE
                                FROM            BILL
                                WHERE        BILLID=@BILLID";
            SqlParameter[] sqlParameters = { new SqlParameter("@BILLID", billID) };
            DataTable dataTable = SqlResult.ExecuteQuery(sqlSelect, sqlParameters);
            if (dataTable.Rows.Count > 0)
            {
                newBill.BillID = (int)dataTable.Rows[0][0];
                newBill.BillTypeID = (int)dataTable.Rows[0][1];
                newBill.PatientID = (int)dataTable.Rows[0][2];
                newBill.StaffID = (int)dataTable.Rows[0][3];
                newBill.Date = (DateTime)dataTable.Rows[0][4];
                newBill.TotalPrice = (int)dataTable.Rows[0][5];
                newBill.State = (int)dataTable.Rows[0][6];
            }
            return newBill;
        }
    }
}
