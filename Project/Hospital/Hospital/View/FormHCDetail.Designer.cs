namespace Hospital.View
{
    partial class FormHCDetail
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
            this.textBoxHCID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelHCID = new DevComponents.DotNetBar.LabelX();
            this.textBoxPatientID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelRoleName = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.textBoxStaffID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBoxReason = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelAddress = new DevComponents.DotNetBar.LabelX();
            this.labelState = new DevComponents.DotNetBar.LabelX();
            this.comboBoxState = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItemNo = new DevComponents.Editors.ComboItem();
            this.comboItemYes = new DevComponents.Editors.ComboItem();
            this.buttonOk = new DevComponents.DotNetBar.ButtonX();
            this.buttonClose = new DevComponents.DotNetBar.ButtonX();
            this.dateHospitalizate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.dateHospitalizate)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxHCID
            // 
            // 
            // 
            // 
            this.textBoxHCID.Border.Class = "TextBoxBorder";
            this.textBoxHCID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxHCID.Location = new System.Drawing.Point(133, 12);
            this.textBoxHCID.Name = "textBoxHCID";
            this.textBoxHCID.ReadOnly = true;
            this.textBoxHCID.Size = new System.Drawing.Size(293, 20);
            this.textBoxHCID.TabIndex = 46;
            // 
            // labelHCID
            // 
            // 
            // 
            // 
            this.labelHCID.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelHCID.Location = new System.Drawing.Point(11, 9);
            this.labelHCID.Name = "labelHCID";
            this.labelHCID.Size = new System.Drawing.Size(92, 23);
            this.labelHCID.TabIndex = 43;
            this.labelHCID.Text = "Mã giấy nhập viện";
            // 
            // textBoxPatientID
            // 
            this.textBoxPatientID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxPatientID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            // 
            // 
            // 
            this.textBoxPatientID.Border.Class = "TextBoxBorder";
            this.textBoxPatientID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxPatientID.Location = new System.Drawing.Point(133, 64);
            this.textBoxPatientID.Name = "textBoxPatientID";
            this.textBoxPatientID.Size = new System.Drawing.Size(293, 20);
            this.textBoxPatientID.TabIndex = 42;
            // 
            // labelRoleName
            // 
            // 
            // 
            // 
            this.labelRoleName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelRoleName.Location = new System.Drawing.Point(11, 61);
            this.labelRoleName.Name = "labelRoleName";
            this.labelRoleName.Size = new System.Drawing.Size(92, 23);
            this.labelRoleName.TabIndex = 45;
            this.labelRoleName.Text = "Mã bệnh nhân";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(11, 35);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(92, 23);
            this.labelX1.TabIndex = 43;
            this.labelX1.Text = "Mã nhân viên lập";
            // 
            // textBoxStaffID
            // 
            // 
            // 
            // 
            this.textBoxStaffID.Border.Class = "TextBoxBorder";
            this.textBoxStaffID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxStaffID.Location = new System.Drawing.Point(133, 38);
            this.textBoxStaffID.Name = "textBoxStaffID";
            this.textBoxStaffID.ReadOnly = true;
            this.textBoxStaffID.Size = new System.Drawing.Size(293, 20);
            this.textBoxStaffID.TabIndex = 46;
            // 
            // textBoxReason
            // 
            // 
            // 
            // 
            this.textBoxReason.Border.Class = "TextBoxBorder";
            this.textBoxReason.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxReason.Location = new System.Drawing.Point(133, 90);
            this.textBoxReason.Multiline = true;
            this.textBoxReason.Name = "textBoxReason";
            this.textBoxReason.Size = new System.Drawing.Size(293, 91);
            this.textBoxReason.TabIndex = 48;
            // 
            // labelAddress
            // 
            this.labelAddress.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelAddress.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelAddress.Location = new System.Drawing.Point(11, 87);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(50, 23);
            this.labelAddress.TabIndex = 49;
            this.labelAddress.Text = "Lý do";
            // 
            // labelState
            // 
            this.labelState.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelState.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelState.Location = new System.Drawing.Point(11, 210);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(75, 23);
            this.labelState.TabIndex = 53;
            this.labelState.Text = "Trạng thái:";
            // 
            // comboBoxState
            // 
            this.comboBoxState.DisplayMember = "Text";
            this.comboBoxState.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxState.FormattingEnabled = true;
            this.comboBoxState.ItemHeight = 14;
            this.comboBoxState.Items.AddRange(new object[] {
            this.comboItemNo,
            this.comboItemYes});
            this.comboBoxState.Location = new System.Drawing.Point(133, 213);
            this.comboBoxState.Name = "comboBoxState";
            this.comboBoxState.Size = new System.Drawing.Size(127, 20);
            this.comboBoxState.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBoxState.TabIndex = 52;
            // 
            // comboItemNo
            // 
            this.comboItemNo.Text = "Chưa xác nhận";
            // 
            // comboItemYes
            // 
            this.comboItemYes.Text = "Đã xác nhận";
            // 
            // buttonOk
            // 
            this.buttonOk.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonOk.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonOk.Location = new System.Drawing.Point(252, 239);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonOk.TabIndex = 54;
            this.buttonOk.Text = "Đồng ý";
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonClose.Location = new System.Drawing.Point(344, 239);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonClose.TabIndex = 55;
            this.buttonClose.Text = "Đóng";
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // dateHospitalizate
            // 
            // 
            // 
            // 
            this.dateHospitalizate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dateHospitalizate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateHospitalizate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dateHospitalizate.ButtonDropDown.Visible = true;
            this.dateHospitalizate.IsPopupCalendarOpen = false;
            this.dateHospitalizate.Location = new System.Drawing.Point(133, 187);
            // 
            // 
            // 
            this.dateHospitalizate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateHospitalizate.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateHospitalizate.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dateHospitalizate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dateHospitalizate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dateHospitalizate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dateHospitalizate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dateHospitalizate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dateHospitalizate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dateHospitalizate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dateHospitalizate.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateHospitalizate.MonthCalendar.DisplayMonth = new System.DateTime(2012, 5, 1, 0, 0, 0, 0);
            this.dateHospitalizate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dateHospitalizate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateHospitalizate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dateHospitalizate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dateHospitalizate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dateHospitalizate.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateHospitalizate.MonthCalendar.TodayButtonVisible = true;
            this.dateHospitalizate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dateHospitalizate.Name = "dateHospitalizate";
            this.dateHospitalizate.Size = new System.Drawing.Size(293, 20);
            this.dateHospitalizate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dateHospitalizate.TabIndex = 50;
            this.dateHospitalizate.Value = new System.DateTime(2012, 5, 20, 0, 0, 0, 0);
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(11, 184);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(121, 23);
            this.labelX2.TabIndex = 51;
            this.labelX2.Text = "Ngày nhập viện";
            // 
            // FormHCDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 266);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.labelState);
            this.Controls.Add(this.comboBoxState);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.dateHospitalizate);
            this.Controls.Add(this.textBoxReason);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.textBoxStaffID);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.textBoxHCID);
            this.Controls.Add(this.labelHCID);
            this.Controls.Add(this.textBoxPatientID);
            this.Controls.Add(this.labelRoleName);
            this.Name = "FormHCDetail";
            this.Text = "FormHCDetail";
            ((System.ComponentModel.ISupportInitialize)(this.dateHospitalizate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX textBoxHCID;
        private DevComponents.DotNetBar.LabelX labelHCID;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxPatientID;
        private DevComponents.DotNetBar.LabelX labelRoleName;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxStaffID;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxReason;
        private DevComponents.DotNetBar.LabelX labelAddress;
        private DevComponents.DotNetBar.LabelX labelState;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxState;
        private DevComponents.Editors.ComboItem comboItemNo;
        private DevComponents.Editors.ComboItem comboItemYes;
        private DevComponents.DotNetBar.ButtonX buttonOk;
        private DevComponents.DotNetBar.ButtonX buttonClose;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateHospitalizate;
        private DevComponents.DotNetBar.LabelX labelX2;
    }
}