using ExtendedXmlSerializer;
using ExtendedXmlSerializer.Configuration;
using IesYazilim.Logo.DataType.Xml;

namespace IesYazilim.Logo.DataType.Units
{
    public class UnitProfile : IConfigurationProfile
    {
        public static UnitProfile Default { get; } = new UnitProfile();

        private UnitProfile() { }

        public IConfigurationContainer Get(IConfigurationContainer parameter)
        {
            var configuration = parameter.Type<Unit>();

            Configure(configuration);

            return configuration;
        }
        public static void Configure<T>(ITypeConfiguration<T> typeConfigurations) where T : Unit
        {
            typeConfigurations.Configure();
            typeConfigurations.Name<T>("UNIT");

            typeConfigurations
                .Member(m => m.UnitCode).Name("UNIT_CODE")
                ;
         }
    }
}
