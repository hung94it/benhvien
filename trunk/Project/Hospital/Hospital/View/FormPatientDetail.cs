using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Hospital.Model;
using Hospital.Functional;

namespace Hospital.View
{
    public partial class FormPatientDetail : Form
    {
        public FormPatientDetail()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            Patient newPatient = new Patient();
            newPatient.FirstName = textBoxFirstName.Text;
            newPatient.LastName = textBoxLastName.Text;
            //newPatient.BirthDay = new DateTime(dateBirthday.Text);
            //newPatient.

        }
    }
}
