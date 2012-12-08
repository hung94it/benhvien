namespace DiabetesDido
{
    partial class NaiveBayes
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
            this.grbHuanLuyen = new System.Windows.Forms.GroupBox();
            this.diabetesDataSet = new DiabetesDido.DiabetesDataSet();
            this.trainingSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trainingSetTableAdapter = new DiabetesDido.DiabetesDataSetTableAdapters.TrainingSetTableAdapter();
            this.tableAdapterManager = new DiabetesDido.DiabetesDataSetTableAdapters.TableAdapterManager();
            this.trainingSetDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
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
            this.grbHuanLuyen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diabetesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingSetDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // grbHuanLuyen
            // 
            this.grbHuanLuyen.Controls.Add(this.trainingSetDataGridView);
            this.grbHuanLuyen.Location = new System.Drawing.Point(3, 3);
            this.grbHuanLuyen.Name = "grbHuanLuyen";
            this.grbHuanLuyen.Size = new System.Drawing.Size(635, 192);
            this.grbHuanLuyen.TabIndex = 0;
            this.grbHuanLuyen.TabStop = false;
            this.grbHuanLuyen.Text = "Dữ liệu huấn luyện";
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
            this.tableAdapterManager.ResultSetTableAdapter = null;
            this.tableAdapterManager.TestSetTableAdapter = null;
            this.tableAdapterManager.TrainingSetTableAdapter = this.trainingSetTableAdapter;
            this.tableAdapterManager.UpdateOrder = DiabetesDido.DiabetesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.XetNghiemTableAdapter = null;
            // 
            // trainingSetDataGridView
            // 
            this.trainingSetDataGridView.AutoGenerateColumns = false;
            this.trainingSetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.trainingSetDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewCheckBoxColumn1,
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
            this.dataGridViewTextBoxColumn31});
            this.trainingSetDataGridView.DataSource = this.trainingSetBindingSource;
            this.trainingSetDataGridView.Location = new System.Drawing.Point(0, 17);
            this.trainingSetDataGridView.Name = "trainingSetDataGridView";
            this.trainingSetDataGridView.Size = new System.Drawing.Size(629, 169);
            this.trainingSetDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Tuoi";
            this.dataGridViewTextBoxColumn1.HeaderText = "Tuoi";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "TieuDuong";
            this.dataGridViewCheckBoxColumn1.HeaderText = "TieuDuong";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "GioiTinh";
            this.dataGridViewTextBoxColumn2.HeaderText = "GioiTinh";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Cholesterol";
            this.dataGridViewTextBoxColumn3.HeaderText = "Cholesterol";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "HDL_Cholesterol";
            this.dataGridViewTextBoxColumn4.HeaderText = "HDL_Cholesterol";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Triglyceride";
            this.dataGridViewTextBoxColumn5.HeaderText = "Triglyceride";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "LDL_Cholesterol";
            this.dataGridViewTextBoxColumn6.HeaderText = "LDL_Cholesterol";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "SGOT";
            this.dataGridViewTextBoxColumn7.HeaderText = "SGOT";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "SGPT";
            this.dataGridViewTextBoxColumn8.HeaderText = "SGPT";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Urea";
            this.dataGridViewTextBoxColumn9.HeaderText = "Urea";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "WBC";
            this.dataGridViewTextBoxColumn10.HeaderText = "WBC";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "LYM";
            this.dataGridViewTextBoxColumn11.HeaderText = "LYM";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "MONO";
            this.dataGridViewTextBoxColumn12.HeaderText = "MONO";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "GRAN";
            this.dataGridViewTextBoxColumn13.HeaderText = "GRAN";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "TyLeLYM";
            this.dataGridViewTextBoxColumn14.HeaderText = "TyLeLYM";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "TyLeMONO";
            this.dataGridViewTextBoxColumn15.HeaderText = "TyLeMONO";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "TyLeGRAN";
            this.dataGridViewTextBoxColumn16.HeaderText = "TyLeGRAN";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "HGB";
            this.dataGridViewTextBoxColumn17.HeaderText = "HGB";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "RBC";
            this.dataGridViewTextBoxColumn18.HeaderText = "RBC";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "HTC";
            this.dataGridViewTextBoxColumn19.HeaderText = "HTC";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "MCV";
            this.dataGridViewTextBoxColumn20.HeaderText = "MCV";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "MCH";
            this.dataGridViewTextBoxColumn21.HeaderText = "MCH";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "MCHC";
            this.dataGridViewTextBoxColumn22.HeaderText = "MCHC";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "RDW_CV";
            this.dataGridViewTextBoxColumn23.HeaderText = "RDW_CV";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "PLT";
            this.dataGridViewTextBoxColumn24.HeaderText = "PLT";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "MPV";
            this.dataGridViewTextBoxColumn25.HeaderText = "MPV";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.DataPropertyName = "PDW";
            this.dataGridViewTextBoxColumn26.HeaderText = "PDW";
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.DataPropertyName = "PCT";
            this.dataGridViewTextBoxColumn27.HeaderText = "PCT";
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            // 
            // dataGridViewTextBoxColumn28
            // 
            this.dataGridViewTextBoxColumn28.DataPropertyName = "Na";
            this.dataGridViewTextBoxColumn28.HeaderText = "Na";
            this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            // 
            // dataGridViewTextBoxColumn29
            // 
            this.dataGridViewTextBoxColumn29.DataPropertyName = "K";
            this.dataGridViewTextBoxColumn29.HeaderText = "K";
            this.dataGridViewTextBoxColumn29.Name = "dataGridViewTextBoxColumn29";
            // 
            // dataGridViewTextBoxColumn30
            // 
            this.dataGridViewTextBoxColumn30.DataPropertyName = "Cl";
            this.dataGridViewTextBoxColumn30.HeaderText = "Cl";
            this.dataGridViewTextBoxColumn30.Name = "dataGridViewTextBoxColumn30";
            // 
            // dataGridViewTextBoxColumn31
            // 
            this.dataGridViewTextBoxColumn31.DataPropertyName = "Ca";
            this.dataGridViewTextBoxColumn31.HeaderText = "Ca";
            this.dataGridViewTextBoxColumn31.Name = "dataGridViewTextBoxColumn31";
            // 
            // NaiveBayes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 388);
            this.Controls.Add(this.grbHuanLuyen);
            this.Name = "NaiveBayes";
            this.Text = "NaiveBayes";
            this.Load += new System.EventHandler(this.NaiveBayes_Load);
            this.grbHuanLuyen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.diabetesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingSetDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbHuanLuyen;
        private DiabetesDataSet diabetesDataSet;
        private System.Windows.Forms.BindingSource trainingSetBindingSource;
        private DiabetesDataSetTableAdapters.TrainingSetTableAdapter trainingSetTableAdapter;
        private DiabetesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView trainingSetDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
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
    }
}