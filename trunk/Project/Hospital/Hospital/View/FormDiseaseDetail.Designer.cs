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
            this.textBoxDiseaseID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelDiseaseID = new DevComponents.DotNetBar.LabelX();
            this.textBoxDiseaseName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelDiseaseName = new DevComponents.DotNetBar.LabelX();
            this.labelDiseaseSymptom = new DevComponents.DotNetBar.LabelX();
            this.textBoxDiseaseSymptom = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.buttonClose = new DevComponents.DotNetBar.ButtonX();
            this.buttonOk = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // textBoxDiseaseID
            // 
            // 
            // 
            // 
            this.textBoxDiseaseID.Border.Class = "TextBoxBorder";
            this.textBoxDiseaseID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxDiseaseID.Location = new System.Drawing.Point(76, 8);
            this.textBoxDiseaseID.Name = "textBoxDiseaseID";
            this.textBoxDiseaseID.ReadOnly = true;
            this.textBoxDiseaseID.Size = new System.Drawing.Size(293, 20);
            this.textBoxDiseaseID.TabIndex = 29;
            // 
            // labelDiseaseID
            // 
            // 
            // 
            // 
            this.labelDiseaseID.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelDiseaseID.Location = new System.Drawing.Point(8, 5);
            this.labelDiseaseID.Name = "labelDiseaseID";
            this.labelDiseaseID.Size = new System.Drawing.Size(92, 23);
            this.labelDiseaseID.TabIndex = 27;
            this.labelDiseaseID.Text = "Mã bệnh";
            // 
            // textBoxDiseaseName
            // 
            // 
            // 
            // 
            this.textBoxDiseaseName.Border.Class = "TextBoxBorder";
            this.textBoxDiseaseName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxDiseaseName.Location = new System.Drawing.Point(76, 34);
            this.textBoxDiseaseName.Name = "textBoxDiseaseName";
            this.textBoxDiseaseName.Size = new System.Drawing.Size(293, 20);
            this.textBoxDiseaseName.TabIndex = 26;
            // 
            // labelDiseaseName
            // 
            // 
            // 
            // 
            this.labelDiseaseName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelDiseaseName.Location = new System.Drawing.Point(8, 31);
            this.labelDiseaseName.Name = "labelDiseaseName";
            this.labelDiseaseName.Size = new System.Drawing.Size(92, 23);
            this.labelDiseaseName.TabIndex = 28;
            this.labelDiseaseName.Text = "Tên bệnh";
            // 
            // labelDiseaseSymptom
            // 
            // 
            // 
            // 
            this.labelDiseaseSymptom.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelDiseaseSymptom.Location = new System.Drawing.Point(8, 57);
            this.labelDiseaseSymptom.Name = "labelDiseaseSymptom";
            this.labelDiseaseSymptom.Size = new System.Drawing.Size(92, 23);
            this.labelDiseaseSymptom.TabIndex = 28;
            this.labelDiseaseSymptom.Text = "Triệu chứng";
            // 
            // textBoxDiseaseSymptom
            // 
            // 
            // 
            // 
            this.textBoxDiseaseSymptom.Border.Class = "TextBoxBorder";
            this.textBoxDiseaseSymptom.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxDiseaseSymptom.Location = new System.Drawing.Point(76, 60);
            this.textBoxDiseaseSymptom.Multiline = true;
            this.textBoxDiseaseSymptom.Name = "textBoxDiseaseSymptom";
            this.textBoxDiseaseSymptom.Size = new System.Drawing.Size(293, 187);
            this.textBoxDiseaseSymptom.TabIndex = 30;
            // 
            // buttonClose
            // 
            this.buttonClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonClose.Location = new System.Drawing.Point(281, 253);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonClose.TabIndex = 32;
            this.buttonClose.Text = "Đóng";
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonOk.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonOk.Location = new System.Drawing.Point(189, 253);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonOk.TabIndex = 31;
            this.buttonOk.Text = "Đồng ý";
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // FormDiseaseDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 283);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.textBoxDiseaseSymptom);
            this.Controls.Add(this.textBoxDiseaseID);
            this.Controls.Add(this.labelDiseaseID);
            this.Controls.Add(this.labelDiseaseSymptom);
            this.Controls.Add(this.textBoxDiseaseName);
            this.Controls.Add(this.labelDiseaseName);
            this.Name = "FormDiseaseDetail";
            this.Text = "FormDiseaseDetail";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX textBoxDiseaseID;
        private DevComponents.DotNetBar.LabelX labelDiseaseID;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxDiseaseName;
        private DevComponents.DotNetBar.LabelX labelDiseaseName;
        private DevComponents.DotNetBar.LabelX labelDiseaseSymptom;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxDiseaseSymptom;
        private DevComponents.DotNetBar.ButtonX buttonClose;
        private DevComponents.DotNetBar.ButtonX buttonOk;
    }
}