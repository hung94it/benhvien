namespace Hospital.View
{
    partial class FormRoleFunctionDetail
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
            this.textBoxFunctionID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelFunctionID = new DevComponents.DotNetBar.LabelX();
            this.textBoxFunctionName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelFunctionName = new DevComponents.DotNetBar.LabelX();
            this.labelFunctionButton = new DevComponents.DotNetBar.LabelX();
            this.textBoxButton = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.buttonClose = new DevComponents.DotNetBar.ButtonX();
            this.buttonOk = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // textBoxFunctionID
            // 
            // 
            // 
            // 
            this.textBoxFunctionID.Border.Class = "TextBoxBorder";
            this.textBoxFunctionID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxFunctionID.Location = new System.Drawing.Point(93, 12);
            this.textBoxFunctionID.Name = "textBoxFunctionID";
            this.textBoxFunctionID.ReadOnly = true;
            this.textBoxFunctionID.Size = new System.Drawing.Size(293, 20);
            this.textBoxFunctionID.TabIndex = 0;
            // 
            // labelFunctionID
            // 
            // 
            // 
            // 
            this.labelFunctionID.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelFunctionID.Location = new System.Drawing.Point(4, 9);
            this.labelFunctionID.Name = "labelFunctionID";
            this.labelFunctionID.Size = new System.Drawing.Size(92, 23);
            this.labelFunctionID.TabIndex = 27;
            this.labelFunctionID.Text = "Mã chức năng";
            // 
            // textBoxFunctionName
            // 
            // 
            // 
            // 
            this.textBoxFunctionName.Border.Class = "TextBoxBorder";
            this.textBoxFunctionName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxFunctionName.Location = new System.Drawing.Point(93, 38);
            this.textBoxFunctionName.Name = "textBoxFunctionName";
            this.textBoxFunctionName.Size = new System.Drawing.Size(293, 20);
            this.textBoxFunctionName.TabIndex = 1;
            // 
            // labelFunctionName
            // 
            // 
            // 
            // 
            this.labelFunctionName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelFunctionName.Location = new System.Drawing.Point(4, 35);
            this.labelFunctionName.Name = "labelFunctionName";
            this.labelFunctionName.Size = new System.Drawing.Size(92, 23);
            this.labelFunctionName.TabIndex = 28;
            this.labelFunctionName.Text = "Tên chức năng";
            // 
            // labelFunctionButton
            // 
            // 
            // 
            // 
            this.labelFunctionButton.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelFunctionButton.Location = new System.Drawing.Point(4, 61);
            this.labelFunctionButton.Name = "labelFunctionButton";
            this.labelFunctionButton.Size = new System.Drawing.Size(92, 23);
            this.labelFunctionButton.TabIndex = 28;
            this.labelFunctionButton.Text = "Nút";
            // 
            // textBoxButton
            // 
            // 
            // 
            // 
            this.textBoxButton.Border.Class = "TextBoxBorder";
            this.textBoxButton.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxButton.Location = new System.Drawing.Point(93, 64);
            this.textBoxButton.Name = "textBoxButton";
            this.textBoxButton.Size = new System.Drawing.Size(293, 20);
            this.textBoxButton.TabIndex = 2;
            // 
            // buttonClose
            // 
            this.buttonClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonClose.Location = new System.Drawing.Point(309, 90);
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
            this.buttonOk.Location = new System.Drawing.Point(217, 90);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonOk.TabIndex = 3;
            this.buttonOk.Text = "Đồng ý";
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // FormRoleFunctionDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 121);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.textBoxFunctionID);
            this.Controls.Add(this.labelFunctionID);
            this.Controls.Add(this.textBoxButton);
            this.Controls.Add(this.labelFunctionButton);
            this.Controls.Add(this.textBoxFunctionName);
            this.Controls.Add(this.labelFunctionName);
            this.Name = "FormRoleFunctionDetail";
            this.Text = "FormRoleFunctionDetail";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX textBoxFunctionID;
        private DevComponents.DotNetBar.LabelX labelFunctionID;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxFunctionName;
        private DevComponents.DotNetBar.LabelX labelFunctionName;
        private DevComponents.DotNetBar.LabelX labelFunctionButton;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxButton;
        private DevComponents.DotNetBar.ButtonX buttonClose;
        private DevComponents.DotNetBar.ButtonX buttonOk;
    }
}