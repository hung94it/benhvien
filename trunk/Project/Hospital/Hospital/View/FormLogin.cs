using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Hospital.Model;
using System.Data.SqlClient;

namespace Hospital.View
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            int staffID;
            Staff loginStaff;

            try
            {
                // Check if username is number only
                if (int.TryParse(textBoxUsername.Text, out staffID))
                {
                    loginStaff = Staff.GetStaff(staffID);

                    // Check if username and password is valid
                    if ((loginStaff.StaffID != 0) && (loginStaff.Password.Trim().Equals(textBoxPassword.Text)))
                    {
                        // Show FormMain and hide FormLogin
                        FormMain mainForm = new FormMain(loginStaff);
                        mainForm.FormClosed += new FormClosedEventHandler(FormLogin_FormClosed);
                        mainForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản không hợp lệ", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Tài khoản không hợp lệ", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                

            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message, "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Show FormLogin if FormMain close
        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}
