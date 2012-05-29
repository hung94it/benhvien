using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Hospital.View
{
    public partial class FormDatabase : Form
    {
        public FormDatabase()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.ConnectionStrings.ConnectionStrings["eHospital"].ConnectionString = textBoxConnectionString.Text;
            config.Save(ConfigurationSaveMode.Modified, true);
            ConfigurationManager.RefreshSection("connectionStrings");

            string temp = ConfigurationManager.ConnectionStrings["eHospital"].ConnectionString;
            this.Close();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(textBoxConnectionString.Text))
                {
                    connection.Open();
                    MessageBox.Show("OK. Khởi động lại chương trình để kết nối mới có hiệu lực!");
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Kiểm tra lại chuỗi kết nối", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
