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
    public partial class FormMajorDetail : Form
    {
        public Major MajorDetail { get; set; }
        public String UserAction { get; set; }
        public FormMajorDetail()
        {
            InitializeComponent();
        }
        public FormMajorDetail(Major majorDetail, String userAction)
        {
            InitializeComponent();
            this.MajorDetail = majorDetail;
            this.UserAction = userAction;
            SetMajorDetail(majorDetail);
        }
        private void SetMajorDetail(Major majorDetail)
        {
            textBoxMajorID.Text = majorDetail.MajorID.ToString();
            textBoxMajorName.Text = majorDetail.MajorName;
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if(!superValidator1.Validate())
                return;
            try
            {
                Major newMajor = new Major();
                
                newMajor.MajorName = textBoxMajorName.Text;
                if (UserAction == "edit")
                {
                    newMajor.MajorID = Convert.ToInt32(textBoxMajorID.Text);
                    DialogResult dialogResult = MessageBox.Show("Xác nhận cập nhập thông tin chuyên ngành", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (Major.UpdateMajor(newMajor) > 0)
                            MessageBox.Show("Cập nhập thông tin chuyên ngành thành công thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    newMajor.MajorID = 0;
                    if (Major.InsertMajor(newMajor) > 0)
                        MessageBox.Show("Thêm phòng khoa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
