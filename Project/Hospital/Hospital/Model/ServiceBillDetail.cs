using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Hospital.Functional;

namespace Hospital.Model
{
    class ServiceBillDetail
    {
        public int BillID { get; set; }
        public int ServiceID { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }

        public ServiceBillDetail() { }
        public ServiceBillDetail(int billID, int serviceID, int quantity, int price)
        {
            this.BillID = billID;
            this.ServiceID = serviceID;
            this.Quantity = quantity;
            this.Price = price;
        }
        public static int InsertServiceBillDetail(ServiceBillDetail newSBD)
        {
            String sqlInsert = @"INSERT INTO SERVICEBILLDETAIL(BILLID, SERVICEID, QUANTITY, PRICE)
                                VALUES        (@BILLID,@SERVICEID,@QUANTITY,@PRICE)";
            SqlParameter[] sqlParameters = { new SqlParameter("@BILLID", newSBD.BillID),
                                            new SqlParameter("@SERVICEID", newSBD.ServiceID),
                                            new SqlParameter("@QUANTITY", newSBD.Quantity),
                                           new SqlParameter("@PRICE",newSBD.Price)};
            return SqlResult.ExecuteNonQuery(sqlInsert, sqlParameters);
        }
        public Boolean UpdateServiceBillDetail()
        {
            return true;
        }
        public static int DeleteServiceBillDetail(int billID,int serviceID)
        {
            string sqlDelete = @"DELETE FROM SERVICEBILLDETAIL
                                WHERE BILLID=@BILLID AND SERVICEID=@SERVICRID";
            SqlParameter[] sqlParameters = { new SqlParameter("@BILLID", billID),
                                           new SqlParameter("@SERVICEID", serviceID)};
            return SqlResult.ExecuteNonQuery(sqlDelete, sqlParameters);
        }
        public static int DeleteServiceBillDetail(int billID)
        {
            string sqlDelete = @"DELETE FROM SERVICEBILLDETAIL
                                WHERE BILLID=@BILLID";
            SqlParameter[] sqlParameters = { new SqlParameter("@BILLID", billID) };
            return SqlResult.ExecuteNonQuery(sqlDelete, sqlParameters);
        }
        public static DataTable GetListServiceBillDetail(int billID)
        {
            DataTable dtSBD = new DataTable();
            string sqlSelect = @"SELECT        BILLID, SERVICEID, QUANTITY, PRICE
                                FROM            SERVICEBILLDETAIL
                                WHERE        BILLID=@BILLID";
            SqlParameter[] sqlParameters = { new SqlParameter("@BILLID", billID) };
            dtSBD = SqlResult.ExecuteQuery(sqlSelect,sqlParameters);
            dtSBD.Columns[0].ColumnName = "Mã hóa đơn";
            dtSBD.Columns[1].ColumnName = "Mã dịch vụ";
            dtSBD.Columns[2].ColumnName = "Số lượng";
            dtSBD.Columns[3].ColumnName = "Đơn giá";
            return dtSBD;

        }
    }
}
