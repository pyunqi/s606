//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KiwiBike4Rent
{
    using System;
    using System.Collections.Generic;
    
    public partial class MODEL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MODEL()
        {
            this.BIKEs = new HashSet<BIKE>();
        }
    
        public int ModelID { get; set; }
        public string Brand { get; set; }
        public string Category { get; set; }
        public string Dimension { get; set; }
        public double Weight { get; set; }
        public string Description { get; set; }
        public int Deposit { get; set; }
        public int Rate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BIKE> BIKEs { get; set; }
    }
}
