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
    
    public partial class PriceProjectsHistory
    {
        public long Id { get; set; }
        public Nullable<System.Guid> UserId { get; set; }
        public System.DateTime DateCreate { get; set; }
        public bool IsDelete { get; set; }
        public int StatusId { get; set; }
        public string Note { get; set; }
        public System.Guid PriceProjectId { get; set; }
        public string XmlSign { get; set; }
    
        public virtual Employee Employee { get; set; }
        public virtual PriceProject PriceProject { get; set; }
    }
}