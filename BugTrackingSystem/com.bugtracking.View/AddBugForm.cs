using BugTrackingSystem.com.bugtracking.Controller;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugTrackingSystem.com.bugtracking.View
{
    public partial class AddBugForm : MaterialForm
    {
        private MemoryStream memory = new MemoryStream();
        private PictureBox pictureBox = new PictureBox();
        private int project_id, user_id;

        public AddBugForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_bug_desc_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cmb_severity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_add_bug_Click(object sender, EventArgs e)
        {
            pictureBox.Image.Save(memory, pictureBox.Image.RawFormat);
            byte[] img = memory.ToArray();

            String state, severity, bug_sourcecode;

            bug_sourcecode = txt_bug_code.Text;
            state = cmb_bug_state.GetItemText(this.cmb_bug_state.SelectedItem);
            severity = cmb_severity.GetItemText(this.cmb_severity.SelectedItem);

            UserController userController = new UserController();
            userController.insertBug(bug_sourcecode, img, state, severity, project_id, Global.User_id);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void AddBugForm_Load(object sender, EventArgs e)
        {

        }

        private void txt_pic_name_Click(object sender, EventArgs e)
        {

        }

        private void txt_bug_desc_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {

        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Choose image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                txt_pic_name.Text = System.IO.Path.GetFileName(openFile.FileName);
            }
        }
    }
}
