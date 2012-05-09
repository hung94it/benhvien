using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using Hospital.Model;

namespace Hospital.View
{
    public partial class testconnection : Form
    {
        public testconnection()
        {
            InitializeComponent();
        }

        private void dataGridViewX1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void testconnection_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            //Patient p = new Patient(10000002, "test2", "test3", new DateTime(1990,1,2), 0, 100000002, "qwer", "qwer", 23454363, 0);
            Disease newDiesea = new Disease(101, "Cảm", "Khó chịu");
            try
            {
                //Patient pa = Patient.GetPatient(10000000);
                //textBoxX1.Text = pa.PatientID.ToString() + " " + pa.FirstName;
                //Patient.InsertPatient(p);
                //Patient.DeletePatient(10000003);
                //Patient.UpdatePatient(p);
                //Major.InsertMajor(temp);
                //Major.DeleteMajor(104);
                Disease.UpdateDisease(newDiesea);
                dataGridViewX1.DataSource = Disease.GetListDisease();
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void testconnection_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                dataGridViewX1.DataSource = Disease.GetListDisease();
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

    }
}
