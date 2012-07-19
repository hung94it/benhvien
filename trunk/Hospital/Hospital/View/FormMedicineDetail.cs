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
    public partial class FormMedicineDetail : Form
    {
        public Medicine MedicineDetail { get; set; }
        public String UserAction { get; set; }
        public FormMedicineDetail()
        {
            InitializeComponent();
        }
        public FormMedicineDetail(Medicine medicineDetail, String userAction)
        {
            InitializeComponent();
            this.MedicineDetail = medicineDetail;
            this.UserAction = userAction;
            if (this.UserAction == "edit")
                SetMedicineDetail(medicineDetail);
        }
        private void SetMedicineDetail(Medicine medicineDetail)
        {
            textBoxMedicineID.Text = medicineDetail.MedicineID.ToString();
            textBoxMedicineName.Text = medicineDetail.MedicineName;
            textBoxQuantity.Text = medicineDetail.Quantity.ToString();
            textBoxPrice.Text = Convert.ToInt64(medicineDetail.Price).ToString();
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
                        MedicineDetail.MedicineName = textBoxMedicineName.Text;
                        MedicineDetail.Quantity = int.Parse(textBoxQuantity.Text);
                        MedicineDetail.Price = decimal.Parse(textBoxPrice.Text);
                        DialogResult dialogResult = MessageBox.Show("Xác nhận cập nhập thông tin thuốc", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialogResult == DialogResult.Yes)
                        {
                            if (Medicine.UpdateMedicine(MedicineDetail) > 0)
                                MessageBox.Show("Cập nhập thông tin thuốc thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        
                    }
                    else
                    {
                        Medicine newMedicine = new Medicine(0, textBoxMedicineName.Text, int.Parse(textBoxQuantity.Text), decimal.Parse(textBoxPrice.Text));
                        if (Medicine.InsertMedicine(newMedicine) > 0)
                            MessageBox.Show("Thêm thuốc thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
