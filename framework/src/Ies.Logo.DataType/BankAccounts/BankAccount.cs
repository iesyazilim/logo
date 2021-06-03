using System;
using System.Collections.Generic;
using Ies.Logo.Core;
using Ies.Logo.DataType.AggregateRoot;
using Ies.Logo.DataType.DefinitionFields;
using Ies.Logo.DataType.Infrastructure;

namespace Ies.Logo.DataType.BankAccounts
{
    [Serializable]
    public class BankAccount : AuditedAggregateRoot, IRecordStatus, IAuxilCode, IAuthCode, IGlCodes, IOhpCodes, IDataSiteId, IDataNo
    {
        public static LogoObjectType XmlRoot => LogoObjectType.BANK_ACCOUNTS;

        public virtual Nullable<int> AccountType { get; set; }
        public virtual string Code { get; set; }
        public virtual string Description { get; set; }
        public virtual string BankCode { get; set; }
        public virtual Nullable<decimal> ChequeMargin { get; set; }
        public virtual Nullable<decimal> PnMargin { get; set; }
        public virtual Nullable<decimal> ChequeLimit { get; set; }
        public virtual Nullable<decimal> PnLimit { get; set; }
        public virtual Nullable<decimal> IntrateGen { get; set; }
        public virtual Nullable<decimal> IntrateChqcrd { get; set; }
        public virtual Nullable<decimal> IntratePncrd { get; set; }
        public virtual Nullable<decimal> DedtaxRate { get; set; }
        public virtual Nullable<decimal> OfcfundRate { get; set; }
        public virtual Nullable<short> Currency { get; set; }
        public virtual string AccountNr { get; set; }
        public virtual Nullable<short> Kkusage { get; set; }
        public virtual Nullable<decimal> CollatrlLimit { get; set; }
        public virtual Nullable<decimal> WithCltrlInterest { get; set; }
        public virtual Nullable<decimal> WithCltrlLimit { get; set; }
        public virtual Nullable<short> CurrRateType { get; set; }
        public virtual string DivisionId { get; set; }
        public virtual string Iban { get; set; }
        public virtual string GlCode6 { get; set; }
        public virtual string OhpCode6 { get; set; }
        public virtual string GlCode7 { get; set; }
        public virtual string OhpCode7 { get; set; }
        public virtual string GlCode8 { get; set; }
        public virtual string OhpCode8 { get; set; }
        public virtual string GlCode9 { get; set; }
        public virtual string OhpCodeE9 { get; set; }
        public virtual string GlCode10 { get; set; }
        public virtual string OhpCode10 { get; set; }
        public virtual string GlCode11 { get; set; }
        public virtual string OhpCode11 { get; set; }
        public virtual string GlCode12 { get; set; }
        public virtual string OhpCode12 { get; set; }
        public virtual string GlCode13 { get; set; }
        public virtual string OhpCode13 { get; set; }
        public virtual string GlCode14 { get; set; }
        public virtual string OhpCode14 { get; set; }
        public virtual string GlCode15 { get; set; }
        public virtual string OhpCode15 { get; set; }
        public virtual string GlCode16 { get; set; }
        public virtual string OhpCode16 { get; set; }
        public virtual string GlCode17 { get; set; }
        public virtual string OhpCode17 { get; set; }
        public virtual string GlCode18 { get; set; }
        public virtual string OhpCode18 { get; set; }
        public virtual Nullable<decimal> CreditCardLimit { get; set; }
        public virtual string CreditCardNo { get; set; }
        public virtual string GlobalBankBranch { get; set; }
        public virtual string DefBankAccCode { get; set; }
        public virtual string DefCashAccCode { get; set; }
        public virtual string PosTerminalNo { get; set; }
        public virtual Nullable<decimal> StopajPer { get; set; }

        #region Implementation
        public virtual Nullable<short> RecordStatus { get; set; }
        public virtual string AuxilCode { get; set; }
        public virtual string AuthCode { get; set; }
        public virtual string GlCode1 { get; set; }
        public virtual string GlCode2 { get; set; }
        public virtual string GlCode3 { get; set; }
        public virtual string GlCode4 { get; set; }
        public virtual string GlCode5 { get; set; }
        public virtual string OhpCode1 { get; set; }
        public virtual string OhpCode2 { get; set; }
        public virtual string OhpCode3 { get; set; }
        public virtual string OhpCode4 { get; set; }
        public virtual string OhpCode5 { get; set; }
        public virtual Nullable<int> DataSiteId { get; set; }
        public string DataNumber { get => Code; set => Code = value; }
        #endregion

        #region SubClasses
        public virtual List<DefnFld> DefnFldsList { get; set; }
        #endregion
    }
}
