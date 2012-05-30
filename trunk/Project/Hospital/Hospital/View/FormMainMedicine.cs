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
        // Refresh datagridview when click material tab
        private void tabItemMedicine_Click(object sender, EventArgs e)
        {
            refreshDataViewMedicine();
        }
        private void buttonMedicineDelete_Click(object sender, EventArgs e)
        {
            if (dataViewMedicine.SelectedRows.Count > 0)
            {
                int medicineID = Convert.ToInt32(dataViewMedicine.SelectedRows[0].Cells[0].Value);
                DialogResult dialogResult = MessageBox.Show("Xác nhận xóa thuốc", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        if (Medicine.DeleteMedicne(medicineID) > 0)
                            MessageBox.Show("Xóa thuốc thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Thuốc đã hoặc đang được sử dụng", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                refreshDataViewMedicine();
            }

        }

        private void buttonMedicineEdit_Click(object sender, EventArgs e)
        {
            if (dataViewMedicine.SelectedRows.Count > 0)
            { 
                int medicineID = Convert.ToInt32(dataViewMedicine.SelectedRows[0].Cells[0].Value);
                FormMedicineDetail formMedicineDetail = new FormMedicineDetail(Medicine.GetMedicine(medicineID),"edit");
                formMedicineDetail.ShowDialog();

                refreshDataViewMedicine();
            }

        }
        private void buttonMedicineAdd_Click(object sender, EventArgs e)
        {
            FormMedicineDetail formMedicineDetail = new FormMedicineDetail();
            formMedicineDetail.ShowDialog();

            refreshDataViewMedicine();
        }

        private void textBoxMedicineSearch_TextChanged(object sender, EventArgs e)
        {
            searchMedicine();
        }

        private void buttonDeleteMedicineSearch_Click(object sender, EventArgs e)
        {
            textBoxMedicineSearch.Text = "";
            searchMedicine();
        }

        private void textBoxMedicineSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchMedicine();
            }
        }
        //Refresh datagridview in medicine tab
        private void refreshDataViewMedicine()
        {
            try
            {
                // Get medicine's datatable
                DataTable medicineTable = Medicine.GetListMedicine();

                // Add Vietnamese column's name
                medicineTable.Columns.Add("Mã thuốc", typeof(string), "[MEDICINEID]");
                medicineTable.Columns.Add("Tên thuốc", typeof(string), "[MEDICINENAME]");
                medicineTable.Columns.Add("Số lượng", typeof(string), "[QUANTITY]");
                medicineTable.Columns.Add("Đơn giá", typeof(string), "[PRICE]");
                // Set data source to dataview for searching
                dataViewMedicine.DataSource = medicineTable.DefaultView;

                // Hide English columns'name
                for (int i = 0; i < 4; i++)
                {
                    dataViewMedicine.Columns[i].Visible = false;
                }

                //Add auto complete datasource to textbox
                textBoxMedicineSearch.AutoCompleteCustomSource.Clear();
                for (int i = 0; i < medicineTable.Rows.Count; i++)
                {
                    String strMaterialName = medicineTable.Rows[i][1].ToString();
                    textBoxMedicineSearch.AutoCompleteCustomSource.Add(strMaterialName);
                }
            }
            catch
            {
                MessageBox.Show("Lỗi dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Search in datagridview
        private void searchMedicine()
        {
            // Not search it search string is empty
            if (textBoxMedicineSearch.Text != "")
            {
                // Search with RowFilter
                ((DataView)dataViewMedicine.DataSource).RowFilter = "[Mã thuốc] LIKE '*" + textBoxMedicineSearch.Text.Trim() + "*'"
                                                                + "OR [Tên thuốc] LIKE '*" + textBoxMedicineSearch.Text.Trim() + "*'";
            }
            else
            {
                ((DataView)dataViewMedicine.DataSource).RowFilter = "";
            }
        }
    }
}
