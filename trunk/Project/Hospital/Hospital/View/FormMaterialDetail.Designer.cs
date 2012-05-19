namespace Hospital.View
{
    partial class FormMaterialDetail
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
            this.textBoxMaterialID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelMaterialID = new DevComponents.DotNetBar.LabelX();
            this.textBoxMaterialName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelMaterialName = new DevComponents.DotNetBar.LabelX();
            this.labelPrice = new DevComponents.DotNetBar.LabelX();
            this.textBoxPrice = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelQuantity = new DevComponents.DotNetBar.LabelX();
            this.textBoxQuantity = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.buttonClose = new DevComponents.DotNetBar.ButtonX();
            this.buttonOk = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // textBoxMaterialID
            // 
            // 
            // 
            // 
            this.textBoxMaterialID.Border.Class = "TextBoxBorder";
            this.textBoxMaterialID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxMaterialID.Location = new System.Drawing.Point(109, 12);
            this.textBoxMaterialID.Name = "textBoxMaterialID";
            this.textBoxMaterialID.ReadOnly = true;
            this.textBoxMaterialID.Size = new System.Drawing.Size(293, 20);
            this.textBoxMaterialID.TabIndex = 33;
            // 
            // labelMaterialID
            // 
            // 
            // 
            // 
            this.labelMaterialID.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelMaterialID.Location = new System.Drawing.Point(11, 9);
            this.labelMaterialID.Name = "labelMaterialID";
            this.labelMaterialID.Size = new System.Drawing.Size(92, 23);
            this.labelMaterialID.TabIndex = 31;
            this.labelMaterialID.Text = "Mã vật tư";
            // 
            // textBoxMaterialName
            // 
            // 
            // 
            // 
            this.textBoxMaterialName.Border.Class = "TextBoxBorder";
            this.textBoxMaterialName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxMaterialName.Location = new System.Drawing.Point(109, 38);
            this.textBoxMaterialName.Name = "textBoxMaterialName";
            this.textBoxMaterialName.Size = new System.Drawing.Size(293, 20);
            this.textBoxMaterialName.TabIndex = 30;
            // 
            // labelMaterialName
            // 
            // 
            // 
            // 
            this.labelMaterialName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelMaterialName.Location = new System.Drawing.Point(11, 35);
            this.labelMaterialName.Name = "labelMaterialName";
            this.labelMaterialName.Size = new System.Drawing.Size(92, 23);
            this.labelMaterialName.TabIndex = 32;
            this.labelMaterialName.Text = "Tên vật tư";
            // 
            // labelPrice
            // 
            // 
            // 
            // 
            this.labelPrice.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelPrice.Location = new System.Drawing.Point(11, 87);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(92, 23);
            this.labelPrice.TabIndex = 32;
            this.labelPrice.Text = "Đơn giá";
            // 
            // textBoxPrice
            // 
            // 
            // 
            // 
            this.textBoxPrice.Border.Class = "TextBoxBorder";
            this.textBoxPrice.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxPrice.Location = new System.Drawing.Point(109, 90);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(293, 20);
            this.textBoxPrice.TabIndex = 30;
            // 
            // labelQuantity
            // 
            // 
            // 
            // 
            this.labelQuantity.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelQuantity.Location = new System.Drawing.Point(11, 61);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(92, 23);
            this.labelQuantity.TabIndex = 31;
            this.labelQuantity.Text = "Số lượng";
            // 
            // textBoxQuantity
            // 
            // 
            // 
            // 
            this.textBoxQuantity.Border.Class = "TextBoxBorder";
            this.textBoxQuantity.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxQuantity.Location = new System.Drawing.Point(109, 64);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(293, 20);
            this.textBoxQuantity.TabIndex = 33;
            // 
            // buttonClose
            // 
            this.buttonClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonClose.Location = new System.Drawing.Point(326, 116);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonClose.TabIndex = 35;
            this.buttonClose.Text = "Đóng";
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonOk.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonOk.Location = new System.Drawing.Point(234, 116);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonOk.TabIndex = 34;
            this.buttonOk.Text = "Đồng ý";
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // FormMaterialDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 146);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.textBoxMaterialID);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.labelMaterialID);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.textBoxMaterialName);
            this.Controls.Add(this.labelMaterialName);
            this.Name = "FormMaterialDetail";
            this.Text = "FormMaterialDetail";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX textBoxMaterialID;
        private DevComponents.DotNetBar.LabelX labelMaterialID;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxMaterialName;
        private DevComponents.DotNetBar.LabelX labelMaterialName;
        private DevComponents.DotNetBar.LabelX labelPrice;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxPrice;
        private DevComponents.DotNetBar.LabelX labelQuantity;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxQuantity;
        private DevComponents.DotNetBar.ButtonX buttonClose;
        private DevComponents.DotNetBar.ButtonX buttonOk;
    }
}