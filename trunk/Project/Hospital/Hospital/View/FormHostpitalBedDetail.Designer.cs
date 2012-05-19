namespace Hospital.View
{
    partial class FormHostpitalBedDetail
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
            this.textBoxHospitalBedID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelHospitalBedID = new DevComponents.DotNetBar.LabelX();
            this.textBoxPatientID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelPatientID = new DevComponents.DotNetBar.LabelX();
            this.labelState = new DevComponents.DotNetBar.LabelX();
            this.comboBoxState = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItemMale = new DevComponents.Editors.ComboItem();
            this.comboItemFemale = new DevComponents.Editors.ComboItem();
            this.buttonClose = new DevComponents.DotNetBar.ButtonX();
            this.buttonOk = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // textBoxHospitalBedID
            // 
            // 
            // 
            // 
            this.textBoxHospitalBedID.Border.Class = "TextBoxBorder";
            this.textBoxHospitalBedID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxHospitalBedID.Location = new System.Drawing.Point(109, 12);
            this.textBoxHospitalBedID.Name = "textBoxHospitalBedID";
            this.textBoxHospitalBedID.ReadOnly = true;
            this.textBoxHospitalBedID.Size = new System.Drawing.Size(293, 20);
            this.textBoxHospitalBedID.TabIndex = 33;
            // 
            // labelHospitalBedID
            // 
            // 
            // 
            // 
            this.labelHospitalBedID.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelHospitalBedID.Location = new System.Drawing.Point(11, 9);
            this.labelHospitalBedID.Name = "labelHospitalBedID";
            this.labelHospitalBedID.Size = new System.Drawing.Size(92, 23);
            this.labelHospitalBedID.TabIndex = 31;
            this.labelHospitalBedID.Text = "Mã giường bệnh";
            // 
            // textBoxPatientID
            // 
            // 
            // 
            // 
            this.textBoxPatientID.Border.Class = "TextBoxBorder";
            this.textBoxPatientID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxPatientID.Location = new System.Drawing.Point(109, 38);
            this.textBoxPatientID.Name = "textBoxPatientID";
            this.textBoxPatientID.Size = new System.Drawing.Size(293, 20);
            this.textBoxPatientID.TabIndex = 30;
            // 
            // labelPatientID
            // 
            // 
            // 
            // 
            this.labelPatientID.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelPatientID.Location = new System.Drawing.Point(11, 35);
            this.labelPatientID.Name = "labelPatientID";
            this.labelPatientID.Size = new System.Drawing.Size(92, 23);
            this.labelPatientID.TabIndex = 32;
            this.labelPatientID.Text = "Mã bệnh nhân";
            // 
            // labelState
            // 
            // 
            // 
            // 
            this.labelState.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelState.Location = new System.Drawing.Point(11, 64);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(92, 23);
            this.labelState.TabIndex = 32;
            this.labelState.Text = "Trạng thái";
            // 
            // comboBoxState
            // 
            this.comboBoxState.DisplayMember = "Text";
            this.comboBoxState.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxState.FormattingEnabled = true;
            this.comboBoxState.ItemHeight = 14;
            this.comboBoxState.Items.AddRange(new object[] {
            this.comboItemMale,
            this.comboItemFemale});
            this.comboBoxState.Location = new System.Drawing.Point(109, 64);
            this.comboBoxState.Name = "comboBoxState";
            this.comboBoxState.Size = new System.Drawing.Size(119, 20);
            this.comboBoxState.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBoxState.TabIndex = 34;
            // 
            // comboItemMale
            // 
            this.comboItemMale.Text = "Trống";
            // 
            // comboItemFemale
            // 
            this.comboItemFemale.Text = "Có bệnh nhân";
            // 
            // buttonClose
            // 
            this.buttonClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonClose.Location = new System.Drawing.Point(324, 94);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonClose.TabIndex = 36;
            this.buttonClose.Text = "Đóng";
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonOk.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonOk.Location = new System.Drawing.Point(232, 94);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonOk.TabIndex = 35;
            this.buttonOk.Text = "Đồng ý";
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // FormHostpitalBedDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 120);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.comboBoxState);
            this.Controls.Add(this.textBoxHospitalBedID);
            this.Controls.Add(this.labelHospitalBedID);
            this.Controls.Add(this.textBoxPatientID);
            this.Controls.Add(this.labelState);
            this.Controls.Add(this.labelPatientID);
            this.Name = "FormHostpitalBedDetail";
            this.Text = "FormHostpitalBedDetail";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX textBoxHospitalBedID;
        private DevComponents.DotNetBar.LabelX labelHospitalBedID;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxPatientID;
        private DevComponents.DotNetBar.LabelX labelPatientID;
        private DevComponents.DotNetBar.LabelX labelState;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxState;
        private DevComponents.Editors.ComboItem comboItemMale;
        private DevComponents.Editors.ComboItem comboItemFemale;
        private DevComponents.DotNetBar.ButtonX buttonClose;
        private DevComponents.DotNetBar.ButtonX buttonOk;
    }
}