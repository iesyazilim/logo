using ExtendedXmlSerializer;
using ExtendedXmlSerializer.Configuration;
using Ies.Logo.DataType.Xml;

namespace Ies.Logo.DataType.BankVouchers
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
                .Member(m => m.DefnFldsList).Name("DEFNFLDSLIST")
                .Member(m => m.PaymentList).Name("PAYMENT_LIST")
                ;
        }
    }
}
