using ExtendedXmlSerializer;
using ExtendedXmlSerializer.Configuration;
using Logo.DataType.Xml;

namespace Logo.DataType.GlLinks
{
    public class GlLinkProfile : IConfigurationProfile
    {
        public static GlLinkProfile Default { get; } = new GlLinkProfile();

        private GlLinkProfile() { }

        public IConfigurationContainer Get(IConfigurationContainer parameter)
        {
            var configuration = parameter.Type<GlLink>();

            Configure(configuration);

            return configuration;
        }

        public static void Configure<T>(ITypeConfiguration<T> typeConfigurations) where T : GlLink
        {
            typeConfigurations.Configure();
            typeConfigurations.Name<T>("GL_LINK");

            typeConfigurations
                .Member(m => m.InfoType).Name("INFO_TYPE")
                .Member(m => m.GlaccCode).Name("GLACC_CODE")
                .Member(m => m.OhpCode).Name("OHP_CODE")
                ;
        }
    }
}
