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
    public partial class AssignedBugsForm : MaterialForm
    {
        private UserController userController;

        public AssignedBugsForm()
        {
            InitializeComponent();

            userController = new UserController();

            tbl_view_bugs.DataSource = userController.retriveProject();
        }

        private void tbl_view_bugs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AssignedBugsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
