using System;
using System.Collections.Generic;
using Ies.Logo.DataType.AggregateRoot;
using Ies.Logo.DataType.DefinitionFields;
using Ies.Logo.DataType.Infrastructure;

namespace Ies.Logo.DataType.BankVouchers
{
    [Serializable]
    public class BankVoucher : AuditedAggregateRoot, ISpecialCode, IDivision, IDepartment, ICancelled, INotes, IDataSiteId, IProjectCode, IApprove
    {
        public static string XmlRoot => "BANK_VOUCHERS";

        public virtual Nullable<DateTime> Date { get; set; }
        public virtual string Number { get; set; }
        public virtual Nullable<int> Type { get; set; }
        public virtual Nullable<int> Sign { get; set; }
        public virtual Nullable<decimal> TotalDebit{ get; set; }
        public virtual Nullable<decimal> TotalCredit{ get; set; }
        public virtual Nullable<int> PrintCounter{ get; set; }
        public virtual Nullable<int> Accficheref{ get; set; }
        public virtual Nullable<int> CurrselTotals{ get; set; }
        public virtual Nullable<int> CurrselDetails{ get; set; }
        public virtual Nullable<decimal> RcTotalDebit{ get; set; }
        public virtual Nullable<decimal> RcTotalCredit{ get; set; }
        public virtual Nullable<DateTime> Trangrpdate{ get; set; }
        public virtual string BankaccCode{ get; set; }
        public virtual string Trangrpno{ get; set; }
        public virtual Nullable<int> Bncreref { get; set; }
        public virtual string BankCreditCode{ get; set; }
        public virtual Nullable<int> CrcardWizard{ get; set; }
        public virtual Nullable<int> AccFicheSiteid{ get; set; }
        public virtual Nullable<int> CollatrlCardRef{ get; set; }
        public virtual Nullable<int> CollatrlCardSiteid{ get; set; }
        public virtual string SalesmanCode{ get; set; }
        public virtual Nullable<int> CrcardFicheref{ get; set; }
        public virtual Nullable<short> CancelAutoGlProc{ get; set; }

        #region Implementation
        public virtual string AuthCode { get; set; }
        public virtual string AuxilCode { get; set; }
        public virtual Nullable<short> Division { get; set; }
        public virtual Nullable<short> Department { get; set; }
        public virtual Nullable<short> Cancelled { get; set; }
        public virtual string Notes1 { get; set; }
        public virtual string Notes2 { get; set; }
        public virtual string Notes3 { get; set; }
        public virtual string Notes4 { get; set; }
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
