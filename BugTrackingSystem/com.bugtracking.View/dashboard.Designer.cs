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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_ttlerr = new System.Windows.Forms.Label();
            this.lbl_unreerr = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_reerr = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.errorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newErrorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assignedBugsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label1.Location = new System.Drawing.Point(12, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Total errors";
            // 
            // lbl_ttlerr
            // 
            this.lbl_ttlerr.AutoSize = true;
            this.lbl_ttlerr.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_ttlerr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lbl_ttlerr.Location = new System.Drawing.Point(126, 109);
            this.lbl_ttlerr.Name = "lbl_ttlerr";
            this.lbl_ttlerr.Size = new System.Drawing.Size(15, 16);
            this.lbl_ttlerr.TabIndex = 15;
            this.lbl_ttlerr.Text = "0";
            // 
            // lbl_unreerr
            // 
            this.lbl_unreerr.AutoSize = true;
            this.lbl_unreerr.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_unreerr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lbl_unreerr.Location = new System.Drawing.Point(126, 188);
            this.lbl_unreerr.Name = "lbl_unreerr";
            this.lbl_unreerr.Size = new System.Drawing.Size(15, 16);
            this.lbl_unreerr.TabIndex = 19;
            this.lbl_unreerr.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label2.Location = new System.Drawing.Point(12, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Resolved errors";
            // 
            // lbl_reerr
            // 
            this.lbl_reerr.AutoSize = true;
            this.lbl_reerr.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_reerr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lbl_reerr.Location = new System.Drawing.Point(126, 146);
            this.lbl_reerr.Name = "lbl_reerr";
            this.lbl_reerr.Size = new System.Drawing.Size(15, 16);
            this.lbl_reerr.TabIndex = 18;
            this.lbl_reerr.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label3.Location = new System.Drawing.Point(12, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Unresolved errors";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.errorsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(-1, 65);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(179, 24);
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
            // 
            // newErrorToolStripMenuItem
            // 
            this.newErrorToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.newErrorToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.newErrorToolStripMenuItem.Name = "newErrorToolStripMenuItem";
            this.newErrorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newErrorToolStripMenuItem.Text = "New Bugs";
            this.newErrorToolStripMenuItem.Click += new System.EventHandler(this.newErrorToolStripMenuItem_Click);
            // 
            // assignedBugsToolStripMenuItem
            // 
            this.assignedBugsToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.assignedBugsToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.assignedBugsToolStripMenuItem.Name = "assignedBugsToolStripMenuItem";
            this.assignedBugsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.assignedBugsToolStripMenuItem.Text = "View Bugs";
            this.assignedBugsToolStripMenuItem.Click += new System.EventHandler(this.assignedBugsToolStripMenuItem_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_ttlerr);
            this.Controls.Add(this.lbl_unreerr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_reerr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_ttlerr;
        private System.Windows.Forms.Label lbl_unreerr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_reerr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem errorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newErrorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assignedBugsToolStripMenuItem;
    }
}