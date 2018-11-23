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
    public partial class ViewBugs : MaterialForm
    {
        private UserController userController;

        public ViewBugs()
        {
            InitializeComponent();

            userController = new UserController();

            tbl_view_bugs.DataSource = userController.retriveBugs();
            Console.WriteLine(tbl_view_bugs.SelectedRows.Count);
            Console.WriteLine(tbl_view_bugs.SelectedColumns.Count);
        }

        private void tbl_view_bugs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int bug_id = 0;

            this.Hide();

            BugDetailsForm bugDetails = new BugDetailsForm(bug_id);
            bugDetails.Show();
        }

        private void AssignedBugsForm_Load(object sender, EventArgs e)
        {
        }
    }
}
