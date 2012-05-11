using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Hospital.View;
//using System.Threading;

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
            Application.Run(new FormMain());
        }

        //static void Application_ThreadException(
        //object sender, ThreadExceptionEventArgs e)
        //{
        //    // Do logging or whatever here
        //    Application.Exit();
        //}
    }
}
