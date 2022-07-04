using ExtendedXmlSerializer;
using ExtendedXmlSerializer.Configuration;
using Ies.Logo.DataType.Xml;

namespace Ies.Logo.DataType.Units
{
    public class UnitSetProfile : IConfigurationProfile
    {
        public static UnitSetProfile Default { get; } = new UnitSetProfile();

        private UnitSetProfile() { }

        public IConfigurationContainer Get(IConfigurationContainer parameter)
        {
            var configuration = parameter.Type<UnitSet>();

            Configure(configuration);

            return configuration;
        }

        public static void Configure<T>(ITypeConfiguration<T> typeConfigurations) where T : UnitSet
        {
            typeConfigurations.Configure();
            typeConfigurations.Name<T>("UNIT_SET");

            typeConfigurations
                .Member(m => m.Code).Name("CODE")
                .Member(m => m.Description).Name("DESCRIPTION")
                .Member(m => m.Type).Name("TYPE")
                .Member(m => m.Units).Name("UNITS");

        }
    }
}
