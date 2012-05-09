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
        public List<Function> GetListFunction()
        {
            List<Function> lstF = new List<Function>();

            return lstF;
        }
        public Function GetFunction()
        {
            Function newFunction = new Function();

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
