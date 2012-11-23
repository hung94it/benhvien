using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Diabetes.DTO;

namespace Diabetes.DAL
{
    class MedicalTestDAL
    {
        public static List<MedicalTestDTO> SelectAll()
        {
            List<MedicalTestDTO> listMedicalTestDTO = new List<MedicalTestDTO>();

            using (DiabetesEntities entity = new DiabetesEntities())
            {
                var query = from row in entity.XetNghiems
                            select row;
                foreach (var row in query)
                {
                    //Decimal.Parse(
                    MedicalTestDTO medicalTestDTO = new MedicalTestDTO();
                    medicalTestDTO.ID = row.IDXetNghiem;
                    medicalTestDTO.MaBenhNhan = (decimal)row.MaBn;
                    medicalTestDTO.HoTen = row.HoTen;
                    medicalTestDTO.GioiTinh = row.GioiTinh;
                    medicalTestDTO.NgayLayMau = (DateTime)row.NgayLayMau;
                    if (row.Cholesterol.HasValue)
                        medicalTestDTO.Cholesterol = (decimal)row.Cholesterol;
                    if (row.HDL_Cholesterol.HasValue)
                        medicalTestDTO.HDL_Cholesterol = (decimal)row.HDL_Cholesterol;
                    if (row.Triglyceride.HasValue)
                        medicalTestDTO.Triglyceride = (decimal)row.Triglyceride;
                    if (row.LDL_Cholesterol.HasValue)
                        medicalTestDTO.LDL_Cholesterol = (decimal)row.LDL_Cholesterol;
                    if (row.GGT.HasValue)
                        medicalTestDTO.GGT = (decimal)row.GGT;
                    if (row.Glucose.HasValue)
                        medicalTestDTO.Glucose = (decimal)row.Glucose;
                    if (row.SGOT.HasValue)
                        medicalTestDTO.SGOT = (decimal)row.SGOT;
                    if (row.SGPT.HasValue)
                        medicalTestDTO.SGPT = (decimal)row.SGPT;
                    if (row.Urea.HasValue)
                        medicalTestDTO.Urea = (decimal)row.Urea;
                    if (row.WBC.HasValue)
                        medicalTestDTO.WBC = (decimal)row.WBC;
                    if (row.LYM.HasValue)
                        medicalTestDTO.LYM = (decimal)row.LYM;
                    if (row.MONO.HasValue)
                        medicalTestDTO.MONO = (decimal)row.MONO;
                    if (row.GRAN.HasValue)
                        medicalTestDTO.GRAN = (decimal)row.GRAN;
                    if (row.TyLeLYM.HasValue)
                        medicalTestDTO.TyLeLYM = (decimal)row.TyLeLYM;
                    if (row.TyLeMONO.HasValue)
                        medicalTestDTO.TyLeMONO = (decimal)row.TyLeMONO;
                    if (row.TyLeGRAN.HasValue)
                        medicalTestDTO.TyLeGRAN = (decimal)row.TyLeGRAN;
                    if (row.HGB.HasValue)
                        medicalTestDTO.HGB = (decimal)row.HGB;
                    if (row.RBC.HasValue)
                        medicalTestDTO.RBC = (decimal)row.RBC;
                    if (row.HCT.HasValue)
                        medicalTestDTO.HCT = (decimal)row.HCT;
                    if (row.MCV.HasValue)
                        medicalTestDTO.MCV = (decimal)row.MCV;
                    if (row.MCH.HasValue)
                        medicalTestDTO.MCH = (decimal)row.MCH;
                    if (row.MCHC.HasValue)
                        medicalTestDTO.MCHC = (decimal)row.MCHC;
                    if (row.RDW_CV.HasValue)
                        medicalTestDTO.RDW_CV = (decimal)row.RDW_CV;
                    if (row.PLT.HasValue)
                        medicalTestDTO.PLT = (decimal)row.PLT;
                    if (row.MPV.HasValue)
                        medicalTestDTO.MPV = (decimal)row.MPV;
                    if (row.PDW.HasValue)
                        medicalTestDTO.PDW = (decimal)row.PDW;
                    if (row.PCT.HasValue)
                        medicalTestDTO.PCT = (decimal)row.PCT;
                    if (row.Na.HasValue)
                        medicalTestDTO.Na = (decimal)row.Na;
                    if (row.K.HasValue)
                        medicalTestDTO.K = (decimal)row.K;
                    if (row.Cl.HasValue)
                        medicalTestDTO.Cl = (decimal)row.Cl;
                    if (row.Ca.HasValue)
                        medicalTestDTO.Ca = (decimal)row.Ca;

                    listMedicalTestDTO.Add(medicalTestDTO);
                }

            }

            return listMedicalTestDTO;
        }
    }
}
