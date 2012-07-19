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
        private SqlConnectionStringBuilder connectionBuilder;

        public FormDatabase()
        {
            InitializeComponent();

            connectionBuilder = new SqlConnectionStringBuilder();

            comboBoxConnection.SelectedIndex = 1;
            
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!superValidator1.Validate())
            {
                return;
            }

            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.ConnectionStrings.ConnectionStrings["Hospital.Properties.Settings.eHospital"].ConnectionString = getConnectionString();
            config.Save(ConfigurationSaveMode.Modified, true);
            ConfigurationManager.RefreshSection("connectionStrings");

            MessageBox.Show("Khởi động lại chương trình để kết nối mới có hiệu lực!");
            this.Close();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            if (!superValidator1.Validate())
            {
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(getConnectionString()))
                {
                    connection.Open();
                    MessageBox.Show("Kết nối thành công!");
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Kiểm tra lại chuỗi kết nối", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxConnection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxConnection.SelectedIndex == 0)
            {
                textBoxUsername.Enabled = false;
                textBoxPassword.Enabled = false;
            }
            else
            {
                textBoxUsername.Enabled = true;
                textBoxPassword.Enabled = true;
            }            
        }

        private string getConnectionString()
        {
            connectionBuilder.DataSource = textBoxServer.Text;
            connectionBuilder.InitialCatalog = textBoxDatabase.Text;            

            if (comboBoxConnection.SelectedIndex == 0)
            {
                connectionBuilder.IntegratedSecurity = true;
            }
            else
            {
                connectionBuilder.IntegratedSecurity = false;
                connectionBuilder.UserID = textBoxUsername.Text;
                connectionBuilder.Password = textBoxPassword.Text;
            }

            return connectionBuilder.ConnectionString;
        }
    }
}
