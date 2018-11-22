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
    public partial class ViewUser : MaterialForm
    {
        private AdminController admin;

        public ViewUser()
        {
            InitializeComponent();

            admin = new AdminController();

            tbl_users.DataSource = admin.retriveUser();
        }

        private void ViewUser_Load(object sender, EventArgs e)
        {

        }
    }
}
