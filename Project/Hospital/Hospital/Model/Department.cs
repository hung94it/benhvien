using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Hospital.Model
{
    class Department
    {
        private int departmentID;
        private String departmentName;

        public String DepartmentName
        {
            get { return departmentName; }
            set { departmentName = value; }
        }

        public int DepartmentID
        {
            get { return departmentID; }
            set { departmentID = value; }
        }
        public Department GetDepartment()
        {
            Department newDepartment = new Department();

            return newDepartment;
        }
        public DataTable GetListDepartment()
        {
            DataTable dtDepartment = new DataTable();

            return dtDepartment;
        }
    }
}
