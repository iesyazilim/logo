using ExtendedXmlSerializer;
using ExtendedXmlSerializer.Configuration;
using IesYazilim.Logo.DataType.Xml;

namespace IesYazilim.Logo.DataType.WhParams
{
    public class WhParamProfile : IConfigurationProfile
    {
        public static WhParamProfile Default { get; } = new WhParamProfile();

        private WhParamProfile() { }

        public IConfigurationContainer Get(IConfigurationContainer parameter)
        {
            var configuration = parameter.Type<WhParam>();

            Configure(configuration);

            return configuration;
        }
        public static void Configure<T>(ITypeConfiguration<T> typeConfigurations) where T : WhParam
        {
            typeConfigurations.Configure();
            typeConfigurations.Name<T>("WH_PARAM");

            typeConfigurations
                .Member(m => m.WhNumber).Name("WH_NUMBER")
                ;
        }
    }
}
