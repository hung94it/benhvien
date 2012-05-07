using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Hospital.Model
{
    class Major
    {
        private int majorID;
        private int majorName;

        public int MajorName
        {
            get { return majorName; }
            set { majorName = value; }
        }

        public int MajorID
        {
            get { return majorID; }
            set { majorID = value; }
        }
        public DataTable GetListMajor()
        {
            DataTable dtMajor = new DataTable();

            return dtMajor;
        }
        public Major GetMajor()
        {
            Major newMajor = new Major();

            return newMajor;
        }
    }
}
