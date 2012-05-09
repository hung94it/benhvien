using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Hospital.Functional;

namespace Hospital.Model
{
    class Patient
    {
        //Properties of Hospital class
        public int PatientID { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public DateTime BirthDay { get; set; }
        public int Gender { get; set; }
        public decimal ICN { get; set; }
        public String Profession { get; set; }
        public String Address { get; set; }
        public decimal Deposit { get; set; }
        public int State { get; set; }

        private static Patient tempPatient;

        //Default constructor
        public Patient() { }

        //Constructor set all properties
        public Patient(int patientID, string firstName, string lastName, DateTime birthDay,
            int gender, decimal iCN, string profession, string address, decimal deposit, int state)
        {
            PatientID = patientID;
            FirstName = firstName;
            LastName = lastName;
            BirthDay = birthDay;
            Gender = gender;
            ICN = iCN;
            Profession = profession;
            Address = address;
            Deposit = deposit;
            State = state;
        }

        //Insert new patient
        public static int InsertPatient(Patient patient)
        {
            string sqlInsert = @"INSERT INTO PATIENT
                                (FIRSTNAME, LASTNAME, BIRTHDAY, GENDER, ICN, PROFESSION, ADDRESS, DEPOSIT, STATE)
                                VALUES 
                                (@FirstName, @LastName, @BirthDay, @Gender, @ICN, @Profession, @Address, @Deposit, @State)";
            SqlParameter[] sqlParameters = { new SqlParameter("@FirstName", patient.FirstName),
                                           new SqlParameter("@LastName", patient.LastName),
                                           new SqlParameter("@BirthDay", patient.BirthDay),
                                           new SqlParameter("@Gender", patient.Gender),
                                           new SqlParameter("@ICN", patient.ICN),
                                           new SqlParameter("@Profession", patient.Profession),
                                           new SqlParameter("@Address", patient.Address),
                                           new SqlParameter("@Deposit", patient.Deposit),
                                           new SqlParameter("@State", patient.State)};
            return SqlResult.ExecuteNonQuery(sqlInsert, sqlParameters);
        }

        //Update patien by patientid
        public static int UpdatePatient(Patient patient)
        {
            string sqlUpdate = @"UPDATE PATIENT
                                SET FIRSTNAME = @FirstName, LASTNAME = @LastName, BIRTHDAY = @BirthDay, GENDER = @Gender,
                                    ICN = @ICN, PROFESSION = @Profession, ADDRESS = @Address, DEPOSIT = @Deposit, STATE = @State
                                WHERE (PATIENTID = @PatientID)";
            SqlParameter[] sqlParameters = { new SqlParameter("@PatientID", patient.PatientID), 
                                           new SqlParameter("@FirstName", patient.FirstName),
                                           new SqlParameter("@LastName", patient.LastName),
                                           new SqlParameter("@BirthDay", patient.BirthDay),
                                           new SqlParameter("@Gender", patient.Gender),
                                           new SqlParameter("@ICN", patient.ICN),
                                           new SqlParameter("@Profession", patient.Profession),
                                           new SqlParameter("@Address", patient.Address),
                                           new SqlParameter("@Deposit", patient.Deposit),
                                           new SqlParameter("@State", patient.State)};
            return SqlResult.ExecuteNonQuery(sqlUpdate, sqlParameters);
        }

        //Delete patient by patientid
        public static int DeletePatient(int patientID)
        {
            string sqlDelete = @"DELETE FROM PATIENT
                                WHERE (PATIENTID = @PatientID)";
            SqlParameter[] sqlParameters = { new SqlParameter("@PatientID", patientID) };
            return SqlResult.ExecuteNonQuery(sqlDelete, sqlParameters);
        }

        //Get list patient
        public static DataTable GetListPatient()
        {
            string sqlSelect = @"SELECT PATIENTID, FIRSTNAME, LASTNAME, BIRTHDAY, GENDER, ICN, PROFESSION, ADDRESS, DEPOSIT, STATE 
                                FROM PATIENT";
            DataTable dataTable = SqlResult.ExecuteQuery(sqlSelect);
            dataTable.Columns[0].ColumnName = "Mã bệnh nhân";
            return dataTable;
        }

        //Get patient by patientid
        public static Patient GetPatient(decimal patientID)
        {
            string sqlSelect = @"SELECT PATIENTID, FIRSTNAME, LASTNAME, BIRTHDAY, GENDER, ICN, PROFESSION, ADDRESS, DEPOSIT, STATE 
                                FROM PATIENT 
                                WHERE PATIENTID = @PatientID";
          
            return tempPatient;
        }

        public Boolean ChangePatientState()
        {
            return true;
        }

        public Boolean ChargeDeposit()
        {
            return true;
        }

        public List<Patient> GetResidentPatientList()
        {
            List<Patient> lstPatient = new List<Patient>();

            return lstPatient;
        }
    }
}
