﻿using ExtendedXmlSerializer;
using ExtendedXmlSerializer.Configuration;
using Ies.Logo.DataType.Xml;

namespace Ies.Logo.DataType.Items
{
    public class ItemProfile : IConfigurationProfile
    {
        public static ItemProfile Default { get; } = new ItemProfile();

        private ItemProfile() { }

        public IConfigurationContainer Get(IConfigurationContainer parameter)
        {
            var configuration = parameter.Type<Item>();

            Configure(configuration);

            return configuration;
        }

        public static void Configure<T>(ITypeConfiguration<T> typeConfigurations) where T : Item
        {
            typeConfigurations.Configure();
            typeConfigurations.Name<T>("ITEM");

            typeConfigurations
                .Member(m => m.Code).Name("CODE")
                .Member(m => m.Name).Name("NAME")
                .Member(m => m.Name2).Name("NAME2")
                .Member(m => m.Name3).Name("NAME3")
                .Member(m => m.Name4).Name("NAME4")
                .Member(m => m.CardType).Name("CARD_TYPE")
                .Member(m => m.ProducerCode).Name("PRODUCER_CODE")
                .Member(m => m.ClassType).Name("CLASS_TYPE")
                .Member(m => m.UsefPurchasing).Name("USEF_PURCHASING")
                .Member(m => m.UsefSales).Name("USEF_SALES")
                .Member(m => m.UsefMm).Name("USEF_MM")
                .Member(m => m.Vat).Name("VAT")
                .Member(m => m.SelVat).Name("SELVAT")
                .Member(m => m.ReturnVat).Name("RETURNVAT")
                .Member(m => m.SelprVat).Name("SELPRVAT")
                .Member(m => m.ReturnprVat).Name("RETURNPRVAT")
                .Member(m => m.TrackType).Name("TRACK_TYPE")
                .Member(m => m.LocationTracking).Name("LOCATION_TRACKING")
                .Member(m => m.Tool).Name("TOOL")
                .Member(m => m.AutoIncsl).Name("AUTOINCSL")
                .Member(m => m.LotsDivisible).Name("LOTS_DIVISIBLE")
                .Member(m => m.ShelfLife).Name("SHELF_LIFE")
                .Member(m => m.ShelfDate).Name("SHELF_DATE")
                .Member(m => m.DeprecType).Name("DEPREC_TYPE")
                .Member(m => m.DeprecType2).Name("DEPREC_TYPE2")
                .Member(m => m.DeprecRate).Name("DEPREC_RATE")
                .Member(m => m.DeprecRate2).Name("DEPREC_RATE2")
                .Member(m => m.DeprecDuration).Name("DEPREC_DURATION")
                .Member(m => m.DeprecDuration2).Name("DEPREC_DURATION2")
                .Member(m => m.SalvageVal).Name("SALVAGE_VAL")
                .Member(m => m.SalvageValue).Name("SALVAGE_VALUE")
                .Member(m => m.RevalFlag).Name("REVAL_FLAG")
                .Member(m => m.RevalFlag2).Name("REVAL_FLAG2")
                .Member(m => m.RevdeprecFlag).Name("REVDEPREC_FLAG")
                .Member(m => m.RevdeprecFlag2).Name("REVDEPREC_FLAG2")
                .Member(m => m.PartialDeprec).Name("PARTIAL_DEPREC")
                .Member(m => m.PartialDeprec2).Name("PARTIAL_DEPREC2")
                .Member(m => m.Approved).Name("APPROVED")
                .Member(m => m.UnitsetCode).Name("UNITSET_CODE")
                .Member(m => m.QccsetCode).Name("QCCSET_CODE")
                .Member(m => m.DistributedAmount).Name("DISTRIBUTED_AMOUNT")
                .Member(m => m.UniversalId).Name("UNIVERSAL_ID")
                .Member(m => m.DistLotUnits).Name("DIST_LOT_UNITS")
                .Member(m => m.CombLotUnits).Name("COMB_LOT_UNITS")
                .Member(m => m.DistPoint).Name("DIST_POINT")
                .Member(m => m.CanUseInTrans).Name("CAN_USE_IN_TRANS")
                .Member(m => m.IsoNr).Name("ISO_NR")
                .Member(m => m.GroupNr).Name("GROUP_NR")
                .Member(m => m.ProdCountry).Name("PROD_COUNTRY")
                .Member(m => m.ExtAccFlags).Name("EXT_ACC_FLAGS")
                .Member(m => m.AddTaxCode).Name("ADD_TAX_CODE")
                .Member(m => m.MultiAddTax).Name("MULTI_ADD_TAX")
                .Member(m => m.Packet).Name("PACKET")
                .Member(m => m.LidConfirmed).Name("LID_CONFIRMED")
                .Member(m => m.GtipCode).Name("GTIPCODE")
                .Member(m => m.B2CCode).Name("B2CCODE")
                .Member(m => m.MarkCode).Name("MARKCODE")
                .Member(m => m.Img2Inc).Name("IMG2INC")
                .Member(m => m.ExpctGnr).Name("ExpctGnr")
                .Member(m => m.ExtcrdFlags).Name("EXTCRD_FLAGS")
                .Member(m => m.MinOrdAmnt).Name("MIN_ORD_AMNT")
                 #region Freight
                .Member(m => m.FreightPlace).Name("FREIGHT_PLACE")
                .Member(m => m.FreightTypeCode1).Name("FREIGHT_TYPE_CODE1")
                .Member(m => m.FreightTypeCode2).Name("FREIGHT_TYPE_CODE2")
                .Member(m => m.FreightTypeCode3).Name("FREIGHT_TYPE_CODE3")
                .Member(m => m.FreightTypeCode4).Name("FREIGHT_TYPE_CODE4")
                .Member(m => m.FreightTypeCode5).Name("FREIGHT_TYPE_CODE5")
                .Member(m => m.FreightTypeCode6).Name("FREIGHT_TYPE_CODE6")
                .Member(m => m.FreightTypeCode7).Name("FREIGHT_TYPE_CODE7")
                .Member(m => m.FreightTypeCode8).Name("FREIGHT_TYPE_CODE8")
                .Member(m => m.FreightTypeCode9).Name("FREIGHT_TYPE_CODE9")
                .Member(m => m.FreightTypeCode10).Name("FREIGHT_TYPE_CODE10")
                .Member(m => m.FreightTypeDef1).Name("FREIGHT_TYPE_DEF1")
                .Member(m => m.FreightTypeDef2).Name("FREIGHT_TYPE_DEF2")
                .Member(m => m.FreightTypeDef3).Name("FREIGHT_TYPE_DEF3")
                .Member(m => m.FreightTypeDef4).Name("FREIGHT_TYPE_DEF4")
                .Member(m => m.FreightTypeDef5).Name("FREIGHT_TYPE_DEF5")
                .Member(m => m.FreightTypeDef6).Name("FREIGHT_TYPE_DEF6")
                .Member(m => m.FreightTypeDef7).Name("FREIGHT_TYPE_DEF7")
                .Member(m => m.FreightTypeDef8).Name("FREIGHT_TYPE_DEF8")
                .Member(m => m.FreightTypeDef9).Name("FREIGHT_TYPE_DEF9")
                .Member(m => m.FreightTypeDef10).Name("FREIGHT_TYPE_DEF10")
                #endregion
                .Member(m => m.QprodAmnt).Name("QPRODAMNT")
                .Member(m => m.QprodSourceIndex).Name("QPRODSOURCEINDEX")
                .Member(m => m.LostFactor).Name("LOSTFACTOR")
                .Member(m => m.ExpCategory).Name("EXPCATEGORY")
                .Member(m => m.EanBarcode).Name("EAN_BARCODE")
                .Member(m => m.DeprClassType).Name("DEPRCLASSTYPE")
                .Member(m => m.WflowCardRef).Name("WflowCardRef")
                .Member(m => m.CodeChanged).Name("CODE_CHANGED")
                .Member(m => m.AvrWhDuration).Name("AVR_WH_DURATION")
                .Member(m => m.ImageInc).Name("IMAGEINC")
                .Member(m => m.Image1Size).Name("IMAGE1_SIZE")
                .Member(m => m.Image2Size).Name("IMAGE2_SIZE")
                .Member(m => m.CanConfigure).Name("CANCONFIGURE")
                .Member(m => m.Charset).Name("CHARSET")
                .Member(m => m.CharsetName).Name("CHARSETNAME")
                .Member(m => m.VgenDataReference).Name("VGEN_DATA_REFERENCE")
                .Member(m => m.ConsCode).Name("CONSCODE")
                .Member(m => m.UpdateChilds).Name("UPDATECHILDS")
                .Member(m => m.CanDeduct).Name("CAN_DEDUCT")
                .Member(m => m.SaleDeductionPart1).Name("SALE_DEDUCTION_PART1")
                .Member(m => m.SaleDeductionPart2).Name("SALE_DEDUCTION_PART2")
                .Member(m => m.PurchDeductionPart1).Name("PURCH_DEDUCTION_PART1")
                .Member(m => m.PurchDeductionPart2).Name("PURCH_DEDUCTION_PART2")
                .Member(m => m.Expense).Name("EXPENSE")
                 #region EximTax
                .Member(m => m.EximTax1).Name("EXIM_TAX1")
                .Member(m => m.EximTax2).Name("EXIM_TAX2")
                .Member(m => m.EximTax3).Name("EXIM_TAX3")
                .Member(m => m.EximTax4).Name("EXIM_TAX4")
                .Member(m => m.EximTax5).Name("EXIM_TAX5")
                #endregion
                .Member(m => m.ReyonCode).Name("REYON_CODE")
                .Member(m => m.KdvDeptNr).Name("KDV_DEPT_NR")
                .Member(m => m.Scales).Name("SCALES")
                .Member(m => m.ScaleNr).Name("SCALE_NR")
                .Member(m => m.Origin).Name("ORIGIN")
                .Member(m => m.AppSpeVatMatrah).Name("APP_SPE_VAT_MATRAH")
                .Member(m => m.FltImage1).Name("FLTIMAGE1")
                .Member(m => m.FltImage2).Name("FLTIMAGE2")
                .Member(m => m.CategoryId).Name("CATEGORY_ID")
                .Member(m => m.CategoryName).Name("CATEGORY_NAME")
                .Member(m => m.Keyword1).Name("KEYWORD1")
                .Member(m => m.Keyword2).Name("KEYWORD2")
                .Member(m => m.Keyword3).Name("KEYWORD3")
                .Member(m => m.Keyword4).Name("KEYWORD4")
                .Member(m => m.Keyword5).Name("KEYWORD5")
                .Member(m => m.SubsGoodCode).Name("SUBSGOOD_CODE")
                .Member(m => m.FactoryParams).Name("FACTORY_PARAMS")
                .Member(m => m.WhParams).Name("WH_PARAMS")
                .Member(m => m.Characteristics).Name("CHARACTERISTICS")
                .Member(m => m.DominantClasses).Name("DOMINANT_CLASSES")
                .Member(m => m.Units).Name("UNITS")
                .Member(m => m.Composites).Name("COMPOSITES")
                .Member(m => m.GlLinks).Name("GL_LINKS")
                .Member(m => m.Suppliers).Name("SUPPLIERS")
                .Member(m => m.QProds).Name("QPRODS")
                .Member(m => m.GeniusFldsList).Name("GENIUSFLDSLIST")
                .Member(m => m.DefnFldsList).Name("DEFNFLDSLIST")
                .Member(m => m.VrntExceptions).Name("VRNTEXCEPTIONS")
                .Member(m => m.VrntCodeTemps).Name("VRNTCODETEMPS")
                .Member(m => m.VrntExcpTemps).Name("VRNTEXCPTEMPS")
                .Member(m => m.Alternatives).Name("ALTERNATIVES")
                ;
        }
    }
}
