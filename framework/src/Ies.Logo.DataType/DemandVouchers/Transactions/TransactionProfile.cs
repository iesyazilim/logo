using ExtendedXmlSerializer;
using ExtendedXmlSerializer.Configuration;
using Ies.Logo.DataType.Xml;

namespace Ies.Logo.DataType.DemandVouchers
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
                .Member(m => m.Amount).Name("AMOUNT")
                .Member(m => m.CancAmount).Name("CANC_AMOUNT")
                .Member(m => m.Price).Name("PRICE")
                .Member(m => m.MeetAmount).Name("MEET_AMOUNT")
                .Member(m => m.UnitConv1).Name("UNIT_CONV1")
                .Member(m => m.UnitConv2).Name("UNIT_CONV2")
                .Member(m => m.MeetType).Name("MEET_TYPE")
                .Member(m => m.ProcureDate).Name("PROCURE_DATE")
                .Member(m => m.RealSrcIndex).Name("REAL_SRC_INDEX")
                .Member(m => m.FactoryNr).Name("FACTORY_NR")
                .Member(m => m.Description).Name("DESCRIPTION")
                .Member(m => m.Status).Name("STATUS")
                .Member(m => m.LineType).Name("LINE_TYPE")
                .Member(m => m.LineNo).Name("LINE_NO")
                .Member(m => m.UserName).Name("USER_NAME")
                .Member(m => m.FicheDate).Name("FICHE_DATE")
                .Member(m => m.MrpHeadType).Name("MRP_HEAD_TYPE")
                .Member(m => m.ArpCode).Name("ARP_CODE")
                .Member(m => m.ArpName).Name("ARP_NAME")
                .Member(m => m.ItemCode).Name("ITEM_CODE")
                .Member(m => m.ItemName).Name("ITEM_NAME")
                .Member(m => m.PayCode).Name("PAY_CODE")
                .Member(m => m.CardType).Name("CARD_TYPE")
                .Member(m => m.UnitCode).Name("UNIT_CODE")
                .Member(m => m.OrdPegUse).Name("ORD_PEG_USE")
                .Member(m => m.CrossAccRef).Name("CROSS_ACC_REF")
                .Member(m => m.Guid).Name("GUID")
                .Member(m => m.PrCurr).Name("PR_CURR")
                .Member(m => m.PrPrice).Name("PR_PRICE")
                .Member(m => m.DefnFldsList).Name("DEFNFLDSLIST")
                ;
        }
    }
}
