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

namespace BugTrackingSystem.com.bugtracking.View
{
    public partial class BugDetailsForm : MaterialForm
    {
        public BugDetailsForm(int bug_id)
        {
            InitializeComponent();

            UserController userController = new UserController();
            userController.retriveBugsDet(bug_id);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewBugs viewBugs = new ViewBugs();
            viewBugs.Show();

            this.Hide();
        }
    }
}
