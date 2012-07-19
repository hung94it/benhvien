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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRoleDetail));
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.listBoxSystemFunctionID = new System.Windows.Forms.ListBox();
            this.listBoxCurrentFunctionID = new System.Windows.Forms.ListBox();
            this.buttonClose = new DevComponents.DotNetBar.ButtonX();
            this.buttonInsertFunction = new DevComponents.DotNetBar.ButtonX();
            this.buttonRemoveFunction = new DevComponents.DotNetBar.ButtonX();
            this.buttonOk = new DevComponents.DotNetBar.ButtonX();
            this.listBoxSystemFunction = new System.Windows.Forms.ListBox();
            this.listBoxCurrentFunction = new System.Windows.Forms.ListBox();
            this.textBoxRoleID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelRoleID = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.textBoxRoleName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelRoleName = new DevComponents.DotNetBar.LabelX();
            this.superValidator1 = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.requiredFieldValidator1 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Nhập tên phân quyền");
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.highlighter1 = new DevComponents.DotNetBar.Validator.Highlighter();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.listBoxSystemFunctionID);
            this.groupPanel1.Controls.Add(this.listBoxCurrentFunctionID);
            this.groupPanel1.Controls.Add(this.buttonClose);
            this.groupPanel1.Controls.Add(this.buttonInsertFunction);
            this.groupPanel1.Controls.Add(this.buttonRemoveFunction);
            this.groupPanel1.Controls.Add(this.buttonOk);
            this.groupPanel1.Controls.Add(this.listBoxSystemFunction);
            this.groupPanel1.Controls.Add(this.listBoxCurrentFunction);
            this.groupPanel1.Controls.Add(this.textBoxRoleID);
            this.groupPanel1.Controls.Add(this.labelRoleID);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Controls.Add(this.textBoxRoleName);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.Controls.Add(this.labelRoleName);
            this.groupPanel1.Location = new System.Drawing.Point(12, -2);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(427, 371);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 0;
            this.groupPanel1.Text = "Phân quyền";
            // 
            // listBoxSystemFunctionID
            // 
            this.listBoxSystemFunctionID.FormattingEnabled = true;
            this.listBoxSystemFunctionID.Location = new System.Drawing.Point(45, 314);
            this.listBoxSystemFunctionID.Name = "listBoxSystemFunctionID";
            this.listBoxSystemFunctionID.Size = new System.Drawing.Size(31, 30);
            this.listBoxSystemFunctionID.TabIndex = 42;
            this.listBoxSystemFunctionID.Visible = false;
            // 
            // listBoxCurrentFunctionID
            // 
            this.listBoxCurrentFunctionID.FormattingEnabled = true;
            this.listBoxCurrentFunctionID.Location = new System.Drawing.Point(8, 314);
            this.listBoxCurrentFunctionID.Name = "listBoxCurrentFunctionID";
            this.listBoxCurrentFunctionID.Size = new System.Drawing.Size(31, 30);
            this.listBoxCurrentFunctionID.TabIndex = 43;
            this.listBoxCurrentFunctionID.Visible = false;
            // 
            // buttonClose
            // 
            this.buttonClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonClose.Location = new System.Drawing.Point(316, 321);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonClose.TabIndex = 33;
            this.buttonClose.Text = "Đóng";
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonInsertFunction
            // 
            this.buttonInsertFunction.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonInsertFunction.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonInsertFunction.Location = new System.Drawing.Point(178, 207);
            this.buttonInsertFunction.Name = "buttonInsertFunction";
            this.buttonInsertFunction.Size = new System.Drawing.Size(37, 23);
            this.buttonInsertFunction.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonInsertFunction.TabIndex = 40;
            this.buttonInsertFunction.Text = "<";
            this.buttonInsertFunction.Click += new System.EventHandler(this.buttonInsertFunction_Click);
            // 
            // buttonRemoveFunction
            // 
            this.buttonRemoveFunction.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonRemoveFunction.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonRemoveFunction.Location = new System.Drawing.Point(178, 178);
            this.buttonRemoveFunction.Name = "buttonRemoveFunction";
            this.buttonRemoveFunction.Size = new System.Drawing.Size(37, 23);
            this.buttonRemoveFunction.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonRemoveFunction.TabIndex = 41;
            this.buttonRemoveFunction.Text = ">";
            this.buttonRemoveFunction.Click += new System.EventHandler(this.buttonRemoveFunction_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonOk.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonOk.Location = new System.Drawing.Point(224, 321);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonOk.TabIndex = 32;
            this.buttonOk.Text = "Đồng ý";
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // listBoxSystemFunction
            // 
            this.listBoxSystemFunction.FormattingEnabled = true;
            this.listBoxSystemFunction.Location = new System.Drawing.Point(224, 96);
            this.listBoxSystemFunction.Name = "listBoxSystemFunction";
            this.listBoxSystemFunction.Size = new System.Drawing.Size(170, 212);
            this.listBoxSystemFunction.TabIndex = 38;
            // 
            // listBoxCurrentFunction
            // 
            this.listBoxCurrentFunction.FormattingEnabled = true;
            this.listBoxCurrentFunction.Location = new System.Drawing.Point(3, 96);
            this.listBoxCurrentFunction.Name = "listBoxCurrentFunction";
            this.listBoxCurrentFunction.Size = new System.Drawing.Size(165, 212);
            this.listBoxCurrentFunction.TabIndex = 39;
            // 
            // textBoxRoleID
            // 
            // 
            // 
            // 
            this.textBoxRoleID.Border.Class = "TextBoxBorder";
            this.textBoxRoleID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxRoleID.Location = new System.Drawing.Point(101, 6);
            this.textBoxRoleID.Name = "textBoxRoleID";
            this.textBoxRoleID.ReadOnly = true;
            this.textBoxRoleID.Size = new System.Drawing.Size(293, 20);
            this.textBoxRoleID.TabIndex = 30;
            // 
            // labelRoleID
            // 
            this.labelRoleID.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelRoleID.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelRoleID.Location = new System.Drawing.Point(3, 3);
            this.labelRoleID.Name = "labelRoleID";
            this.labelRoleID.Size = new System.Drawing.Size(92, 23);
            this.labelRoleID.TabIndex = 34;
            this.labelRoleID.Text = "Mã phân quyền";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(249, 67);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(145, 23);
            this.labelX2.TabIndex = 37;
            this.labelX2.Text = "Các chức năng của hệ thống";
            // 
            // textBoxRoleName
            // 
            // 
            // 
            // 
            this.textBoxRoleName.Border.Class = "TextBoxBorder";
            this.textBoxRoleName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxRoleName.Location = new System.Drawing.Point(101, 32);
            this.textBoxRoleName.Name = "textBoxRoleName";
            this.textBoxRoleName.Size = new System.Drawing.Size(293, 20);
            this.textBoxRoleName.TabIndex = 0;
            this.superValidator1.SetValidator1(this.textBoxRoleName, this.requiredFieldValidator1);
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(3, 67);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(116, 23);
            this.labelX1.TabIndex = 36;
            this.labelX1.Text = "Các chức năng hiện có";
            // 
            // labelRoleName
            // 
            this.labelRoleName.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelRoleName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelRoleName.Location = new System.Drawing.Point(3, 29);
            this.labelRoleName.Name = "labelRoleName";
            this.labelRoleName.Size = new System.Drawing.Size(92, 23);
            this.labelRoleName.TabIndex = 35;
            this.labelRoleName.Text = "Tên phân quyền";
            // 
            // superValidator1
            // 
            this.superValidator1.ContainerControl = this;
            this.superValidator1.ErrorProvider = this.errorProvider1;
            this.superValidator1.Highlighter = this.highlighter1;
            // 
            // requiredFieldValidator1
            // 
            this.requiredFieldValidator1.ErrorMessage = "Nhập tên phân quyền";
            this.requiredFieldValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // highlighter1
            // 
            this.highlighter1.ContainerControl = this;
            // 
            // FormRoleDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 381);
            this.Controls.Add(this.groupPanel1);
            this.Name = "FormRoleDetail";
            this.Text = "Thông tin phân quyền";
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private System.Windows.Forms.ListBox listBoxSystemFunctionID;
        private System.Windows.Forms.ListBox listBoxCurrentFunctionID;
        private DevComponents.DotNetBar.ButtonX buttonClose;
        private DevComponents.DotNetBar.ButtonX buttonInsertFunction;
        private DevComponents.DotNetBar.ButtonX buttonRemoveFunction;
        private DevComponents.DotNetBar.ButtonX buttonOk;
        private System.Windows.Forms.ListBox listBoxSystemFunction;
        private System.Windows.Forms.ListBox listBoxCurrentFunction;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxRoleID;
        private DevComponents.DotNetBar.LabelX labelRoleID;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxRoleName;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelRoleName;
        private DevComponents.DotNetBar.Validator.SuperValidator superValidator1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter1;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator1;



    }
}