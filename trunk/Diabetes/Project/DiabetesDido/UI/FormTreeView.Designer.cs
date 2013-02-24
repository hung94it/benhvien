namespace DiabetesDido.UI
{
    partial class FormTreeView
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.decisionTreeView = new DiabetesDido.UI.DecisionTreeViewDiabetes();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.textBoxYesRules = new System.Windows.Forms.TextBox();
            this.textBoxNoRules = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.decisionTreeView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(625, 396);
            this.splitContainer1.SplitterDistance = 297;
            this.splitContainer1.TabIndex = 5;
            // 
            // decisionTreeView
            // 
            this.decisionTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.decisionTreeView.Location = new System.Drawing.Point(0, 0);
            this.decisionTreeView.Name = "decisionTreeView";
            this.decisionTreeView.Size = new System.Drawing.Size(297, 396);
            this.decisionTreeView.TabIndex = 2;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.textBoxYesRules);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.textBoxNoRules);
            this.splitContainer2.Size = new System.Drawing.Size(324, 396);
            this.splitContainer2.SplitterDistance = 194;
            this.splitContainer2.TabIndex = 0;
            // 
            // textBoxYesRules
            // 
            this.textBoxYesRules.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxYesRules.Location = new System.Drawing.Point(0, 0);
            this.textBoxYesRules.Multiline = true;
            this.textBoxYesRules.Name = "textBoxYesRules";
            this.textBoxYesRules.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxYesRules.Size = new System.Drawing.Size(324, 194);
            this.textBoxYesRules.TabIndex = 1;
            // 
            // textBoxNoRules
            // 
            this.textBoxNoRules.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxNoRules.Location = new System.Drawing.Point(0, 0);
            this.textBoxNoRules.Multiline = true;
            this.textBoxNoRules.Name = "textBoxNoRules";
            this.textBoxNoRules.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxNoRules.Size = new System.Drawing.Size(324, 198);
            this.textBoxNoRules.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 396);
            this.Controls.Add(this.splitContainer1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "MetroForm";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private DecisionTreeViewDiabetes decisionTreeView;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TextBox textBoxYesRules;
        private System.Windows.Forms.TextBox textBoxNoRules;
    }
}