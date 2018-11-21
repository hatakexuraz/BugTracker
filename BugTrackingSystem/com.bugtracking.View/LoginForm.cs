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
using BugTrackingSystem.com.bugtracking.View.com.bugtracking.View.Admin;

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
            identifyAdmin();

            //Dashboard dashboard = new Dashboard();
            //dashboard.Visible = true;

            //AdminController adminController = new AdminController();

            //adminController.insertUser(txt_email.Text);
        }

        private void identifyAdmin()
        {
            LoginController loginController = new LoginController();
            int user;
            String email, password, type;

            email = txt_email.Text;
            password = txt_pwd.Text;
            type = cmb_type.GetItemText(this.cmb_type.SelectedItem);

            user = loginController.SelectUser(txt_email.Text, txt_pwd.Text);

            if (type.Equals("Admin") && user != 0)
            {
                AdminDashboard adminDashboard = new AdminDashboard();
                adminDashboard.Show();
            }
            else if (user != 0)
            {
                Dashboard dashboard = new Dashboard();
                dashboard.Visible = true;
            }
            else
            {
                MessageBox.Show("username or password invalid!!");
            }
        }
    }
}
