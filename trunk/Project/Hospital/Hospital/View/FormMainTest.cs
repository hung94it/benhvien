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
        // Refresh datagridview when click test tab
        private void tabItemTest_Click(object sender, EventArgs e)
        {
            refreshDataViewTest();
            refreshDataViewTestDetail();
        }

        private void textBoxTCSearch_TextChanged(object sender, EventArgs e)
        {
            searchTest();
        }

        private void textBoxTCSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchTest();
            }
        }

        private void buttonDeleteTCSearch_Click(object sender, EventArgs e)
        {
            textBoxSearchTest.Text = "";
            searchTest();
        }

        private void dataViewTC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataViewTC.SelectedRows.Count > 0)
            {
                int testID = Convert.ToInt32(dataViewTC.SelectedRows[0].Cells[0].Value);
                DataTable dtTD = TestDetail.GetListTestDetail(testID);

                dataViewTCDetail.DataSource = dtTD.DefaultView;
            }
            
        }

        private void buttonTestDelete_Click(object sender, EventArgs e)
        {
            if (dataViewTC.SelectedRows.Count > 0)
            {
                int testID = Convert.ToInt32(dataViewTC.SelectedRows[0].Cells[0].Value);
                DialogResult dialogResult = MessageBox.Show("Xác nhận xóa phiếu xét nghiệm", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        if (TestDetail.DeleteTestDetail(testID) > 0 && TestCertificate.DeleteTC(testID) > 0)
                            MessageBox.Show("Xóa phiếu xét nghiệm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Không thể xóa phiếu xét nghiệm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                refreshDataViewTest();
                refreshDataViewTestDetail();
            }

        }

        private void buttonTestEdit_Click(object sender, EventArgs e)
        {
            if (dataViewTC.SelectedRows.Count > 0)
            {
                int testID = Convert.ToInt32(dataViewTC.SelectedRows[0].Cells[0].Value);
                TestCertificate updateTD=TestCertificate.GetTC(testID);
                FormTestDetail formTD = new FormTestDetail(updateTD,"edit");
                formTD.ShowDialog();

                refreshDataViewTest();
                refreshDataViewTestDetail();
            }

        }
        //Refresh datagridview in test tab
        private void refreshDataViewTest()
        {
            try
            {
                // Get test's datatable
                DataTable testTable = TestCertificate.GetListTC();

                // Add Vietnamese column's name
                testTable.Columns.Add("Mã phiếu xét nghiệm", typeof(string), "[TCID]");
                testTable.Columns.Add("Mã nhân viên", typeof(string), "[STAFFID]");
                testTable.Columns.Add("Mã bệnh nhân", typeof(string), "[PATIENTID]");
                testTable.Columns.Add("Ngày lập", typeof(DateTime), "[DATE]");
                testTable.Columns.Add("Trạng thái", typeof(string), "IIF([STATE] = 0, 'Chưa xét nghiệm', 'Đã xét nghiệm')");
                
                // Set data source to dataview for searching
                dataViewTC.DataSource = testTable.DefaultView;

                // Hide English columns'name
                for (int i = 0; i < 5; i++)
                {
                    dataViewTC.Columns[i].Visible = false;
                }
            }
            catch
            {
                MessageBox.Show("Lỗi dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void refreshDataViewTestDetail()
        {
            if (dataViewTC.SelectedRows.Count>0)
            {
                try
                {
                    // Get Test's datatable
                    int testID = Convert.ToInt32(dataViewTC.Rows[0].Cells[0].Value);
                    DataTable testDetailTable = TestDetail.GetListTestDetail(testID);
                    // Set data source to dataview for searching
                    dataViewTCDetail.DataSource = testDetailTable.DefaultView;
                }
                catch
                {
                    MessageBox.Show("Lỗi dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } 
            }
        }
        private void searchTest()
        {
            // Not search it search string is empty
            if (textBoxSearchTest.Text != "")
            {
                // Search with RowFilter
                ((DataView)dataViewTC.DataSource).RowFilter = "[Mã phiếu xét nghiệm] LIKE '*" + textBoxSearchTest.Text.Trim() + "*'"
                                                                + "OR [Mã bệnh nhân] LIKE '*" + textBoxSearchTest.Text.Trim() + "*'"
                                                                 + "OR [Mã nhân viên] LIKE '*" + textBoxSearchTest.Text.Trim() + "*'"
                                                                  + "OR [Trạng thái] LIKE '*" + textBoxSearchTest.Text.Trim() + "*'";
                refreshDataViewTestDetail();
            }
            else
            {
                ((DataView)dataViewTC.DataSource).RowFilter = "";
            }
        }
    }
}
