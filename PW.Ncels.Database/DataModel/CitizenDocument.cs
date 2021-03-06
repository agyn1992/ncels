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
    
    public partial class CitizenDocument
    {
        public System.Guid Id { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsAdministrativeUse { get; set; }
        public bool IsAwaitingResponse { get; set; }
        public bool IsTradeSecret { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<System.DateTime> AwaitingResponseDate { get; set; }
        public Nullable<System.DateTime> DocumentDate { get; set; }
        public Nullable<System.DateTime> OutgoingDate { get; set; }
        public Nullable<System.DateTime> ProtocolDate { get; set; }
        public Nullable<System.DateTime> MonitoringDate { get; set; }
        public int ApplicantType { get; set; }
        public int DocumentType { get; set; }
        public int MonitoringType { get; set; }
        public int PriorityType { get; set; }
        public int StateType { get; set; }
        public int AppendixCount { get; set; }
        public int CopiesCount { get; set; }
        public int PageCount { get; set; }
        public int RepeatCount { get; set; }
        public string ApplicantAddress { get; set; }
        public string ApplicantEmail { get; set; }
        public string ApplicantName { get; set; }
        public string ApplicantPhone { get; set; }
        public string BlankNumber { get; set; }
        public string CorrespondentsInfo { get; set; }
        public string Number { get; set; }
        public string OutgoingNumber { get; set; }
        public string SortingNumber { get; set; }
        public string SortingOutgoingNumber { get; set; }
        public string Note { get; set; }
        public string Summary { get; set; }
        public string AdministrativeTypeDictionaryValue { get; set; }
        public string ApplicantCategoryDictionaryValue { get; set; }
        public string CauseCitizenDictionaryValue { get; set; }
        public string CitizenCategoryDictionaryValue { get; set; }
        public string CitizenResultDictionaryValue { get; set; }
        public string CitizenTypeDictionaryValue { get; set; }
        public string DocumentKindDictionaryValue { get; set; }
        public string FormDeliveryDictionaryValue { get; set; }
        public string FormSendingDictionaryValue { get; set; }
        public string KatoDictionaryValue { get; set; }
        public string LanguageDictionaryValue { get; set; }
        public string NomenclatureDictionaryValue { get; set; }
        public string QuestionDesignDictionaryValue { get; set; }
        public string SigningFormDictionaryValue { get; set; }
        public string AgreementsValue { get; set; }
        public string ExecutorsValue { get; set; }
        public string ReadersValue { get; set; }
        public string RecipientsValue { get; set; }
        public string RegistratorValue { get; set; }
        public string ResponsibleValue { get; set; }
        public string SignerValue { get; set; }
        public string CorrespondentsValue { get; set; }
        public string MonitoringAuthorValue { get; set; }
        public string MonitoringNote { get; set; }
        public string AnswersValue { get; set; }
        public string CompleteDocumentsValue { get; set; }
        public string EditDocumentsValue { get; set; }
        public string RepealDocumentsValue { get; set; }
        public string DisplayName { get; set; }
        public string AutoAnswersValue { get; set; }
        public string AutoAnswersTempValue { get; set; }
        public string AutoCompleteDocumentsValue { get; set; }
        public string AutoEditDocumentsValue { get; set; }
        public string AutoRepealDocumentsValue { get; set; }
        public int SortNumber { get; set; }
        public Nullable<System.DateTime> AutoAwaitingResponseDate { get; set; }
        public Nullable<System.DateTime> AutoDocumentDate { get; set; }
        public Nullable<System.DateTime> AutoOutgoingDate { get; set; }
        public Nullable<System.DateTime> AutoProtocolDate { get; set; }
        public Nullable<System.DateTime> AutoMonitoringDate { get; set; }
        public Nullable<System.DateTime> FactExecutionDate { get; set; }
        public Nullable<System.DateTime> FirstExecutionDate { get; set; }
        public Nullable<System.DateTime> ExecutionDate { get; set; }
        public Nullable<System.DateTime> AutoFactExecutionDate { get; set; }
        public Nullable<System.DateTime> AutoFirstExecutionDate { get; set; }
        public Nullable<System.DateTime> AutoExecutionDate { get; set; }
        public string Counters { get; set; }
        public string DocumentDictionaryTypeValue { get; set; }
        public string ResolutionValue { get; set; }
        public int OutgoingType { get; set; }
        public string SourceValue { get; set; }
        public string DestinationValue { get; set; }
        public string OwnerValue { get; set; }
        public string Country { get; set; }
        public string Area { get; set; }
        public string Postcode { get; set; }
        public string Phone { get; set; }
        public string Department { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string NumberBill { get; set; }
        public string Email { get; set; }
        public Nullable<System.Guid> SuperMainDocumentId { get; set; }
        public string ModifiedUser { get; set; }
        public bool IsNotification { get; set; }
        public int NotificationCount { get; set; }
        public Nullable<System.DateTime> DateDispatch { get; set; }
        public string DispatchNote { get; set; }
        public string Digest { get; set; }
        public bool IsAttachments { get; set; }
        public string Text { get; set; }
        public string Recipient { get; set; }
        public byte[] QrCode { get; set; }
        public bool IsArchive { get; set; }
        public Nullable<System.DateTime> FulfilledDate { get; set; }
        public string State { get; set; }
        public string Monitoring { get; set; }
        public string Priority { get; set; }
    }
}
