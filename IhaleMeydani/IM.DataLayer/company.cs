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
    
    public partial class company
    {
        public int Id { get; set; }
        public Nullable<int> company_type_id { get; set; }
        public string company_name { get; set; }
        public Nullable<int> city_id { get; set; }
        public Nullable<int> Tax_Administration_id { get; set; }
        public Nullable<int> county_id { get; set; }
        public Nullable<int> country_id { get; set; }
        public string Tax_number { get; set; }
        public string company_address { get; set; }
        public string tel { get; set; }
        public string ticaret_sicil_no { get; set; }
        public string mersis_no { get; set; }
        public Nullable<System.DateTime> DATE_OF_UPDATE { get; set; }
    }
}
