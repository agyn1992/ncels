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
    
    public partial class PP_ProtocolListView
    {
        public System.Guid Id { get; set; }
        public Nullable<bool> HasEdit { get; set; }
        public System.DateTime ProtocolDate { get; set; }
        public string Number { get; set; }
        public Nullable<bool> IsFinal { get; set; }
        public int Type { get; set; }
        public string TypeName { get; set; }
        public Nullable<System.Guid> UserId { get; set; }
        public string OwnerName { get; set; }
        public string RequesterName { get; set; }
        public int Status { get; set; }
        public string StatusName { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<System.Guid> ChiefId { get; set; }
    }
}
