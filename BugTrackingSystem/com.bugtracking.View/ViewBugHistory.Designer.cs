namespace BugTrackingSystem.com.bugtracking.View
{
    partial class ViewBugHistory
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
            this.tbl_bug_history = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_bug_history)).BeginInit();
            this.SuspendLayout();
            // 
            // tbl_bug_history
            // 
            this.tbl_bug_history.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_bug_history.Location = new System.Drawing.Point(1, 64);
            this.tbl_bug_history.Name = "tbl_bug_history";
            this.tbl_bug_history.Size = new System.Drawing.Size(536, 186);
            this.tbl_bug_history.TabIndex = 0;
            // 
            // ViewBugHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 251);
            this.Controls.Add(this.tbl_bug_history);
            this.Name = "ViewBugHistory";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ViewBugHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_bug_history)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tbl_bug_history;
    }
}