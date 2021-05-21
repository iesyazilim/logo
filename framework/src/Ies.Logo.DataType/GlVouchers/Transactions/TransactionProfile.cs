using ExtendedXmlSerializer;
using ExtendedXmlSerializer.Configuration;
using Ies.Logo.DataType.Xml;

namespace Ies.Logo.DataType.GlVouchers
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
                .Member(m => m.Sign).Name("SIGN")
                .Member(m => m.GlCode).Name("GL_CODE")
                .Member(m => m.OhpCode).Name("OHP_CODE")
                .Member(m => m.ParentGlcode).Name("PARENT_GLCODE")
                .Member(m => m.AuxilCode2).Name("AUXIL_CODE2")
                .Member(m => m.Debit).Name("DEBIT")
                .Member(m => m.Credit).Name("CREDIT")
                .Member(m => m.Lineno).Name("LINENO")
                .Member(m => m.Description).Name("DESCRIPTION")
                .Member(m => m.CurrTrans).Name("CURR_TRANS")
                .Member(m => m.SourceXratediff).Name("SOURCE_XRATEDIFF")
                .Member(m => m.RcXrate).Name("RC_XRATE")
                .Member(m => m.RcAmount).Name("RC_AMOUNT")
                .Member(m => m.TcXrate).Name("TC_XRATE")
                .Member(m => m.TcAmount).Name("TC_AMOUNT")
                .Member(m => m.Quantity).Name("QUANTITY")
                .Member(m => m.EuroDebit).Name("EURO_DEBIT")
                .Member(m => m.EuroTrans).Name("EURO_CREDIT")
                .Member(m => m.CurrselTrans).Name("CURRSEL_TRANS")
                .Member(m => m.SafedepTrans).Name("SAFEDEP_TRANS")
                .Member(m => m.InflationIdx).Name("INFLATION_IDX")
                .Member(m => m.InflationFlag).Name("INFLATION_FLAG")
                .Member(m => m.CalcFlagg).Name("CALC_FLAG")
                .Member(m => m.CreditglCode).Name("CREDITGL_CODE")
                .Member(m => m.FromWhere).Name("FROM_WHERE")
                .Member(m => m.BdgtLineType).Name("BDGT_LINE_TYPE")
                .Member(m => m.Status).Name("STATUS")
                .Member(m => m.BdgtFicType).Name("BDGT_FIC_TYPE")
                .Member(m => m.BdgtFicREf).Name("BDGT_FIC_REF")
                .Member(m => m.BdgtFicLnRef).Name("BDGT_FIC_LN_REF")
                .Member(m => m.BdgtFicPrdRef).Name("BDGT_FIC_PRD_REF")
                .Member(m => m.FromDemType).Name("FROM_DEM_TYPE")
                .Member(m => m.EmDemFicRef).Name("EM_DEM_FIC_REF")
                .Member(m => m.EmDemLineRef).Name("EM_DEM_LINE_REF")
                .Member(m => m.ParentLineRef).Name("PARENT_LINE_REF")
                .Member(m => m.AccBdgtAccRef).Name("ACC_BDGT_ACC_REF")
                .Member(m => m.AccBdrefLaccRef).Name("ACC_BDREF_LACC_REF")
                .Member(m => m.AccBdgtPayRef).Name("ACC_BDGT_PAY_REF")
                .Member(m => m.AccBdgtPayLnref).Name("ACC_BDGT_PAY_LNREF")
                .Member(m => m.Linetag).Name("LINETAG")
                .Member(m => m.CreateBdgtLn).Name("CREATE_BDGT_LN")
                .Member(m => m.Month).Name("MONTH")
                .Member(m => m.Year).Name("YEAR")
                .Member(m => m.Grpfirmtrans).Name("GRPFIRMTRANS")
                .Member(m => m.InvoiceNo).Name("INVOICE_NO")
                .Member(m => m.ClName).Name("CL_NAME")
                .Member(m => m.TaxNr).Name("TAX_NR")
                .Member(m => m.ForTaxDecl).Name("FOR_TAX_DECL")
                .Member(m => m.DocDate).Name("DOC_DATE")
                .Member(m => m.GlobalLineNo).Name("GLOBAL_LINE_NO")
                .Member(m => m.LineType).Name("LINE_TYPE")
                .Member(m => m.CodeRef).Name("CODE_REF")
                .Member(m => m.EbookDocdate).Name("EBOOK_DOCDATE")
                .Member(m => m.EbookUndocumented).Name("EBOOK_UNDOCUMENTED")
                .Member(m => m.EbookDocnr).Name("EBOOK_DOCNR")
                .Member(m => m.EbookDoctype).Name("EBOOK_DOCTYPE")
                .Member(m => m.EbookExplain).Name("EBOOK_EXPLAIN")
                .Member(m => m.EbookPaytype).Name("EBOOK_PAYTYPE")
                .Member(m => m.EbookNopay).Name("EBOOK_NOPAY")
                .Member(m => m.DetList).Name("DETLIST")
                ;
        }
    }
}
