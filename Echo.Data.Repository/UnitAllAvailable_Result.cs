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
    
    public partial class UnitAllAvailable_Result
    {
        public string UnitNumber { get; set; }
        public Nullable<System.DateTime> StartOfOccupancy { get; set; }
        public Nullable<System.DateTime> ExpectedEndOfOccupancy { get; set; }
        public string NatureOfOccupancy { get; set; }
        public string Type { get; set; }
        public string Floor { get; set; }
        public string OwnerFirstName { get; set; }
        public string OwnerLastName { get; set; }
        public string TenantFirstName { get; set; }
        public string TenantLastName { get; set; }
    }
}