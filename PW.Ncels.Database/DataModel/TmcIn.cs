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
    
    public partial class TmcIn
    {
        public System.Guid Id { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.Guid CreatedEmployeeId { get; set; }
        public int StateType { get; set; }
        public Nullable<System.Guid> OwnerEmployeeId { get; set; }
        public string Provider { get; set; }
        public string ContractNumber { get; set; }
        public Nullable<System.DateTime> ContractDate { get; set; }
        public Nullable<System.DateTime> LastDeliveryDate { get; set; }
        public bool IsFullDelivery { get; set; }
        public string PowerOfAttorney { get; set; }
        public string ProviderBin { get; set; }
        public Nullable<System.Guid> ExecutorEmployeeId { get; set; }
        public Nullable<System.Guid> AgreementEmployeeId { get; set; }
        public bool IsScan { get; set; }
        public Nullable<System.Guid> AccountantEmployeeId { get; set; }
    }
}
