namespace Hospital.View
{
    partial class FormRoleDetail
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
            this.textBoxRoleID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelRoleID = new DevComponents.DotNetBar.LabelX();
            this.textBoxRoleName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelRoleName = new DevComponents.DotNetBar.LabelX();
            this.listBoxCurrentFunction = new System.Windows.Forms.ListBox();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.listBoxSystemFunction = new System.Windows.Forms.ListBox();
            this.buttonClose = new DevComponents.DotNetBar.ButtonX();
            this.buttonOk = new DevComponents.DotNetBar.ButtonX();
            this.buttonRemoveFunction = new DevComponents.DotNetBar.ButtonX();
            this.buttonInsertFunction = new DevComponents.DotNetBar.ButtonX();
            this.listBoxCurrentFunctionID = new System.Windows.Forms.ListBox();
            this.listBoxSystemFunctionID = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBoxRoleID
            // 
            // 
            // 
            // 
            this.textBoxRoleID.Border.Class = "TextBoxBorder";
            this.textBoxRoleID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxRoleID.Location = new System.Drawing.Point(103, 12);
            this.textBoxRoleID.Name = "textBoxRoleID";
            this.textBoxRoleID.ReadOnly = true;
            this.textBoxRoleID.Size = new System.Drawing.Size(293, 20);
            this.textBoxRoleID.TabIndex = 25;
            // 
            // labelRoleID
            // 
            // 
            // 
            // 
            this.labelRoleID.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelRoleID.Location = new System.Drawing.Point(5, 9);
            this.labelRoleID.Name = "labelRoleID";
            this.labelRoleID.Size = new System.Drawing.Size(92, 23);
            this.labelRoleID.TabIndex = 23;
            this.labelRoleID.Text = "Mã phân quyền";
            // 
            // textBoxRoleName
            // 
            // 
            // 
            // 
            this.textBoxRoleName.Border.Class = "TextBoxBorder";
            this.textBoxRoleName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxRoleName.Location = new System.Drawing.Point(103, 38);
            this.textBoxRoleName.Name = "textBoxRoleName";
            this.textBoxRoleName.Size = new System.Drawing.Size(293, 20);
            this.textBoxRoleName.TabIndex = 22;
            // 
            // labelRoleName
            // 
            // 
            // 
            // 
            this.labelRoleName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelRoleName.Location = new System.Drawing.Point(5, 35);
            this.labelRoleName.Name = "labelRoleName";
            this.labelRoleName.Size = new System.Drawing.Size(92, 23);
            this.labelRoleName.TabIndex = 24;
            this.labelRoleName.Text = "Tên phân quyền";
            // 
            // listBoxCurrentFunction
            // 
            this.listBoxCurrentFunction.Enabled = false;
            this.listBoxCurrentFunction.FormattingEnabled = true;
            this.listBoxCurrentFunction.Location = new System.Drawing.Point(12, 103);
            this.listBoxCurrentFunction.Name = "listBoxCurrentFunction";
            this.listBoxCurrentFunction.Size = new System.Drawing.Size(165, 212);
            this.listBoxCurrentFunction.TabIndex = 26;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(12, 74);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(116, 23);
            this.labelX1.TabIndex = 24;
            this.labelX1.Text = "Các chức năng hiện có";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(226, 74);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(145, 23);
            this.labelX2.TabIndex = 24;
            this.labelX2.Text = "Các chức năng của hệ thống";
            // 
            // listBoxSystemFunction
            // 
            this.listBoxSystemFunction.Enabled = false;
            this.listBoxSystemFunction.FormattingEnabled = true;
            this.listBoxSystemFunction.Location = new System.Drawing.Point(226, 103);
            this.listBoxSystemFunction.Name = "listBoxSystemFunction";
            this.listBoxSystemFunction.Size = new System.Drawing.Size(170, 212);
            this.listBoxSystemFunction.TabIndex = 26;
            // 
            // buttonClose
            // 
            this.buttonClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonClose.Location = new System.Drawing.Point(321, 335);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonClose.TabIndex = 28;
            this.buttonClose.Text = "Đóng";
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonOk.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonOk.Location = new System.Drawing.Point(229, 335);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonOk.TabIndex = 27;
            this.buttonOk.Text = "Đồng ý";
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonRemoveFunction
            // 
            this.buttonRemoveFunction.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonRemoveFunction.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonRemoveFunction.Enabled = false;
            this.buttonRemoveFunction.Location = new System.Drawing.Point(183, 185);
            this.buttonRemoveFunction.Name = "buttonRemoveFunction";
            this.buttonRemoveFunction.Size = new System.Drawing.Size(37, 23);
            this.buttonRemoveFunction.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonRemoveFunction.TabIndex = 27;
            this.buttonRemoveFunction.Text = ">";
            this.buttonRemoveFunction.Click += new System.EventHandler(this.buttonRemoveFunction_Click);
            // 
            // buttonInsertFunction
            // 
            this.buttonInsertFunction.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonInsertFunction.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonInsertFunction.Enabled = false;
            this.buttonInsertFunction.Location = new System.Drawing.Point(183, 214);
            this.buttonInsertFunction.Name = "buttonInsertFunction";
            this.buttonInsertFunction.Size = new System.Drawing.Size(37, 23);
            this.buttonInsertFunction.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonInsertFunction.TabIndex = 27;
            this.buttonInsertFunction.Text = "<";
            this.buttonInsertFunction.Click += new System.EventHandler(this.buttonInsertFunction_Click);
            // 
            // listBoxCurrentFunctionID
            // 
            this.listBoxCurrentFunctionID.FormattingEnabled = true;
            this.listBoxCurrentFunctionID.Location = new System.Drawing.Point(12, 335);
            this.listBoxCurrentFunctionID.Name = "listBoxCurrentFunctionID";
            this.listBoxCurrentFunctionID.Size = new System.Drawing.Size(31, 30);
            this.listBoxCurrentFunctionID.TabIndex = 29;
            this.listBoxCurrentFunctionID.Visible = false;
            // 
            // listBoxSystemFunctionID
            // 
            this.listBoxSystemFunctionID.FormattingEnabled = true;
            this.listBoxSystemFunctionID.Location = new System.Drawing.Point(49, 335);
            this.listBoxSystemFunctionID.Name = "listBoxSystemFunctionID";
            this.listBoxSystemFunctionID.Size = new System.Drawing.Size(31, 30);
            this.listBoxSystemFunctionID.TabIndex = 29;
            this.listBoxSystemFunctionID.Visible = false;
            // 
            // FormRoleDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 370);
            this.Controls.Add(this.listBoxSystemFunctionID);
            this.Controls.Add(this.listBoxCurrentFunctionID);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonInsertFunction);
            this.Controls.Add(this.buttonRemoveFunction);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.listBoxSystemFunction);
            this.Controls.Add(this.listBoxCurrentFunction);
            this.Controls.Add(this.textBoxRoleID);
            this.Controls.Add(this.labelRoleID);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.textBoxRoleName);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.labelRoleName);
            this.Name = "FormRoleDetail";
            this.Text = "FormRole";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX textBoxRoleID;
        private DevComponents.DotNetBar.LabelX labelRoleID;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxRoleName;
        private DevComponents.DotNetBar.LabelX labelRoleName;
        private System.Windows.Forms.ListBox listBoxCurrentFunction;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private System.Windows.Forms.ListBox listBoxSystemFunction;
        private DevComponents.DotNetBar.ButtonX buttonClose;
        private DevComponents.DotNetBar.ButtonX buttonOk;
        private DevComponents.DotNetBar.ButtonX buttonRemoveFunction;
        private DevComponents.DotNetBar.ButtonX buttonInsertFunction;
        private System.Windows.Forms.ListBox listBoxCurrentFunctionID;
        private System.Windows.Forms.ListBox listBoxSystemFunctionID;


    }
}