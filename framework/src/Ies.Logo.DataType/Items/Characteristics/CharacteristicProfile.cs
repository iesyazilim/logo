using ExtendedXmlSerializer;
using ExtendedXmlSerializer.Configuration;
using Ies.Logo.DataType.Xml;

namespace Ies.Logo.DataType.Items
{
    public class CharacteristicProfile : IConfigurationProfile
    {
        public static CharacteristicProfile Default { get; } = new CharacteristicProfile();

        private CharacteristicProfile() { }

        public IConfigurationContainer Get(IConfigurationContainer parameter)
        {
            var configuration = parameter.Type<Characteristic>();

            Configure(configuration);

            return configuration;
        }

        public static void Configure<T>(ITypeConfiguration<T> typeConfigurations) where T : Characteristic
        {
            typeConfigurations.Configure();
            typeConfigurations.Name<T>("CHARACTERISTIC");

            typeConfigurations
               .Member(m => m.LineNr).Name("LINENR")
               .Member(m => m.MatrixLoc).Name("MATRIXLOC")
               .Member(m => m.Priority).Name("PRIORITY")
               .Member(m => m.Ccode).Name("CCODE")
               .Member(m => m.Vcode).Name("VCODE")
               .Member(m => m.Values).Name("VALUES")
               ;
        }
    }
}
