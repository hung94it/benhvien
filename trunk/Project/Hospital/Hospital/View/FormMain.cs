using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hospital.View
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonPatientAdd_Click(object sender, EventArgs e)
        {
            FormPatientDetail patientDetailForm = new FormPatientDetail();
            patientDetailForm.Show();
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
    }
}
