using ExtendedXmlSerializer;
using ExtendedXmlSerializer.Configuration;
using Ies.Logo.DataType.Xml;

namespace Ies.Logo.DataType.GlAccounts
{
    public class GlAccountProfile : IConfigurationProfile 
    {
        public static GlAccountProfile Default { get; } = new GlAccountProfile();

        private GlAccountProfile() { }

        public IConfigurationContainer Get(IConfigurationContainer parameter)
        {
            var configuration = parameter.Type<GlAccount>();

            Configure(configuration);

            return configuration;
        }
        public static void Configure<T>(ITypeConfiguration<T> typeConfigurations) where T : GlAccount
        {
            typeConfigurations.Configure();
            typeConfigurations.Name<T>("GL_ACCOUNT");

            typeConfigurations
                .Member(m => m.Code).Name("CODE")
                .Member(m => m.Description).Name("DESCRIPTION")
                .Member(m => m.Description2).Name("DESCRIPTION2")
                .Member(m => m.Unit).Name("UNIT")
                .Member(m => m.OhpCode).Name("OHP_CODE")
                .Member(m => m.DiffaccCode).Name("DIFFACC_CODE")
                .Member(m => m.AccountType).Name("ACCOUNT_TYPE")
                .Member(m => m.MndtryQuan).Name("MNDTRY_QUAN")
                .Member(m => m.MndtryOhp).Name("MNDTRY_OHP")
                .Member(m => m.AccountChar).Name("ACCOUNT_CHAR")
                .Member(m => m.InflationFlag).Name("INFLATION_FLAG")
                .Member(m => m.DiffdebtaccCode).Name("DIFFDEBTACC_CODE")
                .Member(m => m.Category).Name("CATEGORY")
                .Member(m => m.ProjectControl).Name("PROJECT_CONTROL")
                .Member(m => m.InfDiffAcccode).Name("INF_DIFF_ACCCODE")
                .Member(m => m.Ccurency).Name("CCURRENCY")
                .Member(m => m.Curratetype).Name("CURRATETYPE")
                .Member(m => m.Fixedcurrtype).Name("FIXEDCURRTYPE")
                .Member(m => m.ClName).Name("CL_NAME")
                .Member(m => m.TaxNr).Name("TAX_NR")
                .Member(m => m.FoxTaxDecl).Name("FOR_TAX_DECL")
                .Member(m => m.VatAcc).Name("VAT_ACC")
                .Member(m => m.IsBdgtLine).Name("IS_BDGT_LINE")
                .Member(m => m.BdgtAccCode).Name("BDGT_ACC_CODE")
                .Member(m => m.BgdtReflAccCode).Name("BDGT_REFL_ACC_CODE")
                .Member(m => m.BdgtPayAccCode).Name("BDGT_PAY_ACC_CODE")
                .Member(m => m.BdgtPayReflAccCode).Name("BDGT_PAY_REFL_ACC_CODE")
                .Member(m => m.Crbdgtaccln).Name("CRBDGTACCLN")
                .Member(m => m.Crbdgtpayaln).Name("CRBDGTPAYALN")
                .Member(m => m.CorpCode1).Name("CORP_CODE1")
                .Member(m => m.CorpCode2).Name("CORP_CODE2")
                .Member(m => m.CorpCode3).Name("CORP_CODE3")
                .Member(m => m.CorpCode4).Name("CORP_CODE4")
                .Member(m => m.FuncCode1).Name("FUNC_CODE1")
                .Member(m => m.FuncCode2).Name("FUNC_CODE2")
                .Member(m => m.FuncCode3).Name("FUNC_CODE3")
                .Member(m => m.FuncCode4).Name("FUNC_CODE4")
                .Member(m => m.FinCode).Name("FIN_CODE")
                .Member(m => m.EcoCode1).Name("ECO_CODE1")
                .Member(m => m.EcoCode2).Name("ECO_CODE2")
                .Member(m => m.EcoCode3).Name("ECO_CODE3")
                .Member(m => m.EcoCode4).Name("ECO_CODE4")
                .Member(m => m.VatReflAccCode).Name("VAT_REFL_ACC_CODE")
                .Member(m => m.VatReflOthAccCode).Name("VAT_REFL_OTH_ACC_CODE")
                ;
        }
    }
}
