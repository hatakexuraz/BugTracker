namespace BugTrackingSystem.com.bugtracking.View
{
    partial class AddError
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
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_assignTo = new System.Windows.Forms.ComboBox();
            this.txt_bug_desc = new System.Windows.Forms.TextBox();
            this.btn_add_bug = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bug Report";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Severity";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cmb_severity
            // 
            this.cmb_severity.AllowDrop = true;
            this.cmb_severity.FormattingEnabled = true;
            this.cmb_severity.Items.AddRange(new object[] {
            "Enhancement",
            "Blocker",
            "Critical",
            "Major",
            "Normal",
            "Trivial"});
            this.cmb_severity.Location = new System.Drawing.Point(141, 62);
            this.cmb_severity.Name = "cmb_severity";
            this.cmb_severity.Size = new System.Drawing.Size(196, 21);
            this.cmb_severity.TabIndex = 3;
            this.cmb_severity.SelectedIndexChanged += new System.EventHandler(this.cmb_severity_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Initial State";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cmb_bug_state
            // 
            this.cmb_bug_state.AllowDrop = true;
            this.cmb_bug_state.FormattingEnabled = true;
            this.cmb_bug_state.Items.AddRange(new object[] {
            "New",
            "Unconfirmed",
            "Assigned"});
            this.cmb_bug_state.Location = new System.Drawing.Point(141, 25);
            this.cmb_bug_state.Name = "cmb_bug_state";
            this.cmb_bug_state.Size = new System.Drawing.Size(196, 21);
            this.cmb_bug_state.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Assign To";
            // 
            // cmb_assignTo
            // 
            this.cmb_assignTo.AllowDrop = true;
            this.cmb_assignTo.FormattingEnabled = true;
            this.cmb_assignTo.Items.AddRange(new object[] {
            "Enhancement",
            "Blocker",
            "Critical",
            "Major",
            "Normal",
            "Trivial"});
            this.cmb_assignTo.Location = new System.Drawing.Point(141, 100);
            this.cmb_assignTo.Name = "cmb_assignTo";
            this.cmb_assignTo.Size = new System.Drawing.Size(196, 21);
            this.cmb_assignTo.TabIndex = 7;
            // 
            // txt_bug_desc
            // 
            this.txt_bug_desc.Location = new System.Drawing.Point(141, 139);
            this.txt_bug_desc.Name = "txt_bug_desc";
            this.txt_bug_desc.Size = new System.Drawing.Size(196, 20);
            this.txt_bug_desc.TabIndex = 1;
            this.txt_bug_desc.TextChanged += new System.EventHandler(this.txt_bug_desc_TextChanged);
            // 
            // btn_add_bug
            // 
            this.btn_add_bug.Location = new System.Drawing.Point(141, 181);
            this.btn_add_bug.Name = "btn_add_bug";
            this.btn_add_bug.Size = new System.Drawing.Size(91, 31);
            this.btn_add_bug.TabIndex = 8;
            this.btn_add_bug.Text = "Add Bug";
            this.btn_add_bug.UseVisualStyleBackColor = true;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(246, 181);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(91, 31);
            this.btn_cancel.TabIndex = 9;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // AddError
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 239);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_add_bug);
            this.Controls.Add(this.cmb_assignTo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_bug_state);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_severity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_bug_desc);
            this.Controls.Add(this.label1);
            this.Name = "AddError";
            this.Text = "AddError";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_severity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_bug_state;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_assignTo;
        private System.Windows.Forms.TextBox txt_bug_desc;
        private System.Windows.Forms.Button btn_add_bug;
        private System.Windows.Forms.Button btn_cancel;
    }
}