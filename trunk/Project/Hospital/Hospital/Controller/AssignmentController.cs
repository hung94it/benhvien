using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hospital.Model;
using System.Data;

namespace Hospital.Controller
{
    class AssignmentController
    {
        public DataTable GetListAssignment()
        {
            DataTable dtA = new DataTable();

            return dtA;
        }
        public DataTable GetListAssignmentDetail(int assignID)
        {
            DataTable dtAD = new DataTable();

            return dtAD;
        }
        public DataTable GetAssignment(int assignID)
        {
            DataTable newAssignment = new DataTable();

            return newAssignment;
        }
        public Boolean InsertAssignment(Assignment newAssignment)
        {
            return true;
        }
        public Boolean UpdateAssignment(Assignment newAssignment)
        {
            return true;
        }
        public Boolean DeleteAssignment(Assignment newAssignment)
        {
            return true;
        }
    }
}
