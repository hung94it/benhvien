using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Data.SqlClient;
using System.Configuration;

namespace DiabetesDido.UI
{
    public partial class FormDatabaseConnection : DevComponents.DotNetBar.Metro.MetroForm
    {
        private SqlConnectionStringBuilder connectionBuilder;

        public FormDatabaseConnection()
        {
            InitializeComponent();

            connectionBuilder = new SqlConnectionStringBuilder(Properties.Settings.Default.testConnectionString);

            comboBoxConnection.SelectedIndex = 0;

            this.textBoxServer.Text = this.connectionBuilder.DataSource;
            this.textBoxDatabase.Text = this.connectionBuilder.InitialCatalog;
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(getConnectionString()))
                {
                    connection.Open();                    
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Kiểm tra lại chuỗi kết nối", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.ConnectionStrings.ConnectionStrings["DiabetesDido.Properties.Settings.testConnectionString"].ConnectionString = getConnectionString();
                config.Save(ConfigurationSaveMode.Modified, true);
                ConfigurationManager.RefreshSection("connectionStrings");

                FormMain formMain = new FormMain();
                formMain.FormClosed += new FormClosedEventHandler(formMain_FormClosed);
                this.Hide();
                formMain.Show();
                       
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxConnection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBoxConnection.SelectedIndex == 0)
            {
                this.textBoxUsername.Enabled = false;
                this.textBoxPassword.Enabled = false;
            }
            else
            {
                this.textBoxUsername.Enabled = true;
                this.textBoxPassword.Enabled = true;
            }
        }

        private string getConnectionString()
        {
            this.connectionBuilder.DataSource = textBoxServer.Text;
            this.connectionBuilder.InitialCatalog = textBoxDatabase.Text;

            if (this.comboBoxConnection.SelectedIndex == 0)
            {
                this.connectionBuilder.IntegratedSecurity = true;
            }
            else
            {
                this.connectionBuilder.IntegratedSecurity = false;
                this.connectionBuilder.UserID = textBoxUsername.Text;
                this.connectionBuilder.Password = textBoxPassword.Text;
            }

            return connectionBuilder.ConnectionString;
        }

        public void formMain_FormClosed(Object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}