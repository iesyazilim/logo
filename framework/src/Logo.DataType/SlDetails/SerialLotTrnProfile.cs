using ExtendedXmlSerializer;
using ExtendedXmlSerializer.Configuration;
using Logo.DataType.Xml;

namespace Logo.DataType.SlDetails
{
    public class SerialLotTrnProfile : IConfigurationProfile
    {
        public static SerialLotTrnProfile Default { get; } = new SerialLotTrnProfile();

        private SerialLotTrnProfile() { }

        public IConfigurationContainer Get(IConfigurationContainer parameter)
        {
            var configuration = parameter.Type<SerialLotTrn>();

            Configure(configuration);

            return configuration;
        }

        public static void Configure<T>(ITypeConfiguration<T> typeConfigurations) where T : SerialLotTrn
        {
            typeConfigurations.Configure();
            typeConfigurations.Name<T>("SERIAL_LOT_TRN");

            typeConfigurations
                .Member(m => m.QcList).Name("QCLIST")
                .Member(m => m.SourceMtSiteid).Name("SOURCE_MT_SITEID")
                .Member(m => m.SourceMtReference).Name("SOURCE_MT_REFERENCE")
                .Member(m => m.SourceSltSiteid).Name("SOURCE_SLT_SITEID")
                .Member(m => m.SourceSltReference).Name("SOURCE_SLT_REFERENCE")
                .Member(m => m.SourceQuantity).Name("SOURCE_QUANTITY")
                .Member(m => m.IoCode).Name("IOCODE")
                .Member(m => m.SourceWh).Name("SOURCE_WH")
                .Member(m => m.SlType).Name("SL_TYPE")
                .Member(m => m.SlCode).Name("SL_CODE")
                .Member(m => m.LocationCode).Name("LOCATION_CODE")
                .Member(m => m.DestLocationCode).Name("DEST_LOCATION_CODE")
                .Member(m => m.MuQuantity).Name("MU_QUANTITY")
                .Member(m => m.Quantity).Name("QUANTITY")
                .Member(m => m.RemQuantity).Name("REM_QUANTITY")
                .Member(m => m.LuRemQuantity).Name("LU_REM_QUANTITY")
                .Member(m => m.DateExpired).Name("DATE_EXPIRED")
                .Member(m => m.RateScore).Name("RATE_SCORE")
                .Member(m => m.OutCost).Name("OUT_COST")
                .Member(m => m.TcOutCost).Name("TC_OUT_COST")
                .Member(m => m.PrcdifCost).Name("PRCDIF_COST")
                .Member(m => m.TcPrcdifCost).Name("TC_PRCDIF_COST")
                .Member(m => m.SlQcOk).Name("SL_QC_OK")
                .Member(m => m.SourceType).Name("SOURCE_TYPE")
                .Member(m => m.WfStatus).Name("WF_STATUS")
                .Member(m => m.SourceDistSlSiteid).Name("SOURCE_DIST_SL_SITEID")
                .Member(m => m.SourceDistSlReference).Name("SOURCE_DIST_SL_REFERENCE")
                .Member(m => m.GrossuInfo1).Name("GROSS_U_INFO1")
                .Member(m => m.GrossuInfo2).Name("GROSS_U_INFO2")
                .Member(m => m.AddTaxPrcost).Name("ADD_TAX_PRCOST")
                .Member(m => m.AddTaxPrcostCurr).Name("ADD_TAX_PRCOSTCURR")
                .Member(m => m.InflationIdx).Name("INFLATION_IDX")
                .Member(m => m.OrgLogoId).Name("ORGLOGOID")
                .Member(m => m.OrgLinkRef).Name("ORGLINKREF")
                .Member(m => m.LineExp).Name("LINEEXP")
                .Member(m => m.GrpBegCode).Name("GRP_BEG_CODE")
                .Member(m => m.GrpEndCode).Name("GRP_END_CODE")
                .Member(m => m.Guid).Name("GUID")
                ;
        }
    }
}
