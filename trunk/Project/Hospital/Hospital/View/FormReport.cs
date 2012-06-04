using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Hospital.View
{

    public partial class FormReport : Form
    {
        private Hospital.Report reportDataset;
        private Microsoft.Reporting.WinForms.ReportDataSource reportDataSource;
        public string ReportType { get; set; }
        public int ObjectID { get; set; }
        public DateTime DATEFROM { get; set; }
        public DateTime DATETO { get; set; }

        public FormReport()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.reportDataset = new Report();
            this.reportDataSource = new Microsoft.Reporting.WinForms.ReportDataSource();

            this.reportViewer1.ProcessingMode = ProcessingMode.Local;

            switch (ReportType)
            {
                case "EC":
                    ReportTableAdapters.ECTableAdapter ECTableAdapter = new ReportTableAdapters.ECTableAdapter();
                    ECTableAdapter.Fill(reportDataset.EC, this.ObjectID);

                    this.reportDataSource.Name = "EC";
                    this.reportDataSource.Value = this.reportDataset.EC;

                    this.reportViewer1.LocalReport.ReportEmbeddedResource = "Hospital.Report.EC.rdlc";

                    break;
                case "MEDICINEBILL":
                    ReportTableAdapters.MEDICINEBILLTableAdapter MEDICINEBILLTableAdapter = new ReportTableAdapters.MEDICINEBILLTableAdapter();
                    MEDICINEBILLTableAdapter.Fill(reportDataset.MEDICINEBILL, this.ObjectID);

                    this.reportDataSource.Name = "MEDICINEBILL";
                    this.reportDataSource.Value = this.reportDataset.MEDICINEBILL;

                    this.reportViewer1.LocalReport.ReportEmbeddedResource = "Hospital.Report.MEDICINEBILL.rdlc";

                    break;
                case "SERVICEBILL":
                    ReportTableAdapters.SERVICEBILLTableAdapter SERVICEBILLTableAdapter = new ReportTableAdapters.SERVICEBILLTableAdapter();
                    SERVICEBILLTableAdapter.Fill(reportDataset.SERVICEBILL, this.ObjectID);

                    this.reportDataSource.Name = "SERVICEBILL";
                    this.reportDataSource.Value = this.reportDataset.SERVICEBILL;

                    this.reportViewer1.LocalReport.ReportEmbeddedResource = "Hospital.Report.SERVICEBILL.rdlc";
                    break;
                case "MATERIALBILL":
                    ReportTableAdapters.MATERIALBILLTableAdapter METERIALBILLTableAdapter = new ReportTableAdapters.MATERIALBILLTableAdapter();
                    METERIALBILLTableAdapter.Fill(reportDataset.MATERIALBILL, 10000002);

                    this.reportDataSource.Name = "MATERIALBILL";
                    this.reportDataSource.Value = this.reportDataset.MATERIALBILL;

                    this.reportViewer1.LocalReport.ReportEmbeddedResource = "Hospital.Report.MATERIALBILL.rdlc";
                    break;
                case "REVENUEBYDAY":
                    ReportTableAdapters.REVENUEBYDAYTableAdapter REVENUEBYDAYTableAdapter = new ReportTableAdapters.REVENUEBYDAYTableAdapter();
                    REVENUEBYDAYTableAdapter.Fill(reportDataset.REVENUEBYDAY, this.DATEFROM, this.DATETO);

                    this.reportDataSource.Name = "REVENUEBYDAY";
                    this.reportDataSource.Value = this.reportDataset.REVENUEBYDAY;

                    //this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { 
                    //new ReportParameter("DateForm", this.DATEFROM.ToShortDateString()),
                    //new ReportParameter("DateTo", this.DATETO.ToShortDateString()) });
                    this.reportViewer1.LocalReport.ReportEmbeddedResource = "Hospital.Report.REVENUEBYDAY.rdlc";
                    break;
                case "REVENUEBYMONTH":
                    ReportTableAdapters.REVENUEBYMONTHTableAdapter REVENUEBYMONTHTableAdapter = new ReportTableAdapters.REVENUEBYMONTHTableAdapter();
                    REVENUEBYMONTHTableAdapter.Fill(reportDataset.REVENUEBYMONTH, this.DATEFROM, this.DATETO);

                    this.reportDataSource.Name = "REVENUEBYMONTH";
                    this.reportDataSource.Value = this.reportDataset.REVENUEBYMONTH;

                    this.reportViewer1.LocalReport.ReportEmbeddedResource = "Hospital.Report.REVENUEBYMONTH.rdlc";
                    break;
                case "REVENUEBYYEAR":
                    ReportTableAdapters.REVENUEBYYEARTableAdapter REVENUEBYYEARTableAdapter = new ReportTableAdapters.REVENUEBYYEARTableAdapter();
                    REVENUEBYYEARTableAdapter.Fill(reportDataset.REVENUEBYYEAR, this.DATEFROM, this.DATETO);

                    this.reportDataSource.Name = "REVENUEBYYEAR";
                    this.reportDataSource.Value = this.reportDataset.REVENUEBYYEAR;

                    this.reportViewer1.LocalReport.ReportEmbeddedResource = "Hospital.Report.REVENUEBYYEAR.rdlc";
                    break;
            }

            this.reportViewer1.LocalReport.DataSources.Add(this.reportDataSource);
            this.reportViewer1.RefreshReport();


            //this.reportDataset = new Report();
            //this.reportDataSource = new Microsoft.Reporting.WinForms.ReportDataSource();

            //this.reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;


            //ReportTableAdapters.REVENUEBYYEARTableAdapter REVENUEBYYEARTableAdapter = new ReportTableAdapters.REVENUEBYYEARTableAdapter();
            //REVENUEBYYEARTableAdapter.Fill(reportDataset.REVENUEBYYEAR, this.DATEFROM, this.DATETO);

            //this.reportDataSource.Name = "REVENUEBYYEAR";
            //this.reportDataSource.Value = this.reportDataset.REVENUEBYYEAR;

            //this.reportViewer1.LocalReport.ReportEmbeddedResource = "Hospital.Report.REVENUEBYYEAR.rdlc";

            //this.reportViewer1.LocalReport.DataSources.Add(this.reportDataSource);
            //this.reportViewer1.RefreshReport();
        }
    }
}
