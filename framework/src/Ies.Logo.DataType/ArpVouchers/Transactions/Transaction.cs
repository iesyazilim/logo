using System;
using System.Collections.Generic;
using Ies.Logo.DataType.Auditing;
using Ies.Logo.DataType.DefinitionFields;
using Ies.Logo.DataType.Infrastructure;
using Ies.Logo.DataType.Payments;

namespace Ies.Logo.DataType.ArpVouchers
{
    [Serializable]
    public class Transaction : ILogo, IOhpCodes, IGlCodes, IAuxilCode, IPaymentCode, ITradingGroup, IDataReference, IDataSiteId, IProjectCode, IModificationAuditedObject
    {
        public virtual string ArpCode { get; set; }
        public virtual string Tranno { get; set; }
        public virtual string DocNumber { get; set; }
        public virtual string Description { get; set; }
        public virtual Nullable<decimal> Debit{ get; set; }
        public virtual Nullable<decimal> Credit { get; set; }
        public virtual Nullable<short> CurrTrans{ get; set; }
        public virtual Nullable<decimal> TcXrate{ get; set; }
        public virtual Nullable<decimal> TcAmount{ get; set; }
        public virtual Nullable<decimal> RcXrate{ get; set; }
        public virtual Nullable<decimal> RcAmount{ get; set; }
        public virtual Nullable<int> Extenref{ get; set; }
        public virtual Nullable<int> CurrselTrans{ get; set; }
        public virtual Nullable<short> SinglePayment{ get; set; }
        public virtual Nullable<short> Discounted{ get; set; }
        public virtual Nullable<decimal> DiscountRate{ get; set; }
        public virtual Nullable<decimal> VatRate{ get; set; }
        public virtual Nullable<decimal> DiscountedAmount{ get; set; }
        public virtual Nullable<decimal> InflationIdx{ get; set; }
        public virtual string CashTranGrpNo{ get; set; }
        public virtual Nullable<int> CashTranGrplineNo{ get; set; }
        public virtual Nullable<decimal> CashInfldx{ get; set; }
        public virtual Nullable<int> CashOrgLogoId{ get; set; }
        public virtual Nullable<int> InvoiceOrgLogoId{ get; set; }
        public virtual string CreditCardNo{ get; set; }
        public virtual string EximFilecode{ get; set; }
        public virtual Nullable<int> EximFilelinenr{ get; set; }
        public virtual Nullable<int> EximProcnr{ get; set; }
        public virtual Nullable<decimal> Fundsharerat{ get; set; }
        public virtual Nullable<int> Month{ get; set; }
        public virtual Nullable<int> Year{ get; set; }
        public virtual Nullable<short> AffectCollatrl{ get; set; }
        public virtual Nullable<short> Grpfirmtrans{ get; set; }
        public virtual Nullable<short> AffectRisk{ get; set; }
        public virtual string BatchNr{ get; set; }
        public virtual string ApproveNr { get; set; }
        public virtual string OrgLogoId { get; set; }
        public virtual string BankAccCode { get; set; }
        public virtual string BankGlCode { get; set; }
        public virtual string BankOhpCode{ get; set; }
        public virtual Nullable<DateTime> DevirProcDate{ get; set; }
        public virtual Nullable<DateTime> DocDate{ get; set; }
        public virtual string SalesmanCode{ get; set; }
        public virtual string PointcommGlCode{ get; set; }
        public virtual Nullable<decimal> VatAmount{ get; set; }
        public virtual string RetCcFcNo { get; set; }

        #region Implementation
        public virtual string OhpCode1 { get; set; }
        public virtual string OhpCode2 { get; set; }
        public virtual string OhpCode3 { get; set; }
        public virtual string OhpCode4 { get; set; }
        public virtual string OhpCode5 { get; set; }
        public virtual string GlCode1 { get; set; }
        public virtual string GlCode2 { get; set; }
        public virtual string GlCode3 { get; set; }
        public virtual string GlCode4 { get; set; }
        public virtual string GlCode5 { get; set; }
        public virtual string AuxilCode { get; set; }
        public virtual string PaymentCode { get; set; }
        public virtual string TradingGrp { get; set; }
        public virtual Nullable<int> DataReference { get; set; }
        public virtual Nullable<int> InternalReference { get; set; }
        public virtual Nullable<int> DataSiteId { get; set; }
        public virtual string ProjectCode { get; set; }
        public virtual Nullable<short> LastModifierId { get; set; }
        public virtual Nullable<short> LastModificationHour { get; set; }
        public virtual Nullable<short> LastModificationMinute { get; set; }
        public virtual Nullable<short> LastModificationSecond { get; set; }
        public virtual Nullable<DateTime> LastModificationDate { get; set; }
        #endregion

        #region SubClasses
        public virtual List<DefnFld> DefnFldsList { get; set; }
        public virtual List<Payment> PaymentList { get; set; }
        #endregion
    }
}
