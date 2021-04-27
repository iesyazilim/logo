using ExtendedXmlSerializer;
using ExtendedXmlSerializer.Configuration;
using Logo.DataType.Xml;

namespace Logo.DataType.Invoices
{
    public class IntelProfile : IConfigurationProfile
    {
        public static IntelProfile Default { get; } = new IntelProfile();

        private IntelProfile() { }

        public IConfigurationContainer Get(IConfigurationContainer parameter)
        {
            var configuration = parameter.Type<Intel>();

            Configure(configuration);

            return configuration;
        }
        public static void Configure<T>(ITypeConfiguration<T> typeConfigurations) where T : Intel
        {
            typeConfigurations.Configure();
            typeConfigurations.Name<T>("INTEL");

            typeConfigurations
                .Member(m => m.InvoiceInfo1).Name("INVOICEINFO1")
                .Member(m => m.InvoiceInfo2).Name("INVOICEINFO2")
                .Member(m => m.InvoiceInfo3).Name("INVOICEINFO3")
                .Member(m => m.InvoiceInfo4).Name("INVOICEINFO4")
                .Member(m => m.InvoiceInfo5).Name("INVOICEINFO5")
                .Member(m => m.InvoiceInfo6).Name("INVOICEINFO6")
                .Member(m => m.InvoiceInfo7).Name("INVOICEINFO7")
                .Member(m => m.InvoiceInfo8).Name("INVOICEINFO8")
                .Member(m => m.InvoiceInfo9).Name("INVOICEINFO9")
                .Member(m => m.InvoiceInfo10).Name("INVOICEINFO10")
                .Member(m => m.IntelDesc).Name("INTELDESC")
                .Member(m => m.LineNum).Name("LINENUM")
                ;
        }
    }
}
