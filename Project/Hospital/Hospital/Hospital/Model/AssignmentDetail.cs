using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Hospital.Model
{
    class AssignmentDetail
    {
        private int patientID;
        private int assignID;
        private int staffID;

        public int StaffID
        {
            get { return staffID; }
            set { staffID = value; }
        }
        public int AssignID
        {
            get { return assignID; }
            set { assignID = value; }
        }
        public int PatientID
        {
            get { return patientID; }
            set { patientID = value; }
        }

        public Boolean InsertAssignmentDetails()
        {
            return true;
        }
        public Boolean UpdateAssignmentDetails()
        {
            return true;
        }
        public Boolean DeleteAssignmentDetails()
        {
            return true;
        }
        public DataTable GetListAssignmentDetails()
        {
            DataTable dtAD = new DataTable();

            return dtAD;
        }
    }
}
