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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPatientDetail));
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
            this.comboItemMale = new DevComponents.Editors.ComboItem();
            this.comboItemFemale = new DevComponents.Editors.ComboItem();
            this.textBoxDeposit = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.textBoxProfession = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelProfession = new DevComponents.DotNetBar.LabelX();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.superValidator1 = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.requiredFieldValidator1 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Tên chỉ gồm các kí tự");
            this.requiredFieldValidator2 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Họ chỉ gồm các kí tự");
            this.regularExpressionValidator1 = new DevComponents.DotNetBar.Validator.RegularExpressionValidator();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.highlighter1 = new DevComponents.DotNetBar.Validator.Highlighter();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.regularExpressionValidator2 = new DevComponents.DotNetBar.Validator.RegularExpressionValidator();
            ((System.ComponentModel.ISupportInitialize)(this.dateBirthday)).BeginInit();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOk
            // 
            this.buttonOk.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonOk.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonOk.Location = new System.Drawing.Point(277, 348);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonOk.TabIndex = 9;
            this.buttonOk.Text = "Đồng ý";
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonClose.Location = new System.Drawing.Point(369, 348);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonClose.TabIndex = 10;
            this.buttonClose.Text = "Đóng";
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelFirstName
            // 
            this.labelFirstName.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelFirstName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelFirstName.Location = new System.Drawing.Point(15, 37);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(75, 23);
            this.labelFirstName.TabIndex = 12;
            this.labelFirstName.Text = "Tên:";
            // 
            // textBoxFirstName
            // 
            // 
            // 
            // 
            this.textBoxFirstName.Border.Class = "TextBoxBorder";
            this.textBoxFirstName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxFirstName.Location = new System.Drawing.Point(96, 40);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(348, 20);
            this.textBoxFirstName.TabIndex = 0;
            this.superValidator1.SetValidator1(this.textBoxFirstName, this.requiredFieldValidator1);
            // 
            // textBoxLastName
            // 
            // 
            // 
            // 
            this.textBoxLastName.Border.Class = "TextBoxBorder";
            this.textBoxLastName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxLastName.Location = new System.Drawing.Point(96, 66);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(348, 20);
            this.textBoxLastName.TabIndex = 1;
            this.superValidator1.SetValidator1(this.textBoxLastName, this.requiredFieldValidator2);
            // 
            // labelLastName
            // 
            this.labelLastName.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelLastName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelLastName.Location = new System.Drawing.Point(15, 63);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(75, 23);
            this.labelLastName.TabIndex = 13;
            this.labelLastName.Text = "Họ:";
            // 
            // labelBirthday
            // 
            this.labelBirthday.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelBirthday.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelBirthday.Location = new System.Drawing.Point(15, 115);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(75, 23);
            this.labelBirthday.TabIndex = 15;
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
            this.dateBirthday.Location = new System.Drawing.Point(96, 118);
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
            this.dateBirthday.TabIndex = 3;
            this.dateBirthday.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // labelIdentityCard
            // 
            this.labelIdentityCard.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelIdentityCard.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelIdentityCard.Location = new System.Drawing.Point(15, 89);
            this.labelIdentityCard.Name = "labelIdentityCard";
            this.labelIdentityCard.Size = new System.Drawing.Size(75, 23);
            this.labelIdentityCard.TabIndex = 14;
            this.labelIdentityCard.Text = "CMND:";
            // 
            // labelGender
            // 
            this.labelGender.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelGender.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelGender.Location = new System.Drawing.Point(15, 141);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(75, 23);
            this.labelGender.TabIndex = 16;
            this.labelGender.Text = "Giới tính:";
            // 
            // labelAddress
            // 
            this.labelAddress.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelAddress.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelAddress.Location = new System.Drawing.Point(15, 193);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(75, 23);
            this.labelAddress.TabIndex = 18;
            this.labelAddress.Text = "Địa chỉ:";
            // 
            // textBoxAddress
            // 
            // 
            // 
            // 
            this.textBoxAddress.Border.Class = "TextBoxBorder";
            this.textBoxAddress.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxAddress.Location = new System.Drawing.Point(96, 196);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(348, 91);
            this.textBoxAddress.TabIndex = 6;
            // 
            // textBoxIdentityCard
            // 
            // 
            // 
            // 
            this.textBoxIdentityCard.Border.Class = "TextBoxBorder";
            this.textBoxIdentityCard.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxIdentityCard.Location = new System.Drawing.Point(96, 92);
            this.textBoxIdentityCard.Name = "textBoxIdentityCard";
            this.textBoxIdentityCard.Size = new System.Drawing.Size(348, 20);
            this.textBoxIdentityCard.TabIndex = 2;
            this.superValidator1.SetValidator1(this.textBoxIdentityCard, this.regularExpressionValidator1);
            // 
            // textBoxPatientID
            // 
            this.textBoxPatientID.BackColor = System.Drawing.Color.WhiteSmoke;
            // 
            // 
            // 
            this.textBoxPatientID.Border.Class = "TextBoxBorder";
            this.textBoxPatientID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxPatientID.Location = new System.Drawing.Point(96, 14);
            this.textBoxPatientID.Name = "textBoxPatientID";
            this.textBoxPatientID.ReadOnly = true;
            this.textBoxPatientID.Size = new System.Drawing.Size(348, 20);
            this.textBoxPatientID.TabIndex = 21;
            // 
            // labelPatientID
            // 
            this.labelPatientID.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelPatientID.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelPatientID.Location = new System.Drawing.Point(15, 11);
            this.labelPatientID.Name = "labelPatientID";
            this.labelPatientID.Size = new System.Drawing.Size(75, 23);
            this.labelPatientID.TabIndex = 11;
            this.labelPatientID.Text = "Mã bệnh nhân:";
            // 
            // comboBoxState
            // 
            this.comboBoxState.DisplayMember = "Text";
            this.comboBoxState.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxState.FormattingEnabled = true;
            this.comboBoxState.ItemHeight = 14;
            this.comboBoxState.Items.AddRange(new object[] {
            this.comboItem1,
            this.comboItem2});
            this.comboBoxState.Location = new System.Drawing.Point(96, 319);
            this.comboBoxState.Name = "comboBoxState";
            this.comboBoxState.Size = new System.Drawing.Size(240, 20);
            this.comboBoxState.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBoxState.TabIndex = 8;
            // 
            // labelState
            // 
            this.labelState.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelState.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelState.Location = new System.Drawing.Point(15, 316);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(75, 23);
            this.labelState.TabIndex = 20;
            this.labelState.Text = "Trạng thái:";
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
            this.comboBoxGender.Location = new System.Drawing.Point(96, 144);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(240, 20);
            this.comboBoxGender.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBoxGender.TabIndex = 4;
            // 
            // comboItemMale
            // 
            this.comboItemMale.Text = "Nam";
            // 
            // comboItemFemale
            // 
            this.comboItemFemale.Text = "Nữ";
            // 
            // textBoxDeposit
            // 
            // 
            // 
            // 
            this.textBoxDeposit.Border.Class = "TextBoxBorder";
            this.textBoxDeposit.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxDeposit.Location = new System.Drawing.Point(96, 293);
            this.textBoxDeposit.Name = "textBoxDeposit";
            this.textBoxDeposit.Size = new System.Drawing.Size(348, 20);
            this.textBoxDeposit.TabIndex = 7;
            this.superValidator1.SetValidator1(this.textBoxDeposit, this.regularExpressionValidator2);
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(15, 290);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 19;
            this.labelX1.Text = "Tiền đặc cọc:";
            // 
            // textBoxProfession
            // 
            // 
            // 
            // 
            this.textBoxProfession.Border.Class = "TextBoxBorder";
            this.textBoxProfession.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxProfession.Location = new System.Drawing.Point(96, 170);
            this.textBoxProfession.Name = "textBoxProfession";
            this.textBoxProfession.Size = new System.Drawing.Size(348, 20);
            this.textBoxProfession.TabIndex = 5;
            // 
            // labelProfession
            // 
            this.labelProfession.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelProfession.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelProfession.Location = new System.Drawing.Point(15, 167);
            this.labelProfession.Name = "labelProfession";
            this.labelProfession.Size = new System.Drawing.Size(75, 23);
            this.labelProfession.TabIndex = 17;
            this.labelProfession.Text = "Nghề nghiệp:";
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.textBoxPatientID);
            this.groupPanel1.Controls.Add(this.textBoxProfession);
            this.groupPanel1.Controls.Add(this.buttonOk);
            this.groupPanel1.Controls.Add(this.labelProfession);
            this.groupPanel1.Controls.Add(this.buttonClose);
            this.groupPanel1.Controls.Add(this.textBoxDeposit);
            this.groupPanel1.Controls.Add(this.labelFirstName);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.Controls.Add(this.textBoxFirstName);
            this.groupPanel1.Controls.Add(this.comboBoxGender);
            this.groupPanel1.Controls.Add(this.labelLastName);
            this.groupPanel1.Controls.Add(this.labelState);
            this.groupPanel1.Controls.Add(this.textBoxLastName);
            this.groupPanel1.Controls.Add(this.comboBoxState);
            this.groupPanel1.Controls.Add(this.labelBirthday);
            this.groupPanel1.Controls.Add(this.dateBirthday);
            this.groupPanel1.Controls.Add(this.labelPatientID);
            this.groupPanel1.Controls.Add(this.labelIdentityCard);
            this.groupPanel1.Controls.Add(this.textBoxIdentityCard);
            this.groupPanel1.Controls.Add(this.labelGender);
            this.groupPanel1.Controls.Add(this.textBoxAddress);
            this.groupPanel1.Controls.Add(this.labelAddress);
            this.groupPanel1.Location = new System.Drawing.Point(12, 12);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(467, 404);
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
            this.groupPanel1.TabIndex = 22;
            this.groupPanel1.Text = "Thông tin bệnh nhân";
            // 
            // superValidator1
            // 
            this.superValidator1.ContainerControl = this;
            this.superValidator1.ErrorProvider = this.errorProvider1;
            this.superValidator1.Highlighter = this.highlighter1;
            // 
            // requiredFieldValidator1
            // 
            this.requiredFieldValidator1.ErrorMessage = "Tên chỉ gồm các kí tự";
            this.requiredFieldValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // requiredFieldValidator2
            // 
            this.requiredFieldValidator2.ErrorMessage = "Họ chỉ gồm các kí tự";
            this.requiredFieldValidator2.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // regularExpressionValidator1
            // 
            this.regularExpressionValidator1.EmptyValueIsValid = true;
            this.regularExpressionValidator1.ErrorMessage = "Nhập 9 số CMND";
            this.regularExpressionValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.regularExpressionValidator1.ValidationExpression = "[1-9]\\d{8}";
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
            this.comboItem1.Text = "Ngoại trú";
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "Nội trú";
            // 
            // regularExpressionValidator2
            // 
            this.regularExpressionValidator2.EmptyValueIsValid = true;
            this.regularExpressionValidator2.ErrorMessage = "Nhập số tiền";
            this.regularExpressionValidator2.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.regularExpressionValidator2.ValidationExpression = "[1-9]\\d+";
            // 
            // FormPatientDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 425);
            this.ControlBox = false;
            this.Controls.Add(this.groupPanel1);
            this.Name = "FormPatientDetail";
            this.Text = "Thông tin bệnh nhân";
            ((System.ComponentModel.ISupportInitialize)(this.dateBirthday)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
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
        private DevComponents.Editors.ComboItem comboItemMale;
        private DevComponents.Editors.ComboItem comboItemFemale;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Validator.SuperValidator superValidator1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter1;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator1;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator2;
        private DevComponents.DotNetBar.Validator.RegularExpressionValidator regularExpressionValidator1;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem2;
        private DevComponents.DotNetBar.Validator.RegularExpressionValidator regularExpressionValidator2;
    }
}