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
    public partial class FormECDetail : Form
    {
        public ExaminationCertificate ECDetail { get; set; }
        public String UserAction { get; set; }
        
        public FormECDetail()
        {
            InitializeComponent();
        }
        public FormECDetail(ExaminationCertificate ecDetail, String userAction)
        {
            InitializeComponent();
            this.ECDetail = ecDetail;
            this.UserAction = userAction;
            if (this.UserAction == "edit")
                SetECDetail(ecDetail);
            else
            {
                SetECDetail(ecDetail);
                dateCreate.Enabled = false;
                comboBoxState.Enabled = false;
            }
        }
        private void SetECDetail(ExaminationCertificate ecDetail)
        {
            textBoxECID.Text = ecDetail.ECID.ToString();;
            textBoxPatientID.Text = ecDetail.PatientID.ToString();
            textBoxStaffID.Text = ecDetail.StaffID.ToString();
            dateCreate.Value = ecDetail.Date;
            textBoxResult.Text = ecDetail.Result;
            comboBoxState.SelectedIndex = ecDetail.State;
        }
        private void buttonClose_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void buttonOk_Click(object sender, System.EventArgs e)
        {
            try
            {
                
                if (textBoxResult.Text != "")
                {
                    if (UserAction.Equals("edit"))
                    {
                        ExaminationCertificate newEC = new ExaminationCertificate();
                        newEC = this.ECDetail;
                        newEC.Result = textBoxResult.Text;
                        newEC.State = comboBoxState.SelectedIndex;
                        newEC.Date = dateCreate.Value;
                        if (newEC.State == 1 && comboBoxState.SelectedIndex != 1)
                        {
                            if (ExaminationCertificate.UpdateEC(newEC) > 0)
                                MessageBox.Show("Cập nhập thông tin phiếu khám bệnh thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                        }
                        else
                        {
                            MessageBox.Show("Không được phép cập nhập trạng thái khi phiếu đã được xác nhận", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        
                    }
                    else
                    {
                        ExaminationCertificate newEC = new ExaminationCertificate();
                        newEC = this.ECDetail;
                        newEC.Result = textBoxResult.Text;
                        newEC.State = 1;
                        if(ExaminationCertificate.UpdateEC(newEC)>0)
                            MessageBox.Show("Cập nhập kết quả khám bệnh thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                }
                else
                {
                    MessageBox.Show("Thiếu thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);   
                }
                
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message, "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
