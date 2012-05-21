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
                if (int.TryParse(textBoxUsername.Text, out staffID))
                {
                    loginStaff = Staff.GetStaff(staffID);

                    if ((loginStaff.StaffID != 0) && (loginStaff.Password.Trim().Equals(textBoxPassword.Text)))
                    {
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

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}
