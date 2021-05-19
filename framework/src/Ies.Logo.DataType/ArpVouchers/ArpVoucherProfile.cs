using ExtendedXmlSerializer;
using ExtendedXmlSerializer.Configuration;
using Ies.Logo.DataType.Xml;

namespace Ies.Logo.DataType.ArpVouchers
{
    public class ArpVoucherProfile : IConfigurationProfile
    {
        public static ArpVoucherProfile Default { get; } = new ArpVoucherProfile();

        private ArpVoucherProfile() { }

        public IConfigurationContainer Get(IConfigurationContainer parameter)
        {
            var configuration = parameter.Type<ArpVoucher>();

            Configure(configuration);

            return configuration;
        }

        public static void Configure<T>(ITypeConfiguration<T> typeConfigurations) where T : ArpVoucher
        {
            typeConfigurations.Configure();
            typeConfigurations.Name<T>("ARP_VOUCHER");

            typeConfigurations
                .Member(m => m.Number).Name("NUMBER")
                .Member(m => m.Date).Name("DATE")
                .Member(m => m.DocNumber).Name("DOC_NUMBER")
                .Member(m => m.Type).Name("TYPE")
                .Member(m => m.TotalDebit).Name("TOTAL_DEBIT")
                .Member(m => m.TotalCredit).Name("TOTAL_CREDIT")
                .Member(m => m.RcTotalDebit).Name("RC_TOTAL_DEBIT")
                .Member(m => m.RcTotalCredit).Name("RC_TOTAL_CREDIT")
                .Member(m => m.GlPosted).Name("GL_POSTED")
                .Member(m => m.GlCode).Name("GL_CODE")
                .Member(m => m.OhpCode).Name("OHP_CODE")
                .Member(m => m.PrintCounter).Name("PRINT_COUNTER")
                .Member(m => m.Accficheref).Name("ACCFICHEREF")
                .Member(m => m.CurrselTotals).Name("CURRSEL_TOTALS")
                .Member(m => m.CurrselDetails).Name("CURRSEL_DETAILS")
                .Member(m => m.ArpCode).Name("ARP_CODE")
                .Member(m => m.Time).Name("TIME")
                .Member(m => m.BankaccCode).Name("BANKACC_CODE")
                .Member(m => m.BnglCode).Name("BNGL_CODE")
                .Member(m => m.BnohpCode).Name("BNOHP_CODE")
                .Member(m => m.AffectCollatrl).Name("AFFECT_COLLATRL")
                .Member(m => m.Status).Name("STATUS")
                .Member(m => m.Grpfirmtrans).Name("GRPFIRMTRANS")
                .Member(m => m.AffectRisk).Name("AFFECT_RISK")
                .Member(m => m.PosTerminalNr).Name("POS_TERMINAL_NR")
                .Member(m => m.AccFicheSiteid).Name("ACC_FICHE_SITEID")
                .Member(m => m.DocDate).Name("DOC_DATE")
                .Member(m => m.SalesmanCode).Name("SALESMAN_CODE")
                .Member(m => m.CancelAutoGlProc).Name("CANCEL_AUTO_GL_PROC")
                .Member(m => m.EbookDocdate).Name("EBOOK_DOCDATE")
                .Member(m => m.DefnFldsList).Name("DEFNFLDSLIST")
                .Member(m => m.Transactions).Name("TRANSACTIONS")
                ;

        }
    }
}
