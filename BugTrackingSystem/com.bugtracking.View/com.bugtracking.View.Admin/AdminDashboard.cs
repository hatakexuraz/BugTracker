using MaterialSkin.Controls;
using System;
using CefSharp;
using CefSharp.WinForms;
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
    public partial class AdminDashboard : MaterialForm
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void newUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser();
            addUser.Show();
        }

        private void viewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewUser viewUser = new ViewUser();
            viewUser.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void newProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddProject addProject = new AddProject();
            addProject.Show();
        }

        private void viewProjectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewProject viewProject = new ViewProject();
            viewProject.Show();
        }

        private void assignUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AssignUser assignUser = new AssignUser();
            assignUser.Show();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {

        }

        private void bugsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void versionControlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VersionControl versionControl = new VersionControl();
            versionControl.Show();
        }
    }
}
