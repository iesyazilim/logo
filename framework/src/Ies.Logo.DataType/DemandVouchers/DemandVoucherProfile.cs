using ExtendedXmlSerializer;
using ExtendedXmlSerializer.Configuration;
using Ies.Logo.DataType.Xml;

namespace Ies.Logo.DataType.DemandVouchers
{
    public class DemandVoucherProfile : IConfigurationProfile
    {
        public static DemandVoucherProfile Default { get; } = new DemandVoucherProfile();

        private DemandVoucherProfile() { }

        public IConfigurationContainer Get(IConfigurationContainer parameter)
        {
            var configuration = parameter.Type<DemandVoucher>();

            Configure(configuration);

            return configuration;
        }
        public static void Configure<T>(ITypeConfiguration<T> typeConfigurations) where T : DemandVoucher
        {
            typeConfigurations.Configure();
            typeConfigurations.Name<T>("DEMAND_VOUCHER");

            typeConfigurations
              .Member(m => m.Number).Name("NUMBER")
              .Member(m => m.Date).Name("DATE")
              .Member(m => m.Time).Name("TIME")
              .Member(m => m.DoCode).Name("DO_CODE")
              .Member(m => m.FactoryNr).Name("FACTORY_NR")
              .Member(m => m.Branch).Name("BRANCH")
              .Member(m => m.Status).Name("STATUS")
              .Member(m => m.UserNo).Name("USER_NO")
              .Member(m => m.MpsCode).Name("MPS_CODE")
              .Member(m => m.LineCnt).Name("LINE_CNT")
              .Member(m => m.Itext).Name("ITEXT")
              .Member(m => m.Transactions).Name("TRANSACTIONS")
              ;
        }
    }
}
