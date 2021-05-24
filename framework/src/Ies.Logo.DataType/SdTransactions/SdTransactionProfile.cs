using ExtendedXmlSerializer;
using ExtendedXmlSerializer.Configuration;
using Ies.Logo.DataType.Xml;

namespace Ies.Logo.DataType.SdTransactions
{
    public class SdTransactionProfile : IConfigurationProfile
    {
        public static SdTransactionProfile Default { get; } = new SdTransactionProfile();

        private SdTransactionProfile() { }

        public IConfigurationContainer Get(IConfigurationContainer parameter)
        {
            var configuration = parameter.Type<SdTransaction>();

            Configure(configuration);

            return configuration;
        }

        public static void Configure<T>(ITypeConfiguration<T> typeConfigurations) where T : SdTransaction
        {
            typeConfigurations.Configure();
            typeConfigurations.Name<T>("SD_TRANSACTION");

            typeConfigurations
                .Member(m => m.AttachmentArp).Name("ATTACHMENT_ARP")
                .Member(m => m.AttachmentBank).Name("ATTACHMENT_BANK")
                .Member(m => m.AttachmentInvoice).Name("ATTACHMENT_INVOICE")
                ;
        }
    }
}
