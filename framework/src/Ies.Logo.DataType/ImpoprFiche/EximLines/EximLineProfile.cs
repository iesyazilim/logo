using ExtendedXmlSerializer;
using ExtendedXmlSerializer.Configuration;
using Ies.Logo.DataType.Xml;
using System;

namespace Ies.Logo.DataType.ImpoprFiche.EximLines
{
    public class EximLineProfile : IConfigurationProfile
    {
        public static EximLineProfile Default { get; } = new EximLineProfile();

        private EximLineProfile() { }

        public IConfigurationContainer Get(IConfigurationContainer parameter)
        {
            var configuration = parameter.Type<EximLine>();

            Configure(configuration);

            return configuration;
        }

        private void Configure<T>(ITypeConfiguration<T> typeConfigurations) where T : EximLine
        {
            typeConfigurations.Configure();
            typeConfigurations.Name<T>("EXIMLINE");

            typeConfigurations
                .Member(m => m.Details).Name("DETAILS")
                .Member(m => m.CampaingInfos).Name("CAMPAIGN_INFOS")
                .Member(m => m.DefnFldsList).Name("DEFNFLDSLIST")
                .Member(m => m.Type).Name("TYPE")
                .Member(m => m.MasterCode).Name("MASTER_CODE")
                .Member(m => m.MasterDef).Name("MASTER_DEF")
                .Member(m => m.DiscExpCalc).Name("DISCEXP_CALC")
                .Member(m => m.SourceCostGrp).Name("SOURCECOSTGRP")
                .Member(m => m.OrderReference).Name("ORDER_REFERENCE")
                .Member(m => m.OrderSite).Name("ORDER_SITE")
                .Member(m => m.DelvryCode).Name("DELVRY_CODE")
                .Member(m => m.Quantity).Name("QUANTITY")
                .Member(m => m.Price).Name("PRICE")
                .Member(m => m.Total).Name("TOTAL")
                .Member(m => m.CurrPrice).Name("CURR_PRICE")
                .Member(m => m.PcPrice).Name("PC_PRICE")
                .Member(m => m.CurrTransaction).Name("CURR_TRANSACTION")
                .Member(m => m.TcXrate).Name("TC_XRATE")
                .Member(m => m.RcXrate).Name("RC_XRATE")
                .Member(m => m.CostDistr).Name("COST_DISTR")
                .Member(m => m.DiscountDistr).Name("DISCOUNT_DISTR")
                .Member(m => m.ExpenseDistr).Name("EXPENSE_DISTR")
                .Member(m => m.PromotionDistr).Name("PROMOTION_DISTR")
                .Member(m => m.DiscountRate).Name("DISCOUNT_RATE")
                .Member(m => m.BaseAmount).Name("BASE_AMOUNT")
                .Member(m => m.Description).Name("DESCRIPTION")
                .Member(m => m.VatIncluded).Name("VAT_INCLUDED")
                .Member(m => m.VatRate).Name("VAT_RATE")
                .Member(m => m.VatAmount).Name("VAT_AMOUNT")
                .Member(m => m.VatBase).Name("VAT_BASE")
                .Member(m => m.VatAdjustment).Name("VAT_ADJUSTMENT")
                .Member(m => m.Billed).Name("BILLED")
                .Member(m => m.TotalNet).Name("TOTAL_NET")
                .Member(m => m.DispatchNumber).Name("DISPATCH_NUMBER")
                .Member(m => m.DistOrdSiteId).Name("DIST_ORD_SITEIID")
                .Member(m => m.DistOrdReference).Name("DIST_ORD_REFERENCE")
                .Member(m => m.CostOfSaleGlCode).Name("COST_OF_SALE_GL_CODE")
                .Member(m => m.PurchGlCode).Name("PURCH_GL_CODE")
                .Member(m => m.CostOfSaleOhpCode).Name("COST_OF_SALE_OHP_CODE")
                .Member(m => m.PurchOhpCode).Name("PURCH_OHP_CODE")
                .Member(m => m.PrRate).Name("PR_RATE")
                .Member(m => m.EdtCurr).Name("EDT_CURR")
                .Member(m => m.EdtPrice).Name("EDT_PRICE")
                .Member(m => m.AddTaxDiscAmnt).Name("ADDTAXDISC_AMNT")
                .Member(m => m.OrgLogoId).Name("ORGLOGOID")
                .Member(m => m.SalesmanCode).Name("SALEMANCODE")
                .Member(m => m.TransExpLine).Name("TRANS_EXP_LINE")
                .Member(m => m.InsExpLine).Name("INS_EXP_LINE")
                .Member(m => m.EximFicheType).Name("EXIM_FICHE_TYPE")
                .Member(m => m.EximProcNo).Name("INFO_EXIMPROCNR")
                .Member(m => m.EximCustomDocNo).Name("EXIM_CUSTOMDOCNO")
                .Member(m => m.EximCustomDocDate).Name("EXIM_CUSTOMDOCDATE")
                .Member(m => m.EximCountryType).Name("EXIM_COUNTRYTYPE")
                .Member(m => m.EximCountryCode).Name("EXIM_COUNTRYCODE")
                .Member(m => m.MultAddTax).Name("MULTI_ADD_TAX")
                .Member(m => m.DiibCode).Name("DIIB_CODE")
                .Member(m => m.Month).Name("MONTH")
                .Member(m => m.Year).Name("YEAR")
                .Member(m => m.VariantCode).Name("VARIANTCODE")
                .Member(m => m.VariantName).Name("VARIANTNAME")
                .Member(m => m.AffectRisk).Name("AFFECT_RISK")
                .Member(m => m.AddTaxGlobalCode).Name("ADDTAX_GLOBAL_CODE")
                .Member(m => m.UnitGlobalCode).Name("UNIT_GLOBAL_CODE")
                .Member(m => m.PayplGlobalCode).Name("PAYPL_GLOBAL_CODE")
                .Member(m => m.PrcurrGlobalCode).Name("PRCURR_GLOBAL_CODE")
                .Member(m => m.TrcurrGlobalCode).Name("TRCURR_GLOBAL_CODE")
                .Member(m => m.EdtcurrGlobalCode).Name("EDTCURR_GLOBAL_CODE")
                .Member(m => m.CanDeduct).Name("CANDEDUCT")
                .Member(m => m.DeductCode).Name("DEDUCT_CODE")
                .Member(m => m.DeductDef).Name("DEDUCT_DEF")
                .Member(m => m.DeductionPart1).Name("DEDUCTION_PART1")
                .Member(m => m.DeductionPart2).Name("DEDUCTION_PART2")
                .Member(m => m.DeductionTot).Name("DEDUCTION_TOT")
                .Member(m => m.DeductionTotTc).Name("DEDUCTION_TOT_TC")
                .Member(m => m.Guid).Name("GUID")
                .Member(m => m.AuxilCode2).Name("AUXIL_CODE2")
                .Member(m => m.VatExceptReason).Name("VATEXCEPT_REASON")
                .Member(m => m.VatExceptCode).Name("VATEXCEPT_CODE")
                .Member(m => m.Barcode).Name("BARCODE")
                ;
        }
    }
}
