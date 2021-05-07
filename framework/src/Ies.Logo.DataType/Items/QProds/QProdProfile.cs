using ExtendedXmlSerializer;
using ExtendedXmlSerializer.Configuration;
using Ies.Logo.DataType.Xml;

namespace Ies.Logo.DataType.Items.QProds
{
    public class QProdProfile : IConfigurationProfile
    {
        public static QProdProfile Default { get; } = new QProdProfile();

        private QProdProfile() { }

        public IConfigurationContainer Get(IConfigurationContainer parameter)
        {
            var configuration = parameter.Type<QProd>();

            Configure(configuration);

            return configuration;
        }

        public static void Configure<T>(ITypeConfiguration<T> typeConfigurations) where T : QProd
        {
            typeConfigurations.Configure();
            typeConfigurations.Name<T>("QPROD");

            typeConfigurations
               .Member(m => m.Amnt).Name("AMNT")
               .Member(m => m.Price).Name("PRICE")
               .Member(m => m.Perc).Name("PERC")
               .Member(m => m.LineNo).Name("LINENO")
               .Member(m => m.LostFactor).Name("LOSTFACTOR")
               .Member(m => m.CardType).Name("CARDTYPE")
               .Member(m => m.Scode).Name("SCODE")
               .Member(m => m.Sdef).Name("SDEF")
               .Member(m => m.Uedit).Name("UEDIT")
               .Member(m => m.Uunit).Name("UUNIT")
               ;
        }
    }
}
