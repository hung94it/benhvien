namespace DiabetesDido
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label iDKhamBenhLabel;
            System.Windows.Forms.Label maBNLabel;
            System.Windows.Forms.Label hoTenLabel;
            System.Windows.Forms.Label namSinhLabel;
            System.Windows.Forms.Label thonLabel;
            System.Windows.Forms.Label tenXaLabel;
            System.Windows.Forms.Label tenQuanLabel;
            System.Windows.Forms.Label tenThiTranLabel;
            System.Windows.Forms.Label tenNgheNghiepLabel;
            System.Windows.Forms.Label ngayKhamLabel;
            System.Windows.Forms.Label tenPhongKhamLabel;
            System.Windows.Forms.Label chuanDoanLabel;
            System.Windows.Forms.Label tieuDuongLabel;
            this.diabetesDataSet = new DiabetesDido.DiabetesDataSet();
            this.benhNhanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.benhNhanTableAdapter = new DiabetesDido.DiabetesDataSetTableAdapters.BenhNhanTableAdapter();
            this.tableAdapterManager = new DiabetesDido.DiabetesDataSetTableAdapters.TableAdapterManager();
            this.benhNhanBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.benhNhanBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iDKhamBenhTextBox = new System.Windows.Forms.TextBox();
            this.maBNTextBox = new System.Windows.Forms.TextBox();
            this.hoTenTextBox = new System.Windows.Forms.TextBox();
            this.namSinhTextBox = new System.Windows.Forms.TextBox();
            this.thonTextBox = new System.Windows.Forms.TextBox();
            this.tenXaTextBox = new System.Windows.Forms.TextBox();
            this.tenQuanTextBox = new System.Windows.Forms.TextBox();
            this.tenThiTranTextBox = new System.Windows.Forms.TextBox();
            this.tenNgheNghiepTextBox = new System.Windows.Forms.TextBox();
            this.ngayKhamDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tenPhongKhamTextBox = new System.Windows.Forms.TextBox();
            this.chuanDoanTextBox = new System.Windows.Forms.TextBox();
            this.tieuDuongCheckBox = new System.Windows.Forms.CheckBox();
            this.benhNhanDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            iDKhamBenhLabel = new System.Windows.Forms.Label();
            maBNLabel = new System.Windows.Forms.Label();
            hoTenLabel = new System.Windows.Forms.Label();
            namSinhLabel = new System.Windows.Forms.Label();
            thonLabel = new System.Windows.Forms.Label();
            tenXaLabel = new System.Windows.Forms.Label();
            tenQuanLabel = new System.Windows.Forms.Label();
            tenThiTranLabel = new System.Windows.Forms.Label();
            tenNgheNghiepLabel = new System.Windows.Forms.Label();
            ngayKhamLabel = new System.Windows.Forms.Label();
            tenPhongKhamLabel = new System.Windows.Forms.Label();
            chuanDoanLabel = new System.Windows.Forms.Label();
            tieuDuongLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.diabetesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.benhNhanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.benhNhanBindingNavigator)).BeginInit();
            this.benhNhanBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.benhNhanDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // diabetesDataSet
            // 
            this.diabetesDataSet.DataSetName = "DiabetesDataSet";
            this.diabetesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // benhNhanBindingSource
            // 
            this.benhNhanBindingSource.DataMember = "BenhNhan";
            this.benhNhanBindingSource.DataSource = this.diabetesDataSet;
            // 
            // benhNhanTableAdapter
            // 
            this.benhNhanTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BenhNhanTableAdapter = this.benhNhanTableAdapter;
            this.tableAdapterManager.UpdateOrder = DiabetesDido.DiabetesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.XetNghiemTableAdapter = null;
            // 
            // benhNhanBindingNavigator
            // 
            this.benhNhanBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.benhNhanBindingNavigator.BindingSource = this.benhNhanBindingSource;
            this.benhNhanBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.benhNhanBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.benhNhanBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.benhNhanBindingNavigatorSaveItem});
            this.benhNhanBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.benhNhanBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.benhNhanBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.benhNhanBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.benhNhanBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.benhNhanBindingNavigator.Name = "benhNhanBindingNavigator";
            this.benhNhanBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.benhNhanBindingNavigator.Size = new System.Drawing.Size(890, 25);
            this.benhNhanBindingNavigator.TabIndex = 0;
            this.benhNhanBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // benhNhanBindingNavigatorSaveItem
            // 
            this.benhNhanBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.benhNhanBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("benhNhanBindingNavigatorSaveItem.Image")));
            this.benhNhanBindingNavigatorSaveItem.Name = "benhNhanBindingNavigatorSaveItem";
            this.benhNhanBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.benhNhanBindingNavigatorSaveItem.Text = "Save Data";
            this.benhNhanBindingNavigatorSaveItem.Click += new System.EventHandler(this.benhNhanBindingNavigatorSaveItem_Click);
            // 
            // iDKhamBenhLabel
            // 
            iDKhamBenhLabel.AutoSize = true;
            iDKhamBenhLabel.Location = new System.Drawing.Point(326, 38);
            iDKhamBenhLabel.Name = "iDKhamBenhLabel";
            iDKhamBenhLabel.Size = new System.Drawing.Size(76, 13);
            iDKhamBenhLabel.TabIndex = 1;
            iDKhamBenhLabel.Text = "IDKham Benh:";
            // 
            // iDKhamBenhTextBox
            // 
            this.iDKhamBenhTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.benhNhanBindingSource, "IDKhamBenh", true));
            this.iDKhamBenhTextBox.Location = new System.Drawing.Point(427, 35);
            this.iDKhamBenhTextBox.Name = "iDKhamBenhTextBox";
            this.iDKhamBenhTextBox.Size = new System.Drawing.Size(200, 20);
            this.iDKhamBenhTextBox.TabIndex = 2;
            // 
            // maBNLabel
            // 
            maBNLabel.AutoSize = true;
            maBNLabel.Location = new System.Drawing.Point(326, 64);
            maBNLabel.Name = "maBNLabel";
            maBNLabel.Size = new System.Drawing.Size(43, 13);
            maBNLabel.TabIndex = 3;
            maBNLabel.Text = "Ma BN:";
            // 
            // maBNTextBox
            // 
            this.maBNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.benhNhanBindingSource, "MaBN", true));
            this.maBNTextBox.Location = new System.Drawing.Point(427, 61);
            this.maBNTextBox.Name = "maBNTextBox";
            this.maBNTextBox.Size = new System.Drawing.Size(200, 20);
            this.maBNTextBox.TabIndex = 4;
            // 
            // hoTenLabel
            // 
            hoTenLabel.AutoSize = true;
            hoTenLabel.Location = new System.Drawing.Point(326, 90);
            hoTenLabel.Name = "hoTenLabel";
            hoTenLabel.Size = new System.Drawing.Size(46, 13);
            hoTenLabel.TabIndex = 5;
            hoTenLabel.Text = "Ho Ten:";
            // 
            // hoTenTextBox
            // 
            this.hoTenTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.benhNhanBindingSource, "HoTen", true));
            this.hoTenTextBox.Location = new System.Drawing.Point(427, 87);
            this.hoTenTextBox.Name = "hoTenTextBox";
            this.hoTenTextBox.Size = new System.Drawing.Size(200, 20);
            this.hoTenTextBox.TabIndex = 6;
            // 
            // namSinhLabel
            // 
            namSinhLabel.AutoSize = true;
            namSinhLabel.Location = new System.Drawing.Point(326, 116);
            namSinhLabel.Name = "namSinhLabel";
            namSinhLabel.Size = new System.Drawing.Size(56, 13);
            namSinhLabel.TabIndex = 7;
            namSinhLabel.Text = "Nam Sinh:";
            // 
            // namSinhTextBox
            // 
            this.namSinhTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.benhNhanBindingSource, "NamSinh", true));
            this.namSinhTextBox.Location = new System.Drawing.Point(427, 113);
            this.namSinhTextBox.Name = "namSinhTextBox";
            this.namSinhTextBox.Size = new System.Drawing.Size(200, 20);
            this.namSinhTextBox.TabIndex = 8;
            // 
            // thonLabel
            // 
            thonLabel.AutoSize = true;
            thonLabel.Location = new System.Drawing.Point(326, 142);
            thonLabel.Name = "thonLabel";
            thonLabel.Size = new System.Drawing.Size(35, 13);
            thonLabel.TabIndex = 9;
            thonLabel.Text = "Thon:";
            // 
            // thonTextBox
            // 
            this.thonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.benhNhanBindingSource, "Thon", true));
            this.thonTextBox.Location = new System.Drawing.Point(427, 139);
            this.thonTextBox.Name = "thonTextBox";
            this.thonTextBox.Size = new System.Drawing.Size(200, 20);
            this.thonTextBox.TabIndex = 10;
            // 
            // tenXaLabel
            // 
            tenXaLabel.AutoSize = true;
            tenXaLabel.Location = new System.Drawing.Point(326, 168);
            tenXaLabel.Name = "tenXaLabel";
            tenXaLabel.Size = new System.Drawing.Size(45, 13);
            tenXaLabel.TabIndex = 11;
            tenXaLabel.Text = "Ten Xa:";
            // 
            // tenXaTextBox
            // 
            this.tenXaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.benhNhanBindingSource, "TenXa", true));
            this.tenXaTextBox.Location = new System.Drawing.Point(427, 165);
            this.tenXaTextBox.Name = "tenXaTextBox";
            this.tenXaTextBox.Size = new System.Drawing.Size(200, 20);
            this.tenXaTextBox.TabIndex = 12;
            // 
            // tenQuanLabel
            // 
            tenQuanLabel.AutoSize = true;
            tenQuanLabel.Location = new System.Drawing.Point(326, 194);
            tenQuanLabel.Name = "tenQuanLabel";
            tenQuanLabel.Size = new System.Drawing.Size(58, 13);
            tenQuanLabel.TabIndex = 13;
            tenQuanLabel.Text = "Ten Quan:";
            // 
            // tenQuanTextBox
            // 
            this.tenQuanTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.benhNhanBindingSource, "TenQuan", true));
            this.tenQuanTextBox.Location = new System.Drawing.Point(427, 191);
            this.tenQuanTextBox.Name = "tenQuanTextBox";
            this.tenQuanTextBox.Size = new System.Drawing.Size(200, 20);
            this.tenQuanTextBox.TabIndex = 14;
            // 
            // tenThiTranLabel
            // 
            tenThiTranLabel.AutoSize = true;
            tenThiTranLabel.Location = new System.Drawing.Point(326, 220);
            tenThiTranLabel.Name = "tenThiTranLabel";
            tenThiTranLabel.Size = new System.Drawing.Size(72, 13);
            tenThiTranLabel.TabIndex = 15;
            tenThiTranLabel.Text = "Ten Thi Tran:";
            // 
            // tenThiTranTextBox
            // 
            this.tenThiTranTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.benhNhanBindingSource, "TenThiTran", true));
            this.tenThiTranTextBox.Location = new System.Drawing.Point(427, 217);
            this.tenThiTranTextBox.Name = "tenThiTranTextBox";
            this.tenThiTranTextBox.Size = new System.Drawing.Size(200, 20);
            this.tenThiTranTextBox.TabIndex = 16;
            // 
            // tenNgheNghiepLabel
            // 
            tenNgheNghiepLabel.AutoSize = true;
            tenNgheNghiepLabel.Location = new System.Drawing.Point(326, 246);
            tenNgheNghiepLabel.Name = "tenNgheNghiepLabel";
            tenNgheNghiepLabel.Size = new System.Drawing.Size(95, 13);
            tenNgheNghiepLabel.TabIndex = 17;
            tenNgheNghiepLabel.Text = "Ten Nghe Nghiep:";
            // 
            // tenNgheNghiepTextBox
            // 
            this.tenNgheNghiepTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.benhNhanBindingSource, "TenNgheNghiep", true));
            this.tenNgheNghiepTextBox.Location = new System.Drawing.Point(427, 243);
            this.tenNgheNghiepTextBox.Name = "tenNgheNghiepTextBox";
            this.tenNgheNghiepTextBox.Size = new System.Drawing.Size(200, 20);
            this.tenNgheNghiepTextBox.TabIndex = 18;
            // 
            // ngayKhamLabel
            // 
            ngayKhamLabel.AutoSize = true;
            ngayKhamLabel.Location = new System.Drawing.Point(326, 273);
            ngayKhamLabel.Name = "ngayKhamLabel";
            ngayKhamLabel.Size = new System.Drawing.Size(65, 13);
            ngayKhamLabel.TabIndex = 19;
            ngayKhamLabel.Text = "Ngay Kham:";
            // 
            // ngayKhamDateTimePicker
            // 
            this.ngayKhamDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.benhNhanBindingSource, "NgayKham", true));
            this.ngayKhamDateTimePicker.Location = new System.Drawing.Point(427, 269);
            this.ngayKhamDateTimePicker.Name = "ngayKhamDateTimePicker";
            this.ngayKhamDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.ngayKhamDateTimePicker.TabIndex = 20;
            // 
            // tenPhongKhamLabel
            // 
            tenPhongKhamLabel.AutoSize = true;
            tenPhongKhamLabel.Location = new System.Drawing.Point(326, 298);
            tenPhongKhamLabel.Name = "tenPhongKhamLabel";
            tenPhongKhamLabel.Size = new System.Drawing.Size(93, 13);
            tenPhongKhamLabel.TabIndex = 21;
            tenPhongKhamLabel.Text = "Ten Phong Kham:";
            // 
            // tenPhongKhamTextBox
            // 
            this.tenPhongKhamTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.benhNhanBindingSource, "TenPhongKham", true));
            this.tenPhongKhamTextBox.Location = new System.Drawing.Point(427, 295);
            this.tenPhongKhamTextBox.Name = "tenPhongKhamTextBox";
            this.tenPhongKhamTextBox.Size = new System.Drawing.Size(200, 20);
            this.tenPhongKhamTextBox.TabIndex = 22;
            // 
            // chuanDoanLabel
            // 
            chuanDoanLabel.AutoSize = true;
            chuanDoanLabel.Location = new System.Drawing.Point(326, 324);
            chuanDoanLabel.Name = "chuanDoanLabel";
            chuanDoanLabel.Size = new System.Drawing.Size(70, 13);
            chuanDoanLabel.TabIndex = 23;
            chuanDoanLabel.Text = "Chuan Doan:";
            // 
            // chuanDoanTextBox
            // 
            this.chuanDoanTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.benhNhanBindingSource, "ChuanDoan", true));
            this.chuanDoanTextBox.Location = new System.Drawing.Point(427, 321);
            this.chuanDoanTextBox.Name = "chuanDoanTextBox";
            this.chuanDoanTextBox.Size = new System.Drawing.Size(200, 20);
            this.chuanDoanTextBox.TabIndex = 24;
            // 
            // tieuDuongLabel
            // 
            tieuDuongLabel.AutoSize = true;
            tieuDuongLabel.Location = new System.Drawing.Point(326, 352);
            tieuDuongLabel.Name = "tieuDuongLabel";
            tieuDuongLabel.Size = new System.Drawing.Size(66, 13);
            tieuDuongLabel.TabIndex = 25;
            tieuDuongLabel.Text = "Tieu Duong:";
            // 
            // tieuDuongCheckBox
            // 
            this.tieuDuongCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.benhNhanBindingSource, "TieuDuong", true));
            this.tieuDuongCheckBox.Location = new System.Drawing.Point(427, 347);
            this.tieuDuongCheckBox.Name = "tieuDuongCheckBox";
            this.tieuDuongCheckBox.Size = new System.Drawing.Size(200, 24);
            this.tieuDuongCheckBox.TabIndex = 26;
            this.tieuDuongCheckBox.Text = "checkBox1";
            this.tieuDuongCheckBox.UseVisualStyleBackColor = true;
            // 
            // benhNhanDataGridView
            // 
            this.benhNhanDataGridView.AutoGenerateColumns = false;
            this.benhNhanDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.benhNhanDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewCheckBoxColumn1});
            this.benhNhanDataGridView.DataSource = this.benhNhanBindingSource;
            this.benhNhanDataGridView.Location = new System.Drawing.Point(12, 87);
            this.benhNhanDataGridView.Name = "benhNhanDataGridView";
            this.benhNhanDataGridView.Size = new System.Drawing.Size(300, 220);
            this.benhNhanDataGridView.TabIndex = 27;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IDKhamBenh";
            this.dataGridViewTextBoxColumn1.HeaderText = "IDKhamBenh";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MaBN";
            this.dataGridViewTextBoxColumn2.HeaderText = "MaBN";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "HoTen";
            this.dataGridViewTextBoxColumn3.HeaderText = "HoTen";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NamSinh";
            this.dataGridViewTextBoxColumn4.HeaderText = "NamSinh";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Thon";
            this.dataGridViewTextBoxColumn5.HeaderText = "Thon";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "TenXa";
            this.dataGridViewTextBoxColumn6.HeaderText = "TenXa";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "TenQuan";
            this.dataGridViewTextBoxColumn7.HeaderText = "TenQuan";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "TenThiTran";
            this.dataGridViewTextBoxColumn8.HeaderText = "TenThiTran";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "TenNgheNghiep";
            this.dataGridViewTextBoxColumn9.HeaderText = "TenNgheNghiep";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "NgayKham";
            this.dataGridViewTextBoxColumn10.HeaderText = "NgayKham";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "TenPhongKham";
            this.dataGridViewTextBoxColumn11.HeaderText = "TenPhongKham";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "ChuanDoan";
            this.dataGridViewTextBoxColumn12.HeaderText = "ChuanDoan";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "TieuDuong";
            this.dataGridViewCheckBoxColumn1.HeaderText = "TieuDuong";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 475);
            this.Controls.Add(this.benhNhanDataGridView);
            this.Controls.Add(iDKhamBenhLabel);
            this.Controls.Add(this.iDKhamBenhTextBox);
            this.Controls.Add(maBNLabel);
            this.Controls.Add(this.maBNTextBox);
            this.Controls.Add(hoTenLabel);
            this.Controls.Add(this.hoTenTextBox);
            this.Controls.Add(namSinhLabel);
            this.Controls.Add(this.namSinhTextBox);
            this.Controls.Add(thonLabel);
            this.Controls.Add(this.thonTextBox);
            this.Controls.Add(tenXaLabel);
            this.Controls.Add(this.tenXaTextBox);
            this.Controls.Add(tenQuanLabel);
            this.Controls.Add(this.tenQuanTextBox);
            this.Controls.Add(tenThiTranLabel);
            this.Controls.Add(this.tenThiTranTextBox);
            this.Controls.Add(tenNgheNghiepLabel);
            this.Controls.Add(this.tenNgheNghiepTextBox);
            this.Controls.Add(ngayKhamLabel);
            this.Controls.Add(this.ngayKhamDateTimePicker);
            this.Controls.Add(tenPhongKhamLabel);
            this.Controls.Add(this.tenPhongKhamTextBox);
            this.Controls.Add(chuanDoanLabel);
            this.Controls.Add(this.chuanDoanTextBox);
            this.Controls.Add(tieuDuongLabel);
            this.Controls.Add(this.tieuDuongCheckBox);
            this.Controls.Add(this.benhNhanBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.diabetesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.benhNhanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.benhNhanBindingNavigator)).EndInit();
            this.benhNhanBindingNavigator.ResumeLayout(false);
            this.benhNhanBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.benhNhanDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DiabetesDataSet diabetesDataSet;
        private System.Windows.Forms.BindingSource benhNhanBindingSource;
        private DiabetesDataSetTableAdapters.BenhNhanTableAdapter benhNhanTableAdapter;
        private DiabetesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator benhNhanBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton benhNhanBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iDKhamBenhTextBox;
        private System.Windows.Forms.TextBox maBNTextBox;
        private System.Windows.Forms.TextBox hoTenTextBox;
        private System.Windows.Forms.TextBox namSinhTextBox;
        private System.Windows.Forms.TextBox thonTextBox;
        private System.Windows.Forms.TextBox tenXaTextBox;
        private System.Windows.Forms.TextBox tenQuanTextBox;
        private System.Windows.Forms.TextBox tenThiTranTextBox;
        private System.Windows.Forms.TextBox tenNgheNghiepTextBox;
        private System.Windows.Forms.DateTimePicker ngayKhamDateTimePicker;
        private System.Windows.Forms.TextBox tenPhongKhamTextBox;
        private System.Windows.Forms.TextBox chuanDoanTextBox;
        private System.Windows.Forms.CheckBox tieuDuongCheckBox;
        private System.Windows.Forms.DataGridView benhNhanDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;

    }
}

