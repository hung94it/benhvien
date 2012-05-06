using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hospital.Model
{
    class Function
    {
        private int functionID;
        private String fucntionName;
        private String button;

        public String Button
        {
            get { return button; }
            set { button = value; }
        }

        public String FucntionName
        {
            get { return fucntionName; }
            set { fucntionName = value; }
        }

        public int FunctionID
        {
            get { return functionID; }
            set { functionID = value; }
        }
        public Boolean InsertFunction()
        {
            return true;
        }
        public Boolean UpdateFunction()
        {
            return true;
        }
        public Boolean DeleteFunction()
        {
            return true;
        }
        public List<Function> GetListFunction()
        {
            List<Function> lstFunction = new List<Function>();

            return lstFunction;
        }
        public Function GetFunction()
        {
            Function newFunction = new Function();

            return newFunction;
        }
    }
}
