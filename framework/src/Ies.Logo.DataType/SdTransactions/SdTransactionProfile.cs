using ExtendedXmlSerializer;
using ExtendedXmlSerializer.Configuration;
using Ies.Logo.DataType.Xml;

namespace Ies.Logo.DataType.SdTransactions
{
    public class SdTransactionProfile : IConfigurationProfile
    {
        public static SdTransactionProfile Default { get; } = new SdTransactionProfile();

        private SdTransactionProfile() { }

        public IConfigurationContainer Get(IConfigurationContainer parameter)
        {
            var configuration = parameter.Type<SdTransaction>();

            Configure(configuration);

            return configuration;
        }

        public static void Configure<T>(ITypeConfiguration<T> typeConfigurations) where T : SdTransaction
        {
            typeConfigurations.Configure();
            typeConfigurations.Name<T>("SD_TRANSACTION");

            typeConfigurations
                .Member(m => m.Type).Name("TYPE")
                .Member(m => m.SdCode).Name("SD_CODE")
                .Member(m => m.SdCodeCross).Name("SD_CODE_CROSS")
                .Member(m => m.SdNumberCross).Name("SD_NUMBER_CROSS")
                .Member(m => m.CrossDataReference).Name("CROSS_DATA_REFERENCE")
                .Member(m => m.GlCode1).Name("GL_CODE1")
                .Member(m => m.OhpCode1).Name("OHP_CODE1")
                .Member(m => m.GlCode2).Name("GL_CODE2")
                .Member(m => m.OhpCode2).Name("OHP_CODE2")
                .Member(m => m.Date).Name("DATE")
                .Member(m => m.Time).Name("TIME")
                .Member(m => m.Hour).Name("HOUR")
                .Member(m => m.Minute).Name("MINUTE")
                .Member(m => m.DestDivision).Name("DEST_DIVISION")
                .Member(m => m.DestDepartment).Name("DEST_DEPARTMENT")
                .Member(m => m.Number).Name("NUMBER")
                .Member(m => m.MasterTitle).Name("MASTER_TITLE")
                .Member(m => m.Description).Name("DESCRIPTION")
                .Member(m => m.Amount).Name("AMOUNT")
                .Member(m => m.Sign).Name("SIGN")
                .Member(m => m.RcXrate).Name("RC_XRATE")
                .Member(m => m.RcAmount).Name("RC_AMOUNT")
                .Member(m => m.TcXrate).Name("TC_XRATE")
                .Member(m => m.TcAmount).Name("TC_AMOUNT")
                .Member(m => m.CurrTrans).Name("CURR_TRANS")
                .Member(m => m.GlPosted).Name("GL_POSTED")
                .Member(m => m.Accficheref).Name("ACCFICHEREF")
                .Member(m => m.PrintCounter).Name("PRINT_COUNTER")
                .Member(m => m.CurrselTotals).Name("CURRSEL_TOTALS")
                .Member(m => m.CurrselDetails).Name("CURRSEL_DETAILS")
                .Member(m => m.Smmvatrate).Name("SMMVATRATE")
                .Member(m => m.Incometaxrate).Name("INCOMETAXRATE")
                .Member(m => m.Fundsharerate).Name("FUNDSHARERATE")
                .Member(m => m.Smmdocode).Name("SMMDOCODE")
                .Member(m => m.Smmaddr).Name("SMMADDR")
                .Member(m => m.Numberplate).Name("NUMBERPLATE")
                .Member(m => m.Optiontype).Name("OPTIONTYPE")
                .Member(m => m.TaxAccCode).Name("TAX_ACC_CODE")
                .Member(m => m.FundAccCode).Name("FUND_ACC_CODE")
                .Member(m => m.SmmVatAccCode).Name("SMM_VAT_ACC_CODE")
                .Member(m => m.InflationIdx).Name("INFLATION_IDX")
                .Member(m => m.TranGrpNo).Name("TRAN_GRP_NO")
                .Member(m => m.TranGrpLineNo).Name("TRAN_GRP_LINE_NO")
                .Member(m => m.CashInfldx).Name("CASH_INFLDX")
                .Member(m => m.CashOrgLogoId).Name("CASH_ORGLOGOID")
                .Member(m => m.InvoiceOrgLogoId).Name("INVOICE_ORGLOGOID")
                .Member(m => m.VatInc).Name("VAT_INC")
                .Member(m => m.VatRat).Name("VAT_RAT")
                .Member(m => m.VatAccCode).Name("VAT_ACC_CODE")
                .Member(m => m.VatTot).Name("VAT_TOT")
                .Member(m => m.Status).Name("STATUS")
                .Member(m => m.AffectCollatrl).Name("AFFECT_COLLATRL")
                .Member(m => m.Grpfirmtrans).Name("GRPFIRMTRANS")
                .Member(m => m.TranNo).Name("TRAN_NO")
                .Member(m => m.DocNumber).Name("DOC_NUMBER")
                .Member(m => m.ControlInfo).Name("CONTROL_INFO")
                .Member(m => m.PosTransferInfo).Name("POS_TRANSFER_INFO")
                .Member(m => m.CsTransReference).Name("CS_TRANS_REFERENCE")
                .Member(m => m.TaxNr).Name("TAX_NR")
                .Member(m => m.AccFicheSiteid).Name("ACC_FICHE_SITEID")
                .Member(m => m.DocDate).Name("DOC_DATE")
                .Member(m => m.TaxOhpCode).Name("TAX_OHP_CODE")
                .Member(m => m.SmmVatOhpCode).Name("SMM_VAT_OHP_CODE")
                .Member(m => m.CashAccCode).Name("CASH_ACC_CODE")
                .Member(m => m.CashOhpCode).Name("CASH_OHP_CODE")
                .Member(m => m.SmmVatDeductAccCode).Name("SMM_VAT_DEDUCT_ACC_CODE")
                .Member(m => m.SmmVatDeductCenCode).Name("SMM_VAT_DEDUCT_CEN_CODE")
                .Member(m => m.SmmVatDeductOthAccCode).Name("SMM_VAT_DEDUCT_OTH_ACC_CODE")
                .Member(m => m.SmmVatDeductOthCenCode).Name("SMM_VAT_DEDUCT_OTH_CEN_CODE")
                .Member(m => m.SalesmanCode).Name("SALESMAN_CODE")
                .Member(m => m.SmmSerialCode).Name("SMM_SERIAL_CODE")
                .Member(m => m.EbookDocdate).Name("EBOOK_DOCDATE")
                .Member(m => m.EbookDocnr).Name("EBOOK_DOCNR")
                .Member(m => m.EbookExplain).Name("EBOOK_EXPLAIN")
                .Member(m => m.EbookPaytype).Name("EBOOK_PAYTYPE")
                ;
        }
    }
}
