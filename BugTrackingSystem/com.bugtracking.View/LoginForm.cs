using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BugTrackingSystem.com.bugtracking.Controller;

namespace BugTrackingSystem.com.bugtracking.View
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btn_log_Click(object sender, EventArgs e)
        {
            LoginController loginController = new LoginController();
            String user = loginController.SelectUser(txt_email.Text);
            if (txt_email.Text.Equals(user))
            {
                Dashboard dashboard = new Dashboard();
                dashboard.Visible = true;
            }
            else
            {
                MessageBox.Show("Something went wrong!!!");
            }

            //Dashboard dashboard = new Dashboard();
            //dashboard.Visible = true;
        }
    }
}
