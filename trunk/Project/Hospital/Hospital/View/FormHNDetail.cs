using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Hospital.Model;

namespace Hospital.View
{
    public partial class FormHNDetail : Form
    {
        public HeathMonitoringNote HNDetail { get; set; }
        public String UserAction { get; set; }
        public FormHNDetail()
        {
            InitializeComponent();
        }
        //This constructor for Heath Note Management feature
        public FormHNDetail(int staffID)
        {
            InitializeComponent();
            textBoxStaffID.Text = staffID.ToString();
            SetAutoComplete();
        }
        //This contructor for Patient Management future
        public FormHNDetail(int staffID, int patientID)
        {
            InitializeComponent();
            textBoxStaffID.Text = staffID.ToString();
            textBoxPatientID.Text = patientID.ToString();
            dateCreate.Value = DateTime.Today;
            dateCreate.Enabled = false;
        }
        //This constructor for update in Heath Note Management
        public FormHNDetail(HeathMonitoringNote hnDetail, String userAction)
        {
            InitializeComponent();
            this.UserAction = userAction;

            textBoxHNID.Text = hnDetail.HNID.ToString();
            textBoxPatientID.Text = hnDetail.PatientID.ToString();
            textBoxStaffID.Text = hnDetail.StaffID.ToString();
            dateCreate.Value = hnDetail.Date;
            textBoxPatientState.Text = hnDetail.PatientState;
            textBoxBloodPressure.Text = hnDetail.BloodPressure;
            textBoxWeight.Text = hnDetail.Weight;
        }

        private void SetAutoComplete()
        {
            DataTable dtPatientID = Patient.GetListPatientID();
            for (int i = 0; i < dtPatientID.Rows.Count; i++)
            {
                textBoxPatientID.AutoCompleteCustomSource.Add(dtPatientID.Rows[i][0].ToString());
            }
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOk_Click(object sender, System.EventArgs e)
        {
            if(!superValidator1.Validate())
            return;
                if (Patient.IsPatientExist(int.Parse(textBoxPatientID.Text)))
                {
                    try
                    {
                        if (UserAction == "edit")
                        {
                            HeathMonitoringNote newHN = new HeathMonitoringNote();
                            newHN.HNID = int.Parse(textBoxHNID.Text);
                            newHN.PatientID = int.Parse(textBoxPatientID.Text);
                            newHN.StaffID = int.Parse(textBoxStaffID.Text);
                            newHN.PatientState = textBoxPatientState.Text;
                            newHN.Weight = textBoxWeight.Text;
                            newHN.BloodPressure = textBoxBloodPressure.Text;
                            newHN.Date = dateCreate.Value;
                            DialogResult dialogResult = MessageBox.Show("Xác nhận cập nhập thông tin phiếu theo dõi sức khỏe", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (dialogResult == DialogResult.Yes)
                            {
                                if (HeathMonitoringNote.UpdateHN(newHN) > 0)
                                    MessageBox.Show("Cập nhập thông tin phiếu theo dõi sức khỏe thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            
                        }
                        else
                        {
                            HeathMonitoringNote newHN = new HeathMonitoringNote();
                            newHN.HNID = 0;
                            newHN.PatientID = int.Parse(textBoxPatientID.Text);
                            newHN.StaffID = int.Parse(textBoxStaffID.Text);
                            newHN.PatientState = textBoxPatientState.Text;
                            newHN.Weight = textBoxWeight.Text;
                            newHN.BloodPressure = textBoxBloodPressure.Text;
                            newHN.Date = dateCreate.Value;
                            if(HeathMonitoringNote.InsertHN(newHN)>0)
                                MessageBox.Show("Thêm phiếu theo dõi sức khỏe thành công thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Lỗi dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                
                this.Close();
            }
            else
            {
                MessageBox.Show("Thiếu thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
    }
}
