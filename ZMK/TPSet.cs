//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ZMK
{
    using System;
    using System.Collections.Generic;
    
    public partial class TPSet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TPSet()
        {
            this.TechOpsSet = new HashSet<TechOpsSet>();
        }
    
        public long Id { get; set; }
        public string Description { get; set; }
        public int ManufacturingStepsId { get; set; }
        public int WorkTypeId { get; set; }
        public int JobTitleId { get; set; }
        public int ProjectId { get; set; }
    
        public virtual JobTitleSet JobTitleSet { get; set; }
        public virtual ManufacturingStepsSet ManufacturingStepsSet { get; set; }
        public virtual ProjectSet ProjectSet { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TechOpsSet> TechOpsSet { get; set; }
        public virtual WorkTypeSet WorkTypeSet { get; set; }
    }
}
