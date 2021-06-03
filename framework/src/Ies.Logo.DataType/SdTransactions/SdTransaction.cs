using System;
using Ies.Logo.Core;
using Ies.Logo.DataType.AggregateRoot;
using Ies.Logo.DataType.Infrastructure;

namespace Ies.Logo.DataType.SdTransactions
{
    [Serializable]
    public class SdTransaction : AuditedAggregateRoot, IDivision, IDepartment, ISpecialCode, ICancelled, IDataSiteId, ITradingGroup, IProjectCode, IApprove, IDataNo
    {
        public static LogoObjectType XmlRoot => LogoObjectType.SD_TRANSACTIONS;

        public virtual Nullable<int> Type { get; set; }
        public virtual string SdCode { get; set; }
        public virtual string SdCodeCross { get; set; }
        public virtual string SdNumberCross { get; set; }
        public virtual Nullable<int> CrossDataReference { get; set; }
        public virtual string GlCode1 { get; set; }
        public virtual string OhpCode1 { get; set; }
        public virtual string GlCode2 { get; set; }
        public virtual string OhpCode2 { get; set; }
        public virtual Nullable<DateTime> Date { get; set; }
        public virtual Nullable<int> Time { get; set; }
        public virtual Nullable<int> Hour { get; set; }
        public virtual Nullable<int> Minute { get; set; }
        public virtual Nullable<int> DestDivision { get; set; }
        public virtual Nullable<int> DestDepartment { get; set; }
        public virtual string Number { get; set; }
        public virtual string MasterTitle { get; set; }
        public virtual string Description { get; set; }
        public virtual Nullable<decimal> Amount { get; set; }
        public virtual Nullable<int> Sign { get; set; }
        public virtual Nullable<decimal> RcXrate { get; set; }
        public virtual Nullable<decimal> RcAmount { get; set; }
        public virtual Nullable<decimal> TcXrate { get; set; }
        public virtual Nullable<decimal> TcAmount { get; set; }
        public virtual Nullable<int> CurrTrans { get; set; }
        public virtual Nullable<short> GlPosted { get; set; }
        public virtual Nullable<int> Accficheref { get; set; }
        public virtual Nullable<int> PrintCounter { get; set; }
        public virtual Nullable<int> CurrselTotals { get; set; }
        public virtual Nullable<int> CurrselDetails { get; set; }
        public virtual Nullable<decimal> Smmvatrate { get; set; }
        public virtual Nullable<decimal> Incometaxrate { get; set; }
        public virtual Nullable<decimal> Fundsharerate { get; set; }
        public virtual string Smmdocode { get; set; }
        public virtual string Smmaddr { get; set; }
        public virtual string Numberplate { get; set; }
        public virtual Nullable<short> Optiontype { get; set; }
        public virtual string TaxAccCode { get; set; }
        public virtual string FundAccCode { get; set; }
        public virtual string SmmVatAccCode { get; set; }
        public virtual Nullable<decimal> InflationIdx { get; set; }
        public virtual string TranGrpNo { get; set; }
        public virtual Nullable<int> TranGrpLineNo { get; set; }
        public virtual Nullable<decimal> CashInfldx { get; set; }
        public virtual string CashOrgLogoId { get; set; }
        public virtual string InvoiceOrgLogoId { get; set; }
        public virtual Nullable<short> VatInc { get; set; }
        public virtual Nullable<decimal> VatRat { get; set; }
        public virtual string VatAccCode { get; set; }
        public virtual Nullable<decimal> VatTot { get; set; }
        public virtual Nullable<int> Status { get; set; }
        public virtual Nullable<short> AffectCollatrl { get; set; }
        public virtual Nullable<short> Grpfirmtrans { get; set; }
        public virtual string TranNo { get; set; }
        public virtual string DocNumber { get; set; }
        public virtual Nullable<short> ControlInfo { get; set; }
        public virtual string PosTransferInfo { get; set; }
        public virtual Nullable<int> CsTransReference { get; set; }
        public virtual string TaxNr { get; set; }
        public virtual Nullable<int> AccFicheSiteid { get; set; }
        public virtual Nullable<DateTime> DocDate { get; set; }
        public virtual string TaxOhpCode { get; set; }
        public virtual string SmmVatOhpCode { get; set; }
        public virtual string CashAccCode { get; set; }
        public virtual string CashOhpCode { get; set; }
        public virtual string SmmVatDeductAccCode { get; set; }
        public virtual string SmmVatDeductCenCode { get; set; }
        public virtual string SmmVatDeductOthAccCode { get; set; }
        public virtual string SmmVatDeductOthCenCode { get; set; }
        public virtual string SalesmanCode { get; set; }
        public virtual string SmmSerialCode { get; set; }
        public virtual Nullable<DateTime> EbookDocdate { get; set; }
        public virtual string EbookDocnr { get; set; }
        public virtual string EbookExplain { get; set; }
        public virtual string EbookPaytype { get; set; }

        #region Implementation
        public virtual Nullable<short> Division { get; set; }
        public virtual Nullable<short> Department { get; set; }
        public virtual string AuthCode { get; set; }
        public virtual string AuxilCode { get; set; }
        public virtual Nullable<short> Cancelled { get; set; }
        public virtual Nullable<int> DataSiteId { get; set; }
        public virtual string TradingGrp { get; set; }
        public virtual string ProjectCode { get; set; }
        public virtual Nullable<short> Approve { get; set; }
        public virtual Nullable<DateTime> ApproveDate { get; set; }
        public string DataNumber { get => Number; set => Number = value; }
        #endregion

        #region SubClasses

        #endregion
    }
}
