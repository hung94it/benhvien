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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHCDetail));
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.buttonOk = new DevComponents.DotNetBar.ButtonX();
            this.buttonClose = new DevComponents.DotNetBar.ButtonX();
            this.labelState = new DevComponents.DotNetBar.LabelX();
            this.comboBoxState = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItemNo = new DevComponents.Editors.ComboItem();
            this.comboItemYes = new DevComponents.Editors.ComboItem();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.dateHospitalizate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.textBoxReason = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelAddress = new DevComponents.DotNetBar.LabelX();
            this.textBoxStaffID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.textBoxHCID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelHCID = new DevComponents.DotNetBar.LabelX();
            this.textBoxPatientID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelRoleName = new DevComponents.DotNetBar.LabelX();
            this.superValidator1 = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.requiredFieldValidator1 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Nhập lý do");
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.highlighter1 = new DevComponents.DotNetBar.Validator.Highlighter();
            this.requiredFieldValidator2 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Nhập lý do");
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateHospitalizate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
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
            this.groupPanel1.Controls.Add(this.dateHospitalizate);
            this.groupPanel1.Controls.Add(this.textBoxReason);
            this.groupPanel1.Controls.Add(this.labelAddress);
            this.groupPanel1.Controls.Add(this.textBoxStaffID);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.Controls.Add(this.textBoxHCID);
            this.groupPanel1.Controls.Add(this.labelHCID);
            this.groupPanel1.Controls.Add(this.textBoxPatientID);
            this.groupPanel1.Controls.Add(this.labelRoleName);
            this.groupPanel1.Location = new System.Drawing.Point(12, 4);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(453, 281);
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
            this.groupPanel1.Text = "Giấy nhập viện";
            // 
            // buttonOk
            // 
            this.buttonOk.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonOk.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonOk.Location = new System.Drawing.Point(251, 232);
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
            this.buttonClose.Location = new System.Drawing.Point(343, 232);
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
            this.labelState.Location = new System.Drawing.Point(3, 204);
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
            this.comboBoxState.Location = new System.Drawing.Point(125, 207);
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
            this.labelX2.Location = new System.Drawing.Point(3, 178);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(121, 23);
            this.labelX2.TabIndex = 66;
            this.labelX2.Text = "Ngày nhập viện";
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
            this.dateHospitalizate.Location = new System.Drawing.Point(125, 181);
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
            this.dateHospitalizate.TabIndex = 58;
            this.dateHospitalizate.Value = new System.DateTime(2012, 5, 20, 0, 0, 0, 0);
            // 
            // textBoxReason
            // 
            // 
            // 
            // 
            this.textBoxReason.Border.Class = "TextBoxBorder";
            this.textBoxReason.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxReason.Location = new System.Drawing.Point(125, 84);
            this.textBoxReason.Multiline = true;
            this.textBoxReason.Name = "textBoxReason";
            this.textBoxReason.Size = new System.Drawing.Size(293, 91);
            this.textBoxReason.TabIndex = 57;
            this.superValidator1.SetValidator1(this.textBoxReason, this.requiredFieldValidator2);
            // 
            // labelAddress
            // 
            this.labelAddress.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelAddress.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelAddress.Location = new System.Drawing.Point(3, 81);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(50, 23);
            this.labelAddress.TabIndex = 65;
            this.labelAddress.Text = "Lý do";
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
            this.superValidator1.SetValidator1(this.labelX1, this.requiredFieldValidator1);
            // 
            // textBoxHCID
            // 
            // 
            // 
            // 
            this.textBoxHCID.Border.Class = "TextBoxBorder";
            this.textBoxHCID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxHCID.Location = new System.Drawing.Point(125, 6);
            this.textBoxHCID.Name = "textBoxHCID";
            this.textBoxHCID.ReadOnly = true;
            this.textBoxHCID.Size = new System.Drawing.Size(293, 20);
            this.textBoxHCID.TabIndex = 54;
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
            // superValidator1
            // 
            this.superValidator1.ContainerControl = this;
            this.superValidator1.ErrorProvider = this.errorProvider1;
            this.superValidator1.Highlighter = this.highlighter1;
            // 
            // requiredFieldValidator1
            // 
            this.requiredFieldValidator1.ErrorMessage = "Nhập lý do";
            this.requiredFieldValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
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
            // requiredFieldValidator2
            // 
            this.requiredFieldValidator2.ErrorMessage = "Nhập lý do";
            this.requiredFieldValidator2.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // FormHCDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 295);
            this.Controls.Add(this.groupPanel1);
            this.Name = "FormHCDetail";
            this.Text = "Thông tin giấy nhập viện";
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dateHospitalizate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
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
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateHospitalizate;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxReason;
        private DevComponents.DotNetBar.LabelX labelAddress;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxStaffID;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxHCID;
        private DevComponents.DotNetBar.LabelX labelHCID;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxPatientID;
        private DevComponents.DotNetBar.LabelX labelRoleName;
        private DevComponents.DotNetBar.Validator.SuperValidator superValidator1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter1;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator1;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator2;

    }
}