using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ZMK
{
    public partial class zmk : DbContext
    {
        public zmk()
            : base("name=zmk")
        {
        }

        public virtual DbSet<ctlg_instrument> ctlg_instrument { get; set; }
        public virtual DbSet<ctlg_job_title> ctlg_job_title { get; set; }
        public virtual DbSet<ctlg_labor_object> ctlg_labor_object { get; set; }
        public virtual DbSet<ctlg_project_stage> ctlg_project_stage { get; set; }
        public virtual DbSet<ctlg_time_norm> ctlg_time_norm { get; set; }
        public virtual DbSet<ctlg_work_type> ctlg_work_type { get; set; }
        public virtual DbSet<operation> operation { get; set; }
        public virtual DbSet<project_meta> project_meta { get; set; }
        public virtual DbSet<project_structure> project_structure { get; set; }
        public virtual DbSet<tp> tp { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ctlg_instrument>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<ctlg_instrument>()
                .HasMany(e => e.operation)
                .WithRequired(e => e.ctlg_instrument)
                .HasForeignKey(e => e.instrument_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ctlg_job_title>()
                .Property(e => e.title)
                .IsUnicode(false);

            modelBuilder.Entity<ctlg_job_title>()
                .HasMany(e => e.tp)
                .WithRequired(e => e.ctlg_job_title)
                .HasForeignKey(e => e.jobTitle_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ctlg_labor_object>()
                .Property(e => e.object_name)
                .IsUnicode(false);

            modelBuilder.Entity<ctlg_labor_object>()
                .HasMany(e => e.operation)
                .WithRequired(e => e.ctlg_labor_object)
                .HasForeignKey(e => e.laborObject_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ctlg_project_stage>()
                .Property(e => e.stage_name)
                .IsUnicode(false);

            modelBuilder.Entity<ctlg_project_stage>()
                .HasMany(e => e.project_structure)
                .WithRequired(e => e.ctlg_project_stage)
                .HasForeignKey(e => e.projectStage_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ctlg_time_norm>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<ctlg_time_norm>()
                .HasMany(e => e.operation)
                .WithRequired(e => e.ctlg_time_norm)
                .HasForeignKey(e => e.timeNorm_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ctlg_work_type>()
                .Property(e => e.type_name)
                .IsUnicode(false);

            modelBuilder.Entity<ctlg_work_type>()
                .HasMany(e => e.tp)
                .WithRequired(e => e.ctlg_work_type)
                .HasForeignKey(e => e.workType_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<operation>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<project_meta>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<project_meta>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<project_meta>()
                .Property(e => e._params)
                .IsUnicode(false);

            modelBuilder.Entity<project_meta>()
                .HasMany(e => e.project_structure)
                .WithRequired(e => e.project_meta)
                .HasForeignKey(e => e.projectMeta_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<project_structure>()
                .HasMany(e => e.project_structure1)
                .WithOptional(e => e.project_structure2)
                .HasForeignKey(e => e.nextNode_id);

            modelBuilder.Entity<project_structure>()
                .HasMany(e => e.tp)
                .WithRequired(e => e.project_structure)
                .HasForeignKey(e => e.projectStage_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tp>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<tp>()
                .HasMany(e => e.operation)
                .WithRequired(e => e.tp)
                .HasForeignKey(e => e.tp_id)
                .WillCascadeOnDelete(false);
        }
    }
}
