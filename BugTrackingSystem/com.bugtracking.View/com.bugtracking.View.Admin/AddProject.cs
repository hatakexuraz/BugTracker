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
    public partial class AddProject : Form
    {
        public AddProject()
        {
            InitializeComponent();

            cmb_startdate.Items.Add(DateTime.Now.ToString("dd/MM/yyyy hh:mm"));
        }
    }
}
