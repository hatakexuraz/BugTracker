namespace BugTrackingSystem.com.bugtracking.View
{
    partial class ViewBugs
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
            this.tbl_view_bugs = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_view_bugs)).BeginInit();
            this.SuspendLayout();
            // 
            // tbl_view_bugs
            // 
            this.tbl_view_bugs.BackgroundColor = System.Drawing.Color.White;
            this.tbl_view_bugs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_view_bugs.Location = new System.Drawing.Point(1, 65);
            this.tbl_view_bugs.Name = "tbl_view_bugs";
            this.tbl_view_bugs.Size = new System.Drawing.Size(840, 244);
            this.tbl_view_bugs.TabIndex = 0;
            this.tbl_view_bugs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbl_view_bugs_CellContentClick);
            // 
            // ViewBugs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 310);
            this.Controls.Add(this.tbl_view_bugs);
            this.Name = "ViewBugs";
            this.Text = "Assigned Bugs";
            this.Load += new System.EventHandler(this.AssignedBugsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_view_bugs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tbl_view_bugs;
    }
}