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

        private void tabItemStaff_Click(object sender, EventArgs e)
        {
            refreshDataViewStaff();
        }

        private void buttonStaffAdd_Click(object sender, EventArgs e)
        {
            FormStaffDetail staffDetailForm = new FormStaffDetail("add", new Staff());
            staffDetailForm.ShowDialog();
            refreshDataViewStaff();
        }

        private void buttonStaffEdit_Click(object sender, EventArgs e)
        {
            Staff StaffDetail = Staff.GetStaff(Convert.ToInt32(dataViewStaff.SelectedRows[0].Cells[0].Value.ToString()));
            FormStaffDetail staffDetailForm = new FormStaffDetail("edit", StaffDetail);
            staffDetailForm.ShowDialog();
            refreshDataViewStaff();
        }

        private void buttonStaffDelete_Click(object sender, EventArgs e)
        {
            int staffID;

            try
            {
                if (MessageBox.Show("Bạn có muốn xóa nhân viên này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                    == DialogResult.Yes)
                {
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
            refreshDataViewStaff();
        }

        private void buttonStaffDeleteSearch_Click(object sender, EventArgs e)
        {
            textBoxStaffSearch.Text = "";
            searchStaff();
        }

        private void textBoxStaffSearch_KeyDown(object sender, KeyEventArgs e)
        {
            searchStaff();
        }

        private void textBoxStaffSearch_TextChanged(object sender, EventArgs e)
        {
            searchStaff();
        }

        private void searchStaff()
        {
            if (textBoxStaffSearch.Text != "")
            {

                ((DataView)dataViewStaff.DataSource).RowFilter = "[Họ tên] LIKE '*" + textBoxStaffSearch.Text.Trim() + "*'"
                                                                + "OR [Mã nhân viên] LIKE '*" + textBoxStaffSearch.Text.Trim() + "*'"
                                                                + "OR [CMND] LIKE '*" + textBoxStaffSearch.Text.Trim() + "*'";
            }
            else
                ((DataView)dataViewStaff.DataSource).RowFilter = "";
        }

        private void refreshDataViewStaff()
        {
            try
            {
                dataViewStaff.DataSource = Staff.GetListStaff();

                for (int i = 0; i <= 9; i++)
                {
                    //dataViewStaff.Columns[i].Visible = false;
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message, "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
