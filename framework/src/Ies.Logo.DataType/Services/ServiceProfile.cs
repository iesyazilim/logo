using ExtendedXmlSerializer;
using ExtendedXmlSerializer.Configuration;
using Ies.Logo.DataType.Xml;

namespace Ies.Logo.DataType.Services
{
    public class ServiceProfile : IConfigurationProfile
    {
        public static ServiceProfile Default { get; } = new ServiceProfile();

        private ServiceProfile() { }

        public IConfigurationContainer Get(IConfigurationContainer parameter)
        {
            var configuration = parameter.Type<Service>();

            Configure(configuration);

            return configuration;
        }

        public static void Configure<T>(ITypeConfiguration<T> typeConfigurations) where T : Service
        {
            typeConfigurations.Configure();
            typeConfigurations.Name<T>("SERVICE");
            
            typeConfigurations
                .Member(m => m.CardType).Name("CARD_TYPE")
                .Member(m => m.Code).Name("CODE")
                .Member(m => m.Description).Name("DESCRIPTION")
                .Member(m => m.Description2).Name("DESCRIPTION2")
                .Member(m => m.VatPerc).Name("VAT_PERC")
                .Member(m => m.UnitsetCode).Name("UNITSET_CODE")
                .Member(m => m.Returnvat).Name("RETURNVAT")
                .Member(m => m.ImportExpenses).Name("IMPORT_EXPENSES")
                .Member(m => m.AffectCost).Name("AFFECT_COST")
                .Member(m => m.AddTaxcode).Name("ADD_TAXCODE")
                .Member(m => m.DistType).Name("DIST_TYPE")
                .Member(m => m.Candeduct).Name("CANDEDUCT")
                .Member(m => m.DeductionPart1).Name("DEDUCTION_PART1")
                .Member(m => m.DeductionPart2).Name("DEDUCTION_PART2")
                .Member(m => m.ExtAccessFlags).Name("EXT_ACCESS_FLAGS")
                .Member(m => m.Currdif).Name("CURRDIFF")
                .Member(m => m.WhParams).Name("WH_PARAMS")
                .Member(m => m.Units).Name("UNITS")
                .Member(m => m.GlLinks).Name("GL_LINKS")
                ;
        }

    }
}
