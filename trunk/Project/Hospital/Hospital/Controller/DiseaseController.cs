using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Hospital.Model;

namespace Hospital.Controller
{
    class DiseaseController
    {
        public DataTable GetListDisease()
        {
            DataTable dtDisease = new DataTable();

            return dtDisease;
        }
        public DataTable GetDisease()
        {
            DataTable newDisease = new DataTable();

            return newDisease;
        }
        public Boolean InsertDisease(Disease newDisease)
        {
            return true;
        }
        public Boolean UpdateDisease(Disease newDisease)
        {
            return true;
        }
        public Boolean DeleteDisease(Disease newDisease)
        {
            return true;
        }
    }
}
