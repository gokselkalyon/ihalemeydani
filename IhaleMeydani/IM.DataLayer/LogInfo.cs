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
    
    public partial class LogInfo
    {
        public int Id { get; set; }
        public Nullable<int> UserId { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string Type { get; set; }
        public string ExceptionMessage { get; set; }
        public Nullable<int> LogStatusId { get; set; }
    }
}
