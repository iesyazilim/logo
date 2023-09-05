using Ies.Logo.Core;
using Ies.Logo.DataType.AggregateRoot;
using Ies.Logo.DataType.DefinitionFields;
using Ies.Logo.DataType.Dispatches;
using Ies.Logo.DataType.ImpoprFiche.EximLines;
using Ies.Logo.DataType.Infrastructure;
using Ies.Logo.DataType.Invoices;
using Ies.Logo.DataType.Payments;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ies.Logo.DataType.ImpoprFiche
{
    [Serializable]
    public class Impopr : AuditedAggregateRoot, ISpecialCode, ICancelled, INotes, IPaymentCode, IDivision, IDepartment, ITradingGroup, IDataSiteId, IFactory, IProjectCode, IApprove, IGlobalId
    {
        public static LogoObjectType XmlRoot => LogoObjectType.IMPOPRFICHE;

        public virtual Nullable<int> Type { get; set; }
        public virtual string Number { get; set; }
        public virtual Nullable<DateTime> Date { get; set; }
        public virtual Nullable<int> Time { get; set; }
        public virtual string DocNumber { get; set; }
        public virtual string ArpCode { get; set; }
        public virtual Nullable<short> GlPosted { get; set; }
        public virtual Nullable<short> PostFlags { get; set; }
        public virtual Nullable<decimal> TotalDiscounted { get; set; }
        public virtual Nullable<decimal> TotalGross { get; set; }
        public virtual Nullable<decimal> TotalNet { get; set; }
        public virtual Nullable<short> CurrInvoice { get; set; }
        public virtual Nullable<decimal> TcXrate { get; set; }
        public virtual Nullable<decimal> TcNet { get; set; }
        public virtual Nullable<decimal> RcXrate { get; set; }
        public virtual Nullable<decimal> RcNet { get; set; }
        public virtual Nullable<int> CurrselTotals { get; set; }
        public virtual Nullable<int> CurrselDetails { get; set; }
        public virtual Nullable<int> AccountedCnt { get; set; }
        public virtual Nullable<short> EximFicheType { get; set; }
        public virtual Nullable<short> EximGrpType { get; set; }
        public virtual Nullable<short> EximFcType { get; set; }
        public virtual string EximFileCode { get; set; }
        public virtual string EximFileName { get; set; }
        public virtual Nullable<short> EximCountryType { get; set; }
        public virtual string EximCountryCode { get; set; }
        public virtual string EximCustomDocNo { get; set; }
        public virtual Nullable<DateTime> EximCustomDocDate { get; set; }
        public virtual Nullable<short> EximFileLineNr { get; set; }
        public virtual Nullable<DateTime> EximDueDate { get; set; }
        public virtual Nullable<int> DeductionPart1 { get; set; }
        public virtual Nullable<int> DeductionPart2 { get; set; }
        public virtual string TotalNetStr { get; set; }
        public virtual string TrNetStr { get; set; }
        public virtual Nullable<int> ProfileId { get; set; }
        public virtual Nullable<int> Estatus { get; set; }
        public virtual Nullable<DateTime> DocDate { get; set; }

        #region Implementation
        public virtual string AuthCode { get; set; }
        public virtual string AuxilCode { get; set; }
        public virtual Nullable<short> Cancelled { get; set; }
        public virtual string Notes1 { get; set; }
        public virtual string Notes2 { get; set; }
        public virtual string Notes3 { get; set; }
        public virtual string Notes4 { get; set; }
        public virtual string PaymentCode { get; set; }
        public virtual Nullable<short> Division { get; set; }
        public virtual Nullable<short> Department { get; set; }
        public virtual Nullable<short> Factory { get; set; }
        public virtual string TradingGrp { get; set; }
        public virtual Nullable<int> DataSiteId { get; set; }
        public virtual string ProjectCode { get; set; }
        public virtual Nullable<short> Approve { get; set; }
        public virtual Nullable<DateTime> ApproveDate { get; set; }
        public virtual string GlobalId { get; set; }
        #endregion
        #region SubClasses
        public virtual List<EximLine> EximLines { get; set; }
        public virtual List<Payment> PaymentList { get; set; }
        public virtual List<Dispatch> Dispatches { get; set; }
        public virtual List<DefnFld> DefnFldsList { get; set; }
        #endregion
    }
}
