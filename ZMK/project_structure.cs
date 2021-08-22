namespace ZMK
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("zmk.project_structure")]
    public partial class project_structure
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public project_structure()
        {
            project_structure1 = new HashSet<project_structure>();
            tp = new HashSet<tp>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        public int projectMeta_id { get; set; }

        public int? nextNode_id { get; set; }

        public int projectStage_id { get; set; }

        public virtual ctlg_project_stage ctlg_project_stage { get; set; }

        public virtual project_meta project_meta { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<project_structure> project_structure1 { get; set; }

        public virtual project_structure project_structure2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tp> tp { get; set; }
    }
}
