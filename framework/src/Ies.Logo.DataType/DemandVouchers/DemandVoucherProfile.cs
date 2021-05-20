using ExtendedXmlSerializer;
using ExtendedXmlSerializer.Configuration;
using Ies.Logo.DataType.Xml;

namespace Ies.Logo.DataType.DemandVouchers
{
    public class DemandVoucherProfile : IConfigurationProfile
    {
        public static DemandVoucherProfile Default { get; } = new DemandVoucherProfile();

        private DemandVoucherProfile() { }

        public IConfigurationContainer Get(IConfigurationContainer parameter)
        {
            var configuration = parameter.Type<DemandVoucher>();

            Configure(configuration);

            return configuration;
        }
        public static void Configure<T>(ITypeConfiguration<T> typeConfigurations) where T : DemandVoucher
        {
            typeConfigurations.Configure();
            typeConfigurations.Name<T>("DEMAND_VOUCHER");

            typeConfigurations
              .Member(m => m.Transactions).Name("TRANSACTIONS")
              ;
        }
    }
}
