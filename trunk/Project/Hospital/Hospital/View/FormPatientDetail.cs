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
        // Property to store patientdetail and useraction
        private Patient PatientDetail { get; set; }
        private string UserAction { get; set; }

        // Cannot call default constructor
        private FormPatientDetail()
        {
            InitializeComponent();
        }

        //Constructor with useraction and patientdetail
        public FormPatientDetail(string userAction, Patient patient)
        {
            InitializeComponent();
            
            // Set useraction and patientdetail
            this.PatientDetail = patient;
            this.UserAction = userAction;

            // Set useraction and staff
            comboBoxGender.SelectedIndex = 0;

            // If useraction is edit then set patientdetail to patientdetail form
            if ("edit".Equals(userAction))
            {
                setPatientDetail(patient);
            }
        }

        // Handle event ok button click
        private void buttonOk_Click(object sender, EventArgs e)
        {
            // Set PatientDetail property with value in patientdetail form
            PatientDetail.FirstName = textBoxFirstName.Text;
            PatientDetail.LastName = textBoxLastName.Text;
            PatientDetail.BirthDay = dateBirthday.Value;
            if (textBoxIdentityCard.Text != "")
            {
                PatientDetail.ICN = Convert.ToDecimal(textBoxIdentityCard.Text);
            }
            else PatientDetail.ICN = 0;
            if (comboBoxGender.SelectedItem.ToString() == "Nam")
            {
                PatientDetail.Gender = Patient.GENDER_MALE;
            }
            else PatientDetail.Gender = Patient.GENDER_FEMALE;
            PatientDetail.Profession = textBoxProfession.Text;
            PatientDetail.Address = textBoxAddress.Text;
            if (!"".Equals(textBoxDeposit.Text))
            {
                PatientDetail.Deposit = Convert.ToDecimal(textBoxDeposit.Text);
            }

            // Process useraction
            try
            {
                // If useraction is add then insert to database else update
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
                MessageBox.Show(exception.Message, "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // After process then close this form
            this.Close();
        }

        // Close this form when click close button
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Set value in patientdetail form with PatienDetail 
        public void setPatientDetail(Patient patient)
        {
            this.PatientDetail = patient;

            textBoxPatientID.Text = patient.PatientID.ToString();
            textBoxFirstName.Text = patient.FirstName;
            textBoxLastName.Text = patient.LastName;
            dateBirthday.Value = patient.BirthDay;
            textBoxIdentityCard.Text = patient.ICN.ToString();
            if (patient.ICN == 0)
            {
                comboBoxGender.Text = "Nam";
            }
            else
            {
                comboBoxGender.Text = "Nữ";
            }
            textBoxProfession.Text = patient.Profession;
            textBoxAddress.Text = patient.Address;
        }
    }
}
