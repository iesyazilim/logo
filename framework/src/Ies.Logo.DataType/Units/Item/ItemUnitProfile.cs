using ExtendedXmlSerializer;
using ExtendedXmlSerializer.Configuration;

namespace Ies.Logo.DataType.Units
{
    public class ItemUnitProfile : IConfigurationProfile
    {
        public static ItemUnitProfile Default { get; } = new ItemUnitProfile();

        private ItemUnitProfile() { }

        public IConfigurationContainer Get(IConfigurationContainer parameter)
        {
            var configuration = parameter.Type<ItemUnit>();

            Configure(configuration);

            return configuration;
        }
        public static void Configure<T>(ITypeConfiguration<T> typeConfigurations) where T : ItemUnit
        {
            UnitProfile.Configure(typeConfigurations);

            typeConfigurations
                .Member(m => m.Barcode).Name("BARCODE")
                .Member(m => m.Barcode2).Name("BARCODE2")
                .Member(m => m.Barcode3).Name("BARCODE3")
                .Member(m => m.UsefMtrlclass).Name("USEF_MTRLCLASS")
                .Member(m => m.UsefPurchclas).Name("USEF_PURCHCLAS")
                .Member(m => m.UsefSalesclas).Name("USEF_SALESCLAS")
                .Member(m => m.MtrlPriority).Name("MTRL_PRIORITY")
                .Member(m => m.PurchPriority).Name("PURCH_PRIORTY")
                .Member(m => m.Width).Name("WIDTH")
                .Member(m => m.Lenght).Name("LENGTH")
                .Member(m => m.Height).Name("HEIGHT")
                .Member(m => m.Area).Name("AREA")
                .Member(m => m.Volume).Name("VOLUME")
                .Member(m => m.Weight).Name("WEIGHT")
                .Member(m => m.GrossVolume).Name("GROSS_VOLUME")
                .Member(m => m.GrossWeight).Name("GROSS_WEIGHT")
                .Member(m => m.ConvFact1).Name("CONV_FACT1")
                .Member(m => m.ConvFact2).Name("CONV_FACT2")
                .Member(m => m.ExtAccFlags).Name("EXT_ACC_FLAGS")
                .Member(m => m.WidthCode).Name("WIDTH_CODE")
                .Member(m => m.LenghtCode).Name("LENGTH_CODE")
                .Member(m => m.HeightCode).Name("HEIGHT_CODE")
                .Member(m => m.AreaCode).Name("AREA_CODE")
                .Member(m => m.VolumeCode).Name("VOLUME_CODE")
                .Member(m => m.WeightCode).Name("WEIGHT_CODE")
                .Member(m => m.GrossVolCode).Name("GROSS_VOL_CODE")
                .Member(m => m.WithUnitBarcode).Name("WITHUNIT_BARCODE")
                .Member(m => m.WbarcodeShift).Name("WBARCODESHIFT")
                .Member(m => m.BarcodeList).Name("BARCODE_LIST")
                ;
        }
    }
}
