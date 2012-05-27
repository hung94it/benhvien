using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Hospital.Model;

namespace Hospital.View
{
    public partial class FormBillDetail : Form
    {
        public Bill BillDetail { get; set; }
        public string UserAction { get; set; }

        private DataTable billMedicineTable { get; set; }
        private DataTable billServiceTable { get; set; }
        private DataTable billMaterialTable { get; set; }

        public FormBillDetail()
        {
            InitializeComponent();
        }

        public FormBillDetail(string userAction, Bill bill)
        {
            InitializeComponent();

            // Set useraction and bill
            this.BillDetail = bill;
            this.UserAction = userAction;

            // Get Medicine list and set it to comboBox
            comboBoxMedicine.DataSource = Medicine.GetListMedicine();
            comboBoxMedicine.ValueMember = "MEDICINEID";
            comboBoxMedicine.DisplayMember = "MEDICINENAME";

            dataViewMedicine.DataSource = billMedicineTable;

            if (BillDetail.State == Bill.PAY)
            {
                buttonMedicineAdd.Enabled = false;
                buttonMedicineDelete.Enabled = false;
            }
        }

    }
}
