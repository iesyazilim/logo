using ExtendedXmlSerializer;
using ExtendedXmlSerializer.Configuration;
using Logo.DataType.Xml;

namespace Logo.DataType.Items
{
    public class ValRefNodeProfile : IConfigurationProfile
    {
        public static ValRefNodeProfile Default { get; } = new ValRefNodeProfile();

        private ValRefNodeProfile() { }

        public IConfigurationContainer Get(IConfigurationContainer parameter)
        {
            var configuration = parameter.Type<ValRefNode>();

            Configure(configuration);

            return configuration;
        }

        public static void Configure<T>(ITypeConfiguration<T> typeConfigurations) where T : ValRefNode
        {
            typeConfigurations.Configure();
            typeConfigurations.Name<T>("VALREFNODE");

            typeConfigurations
               .Member(m => m.ValCode).Name("VALCODE")
               ;
        }
    }
}
