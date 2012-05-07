using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Hospital
{
    class Patient
    {
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

        //public Patient()
        //{

        //}

        //public Patient(decimal patientID, string firstName, string lastName, DateTime birthDay,
        //    int gender, decimal iCN, string profession, string address, decimal deposit, int state)
        //{
        //    PatientID = patientID;
        //    FirstName = firstName;
        //    LastName = lastName;
        //    BirthDay = birthDay;
        //    Gender = gender;
        //    ICN = iCN;
        //    Profession = profession;
        //    Address = address;
        //    Deposit = deposit;
        //    State = state;
        //}

        public Patient SetPatient(decimal patientID, string firstName, string lastName, DateTime birthDay,
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
            return this;
        }

        public Boolean InsertPatient()
        {
            return true;
        }
        public Boolean UpdatePatient()
        {
            return true;
        }
        public Boolean DeletePatient()
        {
            return true;
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
        public List<Patient> GetListPatient()
        {
            List<Patient> lstPatient = new List<Patient>();


            return lstPatient;
        }
        public Patient GetPatient()
        {
            Patient newPatient = new Patient();

            string sqlConnectString = ConfigurationManager.ConnectionStrings[
    "eHospital"].ConnectionString;

            string sqlSelect = @"SELECT * FROM PATIENT";

            //SqlDataAdapter da = new SqlDataAdapter(sqlSelect, sqlConnectString);
            //DataTable dt = new DataTable();
            //da.Fill(dt);

            using (SqlConnection connection = new SqlConnection(sqlConnectString))
            {
                SqlCommand command = new SqlCommand(sqlSelect, connection);
                connection.Open();

                // Create the DataReader to retrieve data
                using (SqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        newPatient = SetPatient(dr.GetDecimal(0), dr.GetString(1), dr.GetString(2),
                            dr.GetDateTime(3), dr.GetInt32(4), dr.GetDecimal(5), dr.GetString(6), dr.GetString(7),
                            dr.GetDecimal(8), dr.GetInt32(9));
                        // Output fields from DataReader row
                        //Console.WriteLine(
                        //    "test = {0}",
                        //    dr.GetString(1));
                    }
                }


            }

            return newPatient;
        }
    }
}
