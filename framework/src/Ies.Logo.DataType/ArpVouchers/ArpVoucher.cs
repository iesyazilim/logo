using System;
using System.Collections.Generic;
using Ies.Logo.DataType.AggregateRoot;
using Ies.Logo.DataType.DefinitionFields;
using Ies.Logo.DataType.Infrastructure;

namespace Ies.Logo.DataType.ArpVouchers
{
    [Serializable]
    public class ArpVoucher : AuditedAggregateRoot, IAuxilCode, IAuthCode, IDivision, IDepartment, INotes, ICancelled, IDataSiteId, IProjectCode, IApprove
    {
        public virtual string Number { get; set; }
        public virtual Nullable<DateTime> Date { get; set; }
        public virtual string DocNumber { get; set; }
        public virtual Nullable<int> Type { get; set; }
        public virtual Nullable<decimal> TotalDebit { get; set; }
        public virtual Nullable<decimal> TotalCredit { get; set; }
        public virtual Nullable<decimal> RcTotalDebit { get; set; }
        public virtual Nullable<decimal> RcTotalCredit { get; set; }
        public virtual Nullable<short> GlPosted { get; set; }
        public virtual string GlCode { get; set; }
        public virtual string OhpCode { get; set; }
        public virtual Nullable<int> PrintCounter { get; set; }
        public virtual Nullable<int> Accficheref { get; set; }
        public virtual Nullable<int> CurrselTotals { get; set; }
        public virtual Nullable<int> CurrselDetails { get; set; }
        public virtual string ArpCode { get; set; }
        public virtual Nullable<int> Time { get; set; }
        public virtual string BankaccCode { get; set; }
        public virtual string BnglCode { get; set; }
        public virtual string BnohpCode { get; set; }
        public virtual Nullable<short> AffectCollatrl { get; set; }
        public virtual Nullable<int> Status { get; set; }
        public virtual Nullable<short> Grpfirmtrans { get; set; }
        public virtual Nullable<short> AffectRisk { get; set; }
        public virtual string PosTerminalNr { get; set; }
        public virtual Nullable<int> AccFicheSiteid { get; set; }
        public virtual Nullable<DateTime> DocDate { get; set; }
        public virtual string SalesmanCode { get; set; }
        public virtual Nullable<short> CancelAutoGlProc { get; set; }
        public virtual Nullable<DateTime> EbookDocdate { get; set; }

        #region Implementation
        public virtual string AuthCode { get; set; }
        public virtual string AuxilCode { get; set; }
        public virtual Nullable<short> Division { get; set; }
        public virtual Nullable<short> Department { get; set; }
        public virtual string Notes1 { get; set; }
        public virtual string Notes2 { get; set; }
        public virtual string Notes3 { get; set; }
        public virtual string Notes4 { get; set; }
        public virtual Nullable<short> Cancelled { get; set; }
        public virtual Nullable<int> DataSiteId { get; set; }
        public virtual string ProjectCode { get; set; }
        public virtual Nullable<short> Approve { get; set; }
        public virtual Nullable<DateTime> ApproveDate { get; set; }
        #endregion

        #region SubClasses
        public virtual List<DefnFld> DefnFldsList { get; set; }
        public virtual List<Transaction> Transactions { get; set; }
        #endregion
    }
}
