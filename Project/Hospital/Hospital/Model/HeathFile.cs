using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hospital.Model
{
    class HeathFile
    {
        private int heathFileID;
        private int patientID;
        private DateTime date;
        private String patientState;
        private String preHistory;
        private String disease;
        private String treament;

        public String Treament
        {
            get { return treament; }
            set { treament = value; }
        }

        public String Disease
        {
            get { return disease; }
            set { disease = value; }
        }
        public String PreHistory
        {
            get { return preHistory; }
            set { preHistory = value; }
        }
        public String PatientState
        {
            get { return patientState; }
            set { patientState = value; }
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public int PatientID
        {
            get { return patientID; }
            set { patientID = value; }
        }
        public int HeathFileID
        {
            get { return heathFileID; }
            set { heathFileID = value; }
        }
        public Boolean InsertHeathFile()
        {
            return true;
        }
        public Boolean UpdateHeathFile()
        {
            return true;
        }
        public Boolean DeleteHeathFile()
        {
            return true;
        }
        public List<HeathFile> GetListHeathFile()
        {
            List<HeathFile> lstHeathFile = new List<HeathFile>();

            return lstHeathFile;
        }
        public HeathFile GetHeathFile()
        {
            HeathFile hF = new HeathFile();

            return hF;
        }
    }
}
