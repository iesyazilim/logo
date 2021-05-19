using ExtendedXmlSerializer;
using ExtendedXmlSerializer.Configuration;
using Ies.Logo.DataType.Xml;

namespace Ies.Logo.DataType.BankAccounts
{
    public class BankAccountProfile : IConfigurationProfile
    {
        public static BankAccountProfile Default { get; } = new BankAccountProfile();

        private BankAccountProfile() { }

        public IConfigurationContainer Get(IConfigurationContainer parameter)
        {
            var configuration = parameter.Type<BankAccount>();

            Configure(configuration);

            return configuration;
        }

        public static void Configure<T>(ITypeConfiguration<T> typeConfigurations) where T : BankAccount
        {
            typeConfigurations.Configure();
            typeConfigurations.Name<T>("BANK_ACCOUNT");

            typeConfigurations
                .Member(m => m.AccountType).Name("ACCOUNT_TYPE ")
                .Member(m => m.Code).Name("CODE ")
                .Member(m => m.Description).Name("DESCRIPTION ")
                .Member(m => m.BankCode).Name("BANK_CODE ")
                .Member(m => m.ChequeMargin).Name("CHEQUE_MARGIN ")
                .Member(m => m.PnMargin).Name("PN_MARGIN ")
                .Member(m => m.ChequeLimit).Name("CHEQUE_LIMIT ")
                .Member(m => m.PnLimit).Name("PN_LIMIT ")
                .Member(m => m.IntrateGen).Name("INTRATE_GEN ")
                .Member(m => m.IntrateChqcrd).Name("INTRATE_CHQCRD ")
                .Member(m => m.IntratePncrd).Name("INTRATE_PNCRD ")
                .Member(m => m.DedtaxRate).Name("DEDTAX_RATE ")
                .Member(m => m.OfcfundRate).Name("OFCFUND_RATE ")
                .Member(m => m.Currency).Name("CURRENCY ")
                .Member(m => m.AccountNr).Name("ACCOUNT_NR ")
                .Member(m => m.Kkusage).Name("KKUSAGE ")
                .Member(m => m.CollatrlLimit).Name("COLLATRL_LIMIT ")
                .Member(m => m.WithCltrlInterest).Name("WITH_CLTRL_INTEREST ")
                .Member(m => m.WithCltrlLimit).Name("WITH_CLTRL_LIMIT ")
                .Member(m => m.CurrRateType).Name("CURR_RATE_TYPE ")
                .Member(m => m.DivisionId).Name("DIVISION_ID ")
                .Member(m => m.Iban).Name("IBAN ")
                .Member(m => m.GlCode6).Name("GL_CODE6 ")
                .Member(m => m.OhpCode6).Name("OHP_CODE6 ")
                .Member(m => m.GlCode7).Name("GL_CODE7 ")
                .Member(m => m.OhpCode7).Name("OHP_CODE7 ")
                .Member(m => m.GlCode8).Name("GL_CODE8 ")
                .Member(m => m.OhpCode8).Name("OHP_CODE8 ")
                .Member(m => m.GlCode9).Name("GL_CODE9 ")
                .Member(m => m.OhpCodeE9).Name("OHP_CODE9 ")
                .Member(m => m.GlCode10).Name("GL_CODE10 ")
                .Member(m => m.OhpCode10).Name("OHP_CODE10 ")
                .Member(m => m.GlCode11).Name("GL_CODE11 ")
                .Member(m => m.OhpCode11).Name("OHP_CODE11 ")
                .Member(m => m.GlCode12).Name("GL_CODE12 ")
                .Member(m => m.OhpCode12).Name("OHP_CODE12 ")
                .Member(m => m.GlCode13).Name("GL_CODE13 ")
                .Member(m => m.OhpCode13).Name("OHP_CODE13 ")
                .Member(m => m.GlCode14).Name("GL_CODE14 ")
                .Member(m => m.OhpCode14).Name("OHP_CODE14 ")
                .Member(m => m.GlCode15).Name("GL_CODE15 ")
                .Member(m => m.OhpCode15).Name("OHP_CODE15 ")
                .Member(m => m.GlCode16).Name("GL_CODE16 ")
                .Member(m => m.OhpCode16).Name("OHP_CODE16 ")
                .Member(m => m.GlCode17).Name("GL_CODE17 ")
                .Member(m => m.OhpCode17).Name("OHP_CODE17 ")
                .Member(m => m.GlCode18).Name("GL_CODE18 ")
                .Member(m => m.OhpCode18).Name("OHP_CODE18 ")
                .Member(m => m.CreditCardLimit).Name("CREDIT_CARD_LIMIT ")
                .Member(m => m.CreditCardNo).Name("CREDIT_CARD_NO ")
                .Member(m => m.GlobalBankBranch).Name("GLOBAL_BANK_BRANCH ")
                .Member(m => m.DefBankAccCode).Name("DEF_BANK_ACC_CODE ")
                .Member(m => m.DefCashAccCode).Name("DEF_CASH_ACC_CODE ")
                .Member(m => m.PosTerminalNo).Name("POS_TERMINAL_NO ")
                .Member(m => m.StopajPer).Name("STOPAJ_PER ")
                .Member(m => m.DefnFldsList).Name("DEFNFLDSLIST")
                ;
        }
    }
}
