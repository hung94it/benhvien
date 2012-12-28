namespace DiabetesDido.UI
{
    partial class FormMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.styleManagerMain = new DevComponents.DotNetBar.StyleManager(this.components);
            this.superTabControlMain = new DevComponents.DotNetBar.SuperTabControl();
            this.superTabControlPanelCreateModel = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.dataGridViewX2 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.dataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX3 = new DevComponents.DotNetBar.ButtonX();
            this.buttonXCreateModel = new DevComponents.DotNetBar.ButtonX();
            this.checkBoxXID3 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.checkBoxXC45 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.checkBoxXNaiveBayes = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.superTabItemCreateModel = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanelPreprocessingData = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.dataGridViewX3 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.buttonXCleaningData = new DevComponents.DotNetBar.ButtonX();
            this.superTabItemPreprocessingData = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanelDiagnosis = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.dataGridViewX4 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.superTabItemDiagnosis = new DevComponents.DotNetBar.SuperTabItem();
            ((System.ComponentModel.ISupportInitialize)(this.superTabControlMain)).BeginInit();
            this.superTabControlMain.SuspendLayout();
            this.superTabControlPanelCreateModel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
            this.groupPanel1.SuspendLayout();
            this.superTabControlPanelPreprocessingData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX3)).BeginInit();
            this.superTabControlPanelDiagnosis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX4)).BeginInit();
            this.SuspendLayout();
            // 
            // styleManagerMain
            // 
            this.styleManagerMain.ManagerStyle = DevComponents.DotNetBar.eStyle.Metro;
            this.styleManagerMain.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254))))), System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(143))))));
            // 
            // superTabControlMain
            // 
            this.superTabControlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.superTabControlMain.ControlBox.CloseBox.Name = "";
            // 
            // 
            // 
            this.superTabControlMain.ControlBox.MenuBox.Name = "";
            this.superTabControlMain.ControlBox.Name = "";
            this.superTabControlMain.ControlBox.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.superTabControlMain.ControlBox.MenuBox,
            this.superTabControlMain.ControlBox.CloseBox});
            this.superTabControlMain.Controls.Add(this.superTabControlPanelCreateModel);
            this.superTabControlMain.Controls.Add(this.superTabControlPanelPreprocessingData);
            this.superTabControlMain.Controls.Add(this.superTabControlPanelDiagnosis);
            this.superTabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlMain.ForeColor = System.Drawing.Color.Black;
            this.superTabControlMain.Location = new System.Drawing.Point(0, 0);
            this.superTabControlMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.superTabControlMain.Name = "superTabControlMain";
            this.superTabControlMain.ReorderTabsEnabled = false;
            this.superTabControlMain.SelectedTabFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.superTabControlMain.SelectedTabIndex = 1;
            this.superTabControlMain.Size = new System.Drawing.Size(884, 561);
            this.superTabControlMain.TabFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.superTabControlMain.TabIndex = 1;
            this.superTabControlMain.TabLayoutType = DevComponents.DotNetBar.eSuperTabLayoutType.SingleLineFit;
            this.superTabControlMain.Tabs.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.superTabItemPreprocessingData,
            this.superTabItemCreateModel,
            this.superTabItemDiagnosis});
            this.superTabControlMain.TabStyle = DevComponents.DotNetBar.eSuperTabStyle.Office2010BackstageBlue;
            this.superTabControlMain.Text = "superTabControl1";
            // 
            // superTabControlPanelCreateModel
            // 
            this.superTabControlPanelCreateModel.Controls.Add(this.dataGridViewX2);
            this.superTabControlPanelCreateModel.Controls.Add(this.dataGridViewX1);
            this.superTabControlPanelCreateModel.Controls.Add(this.groupPanel1);
            this.superTabControlPanelCreateModel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanelCreateModel.Location = new System.Drawing.Point(0, 29);
            this.superTabControlPanelCreateModel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.superTabControlPanelCreateModel.Name = "superTabControlPanelCreateModel";
            this.superTabControlPanelCreateModel.Size = new System.Drawing.Size(884, 532);
            this.superTabControlPanelCreateModel.TabIndex = 1;
            this.superTabControlPanelCreateModel.TabItem = this.superTabItemCreateModel;
            // 
            // dataGridViewX2
            // 
            this.dataGridViewX2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewX2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX2.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewX2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.dataGridViewX2.Location = new System.Drawing.Point(3, 391);
            this.dataGridViewX2.Name = "dataGridViewX2";
            this.dataGridViewX2.Size = new System.Drawing.Size(878, 138);
            this.dataGridViewX2.TabIndex = 4;
            // 
            // dataGridViewX1
            // 
            this.dataGridViewX1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewX1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.dataGridViewX1.Location = new System.Drawing.Point(239, 3);
            this.dataGridViewX1.Name = "dataGridViewX1";
            this.dataGridViewX1.Size = new System.Drawing.Size(642, 382);
            this.dataGridViewX1.TabIndex = 3;
            // 
            // groupPanel1
            // 
            this.groupPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.buttonX1);
            this.groupPanel1.Controls.Add(this.buttonX3);
            this.groupPanel1.Controls.Add(this.buttonXCreateModel);
            this.groupPanel1.Controls.Add(this.checkBoxXID3);
            this.groupPanel1.Controls.Add(this.checkBoxXC45);
            this.groupPanel1.Controls.Add(this.checkBoxXNaiveBayes);
            this.groupPanel1.Location = new System.Drawing.Point(3, 3);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(230, 235);
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
            this.groupPanel1.TabIndex = 2;
            this.groupPanel1.Text = "Mô hình";
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(129, 76);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(92, 23);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 5;
            this.buttonX1.Text = "Kiểm tra";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // buttonX3
            // 
            this.buttonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX3.Location = new System.Drawing.Point(129, 47);
            this.buttonX3.Name = "buttonX3";
            this.buttonX3.Size = new System.Drawing.Size(92, 23);
            this.buttonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX3.TabIndex = 4;
            this.buttonX3.Text = "Xem ";
            this.buttonX3.Click += new System.EventHandler(this.buttonX3_Click);
            // 
            // buttonXCreateModel
            // 
            this.buttonXCreateModel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonXCreateModel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonXCreateModel.Location = new System.Drawing.Point(129, 18);
            this.buttonXCreateModel.Name = "buttonXCreateModel";
            this.buttonXCreateModel.Size = new System.Drawing.Size(92, 23);
            this.buttonXCreateModel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonXCreateModel.TabIndex = 3;
            this.buttonXCreateModel.Text = "Tạo";
            this.buttonXCreateModel.Click += new System.EventHandler(this.buttonXCreateModel_Click);
            // 
            // checkBoxXID3
            // 
            // 
            // 
            // 
            this.checkBoxXID3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkBoxXID3.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.checkBoxXID3.Location = new System.Drawing.Point(6, 47);
            this.checkBoxXID3.Name = "checkBoxXID3";
            this.checkBoxXID3.Size = new System.Drawing.Size(100, 23);
            this.checkBoxXID3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.checkBoxXID3.TabIndex = 2;
            this.checkBoxXID3.Tag = "ID3";
            this.checkBoxXID3.Text = "ID3";
            this.checkBoxXID3.CheckedChanged += new System.EventHandler(this.checkBoxXTabCreateModel_CheckedChanged);
            // 
            // checkBoxXC45
            // 
            // 
            // 
            // 
            this.checkBoxXC45.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkBoxXC45.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.checkBoxXC45.Location = new System.Drawing.Point(6, 76);
            this.checkBoxXC45.Name = "checkBoxXC45";
            this.checkBoxXC45.Size = new System.Drawing.Size(100, 23);
            this.checkBoxXC45.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.checkBoxXC45.TabIndex = 1;
            this.checkBoxXC45.Tag = "C45";
            this.checkBoxXC45.Text = "C4.5";
            this.checkBoxXC45.CheckedChanged += new System.EventHandler(this.checkBoxXTabCreateModel_CheckedChanged);
            // 
            // checkBoxXNaiveBayes
            // 
            // 
            // 
            // 
            this.checkBoxXNaiveBayes.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkBoxXNaiveBayes.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.checkBoxXNaiveBayes.Checked = true;
            this.checkBoxXNaiveBayes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxXNaiveBayes.CheckValue = "Y";
            this.checkBoxXNaiveBayes.Location = new System.Drawing.Point(6, 18);
            this.checkBoxXNaiveBayes.Name = "checkBoxXNaiveBayes";
            this.checkBoxXNaiveBayes.Size = new System.Drawing.Size(100, 23);
            this.checkBoxXNaiveBayes.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.checkBoxXNaiveBayes.TabIndex = 0;
            this.checkBoxXNaiveBayes.Tag = "NaiveBayes";
            this.checkBoxXNaiveBayes.Text = "Naive Bayes";
            this.checkBoxXNaiveBayes.CheckedChanged += new System.EventHandler(this.checkBoxXTabCreateModel_CheckedChanged);
            // 
            // superTabItemCreateModel
            // 
            this.superTabItemCreateModel.AttachedControl = this.superTabControlPanelCreateModel;
            this.superTabItemCreateModel.GlobalItem = false;
            this.superTabItemCreateModel.Name = "superTabItemCreateModel";
            this.superTabItemCreateModel.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.superTabItemCreateModel.TabFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.superTabItemCreateModel.Text = "Xây dựng mô hình";
            // 
            // superTabControlPanelPreprocessingData
            // 
            this.superTabControlPanelPreprocessingData.Controls.Add(this.dataGridViewX3);
            this.superTabControlPanelPreprocessingData.Controls.Add(this.buttonX2);
            this.superTabControlPanelPreprocessingData.Controls.Add(this.buttonXCleaningData);
            this.superTabControlPanelPreprocessingData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanelPreprocessingData.Location = new System.Drawing.Point(0, 29);
            this.superTabControlPanelPreprocessingData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.superTabControlPanelPreprocessingData.Name = "superTabControlPanelPreprocessingData";
            this.superTabControlPanelPreprocessingData.Size = new System.Drawing.Size(884, 532);
            this.superTabControlPanelPreprocessingData.TabIndex = 0;
            this.superTabControlPanelPreprocessingData.TabItem = this.superTabItemPreprocessingData;
            // 
            // dataGridViewX3
            // 
            this.dataGridViewX3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX3.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewX3.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.dataGridViewX3.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewX3.Name = "dataGridViewX3";
            this.dataGridViewX3.Size = new System.Drawing.Size(757, 526);
            this.dataGridViewX3.TabIndex = 4;
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.Location = new System.Drawing.Point(766, 32);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(115, 23);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX2.TabIndex = 2;
            this.buttonX2.Text = "Rời rạc dữ liệu";
            // 
            // buttonXCleaningData
            // 
            this.buttonXCleaningData.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonXCleaningData.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonXCleaningData.Location = new System.Drawing.Point(766, 3);
            this.buttonXCleaningData.Name = "buttonXCleaningData";
            this.buttonXCleaningData.Size = new System.Drawing.Size(115, 23);
            this.buttonXCleaningData.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonXCleaningData.TabIndex = 1;
            this.buttonXCleaningData.Text = "Làm sạch dữ liệu";
            // 
            // superTabItemPreprocessingData
            // 
            this.superTabItemPreprocessingData.AttachedControl = this.superTabControlPanelPreprocessingData;
            this.superTabItemPreprocessingData.GlobalItem = false;
            this.superTabItemPreprocessingData.Name = "superTabItemPreprocessingData";
            this.superTabItemPreprocessingData.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.superTabItemPreprocessingData.TabFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.superTabItemPreprocessingData.Text = "Tiền xử lý dữ liệu";
            // 
            // superTabControlPanelDiagnosis
            // 
            this.superTabControlPanelDiagnosis.Controls.Add(this.dataGridViewX4);
            this.superTabControlPanelDiagnosis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanelDiagnosis.Location = new System.Drawing.Point(0, 0);
            this.superTabControlPanelDiagnosis.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.superTabControlPanelDiagnosis.Name = "superTabControlPanelDiagnosis";
            this.superTabControlPanelDiagnosis.Size = new System.Drawing.Size(884, 561);
            this.superTabControlPanelDiagnosis.TabIndex = 2;
            this.superTabControlPanelDiagnosis.TabItem = this.superTabItemDiagnosis;
            // 
            // dataGridViewX4
            // 
            this.dataGridViewX4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX4.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewX4.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.dataGridViewX4.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewX4.Name = "dataGridViewX4";
            this.dataGridViewX4.Size = new System.Drawing.Size(797, 526);
            this.dataGridViewX4.TabIndex = 4;
            // 
            // superTabItemDiagnosis
            // 
            this.superTabItemDiagnosis.AttachedControl = this.superTabControlPanelDiagnosis;
            this.superTabItemDiagnosis.GlobalItem = false;
            this.superTabItemDiagnosis.Name = "superTabItemDiagnosis";
            this.superTabItemDiagnosis.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.superTabItemDiagnosis.TabFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.superTabItemDiagnosis.Text = "Chuẩn đoán";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.superTabControlMain);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormMain";
            this.Text = "Diabetes Diagnosis";
            this.TitleText = "<h4><font color=\"#903C39\"><b>Diabetes Diagnosis</b></font></h4>\r\n";
            ((System.ComponentModel.ISupportInitialize)(this.superTabControlMain)).EndInit();
            this.superTabControlMain.ResumeLayout(false);
            this.superTabControlPanelCreateModel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            this.superTabControlPanelPreprocessingData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX3)).EndInit();
            this.superTabControlPanelDiagnosis.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.StyleManager styleManagerMain;
        private DevComponents.DotNetBar.SuperTabControl superTabControlMain;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanelDiagnosis;
        private DevComponents.DotNetBar.SuperTabItem superTabItemDiagnosis;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanelPreprocessingData;
        private DevComponents.DotNetBar.SuperTabItem superTabItemPreprocessingData;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanelCreateModel;
        private DevComponents.DotNetBar.SuperTabItem superTabItemCreateModel;
        private DevComponents.DotNetBar.ButtonX buttonXCleaningData;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX4;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX3;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX2;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.ButtonX buttonX3;
        private DevComponents.DotNetBar.ButtonX buttonXCreateModel;
        private DevComponents.DotNetBar.Controls.CheckBoxX checkBoxXID3;
        private DevComponents.DotNetBar.Controls.CheckBoxX checkBoxXC45;
        private DevComponents.DotNetBar.Controls.CheckBoxX checkBoxXNaiveBayes;
    }
}