using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DiabetesDido.DAL.DiabetesDataSetBTableAdapters;
using DiabetesDido.ClassificationLogic;
using Accord.Math;

namespace DiabetesDido.UI
{
    public partial class FormMain
    {

        Function function = new Function();
        static DAL.DiabetesDataSetTableAdapters.DataSetTableAdapter datasetTA = new DAL.DiabetesDataSetTableAdapters.DataSetTableAdapter();
        static DAL.DiabetesDataSetTableAdapters.DataSetTempTableAdapter datasetTempTA = new DAL.DiabetesDataSetTableAdapters.DataSetTempTableAdapter();
        static DAL.DiabetesDataSetTableAdapters.BayesObjectTableAdapter bayesObjectTA = new DAL.DiabetesDataSetTableAdapters.BayesObjectTableAdapter();

        public void InitializeTabDiagnosis()
        {
            this.dataGridViewXDiagnosis.DataSource = this.trainningDataTableAdapter.GetData();
        }

        private void buttonXDiagnosis_Click(object sender, EventArgs e)
        {
            TrainningData trainningData = new TrainningData(this.dataGridViewXDiagnosis.DataSource as DataTable);

            int[,] result = new int[trainningData.TrainningAttributes.GetLength(0), 0];

            foreach (var model in this.modelList)
            {
                //int[] temp = model.Value.ComputeModel(trainningData.TrainningAttributes);
                //result = result.InsertColumn<int>(temp);
                result = result.InsertColumn<int>(model.Value.ComputeModel(trainningData.TrainningAttributes));
            }

            

            this.dataGridViewXDiagnosisResult.DataSource = result.ToDouble().ToTable();
        }

        //Hàm dùng để rời rác hóa dataset trước khi thực hiện chẩn đoán
        public DataTable DataDiscretization(DataTable dt)
        {
            DataTable dtDataSetTemp = datasetTempTA.GetData();
            dtDataSetTemp.Clear();
            DataTable dtBayesObject = bayesObjectTA.GetData();
            int Count = 1;
            foreach (DataRow dtRow in dt.Rows)
            {
                DataRow newRow = dtDataSetTemp.NewRow();
                newRow[0] = Count;
                foreach (DataColumn dtCol in dt.Columns)
                {
                    String colName = dtCol.ColumnName;
                    int colIndex = dt.Columns.IndexOf(colName);
                    switch (colName)
                    {
                        case "ID":
                            break;
                        case "MaBn":
                            newRow[colName] = dtRow[colName].ToString();
                            break;
                        case "NgayKham":
                            break;
                        case "HoTen":
                            break;
                        case "TieuDuong":
                            newRow[colName] = Convert.ToBoolean(dtRow[colName]);
                            break;
                        case "GioiTinh":
                            newRow[colName] = dtRow[colName].ToString();
                            break;
                        case "NamSinh":
                            int namSinh = Convert.ToInt16(dtRow[colName]);
                            int tuoiHienTai = DateTime.Now.Year - namSinh;
                            String Tuoi = function.RoiRacHoaTuoi(tuoiHienTai);
                            newRow["Tuoi"] = Tuoi;
                            break;
                        default:
                            decimal colValue = Convert.ToDecimal(dtRow[colName]);
                            int khoang = Function.XacDinhKhoang(colName);
                            String giaTriRoiRac = Function.DataDiscretization(colValue, colName, khoang);
                            newRow[colName] = giaTriRoiRac;
                            break;
                    }
                }
                Count++;
                dtDataSetTemp.Rows.Add(newRow);
            }
            return dtDataSetTemp;
        }
    }
}
