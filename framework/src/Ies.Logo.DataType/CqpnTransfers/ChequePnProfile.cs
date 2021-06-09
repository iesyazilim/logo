using ExtendedXmlSerializer;
using ExtendedXmlSerializer.Configuration;
using Ies.Logo.DataType.Xml;

namespace Ies.Logo.DataType.CqpnTransfers
{
    public class ChequePnProfile : IConfigurationProfile
    {
        public static ChequePnProfile Default { get; } = new ChequePnProfile();

        private ChequePnProfile() { }

        public IConfigurationContainer Get(IConfigurationContainer parameter)
        {
            var configuration = parameter.Type<ChequePn>();

            Configure(configuration);

            return configuration;
        }
        public static void Configure<T>(ITypeConfiguration<T> typeConfigurations) where T : ChequePn
        {
            typeConfigurations.Configure();
            typeConfigurations.Name<T>("CHEQUE_PN");

            typeConfigurations
              .Member(m => m.Type).Name("TYPE")
              .Member(m => m.CurrentStatus).Name("CURRENT_STATUS")
              .Member(m => m.Number).Name("NUMBER")
              .Member(m => m.Owing).Name("OWING")
              .Member(m => m.DueDate).Name("DUE_DATE")
              .Member(m => m.Amount).Name("AMOUNT")
              .Member(m => m.TcXrate).Name("TC_XRATE")
              .Member(m => m.TcAmount).Name("TC_AMOUNT")
              .Member(m => m.Transferred).Name("TRANSFERRED")
              .Member(m => m.OwnaccCode).Name("OWNACC_CODE")
              .Member(m => m.ArpCode).Name("ARP_CODE")
              .Member(m => m.NewSerialNo).Name("NEW_SERIAL_NO")
              .Member(m => m.AffectRisk).Name("AFFECT_RISK")
              .Member(m => m.BankTitle).Name("BANK_TITLE")
              .Member(m => m.City).Name("CITY")
              .Member(m => m.Currency).Name("CURRENCY")
              .Member(m => m.CurrTrans).Name("CURR_TRANS")
              .Member(m => m.BankCode).Name("BANK_CODE")
              ;
        }
    }
}
