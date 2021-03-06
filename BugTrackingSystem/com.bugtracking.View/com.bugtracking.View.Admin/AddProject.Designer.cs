﻿namespace BugTrackingSystem.com.bugtracking.View.com.bugtracking.View.Admin
{
    partial class AddProject
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
            this.txt_pro_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_pro_desc = new System.Windows.Forms.RichTextBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.end_date = new System.Windows.Forms.DateTimePicker();
            this.start_date = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label1.Location = new System.Drawing.Point(21, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Project Name";
            // 
            // txt_pro_name
            // 
            this.txt_pro_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.txt_pro_name.Location = new System.Drawing.Point(122, 74);
            this.txt_pro_name.Name = "txt_pro_name";
            this.txt_pro_name.Size = new System.Drawing.Size(244, 21);
            this.txt_pro_name.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label2.Location = new System.Drawing.Point(21, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Project desc.";
            // 
            // txt_pro_desc
            // 
            this.txt_pro_desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.txt_pro_desc.Location = new System.Drawing.Point(122, 194);
            this.txt_pro_desc.Name = "txt_pro_desc";
            this.txt_pro_desc.Size = new System.Drawing.Size(244, 129);
            this.txt_pro_desc.TabIndex = 3;
            this.txt_pro_desc.Text = "";
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btn_cancel.Location = new System.Drawing.Point(282, 342);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(84, 31);
            this.btn_cancel.TabIndex = 4;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btn_add.Location = new System.Drawing.Point(151, 342);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(84, 31);
            this.btn_add.TabIndex = 5;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label3.Location = new System.Drawing.Point(21, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Start date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label4.Location = new System.Drawing.Point(21, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "End date";
            // 
            // end_date
            // 
            this.end_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.end_date.Location = new System.Drawing.Point(122, 152);
            this.end_date.Name = "end_date";
            this.end_date.Size = new System.Drawing.Size(244, 21);
            this.end_date.TabIndex = 10;
            // 
            // start_date
            // 
            this.start_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.start_date.Location = new System.Drawing.Point(122, 114);
            this.start_date.Name = "start_date";
            this.start_date.Size = new System.Drawing.Size(244, 21);
            this.start_date.TabIndex = 11;
            // 
            // AddProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 394);
            this.Controls.Add(this.start_date);
            this.Controls.Add(this.end_date);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.txt_pro_desc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_pro_name);
            this.Controls.Add(this.label1);
            this.Name = "AddProject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddProject";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_pro_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txt_pro_desc;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker end_date;
        private System.Windows.Forms.DateTimePicker start_date;
    }
}