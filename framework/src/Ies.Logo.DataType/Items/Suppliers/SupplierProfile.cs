using ExtendedXmlSerializer;
using ExtendedXmlSerializer.Configuration;
using Ies.Logo.DataType.Xml;

namespace Ies.Logo.DataType.Items.Suppliers
{
    public class SupplierProfile : IConfigurationProfile
    {
        public static SupplierProfile Default { get; } = new SupplierProfile();

        private SupplierProfile() { }

        public IConfigurationContainer Get(IConfigurationContainer parameter)
        {
            var configuration = parameter.Type<Supplier>();

            Configure(configuration);

            return configuration;
        }
        public static void Configure<T>(ITypeConfiguration<T> typeConfigurations) where T : Supplier
        {
            typeConfigurations.Configure();
            typeConfigurations.Name<T>("SUPPLIER");

            typeConfigurations
               .Member(m => m.SupplyType).Name("SUPPLY_TYPE")
               .Member(m => m.Priority).Name("PRIORITY")
               .Member(m => m.LineNo).Name("LINE_NO")
               .Member(m => m.ClCardType).Name("CL_CARD_TYPE")
               .Member(m => m.QccCheck).Name("QCC_CHECK")
               .Member(m => m.LeadTime).Name("LEAD_TIME")
               .Member(m => m.MinQuantity).Name("MIN_QUANTITY")
               .Member(m => m.MaxQuantity).Name("MAX_QUANTITY")
               .Member(m => m.BegDate).Name("BEG_DATE")
               .Member(m => m.Specialized).Name("SPECIALIZED")
               .Member(m => m.IcustSupCode).Name("ICUST_SUP_CODE")
               .Member(m => m.IcustSupName).Name("ICUST_SUP_NAME")
               .Member(m => m.QtyDepLeadTime).Name("QTY_DEP_LEAD_TIME")
               .Member(m => m.ArpCode).Name("ARP_CODE")
               .Member(m => m.PacketCode).Name("PACKET_CODE")
               .Member(m => m.PackagingAmnt).Name("PACKAGING_AMNT")
               .Member(m => m.UnitCode).Name("UNIT_CODE")
               .Member(m => m.UnitsetCode).Name("UNITSET_CODE")
               .Member(m => m.PacketUseType).Name("PACKET_USE_TYPE")
               .Member(m => m.OrdPerc).Name("ORD_PERC")
               .Member(m => m.OrdFrec).Name("ORD_FREC")
               ;
        }
    }
}
