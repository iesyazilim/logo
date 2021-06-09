using ExtendedXmlSerializer;
using ExtendedXmlSerializer.Configuration;
using Ies.Logo.DataType.Xml;

namespace Ies.Logo.DataType.CqpnRolls
{
    public class CqpnRollProfile : IConfigurationProfile
    {
        public static CqpnRollProfile Default { get; } = new CqpnRollProfile();

        private CqpnRollProfile() { }

        public IConfigurationContainer Get(IConfigurationContainer parameter)
        {
            var configuration = parameter.Type<CqpnRoll>();

            Configure(configuration);

            return configuration;
        }
        public static void Configure<T>(ITypeConfiguration<T> typeConfigurations) where T : CqpnRoll
        {
            typeConfigurations.Configure();
            typeConfigurations.Name<T>("CHQPN_ROLL");

            typeConfigurations
                .Member(m => m.Type).Name("TYPE")
                .Member(m => m.Number).Name("NUMBER")
                .Member(m => m.DocNumber).Name("DOC_NUMBER")
                .Member(m => m.MasterModule).Name("MASTER_MODULE")
                .Member(m => m.MasterCode).Name("MASTER_CODE")
                .Member(m => m.OhpCode).Name("OHP_CODE")
                .Member(m => m.Date).Name("DATE")
                .Member(m => m.DestDivision).Name("DEST_DIVISION")
                .Member(m => m.DestDepartment).Name("DEST_DEPARTMENT")
                .Member(m => m.ProcType).Name("PROC_TYPE")
                .Member(m => m.SinglePayment).Name("SINGLE_PAYMENT")
                .Member(m => m.GlPosted).Name("GL_POSTED")
                .Member(m => m.AverageAge).Name("AVERAGE_AGE")
                .Member(m => m.DocumentCount).Name("DOCUMENT_COUNT")
                .Member(m => m.PrintCounter).Name("PRINT_COUNTER")
                .Member(m => m.PrintDate).Name("PRINT_DATE")
                .Member(m => m.Total).Name("TOTAL")
                .Member(m => m.CurrTrans).Name("CURR_TRANS")
                .Member(m => m.TcXrate).Name("TC_XRATE")
                .Member(m => m.TcTotal).Name("TC_TOTAL")
                .Member(m => m.RcXrate).Name("RC_XRATE")
                .Member(m => m.RcTotal).Name("RC_TOTAL")
                .Member(m => m.Accficheref).Name("ACCFICHEREF")
                .Member(m => m.GlCode).Name("GL_CODE")
                .Member(m => m.CurrselTotals).Name("CURRSEL_TOTALS")
                .Member(m => m.CurrselDetails).Name("CURRSEL_DETAILS")
                .Member(m => m.OpStatus).Name("OP_STATUS")
                .Member(m => m.InflationIdx).Name("INFLATION_IDX")
                .Member(m => m.CashTranGrpNo).Name("CASH_TRAN_GRP_NO")
                .Member(m => m.CashTranGrplineNo).Name("CASH_TRAN_GRPLINE_NO")
                .Member(m => m.CashInfldx).Name("CASH_INFLDX")
                .Member(m => m.CashOrglogoid).Name("CASH_ORGLOGOID")
                .Member(m => m.FromCash).Name("FROM_CASH")
                .Member(m => m.CollatrlRollref).Name("COLLATRL_ROLLREF")
                .Member(m => m.AffectCollatrl).Name("AFFECT_COLLATRL")
                .Member(m => m.Grpfirmtrans).Name("GRPFIRMTRANS")
                .Member(m => m.AffectRisk).Name("AFFECT_RISK")
                .Member(m => m.Bncreref).Name("BNCREREF")
                .Member(m => m.BankCreditCode).Name("BANK_CREDIT_CODE")
                .Member(m => m.BnkCreCtrlTot).Name("BNK_CRE_CTRL_TOT")
                .Member(m => m.FromBank).Name("FROM_BANK")
                .Member(m => m.DegActive).Name("DEG_ACTIVE")
                .Member(m => m.DegCurr).Name("DEG_CURR")
                .Member(m => m.DegCurrRate).Name("DEG_CURR_RATE")
                .Member(m => m.AccFicheSiteid).Name("ACC_FICHE_SITEID")
                .Member(m => m.SalesmanCode).Name("SALESMAN_CODE")
                .Member(m => m.CancelAutoGlProc).Name("CANCEL_AUTO_GL_PROC")
                .Member(m => m.EbookDocdate).Name("EBOOK_DOCDATE")
                .Member(m => m.EbookNodocument).Name("EBOOK_NODOCUMENT")
                .Member(m => m.EbookDocnr).Name("EBOOK_DOCNR")
                .Member(m => m.EbookDocType).Name("EBOOK_DOCTYPE")
                .Member(m => m.EbookExplain).Name("EBOOK_EXPLAIN")
                .Member(m => m.EbookPaytype).Name("EBOOK_PAYTYPE")
                .Member(m => m.EbookNopay).Name("EBOOK_NOPAY")
                .Member(m => m.DocDate).Name("DOC_DATE")
                .Member(m => m.DefnFldsList).Name("DEFNFLDSLIST")
                .Member(m => m.Transactions).Name("TRANSACTIONS")
                ;
        }
    }
}
