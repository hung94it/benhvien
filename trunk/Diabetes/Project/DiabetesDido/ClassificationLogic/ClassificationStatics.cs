using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DiabetesDido.ClassificationLogic
{
    class ClassificationStatics
    {
        //Hàm dùng để tính phương sai của một cột
        public static decimal TinhDoLechChuan(DataTable dt, String colName)
        {
            Double phuongSai = 0;
            Double doLechChuan = 0;
            Double tienPhuongSai = 0;
            Double soLuongDuLieu = Convert.ToDouble(dt.Compute("count(" + colName + ")", string.Empty));
            Double giaTriTrungTinh = Convert.ToDouble(dt.Compute("avg(" + colName + ")", string.Empty));
            giaTriTrungTinh = Math.Round(giaTriTrungTinh, 3);
            int colIndex = dt.Columns.IndexOf(colName);
            foreach (DataRow dtRow in dt.Rows)
            {
                tienPhuongSai = tienPhuongSai + Math.Round(Math.Pow((Convert.ToDouble(dtRow[colIndex]) - giaTriTrungTinh), 2), 3);
            }
            phuongSai = tienPhuongSai / (soLuongDuLieu - 1);
            doLechChuan = Math.Round(Math.Sqrt(phuongSai), 2);
            return Convert.ToDecimal(doLechChuan);
        }
        //Hàm dùng để tính độ bao phủ Recall (Độ nhạy Sensitivity)
        public static decimal Recall(int truePossive, int falseNegative)
        {
            decimal iRecall = 1;
            decimal iTruePossive = Convert.ToDecimal(truePossive);
            decimal iFalseNegative = Convert.ToDecimal(falseNegative);
            iRecall = iTruePossive / (iTruePossive + iFalseNegative);
            iRecall = Math.Round(iRecall, 3);
            return iRecall;
        }
        //Hàm  dùng để tính độ chính xác Precision
        public static decimal Precision(int truePossive, int falsePossive)
        {
            decimal iPrecision = 1;
            decimal iTruePossive = Convert.ToDecimal(truePossive);
            decimal iFalsePossive = Convert.ToDecimal(falsePossive);
            iPrecision = iTruePossive / (iTruePossive + iFalsePossive);
            iPrecision = Math.Round(iPrecision, 3);
            return iPrecision;
        }
        //Hàm dùng để tính độ chính xác Accuracy
        public static decimal Accuracy(int truePossive, int trueNegative, int falsePossive, int falseNegative)
        {
            decimal iAccuracy = 1;
            decimal iTruePossive = Convert.ToDecimal(truePossive);
            decimal iFalseNegative = Convert.ToDecimal(falseNegative);
            decimal iTrueNegative = Convert.ToDecimal(trueNegative);
            decimal iFalsePossive = Convert.ToDecimal(falsePossive);
            iAccuracy = (iTrueNegative + iTruePossive) / (iTruePossive + iTrueNegative + iFalseNegative + iFalsePossive);
            iAccuracy = Math.Round(iAccuracy, 3);
            return iAccuracy;
        }
        //Hàm dùng để tính độ đó F1
        public static decimal F1(decimal iRecall, decimal iPrecision)
        {
            decimal iF1 = 0;
            iF1 = 2 * iPrecision * iRecall / (iRecall + iPrecision);
            iF1 = Math.Round(iF1, 3);
            return iF1;
        }
        //Hàm dùng để trả về các thông số dùng để đánh giá một giải thuật máy học gồm: true possive, false possive, true negative, false negative
        public static Dictionary<String, int> TinhThongSo(DataTable dtTest, DataTable dtResult)
        {
            Dictionary<String, int> iDictionary = new Dictionary<string, int>();
            int iTruePossive = 0;
            int iFalsePossive = 0;
            int iTrueNegative = 0;
            int iFalseNegative = 0;
            int iCount = dtTest.Columns.Count;
            for (int i = 0; i < dtTest.Rows.Count; i++)
            {
                //2 biến dùng để chứa cột "TieuDuong" của table
                String iTest = dtTest.Rows[i][iCount - 1].ToString();
                String iResult = dtResult.Rows[i][iCount - 1].ToString();
                switch (iResult)
                {
                    case "Yes":
                        {
                            if (iTest == "Yes")
                                iTruePossive++;
                            else
                                iFalseNegative++;
                            break;
                        }
                    case "No":
                        {
                            if (iTest == "Yes")
                                iFalsePossive++;
                            else
                                iTrueNegative++;
                            break;
                        }
                }
            }
            iDictionary.Add("TruePossive", iTruePossive);
            iDictionary.Add("FalseNegative", iFalseNegative);
            iDictionary.Add("TrueNegative", iTrueNegative);
            iDictionary.Add("FalsePossive", iFalsePossive);
            return iDictionary;
        }
    }
}
