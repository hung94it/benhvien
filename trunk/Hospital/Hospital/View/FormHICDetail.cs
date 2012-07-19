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
    public partial class FormHICDetail : Form
    {
        public HIC HICDetail { get; set; }
        public String UserAction { get; set; }
        public FormHICDetail()
        {
            InitializeComponent();
        }
        //This constructor for edit HIC 
        public FormHICDetail(HIC hicDetail, String userAction)
        {
            InitializeComponent();
            this.HICDetail = hicDetail;
            this.UserAction = userAction;
            SetHICDetail(hicDetail);
        }
        //this constructor for add HIC
        public FormHICDetail(int patientID)
        {
            InitializeComponent();
            textBoxPatientID.Text = patientID.ToString();
        }
        private void SetHICDetail(HIC hicDetail)
        {
            textBoxHICID.Text = hicDetail.HICID.ToString();
            textBoxPatientID.Text = hicDetail.PatientID.ToString();
            dateExpire.Value = hicDetail.ExpireDate;
            dateIssue.Value = hicDetail.IssueDate;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if(!superValidator1.Validate())
                return;
            int hicID = Convert.ToInt32(textBoxHICID.Text);
            int patientID = Convert.ToInt32(textBoxPatientID.Text);
            try
            {
                if (dateIssue.Value < dateExpire.Value)
                {
                    if (dateExpire.Value > DateTime.Today)
                    {
                        HIC newHIC=new HIC();
                        newHIC.HICID = hicID;
                        newHIC.PatientID = patientID;
                        newHIC.IssueDate = dateIssue.Value;
                        newHIC.ExpireDate = dateExpire.Value;
                        if (UserAction == "edit")
                        {
                            DialogResult dialogResult = MessageBox.Show("Xác nhận cập nhập thông tin bảo hiểm y tế", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (dialogResult == DialogResult.Yes)
                            {
                                HIC.DeleteHIC(HIC.GetPatientHIC(newHIC.PatientID).HICID);
                                if (HIC.InsertHIC(newHIC) > 0)
                                    MessageBox.Show("Cập nhập thông tin bảo hiểm y tế thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            if (HIC.InsertHIC(newHIC) > 0)
                                MessageBox.Show("Thêm bảo hiểm y tế thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Bảo hiểm y tế này đã hết hạn sử dụng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Ngày phát hành phải nhỏ hơn ngày hết hạn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Số bảo hiểm y tế này đã có người sử dụng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
