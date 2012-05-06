using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
        public List<Department> GetListDepartment()
        {
            List<Department> lstDepartment = new List<Department>();

            return lstDepartment;
        }
    }
}
