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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDepartmentDetail));
            this.textBoxDepartmentID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelDepartmentID = new DevComponents.DotNetBar.LabelX();
            this.textBoxDepartmentName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelDepartmentName = new DevComponents.DotNetBar.LabelX();
            this.buttonClose = new DevComponents.DotNetBar.ButtonX();
            this.buttonOk = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.superValidator1 = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.requiredFieldValidator1 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Nhập tên phòng ban");
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.highlighter1 = new DevComponents.DotNetBar.Validator.Highlighter();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxDepartmentID
            // 
            // 
            // 
            // 
            this.textBoxDepartmentID.Border.Class = "TextBoxBorder";
            this.textBoxDepartmentID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxDepartmentID.Location = new System.Drawing.Point(107, 5);
            this.textBoxDepartmentID.Name = "textBoxDepartmentID";
            this.textBoxDepartmentID.ReadOnly = true;
            this.textBoxDepartmentID.Size = new System.Drawing.Size(293, 20);
            this.textBoxDepartmentID.TabIndex = 1;
            // 
            // labelDepartmentID
            // 
            this.labelDepartmentID.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelDepartmentID.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelDepartmentID.Location = new System.Drawing.Point(9, 2);
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
            this.textBoxDepartmentName.Location = new System.Drawing.Point(107, 31);
            this.textBoxDepartmentName.Name = "textBoxDepartmentName";
            this.textBoxDepartmentName.Size = new System.Drawing.Size(293, 20);
            this.textBoxDepartmentName.TabIndex = 0;
            this.superValidator1.SetValidator1(this.textBoxDepartmentName, this.requiredFieldValidator1);
            // 
            // labelDepartmentName
            // 
            this.labelDepartmentName.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelDepartmentName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelDepartmentName.Location = new System.Drawing.Point(9, 28);
            this.labelDepartmentName.Name = "labelDepartmentName";
            this.labelDepartmentName.Size = new System.Drawing.Size(92, 23);
            this.labelDepartmentName.TabIndex = 28;
            this.labelDepartmentName.Text = "Tên phòng ban";
            // 
            // buttonClose
            // 
            this.buttonClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonClose.Location = new System.Drawing.Point(325, 57);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonClose.TabIndex = 3;
            this.buttonClose.Text = "Đóng";
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonOk.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonOk.Location = new System.Drawing.Point(233, 57);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonOk.TabIndex = 2;
            this.buttonOk.Text = "Đồng ý";
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.textBoxDepartmentName);
            this.groupPanel1.Controls.Add(this.buttonClose);
            this.groupPanel1.Controls.Add(this.labelDepartmentName);
            this.groupPanel1.Controls.Add(this.buttonOk);
            this.groupPanel1.Controls.Add(this.labelDepartmentID);
            this.groupPanel1.Controls.Add(this.textBoxDepartmentID);
            this.groupPanel1.Location = new System.Drawing.Point(12, 5);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(424, 107);
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
            this.groupPanel1.TabIndex = 29;
            this.groupPanel1.Text = "Phòng ban";
            // 
            // superValidator1
            // 
            this.superValidator1.ContainerControl = this;
            this.superValidator1.ErrorProvider = this.errorProvider1;
            this.superValidator1.Highlighter = this.highlighter1;
            // 
            // requiredFieldValidator1
            // 
            this.requiredFieldValidator1.ErrorMessage = "Nhập tên phòng ban";
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
            // FormDepartmentDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 120);
            this.Controls.Add(this.groupPanel1);
            this.Name = "FormDepartmentDetail";
            this.Text = "Thông tin phòng ban";
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX textBoxDepartmentID;
        private DevComponents.DotNetBar.LabelX labelDepartmentID;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxDepartmentName;
        private DevComponents.DotNetBar.LabelX labelDepartmentName;
        private DevComponents.DotNetBar.ButtonX buttonClose;
        private DevComponents.DotNetBar.ButtonX buttonOk;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Validator.SuperValidator superValidator1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter1;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator1;
    }
}