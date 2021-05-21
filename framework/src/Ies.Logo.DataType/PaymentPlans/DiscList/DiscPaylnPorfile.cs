using ExtendedXmlSerializer;
using ExtendedXmlSerializer.Configuration;
using Ies.Logo.DataType.Xml;

namespace Ies.Logo.DataType.PaymentPlans
{
    public class DiscPaylnPorfile : IConfigurationProfile
    {
        public static DiscPaylnPorfile Default { get; } = new DiscPaylnPorfile();

        private DiscPaylnPorfile() { }

        public IConfigurationContainer Get(IConfigurationContainer parameter)
        {
            var configuration = parameter.Type<DiscPayln>();

            Configure(configuration);

            return configuration;
        }

        public static void Configure<T>(ITypeConfiguration<T> typeConfigurations) where T : DiscPayln
        {
            typeConfigurations.Configure();
            typeConfigurations.Name<T>("DISCPAYLN");

            typeConfigurations
                .Member(m => m.Day).Name("DAY")
                .Member(m => m.Discrate).Name("DISCRATE")
                .Member(m => m.Wfstatus).Name("WFSTATUS")
                ;
        }
    }
}
