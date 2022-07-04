using ExtendedXmlSerializer;
using ExtendedXmlSerializer.Configuration;
using Ies.Logo.DataType.Xml;

namespace Ies.Logo.DataType.Units.SubUnits
{
    public class SubUnitProfile : IConfigurationProfile
    {
        public static SubUnitProfile Default { get; } = new SubUnitProfile();

        private SubUnitProfile() { }

        public IConfigurationContainer Get(IConfigurationContainer parameter)
        {
            var configuration = parameter.Type<SubUnit>();

            Configure(configuration);

            return configuration;
        }

        public static void Configure<T>(ITypeConfiguration<T> typeConfigurations) where T : SubUnit
        {
            typeConfigurations.Configure();
            typeConfigurations.Name<T>("UNIT");

            typeConfigurations
                .Member(m => m.Code).Name("CODE")
                .Member(m => m.Name).Name("NAME")
                .Member(m => m.UnitOrder).Name("UNIT_ORDER")
                .Member(m => m.MainUnit).Name("MAIN_UNIT")
                .Member(m => m.ConvFact1).Name("CONV_FACT1")
                .Member(m => m.ConvFact2).Name("CONV_FACT2")
                .Member(m => m.Divisible).Name("DIVISIBLE")
                .Member(m => m.GlobalCode).Name("GLOBAL_CODE");
        }
    }
}
