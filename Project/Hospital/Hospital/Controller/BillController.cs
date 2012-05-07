using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hospital.Model;
using System.Data;

namespace Hospital.Controller
{
    class BillController
    {
        public void Bill(int patientID)
        { 
            
        }
        public DataTable GetPatientBill()
        {
            DataTable dtB = new DataTable();

            return dtB;
        }
        public DataTable GetListBill()
        {
            DataTable dtB = new DataTable();

            return dtB;
        }
        public DataTable GetBillDetail()
        {
            DataTable dtBD = new DataTable();

            return dtBD;
        }
        public DataTable GetBill()
        {
            DataTable newBill = new DataTable();

            return newBill;
        }
        public Boolean InsertBill(Bill newBill)
        {
            return true;
        }
        public Boolean UpdateBill(Bill newBill)
        {
            return true;
        }
        public Boolean DeleteBill(Bill newBill)
        {
            return true;
        }
        public Boolean ConfirmBill(Bill newBill)
        {
            return true;
        }
    }
}
