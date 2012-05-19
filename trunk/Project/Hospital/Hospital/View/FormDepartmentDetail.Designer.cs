namespace Hospital.View
{
    partial class FormDepartmentDetail
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
            this.textBoxDepartmentID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelDepartmentID = new DevComponents.DotNetBar.LabelX();
            this.textBoxDepartmentName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelDepartmentName = new DevComponents.DotNetBar.LabelX();
            this.buttonClose = new DevComponents.DotNetBar.ButtonX();
            this.buttonOk = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // textBoxDepartmentID
            // 
            // 
            // 
            // 
            this.textBoxDepartmentID.Border.Class = "TextBoxBorder";
            this.textBoxDepartmentID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxDepartmentID.Location = new System.Drawing.Point(104, 12);
            this.textBoxDepartmentID.Name = "textBoxDepartmentID";
            this.textBoxDepartmentID.ReadOnly = true;
            this.textBoxDepartmentID.Size = new System.Drawing.Size(293, 20);
            this.textBoxDepartmentID.TabIndex = 29;
            // 
            // labelDepartmentID
            // 
            // 
            // 
            // 
            this.labelDepartmentID.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelDepartmentID.Location = new System.Drawing.Point(6, 9);
            this.labelDepartmentID.Name = "labelDepartmentID";
            this.labelDepartmentID.Size = new System.Drawing.Size(92, 23);
            this.labelDepartmentID.TabIndex = 27;
            this.labelDepartmentID.Text = "Mã phòng ban";
            // 
            // textBoxDepartmentName
            // 
            // 
            // 
            // 
            this.textBoxDepartmentName.Border.Class = "TextBoxBorder";
            this.textBoxDepartmentName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxDepartmentName.Location = new System.Drawing.Point(104, 38);
            this.textBoxDepartmentName.Name = "textBoxDepartmentName";
            this.textBoxDepartmentName.Size = new System.Drawing.Size(293, 20);
            this.textBoxDepartmentName.TabIndex = 26;
            // 
            // labelDepartmentName
            // 
            // 
            // 
            // 
            this.labelDepartmentName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelDepartmentName.Location = new System.Drawing.Point(6, 35);
            this.labelDepartmentName.Name = "labelDepartmentName";
            this.labelDepartmentName.Size = new System.Drawing.Size(92, 23);
            this.labelDepartmentName.TabIndex = 28;
            this.labelDepartmentName.Text = "Tên phòng ban";
            // 
            // buttonClose
            // 
            this.buttonClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonClose.Location = new System.Drawing.Point(316, 64);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonClose.TabIndex = 31;
            this.buttonClose.Text = "Đóng";
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonOk.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonOk.Location = new System.Drawing.Point(224, 64);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonOk.TabIndex = 30;
            this.buttonOk.Text = "Đồng ý";
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // FormDepartmentDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 91);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.textBoxDepartmentID);
            this.Controls.Add(this.labelDepartmentID);
            this.Controls.Add(this.textBoxDepartmentName);
            this.Controls.Add(this.labelDepartmentName);
            this.Name = "FormDepartmentDetail";
            this.Text = "FormDepartmentDetail";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX textBoxDepartmentID;
        private DevComponents.DotNetBar.LabelX labelDepartmentID;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxDepartmentName;
        private DevComponents.DotNetBar.LabelX labelDepartmentName;
        private DevComponents.DotNetBar.ButtonX buttonClose;
        private DevComponents.DotNetBar.ButtonX buttonOk;
    }
}