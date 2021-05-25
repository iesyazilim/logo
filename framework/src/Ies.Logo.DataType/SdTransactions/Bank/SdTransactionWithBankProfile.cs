using ExtendedXmlSerializer;
using ExtendedXmlSerializer.Configuration;

namespace Ies.Logo.DataType.SdTransactions
{
    public class SdTransactionWithBankProfile : IConfigurationProfile
    {
        public static SdTransactionWithBankProfile Default { get; } = new SdTransactionWithBankProfile();

        private SdTransactionWithBankProfile() { }

        public IConfigurationContainer Get(IConfigurationContainer parameter)
        {
            var configuration = parameter.Type<SdTransactionWithBank>();
            
            Configure(configuration);

            return configuration;
        }

        public static void Configure<T>(ITypeConfiguration<T> typeConfigurations) where T : SdTransactionWithBank
        {
            SdTransactionProfile.Configure(typeConfigurations);

            typeConfigurations
                .Member(m => m.AttachmentBank).Ignore()
                .Member(m => m.AttachmentBanks).Name("ATTACHMENT_BANK")
                ;
        }
    }
}
