using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Hospital.Model
{
    class Decentralization
    {
        public int DecentID { get; set; }
        public String DecentName { get; set; }

        public Decentralization() { }
        public Decentralization(int decentID, String decentName)
        {
            this.DecentID = decentID;
            this.DecentName = DecentName;
        }
        public static int InsertDecentralization()
        {
            return true;
        }
        public Boolean UpdateDecentralization()
        {
            return true;
        }
        public Boolean DeleteDecentralization()
        {
            return true;
        }
        public DataTable GetListDecentralization()
        {
            DataTable dtDecent = new DataTable();

            return dtDecent;
        }
        public Decentralization GetDecentralization()
        {
            Decentralization newDecent =new Decentralization();

            return newDecent;
        }
    }
}
