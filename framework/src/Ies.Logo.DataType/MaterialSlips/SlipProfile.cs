using ExtendedXmlSerializer;
using ExtendedXmlSerializer.Configuration;
using Ies.Logo.DataType.Xml;

namespace Ies.Logo.DataType.MaterialSlips
{
    public class SlipProfile : IConfigurationProfile
    {
        public static SlipProfile Default { get; } = new SlipProfile();

        private SlipProfile() { }

        public IConfigurationContainer Get(IConfigurationContainer parameter)
        {
            var configuration = parameter.Type<Slip>();

            Configure(configuration);

            return configuration;
        }

        public static void Configure<T>(ITypeConfiguration<T> typeConfigurations) where T : Slip
        {
            typeConfigurations.Configure();
            typeConfigurations.Name<T>("SLIP");

            typeConfigurations
                .Member(m => m.Transactions).Name("TRANSACTIONS")
                ;
        }
    }
}
