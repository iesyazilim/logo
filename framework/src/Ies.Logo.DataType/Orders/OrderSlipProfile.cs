using ExtendedXmlSerializer;
using ExtendedXmlSerializer.Configuration;
using Ies.Logo.DataType.Xml;

namespace Ies.Logo.DataType.Orders
{
    public class OrderSlipProfile : IConfigurationProfile
    {
        public static OrderSlipProfile Default { get; } = new OrderSlipProfile();

        private OrderSlipProfile() { }

        public IConfigurationContainer Get(IConfigurationContainer parameter)
        {
            var configuration = parameter.Type<OrderSlip>();

            Configure(configuration);

            return configuration;
        }

        public static void Configure<T>(ITypeConfiguration<T> typeConfigurations) where T : OrderSlip
        {
            typeConfigurations.Configure();
            typeConfigurations.Name<T>("ORDER_SLIP");

            typeConfigurations
                .Member(m => m.IsSales).Ignore()
                ;
        }
    }
}
