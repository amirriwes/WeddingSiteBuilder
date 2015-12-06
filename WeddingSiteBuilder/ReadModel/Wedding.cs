//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WeddingSiteBuilder.ReadModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Wedding
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Wedding()
        {
            this.Attendees = new HashSet<Attendee>();
            this.Ceremonies = new HashSet<Ceremony>();
            this.Hotels = new HashSet<Hotel>();
            this.Photos = new HashSet<Photo>();
            this.Receptions = new HashSet<Reception>();
            this.Registries = new HashSet<Registry>();

            CreateDate = DateTime.Now;
            LastUpdated = DateTime.Now;
            DestinationWedding = false;
        }
    
        public long WeddingID { get; set; }
        public bool DestinationWedding { get; set; }
        public string CoupleStory { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime LastUpdated { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Attendee> Attendees { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ceremony> Ceremonies { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Hotel> Hotels { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Photo> Photos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reception> Receptions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Registry> Registries { get; set; }
    }
}
