using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Diabetes.DTO
{
    public class ResultSetDTO
    {
        public string HoTen { get; set; }
        public string Tuoi { get; set; }
        public int TieuDuong { get; set; }
        public string GioiTinh { get; set; }
        public string Cholesterol { get; set; }
        public string HDL_Cholesterol { get; set; }
        public string Triglyceride { get; set; }
        public string LDL_Cholesterol { get; set; }
        public string SGOT { get; set; }
        public string SGPT { get; set; }
        public string Urea { get; set; }
        public string WBC { get; set; }
        public string LYM { get; set; }
        public string MONO { get; set; }
        public string GRAN { get; set; }
        public string TyLeLYM { get; set; }
        public string TyLeMONO { get; set; }
        public string TyLeGRAN { get; set; }
        public string HGB { get; set; }
        public string RBC { get; set; }
        public string HCT { get; set; }
        public string MCV { get; set; }
        public string MCH { get; set; }
        public string MCHC { get; set; }
        public string RDW_CV { get; set; }
        public string PLT { get; set; }
        public string MPV { get; set; }
        public string PDW { get; set; }
        public string PCT { get; set; }
        public string Na { get; set; }
        public string K { get; set; }
        public string Cl { get; set; }
        public string Ca { get; set; }

        public ResultSetDTO() { }

        public ResultSetDTO(string hoTen, string tuoi, int tieuDuong, string gioiTinh,
                          string Cholesterol, string HDL_Cholesterol, string Triglyceride, string LDL_Cholesterol,
                          string SGOT, string SGPT, string Urea, string WBC, string LYM, string MONO,
                          string GRAN, string TyLeLYM, string TyLeMONO, string TyLeGRAN, string HGB, string RBC, string HCT,
                          string MCV, string MCH, string MCHC, string RDW_CV, string PLT, string MPV, string PDW, string PCT,
                          string Na, string K, string Cl, string Ca)
        {
            this.HoTen = hoTen;
            this.Tuoi = tuoi;
            this.TieuDuong = tieuDuong;
            this.GioiTinh = gioiTinh;
            this.Cholesterol = Cholesterol;
            this.HDL_Cholesterol = HDL_Cholesterol;
            this.Triglyceride = Triglyceride;
            this.LDL_Cholesterol = LDL_Cholesterol;
            this.SGOT = SGOT;
            this.SGPT = SGPT;
            this.Urea = Urea;
            this.WBC = WBC;
            this.LYM = LYM;
            this.MONO = MONO;
            this.GRAN = GRAN;
            this.TyLeLYM = TyLeLYM;
            this.TyLeMONO = TyLeMONO;
            this.TyLeGRAN = TyLeGRAN;
            this.HGB = HGB;
            this.RBC = RBC;
            this.HCT = HCT;
            this.MCV = MCV;
            this.MCH = MCH;
            this.MCHC = MCHC;
            this.RDW_CV = RDW_CV;
            this.PLT = PLT;
            this.MPV = MPV;
            this.PDW = PDW;
            this.PCT = PCT;
            this.Na = Na;
            this.K = K;
            this.Cl = Cl;
            this.Ca = Ca;
        }
    }
}
