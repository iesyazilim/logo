using ExtendedXmlSerializer;
using ExtendedXmlSerializer.Configuration;
using Ies.Logo.DataType.Xml;

namespace Ies.Logo.DataType.ItemCharacteristics
{
    public class CharacteristicCodeProfile : IConfigurationProfile
    {
        public static CharacteristicCodeProfile Default { get; } = new CharacteristicCodeProfile();

        private CharacteristicCodeProfile() { }

        public IConfigurationContainer Get(IConfigurationContainer parameter)
        {
            var configuration = parameter.Type<CharacteristicCode>();

            Configure(configuration);

            return configuration;
        }

        public static void Configure<T>(ITypeConfiguration<T> typeConfigurations) where T : CharacteristicCode
        {
            typeConfigurations.Configure();
            typeConfigurations.Name("CHARACTERISTIC_CODES");

            typeConfigurations
               .Member(m => m.Code).Name("CODE")
               .Member(m => m.Name).Name("NAME")
               .Member(m => m.AuxilCode).Name("AUXIL_CODE")
               .Member(m => m.AuthCode).Name("AUTH_CODE")
               .Member(m => m.Values).Name("VALUES")
               ;
        }
    }
}
