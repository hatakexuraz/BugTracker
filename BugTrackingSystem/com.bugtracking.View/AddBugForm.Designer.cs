namespace BugTrackingSystem.com.bugtracking.View
{
    partial class AddBugForm
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
            this.cmb_severity = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_bug_state = new System.Windows.Forms.ComboBox();
            this.btn_add_bug = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.txt_bug_code = new System.Windows.Forms.RichTextBox();
            this.txt_pic_name = new System.Windows.Forms.Label();
            this.btn_browse = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_project = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_line = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label1.Location = new System.Drawing.Point(15, 395);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bug code";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label2.Location = new System.Drawing.Point(15, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Severity";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cmb_severity
            // 
            this.cmb_severity.AllowDrop = true;
            this.cmb_severity.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmb_severity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.cmb_severity.FormattingEnabled = true;
            this.cmb_severity.Items.AddRange(new object[] {
            "Enhancement",
            "Blocker",
            "Critical",
            "Major",
            "Normal",
            "Trivial"});
            this.cmb_severity.Location = new System.Drawing.Point(144, 147);
            this.cmb_severity.Name = "cmb_severity";
            this.cmb_severity.Size = new System.Drawing.Size(225, 23);
            this.cmb_severity.TabIndex = 3;
            this.cmb_severity.SelectedIndexChanged += new System.EventHandler(this.cmb_severity_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label3.Location = new System.Drawing.Point(15, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Initial State";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cmb_bug_state
            // 
            this.cmb_bug_state.AllowDrop = true;
            this.cmb_bug_state.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmb_bug_state.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.cmb_bug_state.FormattingEnabled = true;
            this.cmb_bug_state.Items.AddRange(new object[] {
            "New",
            "Fixed",
            "Unfixed"});
            this.cmb_bug_state.Location = new System.Drawing.Point(144, 111);
            this.cmb_bug_state.Name = "cmb_bug_state";
            this.cmb_bug_state.Size = new System.Drawing.Size(225, 23);
            this.cmb_bug_state.TabIndex = 5;
            // 
            // btn_add_bug
            // 
            this.btn_add_bug.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_add_bug.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_add_bug.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btn_add_bug.Location = new System.Drawing.Point(144, 519);
            this.btn_add_bug.Name = "btn_add_bug";
            this.btn_add_bug.Size = new System.Drawing.Size(91, 31);
            this.btn_add_bug.TabIndex = 8;
            this.btn_add_bug.Text = "Add Bug";
            this.btn_add_bug.UseVisualStyleBackColor = false;
            this.btn_add_bug.Click += new System.EventHandler(this.btn_add_bug_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btn_cancel.Location = new System.Drawing.Point(278, 519);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(91, 31);
            this.btn_cancel.TabIndex = 9;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // txt_bug_code
            // 
            this.txt_bug_code.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_bug_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.txt_bug_code.Location = new System.Drawing.Point(144, 395);
            this.txt_bug_code.Name = "txt_bug_code";
            this.txt_bug_code.Size = new System.Drawing.Size(225, 107);
            this.txt_bug_code.TabIndex = 10;
            this.txt_bug_code.Text = "";
            this.txt_bug_code.TextChanged += new System.EventHandler(this.txt_bug_desc_TextChanged_1);
            // 
            // txt_pic_name
            // 
            this.txt_pic_name.AutoSize = true;
            this.txt_pic_name.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_pic_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.txt_pic_name.Location = new System.Drawing.Point(242, 350);
            this.txt_pic_name.Name = "txt_pic_name";
            this.txt_pic_name.Size = new System.Drawing.Size(127, 16);
            this.txt_pic_name.TabIndex = 17;
            this.txt_pic_name.Text = "No picture selected.";
            this.txt_pic_name.Click += new System.EventHandler(this.txt_pic_name_Click);
            // 
            // btn_browse
            // 
            this.btn_browse.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_browse.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_browse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btn_browse.Location = new System.Drawing.Point(144, 343);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(74, 29);
            this.btn_browse.TabIndex = 16;
            this.btn_browse.Text = "Browse....";
            this.btn_browse.UseVisualStyleBackColor = false;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label5.Location = new System.Drawing.Point(15, 350);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Bug Screenshot";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label6.Location = new System.Drawing.Point(18, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Belong To";
            // 
            // cmb_project
            // 
            this.cmb_project.AllowDrop = true;
            this.cmb_project.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmb_project.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.cmb_project.FormattingEnabled = true;
            this.cmb_project.Location = new System.Drawing.Point(144, 186);
            this.cmb_project.Name = "cmb_project";
            this.cmb_project.Size = new System.Drawing.Size(225, 23);
            this.cmb_project.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label4.Location = new System.Drawing.Point(18, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Bug Title";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.textBox1.Location = new System.Drawing.Point(144, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(225, 21);
            this.textBox1.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label7.Location = new System.Drawing.Point(18, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = " Line No.";
            // 
            // txt_line
            // 
            this.txt_line.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.txt_line.Location = new System.Drawing.Point(144, 225);
            this.txt_line.Name = "txt_line";
            this.txt_line.Size = new System.Drawing.Size(225, 21);
            this.txt_line.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label8.Location = new System.Drawing.Point(19, 266);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 16);
            this.label8.TabIndex = 24;
            this.label8.Text = "Method name";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.textBox3.Location = new System.Drawing.Point(144, 263);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(225, 21);
            this.textBox3.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label9.Location = new System.Drawing.Point(18, 305);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 16);
            this.label9.TabIndex = 26;
            this.label9.Text = "Class name";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.textBox2.Location = new System.Drawing.Point(144, 302);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(225, 21);
            this.textBox2.TabIndex = 27;
            // 
            // AddBugForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 567);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_line);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_project);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_pic_name);
            this.Controls.Add(this.btn_browse);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_bug_code);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_add_bug);
            this.Controls.Add(this.cmb_bug_state);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_severity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddBugForm";
            this.Text = "Add Bug";
            this.Load += new System.EventHandler(this.AddBugForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_severity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_bug_state;
        private System.Windows.Forms.Button btn_add_bug;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.RichTextBox txt_bug_code;
        private System.Windows.Forms.Label txt_pic_name;
        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_project;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_line;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox2;
    }
}