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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMaterialDetail));
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.buttonClose = new DevComponents.DotNetBar.ButtonX();
            this.buttonOk = new DevComponents.DotNetBar.ButtonX();
            this.textBoxQuantity = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelQuantity = new DevComponents.DotNetBar.LabelX();
            this.textBoxMaterialID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBoxPrice = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelMaterialID = new DevComponents.DotNetBar.LabelX();
            this.labelPrice = new DevComponents.DotNetBar.LabelX();
            this.textBoxMaterialName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelMaterialName = new DevComponents.DotNetBar.LabelX();
            this.superValidator1 = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.requiredFieldValidator2 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Nhập số lượng");
            this.rangeValidator2 = new DevComponents.DotNetBar.Validator.RangeValidator();
            this.requiredFieldValidator3 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Nhập đơn giá");
            this.rangeValidator1 = new DevComponents.DotNetBar.Validator.RangeValidator();
            this.requiredFieldValidator1 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Nhập tên vật tư");
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.highlighter1 = new DevComponents.DotNetBar.Validator.Highlighter();
            this.regularExpressionValidator1 = new DevComponents.DotNetBar.Validator.RegularExpressionValidator();
            this.regularExpressionValidator2 = new DevComponents.DotNetBar.Validator.RegularExpressionValidator();
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
            this.groupPanel1.Controls.Add(this.textBoxMaterialID);
            this.groupPanel1.Controls.Add(this.textBoxPrice);
            this.groupPanel1.Controls.Add(this.labelMaterialID);
            this.groupPanel1.Controls.Add(this.labelPrice);
            this.groupPanel1.Controls.Add(this.textBoxMaterialName);
            this.groupPanel1.Controls.Add(this.labelMaterialName);
            this.groupPanel1.Location = new System.Drawing.Point(12, 3);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(379, 156);
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
            this.groupPanel1.Text = "Vật tư";
            // 
            // buttonClose
            // 
            this.buttonClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonClose.Location = new System.Drawing.Point(275, 110);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonClose.TabIndex = 38;
            this.buttonClose.Text = "Đóng";
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonOk.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonOk.Location = new System.Drawing.Point(182, 110);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonOk.TabIndex = 37;
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
            this.textBoxQuantity.Location = new System.Drawing.Point(57, 58);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(293, 20);
            this.textBoxQuantity.TabIndex = 2;
            this.superValidator1.SetValidator1(this.textBoxQuantity, this.requiredFieldValidator2);
            this.superValidator1.SetValidator2(this.textBoxQuantity, this.rangeValidator2);
            this.superValidator1.SetValidator3(this.textBoxQuantity, this.regularExpressionValidator1);
            // 
            // labelQuantity
            // 
            this.labelQuantity.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelQuantity.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelQuantity.Location = new System.Drawing.Point(3, 55);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(92, 23);
            this.labelQuantity.TabIndex = 39;
            this.labelQuantity.Text = "Số lượng";
            // 
            // textBoxMaterialID
            // 
            // 
            // 
            // 
            this.textBoxMaterialID.Border.Class = "TextBoxBorder";
            this.textBoxMaterialID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxMaterialID.Location = new System.Drawing.Point(57, 6);
            this.textBoxMaterialID.Name = "textBoxMaterialID";
            this.textBoxMaterialID.ReadOnly = true;
            this.textBoxMaterialID.Size = new System.Drawing.Size(293, 20);
            this.textBoxMaterialID.TabIndex = 33;
            // 
            // textBoxPrice
            // 
            // 
            // 
            // 
            this.textBoxPrice.Border.Class = "TextBoxBorder";
            this.textBoxPrice.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxPrice.Location = new System.Drawing.Point(57, 84);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(293, 20);
            this.textBoxPrice.TabIndex = 3;
            this.superValidator1.SetValidator1(this.textBoxPrice, this.requiredFieldValidator3);
            this.superValidator1.SetValidator2(this.textBoxPrice, this.rangeValidator1);
            this.superValidator1.SetValidator3(this.textBoxPrice, this.regularExpressionValidator2);
            // 
            // labelMaterialID
            // 
            this.labelMaterialID.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelMaterialID.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelMaterialID.Location = new System.Drawing.Point(3, 3);
            this.labelMaterialID.Name = "labelMaterialID";
            this.labelMaterialID.Size = new System.Drawing.Size(92, 23);
            this.labelMaterialID.TabIndex = 40;
            this.labelMaterialID.Text = "Mã vật tư";
            // 
            // labelPrice
            // 
            this.labelPrice.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelPrice.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelPrice.Location = new System.Drawing.Point(3, 81);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(92, 23);
            this.labelPrice.TabIndex = 42;
            this.labelPrice.Text = "Đơn giá";
            // 
            // textBoxMaterialName
            // 
            // 
            // 
            // 
            this.textBoxMaterialName.Border.Class = "TextBoxBorder";
            this.textBoxMaterialName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxMaterialName.Location = new System.Drawing.Point(57, 32);
            this.textBoxMaterialName.Name = "textBoxMaterialName";
            this.textBoxMaterialName.Size = new System.Drawing.Size(293, 20);
            this.textBoxMaterialName.TabIndex = 1;
            this.superValidator1.SetValidator1(this.textBoxMaterialName, this.requiredFieldValidator1);
            // 
            // labelMaterialName
            // 
            this.labelMaterialName.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelMaterialName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelMaterialName.Location = new System.Drawing.Point(3, 29);
            this.labelMaterialName.Name = "labelMaterialName";
            this.labelMaterialName.Size = new System.Drawing.Size(92, 23);
            this.labelMaterialName.TabIndex = 41;
            this.labelMaterialName.Text = "Tên vật tư";
            // 
            // superValidator1
            // 
            this.superValidator1.ContainerControl = this;
            this.superValidator1.ErrorProvider = this.errorProvider1;
            this.superValidator1.Highlighter = this.highlighter1;
            // 
            // requiredFieldValidator2
            // 
            this.requiredFieldValidator2.ErrorMessage = "Nhập số lượng";
            this.requiredFieldValidator2.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // rangeValidator2
            // 
            this.rangeValidator2.ErrorMessage = "Số lượng phải từ 1-1000";
            this.rangeValidator2.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.rangeValidator2.MaximumValue = "1000";
            this.rangeValidator2.MinimumValue = "1";
            // 
            // requiredFieldValidator3
            // 
            this.requiredFieldValidator3.ErrorMessage = "Nhập đơn giá";
            this.requiredFieldValidator3.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // rangeValidator1
            // 
            this.rangeValidator1.ErrorMessage = "Đơn giá phải từ 4-9 chữ số";
            this.rangeValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.rangeValidator1.MaximumValue = "999999999";
            this.rangeValidator1.MinimumValue = "1000";
            // 
            // requiredFieldValidator1
            // 
            this.requiredFieldValidator1.ErrorMessage = "Nhập tên vật tư";
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
            // regularExpressionValidator1
            // 
            this.regularExpressionValidator1.ErrorMessage = "Chỉ được phép nhập số";
            this.regularExpressionValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.regularExpressionValidator1.ValidationExpression = "^[1-9]\\d?\\d?\\d?\\d?$";
            // 
            // regularExpressionValidator2
            // 
            this.regularExpressionValidator2.ErrorMessage = "Chỉ được phép nhập số";
            this.regularExpressionValidator2.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.regularExpressionValidator2.ValidationExpression = "^[1-9]\\d{3}\\d?\\d?\\d?\\d?\\d?$";
            // 
            // FormMaterialDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 168);
            this.Controls.Add(this.groupPanel1);
            this.Name = "FormMaterialDetail";
            this.Text = "Thông tin vật tư";
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
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxMaterialID;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxPrice;
        private DevComponents.DotNetBar.LabelX labelMaterialID;
        private DevComponents.DotNetBar.LabelX labelPrice;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxMaterialName;
        private DevComponents.DotNetBar.LabelX labelMaterialName;
        private DevComponents.DotNetBar.Validator.SuperValidator superValidator1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter1;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator2;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator3;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator1;
        private DevComponents.DotNetBar.Validator.RangeValidator rangeValidator2;
        private DevComponents.DotNetBar.Validator.RangeValidator rangeValidator1;
        private DevComponents.DotNetBar.Validator.RegularExpressionValidator regularExpressionValidator1;
        private DevComponents.DotNetBar.Validator.RegularExpressionValidator regularExpressionValidator2;

    }
}