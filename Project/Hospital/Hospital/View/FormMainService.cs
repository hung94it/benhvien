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
        // Refresh datagridview when click service tab
        private void tabItemService_Click(object sender, EventArgs e)
        {
            refreshDataViewService();
        }
        private void textBoxServiceSearch_TextChanged(object sender, EventArgs e)
        {
            searchService();
        }

        private void buttonDeleteServiceSearch_Click(object sender, EventArgs e)
        {
            textBoxServiceSearch.Text = "";
            searchService();
        }
        private void textBoxServiceSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchService();
            }
        }

        private void buttonServiceDelete_Click(object sender, EventArgs e)
        {
            if (dataViewService.SelectedRows.Count > 0)
            { 
                int serviceID = Convert.ToInt16(dataViewService.SelectedRows[0].Cells[0].Value);
                DialogResult dialogResult = MessageBox.Show("Xác nhận xóa dịch vụ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        if (Service.DeleteService(serviceID) > 0)
                            MessageBox.Show("Xóa dịch thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Dịch vụ đã hoặc đang được sử dụng", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                refreshDataViewService();
            }
            
        }

        private void buttonServiceEdit_Click(object sender, EventArgs e)
        {
            if (dataViewService.SelectedRows.Count > 0)
            {
                int serviceID = Convert.ToInt16(dataViewService.SelectedRows[0].Cells[0].Value);
                FormServiceDetail formServiceDetail = new FormServiceDetail(Service.GetService(serviceID), "edit");
                formServiceDetail.ShowDialog();

                refreshDataViewService();
            }

        }

        private void buttonServiceAdd_Click(object sender, EventArgs e)
        {
            int serviceID = Convert.ToInt16(dataViewService.SelectedRows[0].Cells[0].Value);
            FormServiceDetail formServiceDetail = new FormServiceDetail();
            formServiceDetail.ShowDialog();

            refreshDataViewService();
        }
        //Refresh datagridview in service tab
        private void refreshDataViewService()
        {
            try
            {
                // Get service's datatable
                DataTable serviceTable = Service.GetListService();

                // Add Vietnamese column's name
                serviceTable.Columns.Add("Mã dịch vụ", typeof(string), "[SERVICEID]");
                serviceTable.Columns.Add("Tên dịch vụ", typeof(string), "[SERVICENAME]");
                serviceTable.Columns.Add("Đơn giá", typeof(string), "[PRICE]");
                // Set data source to dataview for searching
                dataViewService.DataSource = serviceTable.DefaultView;

                // Hide English columns'name
                for (int i = 0; i < 3; i++)
                {
                    dataViewService.Columns[i].Visible = false;
                }

                //Add auto complete datasource to textbox
                textBoxServiceSearch.AutoCompleteCustomSource.Clear();
                for (int i = 0; i < serviceTable.Rows.Count; i++)
                {
                    String strserviceName = serviceTable.Rows[i][1].ToString();
                    textBoxServiceSearch.AutoCompleteCustomSource.Add(strserviceName);
                }
            }
            catch
            {
                MessageBox.Show("Lỗi dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Search in datagridview
        private void searchService()
        {
            // Not search it search string is empty
            if (textBoxServiceSearch.Text != "")
            {
                // Search with RowFilter
                ((DataView)dataViewService.DataSource).RowFilter = "[Mã dịch vụ] LIKE '*" + textBoxServiceSearch.Text.Trim() + "*'"
                                                                + "OR [Tên dịch vụ] LIKE '*" + textBoxServiceSearch.Text.Trim() + "*'";
            }
            else
            {
                ((DataView)dataViewService.DataSource).RowFilter = "";
            }
        }
    }
}
