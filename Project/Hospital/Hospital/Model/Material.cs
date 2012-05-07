using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Hospital.Model
{
    class Material
    {
        private int materialID;
        private int materialName;
        private int quantity;
        private int price;

        public int Price
        {
            get { return price; }
            set { price = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public int MaterialName
        {
            get { return materialName; }
            set { materialName = value; }
        }
        public int MaterialID
        {
            get { return materialID; }
            set { materialID = value; }
        }
        public Boolean InsertMaterial()
        {
            return true;
        }
        public Boolean UpdateMaterial()
        {
            return true;
        }
        public Boolean DeleteMaterial()
        {
            return true;
        }
        public DataTable GetListMaterial()
        {
            DataTable dtM = new DataTable();

            return dtM;
        }
        public Material GetMaterial()
        {
            Material newMaterial = new Material();

            return newMaterial;
        }
    }
}
