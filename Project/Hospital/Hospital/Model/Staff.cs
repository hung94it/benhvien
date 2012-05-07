using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Hospital.Model
{
    class Staff
    {
        private int staffID;
        private int departmentID;
        private int majorID;
        private int decentralizationID;
        private String password;
        private String firstName;
        private String lastName;
        private DateTime birthDay;
        private int gender;
        private int iCN;
        private String andress;
        private int state;
        public String Password
        {
            get { return password; }
            set { password = value; }
        }
       

        public int State
        {
            get { return state; }
            set { state = value; }
        }

        public String Andress
        {
            get { return andress; }
            set { andress = value; }
        }

        public int ICN
        {
            get { return iCN; }
            set { iCN = value; }
        }

        public int Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public DateTime BirthDay
        {
            get { return birthDay; }
            set { birthDay = value; }
        }

        public String LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public String FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }



        public int DecentralizationID
        {
            get { return decentralizationID; }
            set { decentralizationID = value; }
        }

        public int MajorID
        {
            get { return majorID; }
            set { majorID = value; }
        }

        public int DepartmentID
        {
            get { return departmentID; }
            set { departmentID = value; }
        }

        public int StaffID
        {
            get { return staffID; }
            set { staffID = value; }
        }
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
