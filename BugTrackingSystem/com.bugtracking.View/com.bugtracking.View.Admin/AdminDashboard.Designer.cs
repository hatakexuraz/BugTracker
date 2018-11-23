namespace BugTrackingSystem.com.bugtracking.View.com.bugtracking.View.Admin
{
    partial class AdminDashboard
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bugsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewProjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assignUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_close = new System.Windows.Forms.Button();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripMenuItem,
            this.bugsToolStripMenuItem,
            this.versionControlToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 64);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(411, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newUserToolStripMenuItem,
            this.viewUserToolStripMenuItem});
            this.userToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.userToolStripMenuItem.Text = "User";
            // 
            // newUserToolStripMenuItem
            // 
            this.newUserToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.newUserToolStripMenuItem.Name = "newUserToolStripMenuItem";
            this.newUserToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.newUserToolStripMenuItem.Text = "New User";
            this.newUserToolStripMenuItem.Click += new System.EventHandler(this.newUserToolStripMenuItem_Click);
            // 
            // viewUserToolStripMenuItem
            // 
            this.viewUserToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.viewUserToolStripMenuItem.Name = "viewUserToolStripMenuItem";
            this.viewUserToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.viewUserToolStripMenuItem.Text = "View User";
            this.viewUserToolStripMenuItem.Click += new System.EventHandler(this.viewUserToolStripMenuItem_Click);
            // 
            // bugsToolStripMenuItem
            // 
            this.bugsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newProjectToolStripMenuItem,
            this.viewProjectsToolStripMenuItem,
            this.assignUsersToolStripMenuItem});
            this.bugsToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.bugsToolStripMenuItem.Name = "bugsToolStripMenuItem";
            this.bugsToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.bugsToolStripMenuItem.Text = "Project";
            this.bugsToolStripMenuItem.Click += new System.EventHandler(this.bugsToolStripMenuItem_Click);
            // 
            // newProjectToolStripMenuItem
            // 
            this.newProjectToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.newProjectToolStripMenuItem.Name = "newProjectToolStripMenuItem";
            this.newProjectToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.newProjectToolStripMenuItem.Text = "New Project";
            this.newProjectToolStripMenuItem.Click += new System.EventHandler(this.newProjectToolStripMenuItem_Click);
            // 
            // viewProjectsToolStripMenuItem
            // 
            this.viewProjectsToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.viewProjectsToolStripMenuItem.Name = "viewProjectsToolStripMenuItem";
            this.viewProjectsToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.viewProjectsToolStripMenuItem.Text = "View Projects";
            this.viewProjectsToolStripMenuItem.Click += new System.EventHandler(this.viewProjectsToolStripMenuItem_Click);
            // 
            // assignUsersToolStripMenuItem
            // 
            this.assignUsersToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.assignUsersToolStripMenuItem.Name = "assignUsersToolStripMenuItem";
            this.assignUsersToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.assignUsersToolStripMenuItem.Text = "Assign Users";
            this.assignUsersToolStripMenuItem.Click += new System.EventHandler(this.assignUsersToolStripMenuItem_Click);
            // 
            // versionControlToolStripMenuItem
            // 
            this.versionControlToolStripMenuItem.Name = "versionControlToolStripMenuItem";
            this.versionControlToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.versionControlToolStripMenuItem.Text = "Version Control";
            this.versionControlToolStripMenuItem.Click += new System.EventHandler(this.versionControlToolStripMenuItem_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Red;
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Location = new System.Drawing.Point(795, -1);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(29, 23);
            this.btn_close.TabIndex = 1;
            this.btn_close.Text = "x";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 426);
            this.ControlBox = false;
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Dashboard";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bugsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewProjectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assignUsersToolStripMenuItem;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.ToolStripMenuItem versionControlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
    }
}