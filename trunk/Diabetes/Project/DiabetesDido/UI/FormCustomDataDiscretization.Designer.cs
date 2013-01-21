namespace DiabetesDido.UI
{
    partial class FormCustomDataDiscretization
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
            this.labelXInterval = new DevComponents.DotNetBar.LabelX();
            this.comboBoxExInterval = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelXIntervalValue = new DevComponents.DotNetBar.LabelX();
            this.doubleInputIntervalValue = new DevComponents.Editors.DoubleInput();
            this.buttonXDataDiscretization = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.buttonXInputIntervalValue = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.doubleInputIntervalValue)).BeginInit();
            this.groupPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelXInterval
            // 
            this.labelXInterval.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelXInterval.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelXInterval.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelXInterval.ForeColor = System.Drawing.Color.Black;
            this.labelXInterval.Location = new System.Drawing.Point(28, 3);
            this.labelXInterval.Name = "labelXInterval";
            this.labelXInterval.Size = new System.Drawing.Size(119, 23);
            this.labelXInterval.TabIndex = 0;
            this.labelXInterval.Text = "Tên khoảng rời rạc:";
            // 
            // comboBoxExInterval
            // 
            this.comboBoxExInterval.DisplayMember = "Text";
            this.comboBoxExInterval.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxExInterval.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxExInterval.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.comboBoxExInterval.ForeColor = System.Drawing.Color.Black;
            this.comboBoxExInterval.FormattingEnabled = true;
            this.comboBoxExInterval.ItemHeight = 19;
            this.comboBoxExInterval.Location = new System.Drawing.Point(153, 3);
            this.comboBoxExInterval.Name = "comboBoxExInterval";
            this.comboBoxExInterval.Size = new System.Drawing.Size(121, 25);
            this.comboBoxExInterval.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBoxExInterval.TabIndex = 1;
            this.comboBoxExInterval.SelectedIndexChanged += new System.EventHandler(this.comboBoxExInterval_SelectedIndexChanged);
            // 
            // labelXIntervalValue
            // 
            this.labelXIntervalValue.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelXIntervalValue.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelXIntervalValue.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelXIntervalValue.ForeColor = System.Drawing.Color.Black;
            this.labelXIntervalValue.Location = new System.Drawing.Point(28, 44);
            this.labelXIntervalValue.Name = "labelXIntervalValue";
            this.labelXIntervalValue.Size = new System.Drawing.Size(119, 23);
            this.labelXIntervalValue.TabIndex = 0;
            this.labelXIntervalValue.Text = "Khoảng rời rạc:";
            // 
            // doubleInputIntervalValue
            // 
            this.doubleInputIntervalValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            // 
            // 
            // 
            this.doubleInputIntervalValue.BackgroundStyle.Class = "DateTimeInputBackground";
            this.doubleInputIntervalValue.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.doubleInputIntervalValue.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.doubleInputIntervalValue.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.doubleInputIntervalValue.ForeColor = System.Drawing.Color.Black;
            this.doubleInputIntervalValue.Increment = 1D;
            this.doubleInputIntervalValue.Location = new System.Drawing.Point(153, 44);
            this.doubleInputIntervalValue.MinValue = 0D;
            this.doubleInputIntervalValue.Name = "doubleInputIntervalValue";
            this.doubleInputIntervalValue.ShowUpDown = true;
            this.doubleInputIntervalValue.Size = new System.Drawing.Size(121, 25);
            this.doubleInputIntervalValue.TabIndex = 2;
            // 
            // buttonXDataDiscretization
            // 
            this.buttonXDataDiscretization.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonXDataDiscretization.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonXDataDiscretization.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.buttonXDataDiscretization.Location = new System.Drawing.Point(194, 76);
            this.buttonXDataDiscretization.Name = "buttonXDataDiscretization";
            this.buttonXDataDiscretization.Size = new System.Drawing.Size(80, 23);
            this.buttonXDataDiscretization.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonXDataDiscretization.TabIndex = 3;
            this.buttonXDataDiscretization.Text = "Rời rạc";
            this.buttonXDataDiscretization.Click += new System.EventHandler(this.buttonXDataDiscretization_Click);
            // 
            // groupPanel
            // 
            this.groupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.groupPanel.CanvasColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.groupPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel.Controls.Add(this.labelXInterval);
            this.groupPanel.Controls.Add(this.buttonXInputIntervalValue);
            this.groupPanel.Controls.Add(this.buttonXDataDiscretization);
            this.groupPanel.Controls.Add(this.labelXIntervalValue);
            this.groupPanel.Controls.Add(this.doubleInputIntervalValue);
            this.groupPanel.Controls.Add(this.comboBoxExInterval);
            this.groupPanel.Location = new System.Drawing.Point(13, 2);
            this.groupPanel.Name = "groupPanel";
            this.groupPanel.Size = new System.Drawing.Size(307, 125);
            // 
            // 
            // 
            this.groupPanel.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel.Style.BackColorGradientAngle = 90;
            this.groupPanel.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel.Style.BorderBottomWidth = 1;
            this.groupPanel.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel.Style.BorderLeftWidth = 1;
            this.groupPanel.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel.Style.BorderRightWidth = 1;
            this.groupPanel.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel.Style.BorderTopWidth = 1;
            this.groupPanel.Style.CornerDiameter = 4;
            this.groupPanel.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel.TabIndex = 4;
            this.groupPanel.Text = "Tên cột";
            // 
            // buttonXInputIntervalValue
            // 
            this.buttonXInputIntervalValue.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonXInputIntervalValue.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonXInputIntervalValue.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.buttonXInputIntervalValue.Location = new System.Drawing.Point(28, 76);
            this.buttonXInputIntervalValue.Name = "buttonXInputIntervalValue";
            this.buttonXInputIntervalValue.Size = new System.Drawing.Size(80, 23);
            this.buttonXInputIntervalValue.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonXInputIntervalValue.TabIndex = 3;
            this.buttonXInputIntervalValue.Text = "Nhập giá trị";
            this.buttonXInputIntervalValue.Click += new System.EventHandler(this.buttonXInputIntervalValue_Click);
            // 
            // FormCustomDataDiscretization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 131);
            this.Controls.Add(this.groupPanel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormCustomDataDiscretization";
            this.Text = "MetroForm";
            this.TitleText = "<h4><font color=\"#903C39\"><b>Custom Data Discretization</b></font></h4>\r\n";
            this.Load += new System.EventHandler(this.FormCustomDataDiscretization_Load);
            ((System.ComponentModel.ISupportInitialize)(this.doubleInputIntervalValue)).EndInit();
            this.groupPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelXInterval;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxExInterval;
        private DevComponents.DotNetBar.LabelX labelXIntervalValue;
        private DevComponents.Editors.DoubleInput doubleInputIntervalValue;
        private DevComponents.DotNetBar.ButtonX buttonXDataDiscretization;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel;
        private DevComponents.DotNetBar.ButtonX buttonXInputIntervalValue;
    }
}