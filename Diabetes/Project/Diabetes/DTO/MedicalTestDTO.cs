using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Diabetes.DTO
{
    class MedicalTestDTO
    {
        public Int64 ID { get; set; }
        public decimal MaBenhNhan { get; set; }
        public string HoTen { get; set; }
        public string GioiTinh { get; set; }
        public DateTime NgayLayMau { get; set; }
        public decimal Cholesterol { get; set; }
        public decimal HDL_Cholesterol { get; set; }
        public decimal Triglyceride { get; set; }
        public decimal LDL_Cholesterol { get; set; }
        public decimal GGT { get; set; }
        public decimal Glucose { get; set; }
        public decimal SGOT { get; set; }
        public decimal SGPT { get; set; }
        public decimal Urea { get; set; }
        public decimal WBC { get; set; }
        public decimal LYM { get; set; }
        public decimal MONO { get; set; }
        public decimal GRAN { get; set; }
        public decimal TyLeLYM { get; set; }
        public decimal TyLeMONO { get; set; }
        public decimal TyLeGRAN { get; set; }
        public decimal HGB { get; set; }
        public decimal RBC { get; set; }
        public decimal HCT { get; set; }
        public decimal MCV { get; set; }
        public decimal MCH { get; set; }
        public decimal MCHC { get; set; }
        public decimal RDW_CV { get; set; }
        public decimal PLT { get; set; }
        public decimal MPV { get; set; }
        public decimal PDW { get; set; }
        public decimal PCT { get; set; }
        public decimal Na { get; set; }
        public decimal K { get; set; }
        public decimal Cl { get; set; }
        public decimal Ca { get; set; }

        public MedicalTestDTO() {}

        public MedicalTestDTO(Int64 ID, decimal MaBenhNhan, string HoTen, string GioiTinh, DateTime NgayLayMau,
                           decimal Cholesterol, decimal HDL_Cholesterol, decimal Triglyceride, decimal LDL_Cholesterol, decimal GGT,
                           decimal Glucose, decimal SGOT, decimal SGPT, decimal Urea, decimal WBC, decimal LYM, decimal MONO,
                           decimal GRAN, decimal TyLeLYM, decimal TyLeMONO, decimal TyLeGRAN, decimal HGB, decimal RBC, decimal HCT,
                           decimal MCV, decimal MCH, decimal MCHC, decimal RDW_CV, decimal PLT, decimal MPV, decimal PDW, decimal PCT,
                           decimal Na, decimal K, decimal Cl, decimal Ca)
        {
            this.ID = ID;
            this.MaBenhNhan = MaBenhNhan;
            this.HoTen = HoTen;
            this.GioiTinh = GioiTinh;
            this.NgayLayMau = NgayLayMau;
            this.Cholesterol = Cholesterol;
            this.HDL_Cholesterol = HDL_Cholesterol;
            this.Triglyceride = Triglyceride;
            this.LDL_Cholesterol = LDL_Cholesterol;
            this.GGT = GGT;
            this.Glucose = Glucose;
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
