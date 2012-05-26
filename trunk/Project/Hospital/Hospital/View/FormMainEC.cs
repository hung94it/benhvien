using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hospital.Model;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;


namespace Hospital.View
{
    public partial class FormMain
    {
        // Refresh datagridview when click Examination tab
        private void tabItemExamination_Click(object sender, EventArgs e)
        {
            refreshDataViewExamination();
        }

        private void textBoxExaminationSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxExaminationSearch_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void buttonDeleteExaminationSearch_Click(object sender, EventArgs e)
        {

        }

        private void buttonExaminationDelete_Click(object sender, EventArgs e)
        {

        }

        private void buttonExaminationEdit_Click(object sender, EventArgs e)
        {

        }
        //Refresh datagridview in Examination tab
        private void refreshDataViewExamination()
        {
            try
            {
                // Get Examination's datatable
                DataTable examinationTable = ExaminationCertificate.GetListEC();

                // Add Vietnamese column's name
                examinationTable.Columns.Add("Mã phiếu khám bệnh", typeof(string), "[ECID]");
                examinationTable.Columns.Add("Mã bệnh nhân", typeof(DateTime), "[PATIENTID]");
                examinationTable.Columns.Add("Mã nhân viên", typeof(DateTime), "[STAFFID]");
                examinationTable.Columns.Add("Ngày lập", typeof(DateTime), "[DATE]");
                examinationTable.Columns.Add("Kết quả", typeof(string), "[RESULT]");
                examinationTable.Columns.Add("Trạng thái", typeof(string), "IIF([STATE] = 0, 'Chưa xác nhận', 'Đã xác nhận')");
                // Set data source to dataview for searching
                dataViewExamination.DataSource = examinationTable.DefaultView;

                // Hide English columns'name
                for (int i = 0; i < 6; i++)
                {
                    dataViewExamination.Columns[i].Visible = false;
                }

            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message, "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
