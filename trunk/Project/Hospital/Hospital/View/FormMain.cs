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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            dataViewPatient.DataSource = Patient.GetListPatient();
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            FormAbout aboutForm = new FormAbout();
            aboutForm.Show();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonPatientAdd_Click(object sender, EventArgs e)
        {
            Patient p = new Patient(10000002, "test2", "test3", new DateTime(1990, 1, 2), 0, 100000002, "qwer", "qwer", 23454363, 0);
            Patient.InsertPatient(p);
            dataViewPatient.DataSource = Patient.GetListPatient();
            //FormPatientDetail patientDetailForm = new FormPatientDetail();
            //patientDetailForm.Show();
        }

        private void buttonPatientEdit_Click(object sender, EventArgs e)
        {
            Patient p = new Patient(10000002, "test2", "test3", new DateTime(1990, 1, 2), 0, 100000002, "qwer", "qwer", 23454363, 0);
            Patient.InsertPatient(p);
            dataViewPatient.DataSource = Patient.GetListPatient();
        }

        private void buttonPatientDelete_Click(object sender, EventArgs e)
        {
            Patient.DeletePatient(104);
            dataViewPatient.DataSource = Patient.GetListPatient();
        }



    }
}
