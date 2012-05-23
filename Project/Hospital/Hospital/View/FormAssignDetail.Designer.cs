namespace Hospital.View
{
    partial class FormAssignDetail
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
            this.dateDischarge = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.dateHospitalize = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.buttonClose = new DevComponents.DotNetBar.ButtonX();
            this.buttonInsertFunction = new DevComponents.DotNetBar.ButtonX();
            this.buttonRemoveFunction = new DevComponents.DotNetBar.ButtonX();
            this.buttonOk = new DevComponents.DotNetBar.ButtonX();
            this.listBoxSystemFunction = new System.Windows.Forms.ListBox();
            this.listBoxCurrentFunction = new System.Windows.Forms.ListBox();
            this.textBoxRoleID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelRoleID = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.textBoxRoleName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelRoleName = new DevComponents.DotNetBar.LabelX();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateDischarge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateHospitalize)).BeginInit();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.dateDischarge);
            this.groupPanel1.Controls.Add(this.dateHospitalize);
            this.groupPanel1.Controls.Add(this.buttonClose);
            this.groupPanel1.Controls.Add(this.buttonInsertFunction);
            this.groupPanel1.Controls.Add(this.buttonRemoveFunction);
            this.groupPanel1.Controls.Add(this.buttonOk);
            this.groupPanel1.Controls.Add(this.listBoxSystemFunction);
            this.groupPanel1.Controls.Add(this.listBoxCurrentFunction);
            this.groupPanel1.Controls.Add(this.textBoxRoleID);
            this.groupPanel1.Controls.Add(this.labelRoleID);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Controls.Add(this.labelX4);
            this.groupPanel1.Controls.Add(this.textBoxRoleName);
            this.groupPanel1.Controls.Add(this.labelX3);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.Controls.Add(this.labelRoleName);
            this.groupPanel1.Location = new System.Drawing.Point(12, 3);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(404, 419);
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
            this.groupPanel1.Text = "Bảng phân công";
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
            this.dateDischarge.Location = new System.Drawing.Point(101, 84);
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
            this.dateDischarge.TabIndex = 56;
            this.dateDischarge.Value = new System.DateTime(2012, 5, 23, 0, 0, 0, 0);
            // 
            // dateHospitalize
            // 
            // 
            // 
            // 
            this.dateHospitalize.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dateHospitalize.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateHospitalize.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dateHospitalize.ButtonDropDown.Visible = true;
            this.dateHospitalize.Enabled = false;
            this.dateHospitalize.IsPopupCalendarOpen = false;
            this.dateHospitalize.Location = new System.Drawing.Point(101, 58);
            // 
            // 
            // 
            this.dateHospitalize.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateHospitalize.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateHospitalize.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            // 
            // 
            // 
            this.dateHospitalize.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateHospitalize.MonthCalendar.DisplayMonth = new System.DateTime(2012, 5, 1, 0, 0, 0, 0);
            this.dateHospitalize.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dateHospitalize.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateHospitalize.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateHospitalize.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dateHospitalize.Name = "dateHospitalize";
            this.dateHospitalize.Size = new System.Drawing.Size(293, 20);
            this.dateHospitalize.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dateHospitalize.TabIndex = 57;
            this.dateHospitalize.Value = new System.DateTime(2012, 5, 23, 0, 0, 0, 0);
            // 
            // buttonClose
            // 
            this.buttonClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonClose.Location = new System.Drawing.Point(316, 374);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonClose.TabIndex = 55;
            this.buttonClose.Text = "Đóng";
            // 
            // buttonInsertFunction
            // 
            this.buttonInsertFunction.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonInsertFunction.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonInsertFunction.Enabled = false;
            this.buttonInsertFunction.Location = new System.Drawing.Point(179, 267);
            this.buttonInsertFunction.Name = "buttonInsertFunction";
            this.buttonInsertFunction.Size = new System.Drawing.Size(37, 23);
            this.buttonInsertFunction.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonInsertFunction.TabIndex = 52;
            this.buttonInsertFunction.Text = "<";
            // 
            // buttonRemoveFunction
            // 
            this.buttonRemoveFunction.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonRemoveFunction.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonRemoveFunction.Enabled = false;
            this.buttonRemoveFunction.Location = new System.Drawing.Point(179, 238);
            this.buttonRemoveFunction.Name = "buttonRemoveFunction";
            this.buttonRemoveFunction.Size = new System.Drawing.Size(37, 23);
            this.buttonRemoveFunction.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonRemoveFunction.TabIndex = 53;
            this.buttonRemoveFunction.Text = ">";
            // 
            // buttonOk
            // 
            this.buttonOk.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonOk.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonOk.Location = new System.Drawing.Point(224, 374);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonOk.TabIndex = 54;
            this.buttonOk.Text = "Đồng ý";
            // 
            // listBoxSystemFunction
            // 
            this.listBoxSystemFunction.Enabled = false;
            this.listBoxSystemFunction.FormattingEnabled = true;
            this.listBoxSystemFunction.Location = new System.Drawing.Point(224, 156);
            this.listBoxSystemFunction.Name = "listBoxSystemFunction";
            this.listBoxSystemFunction.Size = new System.Drawing.Size(170, 212);
            this.listBoxSystemFunction.TabIndex = 50;
            // 
            // listBoxCurrentFunction
            // 
            this.listBoxCurrentFunction.Enabled = false;
            this.listBoxCurrentFunction.FormattingEnabled = true;
            this.listBoxCurrentFunction.Location = new System.Drawing.Point(3, 156);
            this.listBoxCurrentFunction.Name = "listBoxCurrentFunction";
            this.listBoxCurrentFunction.Size = new System.Drawing.Size(165, 212);
            this.listBoxCurrentFunction.TabIndex = 51;
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
            this.textBoxRoleID.TabIndex = 49;
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
            this.labelRoleID.TabIndex = 43;
            this.labelRoleID.Text = "Mã phân công";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(217, 127);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(145, 23);
            this.labelX2.TabIndex = 44;
            this.labelX2.Text = "Danh sách nhân viên";
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(3, 81);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(92, 23);
            this.labelX4.TabIndex = 46;
            this.labelX4.Text = "Ngày xuất viện";
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
            this.textBoxRoleName.ReadOnly = true;
            this.textBoxRoleName.Size = new System.Drawing.Size(293, 20);
            this.textBoxRoleName.TabIndex = 42;
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(3, 55);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(92, 23);
            this.labelX3.TabIndex = 48;
            this.labelX3.Text = "Ngày nhập viện";
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(3, 127);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(196, 23);
            this.labelX1.TabIndex = 45;
            this.labelX1.Text = "Danh sách được phân công";
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
            this.labelRoleName.TabIndex = 47;
            this.labelRoleName.Text = "Mã bệnh nhân";
            // 
            // FormAssignDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 426);
            this.Controls.Add(this.groupPanel1);
            this.Name = "FormAssignDetail";
            this.Text = "Thông tin bảng phân công";
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dateDischarge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateHospitalize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateDischarge;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateHospitalize;
        private DevComponents.DotNetBar.ButtonX buttonClose;
        private DevComponents.DotNetBar.ButtonX buttonInsertFunction;
        private DevComponents.DotNetBar.ButtonX buttonRemoveFunction;
        private DevComponents.DotNetBar.ButtonX buttonOk;
        private System.Windows.Forms.ListBox listBoxSystemFunction;
        private System.Windows.Forms.ListBox listBoxCurrentFunction;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxRoleID;
        private DevComponents.DotNetBar.LabelX labelRoleID;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxRoleName;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelRoleName;

    }
}