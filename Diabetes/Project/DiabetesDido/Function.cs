using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DiabetesDido
{
    public class Function
    {
        public void LamSachDuLieu(DataTable dataSetDT,List<decimal> danhSachViTri)
        {
            for (int i = 0; i < dataSetDT.Rows.Count-1; i++)
            {
                int Flag=0;
                for (int j = 0; j < danhSachViTri.Count; j++)
                {
                    decimal iD=Convert.ToDecimal(dataSetDT.Rows[i][0]);
                    if ( iD == danhSachViTri[j])
                    {
                        Flag = 1;
                        break;
                    }
                }
                if (Flag == 0)
                {
                    for (int j = i + 1; j < dataSetDT.Rows.Count; j++)
                    {
                        decimal iMaBN = Convert.ToDecimal(dataSetDT.Rows[i][1]);
                        decimal jMaBN = Convert.ToDecimal(dataSetDT.Rows[j][1]);
                        if (iMaBN == jMaBN)
                            danhSachViTri.Add(Convert.ToDecimal(dataSetDT.Rows[j][0]));
                        else
                            break;
                    }
                }
            }
        }
        public void RoiRacHoaTuoi(decimal namSinh, String doTuoi)
        {
            if (namSinh < 10)
                doTuoi = "<10";
            else if (namSinh < 20)
                doTuoi = "10_20";
            else if (namSinh < 30)
                doTuoi = "20_30";
            else if (namSinh < 40)
                doTuoi = "30_40";
            else if (namSinh < 50)
                doTuoi = "40_50";
            else if (namSinh < 60)
                doTuoi = "50_60";
            else if (namSinh < 70)
                doTuoi = "60_70";
            else if (namSinh < 80)
                doTuoi = "70_80";
            else
                doTuoi = "80>";
        }
        
    }
}
