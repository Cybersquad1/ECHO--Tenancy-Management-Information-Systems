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
    
    public partial class UserProfile
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UserProfile()
        {
            this.LogSheet = new HashSet<LogSheet>();
            this.LogSheetActivity = new HashSet<LogSheetActivity>();
        }
    
        public System.Guid ID { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public System.DateTime DateOfBirth { get; set; }
        public string MaritalStatus { get; set; }
        public string HomeAddress { get; set; }
        public string ProvincialAddress { get; set; }
        public string Password { get; set; }
        public string MobileNo { get; set; }
        public string TelephoneNo { get; set; }
        public string Email { get; set; }
        public string ContactPerson { get; set; }
        public string ContactNo { get; set; }
        public string RelationshipToContact { get; set; }
        public byte[] ImageContent { get; set; }
        public string Status { get; set; }
        public string Type { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LogSheet> LogSheet { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LogSheetActivity> LogSheetActivity { get; set; }
    }
}
