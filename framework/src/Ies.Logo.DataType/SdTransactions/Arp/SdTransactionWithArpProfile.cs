using ExtendedXmlSerializer;
using ExtendedXmlSerializer.Configuration;

namespace Ies.Logo.DataType.SdTransactions
{
    public class SdTransactionWithArpProfile : IConfigurationProfile
    {
        public static SdTransactionWithArpProfile Default { get; } = new SdTransactionWithArpProfile();

        private SdTransactionWithArpProfile() { }

        public IConfigurationContainer Get(IConfigurationContainer parameter)
        {
            var configuration = parameter.Type<SdTransactionWithArp>();
            
            Configure(configuration);

            return configuration;
        }

        public static void Configure<T>(ITypeConfiguration<T> typeConfigurations) where T : SdTransactionWithArp
        {
            SdTransactionProfile.Configure(typeConfigurations);

            typeConfigurations
                .Member(m => m.AttachmentArp).Ignore()
                .Member(m => m.AttachmentArps).Name("ATTACHMENT_ARP")
                ;
        }
    }
}
