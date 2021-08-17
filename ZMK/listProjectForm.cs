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
            setIndexes();


            if (grid_projects.Rows.Count > 0)
            {
                int index = grid_projects.Rows.GetFirstRow(DataGridViewElementStates.Visible);
                if(index != -1)
                    grid_projects.Rows[index].Selected = true;
            }
        }

        
        private void setIndexes()
        {
            foreach (DataGridViewRow row in grid_projects.Rows)
                row.Cells[0].Value = row.Index + 1;
        }

        private void grid_projects_SelectionChanged(object sender, EventArgs e)
        {
            if (grid_projects.SelectedRows.Count > 0)
            {
                gb_projectProps.Visible = true;

                zmkDataSet.ProjectSetRow row = (ZMK.zmkDataSet.ProjectSetRow)zmkDataSet.ProjectSet.Rows[grid_projects.SelectedRows[0].Index];
                tb_describe_project.Text = row.description;
                lb_create_date.Text = row.create_time.ToString();
                gb_projectProps.Text = row.name;
            }
            else
                gb_projectProps.Visible = false;
        }

        private async void  btn_addProject_Click(object sender, EventArgs e)
        {
            ProjectSet project = new ProjectSet();
            DialogResult result = (new addProjectForm(project) { 
                Owner = this,
                StartPosition = FormStartPosition.CenterParent
            }).ShowDialog();
            
            if (result == DialogResult.OK)
            {
                using (var context = new zmkContext())
                {
                    context.ProjectSet.Add(project);
                    await context.SaveChangesAsync();
                }
            }
            
            projectSetTableAdapter.Fill(zmkDataSet.ProjectSet);
            grid_projects.Refresh();
        }

        private async void btn_removeProject_Click(object sender, EventArgs e)
        {
            if (grid_projects.SelectedRows.Count > 0) {
                DialogResult dialogResult = MessageBox.Show("Вы уверены что хотите удалить проект '" + grid_projects.SelectedRows[0].Cells[1].Value +
                    "'?", "Удалить проект", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    using (var context = new zmkContext())
                    {
                        context.Database.ExecuteSqlCommand("delete from ProjectSet where Id = " + (int) grid_projects.SelectedRows[0].Cells[3].Value);
                        await context.SaveChangesAsync();
                        int removedRowIndex = grid_projects.SelectedRows[0].Index;
                        grid_projects.ClearSelection();
                        grid_projects.Rows.RemoveAt(removedRowIndex);
                    }
                }
            }
        }

        private void grid_projects_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            setIndexes();
        }

        private void grid_projects_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            setIndexes();
        }
    }
}
