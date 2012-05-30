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
        private void tabItemDischarged_Click(object sender, EventArgs e)
        {
            refreshDataViewDC();
        }

        private void textBoxDCSearch_TextChanged(object sender, EventArgs e)
        {
            searchDC();
        }

        private void textBoxDCSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchDC();
            }
        }

        private void buttonDeleteDCSearch_Click(object sender, EventArgs e)
        {
            textBoxDCSearch.Text = "";
            searchDC();
        }

        private void buttonDCConfirm_Click(object sender, EventArgs e)
        {
            if (dataViewDC.SelectedRows.Count > 0)
            { 
                int dcID = Convert.ToInt32(dataViewDC.SelectedRows[0].Cells[0].Value);
                int state = Convert.ToInt16(dataViewDC.SelectedRows[0].Cells[4].Value);

                if (state != 1)
                {
                    DialogResult dialogResult = MessageBox.Show("Xác nhận giấy xuất viện", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes)
                    {
                        DischargeCertificate confirmDC = DischargeCertificate.GetDC(dcID);
                        Patient updatePatient = Patient.GetPatient(confirmDC.PatientID);
                        updatePatient.State = 0;
                        confirmDC.State = 1;
                        if (DischargeCertificate.UpdateDC(confirmDC) > 0 && Patient.UpdatePatient(updatePatient) > 0 )
                            MessageBox.Show("Xác nhận giấy xuất viện thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    MessageBox.Show("Giấy xuất viện đã được xác nhận", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                refreshDataViewDC();
            }
            
        }

        private void buttonDCDelete_Click(object sender, EventArgs e)
        {
            if (dataViewDC.SelectedRows.Count > 0)
            {
                int dcID = Convert.ToInt32(dataViewDC.SelectedRows[0].Cells[0].Value);
                int state = Convert.ToInt16(dataViewDC.SelectedRows[0].Cells[4].Value);

                if (state != 1)
                {
                    DialogResult dialogResult = MessageBox.Show("Xác nhận xóa giấy xuất viện", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (DischargeCertificate.DeleteDC(dcID) > 0)
                            MessageBox.Show("Xóa giấy xuất viện thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    MessageBox.Show("Không thể xóa giấy xuất viện đã được xác nhận", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                refreshDataViewDC();
            }
 
        }

        private void buttonDCUpdate_Click(object sender, EventArgs e)
        {
            if (dataViewDC.SelectedRows.Count > 0)
            {
                int dcID = Convert.ToInt32(dataViewDC.SelectedRows[0].Cells[0].Value);
                DischargeCertificate updateDC = DischargeCertificate.GetDC(dcID);
                FormDCDetail formDCD = new FormDCDetail(updateDC, "edit");
                formDCD.ShowDialog();

                refreshDataViewDC();
            }

        }
        //Refresh datagridview in Discharge tab
        private void refreshDataViewDC()
        {
            try
            {
                // Get Discharge's datatable
                DataTable dcTable = DischargeCertificate.GetListDC();

                // Add Vietnamese column's name
                dcTable.Columns.Add("Mã giấy xuất viện", typeof(string), "[DCID]");
                dcTable.Columns.Add("Mã bệnh nhân", typeof(string), "[PATIENTID]");
                dcTable.Columns.Add("Mã nhân viên", typeof(string), "[STAFFID]");
                dcTable.Columns.Add("Ngày lập", typeof(DateTime), "[DATE]");
                dcTable.Columns.Add("Trạng thái", typeof(string), "IIF([STATE] = 0, 'Chưa xác nhận', 'Đã xác nhận')");
                // Set data source to dataview for searching
                dataViewDC.DataSource = dcTable.DefaultView;

                // Hide English columns'name
                for (int i = 0; i < 5; i++)
                {
                    dataViewDC.Columns[i].Visible = false;
                }

            }
            catch
            {
                MessageBox.Show("Lỗi dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Search in datagridview
        private void searchDC()
        {
            // Not search it search string is empty
            if (textBoxDCSearch.Text != "")
            {
                // Search with RowFilter
                ((DataView)dataViewDC.DataSource).RowFilter = "[Mã giấy xuất viện] LIKE '*" + textBoxDCSearch.Text.Trim() + "*'"
                                                                + "OR [Mã bệnh nhân] LIKE '*" + textBoxDCSearch.Text.Trim() + "*'"
                                                                + "OR [Mã nhân viên] LIKE '*" + textBoxDCSearch.Text.Trim() + "*'"
                                                                + "OR [Trạng thái] LIKE '*" + textBoxDCSearch.Text.Trim() + "*'";
            }
            else
            {
                ((DataView)dataViewDC.DataSource).RowFilter = "";
            }
        }
    }
}
