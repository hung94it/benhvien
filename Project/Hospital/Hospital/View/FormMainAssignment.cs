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
        // Refresh datagridview when click assignment tab
        private void tabItemAssignment_Click(object sender, EventArgs e)
        {
            refreshDataViewAssignment();
            refreshDataViewAssignmentDetail();
        }

        private void textBoxAssignmentSearch_TextChanged(object sender, EventArgs e)
        {
            searchAsssignment();
        }

        private void textBoxAssignmentSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchAsssignment();
            }
        }

        private void buttondDeleteAssignmentSearch_Click(object sender, EventArgs e)
        {
            textBoxAssignmentSearch.Text = "";
            searchAsssignment();
        }

        private void dataViewAssignment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataViewAssignment.SelectedRows.Count > 0)
            {
                int assignID = Convert.ToInt32(dataViewAssignment.SelectedRows[0].Cells[0].Value);
                DataTable dtAD = AssignmentDetail.GetListAssignmentDetails(assignID);

                dataViewAsssignmentDetail.DataSource = dtAD.DefaultView;
            }  
        }

        private void buttonAssignmentDelete_Click(object sender, EventArgs e)
        {
            if (dataViewAssignment.SelectedRows.Count > 0)
            {
                int assignID = Convert.ToInt32(dataViewAssignment.SelectedRows[0].Cells[0].Value);
                DialogResult dialogResult = MessageBox.Show("Xác nhận xóa bản phân công", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        if (AssignmentDetail.DeleteAssignmentDetails(assignID) > 0 && Assignment.DeleteAssignment(assignID) > 0)
                            MessageBox.Show("Xóa bảng phân công thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Lỗi dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                refreshDataViewAssignment();
                refreshDataViewAssignmentDetail();
            }
            
        }

        private void buttonAssignmentEdit_Click(object sender, EventArgs e)
        {
            if (dataViewAssignment.SelectedRows.Count > 0)
            { 
                int assignID = Convert.ToInt32(dataViewAssignment.SelectedRows[0].Cells[0].Value);
                Assignment updateAssign = Assignment.GetAssignment(assignID);

                FormAssignDetail formAD = new FormAssignDetail(updateAssign, "edit");
                formAD.ShowDialog();
                refreshDataViewAssignment();
                refreshDataViewAssignmentDetail();
            }
            
        }
        //Refresh datagridview in assignment tab
        private void refreshDataViewAssignment()
        {
            try
            {
                // Get assignment's datatable
                DataTable assignmentTable = Assignment.GetListAssignment();

                // Add Vietnamese column's name
                assignmentTable.Columns.Add("Mã phân công", typeof(string), "[ASSIGNID]");
                assignmentTable.Columns.Add("Mã bệnh nhân", typeof(string), "[PATIENTID]");
                assignmentTable.Columns.Add("Ngày lập", typeof(DateTime), "[DATE]");
                assignmentTable.Columns.Add("Ngày nhập viện", typeof(DateTime), "[HOPITALIZATEDATE]");
                assignmentTable.Columns.Add("Ngày xuât viện", typeof(DateTime), "[DISCHARGEDDATE]");
                // Set data source to dataview for searching
                dataViewAssignment.DataSource = assignmentTable.DefaultView;

                // Hide English columns'name
                for (int i = 0; i < 5; i++)
                {
                    dataViewAssignment.Columns[i].Visible = false;
                }
            }
            catch
            {
                MessageBox.Show("Lỗi dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void refreshDataViewAssignmentDetail()
        {
            if (dataViewAssignment.SelectedRows.Count > 0)
            {
                try
                {
                    // Get AssignmentDetail's datatable
                    int assignmentID = Convert.ToInt32(dataViewAssignment.Rows[0].Cells[0].Value);
                    DataTable assignmentDetailTable = AssignmentDetail.GetListAssignmentDetails(assignmentID);
                    // Set data source to dataview for searching
                    dataViewAsssignmentDetail.DataSource = assignmentDetailTable.DefaultView;
                }
                catch
                {
                    MessageBox.Show("Lỗi dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } 
            }
        }
        private void searchAsssignment()
        {
            // Not search it search string is empty
            if (textBoxAssignmentSearch.Text != "")
            {
                // Search with RowFilter
                ((DataView)dataViewAssignment.DataSource).RowFilter = "[Mã phân công] LIKE '*" + textBoxAssignmentSearch.Text.Trim() + "*'"
                                                                + "OR [Mã bệnh nhân] LIKE '*" + textBoxAssignmentSearch.Text.Trim() + "*'";
                refreshDataViewAssignmentDetail();
            }
            else
            {
                ((DataView)dataViewAssignment.DataSource).RowFilter = "";
            }
        }
    }
}
