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
    public partial class FormDCDetail : Form
    {
        public DischargeCertificate DCDetail { get; set; }
        public String UserAction { get; set; }
        public FormDCDetail()
        {
            InitializeComponent();
        }
        //This constructor for insert feature
        public FormDCDetail(int staffID, int patientID)
        {
            InitializeComponent();
            SetDCForInsert(staffID, patientID);
        }
        //This constructor for update, confirm feature
        public FormDCDetail(DischargeCertificate dcDetail, String userAction)
        {
            InitializeComponent();
            this.DCDetail = dcDetail;
            this.UserAction = userAction;
            SetDCForUpdate(dcDetail);
        }
        private void SetDCForInsert(int staffID, int patientID)
        {
            textBoxPatientID.Text = patientID.ToString();
            textBoxStaffID.Text = staffID.ToString();
            dateDischarge.Value = DateTime.Today;
            comboBoxState.SelectedIndex = 0;
            dateDischarge.Enabled = false;
            comboBoxState.Enabled = false;
        }
        private void SetDCForUpdate(DischargeCertificate dcDetail)
        {
            textBoxDCID.Text = dcDetail.DCID.ToString();
            textBoxPatientID.Text = dcDetail.PatientID.ToString();
            textBoxStaffID.Text = dcDetail.StaffID.ToString();
            dateDischarge.Value = dcDetail.Date;
            comboBoxState.SelectedIndex = dcDetail.State;
            comboBoxState.Enabled = false;
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            try
            {
                DischargeCertificate newDC = new DischargeCertificate();
                newDC.PatientID = Convert.ToInt32(textBoxPatientID.Text);
                newDC.StaffID = Convert.ToInt32(textBoxStaffID.Text);
                newDC.Date = dateDischarge.Value;
                newDC.State = comboBoxState.SelectedIndex;
                if (UserAction == "edit")
                {
                    newDC.DCID = Convert.ToInt32(textBoxDCID.Text);
                    DialogResult dialogResult = MessageBox.Show("Xác nhận cập nhập thông tin giấy xuất viện", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult== DialogResult.Yes)
                    {
                        if (DischargeCertificate.UpdateDC(newDC) > 0)
                            MessageBox.Show("Cập nhập thông tin giấy xuất viện thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                    }
                }
                else
                {
                    if (DischargeCertificate.IsPatientHadDC(Convert.ToInt32(textBoxPatientID.Text)))
                    {
                         MessageBox.Show("Bệnh nhân đã có giấy xuất viện", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        newDC.DCID = 0;
                        if (DischargeCertificate.InsertDC(newDC) > 0)
                        MessageBox.Show("Thêm giấy xuất viện thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Lỗi dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }
    }
}
