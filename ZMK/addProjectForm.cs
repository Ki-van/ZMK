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
        public addProjectForm()
        {
            InitializeComponent();
        }

        private void btn_addProject_Click(object sender, EventArgs e)
        {
            if (tb_name.Text != null)
            {
                using (var context = new zmkContext())
                {
                    context.ProjectSet.Add(new ProjectSet
                    {
                        name = tb_name.Text,
                        description = tb_description.Text,
                        create_time = DateTime.Now,
                        update_time = DateTime.Now
                    });
                    context.SaveChanges();
                }


                this.Close();
            } else
                MessageBox.Show("Заполните поле Название", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
