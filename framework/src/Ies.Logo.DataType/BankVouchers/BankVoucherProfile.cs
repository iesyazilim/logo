using ExtendedXmlSerializer;
using ExtendedXmlSerializer.Configuration;
using Ies.Logo.DataType.Xml;

namespace Ies.Logo.DataType.BankVouchers
{
    public class BankVoucherProfile : IConfigurationProfile
    {
        public static BankVoucherProfile Default { get; } = new BankVoucherProfile();

        private BankVoucherProfile() { }

        public IConfigurationContainer Get(IConfigurationContainer parameter)
        {
            var configuration = parameter.Type<BankVoucher>();

            Configure(configuration);

            return configuration;
        }
        public static void Configure<T>(ITypeConfiguration<T> typeConfigurations) where T : BankVoucher
        {
            typeConfigurations.Configure();
            typeConfigurations.Name<T>("BANK_VOUCHER");

            typeConfigurations
                .Member(m => m.Date).Name("DATE")
                .Member(m => m.Time).Name("TIME")
                .Member(m => m.Number).Name("NUMBER")
                .Member(m => m.Type).Name("TYPE")
                .Member(m => m.Sign).Name("SIGN")
                .Member(m => m.TotalDebit).Name("TOTAL_DEBIT")
                .Member(m => m.TotalCredit).Name("TOTAL_CREDIT")
                .Member(m => m.PrintCounter).Name("PRINT_COUNTER")
                .Member(m => m.Accficheref).Name("ACCFICHEREF")
                .Member(m => m.CurrselTotals).Name("CURRSEL_TOTALS")
                .Member(m => m.CurrselDetails).Name("CURRSEL_DETAILS")
                .Member(m => m.RcTotalDebit).Name("RC_TOTAL_DEBIT")
                .Member(m => m.RcTotalCredit).Name("RC_TOTAL_CREDIT")
                .Member(m => m.Trangrpdate).Name("TRANGRPDATE")
                .Member(m => m.BankaccCode).Name("BANKACC_CODE")
                .Member(m => m.Trangrpno).Name("TRANGRPNO")
                .Member(m => m.Bncreref).Name("BNCREREF")
                .Member(m => m.BankCreditCode).Name("BANK_CREDIT_CODE")
                .Member(m => m.CrcardWizard).Name("CRCARD_WIZARD")
                .Member(m => m.AccFicheSiteid).Name("ACC_FICHE_SITEID")
                .Member(m => m.CollatrlCardRef).Name("COLLATRL_CARD_REF")
                .Member(m => m.CollatrlCardSiteid).Name("COLLATRL_CARD_SITEID")
                .Member(m => m.SalesmanCode).Name("SALESMAN_CODE")
                .Member(m => m.CrcardFicheref).Name("CRCARD_FICHEREF")
                .Member(m => m.CancelAutoGlProc).Name("CANCEL_AUTO_GL_PROC")
                .Member(m => m.DefnFldsList).Name("DEFNFLDSLIST")
                .Member(m => m.Transactions).Name("TRANSACTIONS")
                ;
        }
    }
}
