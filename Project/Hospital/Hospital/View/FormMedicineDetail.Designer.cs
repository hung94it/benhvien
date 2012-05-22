namespace Hospital.View
{
    partial class FormMedicineDetail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonClose = new DevComponents.DotNetBar.ButtonX();
            this.buttonOk = new DevComponents.DotNetBar.ButtonX();
            this.textBoxQuantity = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelQuantity = new DevComponents.DotNetBar.LabelX();
            this.textBoxMedicineID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBoxPrice = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelMedicineID = new DevComponents.DotNetBar.LabelX();
            this.labelPrice = new DevComponents.DotNetBar.LabelX();
            this.textBoxMedicineName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelMedicineName = new DevComponents.DotNetBar.LabelX();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonClose.Location = new System.Drawing.Point(281, 116);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonClose.TabIndex = 5;
            this.buttonClose.Text = "Đóng";
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonOk.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonOk.Location = new System.Drawing.Point(189, 116);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonOk.TabIndex = 4;
            this.buttonOk.Text = "Đồng ý";
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // textBoxQuantity
            // 
            // 
            // 
            // 
            this.textBoxQuantity.Border.Class = "TextBoxBorder";
            this.textBoxQuantity.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxQuantity.Location = new System.Drawing.Point(64, 64);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(293, 20);
            this.textBoxQuantity.TabIndex = 2;
            // 
            // labelQuantity
            // 
            // 
            // 
            // 
            this.labelQuantity.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelQuantity.Location = new System.Drawing.Point(8, 61);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(92, 23);
            this.labelQuantity.TabIndex = 38;
            this.labelQuantity.Text = "Số lượng";
            // 
            // textBoxMedicineID
            // 
            // 
            // 
            // 
            this.textBoxMedicineID.Border.Class = "TextBoxBorder";
            this.textBoxMedicineID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxMedicineID.Location = new System.Drawing.Point(64, 12);
            this.textBoxMedicineID.Name = "textBoxMedicineID";
            this.textBoxMedicineID.ReadOnly = true;
            this.textBoxMedicineID.Size = new System.Drawing.Size(293, 20);
            this.textBoxMedicineID.TabIndex = 0;
            // 
            // textBoxPrice
            // 
            // 
            // 
            // 
            this.textBoxPrice.Border.Class = "TextBoxBorder";
            this.textBoxPrice.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxPrice.Location = new System.Drawing.Point(64, 90);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(293, 20);
            this.textBoxPrice.TabIndex = 3;
            // 
            // labelMedicineID
            // 
            // 
            // 
            // 
            this.labelMedicineID.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelMedicineID.Location = new System.Drawing.Point(8, 9);
            this.labelMedicineID.Name = "labelMedicineID";
            this.labelMedicineID.Size = new System.Drawing.Size(92, 23);
            this.labelMedicineID.TabIndex = 39;
            this.labelMedicineID.Text = "Mã thuốc";
            // 
            // labelPrice
            // 
            // 
            // 
            // 
            this.labelPrice.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelPrice.Location = new System.Drawing.Point(8, 87);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(92, 23);
            this.labelPrice.TabIndex = 41;
            this.labelPrice.Text = "Đơn giá";
            // 
            // textBoxMedicineName
            // 
            // 
            // 
            // 
            this.textBoxMedicineName.Border.Class = "TextBoxBorder";
            this.textBoxMedicineName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxMedicineName.Location = new System.Drawing.Point(64, 38);
            this.textBoxMedicineName.Name = "textBoxMedicineName";
            this.textBoxMedicineName.Size = new System.Drawing.Size(293, 20);
            this.textBoxMedicineName.TabIndex = 1;
            // 
            // labelMedicineName
            // 
            // 
            // 
            // 
            this.labelMedicineName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelMedicineName.Location = new System.Drawing.Point(8, 35);
            this.labelMedicineName.Name = "labelMedicineName";
            this.labelMedicineName.Size = new System.Drawing.Size(92, 23);
            this.labelMedicineName.TabIndex = 40;
            this.labelMedicineName.Text = "Tên thuốc";
            // 
            // FormMedicineDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 146);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.textBoxMedicineID);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.labelMedicineID);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.textBoxMedicineName);
            this.Controls.Add(this.labelMedicineName);
            this.Name = "FormMedicineDetail";
            this.Text = "FormMedicineDetail";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX buttonClose;
        private DevComponents.DotNetBar.ButtonX buttonOk;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxQuantity;
        private DevComponents.DotNetBar.LabelX labelQuantity;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxMedicineID;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxPrice;
        private DevComponents.DotNetBar.LabelX labelMedicineID;
        private DevComponents.DotNetBar.LabelX labelPrice;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxMedicineName;
        private DevComponents.DotNetBar.LabelX labelMedicineName;
    }
}