using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Hospital.Model
{
    class Medicine
    {
        private int medicineID;
        private String medicineName;
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

        public String MedicineName
        {
            get { return medicineName; }
            set { medicineName = value; }
        }

        public int MedicineID
        {
            get { return medicineID; }
            set { medicineID = value; }
        }
        public Boolean InsertMedicine()
        {
            return true;
        }
        public Boolean UpdateMedicine()
        {
            return true;
        }
        public Boolean DeleteMedicne()
        {
            return true;
        }
        public DataTable GetListMedicine()
        {
            DataTable dtM = new DataTable();

            return dtM;
        }
        public Medicine GetMedicine()
        {
            Medicine newMedicine = new Medicine();

            return newMedicine;
        }
    }
}
