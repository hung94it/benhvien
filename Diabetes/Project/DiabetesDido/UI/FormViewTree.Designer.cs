namespace DiabetesDido.UI
{
    partial class FormViewTree
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
            this.decisionTreeView1 = new Accord.Controls.DecisionTreeView();
            this.SuspendLayout();
            // 
            // decisionTreeView1
            // 
            this.decisionTreeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.decisionTreeView1.Location = new System.Drawing.Point(12, 12);
            this.decisionTreeView1.Name = "decisionTreeView1";
            this.decisionTreeView1.Size = new System.Drawing.Size(460, 437);
            this.decisionTreeView1.TabIndex = 0;
            this.decisionTreeView1.TreeSource = null;
            // 
            // FormViewTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.decisionTreeView1);
            this.Name = "FormViewTree";
            this.Text = "Decision Tree";
            this.ResumeLayout(false);

        }

        #endregion

        private Accord.Controls.DecisionTreeView decisionTreeView1;
    }
}