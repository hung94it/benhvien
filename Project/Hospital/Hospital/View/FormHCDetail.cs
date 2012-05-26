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
    public partial class FormHCDetail : Form
    {
        public HospitalizationCertificate HCDetail { get; set; }
        public String UserAction { get; set; }
        //This constructor uses for insert HC in HospitalizationManagement
        public FormHCDetail()
        {
            InitializeComponent();
            SetHCDetail();
        }
        //This constructor uses for insert HC in PatientManagement
        public FormHCDetail(int patientID)
        {
            InitializeComponent();
            SetHCDetail(patientID);
        }
        public FormHCDetail(HospitalizationCertificate hcDetail, String userAction)
        {
            InitializeComponent();
            this.HCDetail = hcDetail;
            this.UserAction = userAction;
            SetHCDetail(hcDetail);
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void SetHCDetail()
        { 
            comboBoxState.Enabled = false;
            comboBoxState.SelectedIndex = 0;
            //Need a function to get current user
            textBoxStaffID.Text = 10000000.ToString();
            
            dateHospitalizate.Enabled = false;
            dateHospitalizate.Text = DateTime.Now.ToShortDateString();

            SetAutoComplete();
        }
        private void SetHCDetail(HospitalizationCertificate hcDetail)
        {
            textBoxHCID.Text = hcDetail.HCID.ToString();
            textBoxStaffID.Text = hcDetail.StaffID.ToString();
            textBoxPatientID.Text = hcDetail.PatientID.ToString();
            textBoxPatientID.ReadOnly = true;
            textBoxReason.Text = hcDetail.Reason;
            dateHospitalizate.Value = hcDetail.Date;
            comboBoxState.SelectedIndex = hcDetail.State;

        }
        private void SetHCDetail(int patientID)
        {
            textBoxPatientID.Text = patientID.ToString();
            textBoxPatientID.ReadOnly = true;
            comboBoxState.Enabled = false;
            comboBoxState.SelectedIndex = 0;
            textBoxStaffID.Text = 10000000.ToString();

            dateHospitalizate.Enabled = false;
            dateHospitalizate.Text = DateTime.Now.ToShortDateString();

            SetAutoComplete();
        }
        private void SetAutoComplete()
        {
            DataTable dtPatientID = Patient.GetListPatientID();
            for (int i = 0; i < dtPatientID.Rows.Count; i++)
            {
                textBoxPatientID.AutoCompleteCustomSource.Add(dtPatientID.Rows[i][0].ToString());
            }
        }
        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (textBoxPatientID.Text != "" && textBoxReason.Text != "")
            {
                if (Patient.IsPatientExist(int.Parse(textBoxPatientID.Text)))
                {
                    try
                    {
                        if (UserAction == "edit")
                        {
                            HospitalizationCertificate newHC = new HospitalizationCertificate();
                            newHC.HCID = int.Parse(textBoxHCID.Text);
                            newHC.PatientID = int.Parse(textBoxPatientID.Text);
                            newHC.StaffID = int.Parse(textBoxStaffID.Text);
                            newHC.Reason = textBoxReason.Text;
                            newHC.State = (int)comboBoxState.SelectedIndex;
                            newHC.Date = dateHospitalizate.Value;
                            if (HospitalizationCertificate.UpdateHC(newHC) > 0)
                                MessageBox.Show("Cập nhập thông tin giấy nhập viện thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                        }
                        else
                        {
                            if (HospitalizationCertificate.IsPatientHadHC(int.Parse(textBoxPatientID.Text)))
                            {
                                MessageBox.Show("Bệnh nhân đã có giấy nhập viện", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                HospitalizationCertificate newHC = new HospitalizationCertificate();
                                newHC.HCID = 0;
                                newHC.PatientID = int.Parse(textBoxPatientID.Text);
                                newHC.StaffID = int.Parse(textBoxStaffID.Text);
                                newHC.Reason = textBoxReason.Text;
                                newHC.State = 0;
                                newHC.Date = dateHospitalizate.Value;
                                if (HospitalizationCertificate.InsertHC(newHC) > 0)
                                    MessageBox.Show("Thêm giấy nhập viện thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                            }
                        } 
                    }
                    catch (SqlException exception)
                    {
                        MessageBox.Show(exception.Message, "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
                else
                {
                    MessageBox.Show("Bệnh nhân không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Thiếu thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            this.Close();
        }
    }
}
