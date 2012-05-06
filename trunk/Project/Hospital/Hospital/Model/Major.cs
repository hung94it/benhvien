using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
        public List<Major> GetListMajor()
        {
            List<Major> lstMajor = new List<Major>();

            return lstMajor;
        }
        public Major GetMajor()
        {
            Major newMajor = new Major();

            return newMajor;
        }
    }
}
