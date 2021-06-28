using ExtendedXmlSerializer;
using ExtendedXmlSerializer.Configuration;
using Ies.Logo.DataType.Xml;

namespace Ies.Logo.DataType.BankVouchers
{
    public class TransactionProfile : IConfigurationProfile
    {
        public static TransactionProfile Default { get; } = new TransactionProfile();

        private TransactionProfile() { }

        public IConfigurationContainer Get(IConfigurationContainer parameter)
        {
            var configuration = parameter.Type<Transaction>();

            Configure(configuration);

            return configuration;
        }

        public static void Configure<T>(ITypeConfiguration<T> typeConfigurations) where T : Transaction
        {
            typeConfigurations.Configure();
            typeConfigurations.Name<T>("TRANSACTION");

            typeConfigurations
                .Member(m => m.Type).Name("TYPE")
                .Member(m => m.Tranno).Name("TRANNO")
                .Member(m => m.BankaccCode).Name("BANKACC_CODE")
                .Member(m => m.ArpCode).Name("ARP_CODE")
                .Member(m => m.GlCode1).Name("GL_CODE1")
                .Member(m => m.OhpCode1).Name("OHP_CODE1")
                .Member(m => m.GlCode2).Name("GL_CODE2")
                .Member(m => m.OhpCode2).Name("OHP_CODE2")
                .Member(m => m.Sourcefref).Name("SOURCEFREF")
                .Member(m => m.Date).Name("DATE")
                .Member(m => m.Time).Name("TIME")
                .Member(m => m.Sign).Name("SIGN")
                .Member(m => m.Trcode).Name("TRCODE")
                .Member(m => m.Modulenr).Name("MODULENR")
                .Member(m => m.DocNumber).Name("DOC_NUMBER")
                .Member(m => m.Description).Name("DESCRIPTION")
                .Member(m => m.CurrTrans).Name("CURR_TRANS")
                .Member(m => m.Debit).Name("DEBIT")
                .Member(m => m.Credit).Name("CREDIT")
                .Member(m => m.Amount).Name("AMOUNT")
                .Member(m => m.TcXrate).Name("TC_XRATE")
                .Member(m => m.TcAmount).Name("TC_AMOUNT")
                .Member(m => m.RcXrate).Name("RC_XRATE")
                .Member(m => m.RcAmount).Name("RC_AMOUNT")
                .Member(m => m.ArpBnkdivNr).Name("ARP_BNKDIV_NR")
                .Member(m => m.ArpBnkaccountNr).Name("ARP_BNKACCOUNT_NR")
                .Member(m => m.BnkTrackingNr).Name("BNK_TRACKING_NR")
                .Member(m => m.TrnState).Name("TRN_STATE")
                .Member(m => m.CurrselTrans).Name("CURRSEL_TRANS")
                .Member(m => m.Discounted).Name("DISCOUNTED")
                .Member(m => m.DiscountRate).Name("DISCOUNT_RATE")
                .Member(m => m.VatRate).Name("VAT_RATE")
                .Member(m => m.ArpCloseAmount).Name("ARP_CLOSE_AMOUNT")
                .Member(m => m.OhpCode3).Name("OHP_CODE3")
                .Member(m => m.BankProcType).Name("BANK_PROC_TYPE")
                .Member(m => m.BankProcCode).Name("BANK_PROC_CODE")
                .Member(m => m.DueDate).Name("DUE_DATE")
                .Member(m => m.OpStatus).Name("OP_STATUS")
                .Member(m => m.InflationIdx).Name("INFLATION_IDX")
                .Member(m => m.CashTranGrpNo).Name("CASH_TRAN_GRP_NO")
                .Member(m => m.CashTranGrplineNo).Name("CASH_TRAN_GRPLINE_NO")
                .Member(m => m.CashInfldx).Name("CASH_INFLDX")
                .Member(m => m.EximFicheno).Name("EXIM_FICHENO")
                .Member(m => m.CashOrglogoid).Name("CASH_ORGLOGOID")
                .Member(m => m.BntranVatInc).Name("BNTRAN_VAT_INC")
                .Member(m => m.BntranVatRat).Name("BNTRAN_VAT_RAT")
                .Member(m => m.BnTranVatTot).Name("BNTRAN_VAT_TOT")
                .Member(m => m.EximParity).Name("EXIM_PARITY")
                .Member(m => m.EximCreditCode).Name("EXIM_CREDIT_CODE")
                .Member(m => m.EximFileCode).Name("EXIM_FILE_CODE")
                .Member(m => m.EximFilelinenr).Name("EXIM_FILELINENR")
                .Member(m => m.ComsType).Name("COMS_TYPE")
                .Member(m => m.Trangrpno).Name("TRANGRPNO")
                .Member(m => m.Bankrefnr).Name("BANKREFNR")
                .Member(m => m.CustomDocNumber).Name("CUSTOM_DOC_NUMBER")
                .Member(m => m.Dablnref).Name("DABLNREF")
                .Member(m => m.Transref).Name("TRANSREF")
                .Member(m => m.AffectCollatrl).Name("AFFECT_COLLATRL")
                .Member(m => m.CollatrlCardref).Name("COLLATRL_CARDREF")
                .Member(m => m.Grpfirmtrans).Name("GRPFIRMTRANS")
                .Member(m => m.AffectRisk).Name("AFFECT_RISK")
                .Member(m => m.BnkCreSource).Name("BNK_CRE_SOURCE")
                .Member(m => m.BnkCreLineType).Name("BNK_CRE_LINE_TYPE")
                .Member(m => m.OrgLogoId).Name("ORGLOGOID")
                .Member(m => m.CsTransReference).Name("CS_TRANS_REFERENCE")
                .Member(m => m.Iban).Name("IBAN")
                .Member(m => m.BankBranchs).Name("BANK_BRANCHS")
                .Member(m => m.BankNames).Name("BANK_NAMES")
                .Member(m => m.CostOwner).Name("COST_OWNER")
                .Member(m => m.CostAccount).Name("COST_ACCOUNT")
                .Member(m => m.CrcardWizard).Name("CRCARD_WIZARD")
                .Member(m => m.BankBranchNr).Name("BANK_BRANCH_NR")
                .Member(m => m.BankAccountNr).Name("BANK_ACCOUNT_NR")
                .Member(m => m.ClTckNr).Name("CL_TCK_NR")
                .Member(m => m.ClTaxNr).Name("CL_TAX_NR")
                .Member(m => m.ClTrCurr).Name("CL_TR_CURR")
                .Member(m => m.ClTrRate).Name("CL_TR_RATE")
                .Member(m => m.ClTrNet).Name("CL_TR_NET")
                .Member(m => m.CostTotal).Name("COST_TOTAL")
                .Member(m => m.BsmvTotal).Name("BSMV_TOTAL")
                .Member(m => m.RepCostTotal).Name("REP_COST_TOTAL")
                .Member(m => m.RepBsmvTotal).Name("REP_BSMV_TOTAL")
                .Member(m => m.TrCostTotal).Name("TR_COST_TOTAL")
                .Member(m => m.TrBsmvTotal).Name("TR_BSMV_TOTAL")
                .Member(m => m.BnCostGlCode).Name("BN_COST_GL_CODE")
                .Member(m => m.BnCostOhpCode).Name("BN_COST_OHP_CODE")
                .Member(m => m.BnBsmvGlCode).Name("BN_BSMV_GL_CODE")
                .Member(m => m.BnBsmvOhpCode).Name("BN_BSMV_OHP_CODE")
                .Member(m => m.SalesmanCode).Name("SALESMAN_CODE")
                .Member(m => m.BnIntGlCode).Name("BN_INT_GL_CODE")
                .Member(m => m.BnIntOhpCode).Name("BN_INT_OHP_CODE")
                .Member(m => m.BnKkdfGlCode).Name("BN_KKDF_GL_CODE")
                .Member(m => m.BnKkdfOhpCode).Name("BN_KKDF_OHP_CODE")
                .Member(m => m.Dbs).Name("DBS")
                .Member(m => m.CreditLetterNumber).Name("CREDIT_LETTER_NUMBER")
                .Member(m => m.Bntrancosttotinc).Name("BNTRANCOSTTOTINC")
                .Member(m => m.BnCrdtype).Name("BN_CRDTYPE")
                .Member(m => m.CrcardFicheref).Name("CRCARD_FICHEREF")
                .Member(m => m.CrcardPaytrref).Name("CRCARD_PAYTRREF")
                .Member(m => m.DefnFldsList).Name("DEFNFLDSLIST")
                .Member(m => m.PaymentList).Name("PAYMENT_LIST")
                ;
        }
    }
}
