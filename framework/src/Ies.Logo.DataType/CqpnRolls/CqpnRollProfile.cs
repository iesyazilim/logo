using ExtendedXmlSerializer;
using ExtendedXmlSerializer.Configuration;
using Ies.Logo.DataType.Xml;

namespace Ies.Logo.DataType.CqpnRolls
{
    public class CqpnRollProfile : IConfigurationProfile
    {
        public static CqpnRollProfile Default { get; } = new CqpnRollProfile();

        private CqpnRollProfile() { }

        public IConfigurationContainer Get(IConfigurationContainer parameter)
        {
            var configuration = parameter.Type<CqpnRoll>();

            Configure(configuration);

            return configuration;
        }
        public static void Configure<T>(ITypeConfiguration<T> typeConfigurations) where T : CqpnRoll
        {
            typeConfigurations.Configure();
            typeConfigurations.Name<T>("CHQPN_ROLL");

            typeConfigurations
                .Member(m => m.DefnFldsList).Name("DEFNFLDSLIST")
                .Member(m => m.Transactions).Name("TRANSACTIONS")
                ;
        }
    }
}
