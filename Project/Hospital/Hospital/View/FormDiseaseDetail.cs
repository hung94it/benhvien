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
    public partial class FormDiseaseDetail : Form
    {
        public Disease DiseaseDetail { get; set; }
        public String UserAction { get; set; }
        public FormDiseaseDetail()
        {
            InitializeComponent();
        }
        public FormDiseaseDetail(Disease diseaseDetail, String usertAction)
        {
            InitializeComponent();
            this.DiseaseDetail = diseaseDetail;
            this.UserAction = usertAction;
            if (this.UserAction == "edit")
                SetDiseaseDetail(diseaseDetail);
        }
        public void SetDiseaseDetail(Disease diseaseDetail)
        {
            textBoxDiseaseID.Text = diseaseDetail.DiseaseID.ToString();
            textBoxDiseaseName.Text = diseaseDetail.DiseaseName;
            textBoxDiseaseSymptom.Text = diseaseDetail.Symptom;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {

            if (!superValidator1.Validate())
                return;
                try
                {
                    if (UserAction == "edit")
                    {
                        DiseaseDetail.DiseaseName = textBoxDiseaseName.Text;
                        DiseaseDetail.Symptom = textBoxDiseaseSymptom.Text;
                        DialogResult dialogResult = MessageBox.Show("Bạn muốn cập nhập thông tin bệnh", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialogResult == DialogResult.Yes)
                        {
                            if (Disease.UpdateDisease(DiseaseDetail) > 0)
                                MessageBox.Show("Cập nhập thông tin bệnh thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                        }
                        
                    }
                    else
                    {
                        Disease newDisease = new Disease(0, textBoxDiseaseName.Text, textBoxDiseaseSymptom.Text);
                        if(Disease.InsertDisease(newDisease)>0)
                            MessageBox.Show("Thêm bệnh thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                }
                catch (SqlException exception)
                {
                    MessageBox.Show(exception.Message, "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
           
            this.Close();

        }
    }
}
