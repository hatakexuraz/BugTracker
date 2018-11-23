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
using MaterialSkin.Controls;

namespace BugTrackingSystem.com.bugtracking.View
{
    public partial class LoginForm : MaterialForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btn_log_Click(object sender, EventArgs e)
        {
            identifyAdmin();

            this.Hide();
            //Dashboard dashboard = new Dashboard();
            //dashboard.Visible = true;

            //AdminController adminController = new AdminController();

            //adminController.insertUser(txt_email.Text);
        }

        private void identifyAdmin()
        {
            LoginController loginController = new LoginController();
            //int user;
            String[] user = new String[4];
            String email, password, type;

            email = txt_email.Text;
            password = txt_pwd.Text;
            type = cmb_type.GetItemText(this.cmb_type.SelectedItem);

            Array.Copy(loginController.SelectUser(email, password, type), user, 4);

            /*if (type.Equals("Admin") && user.Length != 0)
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
            }*/

            Global.User_id = Convert.ToInt32(user[0]);
            Global.Email = user[1];
            Global.Type = user[3];


            try
            {   
                if (user[1].Equals(email) && type.Equals("Master"))
                {
                    AdminDashboard adminDashboard = new AdminDashboard();
                    adminDashboard.Show();
                }
                else if (user[1].Equals(email) && user[3].Equals(type))
                {
                    Dashboard dashboard = new Dashboard();
                    dashboard.Visible = true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Invalid email, password or type!!");
            }
        }

        private void lbl_post_Click(object sender, EventArgs e)
        {

        }

        private void lbl_pwd_Click(object sender, EventArgs e)
        {

        }

        private void lbl_email_Click(object sender, EventArgs e)
        {

        }

        private void btn_cnl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
