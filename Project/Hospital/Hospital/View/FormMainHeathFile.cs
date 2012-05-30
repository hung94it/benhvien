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
        // Refresh datagridview when click heath file tab
        private void tabItemHealthFile_Click(object sender, EventArgs e)
        {
            refreshDataViewHeathFile();
        }

        private void textBoxSearchHeathFile_TextChanged(object sender, EventArgs e)
        {
            searchHeathFile();
        }

        private void textBoxSearchHeathFile_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchHeathFile();
            }
        }

        private void buttonDeleteSearchHeathFile_Click(object sender, EventArgs e)
        {
            textBoxSearchHeathFile.Text = "";
            searchHeathFile();
        }

        private void buttonHealthFileDelete_Click(object sender, EventArgs e)
        {
            if (dataViewHeathFile.SelectedRows.Count > 0)
            { 
                int heathFileID = Convert.ToInt32(dataViewHeathFile.SelectedRows[0].Cells[0].Value);
                DialogResult dialogResult = MessageBox.Show("Xác nhận xóa bệnh án", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        if (HeathFile.DeleteHeathFile(heathFileID) > 0)
                            MessageBox.Show("Xóa bệnh án thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Không thể xóa bệnh án này", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                refreshDataViewHeathFile();
            }

        }

        private void buttonHealthFileEdit_Click(object sender, EventArgs e)
        {
            if (dataViewHeathFile.SelectedRows.Count > 0)
            {
                int heathFileID = Convert.ToInt32(dataViewHeathFile.SelectedRows[0].Cells[0].Value);
                FormHFDetail formHFDetail = new FormHFDetail(HeathFile.GetHeathFile(heathFileID), "edit");
                formHFDetail.ShowDialog();

                refreshDataViewHeathFile();
            }

        }
        //Refresh datagridview in heath file tab
        private void refreshDataViewHeathFile()
        {
            try
            {
                // Get heath file's datatable
                DataTable heathFileTable = HeathFile.GetListHeathFile();

                // Add Vietnamese column's name
                heathFileTable.Columns.Add("Mã bệnh án", typeof(string), "[HEATHFILEID]");
                heathFileTable.Columns.Add("Mã bệnh nhân", typeof(string), "[PATIENTID]");
                heathFileTable.Columns.Add("Ngày lập", typeof(DateTime), "[DATE]");
                heathFileTable.Columns.Add("Tình trạng bệnh nhân", typeof(string), "[PATIENTSTATE]");
                heathFileTable.Columns.Add("Tiền sự bệnh lý", typeof(string), "[PREHISTORY]");
                heathFileTable.Columns.Add("Bệnh mắc phải", typeof(string), "[DISEASE]");
                heathFileTable.Columns.Add("Hướng điều trị", typeof(string), "[TREATMENT]");
                // Set data source to dataview for searching
                dataViewHeathFile.DataSource = heathFileTable.DefaultView;

                // Hide English columns'name
                for (int i = 0; i < 7; i++)
                {
                    dataViewHeathFile.Columns[i].Visible = false;
                }
                               
            }
            catch
            {
                MessageBox.Show("Lỗi dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Search in datagridview
        private void searchHeathFile()
        {
            // Not search it search string is empty
            if (textBoxSearchHeathFile.Text != "")
            {
                // Search with RowFilter
                ((DataView)dataViewHeathFile.DataSource).RowFilter = "[Mã bệnh án] LIKE '*" + textBoxSearchHeathFile.Text.Trim() + "*'"
                                                                + "OR [Mã bệnh nhân] LIKE '*" + textBoxSearchHeathFile.Text.Trim() + "*'";
            }
            else
            {
                ((DataView)dataViewHeathFile.DataSource).RowFilter = "";
            }
        }
    }
}
