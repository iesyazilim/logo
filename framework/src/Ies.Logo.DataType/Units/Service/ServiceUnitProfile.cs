using ExtendedXmlSerializer;
using ExtendedXmlSerializer.Configuration;

namespace Ies.Logo.DataType.Units
{
    public class ServiceUnitProfile : IConfigurationProfile
    {
        public static ServiceUnitProfile Default { get; } = new ServiceUnitProfile();

        private ServiceUnitProfile() { }

        public IConfigurationContainer Get(IConfigurationContainer parameter)
        {
            var configuration = parameter.Type<ServiceUnit>();

            Configure(configuration);

            return configuration;
        }
        public static void Configure<T>(ITypeConfiguration<T> typeConfigurations) where T : ServiceUnit
        {
            UnitProfile.Configure(typeConfigurations);

            typeConfigurations
                .Member(m => m.Priority).Name("PRIORITY")
                ;
        }
    }
}
