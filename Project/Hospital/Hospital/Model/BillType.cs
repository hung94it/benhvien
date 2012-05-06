using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hospital.Model
{
    class BillType
    {
        private int billTypeID;
        private String typeName;
        private Bill a;

        public String TypeName
        {
            get { return typeName; }
            set { typeName = value; }
        }
        public int BillTypeID
        {
            get { return billTypeID; }
            set { billTypeID = value; }
        }
        public BillType GetBillType()
        {
            BillType billType = new BillType();

            return billType;
        }
        public List<BillType> GetListBillType()
        {
            List<BillType> lstBillType = new List<BillType>();

            return lstBillType;
        }
    }
}
