using ExtendedXmlSerializer;
using ExtendedXmlSerializer.Configuration;
using Ies.Logo.DataType.Xml;

namespace Ies.Logo.DataType.ArpVouchers
{
    public class ArpVoucherProfile : IConfigurationProfile
    {
        public static ArpVoucherProfile Default { get; } = new ArpVoucherProfile();

        private ArpVoucherProfile() { }

        public IConfigurationContainer Get(IConfigurationContainer parameter)
        {
            var configuration = parameter.Type<ArpVoucher>();

            Configure(configuration);

            return configuration;
        }

        public static void Configure<T>(ITypeConfiguration<T> typeConfigurations) where T : ArpVoucher
        {
            typeConfigurations.Configure();
            typeConfigurations.Name<T>("ARP_VOUCHER");

            typeConfigurations
                 .Member(m => m.DefnFldsList).Name("DEFNFLDSLIST")
                 .Member(m => m.Transactions).Name("TRANSACTIONS")
                 ;

        }
    }
}
