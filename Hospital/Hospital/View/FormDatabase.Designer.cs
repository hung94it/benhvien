namespace Hospital.View
{
    partial class FormDatabase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDatabase));
            this.textBoxServer = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelServer = new DevComponents.DotNetBar.LabelX();
            this.buttonSave = new DevComponents.DotNetBar.ButtonX();
            this.buttonClose = new DevComponents.DotNetBar.ButtonX();
            this.buttonCheck = new DevComponents.DotNetBar.ButtonX();
            this.comboBoxConnection = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.labelConnection = new DevComponents.DotNetBar.LabelX();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.labelPassword = new DevComponents.DotNetBar.LabelX();
            this.textBoxPassword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelUsername = new DevComponents.DotNetBar.LabelX();
            this.textBoxUsername = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelDatabase = new DevComponents.DotNetBar.LabelX();
            this.textBoxDatabase = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.superValidator1 = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.requiredFieldValidator1 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Your error message here.");
            this.requiredFieldValidator2 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Your error message here.");
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.highlighter1 = new DevComponents.DotNetBar.Validator.Highlighter();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxServer
            // 
            // 
            // 
            // 
            this.textBoxServer.Border.Class = "TextBoxBorder";
            this.textBoxServer.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxServer.Location = new System.Drawing.Point(119, 15);
            this.textBoxServer.Name = "textBoxServer";
            this.textBoxServer.Size = new System.Drawing.Size(299, 20);
            this.textBoxServer.TabIndex = 0;
            this.superValidator1.SetValidator1(this.textBoxServer, this.requiredFieldValidator1);
            // 
            // labelServer
            // 
            // 
            // 
            // 
            this.labelServer.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelServer.Location = new System.Drawing.Point(12, 12);
            this.labelServer.Name = "labelServer";
            this.labelServer.Size = new System.Drawing.Size(101, 23);
            this.labelServer.TabIndex = 1;
            this.labelServer.Text = "Máy chủ dữ liệu:";
            // 
            // buttonSave
            // 
            this.buttonSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonSave.Location = new System.Drawing.Point(262, 197);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Lưu";
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonClose.Location = new System.Drawing.Point(343, 197);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonClose.TabIndex = 4;
            this.buttonClose.Text = "Đóng";
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCheck
            // 
            this.buttonCheck.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonCheck.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonCheck.Location = new System.Drawing.Point(12, 197);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(75, 23);
            this.buttonCheck.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonCheck.TabIndex = 5;
            this.buttonCheck.Text = "Kiểm tra";
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // comboBoxConnection
            // 
            this.comboBoxConnection.DisplayMember = "Text";
            this.comboBoxConnection.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxConnection.FormattingEnabled = true;
            this.comboBoxConnection.ItemHeight = 14;
            this.comboBoxConnection.Items.AddRange(new object[] {
            this.comboItem1,
            this.comboItem2});
            this.comboBoxConnection.Location = new System.Drawing.Point(119, 73);
            this.comboBoxConnection.Name = "comboBoxConnection";
            this.comboBoxConnection.Size = new System.Drawing.Size(299, 20);
            this.comboBoxConnection.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBoxConnection.TabIndex = 2;
            this.comboBoxConnection.SelectedIndexChanged += new System.EventHandler(this.comboBoxConnection_SelectedIndexChanged);
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "Nội bộ";
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "Từ xa";
            // 
            // labelConnection
            // 
            // 
            // 
            // 
            this.labelConnection.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelConnection.Location = new System.Drawing.Point(12, 70);
            this.labelConnection.Name = "labelConnection";
            this.labelConnection.Size = new System.Drawing.Size(101, 23);
            this.labelConnection.TabIndex = 6;
            this.labelConnection.Text = "Kết nối:";
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.labelPassword);
            this.groupPanel1.Controls.Add(this.textBoxPassword);
            this.groupPanel1.Controls.Add(this.labelUsername);
            this.groupPanel1.Controls.Add(this.textBoxUsername);
            this.groupPanel1.Location = new System.Drawing.Point(119, 99);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(299, 92);
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
            this.groupPanel1.TabIndex = 7;
            this.groupPanel1.Text = "Tài khoản";
            // 
            // labelPassword
            // 
            this.labelPassword.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelPassword.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelPassword.Location = new System.Drawing.Point(3, 32);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(71, 23);
            this.labelPassword.TabIndex = 13;
            this.labelPassword.Text = "Mật khẩu:";
            // 
            // textBoxPassword
            // 
            // 
            // 
            // 
            this.textBoxPassword.Border.Class = "TextBoxBorder";
            this.textBoxPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxPassword.Location = new System.Drawing.Point(80, 35);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(182, 20);
            this.textBoxPassword.TabIndex = 1;
            // 
            // labelUsername
            // 
            this.labelUsername.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelUsername.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelUsername.Location = new System.Drawing.Point(3, 3);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(71, 23);
            this.labelUsername.TabIndex = 11;
            this.labelUsername.Text = "Tài khoản:";
            // 
            // textBoxUsername
            // 
            // 
            // 
            // 
            this.textBoxUsername.Border.Class = "TextBoxBorder";
            this.textBoxUsername.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxUsername.Location = new System.Drawing.Point(80, 6);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(182, 20);
            this.textBoxUsername.TabIndex = 0;
            // 
            // labelDatabase
            // 
            // 
            // 
            // 
            this.labelDatabase.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelDatabase.Location = new System.Drawing.Point(12, 41);
            this.labelDatabase.Name = "labelDatabase";
            this.labelDatabase.Size = new System.Drawing.Size(101, 23);
            this.labelDatabase.TabIndex = 9;
            this.labelDatabase.Text = "Cơ sở dữ liệu:";
            // 
            // textBoxDatabase
            // 
            // 
            // 
            // 
            this.textBoxDatabase.Border.Class = "TextBoxBorder";
            this.textBoxDatabase.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxDatabase.Location = new System.Drawing.Point(119, 44);
            this.textBoxDatabase.Name = "textBoxDatabase";
            this.textBoxDatabase.Size = new System.Drawing.Size(299, 20);
            this.textBoxDatabase.TabIndex = 1;
            this.superValidator1.SetValidator1(this.textBoxDatabase, this.requiredFieldValidator2);
            // 
            // superValidator1
            // 
            this.superValidator1.ContainerControl = this;
            this.superValidator1.ErrorProvider = this.errorProvider1;
            this.superValidator1.Highlighter = this.highlighter1;
            // 
            // requiredFieldValidator1
            // 
            this.requiredFieldValidator1.ErrorMessage = "Your error message here.";
            this.requiredFieldValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // requiredFieldValidator2
            // 
            this.requiredFieldValidator2.ErrorMessage = "Your error message here.";
            this.requiredFieldValidator2.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
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
            // FormDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 231);
            this.ControlBox = false;
            this.Controls.Add(this.labelDatabase);
            this.Controls.Add(this.textBoxDatabase);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.labelConnection);
            this.Controls.Add(this.comboBoxConnection);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelServer);
            this.Controls.Add(this.textBoxServer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDatabase";
            this.Text = "Tùy chỉnh";
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX textBoxServer;
        private DevComponents.DotNetBar.LabelX labelServer;
        private DevComponents.DotNetBar.ButtonX buttonSave;
        private DevComponents.DotNetBar.ButtonX buttonClose;
        private DevComponents.DotNetBar.ButtonX buttonCheck;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxConnection;
        private DevComponents.DotNetBar.LabelX labelConnection;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.LabelX labelDatabase;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxDatabase;
        private DevComponents.DotNetBar.LabelX labelPassword;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxPassword;
        private DevComponents.DotNetBar.LabelX labelUsername;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxUsername;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem2;
        private DevComponents.DotNetBar.Validator.SuperValidator superValidator1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter1;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator2;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator1;
    }
}