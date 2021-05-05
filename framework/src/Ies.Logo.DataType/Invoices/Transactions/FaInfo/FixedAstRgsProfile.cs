using ExtendedXmlSerializer;
using ExtendedXmlSerializer.Configuration;
using Ies.Logo.DataType.Xml;

namespace Ies.Logo.DataType.Invoices
{
    public class FixedAstRgsProfile : IConfigurationProfile
    {
        public static FixedAstRgsProfile Default { get; } = new FixedAstRgsProfile();

        private FixedAstRgsProfile() { }

        public IConfigurationContainer Get(IConfigurationContainer parameter)
        {
            var configuration = parameter.Type<FixedAstRgs>();

            Configure(configuration);

            return configuration;
        }

        public static void Configure<T>(ITypeConfiguration<T> typeConfigurations) where T : FixedAstRgs
        {
            typeConfigurations.Configure();
            typeConfigurations.Name<T>("FIXED_AST_RGS");

            typeConfigurations
                .Member(m => m.Code).Name("CODE")
                .Member(m => m.Transfer).Name("TRANSFER")
                .Member(m => m.DateAcquired).Name("DATE_ACQUIRED")
                .Member(m => m.DateDeprstart).Name("DATE_DEPRSTART")
                .Member(m => m.DateDeprstart2).Name("DATE_DEPRSTART2")
                .Member(m => m.Quantity).Name("QUANTITY")
                .Member(m => m.QuantityOut).Name("QUANTITY_OUT")
                .Member(m => m.AcqValue).Name("ACQ_VALUE")
                .Member(m => m.VatAmount).Name("VAT_AMOUNT")
                .Member(m => m.VatPostDur).Name("VAT_POST_DUR")
                .Member(m => m.DeprRate).Name("DEPR_RATE")
                .Member(m => m.DeprDur).Name("DEPR_DUR")
                .Member(m => m.DeprType).Name("DEPR_TYPE")
                .Member(m => m.Revaluate).Name("REVALUATE")
                .Member(m => m.RevDepr).Name("REV_DEPR")
                .Member(m => m.DeprRate2).Name("DEPR_RATE2")
                .Member(m => m.DeprDur2).Name("DEPR_DUR2")
                .Member(m => m.DeprType2).Name("DEPR_TYPE2")
                .Member(m => m.Revaluate2).Name("REVALUATE2")
                .Member(m => m.RevDepr2).Name("REV_DEPR2")
                .Member(m => m.PartialDepr).Name("PARTIAL_DEPR")
                .Member(m => m.RcXrate).Name("RC_XRATE")
                .Member(m => m.RcAcqValue).Name("RC_ACQ_VALUE")
                .Member(m => m.TotalExpenses).Name("TOTAL_EXPENSES")
                .Member(m => m.AccumDepr).Name("ACCUM_DEPR")
                .Member(m => m.AccumReval).Name("ACCUM_REVAL")
                .Member(m => m.RcTotalExpn).Name("RC_TOTAL_EXPN")
                .Member(m => m.RcAccumDepr).Name("RC_ACCUM_DEPR")
                .Member(m => m.RcAccumReval).Name("RC_ACCUM_REVAL")
                .Member(m => m.OpenReval).Name("OPEN_REVAL")
                .Member(m => m.OpenDepr).Name("OPEN_DEPR")
                .Member(m => m.OpenRevDepr).Name("OPEN_REVDEPR")
                .Member(m => m.OpenReval2).Name("OPEN_REVAL2")
                .Member(m => m.OpenDepr2).Name("OPEN_DEPR2")
                .Member(m => m.OpenRevDepr2).Name("OPEN_REVDEPR2")
                .Member(m => m.RcOpenRev).Name("RC_OPENREV")
                .Member(m => m.RcOpenDepr).Name("RC_OPENDEPR")
                .Member(m => m.RcOpenRevDepr).Name("RC_OPENREVDEPR")
                .Member(m => m.RcOpenRev2).Name("RC_OPENREV2")
                .Member(m => m.RcOpenDepr2).Name("RC_OPENDEPR2")
                .Member(m => m.RcOpenRevDepr2).Name("RC_OPENREVDEPR2")
                .Member(m => m.PartDep2).Name("PART_DEP2")
                .Member(m => m.DiffPrice).Name("DIFF_PRICE")
                .Member(m => m.DiffrepPrice).Name("DIFFREP_PRICE")
                .Member(m => m.DiscIncl).Name("DISC_INCL")
                .Member(m => m.DiscRate).Name("DISC_RATE")
                .Member(m => m.AnnualDistVal).Name("ANNUAL_DIST_VAL")
                .Member(m => m.InfBasedValue).Name("INF_BASED_VALUE")
                .Member(m => m.RegTypeCode).Name("REGTYPCODE")
                .Member(m => m.RegTypeDef).Name("REGTYPDEF")
                .Member(m => m.RegExpensCode).Name("REGEXPENSCODE")
                .Member(m => m.RegExpensDef).Name("REGEXPENSDEF")
                ;
        }
    }
}
