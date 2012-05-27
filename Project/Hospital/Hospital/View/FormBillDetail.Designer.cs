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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBillDetail));
            this.dataViewMedicine = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.dataViewService = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.dataViewMaterial = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.labelMedicinePrice = new DevComponents.DotNetBar.LabelX();
            this.labelMedicine = new DevComponents.DotNetBar.LabelX();
            this.comboBoxMedicine = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.buttonMedicineAdd = new DevComponents.DotNetBar.ButtonX();
            this.buttonMedicineDelete = new DevComponents.DotNetBar.ButtonX();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX3 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX4 = new DevComponents.DotNetBar.ButtonX();
            this.buttonPay = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewMedicine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewMaterial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataViewMedicine
            // 
            this.dataViewMedicine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataViewMedicine.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataViewMedicine.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataViewMedicine.Location = new System.Drawing.Point(0, 82);
            this.dataViewMedicine.Name = "dataViewMedicine";
            this.dataViewMedicine.Size = new System.Drawing.Size(444, 518);
            this.dataViewMedicine.TabIndex = 0;
            // 
            // dataViewService
            // 
            this.dataViewService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataViewService.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataViewService.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataViewService.Location = new System.Drawing.Point(58, 120);
            this.dataViewService.Name = "dataViewService";
            this.dataViewService.Size = new System.Drawing.Size(376, 150);
            this.dataViewService.TabIndex = 1;
            // 
            // dataViewMaterial
            // 
            this.dataViewMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataViewMaterial.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataViewMaterial.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataViewMaterial.Location = new System.Drawing.Point(38, 123);
            this.dataViewMaterial.Name = "dataViewMaterial";
            this.dataViewMaterial.Size = new System.Drawing.Size(396, 150);
            this.dataViewMaterial.TabIndex = 2;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.buttonPay);
            this.splitContainer1.Panel1.Controls.Add(this.labelMedicinePrice);
            this.splitContainer1.Panel1.Controls.Add(this.labelMedicine);
            this.splitContainer1.Panel1.Controls.Add(this.comboBoxMedicine);
            this.splitContainer1.Panel1.Controls.Add(this.buttonMedicineAdd);
            this.splitContainer1.Panel1.Controls.Add(this.buttonMedicineDelete);
            this.splitContainer1.Panel1.Controls.Add(this.dataViewMedicine);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(884, 684);
            this.splitContainer1.SplitterDistance = 446;
            this.splitContainer1.TabIndex = 3;
            // 
            // labelMedicinePrice
            // 
            // 
            // 
            // 
            this.labelMedicinePrice.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelMedicinePrice.Location = new System.Drawing.Point(12, 53);
            this.labelMedicinePrice.Name = "labelMedicinePrice";
            this.labelMedicinePrice.Size = new System.Drawing.Size(45, 23);
            this.labelMedicinePrice.TabIndex = 13;
            this.labelMedicinePrice.Text = "Giá:";
            // 
            // labelMedicine
            // 
            // 
            // 
            // 
            this.labelMedicine.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelMedicine.Location = new System.Drawing.Point(13, 24);
            this.labelMedicine.Name = "labelMedicine";
            this.labelMedicine.Size = new System.Drawing.Size(45, 23);
            this.labelMedicine.TabIndex = 12;
            this.labelMedicine.Text = "Thuốc:";
            // 
            // comboBoxMedicine
            // 
            this.comboBoxMedicine.DisplayMember = "Text";
            this.comboBoxMedicine.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxMedicine.FormattingEnabled = true;
            this.comboBoxMedicine.ItemHeight = 14;
            this.comboBoxMedicine.Location = new System.Drawing.Point(64, 27);
            this.comboBoxMedicine.Name = "comboBoxMedicine";
            this.comboBoxMedicine.Size = new System.Drawing.Size(379, 20);
            this.comboBoxMedicine.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBoxMedicine.TabIndex = 11;
            // 
            // buttonMedicineAdd
            // 
            this.buttonMedicineAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonMedicineAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMedicineAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonMedicineAdd.Image = ((System.Drawing.Image)(resources.GetObject("buttonMedicineAdd.Image")));
            this.buttonMedicineAdd.Location = new System.Drawing.Point(287, 53);
            this.buttonMedicineAdd.Name = "buttonMedicineAdd";
            this.buttonMedicineAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonMedicineAdd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonMedicineAdd.TabIndex = 10;
            this.buttonMedicineAdd.Text = "Thêm";
            // 
            // buttonMedicineDelete
            // 
            this.buttonMedicineDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonMedicineDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMedicineDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonMedicineDelete.Image = ((System.Drawing.Image)(resources.GetObject("buttonMedicineDelete.Image")));
            this.buttonMedicineDelete.Location = new System.Drawing.Point(368, 53);
            this.buttonMedicineDelete.Name = "buttonMedicineDelete";
            this.buttonMedicineDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonMedicineDelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonMedicineDelete.TabIndex = 8;
            this.buttonMedicineDelete.Text = "Xóa";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.buttonX1);
            this.splitContainer2.Panel1.Controls.Add(this.buttonX2);
            this.splitContainer2.Panel1.Controls.Add(this.dataViewService);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.buttonX3);
            this.splitContainer2.Panel2.Controls.Add(this.buttonX4);
            this.splitContainer2.Panel2.Controls.Add(this.dataViewMaterial);
            this.splitContainer2.Size = new System.Drawing.Size(434, 684);
            this.splitContainer2.SplitterDistance = 305;
            this.splitContainer2.TabIndex = 0;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Image = ((System.Drawing.Image)(resources.GetObject("buttonX1.Image")));
            this.buttonX1.Location = new System.Drawing.Point(239, 67);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(75, 23);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 12;
            this.buttonX1.Text = "Thêm mới";
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.Image = ((System.Drawing.Image)(resources.GetObject("buttonX2.Image")));
            this.buttonX2.Location = new System.Drawing.Point(335, 67);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(75, 23);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX2.TabIndex = 11;
            this.buttonX2.Text = "Xóa";
            // 
            // buttonX3
            // 
            this.buttonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX3.Image = ((System.Drawing.Image)(resources.GetObject("buttonX3.Image")));
            this.buttonX3.Location = new System.Drawing.Point(239, 76);
            this.buttonX3.Name = "buttonX3";
            this.buttonX3.Size = new System.Drawing.Size(75, 23);
            this.buttonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX3.TabIndex = 12;
            this.buttonX3.Text = "Thêm mới";
            // 
            // buttonX4
            // 
            this.buttonX4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonX4.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX4.Image = ((System.Drawing.Image)(resources.GetObject("buttonX4.Image")));
            this.buttonX4.Location = new System.Drawing.Point(335, 76);
            this.buttonX4.Name = "buttonX4";
            this.buttonX4.Size = new System.Drawing.Size(75, 23);
            this.buttonX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX4.TabIndex = 11;
            this.buttonX4.Text = "Xóa";
            // 
            // buttonPay
            // 
            this.buttonPay.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonPay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPay.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonPay.Image = ((System.Drawing.Image)(resources.GetObject("buttonPay.Image")));
            this.buttonPay.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonPay.Location = new System.Drawing.Point(354, 606);
            this.buttonPay.Name = "buttonPay";
            this.buttonPay.Size = new System.Drawing.Size(70, 70);
            this.buttonPay.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonPay.TabIndex = 14;
            this.buttonPay.Text = "Thanh toán";
            // 
            // FormBillDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 684);
            this.Controls.Add(this.splitContainer1);
            this.MinimumSize = new System.Drawing.Size(900, 700);
            this.Name = "FormBillDetail";
            this.Text = "FormBillDetail";
            ((System.ComponentModel.ISupportInitialize)(this.dataViewMedicine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewService)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewMaterial)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dataViewMedicine;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataViewService;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataViewMaterial;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private DevComponents.DotNetBar.LabelX labelMedicinePrice;
        private DevComponents.DotNetBar.LabelX labelMedicine;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxMedicine;
        private DevComponents.DotNetBar.ButtonX buttonMedicineAdd;
        private DevComponents.DotNetBar.ButtonX buttonMedicineDelete;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private DevComponents.DotNetBar.ButtonX buttonX3;
        private DevComponents.DotNetBar.ButtonX buttonX4;
        private DevComponents.DotNetBar.ButtonX buttonPay;
    }
}