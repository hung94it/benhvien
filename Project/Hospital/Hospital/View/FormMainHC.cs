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
        // Refresh datagridview when click Hospitalization tab
        private void tabItemHospitalization_Click(object sender, EventArgs e)
        {
            refreshDataViewHC();
        }

        private void textBoxHCSearch_TextChanged(object sender, EventArgs e)
        {
            searchHC();
        }

        private void textBoxHCSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchHC();
            }
        }

        private void buttonDeleteHCSearch_Click(object sender, EventArgs e)
        {
            textBoxHCSearch.Text = "";
            searchHC();
        }

        private void buttonHCConfirm_Click(object sender, EventArgs e)
        {
            if (dataViewHC.SelectedRows.Count > 0)
            {
                int hcID = Convert.ToInt32(dataViewHC.SelectedRows[0].Cells[0].Value);
                int state = Convert.ToInt16(dataViewHC.SelectedRows[0].Cells[5].Value);

                if (state != 1)
                {
                    DialogResult dialogResult = MessageBox.Show("Bạn có muốn xác nhận giấy nhập viện này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes)
                    {
                        HospitalizationCertificate confirmHC = HospitalizationCertificate.GetHC(hcID);
                        Patient updatePatient = Patient.GetPatient(confirmHC.PatientID);
                        updatePatient.State = 1;
                        confirmHC.State = 1;
                        if (HospitalizationCertificate.UpdateHC(confirmHC) > 0 && Patient.UpdatePatient(updatePatient) > 0 )
                            MessageBox.Show("Xác nhận giấy nhập viện thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }

                }
                else
                {
                    MessageBox.Show("Giấy nhập viện đã được xác nhận", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                refreshDataViewHC();
            }

        }

        private void buttonHCDelete_Click(object sender, EventArgs e)
        {
            if (dataViewHC.SelectedRows.Count > 0)
            {
                int hcID = Convert.ToInt32(dataViewHC.SelectedRows[0].Cells[0].Value);
                int state = Convert.ToInt16(dataViewHC.SelectedRows[0].Cells[5].Value);

                if (state != 1)
                {
                    DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa giấy nhập viện này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (HospitalizationCertificate.DeleteHC(hcID) > 0)
                            MessageBox.Show("Xóa giấy nhập viện thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                
                }
                else
                {
                    MessageBox.Show("Không thể xóa giấy nhập viện đã được xác nhận", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                refreshDataViewHC(); 
            }

        }

        private void buttonHCUpdate_Click(object sender, EventArgs e)
        {
            if (dataViewHC.SelectedRows.Count > 0)
            {
                int hcID = Convert.ToInt32(dataViewHC.SelectedRows[0].Cells[0].Value);
                HospitalizationCertificate updateHC = HospitalizationCertificate.GetHC(hcID);
                FormHCDetail formHCD = new FormHCDetail(updateHC, "edit");
                formHCD.ShowDialog();

                refreshDataViewHC();
            }

        }
        //Refresh datagridview in Hospitalization tab
        private void refreshDataViewHC()
        {
            try
            {
                // Get Hospitalization's datatable
                DataTable hcTable = HospitalizationCertificate.GetListHC();

                // Add Vietnamese column's name
                hcTable.Columns.Add("Mã giấy nhập viện", typeof(string), "[HCID]");
                hcTable.Columns.Add("Mã bệnh nhân", typeof(string), "[PATIENTID]");
                hcTable.Columns.Add("Mã nhân viên", typeof(string), "[STAFFID]");
                hcTable.Columns.Add("Ngày lập", typeof(DateTime), "[DATE]");
                hcTable.Columns.Add("Lý do", typeof(string), "[REASON]");
                hcTable.Columns.Add("Trạng thái", typeof(string), "IIF([STATE] = 0, 'Chưa xác nhận', 'Đã xác nhận')");
                // Set data source to dataview for searching
                dataViewHC.DataSource = hcTable.DefaultView;

                // Hide English columns'name
                for (int i = 0; i < 6; i++)
                {
                    dataViewHC.Columns[i].Visible = false;
                }

            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message, "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Search in datagridview
        private void searchHC()
        {
            // Not search it search string is empty
            if (textBoxHCSearch.Text != "")
            {
                // Search with RowFilter
                ((DataView)dataViewHC.DataSource).RowFilter = "[Mã giấy nhập viện] LIKE '*" + textBoxHCSearch.Text.Trim() + "*'"
                                                                + "OR [Mã bệnh nhân] LIKE '*" + textBoxHCSearch.Text.Trim() + "*'"
                                                                + "OR [Mã nhân viên] LIKE '*" + textBoxHCSearch.Text.Trim() + "*'"
                                                                + "OR [Trạng thái] LIKE '*" + textBoxHCSearch.Text.Trim() + "*'";
            }
            else
            {
                ((DataView)dataViewHC.DataSource).RowFilter = "";
            }
        }
    }
}
