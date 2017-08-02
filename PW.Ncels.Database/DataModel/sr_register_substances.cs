//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PW.Ncels.Database.DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class sr_register_substances
    {
        public int id { get; set; }
        public int register_id { get; set; }
        public int substance_type_id { get; set; }
        public int substance_id { get; set; }
        public Nullable<decimal> substance_count { get; set; }
        public Nullable<long> measure_id { get; set; }
        public Nullable<int> producer_id { get; set; }
        public Nullable<long> country_id { get; set; }
        public Nullable<int> nd_type_id { get; set; }
        public string comment { get; set; }
    
        public virtual sr_register sr_register { get; set; }
        public virtual sr_substance_types sr_substance_types { get; set; }
        public virtual sr_substances sr_substances { get; set; }
        public virtual sr_nd_types sr_nd_types { get; set; }
    }
}