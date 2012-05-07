using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Hospital.Model
{
    class ServiceBillDetail
    {
        private int billID;
        private int serviceID;
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

        public int ServiceID
        {
            get { return serviceID; }
            set { serviceID = value; }
        }

        public int BillID
        {
            get { return billID; }
            set { billID = value; }
        }
        public Boolean InsertServiceBillDetail()
        {
            return true;
        }
        public Boolean UpdateServiceBillDetail()
        {
            return true;
        }
        public Boolean DeleteServiceBillDetail()
        {
            return true;
        }
        public DataTable GetListServiceBillDetail()
        {
            DataTable dtSBD = new DataTable();

            return dtSBD;

        }
    }
}
