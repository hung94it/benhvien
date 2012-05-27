namespace Hospital.View
{
    partial class FormDCDetail
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
            this.buttonOk = new DevComponents.DotNetBar.ButtonX();
            this.buttonClose = new DevComponents.DotNetBar.ButtonX();
            this.labelState = new DevComponents.DotNetBar.LabelX();
            this.comboBoxState = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItemNo = new DevComponents.Editors.ComboItem();
            this.comboItemYes = new DevComponents.Editors.ComboItem();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.dateDischarge = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.textBoxStaffID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.textBoxDCID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelHCID = new DevComponents.DotNetBar.LabelX();
            this.textBoxPatientID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelRoleName = new DevComponents.DotNetBar.LabelX();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateDischarge)).BeginInit();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.buttonOk);
            this.groupPanel1.Controls.Add(this.buttonClose);
            this.groupPanel1.Controls.Add(this.labelState);
            this.groupPanel1.Controls.Add(this.comboBoxState);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Controls.Add(this.dateDischarge);
            this.groupPanel1.Controls.Add(this.textBoxStaffID);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.Controls.Add(this.textBoxDCID);
            this.groupPanel1.Controls.Add(this.labelHCID);
            this.groupPanel1.Controls.Add(this.textBoxPatientID);
            this.groupPanel1.Controls.Add(this.labelRoleName);
            this.groupPanel1.Location = new System.Drawing.Point(12, 3);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(453, 185);
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
            this.groupPanel1.TabIndex = 1;
            this.groupPanel1.Text = "Giấy xuất viện";
            // 
            // buttonOk
            // 
            this.buttonOk.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonOk.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonOk.Location = new System.Drawing.Point(251, 135);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonOk.TabIndex = 60;
            this.buttonOk.Text = "Đồng ý";
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonClose.Location = new System.Drawing.Point(343, 135);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonClose.TabIndex = 61;
            this.buttonClose.Text = "Đóng";
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelState
            // 
            this.labelState.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelState.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelState.Location = new System.Drawing.Point(3, 107);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(75, 23);
            this.labelState.TabIndex = 67;
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
            this.comboBoxState.Location = new System.Drawing.Point(125, 110);
            this.comboBoxState.Name = "comboBoxState";
            this.comboBoxState.Size = new System.Drawing.Size(127, 20);
            this.comboBoxState.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBoxState.TabIndex = 59;
            // 
            // comboItemNo
            // 
            this.comboItemNo.Text = "Chưa xác nhận";
            // 
            // comboItemYes
            // 
            this.comboItemYes.Text = "Đã xác nhận";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(3, 81);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(121, 23);
            this.labelX2.TabIndex = 66;
            this.labelX2.Text = "Ngày xuất viện";
            // 
            // dateDischarge
            // 
            // 
            // 
            // 
            this.dateDischarge.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dateDischarge.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateDischarge.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dateDischarge.ButtonDropDown.Visible = true;
            this.dateDischarge.IsPopupCalendarOpen = false;
            this.dateDischarge.Location = new System.Drawing.Point(125, 84);
            // 
            // 
            // 
            this.dateDischarge.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateDischarge.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateDischarge.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dateDischarge.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dateDischarge.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dateDischarge.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dateDischarge.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dateDischarge.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dateDischarge.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dateDischarge.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dateDischarge.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateDischarge.MonthCalendar.DisplayMonth = new System.DateTime(2012, 5, 1, 0, 0, 0, 0);
            this.dateDischarge.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dateDischarge.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateDischarge.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dateDischarge.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dateDischarge.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dateDischarge.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateDischarge.MonthCalendar.TodayButtonVisible = true;
            this.dateDischarge.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dateDischarge.Name = "dateDischarge";
            this.dateDischarge.Size = new System.Drawing.Size(293, 20);
            this.dateDischarge.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dateDischarge.TabIndex = 58;
            this.dateDischarge.Value = new System.DateTime(2012, 5, 20, 0, 0, 0, 0);
            // 
            // textBoxStaffID
            // 
            // 
            // 
            // 
            this.textBoxStaffID.Border.Class = "TextBoxBorder";
            this.textBoxStaffID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxStaffID.Location = new System.Drawing.Point(125, 32);
            this.textBoxStaffID.Name = "textBoxStaffID";
            this.textBoxStaffID.ReadOnly = true;
            this.textBoxStaffID.Size = new System.Drawing.Size(293, 20);
            this.textBoxStaffID.TabIndex = 55;
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(3, 29);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(92, 23);
            this.labelX1.TabIndex = 62;
            this.labelX1.Text = "Mã nhân viên lập";
            // 
            // textBoxDCID
            // 
            // 
            // 
            // 
            this.textBoxDCID.Border.Class = "TextBoxBorder";
            this.textBoxDCID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxDCID.Location = new System.Drawing.Point(125, 6);
            this.textBoxDCID.Name = "textBoxDCID";
            this.textBoxDCID.ReadOnly = true;
            this.textBoxDCID.Size = new System.Drawing.Size(293, 20);
            this.textBoxDCID.TabIndex = 54;
            // 
            // labelHCID
            // 
            this.labelHCID.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelHCID.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelHCID.Location = new System.Drawing.Point(3, 3);
            this.labelHCID.Name = "labelHCID";
            this.labelHCID.Size = new System.Drawing.Size(92, 23);
            this.labelHCID.TabIndex = 63;
            this.labelHCID.Text = "Mã giấy xuất viện";
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
            this.textBoxPatientID.Location = new System.Drawing.Point(125, 58);
            this.textBoxPatientID.Name = "textBoxPatientID";
            this.textBoxPatientID.ReadOnly = true;
            this.textBoxPatientID.Size = new System.Drawing.Size(293, 20);
            this.textBoxPatientID.TabIndex = 56;
            // 
            // labelRoleName
            // 
            this.labelRoleName.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelRoleName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelRoleName.Location = new System.Drawing.Point(3, 55);
            this.labelRoleName.Name = "labelRoleName";
            this.labelRoleName.Size = new System.Drawing.Size(92, 23);
            this.labelRoleName.TabIndex = 64;
            this.labelRoleName.Text = "Mã bệnh nhân";
            // 
            // FormDCDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 196);
            this.Controls.Add(this.groupPanel1);
            this.Name = "FormDCDetail";
            this.Text = "Thông tin giấy xuất viện";
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dateDischarge)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.ButtonX buttonOk;
        private DevComponents.DotNetBar.ButtonX buttonClose;
        private DevComponents.DotNetBar.LabelX labelState;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxState;
        private DevComponents.Editors.ComboItem comboItemNo;
        private DevComponents.Editors.ComboItem comboItemYes;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateDischarge;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxStaffID;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxDCID;
        private DevComponents.DotNetBar.LabelX labelHCID;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxPatientID;
        private DevComponents.DotNetBar.LabelX labelRoleName;
    }
}