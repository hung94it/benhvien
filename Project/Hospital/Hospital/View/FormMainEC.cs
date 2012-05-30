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
            searchExamination();
        }

        private void textBoxExaminationSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchExamination();
            }
        }

        private void buttonDeleteExaminationSearch_Click(object sender, EventArgs e)
        {
            textBoxExaminationSearch.Text = "";
            searchExamination();
        }

        private void buttonExaminationDelete_Click(object sender, EventArgs e)
        {
            if (dataViewExamination.SelectedRows.Count > 0)
            {
                int ecID = Convert.ToInt32(dataViewExamination.SelectedRows[0].Cells[0].Value);
                DialogResult dialogResult = MessageBox.Show("Xác nhận xóa phiếu khám bệnh", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    if(ExaminationCertificate.GetEC(ecID).State != 1)
                    {
                        if (ExaminationCertificate.DeleteEC(ecID) > 0)
                            MessageBox.Show("Xóa phiếu khám bệnh thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa phiếu khám bệnh này", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                refreshDataViewExamination();
            }

        }

        private void buttonExaminationEdit_Click(object sender, EventArgs e)
        {
            if (dataViewExamination.SelectedRows.Count > 0)
            {
                int ecID = Convert.ToInt32(dataViewExamination.SelectedRows[0].Cells[0].Value);
                ExaminationCertificate updateEC = ExaminationCertificate.GetEC(ecID);
                FormECDetail formECD = new FormECDetail(updateEC, "edit");
                formECD.ShowDialog();

                refreshDataViewExamination();
            }

        }
        private void buttonUpdateResult_Click(object sender, EventArgs e)
        {
            if (dataViewExamination.SelectedRows.Count > 0)
            {
                int ecID = Convert.ToInt32(dataViewExamination.SelectedRows[0].Cells[0].Value);
                ExaminationCertificate updateEC = ExaminationCertificate.GetEC(ecID);
                //Current user
                int staffID = loginStaff.StaffID;
                FormECDetail formECD = new FormECDetail(updateEC, "updateResult", staffID);
                formECD.ShowDialog();

                refreshDataViewExamination();
            }

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
                examinationTable.Columns.Add("Mã bệnh nhân", typeof(string), "[PATIENTID]");
                examinationTable.Columns.Add("Mã nhân viên", typeof(string), "[STAFFID]");
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
            catch
            {
                MessageBox.Show("Lỗi dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Search in datagridview
        private void searchExamination()
        {
            // Not search it search string is empty
            if (textBoxExaminationSearch.Text != "")
            {
                // Search with RowFilter
                ((DataView)dataViewExamination.DataSource).RowFilter = "[Mã phiếu khám bệnh] LIKE '*" + textBoxExaminationSearch.Text.Trim() + "*'"
                                                                + "OR [Mã bệnh nhân] LIKE '*" + textBoxExaminationSearch.Text.Trim() + "*'"
                                                                + "OR [Mã nhân viên] LIKE '*" + textBoxExaminationSearch.Text.Trim() + "*'"
                                                                + "OR [Trạng thái] LIKE '*" + textBoxExaminationSearch.Text.Trim() + "*'";
            }
            else
            {
                ((DataView)dataViewExamination.DataSource).RowFilter = "";
            }
        }
    }
}
