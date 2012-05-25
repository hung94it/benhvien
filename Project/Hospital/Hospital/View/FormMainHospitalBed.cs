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
        // Refresh datagridview when click hospital bed tab
        private void tabItemBed_Click(object sender, EventArgs e)
        {
            refreshDataViewBed();
        }
        private void textBoxBedSearch_TextChanged(object sender, EventArgs e)
        {
            searchBed();
        }

        private void textBoxBedSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchBed();
            }
        }

        private void buttonDeleteBedSearch_Click(object sender, EventArgs e)
        {
            textBoxBedSearch.Text = "";
            searchBed();
        }

        private void buttonRecevieBed_Click(object sender, EventArgs e)
        {
            int bedID = Convert.ToInt16(dataViewBed.SelectedRows[0].Cells[0].Value);
            int state = Convert.ToInt16(dataViewBed.SelectedRows[0].Cells[2].Value);
            if (state == 0)
            {
                FormHostpitalBedDetail formHBDetail = new FormHostpitalBedDetail(HospitalBed.GetHospitalBed(bedID));
                formHBDetail.ShowDialog();
            }
            else
            {
                MessageBox.Show("giường bệnh đang được sử dụng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            refreshDataViewBed();
        }

        private void buttonReturnBed_Click(object sender, EventArgs e)
        {
            int bedID = Convert.ToInt16(dataViewBed.SelectedRows[0].Cells[0].Value);
            int state = Convert.ToInt16(dataViewBed.SelectedRows[0].Cells[2].Value);
            if (state == 1)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có xác nhận trả giường này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    HospitalBed updateHB = HospitalBed.GetHospitalBed(bedID);
                    updateHB.Patient = 0;
                    updateHB.State = 0;
                    if (HospitalBed.UpdateHospitalBed(updateHB) > 0)
                        MessageBox.Show("Trả giường thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);

                }
            }
            else
            {
                MessageBox.Show("Giường bệnh trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            refreshDataViewBed();
        }

        private void buttonBedDelete_Click(object sender, EventArgs e)
        {
            int bedID = Convert.ToInt16(dataViewBed.SelectedRows[0].Cells[0].Value);
            int state = Convert.ToInt16(dataViewBed.SelectedRows[0].Cells[2].Value);
            if (state == 0)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa giường bệnh này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                
                        if (HospitalBed.DeleteHospitalBed(bedID) > 0)
                            MessageBox.Show("Xóa giường bệnh thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                
                }
            }
            else
            {
                MessageBox.Show("giường bệnh đã hoặc đang được sử dụng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            refreshDataViewBed();
        }

        private void buttonBedAdd_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn thêm giường bệnh không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                if (HospitalBed.InsertHospitalBed() > 0)
                    MessageBox.Show("Thêm giường bệnh thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);

            }
            refreshDataViewBed();
        }
        //Refresh datagridview in hospital bed tab
        private void refreshDataViewBed()
        {
            try
            {
                // Get hospital bed's datatable
                DataTable bedTable = HospitalBed.GetListHospitalBed();

                // Add Vietnamese column's name
                bedTable.Columns.Add("Mã giường bệnh", typeof(string), "[BEDID]");
                bedTable.Columns.Add("Mã bệnh nhân", typeof(string), "[PATIENT]");
                bedTable.Columns.Add("Trạng thái", typeof(string), "IIF([STATE] = 0, 'Trống', 'Có người')");

                // Set data source to dataview for searching
                dataViewBed.DataSource = bedTable.DefaultView;

                // Hide English columns'name
                for (int i = 0; i < 3; i++)
                {
                    dataViewBed.Columns[i].Visible = false;
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message, "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Search in datagridview
        private void searchBed()
        {
            // Not search it search string is empty
            if (textBoxBedSearch.Text != "")
            {
                // Search with RowFilter
                ((DataView)dataViewBed.DataSource).RowFilter = "[Mã giường bệnh] LIKE '*" + textBoxBedSearch.Text.Trim() + "*'"
                                                                + "OR [Mã bệnh nhân] LIKE '*" + textBoxBedSearch.Text.Trim() + "*'"
                                                                + "OR [Trạng thái] LIKE '*" + textBoxBedSearch.Text.Trim() + "*'";
            }
            else
            {
                ((DataView)dataViewBed.DataSource).RowFilter = "";
            }
        }
    }
}
