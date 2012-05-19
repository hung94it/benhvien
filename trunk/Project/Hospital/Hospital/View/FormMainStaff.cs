using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Hospital.Model;

namespace Hospital.View
{
    public partial class FormMain
    {
        // Refresh datagridview when click staff tab
        private void tabItemStaff_Click(object sender, EventArgs e)
        {
            refreshDataViewStaff();
        }

        // Add new staff when click add button
        private void buttonStaffAdd_Click(object sender, EventArgs e)
        {
            // Open staffdetail form for add
            FormStaffDetail staffDetailForm = new FormStaffDetail("add", new Staff());
            staffDetailForm.ShowDialog();

            // Refresh datagridview after add
            refreshDataViewStaff();
        }

        // Edit staff's information when click edit button
        private void buttonStaffEdit_Click(object sender, EventArgs e)
        {
            // Get staff for edit
            Staff StaffDetail = Staff.GetStaff(Convert.ToInt32(dataViewStaff.SelectedRows[0].Cells[0].Value.ToString()));

            // Open staffdetail form for edit
            FormStaffDetail staffDetailForm = new FormStaffDetail("edit", StaffDetail);
            staffDetailForm.ShowDialog();

            // Refresh datagridview after edit
            refreshDataViewStaff();
        }

        // Delete staff when click delete button
        private void buttonStaffDelete_Click(object sender, EventArgs e)
        {
            int staffID;

            try
            {
                // Warning before delete
                if (MessageBox.Show("Bạn có muốn xóa nhân viên này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                    == DialogResult.Yes)
                {
                    // Get staffid for delete
                    if (int.TryParse(dataViewStaff.SelectedRows[0].Cells[0].Value.ToString(), out staffID))
                    {
                        Staff.DeleteStaff(staffID);
                    }
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message, "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Refresh datagridview after delete
            refreshDataViewStaff();
        }

        // Reset search when click searchdelete button
        private void buttonStaffDeleteSearch_Click(object sender, EventArgs e)
        {
            textBoxStaffSearch.Text = "";
            searchStaff();
        }

        // Search when press key enter
        private void textBoxStaffSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchStaff();
            }            
        }

        // Search when text changed
        private void textBoxStaffSearch_TextChanged(object sender, EventArgs e)
        {
            searchStaff();
        }

        //Search in datagridview
        private void searchStaff()
        {
            // Not search it search string is empty
            if ("".Equals(textBoxStaffSearch.Text))
            {
                // Search with RowFilter
                ((DataView)dataViewStaff.DataSource).RowFilter = "[Họ tên] LIKE '*" + textBoxStaffSearch.Text.Trim() + "*'"
                                                                + "OR [Mã nhân viên] LIKE '*" + textBoxStaffSearch.Text.Trim() + "*'"
                                                                + "OR [CMND] LIKE '*" + textBoxStaffSearch.Text.Trim() + "*'";
            }
            else
                ((DataView)dataViewStaff.DataSource).RowFilter = "";
        }

        //Refresh datagridview in Staff tab
        private void refreshDataViewStaff()
        {
            try
            {
                // Get Staff's datatable
                DataTable staffTable = Staff.GetListStaff();

                // Add Vietnamese column's name
                staffTable.Columns.Add("Mã nhân viên", typeof(string), "[STAFFID]");
                staffTable.Columns.Add("Họ tên", typeof(string), "[LASTNAME] + ' ' + [FIRSTNAME]");
                staffTable.Columns.Add("Khoa", typeof(string), "[DEPARTMENTNAME]");
                staffTable.Columns.Add("Chuyên ngành", typeof(string), "[MAJORNAME]");
                staffTable.Columns.Add("CMND", typeof(string), "[ICN]");
                staffTable.Columns.Add("Giới tính", typeof(string), "IIF([GENDER] = 0, 'Nam', 'Nữ')");
                staffTable.Columns.Add("Ngày sinh", typeof(DateTime), "[BIRTHDAY]");
                staffTable.Columns.Add("Địa chỉ", typeof(string), "[ADDRESS]");
                //staffTable.Columns.Add("Trạng thái", typeof(string), "[STATE]");

                // Set data source to dataview for searching
                dataViewStaff.DataSource = staffTable.DefaultView;

                // Hide English columns'name
                for (int i = 0; i < 12; i++)
                {
                    dataViewStaff.Columns[i].Visible = false;
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message, "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
