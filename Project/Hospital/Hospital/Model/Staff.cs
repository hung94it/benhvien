using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Hospital.Functional;

namespace Hospital.Model
{
    public class Staff
    {
        public const int GENDER_MALE = 0;
        public const int GENDER_FEMALE = 1;
        public static DataTable staffTable;

        public int StaffID { get; set; }
        public int RoleID { get; set; }
        public int MajorID { get; set; }
        public int DepartmentID { get; set; }
        public String Password { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public DateTime BirthDay { get; set; }
        public int Gender { get; set; }
        public decimal ICN { get; set; }
        public String Address { get; set; }
        public int State { get; set; }

        public Staff() { }

        public Staff(int patientID, int majorID, int departmentID, int roleID, string password, string firstName, string lastName,
            DateTime birthDay, int gender, decimal iCN, string address, int state)
        {
            StaffID = patientID;
            MajorID = majorID;
            DepartmentID = departmentID;
            RoleID = roleID;
            Password = password;
            FirstName = firstName;
            LastName = lastName;
            BirthDay = birthDay;
            Gender = gender;
            ICN = iCN;
            Address = address;
            State = state;
        }

        public static int InsertStaff(Staff staff)
        {
            string sqlInsert = @"INSERT INTO STAFF
                         (DEPARTMENTID, MAJORID, ROLEID, PASSWORD, FIRSTNAME, LASTNAME, BIRTHDAY, GENDER, ICN, ADDRESS, STATE)
                         (@DepartmentID, @MajorID, @RoleID, @Password, @FirstName, @LastName, @BirthDay, @Gender, @ICN, @Address, @State)";
            SqlParameter[] sqlParameters = {   new SqlParameter("@DepartmentID", staff.DepartmentID),
                                           new SqlParameter("@MajorID", staff.MajorID),
                                           new SqlParameter("@RoleID", staff.RoleID),
                                           new SqlParameter("@Password", staff.Password),
                                           new SqlParameter("@FirstName", staff.FirstName),
                                           new SqlParameter("@LastName", staff.LastName),
                                           new SqlParameter("@BirthDay", staff.BirthDay),
                                           new SqlParameter("@Gender", staff.Gender),
                                           new SqlParameter("@ICN", staff.ICN),
                                           new SqlParameter("@Address", staff.Address),
                                           new SqlParameter("@State", staff.State)};
            return SqlResult.ExecuteNonQuery(sqlInsert, sqlParameters);
        }

        public static int UpdateStaff(Staff staff)
        {
            string sqlUpdate = @"UPDATE STAFF
                                SET DEPARTMENTID = @DepartmentID, MAJORID = @MajorID, ROLEID = @RoleID, PASSWORD = @Password
                                                 , FIRSTNAME = @FirstName, LASTNAME = @LastName, BIRTHDAY = @BirthDay, GENDER = @Gender
                                                 , ICN = @ICN, ADDRESS = @Address, STATE = @State
                                WHERE (PATIENTID = @PatientID)";
            SqlParameter[] sqlParameters = { new SqlParameter("StaffID", staff.StaffID),
                                           new SqlParameter("@DepartmentID", staff.DepartmentID),
                                           new SqlParameter("@MajorID", staff.MajorID),
                                           new SqlParameter("@RoleID", staff.RoleID),
                                           new SqlParameter("@Password", staff.Password),
                                           new SqlParameter("@FirstName", staff.FirstName),
                                           new SqlParameter("@LastName", staff.LastName),
                                           new SqlParameter("@BirthDay", staff.BirthDay),
                                           new SqlParameter("@Gender", staff.Gender),
                                           new SqlParameter("@ICN", staff.ICN),
                                           new SqlParameter("@Address", staff.Address),
                                           new SqlParameter("@State", staff.State)};
            return SqlResult.ExecuteNonQuery(sqlUpdate, sqlParameters);
        }

        public static int DeleteStaff(int staffID)
        {
            string sqlDelete = @"DELETE FROM STAFF
                                WHERE (STAFFID = @StaffID)";
            SqlParameter[] sqlParameters = { new SqlParameter("@StaffID", staffID) };
            return SqlResult.ExecuteNonQuery(sqlDelete, sqlParameters);
        }

        public static DataView GetListStaff()
        {
            string sqlSelect = @"SELECT STAFF.STAFFID, DEPARTMENT.DEPARTMENTNAME, MAJOR.MAJORNAME, ROLE.ROLENAME, STAFF.PASSWORD
                                    , STAFF.FIRSTNAME, STAFF.LASTNAME, STAFF.BIRTHDAY, STAFF.GENDER, STAFF.ICN, STAFF.ADDRESS, STAFF.STATE
                                FROM STAFF INNER JOIN
                                    DEPARTMENT ON STAFF.DEPARTMENTID = DEPARTMENT.DEPARTMENTID INNER JOIN
                                    MAJOR ON STAFF.MAJORID = MAJOR.MAJORID INNER JOIN
                                    ROLE ON STAFF.ROLEID = ROLE.ROLEID";

            staffTable = SqlResult.ExecuteQuery(sqlSelect);

            staffTable.Columns.Add("Mã nhân viên", typeof(string), "[STAFFID]");
            staffTable.Columns.Add("Họ tên", typeof(string), "[LASTNAME] + ' ' + [FIRSTNAME]");
            staffTable.Columns.Add("CMND", typeof(string), "[ICN]");
            staffTable.Columns.Add("Giới tính", typeof(string), "IIF([GENDER] = 0, 'Nam', 'Nữ')");
            staffTable.Columns.Add("Ngày sinh", typeof(DateTime), "[BIRTHDAY]");
            staffTable.Columns.Add("Địa chỉ", typeof(string), "[ADDRESS]");

            return staffTable.DefaultView;
        }

        public static Staff GetStaff(int staffID)
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
