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
    public partial class FormMaterialDetail : Form
    {
        public Material MaterialDetail { get; set; }
        public String UserAction { get; set; }
        public FormMaterialDetail()
        {
            InitializeComponent();
        }
        public FormMaterialDetail(Material materialDetail, String userAction)
        {
            InitializeComponent();
            this.MaterialDetail = materialDetail;
            this.UserAction = userAction;
            if (this.UserAction == "edit")
                SetMaterialDetail(materialDetail);
        }
        private void SetMaterialDetail(Material materialDetail)
        {
            textBoxMaterialID.Text = materialDetail.MaterialID.ToString();
            textBoxMaterialName.Text = materialDetail.MaterialName;
            textBoxQuantity.Text = materialDetail.Quantity.ToString();
            textBoxPrice.Text = materialDetail.Price.ToString();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (textBoxMaterialName.Text != "" && textBoxQuantity.Text!="" && textBoxPrice.Text!="")
            {
                try
                {
                    if (UserAction == "edit")
                    {
                        MaterialDetail.MaterialName = textBoxMaterialName.Text;
                        MaterialDetail.Quantity = int.Parse(textBoxQuantity.Text);
                        MaterialDetail.Price = decimal.Parse(textBoxPrice.Text);
                        if (Material.UpdateMaterial(MaterialDetail) > 0)
                            MessageBox.Show("Cập nhập vật tư thành công thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                    else
                    {
                        Material newMaterial = new Material(0, textBoxMaterialName.Text, int.Parse(textBoxQuantity.Text), decimal.Parse(textBoxPrice.Text));
                        if (Material.InsertMaterial(newMaterial) > 0)
                            MessageBox.Show("Thêm vật tư thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                }
                catch (SqlException exception)
                {
                    MessageBox.Show(exception.Message, "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
