using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiabetesDido.ClassificationLogic
{
    class TableMetaData
    {
        private static string[] testingAttributes = {"Cholesterol", "HDL_Cholesterol", "Triglyceride", "LDL_Cholesterol",
                                                       "Glucose", "SGOT", "SGPT", "Urea", "WBC", "LYM", "MONO", "TyLeLYM",
                                                       "TyLeMONO", "HGB", "RBC", "HTC", "MCV", "MCH", "MCHC", "RDW_CV", "PLT",
                                                       "MPV", "PDW", "PCT"};
        private static string classAttributes = "TieuDuong";
        private static string positiveString = "True";
        private static string negativeString = "False";

        public static string PositiveString
        {
            get { return positiveString; }
            private set { positiveString = value; }
        }

        public static string NegativeString
        {
            get { return negativeString; }
            private set { negativeString = value; }
        }

        public static string ClassAttribute
        {
            get { return TableMetaData.classAttributes; }
            private set { TableMetaData.classAttributes = value; }
        }

        public static string[] TestingAttributes
        {
            get { return TableMetaData.testingAttributes; }
            private set { TableMetaData.testingAttributes = value; }
        }

        public static string[] DiscreteTestingAttributes
        {
            get
            {
                List<string> attributeList = new List<string>(new string[] { "Tuoi", "GioiTinh" });
                attributeList.AddRange(testingAttributes);

                return attributeList.ToArray();
            }
        }

        public static string[] AllAttributes
        {
            get
            {
                List<string> attributeList = new List<string>(DiscreteTestingAttributes);
                attributeList.Add(classAttributes);

                return attributeList.ToArray();
            }
        }
    }
}
