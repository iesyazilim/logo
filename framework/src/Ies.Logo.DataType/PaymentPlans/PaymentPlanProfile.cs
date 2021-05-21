using ExtendedXmlSerializer;
using ExtendedXmlSerializer.Configuration;
using Ies.Logo.DataType.Xml;

namespace Ies.Logo.DataType.PaymentPlans
{
    public class PaymentPlanProfile : IConfigurationProfile
    {
        public static PaymentPlanProfile Default { get; } = new PaymentPlanProfile();

        private PaymentPlanProfile() { }

        public IConfigurationContainer Get(IConfigurationContainer parameter)
        {
            var configuration = parameter.Type<PaymentPlan>();

            Configure(configuration);

            return configuration;
        }

        public static void Configure<T>(ITypeConfiguration<T> typeConfigurations) where T : PaymentPlan
        {
            typeConfigurations.Configure();
            typeConfigurations.Name<T>("PAYMENT_PLAN");

            typeConfigurations
                .Member(m => m.PaymentTerms).Name("PAYMENT_TERMS")
                .Member(m => m.DiscList).Name("DISCLIST")
                ;
        }
    }
}
