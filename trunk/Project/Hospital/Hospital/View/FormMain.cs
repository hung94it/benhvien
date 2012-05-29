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
    public partial class FormMain : Form
    {
        private Staff loginStaff { get; set; }

        public FormMain()
        {
            InitializeComponent();
        }

        public FormMain(Staff staff)
        {
            InitializeComponent();
            loginStaff = staff;
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            FormAbout aboutForm = new FormAbout();
            aboutForm.Show();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabMain_SelectedTabChanged(object sender, DevComponents.DotNetBar.SuperTabStripSelectedTabChangedEventArgs e)
        {
            switch((sender as DevComponents.DotNetBar.SuperTabControl).SelectedTab.Text)
            {
                case "Bệnh nhân":
                    refreshDataViewPatient();
                    break;
                case "Thuốc":
                    refreshDataViewMedicine();
                    break;
                case "Nhân viên":
                    refreshDataViewStaff();
                    break;
                case "Hóa đơn":
                    refreshDataViewBill();
                    break;
            }
        }
        
     }
}
