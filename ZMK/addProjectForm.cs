using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ZMK
{
    public partial class addProjectForm : Form
    {
        private ProjectSet project; 
        public addProjectForm(ProjectSet project)
        {
            this.project = project;
            InitializeComponent();
        }

        private void btn_addProject_Click(object sender, EventArgs e)
        {
            if (tb_name.Text != null)
            {
               project.name = tb_name.Text;
               project.description = tb_description.Text;
               project.create_time = DateTime.Now;
               project.update_time = DateTime.Now;
               this.DialogResult = DialogResult.OK;
               this.Close();
            } else
                MessageBox.Show("Заполните поле Название", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
