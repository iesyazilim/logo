using ExtendedXmlSerializer;
using ExtendedXmlSerializer.Configuration;

namespace Ies.Logo.DataType.WhParams
{
    public class ServiceWhParamProfile : IConfigurationProfile
    {
        public static ServiceWhParamProfile Default { get; } = new ServiceWhParamProfile();
        private ServiceWhParamProfile() { }
        public IConfigurationContainer Get(IConfigurationContainer parameter)
        {
            var configuration = parameter.Type<ServiceWhParam>();

            Configure(configuration);

            return configuration;
        }
        public static void Configure<T>(ITypeConfiguration<T> typeConfigurations) where T : ServiceWhParam
        {
            WhParamProfile.Configure(typeConfigurations);

            typeConfigurations
              .Member(m => m.LeadTime).Name("LEAD_TIME");
        }
    }
}
