namespace BugTrackingSystem
{
    partial class dashboard
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_reerr = new System.Windows.Forms.Label();
            this.lbl_unreerr = new System.Windows.Forms.Label();
            this.btn_err = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_asn_err = new System.Windows.Forms.Button();
            this.btn_report = new System.Windows.Forms.Button();
            this.btn_viewerr = new System.Windows.Forms.Button();
            this.btn_adderr = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total errors";
            // 
            // lbl_ttlerr
            // 
            this.lbl_ttlerr.AutoSize = true;
            this.lbl_ttlerr.Location = new System.Drawing.Point(136, 43);
            this.lbl_ttlerr.Name = "lbl_ttlerr";
            this.lbl_ttlerr.Size = new System.Drawing.Size(13, 13);
            this.lbl_ttlerr.TabIndex = 2;
            this.lbl_ttlerr.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Resolved errors";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Unresolved errors";
            // 
            // lbl_reerr
            // 
            this.lbl_reerr.AutoSize = true;
            this.lbl_reerr.Location = new System.Drawing.Point(136, 80);
            this.lbl_reerr.Name = "lbl_reerr";
            this.lbl_reerr.Size = new System.Drawing.Size(13, 13);
            this.lbl_reerr.TabIndex = 5;
            this.lbl_reerr.Text = "0";
            // 
            // lbl_unreerr
            // 
            this.lbl_unreerr.AutoSize = true;
            this.lbl_unreerr.Location = new System.Drawing.Point(136, 122);
            this.lbl_unreerr.Name = "lbl_unreerr";
            this.lbl_unreerr.Size = new System.Drawing.Size(13, 13);
            this.lbl_unreerr.TabIndex = 6;
            this.lbl_unreerr.Text = "0";
            // 
            // btn_err
            // 
            this.btn_err.Location = new System.Drawing.Point(11, 36);
            this.btn_err.Name = "btn_err";
            this.btn_err.Size = new System.Drawing.Size(120, 27);
            this.btn_err.TabIndex = 7;
            this.btn_err.Text = "Errors";
            this.btn_err.UseVisualStyleBackColor = true;
            this.btn_err.Click += new System.EventHandler(this.btn_err_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(1, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btn_asn_err);
            this.splitContainer1.Panel1.Controls.Add(this.btn_report);
            this.splitContainer1.Panel1.Controls.Add(this.btn_viewerr);
            this.splitContainer1.Panel1.Controls.Add(this.btn_adderr);
            this.splitContainer1.Panel1.Controls.Add(this.btn_err);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_ttlerr);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_unreerr);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_reerr);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Size = new System.Drawing.Size(798, 447);
            this.splitContainer1.SplitterDistance = 196;
            this.splitContainer1.TabIndex = 8;
            // 
            // btn_asn_err
            // 
            this.btn_asn_err.Location = new System.Drawing.Point(37, 135);
            this.btn_asn_err.Name = "btn_asn_err";
            this.btn_asn_err.Size = new System.Drawing.Size(120, 27);
            this.btn_asn_err.TabIndex = 11;
            this.btn_asn_err.Text = "Assigned Errors";
            this.btn_asn_err.UseVisualStyleBackColor = true;
            // 
            // btn_report
            // 
            this.btn_report.Location = new System.Drawing.Point(11, 168);
            this.btn_report.Name = "btn_report";
            this.btn_report.Size = new System.Drawing.Size(120, 27);
            this.btn_report.TabIndex = 10;
            this.btn_report.Text = "Bug Report";
            this.btn_report.UseVisualStyleBackColor = true;
            // 
            // btn_viewerr
            // 
            this.btn_viewerr.Location = new System.Drawing.Point(37, 102);
            this.btn_viewerr.Name = "btn_viewerr";
            this.btn_viewerr.Size = new System.Drawing.Size(120, 27);
            this.btn_viewerr.TabIndex = 9;
            this.btn_viewerr.Text = "View Error";
            this.btn_viewerr.UseVisualStyleBackColor = true;
            // 
            // btn_adderr
            // 
            this.btn_adderr.Location = new System.Drawing.Point(37, 69);
            this.btn_adderr.Name = "btn_adderr";
            this.btn_adderr.Size = new System.Drawing.Size(120, 27);
            this.btn_adderr.TabIndex = 8;
            this.btn_adderr.Text = "New Error";
            this.btn_adderr.UseVisualStyleBackColor = true;
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "dashboard";
            this.Text = "dashboard";
            this.Load += new System.EventHandler(this.dashboard_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_ttlerr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_reerr;
        private System.Windows.Forms.Label lbl_unreerr;
        private System.Windows.Forms.Button btn_err;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btn_viewerr;
        private System.Windows.Forms.Button btn_adderr;
        private System.Windows.Forms.Button btn_report;
        private System.Windows.Forms.Button btn_asn_err;
    }
}