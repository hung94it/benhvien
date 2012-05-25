namespace Hospital.View
{
    partial class FormHFDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHFDetail));
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.buttonOk = new DevComponents.DotNetBar.ButtonX();
            this.buttonClose = new DevComponents.DotNetBar.ButtonX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.dateCreate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.textBoxTreatment = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.textBoxDisease = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.textBoxPrehistory = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.textBoxPatientState = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelAddress = new DevComponents.DotNetBar.LabelX();
            this.textBoxPatientID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.textBoxHFID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelHCID = new DevComponents.DotNetBar.LabelX();
            this.superValidator1 = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.highlighter1 = new DevComponents.DotNetBar.Validator.Highlighter();
            this.requiredFieldValidator2 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Nhập tình trạng bệnh nhân");
            this.requiredFieldValidator1 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Nhập tiến sử bệnh lý");
            this.requiredFieldValidator3 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Nhập bệnh mắc phải");
            this.requiredFieldValidator4 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Nhập hướng điều trị");
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
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Controls.Add(this.dateCreate);
            this.groupPanel1.Controls.Add(this.textBoxTreatment);
            this.groupPanel1.Controls.Add(this.labelX5);
            this.groupPanel1.Controls.Add(this.textBoxDisease);
            this.groupPanel1.Controls.Add(this.labelX4);
            this.groupPanel1.Controls.Add(this.textBoxPrehistory);
            this.groupPanel1.Controls.Add(this.labelX3);
            this.groupPanel1.Controls.Add(this.textBoxPatientState);
            this.groupPanel1.Controls.Add(this.labelAddress);
            this.groupPanel1.Controls.Add(this.textBoxPatientID);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.Controls.Add(this.textBoxHFID);
            this.groupPanel1.Controls.Add(this.labelHCID);
            this.groupPanel1.Location = new System.Drawing.Point(12, 3);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(448, 325);
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
            this.groupPanel1.Text = "Bệnh án";
            // 
            // buttonOk
            // 
            this.buttonOk.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonOk.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonOk.Location = new System.Drawing.Point(251, 276);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonOk.TabIndex = 65;
            this.buttonOk.Text = "Đồng ý";
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonClose.Location = new System.Drawing.Point(343, 276);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonClose.TabIndex = 66;
            this.buttonClose.Text = "Đóng";
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
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
            this.labelX2.Size = new System.Drawing.Size(121, 23);
            this.labelX2.TabIndex = 73;
            this.labelX2.Text = "Ngày lập";
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
            this.dateCreate.Location = new System.Drawing.Point(125, 58);
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
            this.dateCreate.TabIndex = 60;
            this.dateCreate.Value = new System.DateTime(2012, 5, 20, 0, 0, 0, 0);
            // 
            // textBoxTreatment
            // 
            // 
            // 
            // 
            this.textBoxTreatment.Border.Class = "TextBoxBorder";
            this.textBoxTreatment.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxTreatment.Location = new System.Drawing.Point(125, 228);
            this.textBoxTreatment.Multiline = true;
            this.textBoxTreatment.Name = "textBoxTreatment";
            this.textBoxTreatment.Size = new System.Drawing.Size(293, 42);
            this.textBoxTreatment.TabIndex = 64;
            this.superValidator1.SetValidator1(this.textBoxTreatment, this.requiredFieldValidator4);
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(3, 225);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(116, 23);
            this.labelX5.TabIndex = 67;
            this.labelX5.Text = "Hướng điều trị";
            // 
            // textBoxDisease
            // 
            // 
            // 
            // 
            this.textBoxDisease.Border.Class = "TextBoxBorder";
            this.textBoxDisease.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxDisease.Location = new System.Drawing.Point(125, 180);
            this.textBoxDisease.Multiline = true;
            this.textBoxDisease.Name = "textBoxDisease";
            this.textBoxDisease.Size = new System.Drawing.Size(293, 42);
            this.textBoxDisease.TabIndex = 63;
            this.superValidator1.SetValidator1(this.textBoxDisease, this.requiredFieldValidator3);
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(3, 177);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(116, 23);
            this.labelX4.TabIndex = 70;
            this.labelX4.Text = "Bệnh mắc phải";
            // 
            // textBoxPrehistory
            // 
            // 
            // 
            // 
            this.textBoxPrehistory.Border.Class = "TextBoxBorder";
            this.textBoxPrehistory.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxPrehistory.Location = new System.Drawing.Point(125, 132);
            this.textBoxPrehistory.Multiline = true;
            this.textBoxPrehistory.Name = "textBoxPrehistory";
            this.textBoxPrehistory.Size = new System.Drawing.Size(293, 42);
            this.textBoxPrehistory.TabIndex = 62;
            this.superValidator1.SetValidator1(this.textBoxPrehistory, this.requiredFieldValidator1);
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(3, 129);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(116, 23);
            this.labelX3.TabIndex = 72;
            this.labelX3.Text = "Tiền sử bệnh lý";
            // 
            // textBoxPatientState
            // 
            // 
            // 
            // 
            this.textBoxPatientState.Border.Class = "TextBoxBorder";
            this.textBoxPatientState.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxPatientState.Location = new System.Drawing.Point(125, 84);
            this.textBoxPatientState.Multiline = true;
            this.textBoxPatientState.Name = "textBoxPatientState";
            this.textBoxPatientState.Size = new System.Drawing.Size(293, 42);
            this.textBoxPatientState.TabIndex = 61;
            this.superValidator1.SetValidator1(this.textBoxPatientState, this.requiredFieldValidator2);
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
            this.labelAddress.Size = new System.Drawing.Size(116, 23);
            this.labelAddress.TabIndex = 71;
            this.labelAddress.Text = "Tình trạng bệnh nhân";
            // 
            // textBoxPatientID
            // 
            this.textBoxPatientID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxPatientID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            // 
            // 
            // 
            this.textBoxPatientID.Border.Class = "TextBoxBorder";
            this.textBoxPatientID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxPatientID.Location = new System.Drawing.Point(125, 32);
            this.textBoxPatientID.Name = "textBoxPatientID";
            this.textBoxPatientID.ReadOnly = true;
            this.textBoxPatientID.Size = new System.Drawing.Size(293, 20);
            this.textBoxPatientID.TabIndex = 59;
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
            this.labelX1.TabIndex = 68;
            this.labelX1.Text = "Mã bệnh nhân";
            // 
            // textBoxHFID
            // 
            this.textBoxHFID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            // 
            // 
            // 
            this.textBoxHFID.Border.Class = "TextBoxBorder";
            this.textBoxHFID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxHFID.Location = new System.Drawing.Point(125, 6);
            this.textBoxHFID.Name = "textBoxHFID";
            this.textBoxHFID.ReadOnly = true;
            this.textBoxHFID.Size = new System.Drawing.Size(293, 20);
            this.textBoxHFID.TabIndex = 58;
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
            this.labelHCID.TabIndex = 69;
            this.labelHCID.Text = "Mã bệnh án";
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
            // requiredFieldValidator2
            // 
            this.requiredFieldValidator2.ErrorMessage = "Nhập tình trạng bệnh nhân";
            this.requiredFieldValidator2.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // requiredFieldValidator1
            // 
            this.requiredFieldValidator1.ErrorMessage = "Nhập tiến sử bệnh lý";
            this.requiredFieldValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // requiredFieldValidator3
            // 
            this.requiredFieldValidator3.ErrorMessage = "Nhập bệnh mắc phải";
            this.requiredFieldValidator3.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // requiredFieldValidator4
            // 
            this.requiredFieldValidator4.ErrorMessage = "Nhập hướng điều trị";
            this.requiredFieldValidator4.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // FormHFDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 341);
            this.Controls.Add(this.groupPanel1);
            this.Name = "FormHFDetail";
            this.Text = "Thông tin bệnh án";
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dateCreate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.ButtonX buttonOk;
        private DevComponents.DotNetBar.ButtonX buttonClose;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateCreate;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxTreatment;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxDisease;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxPrehistory;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxPatientState;
        private DevComponents.DotNetBar.LabelX labelAddress;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxPatientID;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxHFID;
        private DevComponents.DotNetBar.LabelX labelHCID;
        private DevComponents.DotNetBar.Validator.SuperValidator superValidator1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter1;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator2;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator4;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator3;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator1;

    }
}