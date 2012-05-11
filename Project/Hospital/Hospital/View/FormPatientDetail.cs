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
    public partial class FormPatientDetail : Form
    {
        public Patient TempPatient { get; set; }
        public string Action { get; set; }

        public FormPatientDetail()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if ("add".Equals(this.Action))
            {
                TempPatient = new Patient();
            }

            TempPatient.FirstName = textBoxFirstName.Text;
            TempPatient.LastName = textBoxLastName.Text;
            TempPatient.BirthDay = dateBirthday.Value;
            if (textBoxIdentityCard.Text != "")
                TempPatient.ICN = Convert.ToDecimal(textBoxIdentityCard.Text);
            else TempPatient.ICN = 0;
            if (comboBoxGender.Text == "Nam")
                TempPatient.Gender = Patient.GENDER_MALE;
            else TempPatient.Gender = Patient.GENDER_FEMALE;
            TempPatient.Profession = textBoxProfession.Text;
            TempPatient.Address = textBoxAddress.Text;
            if (textBoxDeposit.Text != "")
                TempPatient.Deposit = Convert.ToDecimal(textBoxDeposit.Text);

            if ("add".Equals(this.Action))
            {
                Patient.InsertPatient(TempPatient);
            }
            else if ("edit".Equals(this.Action))
            {
                Patient.UpdatePatient(TempPatient);
            }

            this.Close();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void setPatientDetail(Patient patient)
        {
            this.TempPatient = patient;

            textBoxPatientID.Text = patient.PatientID.ToString();
            textBoxFirstName.Text = patient.FirstName;
            textBoxLastName.Text = patient.LastName;
            dateBirthday.Value = patient.BirthDay;
            textBoxIdentityCard.Text = patient.ICN.ToString();
            if (patient.ICN == 0)
                comboBoxGender.Text = "Nam";
            else comboBoxGender.Text = "Nữ";
            textBoxProfession.Text = patient.Profession;
            textBoxAddress.Text = patient.Address;
        }
    }
}
