using System;
using System.Collections.Generic;
using Ies.Logo.DataType.DefinitionFields;
using Ies.Logo.DataType.Infrastructure;
using Ies.Logo.DataType.Payments;

namespace Ies.Logo.DataType.BankVouchers
{
    [Serializable]
    public class Transaction : ILogo, IAuxilCode, ITradingGroup, IDataSiteId, IDataReference, IProjectCode, IDivision
    {
        public virtual Nullable<int> Type { get; set; }
        public virtual string Tranno { get; set; }
        public virtual string BankaccCode{ get; set; }
        public virtual string ArpCode{ get; set; }
        public virtual string GlCode1{ get; set; }
        public virtual string OhpCode1{ get; set; }
        public virtual string GlCode2{ get; set; }
        public virtual string OhpCode2{ get; set; }
        public virtual Nullable<int> Sourcefref{ get; set; }
        public virtual Nullable<DateTime> Date{ get; set; }
        public virtual Nullable<int> Time { get; set; }
        public virtual Nullable<int> Sign{ get; set; }
        public virtual Nullable<int> Trcode{ get; set; }
        public virtual Nullable<int> Modulenr{ get; set; }
        public virtual string DocNumber{ get; set; }
        public virtual string Description{ get; set; }
        public virtual Nullable<short> CurrTrans{ get; set; }
        public virtual Nullable<decimal> Debit{ get; set; }
        public virtual Nullable<decimal> Credit{ get; set; }
        public virtual Nullable<decimal> Amount{ get; set; }
        public virtual Nullable<decimal> TcXrate{ get; set; }
        public virtual Nullable<decimal> TcAmount{ get; set; }
        public virtual Nullable<decimal> RcXrate{ get; set; }
        public virtual Nullable<decimal> RcAmount{ get; set; }
        public virtual string ArpBnkdivNr{ get; set; }
        public virtual string ArpBnkaccountNr{ get; set; }
        public virtual string BnkTrackingNr{ get; set; }
        public virtual Nullable<int> TrnState{ get; set; }
        public virtual Nullable<int> CurrselTrans{ get; set; }
        public virtual Nullable<short> Discounted{ get; set; }
        public virtual Nullable<decimal> DiscountRate{ get; set; }
        public virtual Nullable<decimal> VatRate{ get; set; }
        public virtual Nullable<decimal> ArpCloseAmount{ get; set; }
        public virtual string OhpCode3{ get; set; }
        public virtual Nullable<int> BankProcType{ get; set; }
        public virtual Nullable<int> BankProcCode{ get; set; }
        public virtual Nullable<DateTime> DueDate{ get; set; }
        public virtual Nullable<int> OpStatus{ get; set; }
        public virtual Nullable<decimal> InflationIdx{ get; set; }
        public virtual string CashTranGrpNo{ get; set; }
        public virtual Nullable<decimal> CashTranGrplineNo{ get; set; }
        public virtual Nullable<decimal> CashInfldx{ get; set; }
        public virtual string EximFicheno{ get; set; }
        public virtual string CashOrglogoid{ get; set; }
        public virtual Nullable<short> BntranVatInc { get; set; }
        public virtual Nullable<decimal> BntranVatRat{ get; set; }
        public virtual Nullable<decimal> BnTranVatTot{ get; set; }
        public virtual Nullable<decimal> EximParity{ get; set; }
        public virtual string EximCreditCode{ get; set; }
        public virtual string EximFileCode{ get; set; }
        public virtual Nullable<int> EximFilelinenr{ get; set; }
        public virtual Nullable<int> ComsType{ get; set; }
        public virtual string Trangrpno{ get; set; }
        public virtual string Bankrefnr{ get; set; }
        public virtual string CustomDocNumber{ get; set; }
        public virtual Nullable<int> Dablnref{ get; set; }
        public virtual Nullable<int> Transref{ get; set; }
        public virtual Nullable<short> AffectCollatrl{ get; set; }
        public virtual Nullable<int> CollatrlCardref{ get; set; }
        public virtual Nullable<short> Grpfirmtrans{ get; set; }
        public virtual Nullable<short> AffectRisk{ get; set; }
        public virtual Nullable<int> BnkCreSource{ get; set; }
        public virtual Nullable<int> BnkCreLineType{ get; set; }
        public virtual string OrgLogoId{ get; set; }
        public virtual Nullable<int> CsTransReference{ get; set; }
        public virtual string Iban { get; set; }
        public virtual string BankBranchs{ get; set; }
        public virtual string BankNames{ get; set; }
        public virtual Nullable<short> CostOwner{ get; set; }
        public virtual string CostAccount{ get; set; }
        public virtual Nullable<int> CrcardWizard{ get; set; }
        public virtual string BankBranchNr{ get; set; }
        public virtual string BankAccountNr{ get; set; }
        public virtual string ClTckNr{ get; set; }
        public virtual string ClTaxNr{ get; set; }
        public virtual Nullable<short> ClTrCurr{ get; set; }
        public virtual Nullable<decimal> ClTrRate{ get; set; }
        public virtual Nullable<decimal> ClTrNet{ get; set; }
        public virtual Nullable<decimal> CostTotal{ get; set; }
        public virtual Nullable<decimal> BsmvTotal{ get; set; }
        public virtual Nullable<decimal> RepCostTotal{ get; set; }
        public virtual Nullable<decimal> RepBsmvTotal{ get; set; }
        public virtual Nullable<decimal> TrCostTotal{ get; set; }
        public virtual Nullable<decimal> TrBsmvTotal{ get; set; }
        public virtual string BnCostGlCode{ get; set; }
        public virtual string BnCostOhpCode{ get; set; }
        public virtual string BnBsmvGlCode{ get; set; }
        public virtual string BnBsmvOhpCode{ get; set; }
        public virtual string SalesmanCode{ get; set; }
        public virtual string BnIntGlCode{ get; set; }
        public virtual string BnIntOhpCode{ get; set; }
        public virtual string BnKkdfGlCode{ get; set; }
        public virtual string BnKkdfOhpCode{ get; set; }
        public virtual Nullable<short> Dbs{ get; set; }
        public virtual string CreditLetterNumber{ get; set; }
        public virtual Nullable<short> Bntrancosttotinc { get; set; } 
        public virtual Nullable<short> BnCrdtype{ get; set; }
        public virtual Nullable<int> CrcardFicheref{ get; set; }
        public virtual Nullable<int> CrcardPaytrref{ get; set; }

        #region Implementation
        public virtual string AuxilCode { get; set; }
        public virtual string TradingGrp { get; set; }
        public virtual Nullable<int> DataSiteId { get; set; }
        public virtual Nullable<int> DataReference { get; set; }
        public virtual Nullable<int> InternalReference { get; set; }
        public virtual string ProjectCode { get; set; }
        public virtual Nullable<short> Division { get; set; }
        #endregion

        #region SubClasses
        public virtual List<DefnFld> DefnFldsList { get; set; }
        public virtual List<Payment> PaymentList { get; set; }
        #endregion
    }
}
