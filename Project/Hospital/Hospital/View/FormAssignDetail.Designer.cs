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
            this.buttonClose = new DevComponents.DotNetBar.ButtonX();
            this.buttonInsertFunction = new DevComponents.DotNetBar.ButtonX();
            this.buttonRemoveFunction = new DevComponents.DotNetBar.ButtonX();
            this.buttonOk = new DevComponents.DotNetBar.ButtonX();
            this.listBoxSystemFunction = new System.Windows.Forms.ListBox();
            this.listBoxCurrentFunction = new System.Windows.Forms.ListBox();
            this.textBoxRoleID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelRoleID = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.textBoxRoleName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelRoleName = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.dateDischarge = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            ((System.ComponentModel.ISupportInitialize)(this.dateDischarge)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonClose.Location = new System.Drawing.Point(321, 358);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonClose.TabIndex = 40;
            this.buttonClose.Text = "Đóng";
            // 
            // buttonInsertFunction
            // 
            this.buttonInsertFunction.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonInsertFunction.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonInsertFunction.Enabled = false;
            this.buttonInsertFunction.Location = new System.Drawing.Point(183, 237);
            this.buttonInsertFunction.Name = "buttonInsertFunction";
            this.buttonInsertFunction.Size = new System.Drawing.Size(37, 23);
            this.buttonInsertFunction.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonInsertFunction.TabIndex = 37;
            this.buttonInsertFunction.Text = "<";
            // 
            // buttonRemoveFunction
            // 
            this.buttonRemoveFunction.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonRemoveFunction.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonRemoveFunction.Enabled = false;
            this.buttonRemoveFunction.Location = new System.Drawing.Point(183, 208);
            this.buttonRemoveFunction.Name = "buttonRemoveFunction";
            this.buttonRemoveFunction.Size = new System.Drawing.Size(37, 23);
            this.buttonRemoveFunction.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonRemoveFunction.TabIndex = 38;
            this.buttonRemoveFunction.Text = ">";
            // 
            // buttonOk
            // 
            this.buttonOk.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonOk.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonOk.Location = new System.Drawing.Point(229, 358);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonOk.TabIndex = 39;
            this.buttonOk.Text = "Đồng ý";
            // 
            // listBoxSystemFunction
            // 
            this.listBoxSystemFunction.Enabled = false;
            this.listBoxSystemFunction.FormattingEnabled = true;
            this.listBoxSystemFunction.Location = new System.Drawing.Point(226, 126);
            this.listBoxSystemFunction.Name = "listBoxSystemFunction";
            this.listBoxSystemFunction.Size = new System.Drawing.Size(170, 212);
            this.listBoxSystemFunction.TabIndex = 35;
            // 
            // listBoxCurrentFunction
            // 
            this.listBoxCurrentFunction.Enabled = false;
            this.listBoxCurrentFunction.FormattingEnabled = true;
            this.listBoxCurrentFunction.Location = new System.Drawing.Point(12, 126);
            this.listBoxCurrentFunction.Name = "listBoxCurrentFunction";
            this.listBoxCurrentFunction.Size = new System.Drawing.Size(165, 212);
            this.listBoxCurrentFunction.TabIndex = 36;
            // 
            // textBoxRoleID
            // 
            // 
            // 
            // 
            this.textBoxRoleID.Border.Class = "TextBoxBorder";
            this.textBoxRoleID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxRoleID.Location = new System.Drawing.Point(110, 15);
            this.textBoxRoleID.Name = "textBoxRoleID";
            this.textBoxRoleID.ReadOnly = true;
            this.textBoxRoleID.Size = new System.Drawing.Size(293, 20);
            this.textBoxRoleID.TabIndex = 34;
            // 
            // labelRoleID
            // 
            // 
            // 
            // 
            this.labelRoleID.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelRoleID.Location = new System.Drawing.Point(12, 12);
            this.labelRoleID.Name = "labelRoleID";
            this.labelRoleID.Size = new System.Drawing.Size(92, 23);
            this.labelRoleID.TabIndex = 30;
            this.labelRoleID.Text = "Mã phân công";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(226, 97);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(145, 23);
            this.labelX2.TabIndex = 31;
            this.labelX2.Text = "Danh sách nhân viên";
            // 
            // textBoxRoleName
            // 
            // 
            // 
            // 
            this.textBoxRoleName.Border.Class = "TextBoxBorder";
            this.textBoxRoleName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxRoleName.Location = new System.Drawing.Point(110, 41);
            this.textBoxRoleName.Name = "textBoxRoleName";
            this.textBoxRoleName.Size = new System.Drawing.Size(293, 20);
            this.textBoxRoleName.TabIndex = 29;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(12, 97);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(196, 23);
            this.labelX1.TabIndex = 32;
            this.labelX1.Text = "Danh sách được phân công";
            // 
            // labelRoleName
            // 
            // 
            // 
            // 
            this.labelRoleName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelRoleName.Location = new System.Drawing.Point(12, 38);
            this.labelRoleName.Name = "labelRoleName";
            this.labelRoleName.Size = new System.Drawing.Size(92, 23);
            this.labelRoleName.TabIndex = 33;
            this.labelRoleName.Text = "Mã bệnh nhân";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(12, 64);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(92, 23);
            this.labelX3.TabIndex = 33;
            this.labelX3.Text = "Ngày xuất viện";
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
            this.dateDischarge.Location = new System.Drawing.Point(110, 67);
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
            this.dateDischarge.TabIndex = 41;
            this.dateDischarge.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // FormAssignDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 436);
            this.Controls.Add(this.dateDischarge);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonInsertFunction);
            this.Controls.Add(this.buttonRemoveFunction);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.listBoxSystemFunction);
            this.Controls.Add(this.listBoxCurrentFunction);
            this.Controls.Add(this.textBoxRoleID);
            this.Controls.Add(this.labelRoleID);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.textBoxRoleName);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.labelRoleName);
            this.Name = "FormAssignDetail";
            this.Text = "FormAssignDetailcs";
            ((System.ComponentModel.ISupportInitialize)(this.dateDischarge)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX buttonClose;
        private DevComponents.DotNetBar.ButtonX buttonInsertFunction;
        private DevComponents.DotNetBar.ButtonX buttonRemoveFunction;
        private DevComponents.DotNetBar.ButtonX buttonOk;
        private System.Windows.Forms.ListBox listBoxSystemFunction;
        private System.Windows.Forms.ListBox listBoxCurrentFunction;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxRoleID;
        private DevComponents.DotNetBar.LabelX labelRoleID;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxRoleName;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelRoleName;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateDischarge;
    }
}