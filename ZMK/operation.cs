namespace ZMK
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("zmk.operation")]
    public partial class operation
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [Required]
        [StringLength(200)]
        public string description { get; set; }

        public int laborObject_id { get; set; }

        public int instrument_id { get; set; }

        public int timeNorm_id { get; set; }

        public int tp_id { get; set; }

        public virtual ctlg_instrument ctlg_instrument { get; set; }

        public virtual ctlg_labor_object ctlg_labor_object { get; set; }

        public virtual ctlg_time_norm ctlg_time_norm { get; set; }

        public virtual tp tp { get; set; }
    }
}
