namespace DiabetesDido
{
    partial class TestForm
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
            this.dtViewDataSet = new System.Windows.Forms.DataGridView();
            this.dtViewDataSetTemp = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtViewDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtViewDataSetTemp)).BeginInit();
            this.SuspendLayout();
            // 
            // dtViewDataSet
            // 
            this.dtViewDataSet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtViewDataSet.Location = new System.Drawing.Point(3, 1);
            this.dtViewDataSet.Name = "dtViewDataSet";
            this.dtViewDataSet.Size = new System.Drawing.Size(595, 208);
            this.dtViewDataSet.TabIndex = 0;
            // 
            // dtViewDataSetTemp
            // 
            this.dtViewDataSetTemp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtViewDataSetTemp.Location = new System.Drawing.Point(3, 215);
            this.dtViewDataSetTemp.Name = "dtViewDataSetTemp";
            this.dtViewDataSetTemp.Size = new System.Drawing.Size(595, 183);
            this.dtViewDataSetTemp.TabIndex = 1;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 450);
            this.Controls.Add(this.dtViewDataSetTemp);
            this.Controls.Add(this.dtViewDataSet);
            this.Name = "TestForm";
            this.Text = "TestForm";
            this.Load += new System.EventHandler(this.TestForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtViewDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtViewDataSetTemp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtViewDataSet;
        private System.Windows.Forms.DataGridView dtViewDataSetTemp;
    }
}