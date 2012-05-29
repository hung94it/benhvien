using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hospital.View
{
    public partial class FormReport : Form
    {
        public FormReport()
        {
            InitializeComponent();
        }

        private void FormReport_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            //reportViewer1.LocalReport.ReportEmbeddedResource = "test.rdlc";
        }
    }
}
