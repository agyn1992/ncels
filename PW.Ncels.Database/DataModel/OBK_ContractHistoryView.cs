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
    
    public partial class OBK_ContractHistoryView
    {
        public System.Guid Id { get; set; }
        public System.DateTime Created { get; set; }
        public System.Guid EmployeeId { get; set; }
        public string UnitName { get; set; }
        public System.Guid StatusId { get; set; }
        public string RefuseReason { get; set; }
        public System.Guid ContractId { get; set; }
        public string EmployeeFullName { get; set; }
        public string EmployeeShortName { get; set; }
        public string StatusCode { get; set; }
        public string StatusNameRu { get; set; }
        public string StatusNameKz { get; set; }
    }
}
