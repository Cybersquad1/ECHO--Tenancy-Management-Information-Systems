//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Echo.Data.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class MonthlyAssociationDue
    {
        public System.Guid ID { get; set; }
        public string UnitNumber { get; set; }
        public Nullable<System.DateTime> ChargeDate { get; set; }
        public Nullable<System.DateTime> DueDate { get; set; }
        public Nullable<decimal> AssociationDue { get; set; }
        public Nullable<decimal> WaterBillTotalDue { get; set; }
        public Nullable<decimal> Discounts { get; set; }
        public Nullable<decimal> Penalty { get; set; }
        public string OtherPenalty { get; set; }
        public Nullable<decimal> OtherPenaltyAmount { get; set; }
        public Nullable<decimal> TotalAmount { get; set; }
    
        public virtual UnitProfile UnitProfile { get; set; }
    }
}
