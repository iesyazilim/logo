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
                .Member(m => m.WhParams).Name("WH_PARAMS")
                .Member(m => m.Units).Name("UNITS")
                .Member(m => m.GlLinks).Name("GL_LINKS")
                ;
        }

    }
}
