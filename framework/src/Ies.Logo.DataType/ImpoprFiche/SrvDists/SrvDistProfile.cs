using ExtendedXmlSerializer;
using ExtendedXmlSerializer.Configuration;
using Ies.Logo.DataType.Xml;

namespace Ies.Logo.DataType.ImpoprFiche.SrvDists
{
    public class SrvDistProfile : IConfigurationProfile
    {
        public static SrvDistProfile Default { get; } = new SrvDistProfile();

        private SrvDistProfile() { }

        public IConfigurationContainer Get(IConfigurationContainer parameter)
        {
            var configuration = parameter.Type<SrvDist>();

            Configure(configuration);

            return configuration;
        }
        public static void Configure<T>(ITypeConfiguration<T> typeConfigurations) where T : SrvDist
        {
            typeConfigurations.Configure();
            typeConfigurations.Name<T>("SRV_DIST");

            typeConfigurations
                .Member(m => m.InternalReference).Name("INTERNAL_REFERENCE")
                .Member(m => m.InfoDistType).Name("INFO_DISTTYPE")
                .Member(m => m.SrvCode).Name("SRVCODE")
                .Member(m => m.SrvDefinition).Name("SRVDEFINITION")
                ;
        }
    }
}
