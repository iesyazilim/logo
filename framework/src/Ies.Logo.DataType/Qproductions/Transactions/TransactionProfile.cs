using ExtendedXmlSerializer;
using ExtendedXmlSerializer.Configuration;
using Ies.Logo.DataType.Xml;

namespace Ies.Logo.DataType.Qproductions
{
    public class TransactionProfile : IConfigurationProfile
    {
        public static TransactionProfile Default { get; } = new TransactionProfile();

        private TransactionProfile() { }

        public IConfigurationContainer Get(IConfigurationContainer parameter)
        {
            var configuration = parameter.Type<Transaction>();

            Configure(configuration);

            return configuration;
        }

        public static void Configure<T>(ITypeConfiguration<T> typeConfigurations) where T : Transaction
        {
            typeConfigurations.Configure();
            typeConfigurations.Name<T>("TRANSACTION");

            typeConfigurations
                .Member(m => m.Amnt).Name("AMNT")
                .Member(m => m.Price).Name("PRICE")
                .Member(m => m.Perc).Name("PERC")
                .Member(m => m.Lineno).Name("LINENO")
                .Member(m => m.Lostfactor).Name("LOSTFACTOR")
                .Member(m => m.Sourceindex).Name("SOURCEINDEX")
                .Member(m => m.Uomref).Name("UOMREF")
                .Member(m => m.Cardtype).Name("CARDTYPE")
                .Member(m => m.Scode).Name("SCODE")
                .Member(m => m.Sdef).Name("SDEF")
                .Member(m => m.Uedit).Name("UEDIT")
                .Member(m => m.Uunit).Name("UUNIT")
                .Member(m => m.CompType).Name("COMP_TYPE")
                ;
        }
    }
}
