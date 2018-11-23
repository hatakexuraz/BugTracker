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
    public partial class ViewProject : MaterialForm
    {
        AdminController admin = new AdminController();

        public ViewProject()
        {
            InitializeComponent();

            tbl_projects.DataSource = admin.retriveProjects();
        }

        private void ViewProject_Load(object sender, EventArgs e)
        {

        }

        private void tbl_projects_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
