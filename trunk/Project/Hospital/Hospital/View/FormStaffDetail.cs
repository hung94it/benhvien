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
    public partial class FormStaffDetail : Form
    {
        private Staff StaffDetail { get; set; }
        private string UserAction { get; set; }

        private FormStaffDetail()
        {
            InitializeComponent();
        }

        public FormStaffDetail(string userAction, Staff staff)
        {
            InitializeComponent();
            this.StaffDetail = staff;
            this.UserAction = userAction;
            //comboBoxGender.SelectedIndex = 0;

            if ("edit".Equals(userAction)) 
            {
                setStaffDetail(staff);
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            StaffDetail.FirstName = textBoxFirstName.Text;
            StaffDetail.LastName = textBoxLastName.Text;
            StaffDetail.BirthDay = dateBirthday.Value;
            if (textBoxIdentityCard.Text != "")
                StaffDetail.ICN = Convert.ToDecimal(textBoxIdentityCard.Text);
            else StaffDetail.ICN = 0;
            if (comboBoxGender.Text == "Nam")
                StaffDetail.Gender = Patient.GENDER_MALE;
            else StaffDetail.Gender = Patient.GENDER_FEMALE;
            StaffDetail.Address = textBoxAddress.Text;

            try
            {
                if ("add".Equals(this.UserAction))
                {
                    Staff.InsertStaff(StaffDetail);
                }
                else if ("edit".Equals(this.UserAction))
                {
                    Staff.UpdateStaff(StaffDetail);
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message, "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Close();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void setStaffDetail(Staff staff)
        {
            this.StaffDetail = staff;

            textBoxStaffID.Text = staff.StaffID.ToString();
            textBoxFirstName.Text = staff.FirstName;
            textBoxLastName.Text = staff.LastName;
            dateBirthday.Value = staff.BirthDay;
            textBoxIdentityCard.Text = staff.ICN.ToString();
            if (staff.ICN == 0)
                comboBoxGender.Text = "Nam";
            else comboBoxGender.Text = "Nữ";            
            textBoxAddress.Text = staff.Address;
        }
    }
}
