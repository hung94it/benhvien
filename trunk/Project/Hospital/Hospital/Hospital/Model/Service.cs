using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Hospital.Model
{
    class Service
    {
        private int serviceID;
        private String serviceName;
        private int price;

        public String ServiceName
        {
            get { return serviceName; }
            set { serviceName = value; }
        }
        
        public int Price
        {
            get { return price; }
            set { price = value; }
        }



        public int ServiceID
        {
            get { return serviceID; }
            set { serviceID = value; }
        }
        public Boolean InsertService()
        {
            return true;
        }
        public Boolean UpdateService()
        {
            return true;
        }
        public Boolean DeleteService()
        {
            return true;
        }
        public DataTable GetListService()
        {
            DataTable dtS = new DataTable();

            return dtS;
        }
        public Service GetService()
        {
            Service newService = new Service();

            return newService;
        }
    }
}
