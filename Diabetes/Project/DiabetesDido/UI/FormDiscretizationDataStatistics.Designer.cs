namespace DiabetesDido.UI
{
    partial class FormDiscretizationDataStatistics
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDiscretizationDataStatistics));
            this.dataGridViewXDiscretizationDataStatistics = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.bindingSourceDiscretizationDataStatistics = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorExDiscretizationDataStatistics = new DevComponents.DotNetBar.Controls.BindingNavigatorEx(this.components);
            this.bindingNavigatorMoveFirstItem = new DevComponents.DotNetBar.ButtonItem();
            this.bindingNavigatorMovePreviousItem = new DevComponents.DotNetBar.ButtonItem();
            this.bindingNavigatorPositionItem = new DevComponents.DotNetBar.TextBoxItem();
            this.bindingNavigatorCountItem = new DevComponents.DotNetBar.LabelItem();
            this.bindingNavigatorMoveNextItem = new DevComponents.DotNetBar.ButtonItem();
            this.bindingNavigatorMoveLastItem = new DevComponents.DotNetBar.ButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXDiscretizationDataStatistics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDiscretizationDataStatistics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorExDiscretizationDataStatistics)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewXDiscretizationDataStatistics
            // 
            this.dataGridViewXDiscretizationDataStatistics.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewXDiscretizationDataStatistics.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewXDiscretizationDataStatistics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewXDiscretizationDataStatistics.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewXDiscretizationDataStatistics.EnableHeadersVisualStyles = false;
            this.dataGridViewXDiscretizationDataStatistics.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dataGridViewXDiscretizationDataStatistics.Location = new System.Drawing.Point(0, 26);
            this.dataGridViewXDiscretizationDataStatistics.Name = "dataGridViewXDiscretizationDataStatistics";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewXDiscretizationDataStatistics.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewXDiscretizationDataStatistics.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewXDiscretizationDataStatistics.Size = new System.Drawing.Size(625, 273);
            this.dataGridViewXDiscretizationDataStatistics.TabIndex = 0;
            // 
            // bindingNavigatorExDiscretizationDataStatistics
            // 
            this.bindingNavigatorExDiscretizationDataStatistics.AntiAlias = true;
            this.bindingNavigatorExDiscretizationDataStatistics.CountLabel = this.bindingNavigatorCountItem;
            this.bindingNavigatorExDiscretizationDataStatistics.CountLabelFormat = "of {0}";
            this.bindingNavigatorExDiscretizationDataStatistics.Dock = System.Windows.Forms.DockStyle.Top;
            this.bindingNavigatorExDiscretizationDataStatistics.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorExDiscretizationDataStatistics.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem});
            this.bindingNavigatorExDiscretizationDataStatistics.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigatorExDiscretizationDataStatistics.MoveFirstButton = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorExDiscretizationDataStatistics.MoveLastButton = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorExDiscretizationDataStatistics.MoveNextButton = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorExDiscretizationDataStatistics.MovePreviousButton = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorExDiscretizationDataStatistics.Name = "bindingNavigatorExDiscretizationDataStatistics";
            this.bindingNavigatorExDiscretizationDataStatistics.PositionTextBox = this.bindingNavigatorPositionItem;
            this.bindingNavigatorExDiscretizationDataStatistics.Size = new System.Drawing.Size(625, 25);
            this.bindingNavigatorExDiscretizationDataStatistics.Stretch = true;
            this.bindingNavigatorExDiscretizationDataStatistics.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bindingNavigatorExDiscretizationDataStatistics.TabIndex = 1;
            this.bindingNavigatorExDiscretizationDataStatistics.TabStop = false;
            this.bindingNavigatorExDiscretizationDataStatistics.Text = "bindingNavigatorEx1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.BeginGroup = true;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bindingNavigatorPositionItem.TextBoxWidth = 54;
            this.bindingNavigatorPositionItem.WatermarkColor = System.Drawing.SystemColors.GrayText;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Text = "of {0}";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.BeginGroup = true;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // FormDiscretizationDataStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 302);
            this.Controls.Add(this.bindingNavigatorExDiscretizationDataStatistics);
            this.Controls.Add(this.dataGridViewXDiscretizationDataStatistics);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormDiscretizationDataStatistics";
            this.Text = "Discretization Data Statistics";
            this.TitleText = "<h4><font color=\"#903C39\"><b>Discretization Data Statistics</b></font></h4>";
            this.Load += new System.EventHandler(this.FormDiscretizationDataStatistics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXDiscretizationDataStatistics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDiscretizationDataStatistics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorExDiscretizationDataStatistics)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewXDiscretizationDataStatistics;
        private System.Windows.Forms.BindingSource bindingSourceDiscretizationDataStatistics;
        private DevComponents.DotNetBar.Controls.BindingNavigatorEx bindingNavigatorExDiscretizationDataStatistics;
        private DevComponents.DotNetBar.LabelItem bindingNavigatorCountItem;
        private DevComponents.DotNetBar.ButtonItem bindingNavigatorMoveFirstItem;
        private DevComponents.DotNetBar.ButtonItem bindingNavigatorMovePreviousItem;
        private DevComponents.DotNetBar.TextBoxItem bindingNavigatorPositionItem;
        private DevComponents.DotNetBar.ButtonItem bindingNavigatorMoveNextItem;
        private DevComponents.DotNetBar.ButtonItem bindingNavigatorMoveLastItem;
    }
}