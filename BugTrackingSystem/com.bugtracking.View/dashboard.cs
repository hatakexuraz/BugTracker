using BugTrackingSystem.com.bugtracking.View.com.bugtracking.View.Admin;
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
    public partial class Dashboard : MaterialForm
    {
        public Dashboard()
        {
            InitializeComponent();

            LoginForm loginForm = new LoginForm();
            loginForm.Visible = false;
        }

        private void newErrorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBugForm addError = new AddBugForm();
            addError.Visible = true;

        }

        private void assignedBugsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewBugs assignedBugs = new ViewBugs();
            assignedBugs.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void viewBugsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void errorsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void versionControlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VersionControl versionControl = new VersionControl();
            versionControl.Show();
        }
    }
}
