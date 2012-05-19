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
        // Refresh datagridview when click patient tab
        private void tabItemPatient_Click(object sender, EventArgs e)
        {
            refreshDataViewPatient();
        }

        // Add new patient when click add button
        private void buttonPatientAdd_Click(object sender, EventArgs e)
        {
            // Open patientdetail form for add
            FormPatientDetail patientDetailForm = new FormPatientDetail("add", new Patient());
            patientDetailForm.ShowDialog();

            // Refresh datagridview after add
            refreshDataViewPatient();
        }

        // Edit patient's information when click edit button
        private void buttonPatientEdit_Click(object sender, EventArgs e)
        {
            // Get patient for edit
            Patient PatientDetail = Patient.GetPatient(Convert.ToInt32(dataViewPatient.SelectedRows[0].Cells[0].Value.ToString()));

            // Open patientdetail form for edit
            FormPatientDetail patientDetailForm = new FormPatientDetail("edit", PatientDetail);
            patientDetailForm.ShowDialog();

            // Refresh datagridview after edit
            refreshDataViewPatient();
        }

        // Delete patient when click delete button
        private void buttonPatientDelete_Click(object sender, EventArgs e)
        {
            int patientID;

            try
            {
                // Warning before delete
                if (MessageBox.Show("Bạn có muốn xóa bệnh nhân này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                    == DialogResult.Yes)
                {
                    // Get patientid for delete
                    if (int.TryParse(dataViewPatient.SelectedRows[0].Cells[0].Value.ToString(), out patientID))
                    {
                        Patient.DeletePatient(patientID);
                    }
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message, "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }

            // Refresh datagridview after delete
            refreshDataViewPatient();
        }

        // Reset search when click searchdelete button
        private void buttonPatientSearchDelete_Click(object sender, EventArgs e)
        {
            textBoxPatientSearch.Text = "";
            searchPatient();
        }

        // Search when text changed
        private void textBoxPatientSearch_TextChanged(object sender, EventArgs e)
        {
            searchPatient();
        }

        // Search when press key enter
        private void textBoxPatientSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchPatient();
            }
        }

        //Search in datagridview
        private void searchPatient()
        {
            // Not search it search string is empty
            if (textBoxPatientSearch.Text != "")
            {
                // Search with RowFilter
                ((DataView)dataViewPatient.DataSource).RowFilter = "[Họ tên] LIKE '*" + textBoxPatientSearch.Text.Trim() + "*'"
                                                                + "OR [Mã bệnh nhân] LIKE '*" + textBoxPatientSearch.Text.Trim() + "*'"
                                                                + "OR [CMND] LIKE '*" + textBoxPatientSearch.Text.Trim() + "*'";
            }
            else
            {
                ((DataView)dataViewPatient.DataSource).RowFilter = "";
            }
        }

        //Refresh datagridview in Patient tab
        private void refreshDataViewPatient()
        {
            try
            {
                // Get Patient's datatable
                DataTable patientTable = Patient.GetListPatient();

                // Add Vietnamese column's name
                patientTable.Columns.Add("Mã bệnh nhân", typeof(string), "[PATIENTID]");
                patientTable.Columns.Add("Họ tên", typeof(string), "[LASTNAME] + ' ' + [FIRSTNAME]");
                patientTable.Columns.Add("CMND", typeof(string), "[ICN]");
                patientTable.Columns.Add("Giới tính", typeof(string), "IIF([GENDER] = 0, 'Nam', 'Nữ')");
                patientTable.Columns.Add("Ngày sinh", typeof(DateTime), "[BIRTHDAY]");
                patientTable.Columns.Add("Nghề nghiệp", typeof(string), "PROFESSION");
                patientTable.Columns.Add("Địa chỉ", typeof(string), "[ADDRESS]");
                patientTable.Columns.Add("Tiền đặt cọc", typeof(string), "[DEPOSIT]");
                //staffTable.Columns.Add("Trạng thái", typeof(string), "[STATE]");

                // Set data source to dataview for searching
                dataViewPatient.DataSource = patientTable.DefaultView;

                // Hide English columns'name
                for (int i = 0; i < 10; i++)
                {
                    dataViewPatient.Columns[i].Visible = false;
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message, "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
