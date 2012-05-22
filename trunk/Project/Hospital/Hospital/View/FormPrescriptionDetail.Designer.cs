namespace Hospital.View
{
    partial class FormPrescriptionDetail
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
            this.textBoxPrescriptionID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelRoleID = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.textBoxStaffID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.textBoxPatientID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelBirthday = new DevComponents.DotNetBar.LabelX();
            this.dateCreate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.buttonInsert = new DevComponents.DotNetBar.ButtonX();
            this.textBoxInputInstruction = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelState = new DevComponents.DotNetBar.LabelX();
            this.comboBoxMedicine = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelAddress = new DevComponents.DotNetBar.LabelX();
            this.labelFirstName = new DevComponents.DotNetBar.LabelX();
            this.textBoxInputQuantity = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.buttonRemove = new DevComponents.DotNetBar.ButtonX();
            this.listSelectedMedicine = new System.Windows.Forms.ListBox();
            this.buttonOk = new DevComponents.DotNetBar.ButtonX();
            this.buttonClose = new DevComponents.DotNetBar.ButtonX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.groupPanel3 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.textBoxAddInstruction = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.textBoxAddQuantity = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.dateCreate)).BeginInit();
            this.groupPanel1.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            this.groupPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxPrescriptionID
            // 
            // 
            // 
            // 
            this.textBoxPrescriptionID.Border.Class = "TextBoxBorder";
            this.textBoxPrescriptionID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxPrescriptionID.Location = new System.Drawing.Point(96, 6);
            this.textBoxPrescriptionID.Name = "textBoxPrescriptionID";
            this.textBoxPrescriptionID.ReadOnly = true;
            this.textBoxPrescriptionID.Size = new System.Drawing.Size(280, 20);
            this.textBoxPrescriptionID.TabIndex = 0;
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
            this.labelRoleID.Size = new System.Drawing.Size(67, 23);
            this.labelRoleID.TabIndex = 27;
            this.labelRoleID.Text = "Mã toa thuốc";
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
            this.labelX1.Size = new System.Drawing.Size(69, 23);
            this.labelX1.TabIndex = 27;
            this.labelX1.Text = "Mã nhân viên";
            // 
            // textBoxStaffID
            // 
            // 
            // 
            // 
            this.textBoxStaffID.Border.Class = "TextBoxBorder";
            this.textBoxStaffID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxStaffID.Location = new System.Drawing.Point(96, 32);
            this.textBoxStaffID.Name = "textBoxStaffID";
            this.textBoxStaffID.ReadOnly = true;
            this.textBoxStaffID.Size = new System.Drawing.Size(279, 20);
            this.textBoxStaffID.TabIndex = 1;
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(3, 55);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(77, 23);
            this.labelX2.TabIndex = 27;
            this.labelX2.Text = "Mã bệnh nhân";
            // 
            // textBoxPatientID
            // 
            // 
            // 
            // 
            this.textBoxPatientID.Border.Class = "TextBoxBorder";
            this.textBoxPatientID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxPatientID.Location = new System.Drawing.Point(96, 58);
            this.textBoxPatientID.Name = "textBoxPatientID";
            this.textBoxPatientID.ReadOnly = true;
            this.textBoxPatientID.Size = new System.Drawing.Size(280, 20);
            this.textBoxPatientID.TabIndex = 2;
            // 
            // labelBirthday
            // 
            this.labelBirthday.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelBirthday.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelBirthday.Location = new System.Drawing.Point(3, 86);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(75, 23);
            this.labelBirthday.TabIndex = 39;
            this.labelBirthday.Text = "Ngày lập";
            // 
            // dateCreate
            // 
            // 
            // 
            // 
            this.dateCreate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dateCreate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateCreate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dateCreate.ButtonDropDown.Visible = true;
            this.dateCreate.IsPopupCalendarOpen = false;
            this.dateCreate.Location = new System.Drawing.Point(96, 87);
            // 
            // 
            // 
            this.dateCreate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateCreate.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateCreate.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dateCreate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dateCreate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dateCreate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dateCreate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dateCreate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dateCreate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dateCreate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dateCreate.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateCreate.MonthCalendar.DisplayMonth = new System.DateTime(2012, 5, 1, 0, 0, 0, 0);
            this.dateCreate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dateCreate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateCreate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dateCreate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dateCreate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dateCreate.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateCreate.MonthCalendar.TodayButtonVisible = true;
            this.dateCreate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dateCreate.Name = "dateCreate";
            this.dateCreate.Size = new System.Drawing.Size(109, 20);
            this.dateCreate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dateCreate.TabIndex = 3;
            this.dateCreate.Value = new System.DateTime(2012, 5, 20, 0, 0, 0, 0);
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.labelRoleID);
            this.groupPanel1.Controls.Add(this.labelBirthday);
            this.groupPanel1.Controls.Add(this.textBoxPrescriptionID);
            this.groupPanel1.Controls.Add(this.dateCreate);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.Controls.Add(this.textBoxPatientID);
            this.groupPanel1.Controls.Add(this.textBoxStaffID);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Location = new System.Drawing.Point(12, 12);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(386, 133);
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
            this.groupPanel1.TabIndex = 49;
            this.groupPanel1.Text = "Toa thuốc";
            // 
            // groupPanel2
            // 
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.buttonInsert);
            this.groupPanel2.Controls.Add(this.textBoxInputInstruction);
            this.groupPanel2.Controls.Add(this.labelState);
            this.groupPanel2.Controls.Add(this.comboBoxMedicine);
            this.groupPanel2.Controls.Add(this.labelAddress);
            this.groupPanel2.Controls.Add(this.labelFirstName);
            this.groupPanel2.Controls.Add(this.textBoxInputQuantity);
            this.groupPanel2.Location = new System.Drawing.Point(12, 147);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(386, 150);
            // 
            // 
            // 
            this.groupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel2.Style.BackColorGradientAngle = 90;
            this.groupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderBottomWidth = 1;
            this.groupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderLeftWidth = 1;
            this.groupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderRightWidth = 1;
            this.groupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderTopWidth = 1;
            this.groupPanel2.Style.CornerDiameter = 4;
            this.groupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel2.TabIndex = 50;
            this.groupPanel2.Text = "Danh sách thuốc";
            // 
            // buttonInsert
            // 
            this.buttonInsert.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonInsert.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonInsert.Location = new System.Drawing.Point(95, 105);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(75, 23);
            this.buttonInsert.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonInsert.TabIndex = 3;
            this.buttonInsert.Text = "Thêm thuốc";
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // textBoxInputInstruction
            // 
            // 
            // 
            // 
            this.textBoxInputInstruction.Border.Class = "TextBoxBorder";
            this.textBoxInputInstruction.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxInputInstruction.Location = new System.Drawing.Point(95, 49);
            this.textBoxInputInstruction.Multiline = true;
            this.textBoxInputInstruction.Name = "textBoxInputInstruction";
            this.textBoxInputInstruction.Size = new System.Drawing.Size(279, 50);
            this.textBoxInputInstruction.TabIndex = 2;
            // 
            // labelState
            // 
            this.labelState.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelState.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelState.Location = new System.Drawing.Point(3, 3);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(66, 23);
            this.labelState.TabIndex = 50;
            this.labelState.Text = "Tên thuốc";
            // 
            // comboBoxMedicine
            // 
            this.comboBoxMedicine.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxMedicine.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.comboBoxMedicine.DisplayMember = "Text";
            this.comboBoxMedicine.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxMedicine.FormattingEnabled = true;
            this.comboBoxMedicine.ItemHeight = 14;
            this.comboBoxMedicine.Location = new System.Drawing.Point(96, 3);
            this.comboBoxMedicine.Name = "comboBoxMedicine";
            this.comboBoxMedicine.Size = new System.Drawing.Size(279, 20);
            this.comboBoxMedicine.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBoxMedicine.TabIndex = 0;
            this.comboBoxMedicine.SelectedIndexChanged += new System.EventHandler(this.comboBoxMedicine_SelectedIndexChanged);
            // 
            // labelAddress
            // 
            this.labelAddress.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelAddress.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelAddress.Location = new System.Drawing.Point(3, 46);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(64, 23);
            this.labelAddress.TabIndex = 54;
            this.labelAddress.Text = "Hướng dẫn";
            // 
            // labelFirstName
            // 
            this.labelFirstName.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelFirstName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelFirstName.Location = new System.Drawing.Point(3, 23);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(85, 23);
            this.labelFirstName.TabIndex = 52;
            this.labelFirstName.Text = "Số lượng cần kê";
            // 
            // textBoxInputQuantity
            // 
            // 
            // 
            // 
            this.textBoxInputQuantity.Border.Class = "TextBoxBorder";
            this.textBoxInputQuantity.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxInputQuantity.Location = new System.Drawing.Point(95, 26);
            this.textBoxInputQuantity.Name = "textBoxInputQuantity";
            this.textBoxInputQuantity.Size = new System.Drawing.Size(62, 20);
            this.textBoxInputQuantity.TabIndex = 1;
            // 
            // buttonRemove
            // 
            this.buttonRemove.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonRemove.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonRemove.Location = new System.Drawing.Point(131, 140);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(75, 23);
            this.buttonRemove.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonRemove.TabIndex = 3;
            this.buttonRemove.Text = "Bỏ thuốc";
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // listSelectedMedicine
            // 
            this.listSelectedMedicine.FormattingEnabled = true;
            this.listSelectedMedicine.Location = new System.Drawing.Point(96, 3);
            this.listSelectedMedicine.Name = "listSelectedMedicine";
            this.listSelectedMedicine.Size = new System.Drawing.Size(280, 56);
            this.listSelectedMedicine.TabIndex = 0;
            this.listSelectedMedicine.SelectedIndexChanged += new System.EventHandler(this.listSelectedMedicine_SelectedIndexChanged);
            // 
            // buttonOk
            // 
            this.buttonOk.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonOk.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonOk.Location = new System.Drawing.Point(211, 140);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonOk.TabIndex = 4;
            this.buttonOk.Text = "Đồng ý";
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonClose.Location = new System.Drawing.Point(292, 140);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonClose.TabIndex = 5;
            this.buttonClose.Text = "Đóng";
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(4, 3);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(85, 23);
            this.labelX3.TabIndex = 54;
            this.labelX3.Text = "Danh sách thuốc";
            // 
            // groupPanel3
            // 
            this.groupPanel3.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel3.Controls.Add(this.buttonOk);
            this.groupPanel3.Controls.Add(this.buttonRemove);
            this.groupPanel3.Controls.Add(this.listSelectedMedicine);
            this.groupPanel3.Controls.Add(this.textBoxAddInstruction);
            this.groupPanel3.Controls.Add(this.buttonClose);
            this.groupPanel3.Controls.Add(this.labelX3);
            this.groupPanel3.Controls.Add(this.labelX5);
            this.groupPanel3.Controls.Add(this.textBoxAddQuantity);
            this.groupPanel3.Controls.Add(this.labelX4);
            this.groupPanel3.Location = new System.Drawing.Point(12, 299);
            this.groupPanel3.Name = "groupPanel3";
            this.groupPanel3.Size = new System.Drawing.Size(386, 186);
            // 
            // 
            // 
            this.groupPanel3.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel3.Style.BackColorGradientAngle = 90;
            this.groupPanel3.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel3.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderBottomWidth = 1;
            this.groupPanel3.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel3.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderLeftWidth = 1;
            this.groupPanel3.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderRightWidth = 1;
            this.groupPanel3.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderTopWidth = 1;
            this.groupPanel3.Style.CornerDiameter = 4;
            this.groupPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel3.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel3.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel3.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel3.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel3.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel3.TabIndex = 51;
            this.groupPanel3.Text = "Chi tiết toa thuốc";
            // 
            // textBoxAddInstruction
            // 
            // 
            // 
            // 
            this.textBoxAddInstruction.Border.Class = "TextBoxBorder";
            this.textBoxAddInstruction.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxAddInstruction.Location = new System.Drawing.Point(96, 84);
            this.textBoxAddInstruction.Multiline = true;
            this.textBoxAddInstruction.Name = "textBoxAddInstruction";
            this.textBoxAddInstruction.ReadOnly = true;
            this.textBoxAddInstruction.Size = new System.Drawing.Size(279, 50);
            this.textBoxAddInstruction.TabIndex = 2;
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(4, 84);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(64, 23);
            this.labelX5.TabIndex = 54;
            this.labelX5.Text = "Hướng dẫn";
            // 
            // textBoxAddQuantity
            // 
            // 
            // 
            // 
            this.textBoxAddQuantity.Border.Class = "TextBoxBorder";
            this.textBoxAddQuantity.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxAddQuantity.Location = new System.Drawing.Point(96, 62);
            this.textBoxAddQuantity.Name = "textBoxAddQuantity";
            this.textBoxAddQuantity.ReadOnly = true;
            this.textBoxAddQuantity.Size = new System.Drawing.Size(62, 20);
            this.textBoxAddQuantity.TabIndex = 1;
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(3, 59);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(85, 23);
            this.labelX4.TabIndex = 52;
            this.labelX4.Text = "Số lượng cần kê";
            // 
            // FormPrescriptionDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 489);
            this.Controls.Add(this.groupPanel3);
            this.Controls.Add(this.groupPanel2);
            this.Controls.Add(this.groupPanel1);
            this.Name = "FormPrescriptionDetail";
            this.Text = "Thông tin toa thuốc";
            ((System.ComponentModel.ISupportInitialize)(this.dateCreate)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel2.ResumeLayout(false);
            this.groupPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX textBoxPrescriptionID;
        private DevComponents.DotNetBar.LabelX labelRoleID;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxStaffID;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxPatientID;
        private DevComponents.DotNetBar.LabelX labelBirthday;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateCreate;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxInputInstruction;
        private DevComponents.DotNetBar.LabelX labelAddress;
        private DevComponents.DotNetBar.LabelX labelFirstName;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxInputQuantity;
        private DevComponents.DotNetBar.LabelX labelState;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxMedicine;
        private DevComponents.DotNetBar.ButtonX buttonInsert;
        private DevComponents.DotNetBar.ButtonX buttonRemove;
        private System.Windows.Forms.ListBox listSelectedMedicine;
        private DevComponents.DotNetBar.ButtonX buttonOk;
        private DevComponents.DotNetBar.ButtonX buttonClose;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel3;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxAddQuantity;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxAddInstruction;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX4;
    }
}