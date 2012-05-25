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
        // Refresh datagridview when click DeptMajor tab
        private void tabItemDeptMajor_Click(object sender, EventArgs e)
        {
            refreshDataViewDepartment();
            refreshDataViewMajor();
        }

        private void buttonDepartmentDelete_Click(object sender, EventArgs e)
        {
            int departmentID = Convert.ToInt16(dataViewDepartment.SelectedRows[0].Cells[0].Value);
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa phòng khoa này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    if (Department.DeleteDepartment(departmentID) > 0)
                        MessageBox.Show("Xóa phòng khoa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                catch
                {
                    MessageBox.Show("phòng khoa đã hoặc đang có người công tác", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            refreshDataViewDepartment();
        }

        private void buttonDepartmentEdit_Click(object sender, EventArgs e)
        {
            int departmentID = Convert.ToInt16(dataViewDepartment.SelectedRows[0].Cells[0].Value);
            FormDepartmentDetail formDepartmentDetail = new FormDepartmentDetail(Department.GetDepartment(departmentID),"edit");
            formDepartmentDetail.ShowDialog();

            refreshDataViewDepartment();
        }

        private void buttonDepartmentAdd_Click(object sender, EventArgs e)
        {
            FormDepartmentDetail formDepartmentDetail = new FormDepartmentDetail();
            formDepartmentDetail.ShowDialog();

            refreshDataViewDepartment();
        }
        //Refresh datagridview in DeptMajor tab
        private void refreshDataViewDepartment()
        {
            try
            {
                // Get department's datatable
                DataTable departmentTable = Department.GetListDepartment();

                // Add Vietnamese column's name
                departmentTable.Columns.Add("Mã phòng ban", typeof(string), "[DEPARTMENTID]");
                departmentTable.Columns.Add("Tên phòng ban", typeof(string), "[DEPARTMENTNAME]");
                // Set data source to dataview for searching
                dataViewDepartment.DataSource = departmentTable.DefaultView;

                // Hide English columns'name
                for (int i = 0; i < 2; i++)
                {
                    dataViewDepartment.Columns[i].Visible = false;
                }

            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message, "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Refresh datagridview in DeptMajor tab
        private void refreshDataViewMajor()
        {
            try
            {
                // Get department's datatable
                DataTable majorTable = Major.GetListMajor();

                // Add Vietnamese column's name
                majorTable.Columns.Add("Mã chuyên ngành", typeof(string), "[MAJORID]");
                majorTable.Columns.Add("Tên chuyên ngành", typeof(string), "[MAJORNAME]");
                // Set data source to dataview for searching
                dataViewMajor.DataSource = majorTable.DefaultView;

                // Hide English columns'name
                for (int i = 0; i < 2; i++)
                {
                    dataViewMajor.Columns[i].Visible = false;
                }

            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message, "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
