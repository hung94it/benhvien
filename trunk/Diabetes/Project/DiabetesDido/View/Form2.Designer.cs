using DiabetesDido.DAL;
namespace DiabetesDido.View
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.diabetesDataSet = new DiabetesDido.DAL.DiabetesDataSet();
            this.trainingSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trainingSetTableAdapter = new DiabetesDido.DAL.DiabetesDataSetTableAdapters.TrainingSetTableAdapter();
            this.tableAdapterManager = new DiabetesDido.DAL.DiabetesDataSetTableAdapters.TableAdapterManager();
            this.testSetTableAdapter = new DiabetesDido.DAL.DiabetesDataSetTableAdapters.TestSetTableAdapter();
            this.trainingSetBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.trainingSetBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.trainingSetDataGridView = new System.Windows.Forms.DataGridView();
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
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn33 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn34 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn35 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testSetDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn41 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn42 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn43 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn44 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn45 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn46 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn47 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn48 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn49 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn50 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn51 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn52 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn53 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn54 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn55 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn56 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn57 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn58 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn59 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn60 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn61 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn62 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn63 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn64 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn65 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn66 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn67 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn68 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn69 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn70 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn71 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn72 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn73 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn74 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bayesObjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bayesObjectTableAdapter = new DiabetesDido.DAL.DiabetesDataSetTableAdapters.BayesObjectTableAdapter();
            this.bayesObjectDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn36 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn37 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn38 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn40 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn75 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.diabetesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingSetBindingNavigator)).BeginInit();
            this.trainingSetBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trainingSetDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testSetDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bayesObjectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bayesObjectDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(672, 518);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Location = new System.Drawing.Point(753, 518);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // diabetesDataSet
            // 
            this.diabetesDataSet.DataSetName = "DiabetesDataSet";
            this.diabetesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // trainingSetBindingSource
            // 
            this.trainingSetBindingSource.DataMember = "TrainingSet";
            this.trainingSetBindingSource.DataSource = this.diabetesDataSet;
            // 
            // trainingSetTableAdapter
            // 
            this.trainingSetTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BayesObjectTableAdapter = null;
            this.tableAdapterManager.BenhNhanTableAdapter = null;
            this.tableAdapterManager.DataSetTableAdapter = null;
            this.tableAdapterManager.DataSetTempTableAdapter = null;
            this.tableAdapterManager.TestSetTableAdapter = this.testSetTableAdapter;
            this.tableAdapterManager.TrainingSetTableAdapter = this.trainingSetTableAdapter;
            this.tableAdapterManager.UpdateOrder = DiabetesDido.DAL.DiabetesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.XetNghiemTableAdapter = null;
            // 
            // testSetTableAdapter
            // 
            this.testSetTableAdapter.ClearBeforeFill = true;
            // 
            // trainingSetBindingNavigator
            // 
            this.trainingSetBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.trainingSetBindingNavigator.BindingSource = this.trainingSetBindingSource;
            this.trainingSetBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.trainingSetBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.trainingSetBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.trainingSetBindingNavigatorSaveItem});
            this.trainingSetBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.trainingSetBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.trainingSetBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.trainingSetBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.trainingSetBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.trainingSetBindingNavigator.Name = "trainingSetBindingNavigator";
            this.trainingSetBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.trainingSetBindingNavigator.Size = new System.Drawing.Size(1040, 25);
            this.trainingSetBindingNavigator.TabIndex = 6;
            this.trainingSetBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // trainingSetBindingNavigatorSaveItem
            // 
            this.trainingSetBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.trainingSetBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("trainingSetBindingNavigatorSaveItem.Image")));
            this.trainingSetBindingNavigatorSaveItem.Name = "trainingSetBindingNavigatorSaveItem";
            this.trainingSetBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.trainingSetBindingNavigatorSaveItem.Text = "Save Data";
            this.trainingSetBindingNavigatorSaveItem.Click += new System.EventHandler(this.trainingSetBindingNavigatorSaveItem_Click);
            // 
            // trainingSetDataGridView
            // 
            this.trainingSetDataGridView.AutoGenerateColumns = false;
            this.trainingSetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.trainingSetDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn24,
            this.dataGridViewTextBoxColumn25,
            this.dataGridViewTextBoxColumn26,
            this.dataGridViewTextBoxColumn27,
            this.dataGridViewTextBoxColumn28,
            this.dataGridViewTextBoxColumn29,
            this.dataGridViewTextBoxColumn30,
            this.dataGridViewTextBoxColumn31,
            this.dataGridViewTextBoxColumn32,
            this.dataGridViewTextBoxColumn33,
            this.dataGridViewTextBoxColumn34,
            this.dataGridViewTextBoxColumn35});
            this.trainingSetDataGridView.DataSource = this.trainingSetBindingSource;
            this.trainingSetDataGridView.Location = new System.Drawing.Point(12, 28);
            this.trainingSetDataGridView.Name = "trainingSetDataGridView";
            this.trainingSetDataGridView.Size = new System.Drawing.Size(540, 156);
            this.trainingSetDataGridView.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MaBN";
            this.dataGridViewTextBoxColumn2.HeaderText = "MaBN";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Tuoi";
            this.dataGridViewTextBoxColumn3.HeaderText = "Tuoi";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "GioiTinh";
            this.dataGridViewTextBoxColumn4.HeaderText = "GioiTinh";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Cholesterol";
            this.dataGridViewTextBoxColumn5.HeaderText = "Cholesterol";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "HDL_Cholesterol";
            this.dataGridViewTextBoxColumn6.HeaderText = "HDL_Cholesterol";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Triglyceride";
            this.dataGridViewTextBoxColumn7.HeaderText = "Triglyceride";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "LDL_Cholesterol";
            this.dataGridViewTextBoxColumn8.HeaderText = "LDL_Cholesterol";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Glucose";
            this.dataGridViewTextBoxColumn9.HeaderText = "Glucose";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "SGOT";
            this.dataGridViewTextBoxColumn10.HeaderText = "SGOT";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "SGPT";
            this.dataGridViewTextBoxColumn11.HeaderText = "SGPT";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Urea";
            this.dataGridViewTextBoxColumn12.HeaderText = "Urea";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "WBC";
            this.dataGridViewTextBoxColumn13.HeaderText = "WBC";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "LYM";
            this.dataGridViewTextBoxColumn14.HeaderText = "LYM";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "MONO";
            this.dataGridViewTextBoxColumn15.HeaderText = "MONO";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "GRAN";
            this.dataGridViewTextBoxColumn16.HeaderText = "GRAN";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "TyLeLYM";
            this.dataGridViewTextBoxColumn17.HeaderText = "TyLeLYM";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "TyLeMONO";
            this.dataGridViewTextBoxColumn18.HeaderText = "TyLeMONO";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "TyLeGRAN";
            this.dataGridViewTextBoxColumn19.HeaderText = "TyLeGRAN";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "HGB";
            this.dataGridViewTextBoxColumn20.HeaderText = "HGB";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "RBC";
            this.dataGridViewTextBoxColumn21.HeaderText = "RBC";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "HTC";
            this.dataGridViewTextBoxColumn22.HeaderText = "HTC";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "MCV";
            this.dataGridViewTextBoxColumn23.HeaderText = "MCV";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "MCH";
            this.dataGridViewTextBoxColumn24.HeaderText = "MCH";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "MCHC";
            this.dataGridViewTextBoxColumn25.HeaderText = "MCHC";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.DataPropertyName = "RDW_CV";
            this.dataGridViewTextBoxColumn26.HeaderText = "RDW_CV";
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.DataPropertyName = "PLT";
            this.dataGridViewTextBoxColumn27.HeaderText = "PLT";
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            // 
            // dataGridViewTextBoxColumn28
            // 
            this.dataGridViewTextBoxColumn28.DataPropertyName = "MPV";
            this.dataGridViewTextBoxColumn28.HeaderText = "MPV";
            this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            // 
            // dataGridViewTextBoxColumn29
            // 
            this.dataGridViewTextBoxColumn29.DataPropertyName = "PDW";
            this.dataGridViewTextBoxColumn29.HeaderText = "PDW";
            this.dataGridViewTextBoxColumn29.Name = "dataGridViewTextBoxColumn29";
            // 
            // dataGridViewTextBoxColumn30
            // 
            this.dataGridViewTextBoxColumn30.DataPropertyName = "PCT";
            this.dataGridViewTextBoxColumn30.HeaderText = "PCT";
            this.dataGridViewTextBoxColumn30.Name = "dataGridViewTextBoxColumn30";
            // 
            // dataGridViewTextBoxColumn31
            // 
            this.dataGridViewTextBoxColumn31.DataPropertyName = "Na";
            this.dataGridViewTextBoxColumn31.HeaderText = "Na";
            this.dataGridViewTextBoxColumn31.Name = "dataGridViewTextBoxColumn31";
            // 
            // dataGridViewTextBoxColumn32
            // 
            this.dataGridViewTextBoxColumn32.DataPropertyName = "K";
            this.dataGridViewTextBoxColumn32.HeaderText = "K";
            this.dataGridViewTextBoxColumn32.Name = "dataGridViewTextBoxColumn32";
            // 
            // dataGridViewTextBoxColumn33
            // 
            this.dataGridViewTextBoxColumn33.DataPropertyName = "Cl";
            this.dataGridViewTextBoxColumn33.HeaderText = "Cl";
            this.dataGridViewTextBoxColumn33.Name = "dataGridViewTextBoxColumn33";
            // 
            // dataGridViewTextBoxColumn34
            // 
            this.dataGridViewTextBoxColumn34.DataPropertyName = "Ca";
            this.dataGridViewTextBoxColumn34.HeaderText = "Ca";
            this.dataGridViewTextBoxColumn34.Name = "dataGridViewTextBoxColumn34";
            // 
            // dataGridViewTextBoxColumn35
            // 
            this.dataGridViewTextBoxColumn35.DataPropertyName = "TieuDuong";
            this.dataGridViewTextBoxColumn35.HeaderText = "TieuDuong";
            this.dataGridViewTextBoxColumn35.Name = "dataGridViewTextBoxColumn35";
            // 
            // testSetBindingSource
            // 
            this.testSetBindingSource.DataMember = "TestSet";
            this.testSetBindingSource.DataSource = this.diabetesDataSet;
            // 
            // testSetDataGridView
            // 
            this.testSetDataGridView.AutoGenerateColumns = false;
            this.testSetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.testSetDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn41,
            this.dataGridViewTextBoxColumn42,
            this.dataGridViewTextBoxColumn43,
            this.dataGridViewTextBoxColumn44,
            this.dataGridViewTextBoxColumn45,
            this.dataGridViewTextBoxColumn46,
            this.dataGridViewTextBoxColumn47,
            this.dataGridViewTextBoxColumn48,
            this.dataGridViewTextBoxColumn49,
            this.dataGridViewTextBoxColumn50,
            this.dataGridViewTextBoxColumn51,
            this.dataGridViewTextBoxColumn52,
            this.dataGridViewTextBoxColumn53,
            this.dataGridViewTextBoxColumn54,
            this.dataGridViewTextBoxColumn55,
            this.dataGridViewTextBoxColumn56,
            this.dataGridViewTextBoxColumn57,
            this.dataGridViewTextBoxColumn58,
            this.dataGridViewTextBoxColumn59,
            this.dataGridViewTextBoxColumn60,
            this.dataGridViewTextBoxColumn61,
            this.dataGridViewTextBoxColumn62,
            this.dataGridViewTextBoxColumn63,
            this.dataGridViewTextBoxColumn64,
            this.dataGridViewTextBoxColumn65,
            this.dataGridViewTextBoxColumn66,
            this.dataGridViewTextBoxColumn67,
            this.dataGridViewTextBoxColumn68,
            this.dataGridViewTextBoxColumn69,
            this.dataGridViewTextBoxColumn70,
            this.dataGridViewTextBoxColumn71,
            this.dataGridViewTextBoxColumn72,
            this.dataGridViewTextBoxColumn73,
            this.dataGridViewTextBoxColumn74});
            this.testSetDataGridView.DataSource = this.testSetBindingSource;
            this.testSetDataGridView.Location = new System.Drawing.Point(12, 190);
            this.testSetDataGridView.Name = "testSetDataGridView";
            this.testSetDataGridView.Size = new System.Drawing.Size(540, 151);
            this.testSetDataGridView.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn41
            // 
            this.dataGridViewTextBoxColumn41.DataPropertyName = "MaBN";
            this.dataGridViewTextBoxColumn41.HeaderText = "MaBN";
            this.dataGridViewTextBoxColumn41.Name = "dataGridViewTextBoxColumn41";
            // 
            // dataGridViewTextBoxColumn42
            // 
            this.dataGridViewTextBoxColumn42.DataPropertyName = "Tuoi";
            this.dataGridViewTextBoxColumn42.HeaderText = "Tuoi";
            this.dataGridViewTextBoxColumn42.Name = "dataGridViewTextBoxColumn42";
            // 
            // dataGridViewTextBoxColumn43
            // 
            this.dataGridViewTextBoxColumn43.DataPropertyName = "GioiTinh";
            this.dataGridViewTextBoxColumn43.HeaderText = "GioiTinh";
            this.dataGridViewTextBoxColumn43.Name = "dataGridViewTextBoxColumn43";
            // 
            // dataGridViewTextBoxColumn44
            // 
            this.dataGridViewTextBoxColumn44.DataPropertyName = "Cholesterol";
            this.dataGridViewTextBoxColumn44.HeaderText = "Cholesterol";
            this.dataGridViewTextBoxColumn44.Name = "dataGridViewTextBoxColumn44";
            // 
            // dataGridViewTextBoxColumn45
            // 
            this.dataGridViewTextBoxColumn45.DataPropertyName = "HDL_Cholesterol";
            this.dataGridViewTextBoxColumn45.HeaderText = "HDL_Cholesterol";
            this.dataGridViewTextBoxColumn45.Name = "dataGridViewTextBoxColumn45";
            // 
            // dataGridViewTextBoxColumn46
            // 
            this.dataGridViewTextBoxColumn46.DataPropertyName = "Triglyceride";
            this.dataGridViewTextBoxColumn46.HeaderText = "Triglyceride";
            this.dataGridViewTextBoxColumn46.Name = "dataGridViewTextBoxColumn46";
            // 
            // dataGridViewTextBoxColumn47
            // 
            this.dataGridViewTextBoxColumn47.DataPropertyName = "LDL_Cholesterol";
            this.dataGridViewTextBoxColumn47.HeaderText = "LDL_Cholesterol";
            this.dataGridViewTextBoxColumn47.Name = "dataGridViewTextBoxColumn47";
            // 
            // dataGridViewTextBoxColumn48
            // 
            this.dataGridViewTextBoxColumn48.DataPropertyName = "Glucose";
            this.dataGridViewTextBoxColumn48.HeaderText = "Glucose";
            this.dataGridViewTextBoxColumn48.Name = "dataGridViewTextBoxColumn48";
            // 
            // dataGridViewTextBoxColumn49
            // 
            this.dataGridViewTextBoxColumn49.DataPropertyName = "SGOT";
            this.dataGridViewTextBoxColumn49.HeaderText = "SGOT";
            this.dataGridViewTextBoxColumn49.Name = "dataGridViewTextBoxColumn49";
            // 
            // dataGridViewTextBoxColumn50
            // 
            this.dataGridViewTextBoxColumn50.DataPropertyName = "SGPT";
            this.dataGridViewTextBoxColumn50.HeaderText = "SGPT";
            this.dataGridViewTextBoxColumn50.Name = "dataGridViewTextBoxColumn50";
            // 
            // dataGridViewTextBoxColumn51
            // 
            this.dataGridViewTextBoxColumn51.DataPropertyName = "Urea";
            this.dataGridViewTextBoxColumn51.HeaderText = "Urea";
            this.dataGridViewTextBoxColumn51.Name = "dataGridViewTextBoxColumn51";
            // 
            // dataGridViewTextBoxColumn52
            // 
            this.dataGridViewTextBoxColumn52.DataPropertyName = "WBC";
            this.dataGridViewTextBoxColumn52.HeaderText = "WBC";
            this.dataGridViewTextBoxColumn52.Name = "dataGridViewTextBoxColumn52";
            // 
            // dataGridViewTextBoxColumn53
            // 
            this.dataGridViewTextBoxColumn53.DataPropertyName = "LYM";
            this.dataGridViewTextBoxColumn53.HeaderText = "LYM";
            this.dataGridViewTextBoxColumn53.Name = "dataGridViewTextBoxColumn53";
            // 
            // dataGridViewTextBoxColumn54
            // 
            this.dataGridViewTextBoxColumn54.DataPropertyName = "MONO";
            this.dataGridViewTextBoxColumn54.HeaderText = "MONO";
            this.dataGridViewTextBoxColumn54.Name = "dataGridViewTextBoxColumn54";
            // 
            // dataGridViewTextBoxColumn55
            // 
            this.dataGridViewTextBoxColumn55.DataPropertyName = "GRAN";
            this.dataGridViewTextBoxColumn55.HeaderText = "GRAN";
            this.dataGridViewTextBoxColumn55.Name = "dataGridViewTextBoxColumn55";
            // 
            // dataGridViewTextBoxColumn56
            // 
            this.dataGridViewTextBoxColumn56.DataPropertyName = "TyLeLYM";
            this.dataGridViewTextBoxColumn56.HeaderText = "TyLeLYM";
            this.dataGridViewTextBoxColumn56.Name = "dataGridViewTextBoxColumn56";
            // 
            // dataGridViewTextBoxColumn57
            // 
            this.dataGridViewTextBoxColumn57.DataPropertyName = "TyLeMONO";
            this.dataGridViewTextBoxColumn57.HeaderText = "TyLeMONO";
            this.dataGridViewTextBoxColumn57.Name = "dataGridViewTextBoxColumn57";
            // 
            // dataGridViewTextBoxColumn58
            // 
            this.dataGridViewTextBoxColumn58.DataPropertyName = "TyLeGRAN";
            this.dataGridViewTextBoxColumn58.HeaderText = "TyLeGRAN";
            this.dataGridViewTextBoxColumn58.Name = "dataGridViewTextBoxColumn58";
            // 
            // dataGridViewTextBoxColumn59
            // 
            this.dataGridViewTextBoxColumn59.DataPropertyName = "HGB";
            this.dataGridViewTextBoxColumn59.HeaderText = "HGB";
            this.dataGridViewTextBoxColumn59.Name = "dataGridViewTextBoxColumn59";
            // 
            // dataGridViewTextBoxColumn60
            // 
            this.dataGridViewTextBoxColumn60.DataPropertyName = "RBC";
            this.dataGridViewTextBoxColumn60.HeaderText = "RBC";
            this.dataGridViewTextBoxColumn60.Name = "dataGridViewTextBoxColumn60";
            // 
            // dataGridViewTextBoxColumn61
            // 
            this.dataGridViewTextBoxColumn61.DataPropertyName = "HTC";
            this.dataGridViewTextBoxColumn61.HeaderText = "HTC";
            this.dataGridViewTextBoxColumn61.Name = "dataGridViewTextBoxColumn61";
            // 
            // dataGridViewTextBoxColumn62
            // 
            this.dataGridViewTextBoxColumn62.DataPropertyName = "MCV";
            this.dataGridViewTextBoxColumn62.HeaderText = "MCV";
            this.dataGridViewTextBoxColumn62.Name = "dataGridViewTextBoxColumn62";
            // 
            // dataGridViewTextBoxColumn63
            // 
            this.dataGridViewTextBoxColumn63.DataPropertyName = "MCH";
            this.dataGridViewTextBoxColumn63.HeaderText = "MCH";
            this.dataGridViewTextBoxColumn63.Name = "dataGridViewTextBoxColumn63";
            // 
            // dataGridViewTextBoxColumn64
            // 
            this.dataGridViewTextBoxColumn64.DataPropertyName = "MCHC";
            this.dataGridViewTextBoxColumn64.HeaderText = "MCHC";
            this.dataGridViewTextBoxColumn64.Name = "dataGridViewTextBoxColumn64";
            // 
            // dataGridViewTextBoxColumn65
            // 
            this.dataGridViewTextBoxColumn65.DataPropertyName = "RDW_CV";
            this.dataGridViewTextBoxColumn65.HeaderText = "RDW_CV";
            this.dataGridViewTextBoxColumn65.Name = "dataGridViewTextBoxColumn65";
            // 
            // dataGridViewTextBoxColumn66
            // 
            this.dataGridViewTextBoxColumn66.DataPropertyName = "PLT";
            this.dataGridViewTextBoxColumn66.HeaderText = "PLT";
            this.dataGridViewTextBoxColumn66.Name = "dataGridViewTextBoxColumn66";
            // 
            // dataGridViewTextBoxColumn67
            // 
            this.dataGridViewTextBoxColumn67.DataPropertyName = "MPV";
            this.dataGridViewTextBoxColumn67.HeaderText = "MPV";
            this.dataGridViewTextBoxColumn67.Name = "dataGridViewTextBoxColumn67";
            // 
            // dataGridViewTextBoxColumn68
            // 
            this.dataGridViewTextBoxColumn68.DataPropertyName = "PDW";
            this.dataGridViewTextBoxColumn68.HeaderText = "PDW";
            this.dataGridViewTextBoxColumn68.Name = "dataGridViewTextBoxColumn68";
            // 
            // dataGridViewTextBoxColumn69
            // 
            this.dataGridViewTextBoxColumn69.DataPropertyName = "PCT";
            this.dataGridViewTextBoxColumn69.HeaderText = "PCT";
            this.dataGridViewTextBoxColumn69.Name = "dataGridViewTextBoxColumn69";
            // 
            // dataGridViewTextBoxColumn70
            // 
            this.dataGridViewTextBoxColumn70.DataPropertyName = "Na";
            this.dataGridViewTextBoxColumn70.HeaderText = "Na";
            this.dataGridViewTextBoxColumn70.Name = "dataGridViewTextBoxColumn70";
            // 
            // dataGridViewTextBoxColumn71
            // 
            this.dataGridViewTextBoxColumn71.DataPropertyName = "K";
            this.dataGridViewTextBoxColumn71.HeaderText = "K";
            this.dataGridViewTextBoxColumn71.Name = "dataGridViewTextBoxColumn71";
            // 
            // dataGridViewTextBoxColumn72
            // 
            this.dataGridViewTextBoxColumn72.DataPropertyName = "Cl";
            this.dataGridViewTextBoxColumn72.HeaderText = "Cl";
            this.dataGridViewTextBoxColumn72.Name = "dataGridViewTextBoxColumn72";
            // 
            // dataGridViewTextBoxColumn73
            // 
            this.dataGridViewTextBoxColumn73.DataPropertyName = "Ca";
            this.dataGridViewTextBoxColumn73.HeaderText = "Ca";
            this.dataGridViewTextBoxColumn73.Name = "dataGridViewTextBoxColumn73";
            // 
            // dataGridViewTextBoxColumn74
            // 
            this.dataGridViewTextBoxColumn74.DataPropertyName = "TieuDuong";
            this.dataGridViewTextBoxColumn74.HeaderText = "TieuDuong";
            this.dataGridViewTextBoxColumn74.Name = "dataGridViewTextBoxColumn74";
            // 
            // bayesObjectBindingSource
            // 
            this.bayesObjectBindingSource.DataMember = "BayesObject";
            this.bayesObjectBindingSource.DataSource = this.diabetesDataSet;
            // 
            // bayesObjectTableAdapter
            // 
            this.bayesObjectTableAdapter.ClearBeforeFill = true;
            // 
            // bayesObjectDataGridView
            // 
            this.bayesObjectDataGridView.AutoGenerateColumns = false;
            this.bayesObjectDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bayesObjectDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn36,
            this.dataGridViewTextBoxColumn37,
            this.dataGridViewTextBoxColumn38,
            this.dataGridViewTextBoxColumn40,
            this.dataGridViewTextBoxColumn75});
            this.bayesObjectDataGridView.DataSource = this.bayesObjectBindingSource;
            this.bayesObjectDataGridView.Location = new System.Drawing.Point(558, 28);
            this.bayesObjectDataGridView.Name = "bayesObjectDataGridView";
            this.bayesObjectDataGridView.Size = new System.Drawing.Size(448, 446);
            this.bayesObjectDataGridView.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn36
            // 
            this.dataGridViewTextBoxColumn36.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn36.HeaderText = "ID";
            this.dataGridViewTextBoxColumn36.Name = "dataGridViewTextBoxColumn36";
            this.dataGridViewTextBoxColumn36.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn37
            // 
            this.dataGridViewTextBoxColumn37.DataPropertyName = "TenThuocTinh";
            this.dataGridViewTextBoxColumn37.HeaderText = "TenThuocTinh";
            this.dataGridViewTextBoxColumn37.Name = "dataGridViewTextBoxColumn37";
            // 
            // dataGridViewTextBoxColumn38
            // 
            this.dataGridViewTextBoxColumn38.DataPropertyName = "KhoangRoiRac";
            this.dataGridViewTextBoxColumn38.HeaderText = "KhoangRoiRac";
            this.dataGridViewTextBoxColumn38.Name = "dataGridViewTextBoxColumn38";
            // 
            // dataGridViewTextBoxColumn40
            // 
            this.dataGridViewTextBoxColumn40.DataPropertyName = "GiaTri";
            this.dataGridViewTextBoxColumn40.HeaderText = "GiaTri";
            this.dataGridViewTextBoxColumn40.Name = "dataGridViewTextBoxColumn40";
            // 
            // dataGridViewTextBoxColumn75
            // 
            this.dataGridViewTextBoxColumn75.DataPropertyName = "TieuDuong";
            this.dataGridViewTextBoxColumn75.HeaderText = "TieuDuong";
            this.dataGridViewTextBoxColumn75.Name = "dataGridViewTextBoxColumn75";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(940, 537);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 347);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(540, 114);
            this.dataGridView1.TabIndex = 8;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 467);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(540, 114);
            this.dataGridView2.TabIndex = 8;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 749);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.bayesObjectDataGridView);
            this.Controls.Add(this.testSetDataGridView);
            this.Controls.Add(this.trainingSetDataGridView);
            this.Controls.Add(this.trainingSetBindingNavigator);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.diabetesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingSetBindingNavigator)).EndInit();
            this.trainingSetBindingNavigator.ResumeLayout(false);
            this.trainingSetBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trainingSetDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testSetDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bayesObjectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bayesObjectDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private DiabetesDataSet diabetesDataSet;
        private System.Windows.Forms.BindingSource trainingSetBindingSource;
        private DiabetesDido.DAL.DiabetesDataSetTableAdapters.TrainingSetTableAdapter trainingSetTableAdapter;
        private DiabetesDido.DAL.DiabetesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator trainingSetBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton trainingSetBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView trainingSetDataGridView;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn31;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn32;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn33;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn34;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn35;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn39;
        private DiabetesDido.DAL.DiabetesDataSetTableAdapters.TestSetTableAdapter testSetTableAdapter;
        private System.Windows.Forms.BindingSource testSetBindingSource;
        private System.Windows.Forms.DataGridView testSetDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn41;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn42;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn43;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn44;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn45;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn46;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn47;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn48;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn49;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn50;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn51;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn52;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn53;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn54;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn55;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn56;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn57;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn58;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn59;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn60;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn61;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn62;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn63;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn64;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn65;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn66;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn67;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn68;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn69;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn70;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn71;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn72;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn73;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn74;
        private System.Windows.Forms.BindingSource bayesObjectBindingSource;
        private DiabetesDido.DAL.DiabetesDataSetTableAdapters.BayesObjectTableAdapter bayesObjectTableAdapter;
        private System.Windows.Forms.DataGridView bayesObjectDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn36;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn37;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn38;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn40;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn75;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;




    }
}