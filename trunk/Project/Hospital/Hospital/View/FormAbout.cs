using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Hospital.Model;

namespace Hospital.View
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
            //FormBillDetail ew = new FormBillDetail("insertExamination", new Bill(Bill.MEDICINEBILL, patientID, staffID);
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
