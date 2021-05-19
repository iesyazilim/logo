using ExtendedXmlSerializer;
using ExtendedXmlSerializer.Configuration;
using Ies.Logo.DataType.Xml;

namespace Ies.Logo.DataType.BankVouchers
{
    public class BankVoucherProfile : IConfigurationProfile
    {
        public static BankVoucherProfile Default { get; } = new BankVoucherProfile();

        private BankVoucherProfile() { }

        public IConfigurationContainer Get(IConfigurationContainer parameter)
        {
            var configuration = parameter.Type<BankVoucher>();

            Configure(configuration);

            return configuration;
        }
        public static void Configure<T>(ITypeConfiguration<T> typeConfigurations) where T : BankVoucher
        {
            typeConfigurations.Configure();
            typeConfigurations.Name<T>("BANK_VOUCHER");

            typeConfigurations
                .Member(m => m.DefnFldsList).Name("DEFNFLDSLIST")
                .Member(m => m.Transactions).Name("TRANSACTIONS")
                ;
        }
    }
}
