using ExtendedXmlSerializer;
using ExtendedXmlSerializer.Configuration;
using IesYazilim.Logo.DataType.Xml;

namespace IesYazilim.Logo.DataType.Payments
{
    public class DiscPaytrProfile : IConfigurationProfile
    {
        public static DiscPaytrProfile Default { get; } = new DiscPaytrProfile();

        private DiscPaytrProfile() { }

        public IConfigurationContainer Get(IConfigurationContainer parameter)
        {
            var configuration = parameter.Type<DiscPaytr>();

            Configure(configuration);

            return configuration;
        }

        public static void Configure<T>(ITypeConfiguration<T> typeConfigurations) where T : DiscPaytr
        {
            typeConfigurations.Configure();
            typeConfigurations.Name<T>("DISCPAYTR");

            typeConfigurations
                .Member(m => m.TrCode).Name("TRCODE")
                .Member(m => m.ModuleNr).Name("MODULENR")
                .Member(m => m.Tsign).Name("TSIGN")
                .Member(m => m.DiscRate).Name("DISC_RATE")
                .Member(m => m.DiscDueDate).Name("DISCDUE_DATE")
                .Member(m => m.WfStatus).Name("WFSTATUS")
                ;
        }
    }
}
