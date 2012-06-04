namespace Hospital.View
{
    partial class FormPayment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPayment));
            this.dataViewBill = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.buttonPrint = new DevComponents.DotNetBar.ButtonX();
            this.buttonEdit = new DevComponents.DotNetBar.ButtonX();
            this.labelPrice = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.textBoxPatientID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBoxPatientName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.buttonPay = new DevComponents.DotNetBar.ButtonX();
            this.labelTotalPrice = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewBill)).BeginInit();
            this.SuspendLayout();
            // 
            // dataViewBill
            // 
            this.dataViewBill.AllowUserToAddRows = false;
            this.dataViewBill.AllowUserToDeleteRows = false;
            this.dataViewBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataViewBill.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataViewBill.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataViewBill.Location = new System.Drawing.Point(12, 41);
            this.dataViewBill.MultiSelect = false;
            this.dataViewBill.Name = "dataViewBill";
            this.dataViewBill.ReadOnly = true;
            this.dataViewBill.Size = new System.Drawing.Size(472, 333);
            this.dataViewBill.TabIndex = 0;
            // 
            // buttonPrint
            // 
            this.buttonPrint.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPrint.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonPrint.Image = ((System.Drawing.Image)(resources.GetObject("buttonPrint.Image")));
            this.buttonPrint.Location = new System.Drawing.Point(490, 70);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(75, 23);
            this.buttonPrint.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonPrint.TabIndex = 22;
            this.buttonPrint.Text = "In";
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEdit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonEdit.Image = ((System.Drawing.Image)(resources.GetObject("buttonEdit.Image")));
            this.buttonEdit.Location = new System.Drawing.Point(490, 41);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonEdit.TabIndex = 21;
            this.buttonEdit.Text = "Cập nhật";
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // labelPrice
            // 
            // 
            // 
            // 
            this.labelPrice.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelPrice.Location = new System.Drawing.Point(240, 383);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(59, 23);
            this.labelPrice.TabIndex = 23;
            this.labelPrice.Text = "Tổng tiền:";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(12, 12);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 25;
            this.labelX3.Text = "Mã bệnh nhân:";
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
            this.textBoxPatientID.Size = new System.Drawing.Size(125, 20);
            this.textBoxPatientID.TabIndex = 26;
            // 
            // textBoxPatientName
            // 
            // 
            // 
            // 
            this.textBoxPatientName.Border.Class = "TextBoxBorder";
            this.textBoxPatientName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxPatientName.Location = new System.Drawing.Point(283, 15);
            this.textBoxPatientName.Name = "textBoxPatientName";
            this.textBoxPatientName.Size = new System.Drawing.Size(282, 20);
            this.textBoxPatientName.TabIndex = 28;
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(224, 12);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(75, 23);
            this.labelX4.TabIndex = 27;
            this.labelX4.Text = "Bệnh nhân:";
            // 
            // buttonPay
            // 
            this.buttonPay.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonPay.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonPay.Image = ((System.Drawing.Image)(resources.GetObject("buttonPay.Image")));
            this.buttonPay.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonPay.Location = new System.Drawing.Point(495, 304);
            this.buttonPay.Name = "buttonPay";
            this.buttonPay.Size = new System.Drawing.Size(70, 70);
            this.buttonPay.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonPay.TabIndex = 29;
            this.buttonPay.Text = "Thanh toán";
            // 
            // labelTotalPrice
            // 
            this.labelTotalPrice.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelTotalPrice.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalPrice.ForeColor = System.Drawing.Color.Red;
            this.labelTotalPrice.Location = new System.Drawing.Point(313, 380);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.Size = new System.Drawing.Size(171, 23);
            this.labelTotalPrice.TabIndex = 43;
            this.labelTotalPrice.Text = "100";
            // 
            // FormPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 415);
            this.Controls.Add(this.labelTotalPrice);
            this.Controls.Add(this.buttonPay);
            this.Controls.Add(this.textBoxPatientName);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.textBoxPatientID);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.dataViewBill);
            this.Name = "FormPayment";
            this.Text = "Tính viện phí";
            this.Load += new System.EventHandler(this.FormPayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataViewBill)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dataViewBill;
        private DevComponents.DotNetBar.ButtonX buttonPrint;
        private DevComponents.DotNetBar.ButtonX buttonEdit;
        private DevComponents.DotNetBar.LabelX labelPrice;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxPatientID;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxPatientName;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.ButtonX buttonPay;
        private DevComponents.DotNetBar.LabelX labelTotalPrice;
    }
}