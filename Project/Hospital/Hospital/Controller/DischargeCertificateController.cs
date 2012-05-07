using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Hospital.Model;


namespace Hospital.Controller
{
    class DischargeCertificateController
    {
        public DataTable GetListDC()
        {
            DataTable dtDC = new DataTable();

            return dtDC;
        }
        public DataTable GetDC()
        {
            DataTable newDC = new DataTable();

            return newDC;
        }
        public Boolean InsertDC(DischargeCertificate newDC)
        {
            return true;
        }
        public Boolean UpdateDC(DischargeCertificate newDC)
        {
            return true;
        }
        public Boolean DeleteDC(DischargeCertificate newDC)
        {
            return true;
        }
    }
}
