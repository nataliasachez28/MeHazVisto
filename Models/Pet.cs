//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MeHazVisto.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Pet
    {
        public Pet()
        {
            this.PetPhotos = new HashSet<PetPhoto>();
        }
    
        public int PetID { get; set; }
        public string PetName { get; set; }
        public Nullable<int> PetAgeYears { get; set; }
        public Nullable<int> PetAgeMonths { get; set; }
        public int StatusID { get; set; }
        public Nullable<System.DateTime> LastSeenOn { get; set; }
        public string LastSeenWhere { get; set; }
        public string Notes { get; set; }
        public int UserId { get; set; }
    
        public virtual Status Status { get; set; }
        public virtual UserProfile UserProfile { get; set; }
        public virtual ICollection<PetPhoto> PetPhotos { get; set; }
    }
}
