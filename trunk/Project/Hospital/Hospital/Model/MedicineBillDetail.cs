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
        public Boolean InsertBillDetail()
        {
            return true;
        }
        public Boolean UpdateBillDetail()
        {
            return true;
        }
        public Boolean DeleteBillDetail()
        {
            return true;
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
