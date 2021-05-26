﻿using ExtendedXmlSerializer;
using ExtendedXmlSerializer.Configuration;
using Ies.Logo.DataType.Xml;

namespace Ies.Logo.DataType.Orders
{
    public class DetailProfile : IConfigurationProfile
    {
        public static DetailProfile Default { get; } = new DetailProfile();

        private DetailProfile() { }

        public IConfigurationContainer Get(IConfigurationContainer parameter)
        {
            var configuration = parameter.Type<Detail>();

            Configure(configuration);

            return configuration;
        }

        public static void Configure<T>(ITypeConfiguration<T> typeConfigurations) where T : Detail
        {
            typeConfigurations.Configure();
            typeConfigurations.Name<T>("DETAIL");

            typeConfigurations
                .Member(m => m.Type).Name("TYPE")
                .Member(m => m.MasterCode).Name("MASTER_CODE")
                .Member(m => m.DetailLevel).Name("DETAIL_LEVEL")
                .Member(m => m.CalcType).Name("CALC_TYPE")
                .Member(m => m.OhpCode1).Name("OHP_CODE1")
                .Member(m => m.OhpCode2).Name("GL_CODE1")
                .Member(m => m.GlCode1).Name("GL_CODE2")
                .Member(m => m.GlCode2).Name("OHP_CODE2")
                .Member(m => m.DelvryCode).Name("DELVRY_CODE")
                .Member(m => m.Quantity).Name("QUANTITY")
                .Member(m => m.Price).Name("PRICE")
                .Member(m => m.Total).Name("TOTAL")
                .Member(m => m.QuantityShipped).Name("QUANTITY_SHIPPED")
                .Member(m => m.DiscountRate).Name("DISCOUNT_RATE")
                .Member(m => m.CostDistr).Name("COST_DISTR")
                .Member(m => m.DiscountDistr).Name("DISCOUNT_DISTR")
                .Member(m => m.ExpenseDistr).Name("EXPENSE_DISTR")
                .Member(m => m.PromotionDistr).Name("PROMOTION_DISTR")
                .Member(m => m.VatRate).Name("VAT_RATE")
                .Member(m => m.VatAmount).Name("VAT_AMOUNT")
                .Member(m => m.VatBase).Name("VAT_BASE")
                .Member(m => m.TransDescription).Name("TRANS_DESCRIPTION")
                .Member(m => m.UnitCode).Name("UNIT_CODE")
                .Member(m => m.UnitConv1).Name("UNIT_CONV1")
                .Member(m => m.UnitConv2).Name("UNIT_CONV2")
                .Member(m => m.UnitConv3).Name("UNIT_CONV3")
                .Member(m => m.UnitConv4).Name("UNIT_CONV4")
                .Member(m => m.UnitConv5).Name("UNIT_CONV5")
                .Member(m => m.UnitConv6).Name("UNIT_CONV6")
                .Member(m => m.UnitConv7).Name("UNIT_CONV7")
                .Member(m => m.UnitConv8).Name("UNIT_CONV8")
                .Member(m => m.VatIncluded).Name("VAT_INCLUDED")
                .Member(m => m.OrderClosed).Name("ORDER_CLOSED")
                .Member(m => m.OrderReserve).Name("ORDER_RESERVE")
                .Member(m => m.DueDate).Name("DUE_DATE")
                .Member(m => m.CurrPrice).Name("CURR_PRICE")
                .Member(m => m.PcPrice).Name("PC_PRICE")
                .Member(m => m.RcXrate).Name("RC_XRATE")
                .Member(m => m.Composite).Name("COMPOSITE")
                .Member(m => m.SourceWh).Name("SOURCE_WH")
                .Member(m => m.SourceCostGrp).Name("SOURCE_COST_GRP")
                .Member(m => m.TotalNet).Name("TOTAL_NET")
                .Member(m => m.Produced).Name("PRODUCED")
                .Member(m => m.ReasonForNotShp).Name("REASON_FOR_NOT_SHP")
                .Member(m => m.DemPeggedAmnt).Name("DEM_PEGGED_AMNT")
                .Member(m => m.Textinc).Name("TEXTINC")
                .Member(m => m.AffectCollatrl).Name("AFFECT_COLLATRL")
                .Member(m => m.VariantRef).Name("VARIANTREF")
                .Member(m => m.VariantCode).Name("VARIANTCODE")
                .Member(m => m.VariantName).Name("VARIANTNAME")
                .Member(m => m.Canconfig).Name("CANCONFIG")
                .Member(m => m.Priority).Name("PRIORITY")
                .Member(m => m.AddTaxRate).Name("ADD_TAX_RATE")
                .Member(m => m.AddTaxConvfact).Name("ADD_TAX_CONVFACT")
                .Member(m => m.AddTaxAmount).Name("ADD_TAX_AMOUNT")
                .Member(m => m.AddTaxAmtisupd).Name("ADD_TAX_AMNTISUPD")
                .Member(m => m.AddTaxDiscAmount).Name("ADD_TAX_DISC_AMOUNT")
                .Member(m => m.ExAddTaxRate).Name("EX_ADD_TAX_RATE")
                .Member(m => m.ExAddTaxConvf).Name("EX_ADD_TAX_CONVF")
                .Member(m => m.ExAddTaxAmount).Name("EX_ADD_TAX_AMOUNT")
                .Member(m => m.EuVatStatus).Name("EU_VAT_STATUS")
                .Member(m => m.AddTaxEffectKdv).Name("ADD_TAX_EFFECT_KDV")
                .Member(m => m.AffectRisk).Name("AFFECT_RISK")
                .Member(m => m.EdtPrice).Name("EDT_PRICE")
                .Member(m => m.EdtCurr).Name("EDT_CURR")
                .Member(m => m.OrgDueDate).Name("ORG_DUE_DATE")
                .Member(m => m.OrgQuantity).Name("ORG_QUANTITY")
                .Member(m => m.OrgPrice).Name("ORG_PRICE")
                .Member(m => m.AuxilCode2).Name("AUXIL_CODE2")
                .Member(m => m.ReserveDate).Name("RESERVE_DATE")
                .Member(m => m.Prclistcode).Name("PRCLISTCODE")
                .Member(m => m.Prclisttype).Name("PRCLISTTYPE")
                .Member(m => m.DeductionPart1).Name("DEDUCTION_PART1")
                .Member(m => m.DeductionPart2).Name("DEDUCTION_PART2")
                ;
        }
    }
}
