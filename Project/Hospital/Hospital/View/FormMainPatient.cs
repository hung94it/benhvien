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
            if (dataViewPatient.SelectedRows.Count > 0)
            { 
                // Get patient for edit
                Patient PatientDetail = Patient.GetPatient(Convert.ToInt32(dataViewPatient.SelectedRows[0].Cells[0].Value.ToString()));

                // Open patientdetail form for edit
                FormPatientDetail patientDetailForm = new FormPatientDetail("edit", PatientDetail);
                patientDetailForm.ShowDialog();

                // Refresh datagridview after edit
                refreshDataViewPatient();
            }
            
        }

        // Delete patient when click delete button
        private void buttonPatientDelete_Click(object sender, EventArgs e)
        {
            if (dataViewPatient.SelectedRows.Count > 0)
            {
                int patientID;

                try
                {
                    // Warning before delete
                    if (MessageBox.Show("Xác nhận xóa bệnh nhân", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                        == DialogResult.Yes)
                    {
                        // Get patientid for delete
                        if (int.TryParse(dataViewPatient.SelectedRows[0].Cells[0].Value.ToString(), out patientID))
                        {
                            Patient.DeletePatient(patientID);
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Lỗi dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);                
                }

                // Refresh datagridview after delete
                refreshDataViewPatient();
            }

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
                patientTable.Columns.Add("Trạng thái", typeof(string), "IIF([STATE] = 0, 'Ngoại trú', 'Nội trú')");

                // Set data source to dataview for searching
                dataViewPatient.DataSource = patientTable.DefaultView;

                // Hide English columns'name
                for (int i = 0; i < 10; i++)
                {
                    dataViewPatient.Columns[i].Visible = false;
                }
            }
            catch
            {
                MessageBox.Show("Lỗi dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonPrescription_Click(object sender, EventArgs e)
        {
            if (dataViewPatient.SelectedRows.Count > 0)
            {
                int patientID = Convert.ToInt32(dataViewPatient.SelectedRows[0].Cells[0].Value);
                //Current user
                int staffID = 10000000;

                FormPrescriptionDetail formPD = new FormPrescriptionDetail(staffID, patientID);
                formPD.ShowDialog();
            }
        }

        //Add a new Prescription
        private void Prescription_Click(object sender, EventArgs e)
        {
            if (dataViewPatient.SelectedRows.Count > 0)
            { 
                int patientID = Convert.ToInt32(dataViewPatient.SelectedRows[0].Cells[0].Value);
                //Current user
                int staffID = 10000000;
            
                FormPrescriptionDetail formPD = new FormPrescriptionDetail(staffID,patientID);
                formPD.ShowDialog();
            }

        }
        //Add a new heath file
        private void buttonHealthFile_Click(object sender, EventArgs e)
        {
            if (dataViewPatient.SelectedRows.Count > 0)
            {
                int patientID = Convert.ToInt32(dataViewPatient.SelectedRows[0].Cells[0].Value);
                int state = Patient.GetPatient(patientID).State;

                if (state == 1)
                {
                    if (!HeathFile.DidPatientHaveHF(patientID))
                    {
                        FormHFDetail formHFD = new FormHFDetail(patientID);
                        formHFD.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Bệnh nhân đã có bệnh án", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Bệnh nhân chưa nhập viện", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }
        //Add a new heath note
        private void buttonHealthMonitor_Click(object sender, EventArgs e)
        {
            if (dataViewPatient.SelectedRows.Count > 0)
            {
                int patientID = Convert.ToInt32(dataViewPatient.SelectedRows[0].Cells[0].Value);
                int state = Patient.GetPatient(patientID).State;
                //Current user
                int staffID = loginStaff.StaffID;

                if (state == 1)
                {
                    FormHNDetail formHND = new FormHNDetail(staffID, patientID);
                    formHND.ShowDialog(); 
                }
                else
                {
                    MessageBox.Show("Bệnh nhân chưa nhập viện", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }
        //Add a new examination certificate
        private void buttonPatientExamination_Click(object sender, EventArgs e)
        {
            if (dataViewPatient.SelectedRows.Count > 0)
            {
                int patientID = Convert.ToInt32(dataViewPatient.SelectedRows[0].Cells[0].Value);
                //Current user
                int staffID = loginStaff.StaffID;

                FormECDetail formECD = new FormECDetail(staffID, patientID);
                formECD.ShowDialog();
            }

        }
        //Add a new hostpitalization certificate
        private void buttonHospitalizationCert_Click(object sender, EventArgs e)
        {
            if (dataViewPatient.SelectedRows.Count > 0)
            {
                int patientID = Convert.ToInt32(dataViewPatient.SelectedRows[0].Cells[0].Value);
                //Current user
                int staffID = loginStaff.StaffID;
                if (HospitalizationCertificate.IsPatientHadHC(patientID))
                {
                    MessageBox.Show("Bệnh nhân đã có giấy nhập viện", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    FormHCDetail formHCD = new FormHCDetail(staffID, patientID);
                    formHCD.ShowDialog();
                }
            }


        }
        //Add a new discharged certificate
        private void buttonDischargeCert_Click(object sender, EventArgs e)
        {
            if (dataViewPatient.SelectedRows.Count > 0)
            {
                int patientID = Convert.ToInt32(dataViewPatient.SelectedRows[0].Cells[0].Value);
                //Current user
                int staffID = loginStaff.StaffID;

                if (HospitalizationCertificate.IsPatientHadHC(patientID))
                {
                    FormDCDetail formDCD = new FormDCDetail(staffID, patientID);
                    formDCD.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Bệnh nhân chưa nhập viện", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        //Add a new surgical
        private void buttonPatientSurgery_Click(object sender, EventArgs e)
        {
            if (dataViewPatient.SelectedRows.Count > 0)
            {
                int patientID = Convert.ToInt32(dataViewPatient.SelectedRows[0].Cells[0].Value);

                if (Patient.GetPatient(patientID).State == 1)
                {
                    FormSurgicalDetail formSD = new FormSurgicalDetail(patientID);
                    formSD.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Bệnh nhân chưa nhập viện nên không thể thực hiện phẩu thuật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }
        //Add a new assignment
        private void buttonAssign_Click(object sender, EventArgs e)
        {
            if (dataViewPatient.SelectedRows.Count > 0)
            {
                int patientID = Convert.ToInt32(dataViewPatient.SelectedRows[0].Cells[0].Value);
                if (HospitalizationCertificate.IsPatientHadHC(patientID))
                {
                    if (Assignment.IsPatientHadAssignment(patientID))
                    {
                        MessageBox.Show("Bệnh nhân đã được phân công chăm sóc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        FormAssignDetail formAD = new FormAssignDetail(patientID);
                        formAD.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Bệnh nhân chưa nhập viện", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }
        //Add a new test certificate
        private void buttonPatientTest_Click(object sender, EventArgs e)
        {
            if (dataViewPatient.SelectedRows.Count > 0)
            {
                int patientID = Convert.ToInt32(dataViewPatient.SelectedRows[0].Cells[0].Value);
                //Current user
                int staffID = loginStaff.StaffID;

                FormTestDetail formTD = new FormTestDetail(staffID, patientID);
                formTD.ShowDialog();
            }

        }

        private void buttonPatientMaterial_Click(object sender, EventArgs e)
        {
            if (dataViewPatient.SelectedRows.Count > 0)
            {
                int patientID = Convert.ToInt32(dataViewPatient.SelectedRows[0].Cells[0].Value);
                if (Patient.GetPatient(patientID).State == 1)
                {
                    //Current user
                    int staffID = loginStaff.StaffID;

                    Bill newBill = new Bill(Bill.MATERIALBILL, patientID, staffID);
                    FormBillDetail billDetailForm = new FormBillDetail("insert", newBill);
                    billDetailForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Bệnh nhân chưa nhập viện nên không được phép mượn vật tư", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void buttonPatientService_Click(object sender, EventArgs e)
        {
            if (dataViewPatient.SelectedRows.Count > 0)
            {
                int patientID = Convert.ToInt32(dataViewPatient.SelectedRows[0].Cells[0].Value);
                //Current user
                int staffID = loginStaff.StaffID;

                Bill newBill = new Bill(Bill.SERVICEBILL, patientID, staffID);
                FormBillDetail billDetailForm = new FormBillDetail("insert", newBill);
                billDetailForm.ShowDialog();
            }
        }
        private void dataViewPatient_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataViewPatient.SelectedRows.Count > 0)
            {
                // Get patient for edit
                Patient PatientDetail = Patient.GetPatient(Convert.ToInt32(dataViewPatient.SelectedRows[0].Cells[0].Value.ToString()));

                // Open patientdetail form for edit
                FormPatientDetail patientDetailForm = new FormPatientDetail("edit", PatientDetail);
                patientDetailForm.ShowDialog();

                // Refresh datagridview after edit
                refreshDataViewPatient();
            }
        }
        //Add or update patient's HIC
        private void buttonHIC_Click(object sender, EventArgs e)
        {
            if (dataViewPatient.SelectedRows.Count > 0)
            {
                int patientID = Convert.ToInt32(dataViewPatient.SelectedRows[0].Cells[0].Value);
                if (HIC.CheckHIC(patientID))
                {
                    HIC newHIC = HIC.GetPatientHIC(patientID);
                    FormHICDetail formHICD = new FormHICDetail(newHIC, "edit");

                    formHICD.ShowDialog();
                }
                else
                {
                    FormHICDetail formHICD = new FormHICDetail(patientID);

                    formHICD.ShowDialog();
                }
            }
        }
    }
}
