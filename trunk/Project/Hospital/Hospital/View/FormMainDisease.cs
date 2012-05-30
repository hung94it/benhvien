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
        private void tabItemDisease_Click(object sender, EventArgs e)
        {
            refreshDataViewDisease();
        }

        private void textBoxDiseaseSearch_TextChanged(object sender, EventArgs e)
        {
            searchDisease();
        }

        private void textBoxDiseaseSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchDisease();
            }
        }

        private void buttonDeleteDiseaseSearch_Click(object sender, EventArgs e)
        {
            textBoxDiseaseSearch.Text = "";
            searchDisease();
        }

        private void buttonDiseaseDelete_Click(object sender, EventArgs e)
        {
            if (dataViewDisease.SelectedRows.Count > 0)
            {
                int diseaseID = Convert.ToInt16(dataViewDisease.SelectedRows[0].Cells[0].Value);
                DialogResult dialogResult = MessageBox.Show("Xác nhận xóa bệnh", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        if (Disease.DeleteDisease(diseaseID) > 0)
                            MessageBox.Show("Xóa bệnh thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Bệnh đã hoặc đang có người mắc phải", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                refreshDataViewDisease();
            }

        }

        private void buttonDiseaseEdit_Click(object sender, EventArgs e)
        {
            if (dataViewDisease.SelectedRows.Count > 0)
            {
                int diseaseID = Convert.ToInt16(dataViewDisease.SelectedRows[0].Cells[0].Value);
                FormDiseaseDetail formDiseaseDetail = new FormDiseaseDetail(Disease.GetDisease(diseaseID),"edit");
                formDiseaseDetail.ShowDialog();

                refreshDataViewDisease();
            }

        }

        private void buttonDiseaseAdd_Click(object sender, EventArgs e)
        {
            FormDiseaseDetail formDiseaseDetail = new FormDiseaseDetail();
            formDiseaseDetail.ShowDialog();

            refreshDataViewDisease();
        }
        //Refresh datagridview in disease tab
        private void refreshDataViewDisease()
        {
            try
            {
                // Get disease's datatable
                DataTable diseaseTable = Disease.GetListDisease();

                // Add Vietnamese column's name
                diseaseTable.Columns.Add("Mã bệnh", typeof(string), "[DISEASEID]");
                diseaseTable.Columns.Add("Tên bệnh", typeof(string), "[DISEASENAME]");
                diseaseTable.Columns.Add("Triệu chứng", typeof(string), "[SYMPTOM]");
                // Set data source to dataview for searching
                dataViewDisease.DataSource = diseaseTable.DefaultView;

                // Hide English columns'name
                for (int i = 0; i < 3; i++)
                {
                    dataViewDisease.Columns[i].Visible = false;
                }

                //Add auto complete datasource to textbox
                textBoxDiseaseSearch.AutoCompleteCustomSource.Clear();
                for (int i = 0; i < diseaseTable.Rows.Count; i++)
                {
                    String strDiseaseName = diseaseTable.Rows[i][1].ToString();
                    textBoxDiseaseSearch.AutoCompleteCustomSource.Add(strDiseaseName);
                }
            }
            catch
            {
                MessageBox.Show("Lỗi dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Search in datagridview
        private void searchDisease()
        {
            // Not search it search string is empty
            if (textBoxDiseaseSearch.Text != "")
            {
                // Search with RowFilter
                ((DataView)dataViewDisease.DataSource).RowFilter = "[Mã bệnh] LIKE '*" + textBoxDiseaseSearch.Text.Trim() + "*'"
                                                                + "OR [Tên bệnh] LIKE '*" + textBoxDiseaseSearch.Text.Trim() + "*'";
            }
            else
            {
                ((DataView)dataViewDisease.DataSource).RowFilter = "";
            }
        }
    }
}
