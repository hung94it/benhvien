﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Hospital.Model
{
    class Assignment
    {
        private int assignID;
        private DateTime date;
        private DateTime dischargeDate;
        private DateTime hospitalizateDate;

        public DateTime HospitalizateDate
        {
            get { return hospitalizateDate; }
            set { hospitalizateDate = value; }
        }
        public DateTime DischargeDate
        {
            get { return dischargeDate; }
            set { dischargeDate = value; }
        }
        
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }       
        public int AssignID
        {
            get { return assignID; }
            set { assignID = value; }
        }

        public Boolean InsertAssignment()
        {
            return true;
        }
        public Boolean UpdateAssignment()
        {
            return true;
        }
        public Boolean DeleteAssignment()
        {
            return false;
        }
        public DataTable GetListAssignment()
        {
            DataTable dtAssignment = new DataTable();

            return dtAssignment;
        }
        public Assignment GetAssignment(int assignID)
        {
            Assignment assign = new Assignment();

            return assign;
        }
    }
}
