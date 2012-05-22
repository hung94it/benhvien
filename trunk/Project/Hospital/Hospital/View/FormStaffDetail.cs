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
        // Property to store staffdetail and useraction
        private Staff StaffDetail { get; set; }
        private string UserAction { get; set; }

        // Cannot call default constructor
        private FormStaffDetail()
        {
            InitializeComponent();
        }

        // Constructor with useraction and staffdetail
        public FormStaffDetail(string userAction, Staff staff)
        {
            InitializeComponent();

            // Set useraction and staff
            this.StaffDetail = staff;
            this.UserAction = userAction;

            // Set default gender
            comboBoxGender.SelectedIndex = 0;

            // Get department list and set it to comboBox
            comboBoxDepartment.DataSource = Department.GetListDepartment();
            comboBoxDepartment.ValueMember = "DEPARTMENTID";
            comboBoxDepartment.DisplayMember = "DEPARTMENTNAME";

            // Get major list and set it to combobox
            comboBoxMajor.DataSource = Major.GetListMajor();
            comboBoxMajor.ValueMember = "MAJORID";
            comboBoxMajor.DisplayMember = "MAJORNAME";

            comboBoxRole.DataSource = Role.GetListRole();
            comboBoxRole.ValueMember = "ROLEID";
            comboBoxRole.DisplayMember = "ROLENAME";

            // If useraction is edit then set staffdetail to staffdetail form
            if ("edit".Equals(userAction))
            {
                setStaffDetail(staff);
            }
        }

        // Handle event ok button click
        private void buttonOk_Click(object sender, EventArgs e)
        {
            decimal tempDecimal;

            // If fields is not validated then do nothing
            if (!superValidator1.Validate())
            {
                return;
            }

            // Set StaffDetail property with value in staffdetail form            
            StaffDetail.DepartmentID = Convert.ToInt32(comboBoxDepartment.SelectedValue.ToString());
            StaffDetail.MajorID = Convert.ToInt32(comboBoxMajor.SelectedValue.ToString());
            StaffDetail.RoleID = Convert.ToInt32(comboBoxRole.SelectedValue.ToString());
            StaffDetail.Password = textBoxPassword.Text;
            StaffDetail.FirstName = textBoxFirstName.Text;
            StaffDetail.LastName = textBoxLastName.Text;
            StaffDetail.BirthDay = dateBirthday.Value;

            if (Decimal.TryParse(textBoxIdentityCard.Text, out tempDecimal))
            {
                StaffDetail.ICN = Convert.ToDecimal(textBoxIdentityCard.Text);
            }

            if ("Nam".Equals(comboBoxGender.SelectedItem.ToString()))
            {
                StaffDetail.Gender = Staff.GENDER_MALE;
            }
            else
            {
                StaffDetail.Gender = Staff.GENDER_FEMALE;
            }

            StaffDetail.Address = textBoxAddress.Text;

            // Process useraction
            try
            {
                // If useraction is add then insert to database else update
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

            // After process then close this form
            this.Close();
        }

        // Close form when click close button
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Set staffdetail to staffdetail form
        public void setStaffDetail(Staff staff)
        {
            this.StaffDetail = staff;
            textBoxStaffID.Text = staff.StaffID.ToString();
            textBoxFirstName.Text = staff.FirstName;
            textBoxLastName.Text = staff.LastName;
            dateBirthday.Value = staff.BirthDay;
            textBoxIdentityCard.Text = staff.ICN.ToString();

            if (staff.ICN == 0)
            {
                comboBoxGender.Text = "Nam";
            }
            else
            {
                comboBoxGender.Text = "Nữ";
            }

            textBoxAddress.Text = staff.Address;
            comboBoxDepartment.SelectedValue = (object)staff.DepartmentID;
            comboBoxMajor.SelectedValue = (object)staff.MajorID;
            comboBoxRole.SelectedValue = (object)staff.RoleID;
        }
    }
}
