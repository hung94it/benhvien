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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStaffDetail));
            this.comboBoxGender = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItemMale = new DevComponents.Editors.ComboItem();
            this.comboItemFemale = new DevComponents.Editors.ComboItem();
            this.labelState = new DevComponents.DotNetBar.LabelX();
            this.comboBoxState = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.textBoxStaffID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelStaffID = new DevComponents.DotNetBar.LabelX();
            this.textBoxIdentityCard = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBoxAddress = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelAddress = new DevComponents.DotNetBar.LabelX();
            this.labelGender = new DevComponents.DotNetBar.LabelX();
            this.labelIdentityCard = new DevComponents.DotNetBar.LabelX();
            this.dateBirthday = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelBirthday = new DevComponents.DotNetBar.LabelX();
            this.textBoxLastName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelLastName = new DevComponents.DotNetBar.LabelX();
            this.textBoxFirstName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelFirstName = new DevComponents.DotNetBar.LabelX();
            this.buttonClose = new DevComponents.DotNetBar.ButtonX();
            this.buttonOk = new DevComponents.DotNetBar.ButtonX();
            this.labelDepartment = new DevComponents.DotNetBar.LabelX();
            this.comboBoxDepartment = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelMajor = new DevComponents.DotNetBar.LabelX();
            this.comboBoxMajor = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.textBoxPassword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelPassword = new DevComponents.DotNetBar.LabelX();
            this.textBoxPasswordCheck = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelPasswordCheck = new DevComponents.DotNetBar.LabelX();
            this.groupPanelAccout = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.groupPanelInformation = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.labelRole = new DevComponents.DotNetBar.LabelX();
            this.comboBoxRole = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.superValidator1 = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.regularExpressionValidator1 = new DevComponents.DotNetBar.Validator.RegularExpressionValidator();
            this.requiredFieldValidator2 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Phải điền họ");
            this.requiredFieldValidator1 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Phải điền tên");
            this.compareValidator1 = new DevComponents.DotNetBar.Validator.CompareValidator();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.highlighter1 = new DevComponents.DotNetBar.Validator.Highlighter();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            ((System.ComponentModel.ISupportInitialize)(this.dateBirthday)).BeginInit();
            this.groupPanelAccout.SuspendLayout();
            this.groupPanelInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.DisplayMember = "Text";
            this.comboBoxGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.ItemHeight = 14;
            this.comboBoxGender.Items.AddRange(new object[] {
            this.comboItemMale,
            this.comboItemFemale});
            this.comboBoxGender.Location = new System.Drawing.Point(104, 110);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(240, 20);
            this.comboBoxGender.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBoxGender.TabIndex = 26;
            // 
            // comboItemMale
            // 
            this.comboItemMale.Text = "Nam";
            // 
            // comboItemFemale
            // 
            this.comboItemFemale.Text = "Nữ";
            // 
            // labelState
            // 
            this.labelState.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelState.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelState.Location = new System.Drawing.Point(23, 311);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(75, 23);
            this.labelState.TabIndex = 42;
            this.labelState.Text = "Trạng thái:";
            // 
            // comboBoxState
            // 
            this.comboBoxState.DisplayMember = "Text";
            this.comboBoxState.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxState.FormattingEnabled = true;
            this.comboBoxState.ItemHeight = 14;
            this.comboBoxState.Items.AddRange(new object[] {
            this.comboItem2,
            this.comboItem1});
            this.comboBoxState.Location = new System.Drawing.Point(104, 311);
            this.comboBoxState.Name = "comboBoxState";
            this.comboBoxState.Size = new System.Drawing.Size(240, 20);
            this.comboBoxState.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBoxState.TabIndex = 30;
            // 
            // textBoxStaffID
            // 
            this.textBoxStaffID.BackColor = System.Drawing.Color.WhiteSmoke;
            // 
            // 
            // 
            this.textBoxStaffID.Border.Class = "TextBoxBorder";
            this.textBoxStaffID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxStaffID.Location = new System.Drawing.Point(104, 6);
            this.textBoxStaffID.Name = "textBoxStaffID";
            this.textBoxStaffID.ReadOnly = true;
            this.textBoxStaffID.Size = new System.Drawing.Size(348, 20);
            this.textBoxStaffID.TabIndex = 43;
            // 
            // labelStaffID
            // 
            this.labelStaffID.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelStaffID.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelStaffID.Location = new System.Drawing.Point(23, 3);
            this.labelStaffID.Name = "labelStaffID";
            this.labelStaffID.Size = new System.Drawing.Size(75, 23);
            this.labelStaffID.TabIndex = 33;
            this.labelStaffID.Text = "Mã nhân viên:";
            // 
            // textBoxIdentityCard
            // 
            // 
            // 
            // 
            this.textBoxIdentityCard.Border.Class = "TextBoxBorder";
            this.textBoxIdentityCard.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxIdentityCard.Location = new System.Drawing.Point(104, 58);
            this.textBoxIdentityCard.Name = "textBoxIdentityCard";
            this.textBoxIdentityCard.Size = new System.Drawing.Size(348, 20);
            this.textBoxIdentityCard.TabIndex = 24;
            this.superValidator1.SetValidator1(this.textBoxIdentityCard, this.regularExpressionValidator1);
            // 
            // textBoxAddress
            // 
            // 
            // 
            // 
            this.textBoxAddress.Border.Class = "TextBoxBorder";
            this.textBoxAddress.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxAddress.Location = new System.Drawing.Point(104, 136);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(348, 91);
            this.textBoxAddress.TabIndex = 28;
            // 
            // labelAddress
            // 
            this.labelAddress.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelAddress.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelAddress.Location = new System.Drawing.Point(23, 133);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(75, 23);
            this.labelAddress.TabIndex = 40;
            this.labelAddress.Text = "Địa chỉ:";
            // 
            // labelGender
            // 
            this.labelGender.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelGender.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelGender.Location = new System.Drawing.Point(23, 107);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(75, 23);
            this.labelGender.TabIndex = 38;
            this.labelGender.Text = "Giới tính:";
            // 
            // labelIdentityCard
            // 
            this.labelIdentityCard.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelIdentityCard.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelIdentityCard.Location = new System.Drawing.Point(23, 55);
            this.labelIdentityCard.Name = "labelIdentityCard";
            this.labelIdentityCard.Size = new System.Drawing.Size(75, 23);
            this.labelIdentityCard.TabIndex = 36;
            this.labelIdentityCard.Text = "CMND:";
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
            this.dateBirthday.Location = new System.Drawing.Point(104, 84);
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
            this.dateBirthday.TabIndex = 25;
            this.dateBirthday.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // labelBirthday
            // 
            this.labelBirthday.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelBirthday.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelBirthday.Location = new System.Drawing.Point(23, 81);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(75, 23);
            this.labelBirthday.TabIndex = 37;
            this.labelBirthday.Text = "Ngày sinh:";
            // 
            // textBoxLastName
            // 
            // 
            // 
            // 
            this.textBoxLastName.Border.Class = "TextBoxBorder";
            this.textBoxLastName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxLastName.Location = new System.Drawing.Point(104, 32);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(348, 20);
            this.textBoxLastName.TabIndex = 23;
            this.superValidator1.SetValidator1(this.textBoxLastName, this.requiredFieldValidator2);
            // 
            // labelLastName
            // 
            this.labelLastName.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelLastName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelLastName.Location = new System.Drawing.Point(23, 29);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(75, 23);
            this.labelLastName.TabIndex = 35;
            this.labelLastName.Text = "Họ:";
            // 
            // textBoxFirstName
            // 
            // 
            // 
            // 
            this.textBoxFirstName.Border.Class = "TextBoxBorder";
            this.textBoxFirstName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxFirstName.Location = new System.Drawing.Point(104, 6);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(348, 20);
            this.textBoxFirstName.TabIndex = 22;
            this.superValidator1.SetValidator1(this.textBoxFirstName, this.requiredFieldValidator1);
            // 
            // labelFirstName
            // 
            this.labelFirstName.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelFirstName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelFirstName.Location = new System.Drawing.Point(23, 3);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(75, 23);
            this.labelFirstName.TabIndex = 34;
            this.labelFirstName.Text = "Tên:";
            // 
            // buttonClose
            // 
            this.buttonClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonClose.Location = new System.Drawing.Point(377, 344);
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
            this.buttonOk.Location = new System.Drawing.Point(296, 344);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonOk.TabIndex = 31;
            this.buttonOk.Text = "Đồng ý";
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // labelDepartment
            // 
            this.labelDepartment.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelDepartment.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelDepartment.Location = new System.Drawing.Point(23, 230);
            this.labelDepartment.Name = "labelDepartment";
            this.labelDepartment.Size = new System.Drawing.Size(75, 23);
            this.labelDepartment.TabIndex = 45;
            this.labelDepartment.Text = "Khoa:";
            // 
            // comboBoxDepartment
            // 
            this.comboBoxDepartment.DisplayMember = "Text";
            this.comboBoxDepartment.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxDepartment.FormattingEnabled = true;
            this.comboBoxDepartment.ItemHeight = 14;
            this.comboBoxDepartment.Location = new System.Drawing.Point(104, 233);
            this.comboBoxDepartment.Name = "comboBoxDepartment";
            this.comboBoxDepartment.Size = new System.Drawing.Size(240, 20);
            this.comboBoxDepartment.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBoxDepartment.TabIndex = 44;
            // 
            // labelMajor
            // 
            this.labelMajor.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelMajor.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelMajor.Location = new System.Drawing.Point(23, 256);
            this.labelMajor.Name = "labelMajor";
            this.labelMajor.Size = new System.Drawing.Size(75, 23);
            this.labelMajor.TabIndex = 47;
            this.labelMajor.Text = "Chuyên ngành:";
            // 
            // comboBoxMajor
            // 
            this.comboBoxMajor.DisplayMember = "Text";
            this.comboBoxMajor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxMajor.FormattingEnabled = true;
            this.comboBoxMajor.ItemHeight = 14;
            this.comboBoxMajor.Location = new System.Drawing.Point(104, 259);
            this.comboBoxMajor.Name = "comboBoxMajor";
            this.comboBoxMajor.Size = new System.Drawing.Size(240, 20);
            this.comboBoxMajor.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBoxMajor.TabIndex = 46;
            // 
            // textBoxPassword
            // 
            // 
            // 
            // 
            this.textBoxPassword.Border.Class = "TextBoxBorder";
            this.textBoxPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxPassword.Location = new System.Drawing.Point(104, 35);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(348, 20);
            this.textBoxPassword.TabIndex = 48;
            // 
            // labelPassword
            // 
            this.labelPassword.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelPassword.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelPassword.Location = new System.Drawing.Point(23, 32);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(75, 23);
            this.labelPassword.TabIndex = 49;
            this.labelPassword.Text = "Mật khẩu mới:";
            // 
            // textBoxPasswordCheck
            // 
            // 
            // 
            // 
            this.textBoxPasswordCheck.Border.Class = "TextBoxBorder";
            this.textBoxPasswordCheck.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxPasswordCheck.Location = new System.Drawing.Point(104, 61);
            this.textBoxPasswordCheck.Name = "textBoxPasswordCheck";
            this.textBoxPasswordCheck.PasswordChar = '*';
            this.textBoxPasswordCheck.Size = new System.Drawing.Size(348, 20);
            this.textBoxPasswordCheck.TabIndex = 50;
            this.superValidator1.SetValidator1(this.textBoxPasswordCheck, this.compareValidator1);
            // 
            // labelPasswordCheck
            // 
            this.labelPasswordCheck.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelPasswordCheck.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelPasswordCheck.Location = new System.Drawing.Point(23, 58);
            this.labelPasswordCheck.Name = "labelPasswordCheck";
            this.labelPasswordCheck.Size = new System.Drawing.Size(75, 23);
            this.labelPasswordCheck.TabIndex = 51;
            this.labelPasswordCheck.Text = "Nhập lại:";
            // 
            // groupPanelAccout
            // 
            this.groupPanelAccout.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanelAccout.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanelAccout.Controls.Add(this.labelStaffID);
            this.groupPanelAccout.Controls.Add(this.textBoxPasswordCheck);
            this.groupPanelAccout.Controls.Add(this.textBoxStaffID);
            this.groupPanelAccout.Controls.Add(this.labelPasswordCheck);
            this.groupPanelAccout.Controls.Add(this.labelPassword);
            this.groupPanelAccout.Controls.Add(this.textBoxPassword);
            this.groupPanelAccout.Location = new System.Drawing.Point(12, 12);
            this.groupPanelAccout.Name = "groupPanelAccout";
            this.groupPanelAccout.Size = new System.Drawing.Size(477, 125);
            // 
            // 
            // 
            this.groupPanelAccout.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanelAccout.Style.BackColorGradientAngle = 90;
            this.groupPanelAccout.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanelAccout.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelAccout.Style.BorderBottomWidth = 1;
            this.groupPanelAccout.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanelAccout.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelAccout.Style.BorderLeftWidth = 1;
            this.groupPanelAccout.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelAccout.Style.BorderRightWidth = 1;
            this.groupPanelAccout.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelAccout.Style.BorderTopWidth = 1;
            this.groupPanelAccout.Style.CornerDiameter = 4;
            this.groupPanelAccout.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanelAccout.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanelAccout.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanelAccout.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanelAccout.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanelAccout.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanelAccout.TabIndex = 52;
            this.groupPanelAccout.Text = "Tài khoản";
            // 
            // groupPanelInformation
            // 
            this.groupPanelInformation.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanelInformation.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanelInformation.Controls.Add(this.labelRole);
            this.groupPanelInformation.Controls.Add(this.comboBoxRole);
            this.groupPanelInformation.Controls.Add(this.labelFirstName);
            this.groupPanelInformation.Controls.Add(this.buttonOk);
            this.groupPanelInformation.Controls.Add(this.labelMajor);
            this.groupPanelInformation.Controls.Add(this.buttonClose);
            this.groupPanelInformation.Controls.Add(this.comboBoxMajor);
            this.groupPanelInformation.Controls.Add(this.textBoxFirstName);
            this.groupPanelInformation.Controls.Add(this.labelDepartment);
            this.groupPanelInformation.Controls.Add(this.labelLastName);
            this.groupPanelInformation.Controls.Add(this.comboBoxDepartment);
            this.groupPanelInformation.Controls.Add(this.textBoxLastName);
            this.groupPanelInformation.Controls.Add(this.comboBoxGender);
            this.groupPanelInformation.Controls.Add(this.labelBirthday);
            this.groupPanelInformation.Controls.Add(this.labelState);
            this.groupPanelInformation.Controls.Add(this.dateBirthday);
            this.groupPanelInformation.Controls.Add(this.comboBoxState);
            this.groupPanelInformation.Controls.Add(this.labelIdentityCard);
            this.groupPanelInformation.Controls.Add(this.textBoxIdentityCard);
            this.groupPanelInformation.Controls.Add(this.labelGender);
            this.groupPanelInformation.Controls.Add(this.textBoxAddress);
            this.groupPanelInformation.Controls.Add(this.labelAddress);
            this.groupPanelInformation.Location = new System.Drawing.Point(12, 143);
            this.groupPanelInformation.Name = "groupPanelInformation";
            this.groupPanelInformation.Size = new System.Drawing.Size(477, 391);
            // 
            // 
            // 
            this.groupPanelInformation.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanelInformation.Style.BackColorGradientAngle = 90;
            this.groupPanelInformation.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanelInformation.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelInformation.Style.BorderBottomWidth = 1;
            this.groupPanelInformation.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanelInformation.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelInformation.Style.BorderLeftWidth = 1;
            this.groupPanelInformation.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelInformation.Style.BorderRightWidth = 1;
            this.groupPanelInformation.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelInformation.Style.BorderTopWidth = 1;
            this.groupPanelInformation.Style.CornerDiameter = 4;
            this.groupPanelInformation.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanelInformation.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanelInformation.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanelInformation.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanelInformation.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanelInformation.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanelInformation.TabIndex = 53;
            this.groupPanelInformation.Text = "Thông tin nhân viên";
            // 
            // labelRole
            // 
            this.labelRole.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelRole.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelRole.Location = new System.Drawing.Point(23, 282);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(75, 23);
            this.labelRole.TabIndex = 49;
            this.labelRole.Text = "Quyền:";
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.DisplayMember = "Text";
            this.comboBoxRole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxRole.FormattingEnabled = true;
            this.comboBoxRole.ItemHeight = 14;
            this.comboBoxRole.Location = new System.Drawing.Point(104, 285);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(240, 20);
            this.comboBoxRole.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBoxRole.TabIndex = 48;
            // 
            // superValidator1
            // 
            this.superValidator1.ContainerControl = this;
            this.superValidator1.ErrorProvider = this.errorProvider1;
            this.superValidator1.Highlighter = this.highlighter1;
            // 
            // regularExpressionValidator1
            // 
            this.regularExpressionValidator1.EmptyValueIsValid = true;
            this.regularExpressionValidator1.ErrorMessage = "Nhập đủ 9 số CMND";
            this.regularExpressionValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.regularExpressionValidator1.ValidationExpression = "[1-9]\\d{8}";
            // 
            // requiredFieldValidator2
            // 
            this.requiredFieldValidator2.ErrorMessage = "Phải điền họ";
            this.requiredFieldValidator2.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // requiredFieldValidator1
            // 
            this.requiredFieldValidator1.ErrorMessage = "Phải điền tên";
            this.requiredFieldValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // compareValidator1
            // 
            this.compareValidator1.ControlToCompare = this.textBoxPassword;
            this.compareValidator1.ErrorMessage = "Mật khẩu phải trùng";
            this.compareValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // highlighter1
            // 
            this.highlighter1.ContainerControl = this;
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "Đang làm việc";
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "Đã thôi việc";
            // 
            // FormStaffDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(500, 546);
            this.ControlBox = false;
            this.Controls.Add(this.groupPanelInformation);
            this.Controls.Add(this.groupPanelAccout);
            this.Name = "FormStaffDetail";
            this.Text = "Thông tin nhân viên";
            ((System.ComponentModel.ISupportInitialize)(this.dateBirthday)).EndInit();
            this.groupPanelAccout.ResumeLayout(false);
            this.groupPanelInformation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxGender;
        private DevComponents.Editors.ComboItem comboItemMale;
        private DevComponents.Editors.ComboItem comboItemFemale;
        private DevComponents.DotNetBar.LabelX labelState;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxState;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxStaffID;
        private DevComponents.DotNetBar.LabelX labelStaffID;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxIdentityCard;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxAddress;
        private DevComponents.DotNetBar.LabelX labelAddress;
        private DevComponents.DotNetBar.LabelX labelGender;
        private DevComponents.DotNetBar.LabelX labelIdentityCard;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateBirthday;
        private DevComponents.DotNetBar.LabelX labelBirthday;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxLastName;
        private DevComponents.DotNetBar.LabelX labelLastName;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxFirstName;
        private DevComponents.DotNetBar.LabelX labelFirstName;
        private DevComponents.DotNetBar.ButtonX buttonClose;
        private DevComponents.DotNetBar.ButtonX buttonOk;
        private DevComponents.DotNetBar.LabelX labelDepartment;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxDepartment;
        private DevComponents.DotNetBar.LabelX labelMajor;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxMajor;
        private DevComponents.DotNetBar.LabelX labelPassword;
        private DevComponents.DotNetBar.LabelX labelPasswordCheck;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxPassword;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxPasswordCheck;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanelAccout;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanelInformation;
        private DevComponents.DotNetBar.LabelX labelRole;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxRole;
        private DevComponents.DotNetBar.Validator.SuperValidator superValidator1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter1;
        private DevComponents.DotNetBar.Validator.CompareValidator compareValidator1;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator1;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator2;
        private DevComponents.DotNetBar.Validator.RegularExpressionValidator regularExpressionValidator1;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem2;

    }
}