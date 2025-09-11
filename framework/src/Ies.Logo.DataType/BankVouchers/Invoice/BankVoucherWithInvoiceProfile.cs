using ExtendedXmlSerializer;
using ExtendedXmlSerializer.Configuration;

namespace Ies.Logo.DataType.BankVouchers
{
    public class BankVoucherWithInvoiceProfile : IConfigurationProfile
    {
        public static BankVoucherWithInvoiceProfile Default { get; } = new BankVoucherWithInvoiceProfile();

        private BankVoucherWithInvoiceProfile() { }

        public IConfigurationContainer Get(IConfigurationContainer parameter)
        {
            var configuration = parameter.Type<BankVoucherWithInvoice>();

            Configure(configuration);

            return configuration;
        }

        public static void Configure<T>(ITypeConfiguration<T> typeConfigurations) where T : BankVoucherWithInvoice
        {
            BankVoucherProfile.Configure(typeConfigurations);

            typeConfigurations.Member(m => m.AttachmentInvoices).Name("ATTACHMENT_INVOICE");
            typeConfigurations.Member(m => m.BnAccCode).Name("BNACCCODE");
            //typeConfigurations.Type<Invoices.Transaction>().Name("INVOICE_TRANSACTION");
        }
    }
}
