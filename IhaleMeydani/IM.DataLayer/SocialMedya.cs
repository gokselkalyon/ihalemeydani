//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IM.DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class SocialMedya
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<int> IconId { get; set; }
        public Nullable<int> MediaTypeId { get; set; }
    
        public virtual SocialMediaType SocialMediaType { get; set; }
    }
}
