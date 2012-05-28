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
        // Refresh datagridview when click nonitor tab
        private void tabItemMonitor_Click(object sender, EventArgs e)
        {
            refreshDataViewHeathNote();
        }

        private void textBoxHeathNoteSearch_TextChanged(object sender, EventArgs e)
        {
            searchHeathNote();
        }

        private void textBoxHeathNoteSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchHeathNote();
            }
        }

        private void buttonDeleteHeathNoteSearch_Click(object sender, EventArgs e)
        {
            textBoxHeathNoteSearch.Text = "";
            searchHeathNote();
        }

        private void buttonMonitorDelete_Click(object sender, EventArgs e)
        {
            if (dataViewHeathNote.SelectedRows.Count > 0)
            {
                int heathNoteID = Convert.ToInt32(dataViewHeathNote.SelectedRows[0].Cells[0].Value);
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa phiếu theo dõi này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        if (HeathMonitoringNote.DeleteHN(heathNoteID) > 0)
                            MessageBox.Show("Xóa phiếu theo dõi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                    catch
                    {
                        MessageBox.Show("Không xóa phiếu theo dõi này", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                refreshDataViewHeathNote();
            }

        }

        private void buttonMonitorEdit_Click(object sender, EventArgs e)
        {
            if (dataViewHeathNote.SelectedRows.Count > 0)
            {
                int heathNoteID = Convert.ToInt32(dataViewHeathNote.SelectedRows[0].Cells[0].Value);
                FormHNDetail formHNDetail = new FormHNDetail(HeathMonitoringNote.GetHN(heathNoteID), "edit");
                formHNDetail.ShowDialog();

                refreshDataViewHeathNote();
            }

        }
        
        //Refresh datagridview in monitor tab
        private void refreshDataViewHeathNote()
        {
            try
            {
                // Get heath note's datatable
                DataTable heathNoteTable = HeathMonitoringNote.GetListHN();

                // Add Vietnamese column's name
                heathNoteTable.Columns.Add("Mã phiếu theo dõi", typeof(string), "[HNID]");
                heathNoteTable.Columns.Add("Mã bệnh nhân", typeof(string), "[PATIENTID]");
                heathNoteTable.Columns.Add("Mã nhân viên", typeof(string), "[STAFFID]");
                heathNoteTable.Columns.Add("Ngày lập", typeof(DateTime), "[DATE]");
                heathNoteTable.Columns.Add("Cân nặng", typeof(string), "[WEIGHT]");
                heathNoteTable.Columns.Add("Huyết áp", typeof(string), "[BLOODPRESSURE]");
                heathNoteTable.Columns.Add("Tình trạng bệnh nhân", typeof(string), "[PATIENTSTATE]");
                // Set data source to dataview for searching
                dataViewHeathNote.DataSource = heathNoteTable.DefaultView;

                // Hide English columns'name
                for (int i = 0; i < 7; i++)
                {
                    dataViewHeathNote.Columns[i].Visible = false;
                }              
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message, "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Search in datagridview
        private void searchHeathNote()
        {
            // Not search it search string is empty
            if (textBoxHeathNoteSearch.Text != "")
            {
                // Search with RowFilter
                ((DataView)dataViewHeathNote.DataSource).RowFilter = "[Mã bệnh nhân] LIKE '*" + textBoxHeathNoteSearch.Text.Trim() + "*'"
                                                                + "OR [Mã phiếu theo dõi] LIKE '*" + textBoxHeathNoteSearch.Text.Trim() + "*'";
            }
            else
            {
                ((DataView)dataViewHeathNote.DataSource).RowFilter = "";
            }
        }
    }
}
