using ExtendedXmlSerializer;
using ExtendedXmlSerializer.Configuration;
using Ies.Logo.DataType.Xml;

namespace Ies.Logo.DataType.SdTransactions
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
                .Member(m => m.ArpCode).Name("ARP_CODE")
                .Member(m => m.Tranno).Name("TRANNO")
                .Member(m => m.DocNumber).Name("DOC_NUMBER")
                .Member(m => m.Description).Name("DESCRIPTION")
                .Member(m => m.Debit).Name("DEBIT")
                .Member(m => m.Credit).Name("CREDIT")
                .Member(m => m.CurrTrans).Name("CURR_TRANS")
                .Member(m => m.TCxrate).Name("TC_XRATE")
                .Member(m => m.TcAmount).Name("TC_AMOUNT")
                .Member(m => m.RcXrate).Name("RC_XRATE")
                .Member(m => m.RcAmount).Name("RC_AMOUNT")
                .Member(m => m.Extenref).Name("EXTENREF")
                .Member(m => m.CurrselTrans).Name("CURRSEL_TRANS")
                .Member(m => m.SinglePayment).Name("SINGLE_PAYMENT")
                .Member(m => m.Discounted).Name("DISCOUNTED")
                .Member(m => m.DiscountRate).Name("DISCOUNT_RATE")
                .Member(m => m.VatRate).Name("VAT_RATE")
                .Member(m => m.DiscountedAmount).Name("DISCOUNTED_AMOUNT")
                .Member(m => m.InflationIdx).Name("INFLATION_IDX")
                .Member(m => m.CashTranGrpNo).Name("CASH_TRAN_GRP_NO")
                .Member(m => m.CashTranGrplineNo).Name("CASH_TRAN_GRPLINE_NO")
                .Member(m => m.CashInfldx).Name("CASH_INFLDX")
                .Member(m => m.CashOrglogoid).Name("CASH_ORGLOGOID")
                .Member(m => m.InvoiceOrglogoid).Name("INVOICE_ORGLOGOID")
                .Member(m => m.CreditCardNo).Name("CREDIT_CARD_NO")
                .Member(m => m.EximFilecode).Name("EXIM_FILECODE")
                .Member(m => m.EximFilelinenr).Name("EXIM_FILELINENR")
                .Member(m => m.EximProcnr).Name("EXIM_PROCNR")
                .Member(m => m.Fundsharerat).Name("FUNDSHARERAT")
                .Member(m => m.Month).Name("MONTH")
                .Member(m => m.Year).Name("YEAR")
                .Member(m => m.AffectCollatrl).Name("AFFECT_COLLATRL")
                .Member(m => m.Grpfirmtrans).Name("GRPFIRMTRANS")
                .Member(m => m.AffectRisk).Name("AFFECT_RISK")
                .Member(m => m.BatchNr).Name("BATCH_NR")
                .Member(m => m.ApproveNr).Name("APPROVE_NR")
                .Member(m => m.BankaccCode).Name("BANKACC_CODE")
                .Member(m => m.BankGlCode).Name("BANK_GL_CODE")
                .Member(m => m.BankOhpCode).Name("BANK_OHP_CODE")
                .Member(m => m.DevirProcDate).Name("DEVIR_PROC_DATE")
                .Member(m => m.DocDate).Name("DOC_DATE")
                .Member(m => m.SalesmanCode).Name("SALESMAN_CODE")
                .Member(m => m.PointcommGlCode).Name("POINTCOMM_GL_CODE")
                .Member(m => m.VatAmount).Name("VAT_AMOUNT")
                .Member(m => m.RetCcFcNo).Name("RET_CC_FC_NO")
                .Member(m => m.PaymentList).Name("PAYMENT_LIST")
                .Member(m => m.DefnFldsList).Name("DEFNFLDSLIST")
                ;
        }
    }
}
