﻿using System;
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
    public partial class Dashboard : Form
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
            AssignedBugsForm assignedBugs = new AssignedBugsForm();
            assignedBugs.Show();
        }
    }
}
