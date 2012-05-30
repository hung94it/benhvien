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
        // Refresh datagridview when click role tab
        private void tabItemRole_Click(object sender, EventArgs e)
        {
            refreshDataViewRole();
            refreshDataViewRoleDetail();
        }
        private void buttonRoleAdd_Click(object sender, EventArgs e)
        {
            FormRoleDetail formRoleDetail = new FormRoleDetail();
            formRoleDetail.ShowDialog();

            refreshDataViewRole();
            refreshDataViewRoleDetail();
        }
        private void buttonRoleDelete_Click(object sender, EventArgs e)
        {
            if (dataViewRole.SelectedRows.Count > 0)
            { 
                int roleID = Convert.ToInt16(dataViewRole.SelectedRows[0].Cells[0].Value);
                DialogResult dialogResult=MessageBox.Show("Xác nhận xóa phân quyền", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(dialogResult==DialogResult.Yes)
                {
                    try
                    {
                        if(RoleDetail.DeleteRoleDetail(roleID) >0 && Role.DeleteRole(roleID)>0)
                            MessageBox.Show("Xóa phân quyền thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Lỗi dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                refreshDataViewRole();
                refreshDataViewRoleDetail();
            }

        }

        private void buttonRoleEdit_Click(object sender, EventArgs e)
        {
            if (dataViewRole.SelectedRows.Count > 0)
            {
                int roleID = Convert.ToInt16(dataViewRole.SelectedRows[0].Cells[0].Value);
                FormRoleDetail formRoleDetail = new FormRoleDetail(Role.GetRole(roleID), "edit");
                formRoleDetail.ShowDialog();

                refreshDataViewRole();
                refreshDataViewRoleDetail();
            }

        }
        //Refresh datagridview in role tab
        private void refreshDataViewRole()
        {
            try
            {
                // Get Role's datatable
                DataTable roleTable = Role.GetListRole();

                // Add Vietnamese column's name
                roleTable.Columns.Add("Mã phân quyền", typeof(string), "[ROLEID]");
                roleTable.Columns.Add("Tên phân quyền", typeof(string), "[ROLENAME]");

                // Set data source to dataview for searching
                dataViewRole.DataSource = roleTable.DefaultView;

                // Hide English columns'name
                for (int i = 0; i < 2; i++)
                {
                    dataViewRole.Columns[i].Visible = false;
                }

                //Add auto complete datasource to textbox
                textBoxRoleSearch.AutoCompleteCustomSource.Clear();
                for (int i = 0; i < roleTable.Rows.Count; i++)
                {
                    String strRoleName = roleTable.Rows[i][1].ToString();
                    textBoxRoleSearch.AutoCompleteCustomSource.Add(strRoleName);
                }
            }
            catch
            {
                MessageBox.Show("Lỗi dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void refreshDataViewRoleDetail()
        {
            if (dataViewRole.SelectedRows.Count>0)
            {
                try
                {
                    // Get RoleDetail's datatable
                    int roleID = Convert.ToInt16(dataViewRole.Rows[0].Cells[0].Value);
                    DataTable roleDetailTable = RoleDetail.GetListStaffFunction(roleID);

                    // Set data source to dataview for searching
                    dataViewRoleDetail.DataSource = roleDetailTable;
                }
                catch
                {
                    MessageBox.Show("Lỗi dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } 
            }
        }
        //Search in datagridview
        private void searchRole()
        {
            // Not search it search string is empty
            if (textBoxRoleSearch.Text != "")
            {
                // Search with RowFilter
                ((DataView)dataViewRole.DataSource).RowFilter = "[Tên phân quyền] LIKE '*" + textBoxRoleSearch.Text.Trim() + "*'"
                                                                + "OR [Mã phân quyền] LIKE '*" + textBoxRoleSearch.Text.Trim() + "*'";
                refreshDataViewRoleDetail();
            }
            else
            {
                ((DataView)dataViewRole.DataSource).RowFilter = "";
            }
        }
        //Reload dateViewRoldeDetail
        private void dataViewRole_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataViewRole.SelectedRows.Count > 0)
            {
                // Get RoleDetail's datatable
                int roleID = Convert.ToInt16(dataViewRole.SelectedRows[0].Cells[0].Value);
                DataTable roleDetailTable = RoleDetail.GetListStaffFunction(roleID);

                // Set data source to dataview for searching
                dataViewRoleDetail.DataSource = roleDetailTable;
            }

            
        }
        // Search when text changed
        private void textBoxRoleSearch_TextChanged(object sender, EventArgs e)
        {
            searchRole();
        }
        // Reset search when click searchdelete button
        private void buttonRoleSearchDelete_Click(object sender, EventArgs e)
        {
            textBoxRoleSearch.Text = "";
            searchRole();
        }

        // Search when press key enter
        private void textBoxRoleSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchRole();
            }
        }
    }
}
