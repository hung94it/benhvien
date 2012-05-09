using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Hospital.Model
{
    class DecentralizationDetail
    {
        private int decentID;
        private int functionID;

        public int FunctionID
        {
            get { return functionID; }
            set { functionID = value; }
        }
        public int DecentID
        {
            get { return decentID; }
            set { decentID = value; }
        }
        public Boolean InsertDecentralizationDetail()
        {
            return true;
        }
        public Boolean DeleteDecentralizationDetail()
        {
            return true;
        }
        public Boolean UpdateDecentralizationDetail()
        {
            return true;
        }
        public DataTable GetListStaffFunction()
        {
            DataTable dtDecentDetail = new DataTable();

            return dtDecentDetail;
        }
    }
}
