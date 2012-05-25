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
    public partial class FormHostpitalBedDetail : Form
    {
        public HospitalBed HBDetail { get; set; }
        public FormHostpitalBedDetail()
        {
            InitializeComponent();
        }
        public FormHostpitalBedDetail(HospitalBed hbDetail)
        {
            InitializeComponent();
            HBDetail = hbDetail;
            SetHospitalBedDetail(hbDetail);
        }
        private void SetHospitalBedDetail(HospitalBed hbDetail)
        {
            textBoxHospitalBedID.Text = hbDetail.BedID.ToString();
            textBoxPatientID.Text = hbDetail.Patient.ToString();
            if (hbDetail.State == 0)
                comboBoxState.SelectedIndex = 0;
            else
                comboBoxState.SelectedIndex = 1;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (!superValidator1.Validate())
                return;
                HBDetail.Patient = int.Parse(textBoxPatientID.Text);
                String str = comboBoxState.Items[comboBoxState.SelectedIndex].ToString();
                HBDetail.State = 1;
                if (Patient.IsPatientExist(HBDetail.Patient))
                {
                    try
                    {
                        if (HospitalBed.UpdateHospitalBed(HBDetail) > 0)
                            MessageBox.Show("Nhận giường thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
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
            this.Close();
        }
    }
}
