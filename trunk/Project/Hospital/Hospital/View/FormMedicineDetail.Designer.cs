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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMedicineDetail));
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
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
            this.superValidator1 = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.highlighter1 = new DevComponents.DotNetBar.Validator.Highlighter();
            this.requiredFieldValidator1 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Nhập tên thuốc");
            this.requiredFieldValidator2 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Nhập số lượng");
            this.requiredFieldValidator3 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Nhập đơn giá");
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
            this.groupPanel1.Controls.Add(this.textBoxQuantity);
            this.groupPanel1.Controls.Add(this.labelQuantity);
            this.groupPanel1.Controls.Add(this.textBoxMedicineID);
            this.groupPanel1.Controls.Add(this.textBoxPrice);
            this.groupPanel1.Controls.Add(this.labelMedicineID);
            this.groupPanel1.Controls.Add(this.labelPrice);
            this.groupPanel1.Controls.Add(this.textBoxMedicineName);
            this.groupPanel1.Controls.Add(this.labelMedicineName);
            this.groupPanel1.Location = new System.Drawing.Point(12, 2);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(381, 155);
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
            this.groupPanel1.Text = "Thuốc";
            // 
            // buttonClose
            // 
            this.buttonClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonClose.Location = new System.Drawing.Point(280, 107);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonClose.TabIndex = 47;
            this.buttonClose.Text = "Đóng";
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonOk.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonOk.Location = new System.Drawing.Point(188, 107);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonOk.TabIndex = 46;
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
            this.textBoxQuantity.Location = new System.Drawing.Point(63, 55);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(293, 20);
            this.textBoxQuantity.TabIndex = 44;
            this.superValidator1.SetValidator1(this.textBoxQuantity, this.requiredFieldValidator2);
            // 
            // labelQuantity
            // 
            this.labelQuantity.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelQuantity.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelQuantity.Location = new System.Drawing.Point(7, 52);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(92, 23);
            this.labelQuantity.TabIndex = 48;
            this.labelQuantity.Text = "Số lượng";
            // 
            // textBoxMedicineID
            // 
            // 
            // 
            // 
            this.textBoxMedicineID.Border.Class = "TextBoxBorder";
            this.textBoxMedicineID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxMedicineID.Location = new System.Drawing.Point(63, 3);
            this.textBoxMedicineID.Name = "textBoxMedicineID";
            this.textBoxMedicineID.ReadOnly = true;
            this.textBoxMedicineID.Size = new System.Drawing.Size(293, 20);
            this.textBoxMedicineID.TabIndex = 42;
            // 
            // textBoxPrice
            // 
            // 
            // 
            // 
            this.textBoxPrice.Border.Class = "TextBoxBorder";
            this.textBoxPrice.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxPrice.Location = new System.Drawing.Point(63, 81);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(293, 20);
            this.textBoxPrice.TabIndex = 45;
            this.superValidator1.SetValidator1(this.textBoxPrice, this.requiredFieldValidator3);
            // 
            // labelMedicineID
            // 
            this.labelMedicineID.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelMedicineID.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelMedicineID.Location = new System.Drawing.Point(7, 0);
            this.labelMedicineID.Name = "labelMedicineID";
            this.labelMedicineID.Size = new System.Drawing.Size(92, 23);
            this.labelMedicineID.TabIndex = 49;
            this.labelMedicineID.Text = "Mã thuốc";
            // 
            // labelPrice
            // 
            this.labelPrice.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelPrice.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelPrice.Location = new System.Drawing.Point(7, 78);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(92, 23);
            this.labelPrice.TabIndex = 51;
            this.labelPrice.Text = "Đơn giá";
            // 
            // textBoxMedicineName
            // 
            // 
            // 
            // 
            this.textBoxMedicineName.Border.Class = "TextBoxBorder";
            this.textBoxMedicineName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxMedicineName.Location = new System.Drawing.Point(63, 29);
            this.textBoxMedicineName.Name = "textBoxMedicineName";
            this.textBoxMedicineName.Size = new System.Drawing.Size(293, 20);
            this.textBoxMedicineName.TabIndex = 43;
            this.superValidator1.SetValidator1(this.textBoxMedicineName, this.requiredFieldValidator1);
            // 
            // labelMedicineName
            // 
            this.labelMedicineName.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelMedicineName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelMedicineName.Location = new System.Drawing.Point(7, 26);
            this.labelMedicineName.Name = "labelMedicineName";
            this.labelMedicineName.Size = new System.Drawing.Size(92, 23);
            this.labelMedicineName.TabIndex = 50;
            this.labelMedicineName.Text = "Tên thuốc";
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
            this.requiredFieldValidator1.ErrorMessage = "Nhập tên thuốc";
            this.requiredFieldValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // requiredFieldValidator2
            // 
            this.requiredFieldValidator2.ErrorMessage = "Nhập số lượng";
            this.requiredFieldValidator2.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // requiredFieldValidator3
            // 
            this.requiredFieldValidator3.ErrorMessage = "Nhập đơn giá";
            this.requiredFieldValidator3.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // FormMedicineDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 163);
            this.Controls.Add(this.groupPanel1);
            this.Name = "FormMedicineDetail";
            this.Text = "Thông tin thuốc";
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
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
        private DevComponents.DotNetBar.Validator.SuperValidator superValidator1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter1;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator2;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator3;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator1;

    }
}