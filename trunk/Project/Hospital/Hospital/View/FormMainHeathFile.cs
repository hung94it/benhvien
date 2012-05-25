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

        }

        private void buttonHealthFileEdit_Click(object sender, EventArgs e)
        {
            int heathFileID = Convert.ToInt32(dataViewHeathFile.SelectedRows[0].Cells[0].Value);
            FormHFDetail formHFDetail = new FormHFDetail(HeathFile.GetHeathFile(heathFileID), "edit");
            formHFDetail.ShowDialog();

            refreshDataViewHeathFile();
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
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message, "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
