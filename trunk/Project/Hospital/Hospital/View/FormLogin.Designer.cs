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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.groupPanelLogin = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.buttonClose = new DevComponents.DotNetBar.ButtonX();
            this.buttonLogin = new DevComponents.DotNetBar.ButtonX();
            this.labelPassword = new DevComponents.DotNetBar.LabelX();
            this.textBoxPassword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelUsername = new DevComponents.DotNetBar.LabelX();
            this.textBoxUsername = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.reflectionLabelHospital = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.superValidator1 = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.requiredFieldValidator2 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Nhập password");
            this.requiredFieldValidator1 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Nhập tài khoản");
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.highlighter1 = new DevComponents.DotNetBar.Validator.Highlighter();
            this.groupPanelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupPanelLogin
            // 
            this.groupPanelLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupPanelLogin.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanelLogin.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanelLogin.Controls.Add(this.buttonClose);
            this.groupPanelLogin.Controls.Add(this.buttonLogin);
            this.groupPanelLogin.Controls.Add(this.labelPassword);
            this.groupPanelLogin.Controls.Add(this.textBoxPassword);
            this.groupPanelLogin.Controls.Add(this.labelUsername);
            this.groupPanelLogin.Controls.Add(this.textBoxUsername);
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
            // buttonClose
            // 
            this.buttonClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonClose.Location = new System.Drawing.Point(145, 89);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonClose.TabIndex = 5;
            this.buttonClose.Text = "Thoát";
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
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
            // textBoxPassword
            // 
            this.textBoxPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.textBoxPassword.Border.Class = "TextBoxBorder";
            this.textBoxPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxPassword.Location = new System.Drawing.Point(84, 48);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(194, 20);
            this.textBoxPassword.TabIndex = 2;
            this.superValidator1.SetValidator1(this.textBoxPassword, this.requiredFieldValidator2);
            this.textBoxPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPassword_KeyDown);
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
            // textBoxUsername
            // 
            this.textBoxUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.textBoxUsername.Border.Class = "TextBoxBorder";
            this.textBoxUsername.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxUsername.Location = new System.Drawing.Point(84, 21);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(194, 20);
            this.textBoxUsername.TabIndex = 0;
            this.superValidator1.SetValidator1(this.textBoxUsername, this.requiredFieldValidator1);
            // 
            // reflectionLabelHospital
            // 
            // 
            // 
            // 
            this.reflectionLabelHospital.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reflectionLabelHospital.Font = new System.Drawing.Font("Freestyle Script", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reflectionLabelHospital.Location = new System.Drawing.Point(45, 12);
            this.reflectionLabelHospital.Name = "reflectionLabelHospital";
            this.reflectionLabelHospital.Size = new System.Drawing.Size(248, 114);
            this.reflectionLabelHospital.TabIndex = 2;
            this.reflectionLabelHospital.Text = "     <font size=\"+20\">e<font color=\"#B02B2C\"><i>Hospital</i></font></font>";
            // 
            // superValidator1
            // 
            this.superValidator1.ContainerControl = this;
            this.superValidator1.ErrorProvider = this.errorProvider1;
            this.superValidator1.Highlighter = this.highlighter1;
            // 
            // requiredFieldValidator2
            // 
            this.requiredFieldValidator2.ErrorMessage = "Nhập password";
            this.requiredFieldValidator2.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // requiredFieldValidator1
            // 
            this.requiredFieldValidator1.ErrorMessage = "Nhập tài khoản";
            this.requiredFieldValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
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
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 312);
            this.Controls.Add(this.reflectionLabelHospital);
            this.Controls.Add(this.groupPanelLogin);
            this.MinimumSize = new System.Drawing.Size(350, 350);
            this.Name = "FormLogin";
            this.Text = "eHospital";
            this.groupPanelLogin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanelLogin;
        private DevComponents.DotNetBar.LabelX labelUsername;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxUsername;
        private DevComponents.DotNetBar.LabelX labelPassword;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxPassword;
        private DevComponents.DotNetBar.ButtonX buttonLogin;
        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabelHospital;
        private DevComponents.DotNetBar.Validator.SuperValidator superValidator1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter1;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator2;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator1;
        private DevComponents.DotNetBar.ButtonX buttonClose;
    }
}