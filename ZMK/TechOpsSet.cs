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
    
    public partial class TechOpsSet
    {
        public long Id { get; set; }
        public string Description { get; set; }
        public int LaborObjectsId { get; set; }
        public int InstrumentId { get; set; }
        public long TPId { get; set; }
        public long TimeNormId { get; set; }
    
        public virtual InstrumentSet InstrumentSet { get; set; }
        public virtual LaborObjectsSet LaborObjectsSet { get; set; }
        public virtual TimeNormSet TimeNormSet { get; set; }
        public virtual TPSet TPSet { get; set; }
    }
}
