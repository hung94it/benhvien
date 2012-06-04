namespace Hospital.View
{
    partial class FormAbout
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
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.reflectionLabelHospital = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.SuspendLayout();
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(151, 285);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(75, 23);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 0;
            this.buttonX1.Text = "Đóng";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // reflectionLabelHospital
            // 
            // 
            // 
            // 
            this.reflectionLabelHospital.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reflectionLabelHospital.Font = new System.Drawing.Font("Freestyle Script", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reflectionLabelHospital.Location = new System.Drawing.Point(72, 12);
            this.reflectionLabelHospital.Name = "reflectionLabelHospital";
            this.reflectionLabelHospital.Size = new System.Drawing.Size(248, 176);
            this.reflectionLabelHospital.TabIndex = 3;
            this.reflectionLabelHospital.Text = "     <font size=\"+20\">e<font color=\"#B02B2C\"><i>Hospital</i></font></font>";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(101, 156);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(166, 123);
            this.labelX1.TabIndex = 4;
            this.labelX1.Text = "@2012\r\n\r\nĐại học công nghệ thông tin\r\nKhoa hệ thống thông tin\r\n\r\nUng Quốc Bình \r\n" +
                "binhuq@gmail.com\r\nNguyễn Văn Lâm\r\nkimkaprwan@gmail.com\r\n\r\n";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 340);
            this.ControlBox = false;
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.reflectionLabelHospital);
            this.Controls.Add(this.buttonX1);
            this.Name = "FormAbout";
            this.Text = "Thông tin chương trình";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabelHospital;
        private DevComponents.DotNetBar.LabelX labelX1;
    }
}