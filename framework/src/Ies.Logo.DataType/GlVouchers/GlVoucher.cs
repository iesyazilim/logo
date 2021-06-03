using System;
using System.Collections.Generic;
using Ies.Logo.Core;
using Ies.Logo.DataType.AggregateRoot;
using Ies.Logo.DataType.Infrastructure;

namespace Ies.Logo.DataType.GlVouchers
{
    [Serializable]
    public class GlVoucher : AuditedAggregateRoot, ISpecialCode, IDivision, IDepartment, INotes, ICancelled, IDataSiteId, IApprove, IDataNo
    {
        public static LogoObjectType XmlRoot => LogoObjectType.GL_VOUCHERS;

        public virtual Nullable<int> Type{ get; set; }
        public virtual string Number{ get; set; }
        public virtual Nullable<DateTime> Date{ get; set; }
        public virtual string DocNumber{ get; set; }
        public virtual Nullable<int> Sourceref{ get; set; }
        public virtual Nullable<int> JournalNr{ get; set; }
        public virtual Nullable<decimal> TotalDebit{ get; set; }
        public virtual Nullable<decimal> TotalCredit{ get; set; }
        public virtual Nullable<int> PrintCounter{ get; set; }
        public virtual Nullable<DateTime> PrintDate{ get; set; }
        public virtual Nullable<int> SourceModule{ get; set; }
        public virtual Nullable<decimal> EuroTotalDebit{ get; set; }
        public virtual Nullable<decimal> EuroTotalCredit{ get; set; }
        public virtual Nullable<int> CurrselTotals{ get; set; }
        public virtual Nullable<int> CurrselDetails{ get; set; }
        public virtual Nullable<decimal> RcTotalDebit{ get; set; }
        public virtual Nullable<decimal> RcTotalCredit{ get; set; }
        public virtual Nullable<int> Status{ get; set; }
        public virtual Nullable<int> BdgtFicheType{ get; set; }
        public virtual Nullable<int> BdgtFicheRef { get; set; }
        public virtual Nullable<int> FromDemType{ get; set; }
        public virtual Nullable<int> EmDemFicheRef { get; set; }
        public virtual Nullable<int> Wflowcrdref{ get; set; }
        public virtual Nullable<short> ViaAutoGl{ get; set; }
        public virtual Nullable<DateTime> DocDate{ get; set; }
        public virtual Nullable<short> ImportDistSlip{ get; set; }
        public virtual Nullable<DateTime> EbookDocdate { get; set; }
        public virtual Nullable<short> EbookNodocument{ get; set; }
        public virtual string EbookDocnr{ get; set; }
        public virtual Nullable<int> EbookDoctype{ get; set; }
        public virtual string EbookExplain{ get; set; }
        public virtual string EbookPaytype{ get; set; }
        public virtual Nullable<short> EbookNopay{ get; set; }
        public virtual Nullable<short> Linebaseddocdet  { get; set; }
        public virtual Nullable<short> CrossFlag{ get; set; }
        public virtual Nullable<int> CrossFicheref{ get; set; }
        public virtual Nullable<short> DocType { get; set; }

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
        public virtual Nullable<short> Approve { get; set; }
        public virtual Nullable<DateTime> ApproveDate { get; set; }
        public string DataNumber { get => Number; set => Number = value; }
        #endregion

        #region SubClasses
        public virtual List<DistDetail> DetList { get; set; }
        public virtual List<Transaction> Transactions { get; set; }
        #endregion
    }
}
