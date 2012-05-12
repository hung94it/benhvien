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
        private void tabItemPatient_GotFocus(object sender, EventArgs e)
        { }

        private void tabItemPatient_Click(object sender, EventArgs e)
        {
            refreshDataViewPatient();
        }

        private void dataViewPatient_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        { }

        private void buttonPatientAdd_Click(object sender, EventArgs e)
        {
            FormPatientDetail patientDetailForm = new FormPatientDetail("add", new Patient());
            patientDetailForm.ShowDialog();
            refreshDataViewPatient();
        }

        private void buttonPatientEdit_Click(object sender, EventArgs e)
        {
            Patient PatientDetail = Patient.GetPatient(Convert.ToInt32(dataViewPatient.SelectedRows[0].Cells[0].Value.ToString()));
            FormPatientDetail patientDetailForm = new FormPatientDetail("edit", PatientDetail);
            patientDetailForm.ShowDialog();
            refreshDataViewPatient();
        }

        private void buttonPatientDelete_Click(object sender, EventArgs e)
        {
            int patientID;
            if (int.TryParse(dataViewPatient.SelectedRows[0].Cells[0].Value.ToString(), out patientID))
                Patient.DeletePatient(patientID);
            else MessageBox.Show("Chọn bệnh nhân để xóa!");
            refreshDataViewPatient();
        }        

        private void buttonPatientSearchDelete_Click(object sender, EventArgs e)
        {
            textBoxPatientSearch.Text = "";
            searchPatient();
        }

        private void textBoxPatientSearch_TextChanged(object sender, EventArgs e)
        {
            searchPatient();
        }

        private void searchPatient()
        {
            if (textBoxPatientSearch.Text != "")
            {

                ((DataView)dataViewPatient.DataSource).RowFilter = "[Họ tên] LIKE '*" + textBoxPatientSearch.Text.Trim() + "*'"
                                                                + "OR [Mã bệnh nhân] LIKE '*" + textBoxPatientSearch.Text.Trim() + "*'"
                                                                + "OR [CMND] LIKE '*" + textBoxPatientSearch.Text.Trim() + "*'";
            }
            else
                ((DataView)dataViewPatient.DataSource).RowFilter = "";
        }

        private void refreshDataViewPatient()
        {
            try
            {
                dataViewPatient.DataSource = Patient.GetListPatient();

                for (int i = 0; i <= 9; i++)
                {
                    dataViewPatient.Columns[i].Visible = false;
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
