using ExtendedXmlSerializer;
using ExtendedXmlSerializer.Configuration;
using IesYazilim.Logo.DataType.Xml;

namespace IesYazilim.Logo.DataType.Payments
{
    public class PaymentProfile : IConfigurationProfile
    {
        public static PaymentProfile Default { get; } = new PaymentProfile();

        private PaymentProfile() { }

        public IConfigurationContainer Get(IConfigurationContainer parameter)
        {
            var configuration = parameter.Type<Payment>();

            Configure(configuration);

            return configuration;
        }

        public static void Configure<T>(ITypeConfiguration<T> typeConfigurations) where T : Payment
        {
            typeConfigurations.Configure();
            typeConfigurations.Name<T>("PAYMENT");

            typeConfigurations
                .Member(m => m.DisctrList).Name("DISCTRLIST")
                .Member(m => m.Date).Name("DATE")
                .Member(m => m.ModuleNr).Name("MODULENR")
                .Member(m => m.Sign).Name("SIGN")
                .Member(m => m.TrCode).Name("TRCODE")
                .Member(m => m.Total).Name("TOTAL")
                .Member(m => m.Days).Name("DAYS")
                .Member(m => m.LatelyIntRate).Name("LATELYINTRATE")
                .Member(m => m.ProcDate).Name("PROCDATE")
                .Member(m => m.TrRate).Name("TRRATE")
                .Member(m => m.Modified).Name("MODIFIED")
                .Member(m => m.DiscountDueDate).Name("DISCOUNT_DUEDATE")
                .Member(m => m.DisctrdelList).Name("DISCTRDELLIST")
                .Member(m => m.PayNo).Name("PAY_NO")
                .Member(m => m.PosComsn).Name("POS_COMSN")
                .Member(m => m.BankAccCode).Name("BANKACC_CODE")
                .Member(m => m.PaymentType).Name("PAYMENT_TYPE")
                .Member(m => m.NetTotal).Name("NET_TOTAL")
                .Member(m => m.RepayplnApplied).Name("REPAYPLN_APPLIED")
                .Member(m => m.RepayplanCode).Name("REPAYPLAN_CODE")
                .Member(m => m.LineExp).Name("LINE_EXP")
                ;
        }
    }
}
