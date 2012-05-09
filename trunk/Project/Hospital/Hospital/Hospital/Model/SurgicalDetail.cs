using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Hospital.Model
{
    class SurgicalDetail
    {
        private int surgicalID;
        private int staffID;

        public int StaffID
        {
            get { return staffID; }
            set { staffID = value; }
        }

        public int SurgicalID
        {
            get { return surgicalID; }
            set { surgicalID = value; }
        }
        public Boolean InsertSurgicalDetail()
        {
            return true;
        }
        public Boolean UpdateSurgicalDetail()
        {
            return true;
        }
        public Boolean DeleteSurgicalDetail()
        {
            return true;
        }
        public DataTable GetSurgicalDetail()
        {
            DataTable dtSD = new DataTable();

            return dtSD;
        }
    }
}
