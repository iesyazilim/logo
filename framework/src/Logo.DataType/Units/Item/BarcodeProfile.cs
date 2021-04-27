using ExtendedXmlSerializer;
using ExtendedXmlSerializer.Configuration;
using Logo.DataType.Xml;

namespace Logo.DataType.Units
{
    public class BarcodeProfile : IConfigurationProfile
    {
        public static BarcodeProfile Default { get; } = new BarcodeProfile();

        private BarcodeProfile() { }

        public IConfigurationContainer Get(IConfigurationContainer parameter)
        {
            var configuration = parameter.Type<Barcode>();

            Configure(configuration);

            return configuration;
        }

        public static void Configure<T>(ITypeConfiguration<T> typeConfigurations) where T : Barcode
        {
            typeConfigurations.Configure();
            typeConfigurations.Name<T>("BARCODE");

            typeConfigurations
                .Member(m => m.BARCODE).Name("BARCODE")
                .Member(m => m.Type).Name("TYPE")
                .Member(m => m.WbarcodeShift).Name("WBARCODESHIFT")
                ;
        }
    }
}
