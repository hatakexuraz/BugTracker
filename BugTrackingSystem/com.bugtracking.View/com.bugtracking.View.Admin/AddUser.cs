using BugTrackingSystem.com.bugtracking.Controller;
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
    public partial class AddUser : MaterialForm
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            String email;
            String password, re_pass;
            String type;
            int result = 0;

            email = txt_email.Text;
            password = txt_pass.Text;
            re_pass = txt_repass.Text;
            type = cmb_type.GetItemText(this.cmb_type.SelectedItem);


            if (password.Equals(re_pass))
            {

                if (email.Equals(""))
                {
                    MessageBox.Show("Please fill all fields.");
                }
                else
                {
                    AdminController adminController = new AdminController();
                    result = adminController.insertUser(email, password, type);

                    if (result != 0)
                    {
                        MessageBox.Show("User added successfully");
                        txt_email.Text = "";
                        txt_pass.Text = "";
                        txt_repass.Text = "";
                    }
                }
            }
            else
            {
                MessageBox.Show("Password didn't match.");
            }
        }

        private void AddUser_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
