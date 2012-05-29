namespace Hospital.View
{
    partial class FormDatabase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDatabase));
            this.textBoxConnectionString = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelConnectionString = new DevComponents.DotNetBar.LabelX();
            this.buttonSave = new DevComponents.DotNetBar.ButtonX();
            this.buttonClose = new DevComponents.DotNetBar.ButtonX();
            this.buttonCheck = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // textBoxConnectionString
            // 
            // 
            // 
            // 
            this.textBoxConnectionString.Border.Class = "TextBoxBorder";
            this.textBoxConnectionString.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxConnectionString.Location = new System.Drawing.Point(12, 36);
            this.textBoxConnectionString.Name = "textBoxConnectionString";
            this.textBoxConnectionString.PasswordChar = '*';
            this.textBoxConnectionString.Size = new System.Drawing.Size(406, 20);
            this.textBoxConnectionString.TabIndex = 0;
            // 
            // labelConnectionString
            // 
            // 
            // 
            // 
            this.labelConnectionString.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelConnectionString.Location = new System.Drawing.Point(12, 12);
            this.labelConnectionString.Name = "labelConnectionString";
            this.labelConnectionString.Size = new System.Drawing.Size(101, 23);
            this.labelConnectionString.TabIndex = 1;
            this.labelConnectionString.Text = "Chuỗi kết nối";
            // 
            // buttonSave
            // 
            this.buttonSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonSave.Location = new System.Drawing.Point(262, 70);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Lưu";
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonClose.Location = new System.Drawing.Point(343, 70);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonClose.TabIndex = 3;
            this.buttonClose.Text = "Đóng";
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCheck
            // 
            this.buttonCheck.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonCheck.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonCheck.Location = new System.Drawing.Point(12, 70);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(75, 23);
            this.buttonCheck.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonCheck.TabIndex = 4;
            this.buttonCheck.Text = "Kiểm tra";
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // FormDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 105);
            this.ControlBox = false;
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelConnectionString);
            this.Controls.Add(this.textBoxConnectionString);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDatabase";
            this.Text = "Tùy chỉnh";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX textBoxConnectionString;
        private DevComponents.DotNetBar.LabelX labelConnectionString;
        private DevComponents.DotNetBar.ButtonX buttonSave;
        private DevComponents.DotNetBar.ButtonX buttonClose;
        private DevComponents.DotNetBar.ButtonX buttonCheck;
    }
}