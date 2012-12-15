namespace DiabetesDido.UI
{
    partial class TreeX
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonViewModel = new System.Windows.Forms.Button();
            this.radioButtonC45 = new System.Windows.Forms.RadioButton();
            this.radioButtonID3 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonNaiveBayes = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(663, 241);
            this.dataGridView1.TabIndex = 3;
            // 
            // buttonCreate
            // 
            this.buttonCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCreate.Location = new System.Drawing.Point(119, 19);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(75, 23);
            this.buttonCreate.TabIndex = 4;
            this.buttonCreate.Text = "Create";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 259);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(869, 102);
            this.dataGridView2.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 367);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Test";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonViewModel
            // 
            this.buttonViewModel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonViewModel.Location = new System.Drawing.Point(687, 152);
            this.buttonViewModel.Name = "buttonViewModel";
            this.buttonViewModel.Size = new System.Drawing.Size(75, 23);
            this.buttonViewModel.TabIndex = 7;
            this.buttonViewModel.Text = "View Model";
            this.buttonViewModel.UseVisualStyleBackColor = true;
            this.buttonViewModel.Click += new System.EventHandler(this.buttonViewModel_Click);
            // 
            // radioButtonC45
            // 
            this.radioButtonC45.AutoSize = true;
            this.radioButtonC45.Checked = true;
            this.radioButtonC45.Location = new System.Drawing.Point(6, 19);
            this.radioButtonC45.Name = "radioButtonC45";
            this.radioButtonC45.Size = new System.Drawing.Size(47, 17);
            this.radioButtonC45.TabIndex = 8;
            this.radioButtonC45.TabStop = true;
            this.radioButtonC45.Text = "C4.5";
            this.radioButtonC45.UseVisualStyleBackColor = true;
            this.radioButtonC45.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonID3
            // 
            this.radioButtonID3.AutoSize = true;
            this.radioButtonID3.Location = new System.Drawing.Point(6, 43);
            this.radioButtonID3.Name = "radioButtonID3";
            this.radioButtonID3.Size = new System.Drawing.Size(42, 17);
            this.radioButtonID3.TabIndex = 9;
            this.radioButtonID3.Text = "ID3";
            this.radioButtonID3.UseVisualStyleBackColor = true;
            this.radioButtonID3.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.radioButtonNaiveBayes);
            this.groupBox1.Controls.Add(this.buttonCreate);
            this.groupBox1.Controls.Add(this.radioButtonID3);
            this.groupBox1.Controls.Add(this.radioButtonC45);
            this.groupBox1.Location = new System.Drawing.Point(681, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 134);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn mô hình";
            // 
            // radioButtonNaiveBayes
            // 
            this.radioButtonNaiveBayes.AutoSize = true;
            this.radioButtonNaiveBayes.Location = new System.Drawing.Point(6, 66);
            this.radioButtonNaiveBayes.Name = "radioButtonNaiveBayes";
            this.radioButtonNaiveBayes.Size = new System.Drawing.Size(82, 17);
            this.radioButtonNaiveBayes.TabIndex = 10;
            this.radioButtonNaiveBayes.Text = "NaiveBayes";
            this.radioButtonNaiveBayes.UseVisualStyleBackColor = true;
            this.radioButtonNaiveBayes.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // TreeX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 402);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonViewModel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TreeX";
            this.Text = "DecisionTree";
            this.Load += new System.EventHandler(this.TreeX_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonViewModel;
        private System.Windows.Forms.RadioButton radioButtonC45;
        private System.Windows.Forms.RadioButton radioButtonID3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonNaiveBayes;
    }
}