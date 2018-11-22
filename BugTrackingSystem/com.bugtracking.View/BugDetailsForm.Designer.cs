namespace BugTrackingSystem.com.bugtracking.View
{
    partial class BugDetailsForm
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
            this.lbl_pr_name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_assigned_to = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_severity = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Project Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_pr_name
            // 
            this.lbl_pr_name.AutoSize = true;
            this.lbl_pr_name.Location = new System.Drawing.Point(147, 21);
            this.lbl_pr_name.Name = "lbl_pr_name";
            this.lbl_pr_name.Size = new System.Drawing.Size(28, 13);
            this.lbl_pr_name.TabIndex = 1;
            this.lbl_pr_name.Text = "XYZ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bug desc.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Assined to";
            // 
            // lbl_assigned_to
            // 
            this.lbl_assigned_to.AutoSize = true;
            this.lbl_assigned_to.Location = new System.Drawing.Point(147, 102);
            this.lbl_assigned_to.Name = "lbl_assigned_to";
            this.lbl_assigned_to.Size = new System.Drawing.Size(25, 13);
            this.lbl_assigned_to.TabIndex = 4;
            this.lbl_assigned_to.Text = "abc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Severity";
            // 
            // lbl_severity
            // 
            this.lbl_severity.AutoSize = true;
            this.lbl_severity.Location = new System.Drawing.Point(147, 144);
            this.lbl_severity.Name = "lbl_severity";
            this.lbl_severity.Size = new System.Drawing.Size(13, 13);
            this.lbl_severity.TabIndex = 6;
            this.lbl_severity.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Status";
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(147, 183);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(52, 13);
            this.lbl_status.TabIndex = 8;
            this.lbl_status.Text = "Not Fixed";
            // 
            // BugDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 237);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_severity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_assigned_to);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_pr_name);
            this.Controls.Add(this.label1);
            this.Name = "BugDetailsForm";
            this.Text = "Bug";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_pr_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_assigned_to;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_severity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_status;
    }
}