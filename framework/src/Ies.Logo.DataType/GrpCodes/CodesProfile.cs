using ExtendedXmlSerializer;
using ExtendedXmlSerializer.Configuration;
using Ies.Logo.DataType.Xml;

namespace Ies.Logo.DataType.GrpCodes
{
    public class CodesProfile : IConfigurationProfile
    {
        public static CodesProfile Default { get; } = new CodesProfile();

        private CodesProfile() { }

        public IConfigurationContainer Get(IConfigurationContainer parameter)
        {
            var configuration = parameter.Type<Codes>();

            Configure(configuration);

            return configuration;
        }
        public static void Configure<T>(ITypeConfiguration<T> typeConfigurations) where T : Codes
        {
            typeConfigurations.Configure();
            typeConfigurations.Name<T>("CODES");

            typeConfigurations
                .Member(m => m.CodeType).Name("CODE_TYPE")
                .Member(m => m.SpeCodeType).Name("SPE_CODE_TYPE")
                .Member(m => m.Code).Name("CODE")
                .Member(m => m.Definition).Name("DEFINITION")
                .Member(m => m.Definition2).Name("DEFINITION2")
                .Member(m => m.Definition3).Name("DEFINITION3")
                .Member(m => m.Color).Name("COLOR")
                .Member(m => m.Wincolor).Name("WINCOLOR")
                ;
        }
    }
}
