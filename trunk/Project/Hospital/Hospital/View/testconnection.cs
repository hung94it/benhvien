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
using Hospital;

namespace Hospital.View
{
    public partial class testconnection : Form
    {
        public testconnection()
        {
            InitializeComponent();
        }

        private void dataGridViewX1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void testconnection_Load(object sender, EventArgs e)
        {
            //dataGridViewX1.DataSource = LoadData();
        }

        private DataTable LoadData()
        {
            string sqlConnectString = ConfigurationManager.ConnectionStrings[
                "eHospital"].ConnectionString;

            string sqlSelect = @"SELECT * FROM PATIENT";

            // Retrieve and return a DataTable containing details about the TOP 50 contact
            SqlDataAdapter da = new SqlDataAdapter(sqlSelect, sqlConnectString);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            Patient pa = new Patient();
            pa = pa.GetPatient();
            textBoxX1.Text = pa.PatientID.ToString() + " " +  pa.FirstName ;
        }

    }
}
