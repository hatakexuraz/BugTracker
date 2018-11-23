namespace BugTrackingSystem.com.bugtracking.View
{
    partial class Dashboard
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
            this.errorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newErrorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assignedBugsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_close = new System.Windows.Forms.Button();
            this.web_browser_control = new System.Windows.Forms.WebBrowser();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.errorsToolStripMenuItem,
            this.versionControlToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(-1, 65);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(351, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // errorsToolStripMenuItem
            // 
            this.errorsToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.errorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newErrorToolStripMenuItem,
            this.assignedBugsToolStripMenuItem});
            this.errorsToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.errorsToolStripMenuItem.Name = "errorsToolStripMenuItem";
            this.errorsToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.errorsToolStripMenuItem.Text = "Bugs";
            this.errorsToolStripMenuItem.Click += new System.EventHandler(this.errorsToolStripMenuItem_Click);
            // 
            // newErrorToolStripMenuItem
            // 
            this.newErrorToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.newErrorToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.newErrorToolStripMenuItem.Name = "newErrorToolStripMenuItem";
            this.newErrorToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.newErrorToolStripMenuItem.Text = "New Bugs";
            this.newErrorToolStripMenuItem.Click += new System.EventHandler(this.newErrorToolStripMenuItem_Click);
            // 
            // assignedBugsToolStripMenuItem
            // 
            this.assignedBugsToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.assignedBugsToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.assignedBugsToolStripMenuItem.Name = "assignedBugsToolStripMenuItem";
            this.assignedBugsToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.assignedBugsToolStripMenuItem.Text = "View Bugs";
            this.assignedBugsToolStripMenuItem.Click += new System.EventHandler(this.assignedBugsToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
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
            this.btn_close.Location = new System.Drawing.Point(1058, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(29, 23);
            this.btn_close.TabIndex = 21;
            this.btn_close.Text = "x";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // web_browser_control
            // 
            this.web_browser_control.Location = new System.Drawing.Point(12, 92);
            this.web_browser_control.MinimumSize = new System.Drawing.Size(20, 20);
            this.web_browser_control.Name = "web_browser_control";
            this.web_browser_control.Size = new System.Drawing.Size(1061, 468);
            this.web_browser_control.TabIndex = 22;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 572);
            this.ControlBox = false;
            this.Controls.Add(this.web_browser_control);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem errorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newErrorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assignedBugsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.ToolStripMenuItem versionControlToolStripMenuItem;
        private System.Windows.Forms.WebBrowser web_browser_control;
    }
}