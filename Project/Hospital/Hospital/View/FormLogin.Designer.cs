namespace Hospital.View
{
    partial class FormLogin
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
            this.groupPanelLogin = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.buttonLogin = new DevComponents.DotNetBar.ButtonX();
            this.labelPassword = new DevComponents.DotNetBar.LabelX();
            this.textBoxX2 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelUsername = new DevComponents.DotNetBar.LabelX();
            this.textBoxX1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.reflectionLabel1 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.groupPanelLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupPanelLogin
            // 
            this.groupPanelLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupPanelLogin.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanelLogin.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanelLogin.Controls.Add(this.buttonLogin);
            this.groupPanelLogin.Controls.Add(this.labelPassword);
            this.groupPanelLogin.Controls.Add(this.textBoxX2);
            this.groupPanelLogin.Controls.Add(this.labelUsername);
            this.groupPanelLogin.Controls.Add(this.textBoxX1);
            this.groupPanelLogin.Location = new System.Drawing.Point(12, 156);
            this.groupPanelLogin.Name = "groupPanelLogin";
            this.groupPanelLogin.Size = new System.Drawing.Size(310, 136);
            // 
            // 
            // 
            this.groupPanelLogin.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanelLogin.Style.BackColorGradientAngle = 90;
            this.groupPanelLogin.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanelLogin.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelLogin.Style.BorderBottomWidth = 1;
            this.groupPanelLogin.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanelLogin.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelLogin.Style.BorderLeftWidth = 1;
            this.groupPanelLogin.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelLogin.Style.BorderRightWidth = 1;
            this.groupPanelLogin.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelLogin.Style.BorderTopWidth = 1;
            this.groupPanelLogin.Style.CornerDiameter = 4;
            this.groupPanelLogin.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanelLogin.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanelLogin.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanelLogin.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanelLogin.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanelLogin.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanelLogin.TabIndex = 1;
            this.groupPanelLogin.Text = "Đăng nhập";
            // 
            // buttonLogin
            // 
            this.buttonLogin.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLogin.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonLogin.Location = new System.Drawing.Point(226, 89);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 23);
            this.buttonLogin.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "Đăng nhập";
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelPassword.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelPassword.Location = new System.Drawing.Point(3, 45);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(75, 23);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Mật khẩu:";
            // 
            // textBoxX2
            // 
            this.textBoxX2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.textBoxX2.Border.Class = "TextBoxBorder";
            this.textBoxX2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX2.Location = new System.Drawing.Point(84, 48);
            this.textBoxX2.Name = "textBoxX2";
            this.textBoxX2.Size = new System.Drawing.Size(217, 20);
            this.textBoxX2.TabIndex = 2;
            // 
            // labelUsername
            // 
            this.labelUsername.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelUsername.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelUsername.Location = new System.Drawing.Point(3, 18);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(75, 23);
            this.labelUsername.TabIndex = 1;
            this.labelUsername.Text = "Tài khoản:";
            // 
            // textBoxX1
            // 
            this.textBoxX1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.textBoxX1.Border.Class = "TextBoxBorder";
            this.textBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX1.Location = new System.Drawing.Point(84, 21);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.Size = new System.Drawing.Size(217, 20);
            this.textBoxX1.TabIndex = 0;
            // 
            // reflectionLabel1
            // 
            // 
            // 
            // 
            this.reflectionLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reflectionLabel1.Font = new System.Drawing.Font("Freestyle Script", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reflectionLabel1.Location = new System.Drawing.Point(45, 12);
            this.reflectionLabel1.Name = "reflectionLabel1";
            this.reflectionLabel1.Size = new System.Drawing.Size(248, 114);
            this.reflectionLabel1.TabIndex = 2;
            this.reflectionLabel1.Text = "     <font size=\"+20\">e<font color=\"#B02B2C\"><i>Hospital</i></font></font>";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 312);
            this.Controls.Add(this.reflectionLabel1);
            this.Controls.Add(this.groupPanelLogin);
            this.MinimumSize = new System.Drawing.Size(350, 350);
            this.Name = "FormLogin";
            this.Text = "eHospital";
            this.groupPanelLogin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanelLogin;
        private DevComponents.DotNetBar.LabelX labelUsername;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX1;
        private DevComponents.DotNetBar.LabelX labelPassword;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX2;
        private DevComponents.DotNetBar.ButtonX buttonLogin;
        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel1;
    }
}