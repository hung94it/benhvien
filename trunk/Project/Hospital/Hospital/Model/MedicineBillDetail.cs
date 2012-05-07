using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hospital.Model
{
    class MedicineBillDetail
    {
        private int medicineID;
        private int billID;
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

        public int BillID
        {
            get { return billID; }
            set { billID = value; }
        }

        public int MedicineID
        {
            get { return medicineID; }
            set { medicineID = value; }
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
        public List<MedicineBillDetail> GetMedicineBillDetail()
        {
            List<MedicineBillDetail> lstMBD = new List<MedicineBillDetail>();

            return lstMBD;
        }
    }
}
