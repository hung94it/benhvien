namespace Hospital.View
{
    partial class FormPatientDetail
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
            this.buttonOk = new DevComponents.DotNetBar.ButtonX();
            this.buttonClose = new DevComponents.DotNetBar.ButtonX();
            this.labelFirstName = new DevComponents.DotNetBar.LabelX();
            this.textBoxFirstName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBoxLastName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelLastName = new DevComponents.DotNetBar.LabelX();
            this.labelBirthday = new DevComponents.DotNetBar.LabelX();
            this.dateBirthday = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelIdentityCard = new DevComponents.DotNetBar.LabelX();
            this.comboTreeGender = new DevComponents.DotNetBar.Controls.ComboTree();
            this.node1 = new DevComponents.AdvTree.Node();
            this.node2 = new DevComponents.AdvTree.Node();
            this.labelGender = new DevComponents.DotNetBar.LabelX();
            this.labelAddress = new DevComponents.DotNetBar.LabelX();
            this.textBoxAddress = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBoxIdentityCard = new DevComponents.DotNetBar.Controls.TextBoxX();
            ((System.ComponentModel.ISupportInitialize)(this.dateBirthday)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOk
            // 
            this.buttonOk.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonOk.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonOk.Location = new System.Drawing.Point(166, 246);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonOk.TabIndex = 0;
            this.buttonOk.Text = "Đồng ý";
            // 
            // buttonClose
            // 
            this.buttonClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonClose.Location = new System.Drawing.Point(247, 246);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "Đóng";
            // 
            // labelFirstName
            // 
            // 
            // 
            // 
            this.labelFirstName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelFirstName.Location = new System.Drawing.Point(12, 12);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(75, 23);
            this.labelFirstName.TabIndex = 2;
            this.labelFirstName.Text = "Tên:";
            // 
            // textBoxFirstName
            // 
            // 
            // 
            // 
            this.textBoxFirstName.Border.Class = "TextBoxBorder";
            this.textBoxFirstName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxFirstName.Location = new System.Drawing.Point(93, 15);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(229, 20);
            this.textBoxFirstName.TabIndex = 3;
            // 
            // textBoxLastName
            // 
            // 
            // 
            // 
            this.textBoxLastName.Border.Class = "TextBoxBorder";
            this.textBoxLastName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxLastName.Location = new System.Drawing.Point(93, 41);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(229, 20);
            this.textBoxLastName.TabIndex = 5;
            // 
            // labelLastName
            // 
            // 
            // 
            // 
            this.labelLastName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelLastName.Location = new System.Drawing.Point(12, 41);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(75, 23);
            this.labelLastName.TabIndex = 4;
            this.labelLastName.Text = "Họ:";
            // 
            // labelBirthday
            // 
            // 
            // 
            // 
            this.labelBirthday.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelBirthday.Location = new System.Drawing.Point(12, 93);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(75, 23);
            this.labelBirthday.TabIndex = 6;
            this.labelBirthday.Text = "Ngày sinh:";
            // 
            // dateBirthday
            // 
            // 
            // 
            // 
            this.dateBirthday.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dateBirthday.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateBirthday.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dateBirthday.ButtonDropDown.Visible = true;
            this.dateBirthday.IsPopupCalendarOpen = false;
            this.dateBirthday.Location = new System.Drawing.Point(93, 93);
            // 
            // 
            // 
            this.dateBirthday.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateBirthday.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateBirthday.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dateBirthday.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dateBirthday.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dateBirthday.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dateBirthday.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dateBirthday.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dateBirthday.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dateBirthday.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dateBirthday.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateBirthday.MonthCalendar.DisplayMonth = new System.DateTime(2012, 5, 1, 0, 0, 0, 0);
            this.dateBirthday.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dateBirthday.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateBirthday.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dateBirthday.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dateBirthday.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dateBirthday.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateBirthday.MonthCalendar.TodayButtonVisible = true;
            this.dateBirthday.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dateBirthday.Name = "dateBirthday";
            this.dateBirthday.Size = new System.Drawing.Size(229, 20);
            this.dateBirthday.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dateBirthday.TabIndex = 8;
            // 
            // labelIdentityCard
            // 
            // 
            // 
            // 
            this.labelIdentityCard.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelIdentityCard.Location = new System.Drawing.Point(12, 67);
            this.labelIdentityCard.Name = "labelIdentityCard";
            this.labelIdentityCard.Size = new System.Drawing.Size(75, 23);
            this.labelIdentityCard.TabIndex = 9;
            this.labelIdentityCard.Text = "CMND:";
            // 
            // comboTreeGender
            // 
            this.comboTreeGender.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.comboTreeGender.BackgroundStyle.Class = "TextBoxBorder";
            this.comboTreeGender.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.comboTreeGender.ButtonDropDown.Visible = true;
            this.comboTreeGender.Location = new System.Drawing.Point(93, 119);
            this.comboTreeGender.Name = "comboTreeGender";
            this.comboTreeGender.Nodes.AddRange(new DevComponents.AdvTree.Node[] {
            this.node1,
            this.node2});
            this.comboTreeGender.Size = new System.Drawing.Size(112, 23);
            this.comboTreeGender.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboTreeGender.TabIndex = 10;
            // 
            // node1
            // 
            this.node1.Name = "node1";
            this.node1.Text = "Nam";
            // 
            // node2
            // 
            this.node2.Name = "node2";
            this.node2.Text = "Nữ";
            // 
            // labelGender
            // 
            // 
            // 
            // 
            this.labelGender.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelGender.Location = new System.Drawing.Point(12, 122);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(75, 23);
            this.labelGender.TabIndex = 12;
            this.labelGender.Text = "Giới tính:";
            // 
            // labelAddress
            // 
            // 
            // 
            // 
            this.labelAddress.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelAddress.Location = new System.Drawing.Point(12, 152);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(75, 23);
            this.labelAddress.TabIndex = 13;
            this.labelAddress.Text = "Địa chỉ:";
            // 
            // textBoxAddress
            // 
            // 
            // 
            // 
            this.textBoxAddress.Border.Class = "TextBoxBorder";
            this.textBoxAddress.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxAddress.Location = new System.Drawing.Point(93, 149);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(229, 91);
            this.textBoxAddress.TabIndex = 14;
            // 
            // textBoxIdentityCard
            // 
            // 
            // 
            // 
            this.textBoxIdentityCard.Border.Class = "TextBoxBorder";
            this.textBoxIdentityCard.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxIdentityCard.Location = new System.Drawing.Point(93, 68);
            this.textBoxIdentityCard.Name = "textBoxIdentityCard";
            this.textBoxIdentityCard.Size = new System.Drawing.Size(229, 20);
            this.textBoxIdentityCard.TabIndex = 15;
            // 
            // FormPatientDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 279);
            this.Controls.Add(this.textBoxIdentityCard);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.comboTreeGender);
            this.Controls.Add(this.labelIdentityCard);
            this.Controls.Add(this.dateBirthday);
            this.Controls.Add(this.labelBirthday);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonOk);
            this.Name = "FormPatientDetail";
            this.Text = "Thông tin bệnh nhân";
            ((System.ComponentModel.ISupportInitialize)(this.dateBirthday)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX buttonOk;
        private DevComponents.DotNetBar.ButtonX buttonClose;
        private DevComponents.DotNetBar.LabelX labelFirstName;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxFirstName;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxLastName;
        private DevComponents.DotNetBar.LabelX labelLastName;
        private DevComponents.DotNetBar.LabelX labelBirthday;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateBirthday;
        private DevComponents.DotNetBar.LabelX labelIdentityCard;
        private DevComponents.DotNetBar.Controls.ComboTree comboTreeGender;
        private DevComponents.DotNetBar.LabelX labelGender;
        private DevComponents.AdvTree.Node node1;
        private DevComponents.AdvTree.Node node2;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxAddress;
        private DevComponents.DotNetBar.LabelX labelAddress;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxIdentityCard;
    }
}