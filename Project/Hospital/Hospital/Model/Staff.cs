using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Hospital.Model
{
    class Staff
    {
        public int StaffID { get; set; }
        public int DepartmentID { get; set; }
        public int MajorID { get; set; }
        public int DecentralizationID { get; set; }
        public String Password { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public DateTime BirthDay { get; set; }
        public int Gender { get; set; }
        public int ICN { get; set; }
        public String Address { get; set; }
        public int State { get; set; }
        
        public Boolean InsertStaff()
        {
            return true;
        }
        public Boolean UpdateStaff()
        {
            return true;
        }
        public Boolean DeleteStaff()
        {
            return true;
        }
        public DataTable GetListStaff()
        {
            DataTable dtStaff = new DataTable();

            return dtStaff;
        }
        public Staff GetPStaff()
        {
            Staff newStaff = new Staff();

            return newStaff;
        }
        public Boolean LogIn()
        {
            return true;
        }
        public Boolean ChangePassword()
        {
            return true;
        }
        public Boolean ChangeInformation()
        {
            return true;
        }
    }
}
