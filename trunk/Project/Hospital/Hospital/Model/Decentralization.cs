using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hospital.Model
{
    class Decentralization
    {
        private int decentID;
        private String decentName;

        public String DecentName
        {
            get { return decentName; }
            set { decentName = value; }
        }
        public int DecentID
        {
            get { return decentID; }
            set { decentID = value; }
        }
        public Boolean InsertDecentralization()
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
        public List<Decentralization> GetListDecentralization()
        {
            List<Decentralization> lstDecent = new List<Decentralization>();

            return lstDecent;
        }
        public Decentralization GetDecentralization()
        {
            Decentralization newDecent =new Decentralization();

            return newDecent;
        }
    }
}
