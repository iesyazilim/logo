using ExtendedXmlSerializer;
using ExtendedXmlSerializer.Configuration;
using Ies.Logo.DataType.Xml;

namespace Ies.Logo.DataType.ItemCharacteristics.Values
{
    public class CharacteristicValueProfile : IConfigurationProfile
    {
        public static CharacteristicValueProfile Default { get; } = new CharacteristicValueProfile();

        private CharacteristicValueProfile() { }

        public IConfigurationContainer Get(IConfigurationContainer parameter)
        {
            var configuration = parameter.Type<CharacteristicValue>();

            Configure(configuration);

            return configuration;
        }

        public static void Configure<T>(ITypeConfiguration<T> typeConfigurations) where T : CharacteristicValue
        {
            typeConfigurations.Configure();
            typeConfigurations.Name("VALUE");

            typeConfigurations
               .Member(m => m.Code).Name("CODE")
               .Member(m => m.Name).Name("NAME")
               .Member(m => m.ValNo).Name("VALNO")
               ;
        }
    }
}
