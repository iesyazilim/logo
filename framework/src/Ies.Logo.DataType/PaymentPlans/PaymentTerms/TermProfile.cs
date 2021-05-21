using ExtendedXmlSerializer;
using ExtendedXmlSerializer.Configuration;
using Ies.Logo.DataType.Xml;

namespace Ies.Logo.DataType.PaymentPlans
{
    public class TermProfile : IConfigurationProfile
    {
        public static TermProfile Default { get; } = new TermProfile();

        private TermProfile() { }

        public IConfigurationContainer Get(IConfigurationContainer parameter)
        {
            var configuration = parameter.Type<Term>();

            Configure(configuration);

            return configuration;
        }

        public static void Configure<T>(ITypeConfiguration<T> typeConfigurations) where T : Term
        {
            typeConfigurations.Configure();
            typeConfigurations.Name<T>("TERM");

            typeConfigurations
                .Member(m => m.Lineno).Name("LINENO")
                .Member(m => m.AfterDays).Name("AFTER_DAYS")
                .Member(m => m.Formula).Name("FORMULA")
                .Member(m => m.Condition).Name("CONDITION")
                .Member(m => m.Day).Name("DAY")
                .Member(m => m.Month).Name("MOUNTH")
                .Member(m => m.Year).Name("YEAR")
                .Member(m => m.RoundBase).Name("ROUND_BASE")
                .Member(m => m.AbsoluteDate).Name("ABSOLUTE_DATE")
                .Member(m => m.DateSelector).Name("DATE_SELECTOR")
                .Member(m => m.DiscRate).Name("DISC_RATE")
                .Member(m => m.PaymentType).Name("PAYMENT_TYPE")
                .Member(m => m.BankaccCode).Name("BANKACC_CODE")
                .Member(m => m.RepayplanCode).Name("REPAYPLAN_CODE")
                .Member(m => m.TrCurr).Name("TR_CURR")
                .Member(m => m.GlobalCode).Name("GLOBAL_CODE")
                ;
        }
    }
}
