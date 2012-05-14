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

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            FormAbout aboutForm = new FormAbout();
            aboutForm.Show();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabItemRole_Click(object sender, EventArgs e)
        {
            dataViewRole.DataSource = Role.GetListRole();
        }

        private void buttonPatientSearchDelete_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPatientSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPatientSearch_KeyDown(object sender, KeyEventArgs e)
        {

        }

    }
}
