using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Hospital.Model
{
    class Patient
    {
        //Properties of Hospital class
        public decimal PatientID { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public DateTime BirthDay { get; set; }
        public int Gender { get; set; }
        public decimal ICN { get; set; }
        public String Profession { get; set; }
        public String Address { get; set; }
        public decimal Deposit { get; set; }
        public int State { get; set; }

        //This static instance is used to store patient temporary for this class's static method
        private static Patient tempPatient;

        //Default constructor
        public Patient() { }

        //Constructor set all properties
        public Patient(decimal patientID, string firstName, string lastName, DateTime birthDay,
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
        public static Boolean InsertPatient(Patient patient)
        {
            string sqlConnectString = ConfigurationManager.ConnectionStrings["eHospital"].ConnectionString;
            string sqlInsert = @"INSERT INTO PATIENT
                                (FIRSTNAME, LASTNAME, BIRTHDAY, GENDER, ICN, PROFESSION, ADDRESS, DEPOSIT, STATE)
                                VALUES 
                                (@FirstName, @LastName, @BirthDay, @Gender, @ICN, @Profession, @Address, @Deposit, @State)";
            try
            {
                using (SqlConnection connection = new SqlConnection(sqlConnectString))
                {
                    SqlCommand command = new SqlCommand(sqlInsert, connection);
                    command.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = patient.FirstName;
                    command.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = patient.LastName;
                    command.Parameters.Add("@BirthDay", SqlDbType.DateTime).Value = patient.BirthDay;
                    command.Parameters.Add("@Gender", SqlDbType.Int).Value = patient.Gender;
                    command.Parameters.Add("@ICN", SqlDbType.Decimal).Value = patient.ICN;
                    command.Parameters.Add("@Profession", SqlDbType.NVarChar).Value = patient.Profession;
                    command.Parameters.Add("@Address", SqlDbType.NVarChar).Value = patient.Address;
                    command.Parameters.Add("@Deposit", SqlDbType.Money).Value = patient.Deposit;
                    command.Parameters.Add("@State", SqlDbType.Int).Value = patient.State;
                    connection.Open();
                    if (command.ExecuteNonQuery() == 0)
                        return false;
                    else
                        return true;
                }
            }
            catch (SqlException e)
            {
                throw e;
            }
        }

        //Update patien by patientid
        public static Boolean UpdatePatient(Patient patient)
        {
            string sqlConnectString = ConfigurationManager.ConnectionStrings["eHospital"].ConnectionString;
            string sqlInsert = @"UPDATE PATIENT
                                SET FIRSTNAME = @FirstName, LASTNAME = @LastName, BIRTHDAY = @BirthDay, GENDER = @Gender,
                                    ICN = @Icn, PROFESSION = @Profession, ADDRESS = @Address, DEPOSIT = @Deposit, STATE = @State
                                WHERE (PATIENTID = @PatientID)";
            try
            {
                using (SqlConnection connection = new SqlConnection(sqlConnectString))
                {
                    SqlCommand command = new SqlCommand(sqlInsert, connection);
                    command.Parameters.Add("@PatientID", SqlDbType.Decimal).Value = patient.PatientID;
                    command.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = patient.FirstName;
                    command.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = patient.LastName;
                    command.Parameters.Add("@BirthDay", SqlDbType.DateTime).Value = patient.BirthDay;
                    command.Parameters.Add("@Gender", SqlDbType.Int).Value = patient.Gender;
                    command.Parameters.Add("@ICN", SqlDbType.Decimal).Value = patient.ICN;
                    command.Parameters.Add("@Profession", SqlDbType.NVarChar).Value = patient.Profession;
                    command.Parameters.Add("@Address", SqlDbType.NVarChar).Value = patient.Address;
                    command.Parameters.Add("@Deposit", SqlDbType.Money).Value = patient.Deposit;
                    command.Parameters.Add("@State", SqlDbType.Int).Value = patient.State;
                    connection.Open();
                    if (command.ExecuteNonQuery() == 0)
                        return false;
                    else
                        return true;
                }
            }
            catch (SqlException e)
            {
                throw e;
            }
        }

        //Delete patient by patientid
        public static Boolean DeletePatient(decimal patientID)
        {
            string sqlConnectString = ConfigurationManager.ConnectionStrings["eHospital"].ConnectionString;
            string sqlInsert = @"DELETE FROM PATIENT
                                WHERE (PATIENTID = @PatientID)";
            try
            {
                using (SqlConnection connection = new SqlConnection(sqlConnectString))
                {
                    SqlCommand command = new SqlCommand(sqlInsert, connection);
                    command.Parameters.Add("@PatientID", SqlDbType.Decimal).Value = patientID;
                    connection.Open();
                    if (command.ExecuteNonQuery() == 0)
                        return false;
                    else
                        return true;
                }
            }
            catch (SqlException e)
            {
                throw e;
            }
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

        //Get list patient
        public static List<Patient> GetListPatient()
        {
            List<Patient> lstPatient = new List<Patient>();
            //Get connectiong string from app.config
            string sqlConnectString = ConfigurationManager.ConnectionStrings["eHospital"].ConnectionString;
            //Prepare query string
            string sqlSelect = @"SELECT PATIENTID, FIRSTNAME, LASTNAME, BIRTHDAY, GENDER, ICN, PROFESSION, ADDRESS, DEPOSIT, STATE
                                FROM PATIENT";

            try
            {
                //Using connection pooling and close connection after finished 
                using (SqlConnection connection = new SqlConnection(sqlConnectString))
                {
                    //Create new command with connection string and query string
                    SqlCommand command = new SqlCommand(sqlSelect, connection);
                    connection.Open();
                    //Excute command and close datareader after finished
                    using (SqlDataReader dr = command.ExecuteReader())
                    {
                        //Read all records
                        while (dr.Read())
                        {
                            //Create new Patient instance and store it in this class's static field patient
                            tempPatient = new Patient(dr.GetDecimal(0), dr.GetString(1), dr.GetString(2),
                                dr.GetDateTime(3), dr.GetInt32(4), dr.GetDecimal(5), dr.GetString(6), dr.GetString(7),
                                dr.GetDecimal(8), dr.GetInt32(9));
                            //Add patient to List<Patient>
                            lstPatient.Add(tempPatient);
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                throw e;
            }
            return lstPatient;
        }

        //Get patient by patientid
        public static Patient GetPatient(decimal patientID)
        {
            string sqlConnectString = ConfigurationManager.ConnectionStrings["eHospital"].ConnectionString;
            string sqlSelect = @"SELECT PATIENTID, FIRSTNAME, LASTNAME, BIRTHDAY, GENDER, ICN, PROFESSION, ADDRESS, DEPOSIT, STATE 
                                FROM PATIENT 
                                WHERE PATIENTID = @PatientID";

            try
            {
                using (SqlConnection connection = new SqlConnection(sqlConnectString))
                {
                    SqlCommand command = new SqlCommand(sqlSelect, connection);
                    //Add parameter with its sqldbType and set its value
                    command.Parameters.Add("@PatientID", SqlDbType.Decimal).Value = patientID;
                    connection.Open();
                    using (SqlDataReader dr = command.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            tempPatient = new Patient(dr.GetDecimal(0), dr.GetString(1), dr.GetString(2),
                                dr.GetDateTime(3), dr.GetInt32(4), dr.GetDecimal(5), dr.GetString(6), dr.GetString(7),
                                dr.GetDecimal(8), dr.GetInt32(9));
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                throw e;
            }
            return tempPatient;
        }
    }
}
