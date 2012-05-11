using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Hospital.Model;
using System.Data.SqlClient;

namespace Hospital.View
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                int i = 0;
                dataGridViewX1.DataSource = MedicineBillDetail.GetListMedicineBillDetail(i);
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            try
            {
                //Patient p = new Patient(10000002, "test2", "test3", new DateTime(1990, 1, 2), 0, 100000002, "qwer", "qwer", 23454363, 0);
                ////Patient.InsertPatient(p);
                //Patient.DeletePatient(10000010);
                Service newService = new Service(101, "Truyền máu", 100000);
                Service.DeleteService(102);
                int i = 0;
                dataGridViewX1.DataSource = RentMaterialBillDetail.GetListRentMaterialBillDetail(i);
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
