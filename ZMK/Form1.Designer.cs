
namespace ZMK
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.grid_projects = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatetimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.grid_projects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zmkDataSet)).BeginInit();
            this.gb_projectProps.SuspendLayout();
            this.SuspendLayout();
            // 
            // grid_projects
            // 
            this.grid_projects.AllowUserToAddRows = false;
            this.grid_projects.AllowUserToDeleteRows = false;
            this.grid_projects.AllowUserToOrderColumns = true;
            this.grid_projects.AutoGenerateColumns = false;
            this.grid_projects.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grid_projects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_projects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.updatetimeDataGridViewTextBoxColumn});
            this.grid_projects.DataSource = this.projectSetBindingSource;
            this.grid_projects.Location = new System.Drawing.Point(17, 92);
            this.grid_projects.MultiSelect = false;
            this.grid_projects.Name = "grid_projects";
            this.grid_projects.ReadOnly = true;
            this.grid_projects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_projects.Size = new System.Drawing.Size(344, 346);
            this.grid_projects.TabIndex = 0;
            this.grid_projects.SelectionChanged += new System.EventHandler(this.grid_projects_SelectionChanged);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.nameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.nameDataGridViewTextBoxColumn.HeaderText = "Название";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 200;
            // 
            // updatetimeDataGridViewTextBoxColumn
            // 
            this.updatetimeDataGridViewTextBoxColumn.DataPropertyName = "update_time";
            this.updatetimeDataGridViewTextBoxColumn.HeaderText = "Последнее обновление";
            this.updatetimeDataGridViewTextBoxColumn.Name = "updatetimeDataGridViewTextBoxColumn";
            this.updatetimeDataGridViewTextBoxColumn.ReadOnly = true;
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
            // 
            // btn_addProject
            // 
            this.btn_addProject.Image = global::ZMK.Properties.Resources.plus_24;
            this.btn_addProject.Location = new System.Drawing.Point(17, 51);
            this.btn_addProject.Name = "btn_addProject";
            this.btn_addProject.Size = new System.Drawing.Size(35, 35);
            this.btn_addProject.TabIndex = 2;
            this.btn_addProject.UseVisualStyleBackColor = true;
            // 
            // projectSetTableAdapter
            // 
            this.projectSetTableAdapter.ClearBeforeFill = true;
            // 
            // gb_projectProps
            // 
            this.gb_projectProps.Controls.Add(this.lb_create_date);
            this.gb_projectProps.Controls.Add(this.tb_describe_project);
            this.gb_projectProps.Controls.Add(this.label4);
            this.gb_projectProps.Controls.Add(this.label2);
            this.gb_projectProps.Location = new System.Drawing.Point(368, 92);
            this.gb_projectProps.Name = "gb_projectProps";
            this.gb_projectProps.Size = new System.Drawing.Size(420, 346);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gb_projectProps);
            this.Controls.Add(this.btn_removeProject);
            this.Controls.Add(this.btn_addProject);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grid_projects);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "ЗМК24";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_projects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zmkDataSet)).EndInit();
            this.gb_projectProps.ResumeLayout(false);
            this.gb_projectProps.PerformLayout();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updatetimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox gb_projectProps;
        private System.Windows.Forms.Label lb_create_date;
        private System.Windows.Forms.TextBox tb_describe_project;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
    }
}

