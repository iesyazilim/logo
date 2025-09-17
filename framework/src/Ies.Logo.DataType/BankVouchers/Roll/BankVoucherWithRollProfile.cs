using ExtendedXmlSerializer;
using ExtendedXmlSerializer.Configuration;

namespace Ies.Logo.DataType.BankVouchers
{
    public class BankVoucherWithRollProfile : IConfigurationProfile
    {
        public static BankVoucherWithRollProfile Default { get; } = new BankVoucherWithRollProfile();

        private BankVoucherWithRollProfile() { }

        public IConfigurationContainer Get(IConfigurationContainer parameter)
        {
            var configuration = parameter.Type<BankVoucherWithRoll>();

            Configure(configuration);

            return configuration;
        }

        public static void Configure<T>(ITypeConfiguration<T> typeConfigurations) where T : BankVoucherWithRoll
        {
            BankVoucherProfile.Configure(typeConfigurations);

            typeConfigurations.Member(m => m.AttachmentRolls).Name("ATTACHMENT_ROLL");
            typeConfigurations.Member(m => m.BnAccCode).Name("BNACCCODE");
        }
    }
}
