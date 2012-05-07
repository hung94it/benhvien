using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Hospital.Model
{
    class PrescriptionDetail
    {
        private int medicineID;
        private int prescriptionID;
        private int quantity;
        private String instruction;

        public String Instruction
        {
            get { return instruction; }
            set { instruction = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public int PrescriptionID
        {
            get { return prescriptionID; }
            set { prescriptionID = value; }
        }

        public int MedicineID
        {
            get { return medicineID; }
            set { medicineID = value; }
        }
        public Boolean InsertPrescriptionDetail()
        {
            return true;
        }
        public Boolean UpdatePrescriptionDetail()
        {
            return true;
        }
        public Boolean DeletePrescriptionDetail()
        {
            return true;
        }
        public DataTable GetListPrescriptionDetail()
        {
            DataTable dtPD = new DataTable();

            return dtPD;

        }
        
    }
}
