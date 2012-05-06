using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hospital.Model
{
    class Patient
    {
        private int patientID;
        private String firstName;
        private String lastName;
        private DateTime birthDay;
        private int gender;
        private int iCN;
        private String profession;
        private String address;
        private int deposit;
        private int state;

        public int State
        {
            get { return state; }
            set { state = value; }
        }

        public int Deposit
        {
            get { return deposit; }
            set { deposit = value; }
        }

        public String Address
        {
            get { return address; }
            set { address = value; }
        }

        public String Profession
        {
            get { return profession; }
            set { profession = value; }
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

        public int PatientID
        {
            get { return patientID; }
            set { patientID = value; }
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

            return newPatient;
        }
    }
}
