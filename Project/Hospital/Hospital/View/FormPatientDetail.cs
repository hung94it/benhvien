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
    public partial class FormPatientDetail : Form
    {
        public Patient PatientDetail { get; set; }
        public string UserAction { get; set; }

        private FormPatientDetail()
        {
            InitializeComponent();
        }

        public FormPatientDetail(string userAction, Patient patient)
        {
            InitializeComponent();
            this.PatientDetail = patient;
            this.UserAction = userAction;

            if ("edit".Equals(userAction))
                setPatientDetail(patient);
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            PatientDetail.FirstName = textBoxFirstName.Text;
            PatientDetail.LastName = textBoxLastName.Text;
            PatientDetail.BirthDay = dateBirthday.Value;
            if (textBoxIdentityCard.Text != "")
                PatientDetail.ICN = Convert.ToDecimal(textBoxIdentityCard.Text);
            else PatientDetail.ICN = 0;
            if (comboBoxGender.Text == "Nam")
                PatientDetail.Gender = Patient.GENDER_MALE;
            else PatientDetail.Gender = Patient.GENDER_FEMALE;
            PatientDetail.Profession = textBoxProfession.Text;
            PatientDetail.Address = textBoxAddress.Text;
            if (textBoxDeposit.Text != "")
                PatientDetail.Deposit = Convert.ToDecimal(textBoxDeposit.Text);

            try
            {
                if ("add".Equals(this.UserAction))
                {
                    Patient.InsertPatient(PatientDetail);
                }
                else if ("edit".Equals(this.UserAction))
                {
                    Patient.UpdatePatient(PatientDetail);
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message);
            }

            this.Close();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void setPatientDetail(Patient patient)
        {
            this.PatientDetail = patient;

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
