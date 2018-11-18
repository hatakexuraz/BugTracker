namespace BugTrackingSystem.com.bugtracking.View.com.bugtracking.View.Admin
{
    partial class AssignUser
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
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_users = new System.Windows.Forms.ComboBox();
            this.cmb_project = new System.Windows.Forms.ComboBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_assign = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Project\'s User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Project";
            // 
            // cmb_users
            // 
            this.cmb_users.FormattingEnabled = true;
            this.cmb_users.Location = new System.Drawing.Point(121, 8);
            this.cmb_users.Name = "cmb_users";
            this.cmb_users.Size = new System.Drawing.Size(262, 21);
            this.cmb_users.TabIndex = 2;
            // 
            // cmb_project
            // 
            this.cmb_project.FormattingEnabled = true;
            this.cmb_project.Location = new System.Drawing.Point(121, 48);
            this.cmb_project.Name = "cmb_project";
            this.cmb_project.Size = new System.Drawing.Size(262, 21);
            this.cmb_project.TabIndex = 3;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(292, 93);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(91, 34);
            this.btn_cancel.TabIndex = 4;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // btn_assign
            // 
            this.btn_assign.Location = new System.Drawing.Point(145, 93);
            this.btn_assign.Name = "btn_assign";
            this.btn_assign.Size = new System.Drawing.Size(91, 34);
            this.btn_assign.TabIndex = 5;
            this.btn_assign.Text = "Assign";
            this.btn_assign.UseVisualStyleBackColor = true;
            // 
            // AssignUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 139);
            this.Controls.Add(this.btn_assign);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.cmb_project);
            this.Controls.Add(this.cmb_users);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AssignUser";
            this.Text = "AssignUSer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_users;
        private System.Windows.Forms.ComboBox cmb_project;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_assign;
    }
}