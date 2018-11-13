namespace BugTrackingSystem
{
    partial class Login
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
            this.btn_log = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txt_pwd = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lbl_post = new System.Windows.Forms.Label();
            this.lbl_pwd = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_cnl
            // 
            this.btn_cnl.Location = new System.Drawing.Point(233, 146);
            this.btn_cnl.Name = "btn_cnl";
            this.btn_cnl.Size = new System.Drawing.Size(89, 30);
            this.btn_cnl.TabIndex = 15;
            this.btn_cnl.Text = "Cancel";
            this.btn_cnl.UseVisualStyleBackColor = true;
            // 
            // btn_log
            // 
            this.btn_log.Location = new System.Drawing.Point(35, 146);
            this.btn_log.Name = "btn_log";
            this.btn_log.Size = new System.Drawing.Size(89, 30);
            this.btn_log.TabIndex = 14;
            this.btn_log.Text = "Login";
            this.btn_log.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(107, 101);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(215, 24);
            this.comboBox1.TabIndex = 13;
            // 
            // txt_pwd
            // 
            this.txt_pwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pwd.Location = new System.Drawing.Point(107, 65);
            this.txt_pwd.Name = "txt_pwd";
            this.txt_pwd.Size = new System.Drawing.Size(215, 22);
            this.txt_pwd.TabIndex = 12;
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(107, 30);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(215, 22);
            this.txt_email.TabIndex = 11;
            // 
            // lbl_post
            // 
            this.lbl_post.AutoSize = true;
            this.lbl_post.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_post.Location = new System.Drawing.Point(32, 104);
            this.lbl_post.Name = "lbl_post";
            this.lbl_post.Size = new System.Drawing.Size(35, 16);
            this.lbl_post.TabIndex = 10;
            this.lbl_post.Text = "Post";
            // 
            // lbl_pwd
            // 
            this.lbl_pwd.AutoSize = true;
            this.lbl_pwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pwd.Location = new System.Drawing.Point(32, 68);
            this.lbl_pwd.Name = "lbl_pwd";
            this.lbl_pwd.Size = new System.Drawing.Size(68, 16);
            this.lbl_pwd.TabIndex = 9;
            this.lbl_pwd.Text = "Password";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(32, 30);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(42, 16);
            this.lbl_email.TabIndex = 8;
            this.lbl_email.Text = "Email";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 211);
            this.Controls.Add(this.btn_cnl);
            this.Controls.Add(this.btn_log);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txt_pwd);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.lbl_post);
            this.Controls.Add(this.lbl_pwd);
            this.Controls.Add(this.lbl_email);
            this.Name = "Login";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cnl;
        private System.Windows.Forms.Button btn_log;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txt_pwd;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label lbl_post;
        private System.Windows.Forms.Label lbl_pwd;
        private System.Windows.Forms.Label lbl_email;
    }
}

