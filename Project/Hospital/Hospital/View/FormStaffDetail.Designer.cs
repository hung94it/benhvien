namespace Hospital.View
{
    partial class FormStaffDetail
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
            this.textBoxFirstName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelFirstName = new DevComponents.DotNetBar.LabelX();
            this.labelLastName = new DevComponents.DotNetBar.LabelX();
            this.textBoxLastName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBoxIdentityCard = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBoxAddress = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelAddress = new DevComponents.DotNetBar.LabelX();
            this.labelGender = new DevComponents.DotNetBar.LabelX();
            this.comboTreeGender = new DevComponents.DotNetBar.Controls.ComboTree();
            this.node1 = new DevComponents.AdvTree.Node();
            this.node2 = new DevComponents.AdvTree.Node();
            this.labelIdentityCard = new DevComponents.DotNetBar.LabelX();
            this.dateInputBirthday = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelBirthday = new DevComponents.DotNetBar.LabelX();
            this.buttonClose = new DevComponents.DotNetBar.ButtonX();
            this.buttonOk = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.dateInputBirthday)).BeginInit();
            this.SuspendLayout();
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
            this.textBoxFirstName.TabIndex = 0;
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
            this.labelFirstName.TabIndex = 1;
            this.labelFirstName.Text = "Tên:";
            // 
            // labelLastName
            // 
            // 
            // 
            // 
            this.labelLastName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelLastName.Location = new System.Drawing.Point(12, 38);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(75, 23);
            this.labelLastName.TabIndex = 3;
            this.labelLastName.Text = "Họ:";
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
            this.textBoxLastName.TabIndex = 2;
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
            this.textBoxIdentityCard.TabIndex = 25;
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
            this.textBoxAddress.TabIndex = 24;
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
            this.labelAddress.TabIndex = 23;
            this.labelAddress.Text = "Địa chỉ:";
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
            this.labelGender.TabIndex = 22;
            this.labelGender.Text = "Giới tính:";
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
            this.comboTreeGender.TabIndex = 21;
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
            // labelIdentityCard
            // 
            // 
            // 
            // 
            this.labelIdentityCard.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelIdentityCard.Location = new System.Drawing.Point(12, 67);
            this.labelIdentityCard.Name = "labelIdentityCard";
            this.labelIdentityCard.Size = new System.Drawing.Size(75, 23);
            this.labelIdentityCard.TabIndex = 20;
            this.labelIdentityCard.Text = "CMND:";
            // 
            // dateInputBirthday
            // 
            // 
            // 
            // 
            this.dateInputBirthday.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dateInputBirthday.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateInputBirthday.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dateInputBirthday.ButtonDropDown.Visible = true;
            this.dateInputBirthday.IsPopupCalendarOpen = false;
            this.dateInputBirthday.Location = new System.Drawing.Point(93, 93);
            // 
            // 
            // 
            this.dateInputBirthday.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateInputBirthday.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateInputBirthday.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dateInputBirthday.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dateInputBirthday.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dateInputBirthday.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dateInputBirthday.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dateInputBirthday.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dateInputBirthday.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dateInputBirthday.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dateInputBirthday.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateInputBirthday.MonthCalendar.DisplayMonth = new System.DateTime(2012, 5, 1, 0, 0, 0, 0);
            this.dateInputBirthday.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dateInputBirthday.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateInputBirthday.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dateInputBirthday.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dateInputBirthday.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dateInputBirthday.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateInputBirthday.MonthCalendar.TodayButtonVisible = true;
            this.dateInputBirthday.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dateInputBirthday.Name = "dateInputBirthday";
            this.dateInputBirthday.Size = new System.Drawing.Size(229, 20);
            this.dateInputBirthday.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dateInputBirthday.TabIndex = 19;
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
            this.labelBirthday.TabIndex = 18;
            this.labelBirthday.Text = "Ngày sinh:";
            // 
            // buttonClose
            // 
            this.buttonClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonClose.Location = new System.Drawing.Point(247, 246);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonClose.TabIndex = 17;
            this.buttonClose.Text = "Đóng";
            // 
            // buttonOk
            // 
            this.buttonOk.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonOk.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonOk.Location = new System.Drawing.Point(166, 246);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonOk.TabIndex = 16;
            this.buttonOk.Text = "Đồng ý";
            // 
            // FormStaffDetail
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
            this.Controls.Add(this.dateInputBirthday);
            this.Controls.Add(this.labelBirthday);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.textBoxFirstName);
            this.Name = "FormStaffDetail";
            this.Text = "FormStaffDetail";
            ((System.ComponentModel.ISupportInitialize)(this.dateInputBirthday)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX textBoxFirstName;
        private DevComponents.DotNetBar.LabelX labelFirstName;
        private DevComponents.DotNetBar.LabelX labelLastName;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxLastName;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxIdentityCard;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxAddress;
        private DevComponents.DotNetBar.LabelX labelAddress;
        private DevComponents.DotNetBar.LabelX labelGender;
        private DevComponents.DotNetBar.Controls.ComboTree comboTreeGender;
        private DevComponents.AdvTree.Node node1;
        private DevComponents.AdvTree.Node node2;
        private DevComponents.DotNetBar.LabelX labelIdentityCard;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateInputBirthday;
        private DevComponents.DotNetBar.LabelX labelBirthday;
        private DevComponents.DotNetBar.ButtonX buttonClose;
        private DevComponents.DotNetBar.ButtonX buttonOk;
    }
}