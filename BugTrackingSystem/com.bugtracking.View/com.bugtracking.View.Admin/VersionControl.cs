using CefSharp;
using CefSharp.WinForms;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugTrackingSystem.com.bugtracking.View.com.bugtracking.View.Admin
{
    public partial class VersionControl : MaterialForm
    {

        private ChromiumWebBrowser browser;

        public VersionControl()
        {
            InitializeComponent();
            InitBrowser();
        }

        private void VersionControl_Load(object sender, EventArgs e)
        {

        }

        public void InitBrowser()
        {
            Cef.Initialize(new CefSettings());
            browser = new ChromiumWebBrowser("https://github.com/hatakexuraz/BugTracker");
            this.Controls.Add(browser);
            browser.Dock = DockStyle.Fill;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
