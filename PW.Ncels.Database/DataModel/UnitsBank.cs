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
    
    public partial class UnitsBank
    {
        public System.Guid Id { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.Guid UnitsId { get; set; }
        public Nullable<System.Guid> CurrencyId { get; set; }
        public string BankNameRu { get; set; }
        public string BankNameKz { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public string KBE { get; set; }
        public string Code { get; set; }
        public string SWIFT { get; set; }
        public string IIK { get; set; }
        public string CorrespondentBank { get; set; }
        public string CorrespondentAccount { get; set; }
        public string SWIFT1 { get; set; }
        public string CorrespondentAccount1 { get; set; }
        public string SWIFT2 { get; set; }
    }
}
