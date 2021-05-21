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
                .Member(m => m.Code).Name("CODE")
                .Member(m => m.Description).Name("DESCRIPTION")
                .Member(m => m.EarlyIntrate).Name("EARLY_INTRATE")
                .Member(m => m.LateIntrate).Name("LATE_INTRATE")
                .Member(m => m.Counter).Name("COUNTER")
                .Member(m => m.WorkDays).Name("WORK_DAYS")
                .Member(m => m.PpGroupCode).Name("PP_GROUP_CODE")
                .Member(m => m.CrdcardCode).Name("CRDCARD_CODE")
                .Member(m => m.PpGroupRef).Name("PP_GROUP_REF")
                .Member(m => m.GlobalCode).Name("GLOBAL_CODE")
                .Member(m => m.PaymentTerms).Name("PAYMENT_TERMS")
                .Member(m => m.DiscList).Name("DISCLIST")
                ;
        }
    }
}
