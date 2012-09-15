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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPayment));
            this.dataViewBill = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.buttonEdit = new DevComponents.DotNetBar.ButtonX();
            this.labelPrice = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.textBoxPatientID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBoxPatientName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelTotalPrice = new DevComponents.DotNetBar.LabelX();
            this.labelHICID = new DevComponents.DotNetBar.LabelX();
            this.labelHIC = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewBill)).BeginInit();
            this.SuspendLayout();
            // 
            // dataViewBill
            // 
            this.dataViewBill.AllowUserToAddRows = false;
            this.dataViewBill.AllowUserToDeleteRows = false;
            this.dataViewBill.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataViewBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataViewBill.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataViewBill.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataViewBill.Location = new System.Drawing.Point(12, 41);
            this.dataViewBill.MultiSelect = false;
            this.dataViewBill.Name = "dataViewBill";
            this.dataViewBill.ReadOnly = true;
            this.dataViewBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataViewBill.Size = new System.Drawing.Size(577, 252);
            this.dataViewBill.TabIndex = 0;
            // 
            // buttonEdit
            // 
            this.buttonEdit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEdit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonEdit.Image = ((System.Drawing.Image)(resources.GetObject("buttonEdit.Image")));
            this.buttonEdit.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonEdit.Location = new System.Drawing.Point(503, 299);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(86, 60);
            this.buttonEdit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonEdit.TabIndex = 21;
            this.buttonEdit.Text = "Thanh toán";
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // labelPrice
            // 
            this.labelPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.labelPrice.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelPrice.Location = new System.Drawing.Point(13, 299);
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
            this.textBoxPatientID.ReadOnly = true;
            this.textBoxPatientID.Size = new System.Drawing.Size(127, 20);
            this.textBoxPatientID.TabIndex = 26;
            // 
            // textBoxPatientName
            // 
            // 
            // 
            // 
            this.textBoxPatientName.Border.Class = "TextBoxBorder";
            this.textBoxPatientName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxPatientName.Location = new System.Drawing.Point(307, 15);
            this.textBoxPatientName.Name = "textBoxPatientName";
            this.textBoxPatientName.ReadOnly = true;
            this.textBoxPatientName.Size = new System.Drawing.Size(282, 20);
            this.textBoxPatientName.TabIndex = 28;
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(226, 12);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(75, 23);
            this.labelX4.TabIndex = 27;
            this.labelX4.Text = "Bệnh nhân:";
            // 
            // labelTotalPrice
            // 
            this.labelTotalPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelTotalPrice.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelTotalPrice.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalPrice.ForeColor = System.Drawing.Color.Red;
            this.labelTotalPrice.Location = new System.Drawing.Point(78, 299);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.Size = new System.Drawing.Size(160, 23);
            this.labelTotalPrice.TabIndex = 43;
            this.labelTotalPrice.Text = "100";
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
            this.labelHICID.Location = new System.Drawing.Point(93, 336);
            this.labelHICID.Name = "labelHICID";
            this.labelHICID.Size = new System.Drawing.Size(148, 23);
            this.labelHICID.TabIndex = 45;
            this.labelHICID.Text = "100";
            // 
            // labelHIC
            // 
            this.labelHIC.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelHIC.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelHIC.Location = new System.Drawing.Point(13, 336);
            this.labelHIC.Name = "labelHIC";
            this.labelHIC.Size = new System.Drawing.Size(74, 23);
            this.labelHIC.TabIndex = 44;
            this.labelHIC.Text = "Bảo hiểm y tế:";
            // 
            // FormPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 371);
            this.Controls.Add(this.labelHICID);
            this.Controls.Add(this.labelHIC);
            this.Controls.Add(this.labelTotalPrice);
            this.Controls.Add(this.textBoxPatientName);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.textBoxPatientID);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelPrice);
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
        private DevComponents.DotNetBar.ButtonX buttonEdit;
        private DevComponents.DotNetBar.LabelX labelPrice;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxPatientID;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxPatientName;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelTotalPrice;
        private DevComponents.DotNetBar.LabelX labelHICID;
        private DevComponents.DotNetBar.LabelX labelHIC;
    }
}