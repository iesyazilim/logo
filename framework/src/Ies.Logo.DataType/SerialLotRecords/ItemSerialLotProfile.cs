using ExtendedXmlSerializer;
using ExtendedXmlSerializer.Configuration;
using Ies.Logo.DataType.Xml;

namespace Ies.Logo.DataType.SerialLotRecords
{
    public class ItemSerialLotProfile : IConfigurationProfile
    {
        public static ItemSerialLotProfile Default { get; } = new ItemSerialLotProfile();

        private ItemSerialLotProfile() { }

        public IConfigurationContainer Get(IConfigurationContainer parameter)
        {
            var configuration = parameter.Type<ItemSerialLot>();

            Configure(configuration);

            return configuration;
        }

        public static void Configure<T>(ITypeConfiguration<T> typeConfigurations) where T : ItemSerialLot
        {
            typeConfigurations.Configure();
            typeConfigurations.Name<T>("ITEM_SERIAL_LOT");

            typeConfigurations
                .Member(m => m.ItemCode).Name("ITEM_CODE")
                .Member(m => m.Type).Name("TYPE")
                .Member(m => m.Code).Name("CODE")
                .Member(m => m.Description).Name("DESCRIPTION")
                .Member(m => m.WfStatus).Name("WF_STATUS")
                .Member(m => m.VariantCode).Name("VARIANT_CODE")
                ;
        }
    }
}
