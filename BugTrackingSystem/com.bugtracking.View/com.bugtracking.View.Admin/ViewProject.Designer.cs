namespace BugTrackingSystem.com.bugtracking.View.com.bugtracking.View.Admin
{
    partial class ViewProject
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
            this.tbl_projects = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_projects)).BeginInit();
            this.SuspendLayout();
            // 
            // tbl_projects
            // 
            this.tbl_projects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_projects.Location = new System.Drawing.Point(0, 65);
            this.tbl_projects.Name = "tbl_projects";
            this.tbl_projects.Size = new System.Drawing.Size(563, 184);
            this.tbl_projects.TabIndex = 0;
            this.tbl_projects.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbl_projects_CellContentClick);
            // 
            // ViewProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 251);
            this.Controls.Add(this.tbl_projects);
            this.Name = "ViewProject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewProject";
            this.Load += new System.EventHandler(this.ViewProject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_projects)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tbl_projects;
    }
}