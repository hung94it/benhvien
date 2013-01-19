using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DiabetesDido.DAL;

namespace DiabetesDido
{
    public partial class TestForm : Form
    {
        Function function = new Function();
        static DAL.DiabetesDataSetTableAdapters.DataSetTableAdapter datasetTA = new DAL.DiabetesDataSetTableAdapters.DataSetTableAdapter();
        static DAL.DiabetesDataSetTableAdapters.DataSetTempTableAdapter datasetTempTA = new DAL.DiabetesDataSetTableAdapters.DataSetTempTableAdapter();
        static DAL.DiabetesDataSetTableAdapters.BayesObjectTableAdapter bayesObjectTA = new DAL.DiabetesDataSetTableAdapters.BayesObjectTableAdapter();
        public TestForm()
        {
            InitializeComponent();
        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            DataTable dtDataSet = datasetTA.GetData();
            DataTable dt = datasetTA.GetData();
            dt.Clear();

            for (int i = 0; i < dtDataSet.Rows.Count-10; i++)
            {
                dtDataSet.Rows[i].Delete();
            }
            dtDataSet.AcceptChanges();
            int j = dtDataSet.Rows.Count;
            dtViewDataSet.DataSource = dtDataSet;
            dtViewDataSetTemp.DataSource = DataDiscretization(dtDataSet);
        }
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
                    int colIndex=dt.Columns.IndexOf(colName);
                    switch(colName)
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
