using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hospital.Model;
using System.Data;

namespace Hospital.Controller
{
    class DecentralizationController
    {
        public DataTable GetListDecentralization()
        {
            DataTable dtD = new DataTable();

            return dtD;
        }
        public DataTable GetListDecentralizationDetail(int assignID)
        {
            DataTable dtDD = new DataTable();

            return dtDD;
        }
        public DataTable GetDecentralization()
        {
            DataTable newDecentralization = new DataTable();

            return newDecentralization;
        }
        public Boolean InsertDecentralization(DecentralizationController newDecentralization)
        {
            return true;
        }
        public Boolean UpdateDecentralization(DecentralizationController newDecentralization)
        {
            return true;
        }
        public Boolean DeleteDecentralization(DecentralizationController newDecentralization)
        {
            return true;
        }
        public DataTable GetListFunction()
        {
            DataTable dtF = new DataTable();

            return dtF;
        }
        public DataTable GetFunction()
        {
            DataTable newFunction = new DataTable();

            return newFunction;
        }
        public Boolean InsertFunction(Function newFunction)
        {
            return true;
        }
        public Boolean UpdateFunction(Function newFunction)
        {
            return true;
        }
        public Boolean DeleteFunction(Function newFunction)
        {
            return true;
        }
    }
    
}
