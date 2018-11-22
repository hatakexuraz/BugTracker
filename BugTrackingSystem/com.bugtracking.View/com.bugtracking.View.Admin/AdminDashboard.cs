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
    }
}
