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
    
    public partial class PetsProfile
    {
        public System.Guid ID { get; set; }
        public string Quantity { get; set; }
        public string Type { get; set; }
        public string Breed { get; set; }
        public string Name { get; set; }
        public Nullable<System.Guid> TenantProfileID { get; set; }
    
        public virtual TenantProfile TenantProfile { get; set; }
    }
}