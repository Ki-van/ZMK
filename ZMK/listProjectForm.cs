using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZMK
{
    public partial class listProjectForm : Form
    {
        public listProjectForm()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'zmkDataSet.ProjectSet' table. You can move, or remove it, as needed.
            this.projectSetTableAdapter.Fill(this.zmkDataSet.ProjectSet);



            if (grid_projects.Rows[0] != null)
            {
                grid_projects.Rows[0].Selected = true;
                describeProject();
                setIndexes();
            }

        }

        private void describeProject()
        {
           
            if (grid_projects.SelectedRows.Count > 0)
            {
                if (gb_projectProps.Visible == false)
                    gb_projectProps.Visible = true;

                zmkDataSet.ProjectSetRow row = (ZMK.zmkDataSet.ProjectSetRow)zmkDataSet.ProjectSet.Rows[grid_projects.SelectedRows[0].Index];
                tb_describe_project.Text = row.description;
                lb_create_date.Text = row.create_time.ToString();
                gb_projectProps.Text = row.name;
            }
        }
        
        private void setIndexes()
        {
            foreach (DataGridViewRow row in grid_projects.Rows)
                row.Cells[0].Value = row.Index + 1;
        }

        private void grid_projects_SelectionChanged(object sender, EventArgs e)
        {
            describeProject();
        }

        private void btn_addProject_Click(object sender, EventArgs e)
        {
            (new addProjectForm() { 
                Owner = this,
                StartPosition = FormStartPosition.CenterParent
            }).ShowDialog();
            projectSetTableAdapter.Fill(zmkDataSet.ProjectSet);
            grid_projects.Refresh();
        }
    }
}
