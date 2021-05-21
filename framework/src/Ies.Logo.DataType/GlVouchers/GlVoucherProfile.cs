using ExtendedXmlSerializer;
using ExtendedXmlSerializer.Configuration;
using Ies.Logo.DataType.Xml;

namespace Ies.Logo.DataType.GlVouchers
{
    public class GlVoucherProfile : IConfigurationProfile
    {
        public static GlVoucherProfile Default { get; } = new GlVoucherProfile();

        private GlVoucherProfile() { }

        public IConfigurationContainer Get(IConfigurationContainer parameter)
        {
            var configuration = parameter.Type<GlVoucher>();

            Configure(configuration);

            return configuration;
        }

        public static void Configure<T>(ITypeConfiguration<T> typeConfigurations) where T : GlVoucher
        {
            typeConfigurations.Configure();
            typeConfigurations.Name<T>("GL_VOUCHER");

            typeConfigurations
                .Member(m => m.Type).Name("TYPE")
                .Member(m => m.Number).Name("NUMBER")
                .Member(m => m.Date).Name("DATE")
                .Member(m => m.DocNumber).Name("DOC_NUMBER")
                .Member(m => m.Sourceref).Name("SOURCEFREF")
                .Member(m => m.JournalNr).Name("JOURNAL_NR")
                .Member(m => m.TotalDebit).Name("TOTAL_DEBIT")
                .Member(m => m.TotalCredit).Name("TOTAL_CREDIT")
                .Member(m => m.PrintCounter).Name("PRINT_COUNTER")
                .Member(m => m.PrintDate).Name("PRINT_DATE")
                .Member(m => m.SourceModule).Name("SOURCE_MODULE")
                .Member(m => m.EuroTotalDebit).Name("EURO_TOTAL_DEBIT")
                .Member(m => m.EuroTotalCredit).Name("EURO_TOTAL_CREDIT")
                .Member(m => m.CurrselTotals).Name("CURRSEL_TOTALS")
                .Member(m => m.CurrselDetails).Name("CURRSEL_DETAILS")
                .Member(m => m.RcTotalDebit).Name("RC_TOTAL_DEBIT")
                .Member(m => m.RcTotalCredit).Name("RC_TOTAL_CREDIT")
                .Member(m => m.Status).Name("STATUS")
                .Member(m => m.BdgtFicheType).Name("BDGT_FICHE_TYPE")
                .Member(m => m.BdgtFicheRef).Name("BDGT_FICHE_REF")
                .Member(m => m.FromDemType).Name("FROM_DEM_TYPE")
                .Member(m => m.EmDemFicheRef).Name("EM_DEM_FICHE_REF")
                .Member(m => m.Wflowcrdref).Name("WFLOWCRDREF")
                .Member(m => m.ViaAutoGl).Name("VIA_AUTO_GL")
                .Member(m => m.DocDate).Name("DOC_DATE")
                .Member(m => m.ImportDistSlip).Name("IMPORT_DIST_SLIP")
                .Member(m => m.EbookDocdate).Name("EBOOK_DOCDATE")
                .Member(m => m.EbookNodocument).Name("EBOOK_NODOCUMENT")
                .Member(m => m.EbookDocnr).Name("EBOOK_DOCNR")
                .Member(m => m.EbookDoctype).Name("EBOOK_DOCTYPE")
                .Member(m => m.EbookExplain).Name("EBOOK_EXPLAIN")
                .Member(m => m.EbookPaytype).Name("EBOOK_PAYTYPE")
                .Member(m => m.EbookNopay).Name("EBOOK_NOPAY")
                .Member(m => m.Linebaseddocdet).Name("LINEBASEDDOCDET")
                .Member(m => m.CrossFlag).Name("CROSS_FLAG")
                .Member(m => m.CrossFicheref).Name("CROSS_FICHEREF")
                .Member(m => m.DocType).Name("DOC_TYPE")
                .Member(m => m.DetList).Name("DETLIST")
                .Member(m => m.Transactions).Name("TRANSACTIONS")
                ;
        }
    }
}
