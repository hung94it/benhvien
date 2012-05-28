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

            // Test login
            Staff loginStaff = Staff.GetStaff(10000000);
            // Main form here
           // Application.Run(new FormMain(loginStaff));

            // Test
            Bill newBill = Bill.GetBill(10000017);            
            //Patient patient = Patient.GetPatient(10000000);
            Application.Run(new FormBillDetail("edit", newBill));
        }

        //static void Application_ThreadException(
        //object sender, ThreadExceptionEventArgs e)
        //{
        //    // Do logging or whatever here
        //    Application.Exit();
        //}
    }
}
