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
    public partial class AddProject : MaterialForm
    {
        public AddProject()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string project_name;
            String startdate;
            String enddate;
            String projectDesc;
            int result = 0;

            project_name = txt_pro_name.Text;
            startdate = start_date.Value.ToString("yyyy-MM-dd");
            enddate = end_date.Value.ToString("yyyy-MM-dd");
            projectDesc = txt_pro_desc.Text;

            if (project_name.Equals("") || projectDesc.Equals(""))
            {
                MessageBox.Show("Please fill all fields.");
            }
            else
            {
                if (DateTime.Compare(DateTime.Parse(startdate), DateTime.Parse(enddate)) < 0)
                {
                    AdminController adminController = new AdminController();
                    result = adminController.addProject(project_name, startdate, enddate, projectDesc);

                    if (result != 0)
                    {
                        MessageBox.Show("Project added successfully.");
                        txt_pro_name.Text = "";
                        txt_pro_desc.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong.");
                    }
                }
                else
                {
                    MessageBox.Show("Start date cannot be later than end date.");
                }
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
