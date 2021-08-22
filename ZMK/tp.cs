namespace ZMK
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("zmk.tp")]
    public partial class tp
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tp()
        {
            operation = new HashSet<operation>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        public int projectStage_id { get; set; }

        [Required]
        [StringLength(300)]
        public string description { get; set; }

        public int jobTitle_id { get; set; }

        public int workType_id { get; set; }

        public virtual ctlg_job_title ctlg_job_title { get; set; }

        public virtual ctlg_work_type ctlg_work_type { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<operation> operation { get; set; }

        public virtual project_structure project_structure { get; set; }
    }
}
