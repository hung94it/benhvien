namespace Hospital.View
{
    partial class FormServiceDetail
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
            this.textBoxServiceID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBoxPrice = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelServiceID = new DevComponents.DotNetBar.LabelX();
            this.labelPrice = new DevComponents.DotNetBar.LabelX();
            this.textBoxServiceName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelServiceName = new DevComponents.DotNetBar.LabelX();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonClose.Location = new System.Drawing.Point(289, 90);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonClose.TabIndex = 4;
            this.buttonClose.Text = "Đóng";
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonOk.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonOk.Location = new System.Drawing.Point(197, 90);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonOk.TabIndex = 3;
            this.buttonOk.Text = "Đồng ý";
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // textBoxServiceID
            // 
            // 
            // 
            // 
            this.textBoxServiceID.Border.Class = "TextBoxBorder";
            this.textBoxServiceID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxServiceID.Location = new System.Drawing.Point(72, 12);
            this.textBoxServiceID.Name = "textBoxServiceID";
            this.textBoxServiceID.ReadOnly = true;
            this.textBoxServiceID.Size = new System.Drawing.Size(293, 20);
            this.textBoxServiceID.TabIndex = 0;
            // 
            // textBoxPrice
            // 
            // 
            // 
            // 
            this.textBoxPrice.Border.Class = "TextBoxBorder";
            this.textBoxPrice.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxPrice.Location = new System.Drawing.Point(72, 64);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(293, 20);
            this.textBoxPrice.TabIndex = 2;
            // 
            // labelServiceID
            // 
            // 
            // 
            // 
            this.labelServiceID.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelServiceID.Location = new System.Drawing.Point(8, 9);
            this.labelServiceID.Name = "labelServiceID";
            this.labelServiceID.Size = new System.Drawing.Size(92, 23);
            this.labelServiceID.TabIndex = 49;
            this.labelServiceID.Text = "Mã dịch vụ";
            // 
            // labelPrice
            // 
            // 
            // 
            // 
            this.labelPrice.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelPrice.Location = new System.Drawing.Point(8, 61);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(92, 23);
            this.labelPrice.TabIndex = 51;
            this.labelPrice.Text = "Đơn giá";
            // 
            // textBoxServiceName
            // 
            // 
            // 
            // 
            this.textBoxServiceName.Border.Class = "TextBoxBorder";
            this.textBoxServiceName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxServiceName.Location = new System.Drawing.Point(72, 38);
            this.textBoxServiceName.Name = "textBoxServiceName";
            this.textBoxServiceName.Size = new System.Drawing.Size(293, 20);
            this.textBoxServiceName.TabIndex = 1;
            // 
            // labelServiceName
            // 
            // 
            // 
            // 
            this.labelServiceName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelServiceName.Location = new System.Drawing.Point(8, 35);
            this.labelServiceName.Name = "labelServiceName";
            this.labelServiceName.Size = new System.Drawing.Size(92, 23);
            this.labelServiceName.TabIndex = 50;
            this.labelServiceName.Text = "Tên dịch vụ";
            // 
            // FormServiceDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 119);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.textBoxServiceID);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.labelServiceID);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.textBoxServiceName);
            this.Controls.Add(this.labelServiceName);
            this.Name = "FormServiceDetail";
            this.Text = "FormServiceDetail";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX buttonClose;
        private DevComponents.DotNetBar.ButtonX buttonOk;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxServiceID;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxPrice;
        private DevComponents.DotNetBar.LabelX labelServiceID;
        private DevComponents.DotNetBar.LabelX labelPrice;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxServiceName;
        private DevComponents.DotNetBar.LabelX labelServiceName;
    }
}