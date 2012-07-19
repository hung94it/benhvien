namespace Hospital.View
{
    partial class FormBillDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBillDetail));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelPatientName = new DevComponents.DotNetBar.LabelX();
            this.labelStaffName = new DevComponents.DotNetBar.LabelX();
            this.textBoxStaffName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.groupPanelBill = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.buttonSave = new DevComponents.DotNetBar.ButtonX();
            this.textBoxQuantity = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelQuantity = new DevComponents.DotNetBar.LabelX();
            this.labelPriceDetail = new DevComponents.DotNetBar.LabelX();
            this.buttonClose = new DevComponents.DotNetBar.ButtonX();
            this.labelBillID = new DevComponents.DotNetBar.LabelX();
            this.textBoxBillID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelBillState = new DevComponents.DotNetBar.LabelX();
            this.labelStaffID = new DevComponents.DotNetBar.LabelX();
            this.buttonPay = new DevComponents.DotNetBar.ButtonX();
            this.textBoxStaffID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelTotalBillPrice = new DevComponents.DotNetBar.LabelX();
            this.textBoxPatientID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelHICID = new DevComponents.DotNetBar.LabelX();
            this.labelHIC = new DevComponents.DotNetBar.LabelX();
            this.labelState = new DevComponents.DotNetBar.LabelX();
            this.labelPrice = new DevComponents.DotNetBar.LabelX();
            this.labelDate = new DevComponents.DotNetBar.LabelX();
            this.textBoxPatientName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dateTimeInputBill = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelTotalPrice = new DevComponents.DotNetBar.LabelX();
            this.labelPatientID = new DevComponents.DotNetBar.LabelX();
            this.dataViewBillDetail = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.buttonDelete = new DevComponents.DotNetBar.ButtonX();
            this.buttonAdd = new DevComponents.DotNetBar.ButtonX();
            this.comboBoxDetail = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelDetail = new DevComponents.DotNetBar.LabelX();
            this.superValidator1 = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.regularExpressionValidator1 = new DevComponents.DotNetBar.Validator.RegularExpressionValidator();
            this.rangeValidator1 = new DevComponents.DotNetBar.Validator.RangeValidator();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.highlighter1 = new DevComponents.DotNetBar.Validator.Highlighter();
            this.groupPanelBill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeInputBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewBillDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPatientName
            // 
            this.labelPatientName.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelPatientName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelPatientName.Location = new System.Drawing.Point(18, 63);
            this.labelPatientName.Name = "labelPatientName";
            this.labelPatientName.Size = new System.Drawing.Size(74, 23);
            this.labelPatientName.TabIndex = 13;
            this.labelPatientName.Text = "Bệnh nhân:";
            // 
            // labelStaffName
            // 
            this.labelStaffName.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelStaffName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelStaffName.Location = new System.Drawing.Point(18, 115);
            this.labelStaffName.Name = "labelStaffName";
            this.labelStaffName.Size = new System.Drawing.Size(61, 23);
            this.labelStaffName.TabIndex = 15;
            this.labelStaffName.Text = "Nhân viên:";
            // 
            // textBoxStaffName
            // 
            // 
            // 
            // 
            this.textBoxStaffName.Border.Class = "TextBoxBorder";
            this.textBoxStaffName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxStaffName.Location = new System.Drawing.Point(98, 118);
            this.textBoxStaffName.Name = "textBoxStaffName";
            this.textBoxStaffName.ReadOnly = true;
            this.textBoxStaffName.Size = new System.Drawing.Size(300, 20);
            this.textBoxStaffName.TabIndex = 14;
            // 
            // groupPanelBill
            // 
            this.groupPanelBill.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupPanelBill.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanelBill.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanelBill.Controls.Add(this.buttonSave);
            this.groupPanelBill.Controls.Add(this.textBoxQuantity);
            this.groupPanelBill.Controls.Add(this.labelQuantity);
            this.groupPanelBill.Controls.Add(this.labelPriceDetail);
            this.groupPanelBill.Controls.Add(this.buttonClose);
            this.groupPanelBill.Controls.Add(this.labelBillID);
            this.groupPanelBill.Controls.Add(this.textBoxBillID);
            this.groupPanelBill.Controls.Add(this.labelBillState);
            this.groupPanelBill.Controls.Add(this.labelStaffID);
            this.groupPanelBill.Controls.Add(this.buttonPay);
            this.groupPanelBill.Controls.Add(this.textBoxStaffID);
            this.groupPanelBill.Controls.Add(this.labelTotalBillPrice);
            this.groupPanelBill.Controls.Add(this.textBoxPatientID);
            this.groupPanelBill.Controls.Add(this.labelHICID);
            this.groupPanelBill.Controls.Add(this.labelHIC);
            this.groupPanelBill.Controls.Add(this.labelState);
            this.groupPanelBill.Controls.Add(this.labelPrice);
            this.groupPanelBill.Controls.Add(this.labelDate);
            this.groupPanelBill.Controls.Add(this.textBoxPatientName);
            this.groupPanelBill.Controls.Add(this.dateTimeInputBill);
            this.groupPanelBill.Controls.Add(this.labelTotalPrice);
            this.groupPanelBill.Controls.Add(this.labelPatientID);
            this.groupPanelBill.Controls.Add(this.labelStaffName);
            this.groupPanelBill.Controls.Add(this.dataViewBillDetail);
            this.groupPanelBill.Controls.Add(this.buttonDelete);
            this.groupPanelBill.Controls.Add(this.buttonAdd);
            this.groupPanelBill.Controls.Add(this.comboBoxDetail);
            this.groupPanelBill.Controls.Add(this.textBoxStaffName);
            this.groupPanelBill.Controls.Add(this.labelPatientName);
            this.groupPanelBill.Controls.Add(this.labelDetail);
            this.groupPanelBill.Location = new System.Drawing.Point(12, 12);
            this.groupPanelBill.Name = "groupPanelBill";
            this.groupPanelBill.Size = new System.Drawing.Size(860, 388);
            // 
            // 
            // 
            this.groupPanelBill.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanelBill.Style.BackColorGradientAngle = 90;
            this.groupPanelBill.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanelBill.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelBill.Style.BorderBottomWidth = 1;
            this.groupPanelBill.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanelBill.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelBill.Style.BorderLeftWidth = 1;
            this.groupPanelBill.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelBill.Style.BorderRightWidth = 1;
            this.groupPanelBill.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelBill.Style.BorderTopWidth = 1;
            this.groupPanelBill.Style.CornerDiameter = 4;
            this.groupPanelBill.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanelBill.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanelBill.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanelBill.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanelBill.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanelBill.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanelBill.TabIndex = 0;
            this.groupPanelBill.Text = "Thông tin hóa đơn";
            // 
            // buttonSave
            // 
            this.buttonSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonSave.Image = ((System.Drawing.Image)(resources.GetObject("buttonSave.Image")));
            this.buttonSave.Location = new System.Drawing.Point(630, 339);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(126, 23);
            this.buttonSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonSave.TabIndex = 49;
            this.buttonSave.Text = "Lưu hóa đơn";
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxQuantity
            // 
            // 
            // 
            // 
            this.textBoxQuantity.Border.Class = "TextBoxBorder";
            this.textBoxQuantity.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxQuantity.Location = new System.Drawing.Point(484, 46);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(77, 20);
            this.textBoxQuantity.TabIndex = 1;
            this.superValidator1.SetValidator2(this.textBoxQuantity, this.regularExpressionValidator1);
            this.superValidator1.SetValidator3(this.textBoxQuantity, this.rangeValidator1);
            // 
            // labelQuantity
            // 
            this.labelQuantity.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelQuantity.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelQuantity.Location = new System.Drawing.Point(404, 43);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(54, 23);
            this.labelQuantity.TabIndex = 48;
            this.labelQuantity.Text = "Số lượng:";
            // 
            // labelPriceDetail
            // 
            this.labelPriceDetail.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelPriceDetail.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelPriceDetail.Location = new System.Drawing.Point(647, 46);
            this.labelPriceDetail.Name = "labelPriceDetail";
            this.labelPriceDetail.Size = new System.Drawing.Size(190, 23);
            this.labelPriceDetail.TabIndex = 47;
            this.labelPriceDetail.Text = "100";
            // 
            // buttonClose
            // 
            this.buttonClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonClose.Location = new System.Drawing.Point(762, 339);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonClose.TabIndex = 46;
            this.buttonClose.Text = "Đóng";
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelBillID
            // 
            this.labelBillID.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelBillID.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelBillID.Location = new System.Drawing.Point(18, 14);
            this.labelBillID.Name = "labelBillID";
            this.labelBillID.Size = new System.Drawing.Size(61, 23);
            this.labelBillID.TabIndex = 45;
            this.labelBillID.Text = "Số hóa đơn:";
            // 
            // textBoxBillID
            // 
            // 
            // 
            // 
            this.textBoxBillID.Border.Class = "TextBoxBorder";
            this.textBoxBillID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxBillID.Location = new System.Drawing.Point(98, 14);
            this.textBoxBillID.Name = "textBoxBillID";
            this.textBoxBillID.ReadOnly = true;
            this.textBoxBillID.Size = new System.Drawing.Size(300, 20);
            this.textBoxBillID.TabIndex = 44;
            // 
            // labelBillState
            // 
            this.labelBillState.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelBillState.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelBillState.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBillState.ForeColor = System.Drawing.Color.Red;
            this.labelBillState.Location = new System.Drawing.Point(98, 310);
            this.labelBillState.Name = "labelBillState";
            this.labelBillState.Size = new System.Drawing.Size(171, 23);
            this.labelBillState.TabIndex = 43;
            this.labelBillState.Text = "Chưa thanh toán";
            // 
            // labelStaffID
            // 
            this.labelStaffID.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelStaffID.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelStaffID.Location = new System.Drawing.Point(18, 89);
            this.labelStaffID.Name = "labelStaffID";
            this.labelStaffID.Size = new System.Drawing.Size(70, 23);
            this.labelStaffID.TabIndex = 25;
            this.labelStaffID.Text = "Mã nhân viên:";
            // 
            // buttonPay
            // 
            this.buttonPay.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonPay.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonPay.Image = ((System.Drawing.Image)(resources.GetObject("buttonPay.Image")));
            this.buttonPay.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonPay.Location = new System.Drawing.Point(328, 263);
            this.buttonPay.Name = "buttonPay";
            this.buttonPay.Size = new System.Drawing.Size(70, 70);
            this.buttonPay.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonPay.TabIndex = 3;
            this.buttonPay.Text = "Thanh toán";
            this.buttonPay.Click += new System.EventHandler(this.buttonPay_Click);
            // 
            // textBoxStaffID
            // 
            // 
            // 
            // 
            this.textBoxStaffID.Border.Class = "TextBoxBorder";
            this.textBoxStaffID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxStaffID.Location = new System.Drawing.Point(98, 92);
            this.textBoxStaffID.Name = "textBoxStaffID";
            this.textBoxStaffID.ReadOnly = true;
            this.textBoxStaffID.Size = new System.Drawing.Size(300, 20);
            this.textBoxStaffID.TabIndex = 24;
            // 
            // labelTotalBillPrice
            // 
            this.labelTotalBillPrice.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelTotalBillPrice.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelTotalBillPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalBillPrice.ForeColor = System.Drawing.Color.Red;
            this.labelTotalBillPrice.Location = new System.Drawing.Point(98, 282);
            this.labelTotalBillPrice.Name = "labelTotalBillPrice";
            this.labelTotalBillPrice.Size = new System.Drawing.Size(171, 23);
            this.labelTotalBillPrice.TabIndex = 42;
            this.labelTotalBillPrice.Text = "100";
            // 
            // textBoxPatientID
            // 
            // 
            // 
            // 
            this.textBoxPatientID.Border.Class = "TextBoxBorder";
            this.textBoxPatientID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxPatientID.Location = new System.Drawing.Point(98, 40);
            this.textBoxPatientID.Name = "textBoxPatientID";
            this.textBoxPatientID.ReadOnly = true;
            this.textBoxPatientID.Size = new System.Drawing.Size(300, 20);
            this.textBoxPatientID.TabIndex = 23;
            // 
            // labelHICID
            // 
            this.labelHICID.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelHICID.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelHICID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHICID.ForeColor = System.Drawing.Color.Red;
            this.labelHICID.Location = new System.Drawing.Point(98, 336);
            this.labelHICID.Name = "labelHICID";
            this.labelHICID.Size = new System.Drawing.Size(148, 23);
            this.labelHICID.TabIndex = 41;
            this.labelHICID.Text = "100";
            // 
            // labelHIC
            // 
            this.labelHIC.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelHIC.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelHIC.Location = new System.Drawing.Point(18, 339);
            this.labelHIC.Name = "labelHIC";
            this.labelHIC.Size = new System.Drawing.Size(74, 23);
            this.labelHIC.TabIndex = 41;
            this.labelHIC.Text = "Bảo hiểm y tế:";
            // 
            // labelState
            // 
            this.labelState.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelState.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelState.Location = new System.Drawing.Point(18, 310);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(74, 23);
            this.labelState.TabIndex = 41;
            this.labelState.Text = "Tình trạng:";
            // 
            // labelPrice
            // 
            this.labelPrice.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelPrice.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelPrice.Location = new System.Drawing.Point(591, 46);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(50, 23);
            this.labelPrice.TabIndex = 36;
            this.labelPrice.Text = "Đơn giá:";
            // 
            // labelDate
            // 
            this.labelDate.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelDate.Location = new System.Drawing.Point(18, 144);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(61, 23);
            this.labelDate.TabIndex = 39;
            this.labelDate.Text = "Ngày lập:";
            // 
            // textBoxPatientName
            // 
            // 
            // 
            // 
            this.textBoxPatientName.Border.Class = "TextBoxBorder";
            this.textBoxPatientName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxPatientName.Location = new System.Drawing.Point(98, 66);
            this.textBoxPatientName.Name = "textBoxPatientName";
            this.textBoxPatientName.ReadOnly = true;
            this.textBoxPatientName.Size = new System.Drawing.Size(300, 20);
            this.textBoxPatientName.TabIndex = 22;
            // 
            // dateTimeInputBill
            // 
            // 
            // 
            // 
            this.dateTimeInputBill.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dateTimeInputBill.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInputBill.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dateTimeInputBill.ButtonDropDown.Visible = true;
            this.dateTimeInputBill.IsPopupCalendarOpen = false;
            this.dateTimeInputBill.Location = new System.Drawing.Point(98, 144);
            // 
            // 
            // 
            this.dateTimeInputBill.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateTimeInputBill.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInputBill.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dateTimeInputBill.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dateTimeInputBill.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dateTimeInputBill.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dateTimeInputBill.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dateTimeInputBill.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dateTimeInputBill.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dateTimeInputBill.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dateTimeInputBill.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInputBill.MonthCalendar.DisplayMonth = new System.DateTime(2012, 5, 1, 0, 0, 0, 0);
            this.dateTimeInputBill.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dateTimeInputBill.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateTimeInputBill.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dateTimeInputBill.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dateTimeInputBill.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dateTimeInputBill.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInputBill.MonthCalendar.TodayButtonVisible = true;
            this.dateTimeInputBill.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dateTimeInputBill.Name = "dateTimeInputBill";
            this.dateTimeInputBill.Size = new System.Drawing.Size(219, 20);
            this.dateTimeInputBill.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dateTimeInputBill.TabIndex = 38;
            // 
            // labelTotalPrice
            // 
            this.labelTotalPrice.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelTotalPrice.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelTotalPrice.Location = new System.Drawing.Point(18, 281);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.Size = new System.Drawing.Size(74, 23);
            this.labelTotalPrice.TabIndex = 40;
            this.labelTotalPrice.Text = "Tổng tiền:";
            // 
            // labelPatientID
            // 
            this.labelPatientID.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelPatientID.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelPatientID.Location = new System.Drawing.Point(18, 37);
            this.labelPatientID.Name = "labelPatientID";
            this.labelPatientID.Size = new System.Drawing.Size(74, 23);
            this.labelPatientID.TabIndex = 21;
            this.labelPatientID.Text = "Mã bệnh nhân:";
            // 
            // dataViewBillDetail
            // 
            this.dataViewBillDetail.AllowUserToAddRows = false;
            this.dataViewBillDetail.AllowUserToDeleteRows = false;
            this.dataViewBillDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataViewBillDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataViewBillDetail.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataViewBillDetail.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataViewBillDetail.Location = new System.Drawing.Point(404, 104);
            this.dataViewBillDetail.Name = "dataViewBillDetail";
            this.dataViewBillDetail.ReadOnly = true;
            this.dataViewBillDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataViewBillDetail.Size = new System.Drawing.Size(433, 229);
            this.dataViewBillDetail.TabIndex = 31;
            // 
            // buttonDelete
            // 
            this.buttonDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonDelete.Image = ((System.Drawing.Image)(resources.GetObject("buttonDelete.Image")));
            this.buttonDelete.Location = new System.Drawing.Point(768, 75);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(69, 23);
            this.buttonDelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonDelete.TabIndex = 32;
            this.buttonDelete.Text = "Xóa";
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonAdd.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdd.Image")));
            this.buttonAdd.Location = new System.Drawing.Point(693, 75);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(69, 23);
            this.buttonAdd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Thêm";
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // comboBoxDetail
            // 
            this.comboBoxDetail.DisplayMember = "Text";
            this.comboBoxDetail.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxDetail.FormattingEnabled = true;
            this.comboBoxDetail.ItemHeight = 14;
            this.comboBoxDetail.Location = new System.Drawing.Point(483, 17);
            this.comboBoxDetail.Name = "comboBoxDetail";
            this.comboBoxDetail.Size = new System.Drawing.Size(254, 20);
            this.comboBoxDetail.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBoxDetail.TabIndex = 0;
            this.comboBoxDetail.SelectedIndexChanged += new System.EventHandler(this.comboBoxDetail_SelectedIndexChanged);
            // 
            // labelDetail
            // 
            this.labelDetail.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelDetail.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelDetail.Location = new System.Drawing.Point(404, 14);
            this.labelDetail.Name = "labelDetail";
            this.labelDetail.Size = new System.Drawing.Size(54, 23);
            this.labelDetail.TabIndex = 35;
            this.labelDetail.Text = "Đồ dùng;";
            // 
            // superValidator1
            // 
            this.superValidator1.ContainerControl = this;
            this.superValidator1.ErrorProvider = this.errorProvider1;
            this.superValidator1.Highlighter = this.highlighter1;
            // 
            // regularExpressionValidator1
            // 
            this.regularExpressionValidator1.ErrorMessage = "Nhập số lượng";
            this.regularExpressionValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.regularExpressionValidator1.ValidationExpression = "[1-9]\\d*";
            // 
            // rangeValidator1
            // 
            this.rangeValidator1.ErrorMessage = "Số lượng phải từ 1-1000";
            this.rangeValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.rangeValidator1.MaximumValue = "1000";
            this.rangeValidator1.MinimumValue = "1";
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
            // FormBillDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 412);
            this.Controls.Add(this.groupPanelBill);
            this.Name = "FormBillDetail";
            this.Text = "Chi tiết hóa đơn";
            this.groupPanelBill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeInputBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewBillDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX textBoxStaffName;
        private DevComponents.DotNetBar.LabelX labelPatientName;
        private DevComponents.DotNetBar.LabelX labelStaffName;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanelBill;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxPatientID;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxPatientName;
        private DevComponents.DotNetBar.LabelX labelPatientID;
        private DevComponents.DotNetBar.LabelX labelStaffID;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxStaffID;
        private DevComponents.DotNetBar.ButtonX buttonClose;
        private DevComponents.DotNetBar.LabelX labelBillID;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxBillID;
        private DevComponents.DotNetBar.LabelX labelBillState;
        private DevComponents.DotNetBar.ButtonX buttonPay;
        private DevComponents.DotNetBar.LabelX labelTotalBillPrice;
        private DevComponents.DotNetBar.LabelX labelState;
        private DevComponents.DotNetBar.LabelX labelPrice;
        private DevComponents.DotNetBar.LabelX labelDate;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateTimeInputBill;
        private DevComponents.DotNetBar.LabelX labelTotalPrice;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataViewBillDetail;
        private DevComponents.DotNetBar.ButtonX buttonDelete;
        private DevComponents.DotNetBar.ButtonX buttonAdd;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxDetail;
        private DevComponents.DotNetBar.LabelX labelDetail;
        private DevComponents.DotNetBar.LabelX labelPriceDetail;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxQuantity;
        private DevComponents.DotNetBar.LabelX labelQuantity;
        private DevComponents.DotNetBar.Validator.SuperValidator superValidator1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter1;
        private DevComponents.DotNetBar.Validator.RegularExpressionValidator regularExpressionValidator1;
        private DevComponents.DotNetBar.ButtonX buttonSave;
        private DevComponents.DotNetBar.Validator.RangeValidator rangeValidator1;
        private DevComponents.DotNetBar.LabelX labelHIC;
        private DevComponents.DotNetBar.LabelX labelHICID;
    }
}