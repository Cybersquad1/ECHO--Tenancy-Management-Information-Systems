//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Echo.Data.Repository
{
    using System;
    using System.Collections.Generic;
    
    public partial class Reservation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Reservation()
        {
            this.PaymentHistory = new HashSet<PaymentHistory>();
        }
    
        public System.Guid ID { get; set; }
        public string Facility { get; set; }
        public string UnitNumber { get; set; }
        public string Purpose { get; set; }
        public System.DateTime DateOfFuntion { get; set; }
        public string NoOfGuest { get; set; }
        public string Time { get; set; }
        public string ContactNo { get; set; }
        public System.DateTime Date { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<decimal> Balance { get; set; }
        public Nullable<decimal> Paid { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PaymentHistory> PaymentHistory { get; set; }
    }
}