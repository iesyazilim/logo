using ExtendedXmlSerializer;
using ExtendedXmlSerializer.Configuration;
using IesYazilim.Logo.DataType.Xml;

namespace IesYazilim.Logo.DataType.Invoices
{
    public class OkcInfoProfile : IConfigurationProfile
    {
        public static OkcInfoProfile Default { get; } = new OkcInfoProfile();

        private OkcInfoProfile() { }

        public IConfigurationContainer Get(IConfigurationContainer parameter)
        {
            var configuration = parameter.Type<OkcInfo>();

            Configure(configuration);

            return configuration;
        }

        public static void Configure<T>(ITypeConfiguration<T> typeConfigurations) where T : OkcInfo
        {
            typeConfigurations.Configure();
            typeConfigurations.Name<T>("OKCINFO");

            typeConfigurations
                .Member(m => m.FicheType).Name("FICHE_TYPE")
                .Member(m => m.FicheNumber).Name("FICHE_NUMBER")
                .Member(m => m.Date).Name("DATE")
                .Member(m => m.Time).Name("TIME")
                .Member(m => m.SerialNumber).Name("SERIAL_NUMBER")
                .Member(m => m.ZNumber).Name("Z_NUMBER")
                .Member(m => m.FixedValue).Name("FIXED_VALUE")
                .Member(m => m.LineNumber).Name("LINE_NUMBER")
                ;
        }
    }
}
