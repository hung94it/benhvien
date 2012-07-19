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
        // Refresh datagridview when click surgical tab
        private void tabItemSurgery_Click(object sender, EventArgs e)
        {
            refreshDataViewSurgical();
            refreshDataViewSurgicalDetail();
        }
        // Refresh datagridview when click a cell
        private void dataViewSurgical_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataViewSurgical.SelectedRows.Count > 0)
            {
                // Get SurgicalnDetail's datatable
                int surgicalID = Convert.ToInt32(dataViewSurgical.SelectedRows[0].Cells[0].Value);
                DataTable surgicalDetailTable = SurgicalDetail.GetListSurgicalDetail(surgicalID);

                // Set data source to dataview for searching
                dataViewSurgicalDetail.DataSource = surgicalDetailTable;
            }

        }

        private void textBoxSurgicalSearch_TextChanged(object sender, EventArgs e)
        {
            searchSurgical();
        }

        private void textBoxSurgicalSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchSurgical();
            }
        }

        private void buttonDeleteSurgicalSearch_Click(object sender, EventArgs e)
        {
            textBoxSurgicalSearch.Text = "";
            searchSurgical();
        }

        private void buttonSurgeryDelete_Click(object sender, EventArgs e)
        {
            if (dataViewSurgical.SelectedRows.Count > 0)
            { 
                int surgicalID = Convert.ToInt32(dataViewSurgical.SelectedRows[0].Cells[0].Value);
                Surgical deleteSurgical = Surgical.GetSurgical(surgicalID);
                if (deleteSurgical.State != 1)
                {
                    DialogResult dialogResult = MessageBox.Show("Xác nhận xóa ca phẩu thuật", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes)
                    {
                        try
                        {
                            if (SurgicalDetail.DeleteSurgicalDetail(surgicalID) > 0 && Surgical.DeleteSurgical(surgicalID) > 0)
                                MessageBox.Show("Xóa ca phẩu thuật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch
                        {
                            MessageBox.Show("Lỗi dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Không thể xóa ca phẩu thuật đã được thực hiện", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                refreshDataViewSurgical();
                refreshDataViewSurgicalDetail();
            }
            
        }

        private void dataViewSurgical_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataViewSurgical.SelectedRows.Count > 0)
            {
                int surgicalID = Convert.ToInt32(dataViewSurgical.SelectedRows[0].Cells[0].Value);
                Surgical updateSurgical = Surgical.GetSurgical(surgicalID);
                FormSurgicalDetail formSD = new FormSurgicalDetail(updateSurgical, "edit");
                formSD.ShowDialog();

                refreshDataViewSurgical();
                refreshDataViewSurgicalDetail();
            }
        }

        private void buttonSurgeryEdit_Click(object sender, EventArgs e)
        {
            if (dataViewSurgical.SelectedRows.Count > 0)
            { 
                int surgicalID = Convert.ToInt32(dataViewSurgical.SelectedRows[0].Cells[0].Value);
                Surgical updateSurgical = Surgical.GetSurgical(surgicalID);
                FormSurgicalDetail formSD = new FormSurgicalDetail(updateSurgical, "edit");
                formSD.ShowDialog();
 
                refreshDataViewSurgical();
                refreshDataViewSurgicalDetail();
            }

        }
        //Refresh datagridview in surgical tab
        private void refreshDataViewSurgical()
        {
            try
            {
                // Get surgical's datatable
                DataTable surgicalTable = Surgical.GetListSurgical();

                // Add Vietnamese column's name
                surgicalTable.Columns.Add("Mã ca phẩu thuật", typeof(string), "[SURGICALID]");
                surgicalTable.Columns.Add("Mã bệnh nhân", typeof(string), "[PATIENTID]");
                surgicalTable.Columns.Add("Ngày thực hiện", typeof(DateTime), "[DATE]");
                surgicalTable.Columns.Add("Mô tả", typeof(string), "[DESCRIPTION]");
                surgicalTable.Columns.Add("Trạng thái", typeof(string), "IIF([STATE] = 0, 'Chưa thực hiện', 'Đã thực hiện')");
                // Set data source to dataview for searching
                dataViewSurgical.DataSource = surgicalTable.DefaultView;

                // Hide English columns'name
                for (int i = 0; i < 5; i++)
                {
                    dataViewSurgical.Columns[i].Visible = false;
                }
            }
            catch
            {
                MessageBox.Show("Lỗi dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void refreshDataViewSurgicalDetail()
        {
            if (dataViewSurgical.SelectedRows.Count>0)
            {
                try
                {
                    // Get SurgicalDetail's datatable
                    int surgicalID = Convert.ToInt32(dataViewSurgical.Rows[0].Cells[0].Value);
                    DataTable surgicalDetailTable = SurgicalDetail.GetListSurgicalDetail(surgicalID);
                    // Set data source to dataview for searching
                    dataViewSurgicalDetail.DataSource = surgicalDetailTable.DefaultView;
                }
                catch
                {
                    MessageBox.Show("Lỗi dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } 
            }
        }
        private void searchSurgical()
        {
            // Not search it search string is empty
            if (textBoxSurgicalSearch.Text != "")
            {
                // Search with RowFilter
                ((DataView)dataViewSurgical.DataSource).RowFilter = "[Mã ca phẩu thuật] LIKE '*" + textBoxSurgicalSearch.Text.Trim() + "*'"
                                                                + "OR [Mã bệnh nhân] LIKE '*" + textBoxSurgicalSearch.Text.Trim() + "*'"
                                                                + "OR [Trạng thái] LIKE '*" + textBoxSurgicalSearch.Text.Trim() + "*'";
                refreshDataViewSurgicalDetail();
            }
            else
            {
                ((DataView)dataViewSurgical.DataSource).RowFilter = "";
            }
        }
    }
}
