using ExtendedXmlSerializer;
using ExtendedXmlSerializer.Configuration;
using Ies.Logo.DataType.Xml;

namespace Ies.Logo.DataType.SalesPeople
{
    public class SalesmanProfile : IConfigurationProfile
    {
        public static SalesmanProfile Default { get; } = new SalesmanProfile();

        private SalesmanProfile() { }

        public IConfigurationContainer Get(IConfigurationContainer parameter)
        {
            var configuration = parameter.Type<Salesman>();

            Configure(configuration);

            return configuration;
        }

        public static void Configure<T>(ITypeConfiguration<T> typeConfigurations) where T : Salesman
        {
            typeConfigurations.Configure();
            typeConfigurations.Name<T>("SALESMAN");

            typeConfigurations
                .Member(m => m.Code).Name("CODE")
                .Member(m => m.Name).Name("NAME")
                .Member(m => m.Position).Name("POSITION")
                .Member(m => m.FirmNo).Name("FIRM_NO")
                .Member(m => m.Targets).Name("TARGETS")
                ;
        }
    }
}
