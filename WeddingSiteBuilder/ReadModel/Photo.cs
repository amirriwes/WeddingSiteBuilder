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
    
    public partial class Photo
    {
        public Nullable<long> WeddingID { get; set; }
        public long PhotoID { get; set; }
        public byte[] PhotoData { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime LastUpdated { get; set; }
    }
}
