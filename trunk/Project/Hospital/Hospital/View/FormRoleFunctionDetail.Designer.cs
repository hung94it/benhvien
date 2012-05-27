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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRoleFunctionDetail));
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.buttonClose = new DevComponents.DotNetBar.ButtonX();
            this.buttonOk = new DevComponents.DotNetBar.ButtonX();
            this.textBoxFunctionID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelFunctionID = new DevComponents.DotNetBar.LabelX();
            this.textBoxButton = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelFunctionButton = new DevComponents.DotNetBar.LabelX();
            this.textBoxFunctionName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelFunctionName = new DevComponents.DotNetBar.LabelX();
            this.superValidator1 = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.highlighter1 = new DevComponents.DotNetBar.Validator.Highlighter();
            this.requiredFieldValidator1 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Nhập tên chức năng");
            this.requiredFieldValidator2 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Nhập nút");
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.buttonClose);
            this.groupPanel1.Controls.Add(this.buttonOk);
            this.groupPanel1.Controls.Add(this.textBoxFunctionID);
            this.groupPanel1.Controls.Add(this.labelFunctionID);
            this.groupPanel1.Controls.Add(this.textBoxButton);
            this.groupPanel1.Controls.Add(this.labelFunctionButton);
            this.groupPanel1.Controls.Add(this.textBoxFunctionName);
            this.groupPanel1.Controls.Add(this.labelFunctionName);
            this.groupPanel1.Location = new System.Drawing.Point(12, 2);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(416, 132);
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
            this.groupPanel1.Text = "Chức năng";
            // 
            // buttonClose
            // 
            this.buttonClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonClose.Location = new System.Drawing.Point(308, 84);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonClose.TabIndex = 33;
            this.buttonClose.Text = "Đóng";
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonOk.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonOk.Location = new System.Drawing.Point(216, 84);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonOk.TabIndex = 32;
            this.buttonOk.Text = "Đồng ý";
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // textBoxFunctionID
            // 
            // 
            // 
            // 
            this.textBoxFunctionID.Border.Class = "TextBoxBorder";
            this.textBoxFunctionID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxFunctionID.Location = new System.Drawing.Point(92, 6);
            this.textBoxFunctionID.Name = "textBoxFunctionID";
            this.textBoxFunctionID.ReadOnly = true;
            this.textBoxFunctionID.Size = new System.Drawing.Size(293, 20);
            this.textBoxFunctionID.TabIndex = 29;
            // 
            // labelFunctionID
            // 
            this.labelFunctionID.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelFunctionID.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelFunctionID.Location = new System.Drawing.Point(3, 3);
            this.labelFunctionID.Name = "labelFunctionID";
            this.labelFunctionID.Size = new System.Drawing.Size(92, 23);
            this.labelFunctionID.TabIndex = 34;
            this.labelFunctionID.Text = "Mã chức năng";
            // 
            // textBoxButton
            // 
            // 
            // 
            // 
            this.textBoxButton.Border.Class = "TextBoxBorder";
            this.textBoxButton.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxButton.Location = new System.Drawing.Point(92, 58);
            this.textBoxButton.Name = "textBoxButton";
            this.textBoxButton.Size = new System.Drawing.Size(293, 20);
            this.textBoxButton.TabIndex = 31;
            this.superValidator1.SetValidator1(this.textBoxButton, this.requiredFieldValidator2);
            // 
            // labelFunctionButton
            // 
            this.labelFunctionButton.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelFunctionButton.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelFunctionButton.Location = new System.Drawing.Point(3, 55);
            this.labelFunctionButton.Name = "labelFunctionButton";
            this.labelFunctionButton.Size = new System.Drawing.Size(92, 23);
            this.labelFunctionButton.TabIndex = 36;
            this.labelFunctionButton.Text = "Nút";
            // 
            // textBoxFunctionName
            // 
            // 
            // 
            // 
            this.textBoxFunctionName.Border.Class = "TextBoxBorder";
            this.textBoxFunctionName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxFunctionName.Location = new System.Drawing.Point(92, 32);
            this.textBoxFunctionName.Name = "textBoxFunctionName";
            this.textBoxFunctionName.Size = new System.Drawing.Size(293, 20);
            this.textBoxFunctionName.TabIndex = 30;
            this.superValidator1.SetValidator1(this.textBoxFunctionName, this.requiredFieldValidator1);
            // 
            // labelFunctionName
            // 
            this.labelFunctionName.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelFunctionName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelFunctionName.Location = new System.Drawing.Point(3, 29);
            this.labelFunctionName.Name = "labelFunctionName";
            this.labelFunctionName.Size = new System.Drawing.Size(92, 23);
            this.labelFunctionName.TabIndex = 35;
            this.labelFunctionName.Text = "Tên chức năng";
            // 
            // superValidator1
            // 
            this.superValidator1.ContainerControl = this;
            this.superValidator1.ErrorProvider = this.errorProvider1;
            this.superValidator1.Highlighter = this.highlighter1;
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
            // requiredFieldValidator1
            // 
            this.requiredFieldValidator1.ErrorMessage = "Nhập tên chức năng";
            this.requiredFieldValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // requiredFieldValidator2
            // 
            this.requiredFieldValidator2.ErrorMessage = "Nhập nút";
            this.requiredFieldValidator2.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // FormRoleFunctionDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 139);
            this.Controls.Add(this.groupPanel1);
            this.Name = "FormRoleFunctionDetail";
            this.Text = "Thông tin chức năng";
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.ButtonX buttonClose;
        private DevComponents.DotNetBar.ButtonX buttonOk;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxFunctionID;
        private DevComponents.DotNetBar.LabelX labelFunctionID;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxButton;
        private DevComponents.DotNetBar.LabelX labelFunctionButton;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxFunctionName;
        private DevComponents.DotNetBar.LabelX labelFunctionName;
        private DevComponents.DotNetBar.Validator.SuperValidator superValidator1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter1;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator2;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator1;

    }
}