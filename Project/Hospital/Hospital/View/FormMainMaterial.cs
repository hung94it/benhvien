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
        private void tabItemMaterial_Click(object sender, EventArgs e)
        {
            refreshDataViewMaterial();
        }
        private void textBoxMaterialSearch_TextChanged(object sender, EventArgs e)
        {
            searchMaterial();
        }
        private void textBoxMaterialSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchMaterial();
            }
        }
        private void buttonDeleteMaterialSearch_Click(object sender, EventArgs e)
        {
            textBoxMaterialSearch.Text = "";
            searchMaterial();
        }

        private void buttonMaterialDelete_Click(object sender, EventArgs e)
        {
            int materialID = Convert.ToInt16(dataViewMaterial.SelectedRows[0].Cells[0].Value);
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa vật tư này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    if (Material.DeleteMaterial(materialID) > 0 )
                        MessageBox.Show("Xóa vật tư thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                catch
                {
                    MessageBox.Show("Vật tư đã hoặc đang được sử dụng", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            refreshDataViewMaterial();
        }

        private void buttonMaterialEdit_Click(object sender, EventArgs e)
        {
            int materialID = Convert.ToInt16(dataViewMaterial.SelectedRows[0].Cells[0].Value);
            FormMaterialDetail formMaterialDetail = new FormMaterialDetail(Material.GetMaterial(materialID),"edit");
            formMaterialDetail.ShowDialog();

            refreshDataViewMaterial();
        }

        private void buttonMaterialAdd_Click(object sender, EventArgs e)
        {
            FormMaterialDetail formMaterialDetail = new FormMaterialDetail();
            formMaterialDetail.ShowDialog();

            refreshDataViewMaterial();
        }
        //Refresh datagridview in material tab
        private void refreshDataViewMaterial()
        {
            try
            {
                // Get material's datatable
                DataTable materialTable = Material.GetListMaterial();

                // Add Vietnamese column's name
                materialTable.Columns.Add("Mã vật tư", typeof(string), "[MATERIALID]");
                materialTable.Columns.Add("Tên vật tư", typeof(string), "[MATERIALNAME]");
                materialTable.Columns.Add("Số lượng", typeof(string), "[QUANTITY]");
                materialTable.Columns.Add("Đơn giá", typeof(string), "[PRICE]");
                // Set data source to dataview for searching
                dataViewMaterial.DataSource = materialTable.DefaultView;

                // Hide English columns'name
                for (int i = 0; i < 4; i++)
                {
                    dataViewMaterial.Columns[i].Visible = false;
                }

                //Add auto complete datasource to textbox
                textBoxMaterialSearch.AutoCompleteCustomSource.Clear();
                for (int i = 0; i < materialTable.Rows.Count; i++)
                {
                    String strmaterialName = materialTable.Rows[i][1].ToString();
                    textBoxMaterialSearch.AutoCompleteCustomSource.Add(strmaterialName);
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message, "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Search in datagridview
        private void searchMaterial()
        {
            // Not search it search string is empty
            if (textBoxMaterialSearch.Text != "")
            {
                // Search with RowFilter
                ((DataView)dataViewMaterial.DataSource).RowFilter = "[Mã vật tư] LIKE '*" + textBoxMaterialSearch.Text.Trim() + "*'"
                                                                + "OR [Tên vật tư] LIKE '*" + textBoxMaterialSearch.Text.Trim() + "*'";
            }
            else
            {
                ((DataView)dataViewMaterial.DataSource).RowFilter = "";
            }
        }
    }
}
