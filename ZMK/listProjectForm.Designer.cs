
namespace ZMK
{
    partial class listProjectForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(listProjectForm));
            this.grid_projects = new System.Windows.Forms.DataGridView();
            this.index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatetimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zmkDataSet = new ZMK.zmkDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_removeProject = new System.Windows.Forms.Button();
            this.btn_addProject = new System.Windows.Forms.Button();
            this.projectSetTableAdapter = new ZMK.zmkDataSetTableAdapters.ProjectSetTableAdapter();
            this.gb_projectProps = new System.Windows.Forms.GroupBox();
            this.lb_create_date = new System.Windows.Forms.Label();
            this.tb_describe_project = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.grid_projects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zmkDataSet)).BeginInit();
            this.gb_projectProps.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grid_projects
            // 
            this.grid_projects.AllowUserToAddRows = false;
            this.grid_projects.AllowUserToDeleteRows = false;
            this.grid_projects.AllowUserToOrderColumns = true;
            this.grid_projects.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grid_projects.AutoGenerateColumns = false;
            this.grid_projects.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grid_projects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_projects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.index,
            this.nameDataGridViewTextBoxColumn,
            this.updatetimeDataGridViewTextBoxColumn,
            this.Id});
            this.grid_projects.DataSource = this.projectSetBindingSource;
            this.grid_projects.Location = new System.Drawing.Point(17, 92);
            this.grid_projects.MultiSelect = false;
            this.grid_projects.Name = "grid_projects";
            this.grid_projects.ReadOnly = true;
            this.grid_projects.RowHeadersVisible = false;
            this.grid_projects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_projects.Size = new System.Drawing.Size(505, 401);
            this.grid_projects.TabIndex = 0;
            this.grid_projects.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.grid_projects_RowsAdded);
            this.grid_projects.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.grid_projects_RowsRemoved);
            this.grid_projects.SelectionChanged += new System.EventHandler(this.grid_projects_SelectionChanged);
            // 
            // index
            // 
            this.index.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.index.HeaderText = "№";
            this.index.Name = "index";
            this.index.ReadOnly = true;
            this.index.Width = 43;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.nameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.nameDataGridViewTextBoxColumn.HeaderText = "Название";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // updatetimeDataGridViewTextBoxColumn
            // 
            this.updatetimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.updatetimeDataGridViewTextBoxColumn.DataPropertyName = "update_time";
            this.updatetimeDataGridViewTextBoxColumn.HeaderText = "Последнее обновление";
            this.updatetimeDataGridViewTextBoxColumn.Name = "updatetimeDataGridViewTextBoxColumn";
            this.updatetimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.updatetimeDataGridViewTextBoxColumn.Width = 138;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // projectSetBindingSource
            // 
            this.projectSetBindingSource.DataMember = "ProjectSet";
            this.projectSetBindingSource.DataSource = this.zmkDataSet;
            // 
            // zmkDataSet
            // 
            this.zmkDataSet.DataSetName = "zmkDataSet";
            this.zmkDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Проекты";
            // 
            // btn_removeProject
            // 
            this.btn_removeProject.Image = global::ZMK.Properties.Resources.minus_32;
            this.btn_removeProject.Location = new System.Drawing.Point(58, 51);
            this.btn_removeProject.Name = "btn_removeProject";
            this.btn_removeProject.Size = new System.Drawing.Size(35, 35);
            this.btn_removeProject.TabIndex = 3;
            this.btn_removeProject.UseVisualStyleBackColor = true;
            this.btn_removeProject.Click += new System.EventHandler(this.btn_removeProject_Click);
            // 
            // btn_addProject
            // 
            this.btn_addProject.Image = global::ZMK.Properties.Resources.plus_24;
            this.btn_addProject.Location = new System.Drawing.Point(17, 51);
            this.btn_addProject.Name = "btn_addProject";
            this.btn_addProject.Size = new System.Drawing.Size(35, 35);
            this.btn_addProject.TabIndex = 2;
            this.btn_addProject.UseVisualStyleBackColor = true;
            this.btn_addProject.Click += new System.EventHandler(this.btn_addProject_Click);
            // 
            // projectSetTableAdapter
            // 
            this.projectSetTableAdapter.ClearBeforeFill = true;
            // 
            // gb_projectProps
            // 
            this.gb_projectProps.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_projectProps.Controls.Add(this.lb_create_date);
            this.gb_projectProps.Controls.Add(this.tb_describe_project);
            this.gb_projectProps.Controls.Add(this.label4);
            this.gb_projectProps.Controls.Add(this.label2);
            this.gb_projectProps.Location = new System.Drawing.Point(528, 92);
            this.gb_projectProps.Name = "gb_projectProps";
            this.gb_projectProps.Size = new System.Drawing.Size(420, 401);
            this.gb_projectProps.TabIndex = 4;
            this.gb_projectProps.TabStop = false;
            this.gb_projectProps.Text = "groupBox1";
            this.gb_projectProps.Visible = false;
            // 
            // lb_create_date
            // 
            this.lb_create_date.AutoSize = true;
            this.lb_create_date.Location = new System.Drawing.Point(101, 154);
            this.lb_create_date.Name = "lb_create_date";
            this.lb_create_date.Size = new System.Drawing.Size(35, 13);
            this.lb_create_date.TabIndex = 4;
            this.lb_create_date.Text = "label3";
            // 
            // tb_describe_project
            // 
            this.tb_describe_project.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_describe_project.Location = new System.Drawing.Point(104, 19);
            this.tb_describe_project.Multiline = true;
            this.tb_describe_project.Name = "tb_describe_project";
            this.tb_describe_project.ReadOnly = true;
            this.tb_describe_project.Size = new System.Drawing.Size(310, 120);
            this.tb_describe_project.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Дата создания:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Описание: ";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 496);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(960, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(114, 17);
            this.toolStripStatusLabel1.Text = "StatusLabelLeftMost";
            // 
            // listProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 518);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.gb_projectProps);
            this.Controls.Add(this.btn_removeProject);
            this.Controls.Add(this.btn_addProject);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grid_projects);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "listProjectForm";
            this.Text = "ЗМК24";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_projects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zmkDataSet)).EndInit();
            this.gb_projectProps.ResumeLayout(false);
            this.gb_projectProps.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_projects;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_addProject;
        private System.Windows.Forms.Button btn_removeProject;
        private zmkDataSet zmkDataSet;
        private System.Windows.Forms.BindingSource projectSetBindingSource;
        private zmkDataSetTableAdapters.ProjectSetTableAdapter projectSetTableAdapter;
        private System.Windows.Forms.GroupBox gb_projectProps;
        private System.Windows.Forms.Label lb_create_date;
        private System.Windows.Forms.TextBox tb_describe_project;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn index;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updatetimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

