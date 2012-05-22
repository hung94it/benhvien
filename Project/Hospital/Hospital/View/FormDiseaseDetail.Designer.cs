namespace Hospital.View
{
    partial class FormDiseaseDetail
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
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.buttonClose = new DevComponents.DotNetBar.ButtonX();
            this.buttonOk = new DevComponents.DotNetBar.ButtonX();
            this.textBoxDiseaseSymptom = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBoxDiseaseID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelDiseaseID = new DevComponents.DotNetBar.LabelX();
            this.labelDiseaseSymptom = new DevComponents.DotNetBar.LabelX();
            this.textBoxDiseaseName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelDiseaseName = new DevComponents.DotNetBar.LabelX();
            this.groupPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.buttonClose);
            this.groupPanel1.Controls.Add(this.buttonOk);
            this.groupPanel1.Controls.Add(this.textBoxDiseaseSymptom);
            this.groupPanel1.Controls.Add(this.textBoxDiseaseID);
            this.groupPanel1.Controls.Add(this.labelDiseaseID);
            this.groupPanel1.Controls.Add(this.labelDiseaseSymptom);
            this.groupPanel1.Controls.Add(this.textBoxDiseaseName);
            this.groupPanel1.Controls.Add(this.labelDiseaseName);
            this.groupPanel1.Location = new System.Drawing.Point(12, 5);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(376, 302);
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
            this.groupPanel1.Text = "Bệnh dịch";
            // 
            // buttonClose
            // 
            this.buttonClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonClose.Location = new System.Drawing.Point(291, 254);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonClose.TabIndex = 33;
            this.buttonClose.Text = "Đóng";
            // 
            // buttonOk
            // 
            this.buttonOk.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonOk.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonOk.Location = new System.Drawing.Point(199, 254);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonOk.TabIndex = 32;
            this.buttonOk.Text = "Đồng ý";
            // 
            // textBoxDiseaseSymptom
            // 
            // 
            // 
            // 
            this.textBoxDiseaseSymptom.Border.Class = "TextBoxBorder";
            this.textBoxDiseaseSymptom.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxDiseaseSymptom.Location = new System.Drawing.Point(73, 61);
            this.textBoxDiseaseSymptom.Multiline = true;
            this.textBoxDiseaseSymptom.Name = "textBoxDiseaseSymptom";
            this.textBoxDiseaseSymptom.Size = new System.Drawing.Size(293, 187);
            this.textBoxDiseaseSymptom.TabIndex = 31;
            // 
            // textBoxDiseaseID
            // 
            // 
            // 
            // 
            this.textBoxDiseaseID.Border.Class = "TextBoxBorder";
            this.textBoxDiseaseID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxDiseaseID.Location = new System.Drawing.Point(73, 9);
            this.textBoxDiseaseID.Name = "textBoxDiseaseID";
            this.textBoxDiseaseID.ReadOnly = true;
            this.textBoxDiseaseID.Size = new System.Drawing.Size(293, 20);
            this.textBoxDiseaseID.TabIndex = 29;
            // 
            // labelDiseaseID
            // 
            this.labelDiseaseID.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelDiseaseID.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelDiseaseID.Location = new System.Drawing.Point(3, 9);
            this.labelDiseaseID.Name = "labelDiseaseID";
            this.labelDiseaseID.Size = new System.Drawing.Size(92, 23);
            this.labelDiseaseID.TabIndex = 34;
            this.labelDiseaseID.Text = "Mã bệnh";
            // 
            // labelDiseaseSymptom
            // 
            this.labelDiseaseSymptom.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelDiseaseSymptom.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelDiseaseSymptom.Location = new System.Drawing.Point(3, 61);
            this.labelDiseaseSymptom.Name = "labelDiseaseSymptom";
            this.labelDiseaseSymptom.Size = new System.Drawing.Size(92, 23);
            this.labelDiseaseSymptom.TabIndex = 36;
            this.labelDiseaseSymptom.Text = "Triệu chứng";
            // 
            // textBoxDiseaseName
            // 
            // 
            // 
            // 
            this.textBoxDiseaseName.Border.Class = "TextBoxBorder";
            this.textBoxDiseaseName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxDiseaseName.Location = new System.Drawing.Point(73, 35);
            this.textBoxDiseaseName.Name = "textBoxDiseaseName";
            this.textBoxDiseaseName.Size = new System.Drawing.Size(293, 20);
            this.textBoxDiseaseName.TabIndex = 30;
            // 
            // labelDiseaseName
            // 
            this.labelDiseaseName.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelDiseaseName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelDiseaseName.Location = new System.Drawing.Point(3, 35);
            this.labelDiseaseName.Name = "labelDiseaseName";
            this.labelDiseaseName.Size = new System.Drawing.Size(92, 23);
            this.labelDiseaseName.TabIndex = 35;
            this.labelDiseaseName.Text = "Tên bệnh";
            // 
            // FormDiseaseDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 312);
            this.Controls.Add(this.groupPanel1);
            this.Name = "FormDiseaseDetail";
            this.Text = "Thông tin bệnh dịch";
            this.groupPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.ButtonX buttonClose;
        private DevComponents.DotNetBar.ButtonX buttonOk;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxDiseaseSymptom;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxDiseaseID;
        private DevComponents.DotNetBar.LabelX labelDiseaseID;
        private DevComponents.DotNetBar.LabelX labelDiseaseSymptom;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxDiseaseName;
        private DevComponents.DotNetBar.LabelX labelDiseaseName;

    }
}