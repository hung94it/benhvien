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
            this.labelGender = new DevComponents.DotNetBar.LabelX();
            this.labelAddress = new DevComponents.DotNetBar.LabelX();
            this.textBoxAddress = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBoxIdentityCard = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBoxPatientID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelPatientID = new DevComponents.DotNetBar.LabelX();
            this.comboBoxState = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelState = new DevComponents.DotNetBar.LabelX();
            this.comboBoxGender = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.textBoxDeposit = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.textBoxProfession = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelProfession = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.dateBirthday)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOk
            // 
            this.buttonOk.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonOk.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonOk.Location = new System.Drawing.Point(274, 349);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonOk.TabIndex = 0;
            this.buttonOk.Text = "Đồng ý";
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonClose.Location = new System.Drawing.Point(366, 349);
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
            this.labelFirstName.Location = new System.Drawing.Point(12, 38);
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
            this.textBoxFirstName.Location = new System.Drawing.Point(93, 41);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(348, 20);
            this.textBoxFirstName.TabIndex = 3;
            // 
            // textBoxLastName
            // 
            // 
            // 
            // 
            this.textBoxLastName.Border.Class = "TextBoxBorder";
            this.textBoxLastName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxLastName.Location = new System.Drawing.Point(93, 67);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(348, 20);
            this.textBoxLastName.TabIndex = 5;
            // 
            // labelLastName
            // 
            // 
            // 
            // 
            this.labelLastName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelLastName.Location = new System.Drawing.Point(12, 64);
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
            this.labelBirthday.Location = new System.Drawing.Point(12, 90);
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
            this.dateBirthday.Size = new System.Drawing.Size(348, 20);
            this.dateBirthday.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dateBirthday.TabIndex = 8;
            // 
            // labelIdentityCard
            // 
            // 
            // 
            // 
            this.labelIdentityCard.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelIdentityCard.Location = new System.Drawing.Point(12, 142);
            this.labelIdentityCard.Name = "labelIdentityCard";
            this.labelIdentityCard.Size = new System.Drawing.Size(75, 23);
            this.labelIdentityCard.TabIndex = 9;
            this.labelIdentityCard.Text = "CMND:";
            // 
            // labelGender
            // 
            // 
            // 
            // 
            this.labelGender.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelGender.Location = new System.Drawing.Point(12, 116);
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
            this.labelAddress.Location = new System.Drawing.Point(12, 194);
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
            this.textBoxAddress.Location = new System.Drawing.Point(93, 197);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(348, 91);
            this.textBoxAddress.TabIndex = 14;
            // 
            // textBoxIdentityCard
            // 
            // 
            // 
            // 
            this.textBoxIdentityCard.Border.Class = "TextBoxBorder";
            this.textBoxIdentityCard.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxIdentityCard.Location = new System.Drawing.Point(93, 145);
            this.textBoxIdentityCard.Name = "textBoxIdentityCard";
            this.textBoxIdentityCard.Size = new System.Drawing.Size(348, 20);
            this.textBoxIdentityCard.TabIndex = 15;
            // 
            // textBoxPatientID
            // 
            // 
            // 
            // 
            this.textBoxPatientID.Border.Class = "TextBoxBorder";
            this.textBoxPatientID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxPatientID.Location = new System.Drawing.Point(93, 15);
            this.textBoxPatientID.Name = "textBoxPatientID";
            this.textBoxPatientID.Size = new System.Drawing.Size(348, 20);
            this.textBoxPatientID.TabIndex = 17;
            // 
            // labelPatientID
            // 
            // 
            // 
            // 
            this.labelPatientID.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelPatientID.Location = new System.Drawing.Point(12, 12);
            this.labelPatientID.Name = "labelPatientID";
            this.labelPatientID.Size = new System.Drawing.Size(75, 23);
            this.labelPatientID.TabIndex = 16;
            this.labelPatientID.Text = "Mã bệnh nhân:";
            // 
            // comboBoxState
            // 
            this.comboBoxState.DisplayMember = "Text";
            this.comboBoxState.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxState.FormattingEnabled = true;
            this.comboBoxState.ItemHeight = 14;
            this.comboBoxState.Location = new System.Drawing.Point(93, 320);
            this.comboBoxState.Name = "comboBoxState";
            this.comboBoxState.Size = new System.Drawing.Size(240, 20);
            this.comboBoxState.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBoxState.TabIndex = 18;
            // 
            // labelState
            // 
            // 
            // 
            // 
            this.labelState.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelState.Location = new System.Drawing.Point(12, 317);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(75, 23);
            this.labelState.TabIndex = 19;
            this.labelState.Text = "Trạng thái:";
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.DisplayMember = "Text";
            this.comboBoxGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.ItemHeight = 14;
            this.comboBoxGender.Location = new System.Drawing.Point(93, 119);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(240, 20);
            this.comboBoxGender.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBoxGender.TabIndex = 20;
            // 
            // textBoxDeposit
            // 
            // 
            // 
            // 
            this.textBoxDeposit.Border.Class = "TextBoxBorder";
            this.textBoxDeposit.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxDeposit.Location = new System.Drawing.Point(93, 294);
            this.textBoxDeposit.Name = "textBoxDeposit";
            this.textBoxDeposit.Size = new System.Drawing.Size(348, 20);
            this.textBoxDeposit.TabIndex = 22;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(12, 291);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 21;
            this.labelX1.Text = "Tiền đặc cọc:";
            // 
            // textBoxProfession
            // 
            // 
            // 
            // 
            this.textBoxProfession.Border.Class = "TextBoxBorder";
            this.textBoxProfession.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxProfession.Location = new System.Drawing.Point(93, 171);
            this.textBoxProfession.Name = "textBoxProfession";
            this.textBoxProfession.Size = new System.Drawing.Size(348, 20);
            this.textBoxProfession.TabIndex = 24;
            // 
            // labelProfession
            // 
            // 
            // 
            // 
            this.labelProfession.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelProfession.Location = new System.Drawing.Point(12, 168);
            this.labelProfession.Name = "labelProfession";
            this.labelProfession.Size = new System.Drawing.Size(75, 23);
            this.labelProfession.TabIndex = 23;
            this.labelProfession.Text = "Nghề nghiệp:";
            // 
            // FormPatientDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 381);
            this.Controls.Add(this.textBoxProfession);
            this.Controls.Add(this.labelProfession);
            this.Controls.Add(this.textBoxDeposit);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.comboBoxGender);
            this.Controls.Add(this.labelState);
            this.Controls.Add(this.comboBoxState);
            this.Controls.Add(this.textBoxPatientID);
            this.Controls.Add(this.labelPatientID);
            this.Controls.Add(this.textBoxIdentityCard);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelGender);
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
        private DevComponents.DotNetBar.LabelX labelGender;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxAddress;
        private DevComponents.DotNetBar.LabelX labelAddress;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxIdentityCard;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxPatientID;
        private DevComponents.DotNetBar.LabelX labelPatientID;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxState;
        private DevComponents.DotNetBar.LabelX labelState;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxGender;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxDeposit;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxProfession;
        private DevComponents.DotNetBar.LabelX labelProfession;
    }
}