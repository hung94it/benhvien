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

        private void buttonStatisticsReport_Click(object sender, EventArgs e)
        {
            FormReport reportForm = new FormReport();

            switch (comboBoxStatisticsType.SelectedIndex)
            { 
                case 0:
                    reportForm.ReportType = "REVENUEBYDAY";                    
                    break;
                case 1:
                    reportForm.ReportType = "REVENUEBYMONTH";
                    break;
                case 2:
                    reportForm.ReportType = "REVENUEBYYEAR";
                    break;
                default:
                    MessageBox.Show("Chọn loại thống kê!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            reportForm.DATEFROM = dateTimeInputStatisticsDateFrom.Value;
            reportForm.DATETO = dateTimeInputStatisticsDateTo.Value;
            reportForm.Show();
        }

     }
}
