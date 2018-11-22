namespace BugTrackingSystem.com.bugtracking.View
{
    partial class LoginForm
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
            this.btn_cnl = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.cmb_type = new System.Windows.Forms.ComboBox();
            this.txt_pwd = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lbl_post = new System.Windows.Forms.Label();
            this.lbl_pwd = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_cnl
            // 
            this.btn_cnl.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_cnl.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_cnl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btn_cnl.Location = new System.Drawing.Point(253, 191);
            this.btn_cnl.Name = "btn_cnl";
            this.btn_cnl.Size = new System.Drawing.Size(89, 30);
            this.btn_cnl.TabIndex = 23;
            this.btn_cnl.Text = "Cancel";
            this.btn_cnl.UseVisualStyleBackColor = false;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btn_login.Location = new System.Drawing.Point(89, 191);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(89, 30);
            this.btn_login.TabIndex = 22;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_log_Click);
            // 
            // cmb_type
            // 
            this.cmb_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_type.FormattingEnabled = true;
            this.cmb_type.Items.AddRange(new object[] {
            "Programmer",
            "Tester",
            "Master"});
            this.cmb_type.Location = new System.Drawing.Point(107, 146);
            this.cmb_type.Name = "cmb_type";
            this.cmb_type.Size = new System.Drawing.Size(235, 24);
            this.cmb_type.TabIndex = 21;
            // 
            // txt_pwd
            // 
            this.txt_pwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pwd.Location = new System.Drawing.Point(107, 110);
            this.txt_pwd.Name = "txt_pwd";
            this.txt_pwd.Size = new System.Drawing.Size(235, 22);
            this.txt_pwd.TabIndex = 20;
            this.txt_pwd.UseSystemPasswordChar = true;
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(107, 75);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(235, 22);
            this.txt_email.TabIndex = 19;
            // 
            // lbl_post
            // 
            this.lbl_post.AutoSize = true;
            this.lbl_post.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_post.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_post.Location = new System.Drawing.Point(12, 149);
            this.lbl_post.Name = "lbl_post";
            this.lbl_post.Size = new System.Drawing.Size(40, 16);
            this.lbl_post.TabIndex = 18;
            this.lbl_post.Text = "Type";
            this.lbl_post.Click += new System.EventHandler(this.lbl_post_Click);
            // 
            // lbl_pwd
            // 
            this.lbl_pwd.AutoSize = true;
            this.lbl_pwd.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_pwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pwd.Location = new System.Drawing.Point(12, 113);
            this.lbl_pwd.Name = "lbl_pwd";
            this.lbl_pwd.Size = new System.Drawing.Size(68, 16);
            this.lbl_pwd.TabIndex = 17;
            this.lbl_pwd.Text = "Password";
            this.lbl_pwd.Click += new System.EventHandler(this.lbl_pwd_Click);
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(12, 75);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(42, 16);
            this.lbl_email.TabIndex = 16;
            this.lbl_email.Text = "Email";
            this.lbl_email.Click += new System.EventHandler(this.lbl_email_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 231);
            this.Controls.Add(this.btn_cnl);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.cmb_type);
            this.Controls.Add(this.txt_pwd);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.lbl_post);
            this.Controls.Add(this.lbl_pwd);
            this.Controls.Add(this.lbl_email);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cnl;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.ComboBox cmb_type;
        private System.Windows.Forms.TextBox txt_pwd;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label lbl_post;
        private System.Windows.Forms.Label lbl_pwd;
        private System.Windows.Forms.Label lbl_email;
    }
}