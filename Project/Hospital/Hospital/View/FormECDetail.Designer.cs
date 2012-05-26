namespace Hospital.View
{
    partial class FormECDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormECDetail));
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.buttonOk = new DevComponents.DotNetBar.ButtonX();
            this.buttonClose = new DevComponents.DotNetBar.ButtonX();
            this.labelState = new DevComponents.DotNetBar.LabelX();
            this.comboBoxState = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItemNo = new DevComponents.Editors.ComboItem();
            this.comboItemYes = new DevComponents.Editors.ComboItem();
            this.textBoxResult = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelAddress = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.dateCreate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.textBoxPatientID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBoxStaffID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBoxECID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelHCID = new DevComponents.DotNetBar.LabelX();
            this.superValidator1 = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.highlighter1 = new DevComponents.DotNetBar.Validator.Highlighter();
            this.requiredFieldValidator1 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Nhập kết quả khám bệnh");
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateCreate)).BeginInit();
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
            this.groupPanel1.Controls.Add(this.textBoxResult);
            this.groupPanel1.Controls.Add(this.labelAddress);
            this.groupPanel1.Controls.Add(this.labelX3);
            this.groupPanel1.Controls.Add(this.dateCreate);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.Controls.Add(this.textBoxPatientID);
            this.groupPanel1.Controls.Add(this.textBoxStaffID);
            this.groupPanel1.Controls.Add(this.textBoxECID);
            this.groupPanel1.Controls.Add(this.labelHCID);
            this.groupPanel1.Location = new System.Drawing.Point(12, 3);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(436, 227);
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
            this.groupPanel1.Text = "Phiếu khám bệnh";
            // 
            // buttonOk
            // 
            this.buttonOk.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonOk.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonOk.Location = new System.Drawing.Point(237, 181);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonOk.TabIndex = 74;
            this.buttonOk.Text = "Đồng ý";
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonClose.Location = new System.Drawing.Point(329, 181);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonClose.TabIndex = 75;
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
            this.labelState.Location = new System.Drawing.Point(7, 152);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(75, 23);
            this.labelState.TabIndex = 81;
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
            this.comboBoxState.Location = new System.Drawing.Point(113, 155);
            this.comboBoxState.Name = "comboBoxState";
            this.comboBoxState.Size = new System.Drawing.Size(127, 20);
            this.comboBoxState.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBoxState.TabIndex = 73;
            // 
            // comboItemNo
            // 
            this.comboItemNo.Text = "Chưa xác nhận";
            // 
            // comboItemYes
            // 
            this.comboItemYes.Text = "Đã xác nhận";
            // 
            // textBoxResult
            // 
            // 
            // 
            // 
            this.textBoxResult.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Dot;
            this.textBoxResult.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxResult.Location = new System.Drawing.Point(113, 107);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(293, 42);
            this.textBoxResult.TabIndex = 72;
            this.superValidator1.SetValidator1(this.textBoxResult, this.requiredFieldValidator1);
            // 
            // labelAddress
            // 
            this.labelAddress.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelAddress.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelAddress.Location = new System.Drawing.Point(6, 107);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(116, 23);
            this.labelAddress.TabIndex = 80;
            this.labelAddress.Text = "Kết quả";
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(6, 81);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(66, 23);
            this.labelX3.TabIndex = 79;
            this.labelX3.Text = "Ngày lập";
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
            this.dateCreate.Location = new System.Drawing.Point(113, 81);
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
            this.dateCreate.Size = new System.Drawing.Size(293, 20);
            this.dateCreate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dateCreate.TabIndex = 71;
            this.dateCreate.Value = new System.DateTime(2012, 5, 20, 0, 0, 0, 0);
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(6, 55);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(92, 23);
            this.labelX2.TabIndex = 77;
            this.labelX2.Text = "Mã bệnh nhân";
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(6, 29);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(101, 23);
            this.labelX1.TabIndex = 78;
            this.labelX1.Text = "Mã nhân viên khám";
            // 
            // textBoxPatientID
            // 
            this.textBoxPatientID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            // 
            // 
            // 
            this.textBoxPatientID.Border.Class = "TextBoxBorder";
            this.textBoxPatientID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxPatientID.Location = new System.Drawing.Point(113, 55);
            this.textBoxPatientID.Name = "textBoxPatientID";
            this.textBoxPatientID.ReadOnly = true;
            this.textBoxPatientID.Size = new System.Drawing.Size(293, 20);
            this.textBoxPatientID.TabIndex = 69;
            // 
            // textBoxStaffID
            // 
            this.textBoxStaffID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            // 
            // 
            // 
            this.textBoxStaffID.Border.Class = "TextBoxBorder";
            this.textBoxStaffID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxStaffID.Location = new System.Drawing.Point(113, 29);
            this.textBoxStaffID.Name = "textBoxStaffID";
            this.textBoxStaffID.ReadOnly = true;
            this.textBoxStaffID.Size = new System.Drawing.Size(293, 20);
            this.textBoxStaffID.TabIndex = 68;
            // 
            // textBoxECID
            // 
            this.textBoxECID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            // 
            // 
            // 
            this.textBoxECID.Border.Class = "TextBoxBorder";
            this.textBoxECID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxECID.Location = new System.Drawing.Point(113, 3);
            this.textBoxECID.Name = "textBoxECID";
            this.textBoxECID.ReadOnly = true;
            this.textBoxECID.Size = new System.Drawing.Size(293, 20);
            this.textBoxECID.TabIndex = 70;
            // 
            // labelHCID
            // 
            this.labelHCID.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelHCID.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelHCID.Location = new System.Drawing.Point(6, 3);
            this.labelHCID.Name = "labelHCID";
            this.labelHCID.Size = new System.Drawing.Size(141, 23);
            this.labelHCID.TabIndex = 76;
            this.labelHCID.Text = "Mã phiếu khám bệnh";
            // 
            // superValidator1
            // 
            this.superValidator1.ContainerControl = this;
            this.superValidator1.ErrorProvider = this.errorProvider1;
            this.superValidator1.Highlighter = this.highlighter1;
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
            // requiredFieldValidator1
            // 
            this.requiredFieldValidator1.ErrorMessage = "Nhập kết quả khám bệnh";
            this.requiredFieldValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // FormECDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 232);
            this.Controls.Add(this.groupPanel1);
            this.Name = "FormECDetail";
            this.Text = "Thông tin phiếu khám bệnh";
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dateCreate)).EndInit();
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
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxResult;
        private DevComponents.DotNetBar.LabelX labelAddress;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateCreate;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxPatientID;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxStaffID;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxECID;
        private DevComponents.DotNetBar.LabelX labelHCID;
        private DevComponents.DotNetBar.Validator.SuperValidator superValidator1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter1;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator1;

    }
}