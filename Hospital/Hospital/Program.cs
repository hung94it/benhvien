using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Hospital.View;
//using System.Threading;
using Hospital.Model;

namespace Hospital
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.ThreadException += new ThreadExceptionEventHandler(Application_ThreadException); 
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            Application.Run(new FormLogin());

            // Test
            //Bill newBill = Bill.GetBill(10000017);            
            //Patient patient = Patient.GetPatient(10000000);
            //Application.Run(new FormBillDetail("edit", newBill));
            FormReport test = new FormReport();
            test.ReportType = "REVENUEBYDAY";
            test.ObjectID = 10000001;
            test.DATEFROM = new DateTime(2012, 5, 30);
            test.DATETO = new DateTime(2012, 6, 4);
            //Application.Run(test);
            //Application.Run(new Form2());
        }

        //static void Application_ThreadException(
        //object sender, ThreadExceptionEventArgs e)
        //{
        //    // Do logging or whatever here
        //    Application.Exit();
        //}
    }
}
