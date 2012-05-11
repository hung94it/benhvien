using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hospital.Model;
using System.Windows.Forms;

namespace Hospital.View
{
    public partial class FormMain
    {
        //internal Patient tempPatient;
        //internal string userAction;

        private void tabItemPatient_GotFocus(object sender, EventArgs e)
        {
            //refreshDataViewPatient();
        }

        private void tabItemPatient_Click(object sender, EventArgs e)
        {
            dataViewPatient.DataSource = Patient.GetListPatient();
        }

        private void dataViewPatient_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataViewPatient.Columns[e.ColumnIndex].Name.Equals("Giới tính"))
            {
                DataGridViewCell cell = dataViewPatient[e.ColumnIndex, e.RowIndex];
                //if (Convert.ToInt32(cell.Value) == Patient.GENDER_MALE)
                //{
                //    cell.ValueType = typeof(String);
                //    cell.Value = "Nam";
                //}
                //cell.Value = (object)"Nam";
                //else cell.Value = "Nữ";                
                //MessageBox.Show(cell.Value.ToString());
            }
        }

        private void buttonPatientAdd_Click(object sender, EventArgs e)
        {
            FormPatientDetail patientDetailForm = new FormPatientDetail();
            patientDetailForm.Action = "add";
            patientDetailForm.ShowDialog();
            refreshDataViewPatient();
        }

        private void buttonPatientEdit_Click(object sender, EventArgs e)
        {
            Patient tempPatient = Patient.GetPatient(Convert.ToInt32(dataViewPatient.SelectedRows[0].Cells[0].Value.ToString()));
            //MessageBox.Show(dataViewPatient.SelectedRows[0].Cells[0].Value.ToString());            
            FormPatientDetail patientDetailForm = new FormPatientDetail();
            patientDetailForm.Action = "edit";
            patientDetailForm.setPatientDetail(tempPatient);
            patientDetailForm.ShowDialog();
            refreshDataViewPatient();

        }

        private void buttonPatientDelete_Click(object sender, EventArgs e)
        {
            int patientID;
            if (int.TryParse(dataViewPatient.SelectedRows[0].Cells[0].Value.ToString(), out patientID))
                Patient.DeletePatient(patientID);
            else MessageBox.Show("Có lỗi gì đó");
            refreshDataViewPatient();
        }

        private void refreshDataViewPatient()
        {
            dataViewPatient.DataSource = Patient.GetListPatient();
        }
    }
}
