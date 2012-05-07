using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Hospital.Model
{
    class RentMaterialBillDetail
    {
        private int billID;
        private int materialID;
        private int quantity;
        private int price;

        public int Price
        {
            get { return price; }
            set { price = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public int MaterialID
        {
            get { return materialID; }
            set { materialID = value; }
        }

        public int BillID
        {
            get { return billID; }
            set { billID = value; }
        }
        public Boolean InsertRentMaterialBillDetail()
        {
            return true;
        }
        public Boolean UpdateRentMaterialBillDetail()
        {
            return true;
        }
        public Boolean DeleteRentMaterialBillDetail()
        {
            return true;
        }
        public DataTable GetListRentMaterialBillDetail()
        {
            DataTable dtRMBD = new DataTable();

            return dtRMBD;

        }
    }
}
