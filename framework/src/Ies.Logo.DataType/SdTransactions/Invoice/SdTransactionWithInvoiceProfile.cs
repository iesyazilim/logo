using ExtendedXmlSerializer;
using ExtendedXmlSerializer.Configuration;

namespace Ies.Logo.DataType.SdTransactions
{
    public class SdTransactionWithInvoiceProfile : IConfigurationProfile
    {
        public static SdTransactionWithInvoiceProfile Default { get; } = new SdTransactionWithInvoiceProfile();

        private SdTransactionWithInvoiceProfile() { }

        public IConfigurationContainer Get(IConfigurationContainer parameter)
        {
            var configuration = parameter.Type<SdTransactionWithInvoice>();
            
            Configure(configuration);

            return configuration;
        }

        public static void Configure<T>(ITypeConfiguration<T> typeConfigurations) where T : SdTransactionWithInvoice
        {
            SdTransactionProfile.Configure(typeConfigurations);

            typeConfigurations
                .Member(m => m.AttachmentInvoice).Ignore()
                .Member(m => m.AttachmentInvoices).Name("ATTACHMENT_INVOICE")
                ;
        }
    }
}
