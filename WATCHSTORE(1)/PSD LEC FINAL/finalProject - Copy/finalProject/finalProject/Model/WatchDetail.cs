//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace finalProject.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class WatchDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WatchDetail()
        {
            this.Carts = new HashSet<Cart>();
            this.TransactionDetails = new HashSet<TransactionDetail>();
        }
    
        public int WatchDetailID { get; set; }
        public int WatchID { get; set; }
        public string WatchName { get; set; }
        public string WatchImage { get; set; }
        public int WatchPrice { get; set; }
        public int WatchStock { get; set; }
        public string WatchDescription { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cart> Carts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransactionDetail> TransactionDetails { get; set; }
        public virtual Watch Watch { get; set; }
    }
}
