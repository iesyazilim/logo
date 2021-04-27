using ExtendedXmlSerializer;
using ExtendedXmlSerializer.Configuration;
using Logo.DataType.Xml;

namespace Logo.DataType.Items
{
    public class FactoryParamProfile : IConfigurationProfile
    {
        public static FactoryParamProfile Default { get; } = new FactoryParamProfile();
        private FactoryParamProfile() { }
        public IConfigurationContainer Get(IConfigurationContainer parameter)
        {
            var configuration = parameter.Type<FactoryParam>();

            Configure(configuration);

            return configuration;
        }
        public static void Configure<T>(ITypeConfiguration<T> typeConfigurations) where T : FactoryParam
        {
            typeConfigurations.Configure();
            typeConfigurations.Name<T>("FACTORY_PARAM");

            typeConfigurations
               .Member(m => m.FactoryNr).Name("FACTORYNR")
               .Member(m => m.Specialized).Name("SPECIALIZED")
               .Member(m => m.ProcureClass).Name("PROCURECLASS")
               .Member(m => m.LowLevelCode).Name("LOWLEVELCODE")
               .Member(m => m.DivLotSize).Name("DIVLOTSIZE")
               .Member(m => m.MrpCntrl).Name("MRPCNTRL")
               .Member(m => m.PlanPolicy).Name("PLANPOLICY")
               .Member(m => m.LotSizingMtd).Name("LOTSIZINGMTD")
               .Member(m => m.LotSizingMtd2).Name("LOT_SIZING_MTD2")
               .Member(m => m.FixedLotSize).Name("FIXEDLOTSIZE")
               .Member(m => m.FixedLotSize2).Name("FIXED_LOT_SIZE2")
               .Member(m => m.Yield).Name("YIELD")
               .Member(m => m.Yield2).Name("YIELD2")
               .Member(m => m.MinOrderQty).Name("MINORDERQTY")
               .Member(m => m.MinOrderQty2).Name("MIN_ORDER_QTY2")
               .Member(m => m.MaxOrderQty).Name("MAXORDERQTY")
               .Member(m => m.MaxOrderQty2).Name("MAX_ORDER_QTY2")
               .Member(m => m.MultOrderQty).Name("MULTORDERQTY")
               .Member(m => m.MultOrderQty2).Name("MULT_ORDER_QTY2")
               .Member(m => m.MinOrderDay).Name("MINORDERDAY")
               .Member(m => m.MaxOrderDay).Name("MAXORDERDAY")
               .Member(m => m.ReOrderPoint).Name("REORDERPOINT")
               .Member(m => m.AutoMtrIssue).Name("AUTOMTRISSUE")
               .Member(m => m.DefSeriLotNo).Name("DEFSERILOTNO")
               .Member(m => m.AutoLotMtd).Name("AUTOLOTOUTMTD")
               .Member(m => m.LotParty).Name("LOTPARTY")
               .Member(m => m.OutLotSize).Name("OUTLOTSIZE")
               .Member(m => m.CountFormPs).Name("COUNTFORMPS")
               ;
        }
    }
}
