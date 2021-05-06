using ExtendedXmlSerializer;
using ExtendedXmlSerializer.Configuration;
using IesYazilim.Logo.DataType.Xml;

namespace IesYazilim.Logo.DataType.Items
{
    public class ValueProfile : IConfigurationProfile
    {
        public static ValueProfile Default { get; } = new ValueProfile();

        private ValueProfile() { }

        public IConfigurationContainer Get(IConfigurationContainer parameter)
        {
            var configuration = parameter.Type<Value>();

            Configure(configuration);

            return configuration;
        }

        public static void Configure<T>(ITypeConfiguration<T> typeConfigurations) where T : Value
        {
            typeConfigurations.Configure();
            typeConfigurations.Name<T>("VALUE");

            typeConfigurations
               .Member(m => m.Vcode).Name("VCODE")
               .Member(m => m.Vname).Name("VNAME")
               ;
        }
    }
}
