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
        // Refresh datagridview when click function tab
        private void tabItemFunction_Click(object sender, EventArgs e)
        {
            refreshDataViewFunction();
        }

        private void textBoxFunctionSearch_TextChanged(object sender, EventArgs e)
        {
            searchFunction();
        }

        private void textBoxFunctionSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchFunction();
            }
        }

        private void buttonDeleteFunctionSearch_Click(object sender, EventArgs e)
        {
            textBoxFunctionSearch.Text = "";
            searchFunction();
        }

        private void buttonFunctionDelete_Click(object sender, EventArgs e)
        {
            int funtionlID = Convert.ToInt16(dataViewFunction.SelectedRows[0].Cells[0].Value);
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa chức năng này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    if (RoleFunction.DeleteFunction(funtionlID) > 0)
                        MessageBox.Show("Xóa chức năng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                catch
                {
                    MessageBox.Show("Chức năng này đang được sử dụng", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            refreshDataViewFunction();
        }

        private void buttonFunctionEdit_Click(object sender, EventArgs e)
        {
            int funtionlID = Convert.ToInt16(dataViewFunction.SelectedRows[0].Cells[0].Value);
            RoleFunction updateFunction = RoleFunction.GetFunction(funtionlID);
            FormRoleFunctionDetail formRFD = new FormRoleFunctionDetail(updateFunction,"edit");
            formRFD.ShowDialog();

            refreshDataViewFunction();
        }

        private void buttonFunctionAdd_Click(object sender, EventArgs e)
        {
            FormRoleFunctionDetail formRFD = new FormRoleFunctionDetail();
            formRFD.ShowDialog();

            refreshDataViewFunction();
        }
        //Refresh datagridview in function tab
        private void refreshDataViewFunction()
        {
            try
            {
                // Get function's datatable
                DataTable functionTable = RoleFunction.GetListFunction();

                // Add Vietnamese column's name
                functionTable.Columns.Add("Mã chức năng", typeof(string), "[FUNCTIONID]");
                functionTable.Columns.Add("Tên chức năng", typeof(string), "[FUNCTIONNAME]");
                functionTable.Columns.Add("Nút kích hoạt", typeof(string), "[BUTTON]");
                // Set data source to dataview for searching
                dataViewFunction.DataSource = functionTable.DefaultView;

                // Hide English columns'name
                for (int i = 0; i < 3; i++)
                {
                    dataViewFunction.Columns[i].Visible = false;
                }

                //Add auto complete datasource to textbox
                textBoxFunctionSearch.AutoCompleteCustomSource.Clear();
                for (int i = 0; i < functionTable.Rows.Count; i++)
                {
                    String strFunctionName = functionTable.Rows[i][1].ToString();
                    textBoxFunctionSearch.AutoCompleteCustomSource.Add(strFunctionName);
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message, "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        //Search in datagridview
        private void searchFunction()
        {
            // Not search it search string is empty
            if (textBoxFunctionSearch.Text != "")
            {
                // Search with RowFilter
                ((DataView)dataViewFunction.DataSource).RowFilter = "[Mã chức năng] LIKE '*" + textBoxFunctionSearch.Text.Trim() + "*'"
                                                                + "OR [Tên chức năng] LIKE '*" + textBoxFunctionSearch.Text.Trim() + "*'";
            }
            else
            {
                ((DataView)dataViewFunction.DataSource).RowFilter = "";
            }
        }
    }
}
