using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Hospital.Functional;

namespace Hospital.Model
{
    class MedicineBillDetail
    {
        public int MedicineID { get; set; }
        public int BillID { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public MedicineBillDetail() { }
        public MedicineBillDetail(int billID, int medicineID, int quantity, int price)
        {
            this.BillID = billID;
            this.MedicineID = medicineID;
            this.Quantity = quantity;
            this.Price = price;
        }
        public static int InsertMedicineBillDetail(MedicineBillDetail newMBD)
        {
            String sqlInsert = @"INSERT INTO MEDICINEBILLDETAIL(BILLID, MEDICINEID, QUANTITY, PRICE)
                                VALUES        (@BILLID,@MEDICINEID,@QUANTITY,@PRICE)";
            SqlParameter[] sqlParameters = { new SqlParameter("@BILLID", newMBD.BillID),
                                            new SqlParameter("@MEDICINEID", newMBD.MedicineID),
                                            new SqlParameter("@QUANTITY", newMBD.Quantity),
                                           new SqlParameter("@PRICE",newMBD.Price)};
            return SqlResult.ExecuteNonQuery(sqlInsert, sqlParameters);
        }
        public Boolean UpdateBillDetail()
        {
            return true;
        }
        public static int DeleteMedicineBillDetail(int billID, int medicineID)
        {
            string sqlDelete = @"DELETE FROM MEDICINEBILLDETAIL
                                WHERE BILLID=@BILLID AND MEDICINEID=@MEDICINEID";
            SqlParameter[] sqlParameters = { new SqlParameter("@BILLID", billID),
                                           new SqlParameter("@MEDICINEID", medicineID)};
            return SqlResult.ExecuteNonQuery(sqlDelete, sqlParameters);
        }
        public static int DeleteMedicineBillDetail(int billID)
        {
            string sqlDelete = @"DELETE FROM MEDICINEBILLDETAIL
                                WHERE BILLID=@BILLID";
            SqlParameter[] sqlParameters = { new SqlParameter("@BILLID", billID) };
            return SqlResult.ExecuteNonQuery(sqlDelete, sqlParameters);
        }
        public static DataTable GetListMedicineBillDetail(int billID)
        {
            DataTable dtMBD = new DataTable();
            string sqlSelect = @"SELECT        BILLID, MEDICINEID, QUANTITY, PRICE
                                FROM            MEDICINEBILLDETAIL
                                WHERE        BILLID=@BILLID";
            SqlParameter[] sqlParameters = { new SqlParameter("@BILLID", billID) };
            dtMBD = SqlResult.ExecuteQuery(sqlSelect, sqlParameters);
            dtMBD.Columns[0].ColumnName = "Mã hóa đơn";
            dtMBD.Columns[1].ColumnName = "Mã thuốc";
            dtMBD.Columns[2].ColumnName = "Số lượng";
            dtMBD.Columns[3].ColumnName = "Đơn giá";
            return dtMBD;
        }
    }
}
