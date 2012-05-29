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
        // Refresh datagridview when click prescription tab
        private void tabItemPrescpition_Click(object sender, EventArgs e)
        {
            refreshDataViewPrescription();
            refreshDataViewPrescriptionDetail();
        }
        //Reload dateViewPrescriptionDetail
        private void dataViewPrescription_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataViewPrescription.SelectedRows.Count > 0)
            { 
                // Get PrescriptionDetail's datatable
                int prescriptionID = Convert.ToInt32(dataViewPrescription.SelectedRows[0].Cells[0].Value);
                DataTable prescriptionDetailTable = PrescriptionDetail.GetListPrescriptionDetail(prescriptionID);

                // Set data source to dataview for searching
                dataViewPrescriptionDetail.DataSource = prescriptionDetailTable;
            }

        }
        private void textBoxPrescriptionSearch_TextChanged(object sender, EventArgs e)
        {
            searchPrescription();
        }

        private void textBoxPrescriptionSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchPrescription();
            }
        }

        private void buttonDeletePrescriptionSearch_Click(object sender, EventArgs e)
        {
            textBoxPrescriptionSearch.Text = "";
            searchPrescription();
        }

        private void buttonPrescpitionEdit_Click(object sender, EventArgs e)
        {
            if (dataViewPrescription.SelectedRows.Count > 0)
            { 
                int prescriptionID = Convert.ToInt32(dataViewPrescription.SelectedRows[0].Cells[0].Value);
                FormPrescriptionDetail formPD = new FormPrescriptionDetail(Prescription.GetPrescription(prescriptionID), "edit");
                formPD.ShowDialog();

                refreshDataViewPrescription();
                refreshDataViewPrescriptionDetail();
            }

        }

        private void buttonPrescpitionDelete_Click(object sender, EventArgs e)
        {
            if (dataViewPrescription.SelectedRows.Count > 0)
            {
                int prescriptionID = Convert.ToInt32(dataViewPrescription.SelectedRows[0].Cells[0].Value);
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa toa thuốc này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        if (PrescriptionDetail.DeletePrescriptionDetail(prescriptionID) > 0 && Prescription.DeletePrescription(prescriptionID) > 0)
                            MessageBox.Show("Xóa toa thuốc thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                    catch (SqlException exception)
                    {
                        MessageBox.Show(exception.Message, "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                refreshDataViewPrescription();
                refreshDataViewPrescriptionDetail();
            }

        }
        //Refresh datagridview in prescription tab
        private void refreshDataViewPrescription()
        {
            try
            {
                // Get prescription's datatable
                DataTable prescriptionTable = Prescription.GetListPrescription();

                // Add Vietnamese column's name
                prescriptionTable.Columns.Add("Mã toa thuốc", typeof(string), "[PRESCRIPTIONID]");
                prescriptionTable.Columns.Add("Mã nhân viên", typeof(string), "[STAFFID]");
                prescriptionTable.Columns.Add("Mã bệnh nhân", typeof(string), "[PATIENTID]");
                prescriptionTable.Columns.Add("Ngày lập", typeof(DateTime), "[DATE]");
                // Set data source to dataview for searching
                dataViewPrescription.DataSource = prescriptionTable.DefaultView;

                // Hide English columns'name
                for (int i = 0; i < 4; i++)
                {
                    dataViewPrescription.Columns[i].Visible = false;
                }                
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message, "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void refreshDataViewPrescriptionDetail()
        {
            if (dataViewPrescription.SelectedRows.Count >0)
            {
                try
                {
                    // Get PrescriptionDetail's datatable
                    int prescriptionID = Convert.ToInt32(dataViewPrescription.Rows[0].Cells[0].Value);
                    DataTable prescriptionDetailTable = PrescriptionDetail.GetListPrescriptionDetail(prescriptionID);

                    // Set data source to dataview for searching
                    dataViewPrescriptionDetail.DataSource = prescriptionDetailTable.DefaultView;
                }
                catch (SqlException exception)
                {
                    MessageBox.Show(exception.Message, "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } 
            }
        }
        private void searchPrescription()
        {
            // Not search it search string is empty
            if (textBoxPrescriptionSearch.Text != "")
            {
                // Search with RowFilter
                ((DataView)dataViewPrescription.DataSource).RowFilter = "[Mã toa thuốc] LIKE '*" + textBoxPrescriptionSearch.Text.Trim() + "*'"
                                                                + "OR [Mã bệnh nhân] LIKE '*" + textBoxPrescriptionSearch.Text.Trim() + "*'"
                                                                + "OR [Mã nhân viên] LIKE '*" + textBoxPrescriptionSearch.Text.Trim() + "*'";
                refreshDataViewPrescriptionDetail();
            }
            else
            {
                ((DataView)dataViewPrescription.DataSource).RowFilter = "";
            }
        }
       
    }
}
