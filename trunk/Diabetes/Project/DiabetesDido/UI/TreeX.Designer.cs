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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonNaiveBayes = new System.Windows.Forms.RadioButton();
            this.buttonCreateModel = new System.Windows.Forms.Button();
            this.radioButtonID3 = new System.Windows.Forms.RadioButton();
            this.radioButtonC45 = new System.Windows.Forms.RadioButton();
            this.buttonViewModel = new System.Windows.Forms.Button();
            this.buttonTestModel = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(928, 477);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.dataGridView3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(920, 451);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.buttonViewModel);
            this.tabPage2.Controls.Add(this.buttonTestModel);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(920, 451);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.radioButtonNaiveBayes);
            this.groupBox1.Controls.Add(this.buttonCreateModel);
            this.groupBox1.Controls.Add(this.radioButtonID3);
            this.groupBox1.Controls.Add(this.radioButtonC45);
            this.groupBox1.Location = new System.Drawing.Point(712, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 134);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn mô hình";
            // 
            // radioButtonNaiveBayes
            // 
            this.radioButtonNaiveBayes.AutoSize = true;
            this.radioButtonNaiveBayes.Location = new System.Drawing.Point(6, 66);
            this.radioButtonNaiveBayes.Name = "radioButtonNaiveBayes";
            this.radioButtonNaiveBayes.Size = new System.Drawing.Size(85, 17);
            this.radioButtonNaiveBayes.TabIndex = 10;
            this.radioButtonNaiveBayes.Tag = "NaiveBayes";
            this.radioButtonNaiveBayes.Text = "Naive Bayes";
            this.radioButtonNaiveBayes.UseVisualStyleBackColor = true;
            // 
            // buttonCreateModel
            // 
            this.buttonCreateModel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCreateModel.Location = new System.Drawing.Point(119, 19);
            this.buttonCreateModel.Name = "buttonCreateModel";
            this.buttonCreateModel.Size = new System.Drawing.Size(75, 23);
            this.buttonCreateModel.TabIndex = 4;
            this.buttonCreateModel.Text = "Create Model";
            this.buttonCreateModel.UseVisualStyleBackColor = true;
            // 
            // radioButtonID3
            // 
            this.radioButtonID3.AutoSize = true;
            this.radioButtonID3.Location = new System.Drawing.Point(6, 43);
            this.radioButtonID3.Name = "radioButtonID3";
            this.radioButtonID3.Size = new System.Drawing.Size(42, 17);
            this.radioButtonID3.TabIndex = 9;
            this.radioButtonID3.Tag = "ID3";
            this.radioButtonID3.Text = "ID3";
            this.radioButtonID3.UseVisualStyleBackColor = true;
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
            this.radioButtonC45.Tag = "C45";
            this.radioButtonC45.Text = "C4.5";
            this.radioButtonC45.UseVisualStyleBackColor = true;
            // 
            // buttonViewModel
            // 
            this.buttonViewModel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonViewModel.Location = new System.Drawing.Point(718, 144);
            this.buttonViewModel.Name = "buttonViewModel";
            this.buttonViewModel.Size = new System.Drawing.Size(75, 23);
            this.buttonViewModel.TabIndex = 19;
            this.buttonViewModel.Text = "View Model";
            this.buttonViewModel.UseVisualStyleBackColor = true;
            // 
            // buttonTestModel
            // 
            this.buttonTestModel.Location = new System.Drawing.Point(8, 416);
            this.buttonTestModel.Name = "buttonTestModel";
            this.buttonTestModel.Size = new System.Drawing.Size(75, 23);
            this.buttonTestModel.TabIndex = 18;
            this.buttonTestModel.Text = "Test Model";
            this.buttonTestModel.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(8, 308);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(904, 102);
            this.dataGridView2.TabIndex = 17;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(698, 298);
            this.dataGridView1.TabIndex = 16;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.treeView2);
            this.tabPage3.Controls.Add(this.treeView1);
            this.tabPage3.Controls.Add(this.button4);
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.textBox1);
            this.tabPage3.Controls.Add(this.dataGridView4);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(920, 451);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(8, 6);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(826, 315);
            this.dataGridView3.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(840, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(840, 35);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(8, 41);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(782, 163);
            this.dataGridView4.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(24, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(130, 13);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(715, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(8, 251);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(230, 192);
            this.treeView1.TabIndex = 4;
            // 
            // treeView2
            // 
            this.treeView2.Location = new System.Drawing.Point(244, 251);
            this.treeView2.Name = "treeView2";
            this.treeView2.Size = new System.Drawing.Size(275, 192);
            this.treeView2.TabIndex = 5;
            // 
            // TreeX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 477);
            this.Controls.Add(this.tabControl1);
            this.Name = "TreeX";
            this.Text = "DecisionTree";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonNaiveBayes;
        private System.Windows.Forms.Button buttonCreateModel;
        private System.Windows.Forms.RadioButton radioButtonID3;
        private System.Windows.Forms.RadioButton radioButtonC45;
        private System.Windows.Forms.Button buttonViewModel;
        private System.Windows.Forms.Button buttonTestModel;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TreeView treeView2;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView4;


    }
}