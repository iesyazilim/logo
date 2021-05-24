using ExtendedXmlSerializer;
using ExtendedXmlSerializer.Configuration;
using Ies.Logo.DataType.Xml;

namespace Ies.Logo.DataType.Qproductions
{
    public class QProductionProfile : IConfigurationProfile
    {
        public static QProductionProfile Default { get; } = new QProductionProfile();

        private QProductionProfile() { }

        public IConfigurationContainer Get(IConfigurationContainer parameter)
        {
            var configuration = parameter.Type<QProduction>();

            Configure(configuration);

            return configuration;
        }

        public static void Configure<T>(ITypeConfiguration<T> typeConfigurations) where T : QProduction
        {
            typeConfigurations.Configure();
            typeConfigurations.Name<T>("QPRODUCTION");

            typeConfigurations
                .Member(m => m.Transactions).Name("TRANSACTIONS")
                ;
        }
    }
}
