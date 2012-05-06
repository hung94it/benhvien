using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hospital.Model
{
    class Bill
    {
        private int billID;
        private int billTypeID;
        private int patientID;
        private int staffID;
        private DateTime date;
        private int totalPrice;
        private int state;

        public int State
        {
            get { return state; }
            set { state = value; }
        }
        public int TotalPrice
        {
            get { return totalPrice; }
            set { totalPrice = value; }
        }

        
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public int StaffID
        {
            get { return staffID; }
            set { staffID = value; }
        }
        public int PatientID
        {
            get { return patientID; }
            set { patientID = value; }
        }
        public int BillTypeID
        {
            get { return billTypeID; }
            set { billTypeID = value; }
        }
        public int BillID
        {
            get { return billID; }
            set { billID = value; }
        }
        public Boolean InsertBill()
        {
            return true;
        }
        public Boolean UpdateBill()
        {
            return true;
        }
        public Boolean DeleteBill()
        {
            return true;
        }
        public Boolean UpdateBillState()
        {
            return true;
        }
        public List<Bill> GetListRentMaterialBill()
        {
            List<Bill> lstBill=new List<Bill>();

            return lstBill;
        }
        public List<Bill> GetListMedicineBill()
        {
            List<Bill> lstBill = new List<Bill>();

            return lstBill;
        }
        public List<Bill> GetServiceBill()
        {
            List<Bill> lstBill = new List<Bill>();

            return lstBill;
        }
        public List<Bill> GetListBill()
        {
            List<Bill> lstBill = new List<Bill>();

            return lstBill;
        }
        public void Billing()
        { 
        
        }
        public Bill GetBill()
        {
            Bill patientBill = new Bill();

            return patientBill;
        }
    }
}
