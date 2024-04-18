using ExtendedXmlSerializer;
using ExtendedXmlSerializer.Configuration;
using Ies.Logo.DataType.Xml;

namespace Ies.Logo.DataType.MaterialSlips
{
    public class SlipProfile : IConfigurationProfile
    {
        public static SlipProfile Default { get; } = new SlipProfile();

        private SlipProfile() { }

        public IConfigurationContainer Get(IConfigurationContainer parameter)
        {
            var configuration = parameter.Type<Slip>();

            Configure(configuration);

            return configuration;
        }

        public static void Configure<T>(ITypeConfiguration<T> typeConfigurations) where T : Slip
        {
            typeConfigurations.Configure();
            typeConfigurations.Name<T>("SLIP");

            typeConfigurations
                .Member(m => m.Group).Name("GROUP")
                .Member(m => m.Type).Name("TYPE")
                .Member(m => m.Number).Name("NUMBER")
                .Member(m => m.DocTrackNr).Name("DOC_TRACK_NR")
                .Member(m => m.Date).Name("DATE")
                .Member(m => m.DocDate).Name("DOC_DATE")
                .Member(m => m.Time).Name("TIME")
                .Member(m => m.DocTime).Name("DOC_TIME")
                .Member(m => m.DocNumber).Name("DOC_NUMBER")
                .Member(m => m.SourceType).Name("SOURCE_TYPE")
                .Member(m => m.SourceWh).Name("SOURCE_WH")
                .Member(m => m.SourceWscode).Name("SOURCE_WSCODE")
                .Member(m => m.SpoDetailCode).Name("SPO_DETAIL_CODE")
                .Member(m => m.SrcpolnReference).Name("SRCPOLN_REFERENCE")
                .Member(m => m.SourceCostGrp).Name("SOURCE_COST_GRP")
                .Member(m => m.DestType).Name("DEST_TYPE")
                .Member(m => m.DestWh).Name("DEST_WH")
                .Member(m => m.DestWscode).Name("DEST_WSCODE")
                .Member(m => m.DpoDetailCode).Name("DPO_DETAIL_CODE")
                .Member(m => m.DestpolnReference).Name("DESTPOLN_REFERENCE")
                .Member(m => m.DestCostGrp).Name("DEST_COST_GRP")
                .Member(m => m.SourceFactoryNr).Name("SOURCE_FACTORY_NR")
                .Member(m => m.SourceDivisionNr).Name("SOURCE_DIVISION_NR")
                .Member(m => m.SourceDepartmentNr).Name("SOURCE_DEPARTMENT_NR")
                .Member(m => m.DestDivisionNr).Name("DEST_DIVISION_NR")
                .Member(m => m.DestDepartmentNr).Name("DEST_DEPARTMENT_NR")
                .Member(m => m.DestFactory).Name("DEST_FACTORY")
                .Member(m => m.PorderStatus).Name("PORDER_STATUS")
                .Member(m => m.FyTransfer).Name("FY_TRANSFER")
                .Member(m => m.GlStatus).Name("GL_STATUS")
                .Member(m => m.XrateStatus).Name("XRATE_STATUS")
                .Member(m => m.AddDiscounts).Name("ADD_DISCOUNTS")
                .Member(m => m.TotalDiscounts).Name("TOTAL_DISCOUNTS")
                .Member(m => m.TotalDiscounted).Name("TOTAL_DISCOUNTED")
                .Member(m => m.AddExpenses).Name("ADD_EXPENSES")
                .Member(m => m.TotalExpenses).Name("TOTAL_EXPENSES")
                .Member(m => m.TotalDeposited).Name("TOTAL_DEPOSITED")
                .Member(m => m.TotalPromotions).Name("TOTAL_PROMOTIONS")
                .Member(m => m.TotalVat).Name("TOTAL_VAT")
                .Member(m => m.TotalGross).Name("TOTAL_GROSS")
                .Member(m => m.TotalNet).Name("TOTAL_NET")
                .Member(m => m.Footnote1).Name("FOOTNOTE1")
                .Member(m => m.Footnote2).Name("FOOTNOTE2")
                .Member(m => m.Footnote3).Name("FOOTNOTE3")
                .Member(m => m.Footnote4).Name("FOOTNOTE4")
                .Member(m => m.RcRate).Name("RC_RATE")
                .Member(m => m.RcNet).Name("RC_NET")
                .Member(m => m.PrintCounter).Name("PRINT_COUNTER")
                .Member(m => m.Accficheref).Name("ACCFICHEREF")
                .Member(m => m.GlCancelled).Name("GL_CANCELLED")
                .Member(m => m.ShipmentType).Name("SHIPMENT_TYPE")
                .Member(m => m.ShippingAgent).Name("SHIPPING_AGENT")
                .Member(m => m.TrackNr).Name("TRACK_NR")
                .Member(m => m.CurrselTotals).Name("CURRSEL_TOTALS")
                .Member(m => m.CurrselDetails).Name("CURRSEL_DETAILS")
                .Member(m => m.Textinc).Name("TEXTINC")
                .Member(m => m.AddTaxCalc).Name("ADD_TAX_CALC")
                .Member(m => m.TotalAddTax).Name("TOTAL_ADD_TAX")
                .Member(m => m.UDocTrackingNr).Name("U_DOC_TRACKING_NR")
                .Member(m => m.VaAcccode).Name("VA_ACCCODE")
                .Member(m => m.VaCentercode).Name("VA_CENTERCODE")
                .Member(m => m.FromExim).Name("FROM_EXIM")
                .Member(m => m.FrgTypCode).Name("FRG_TYP_CODE")
                .Member(m => m.Totalexaddtax).Name("TOTALEXADDTAX")
                .Member(m => m.AffectCollatrl).Name("AFFECT_COLLATRL")
                .Member(m => m.Qprodfcref).Name("QPRODFCREF")
                .Member(m => m.Grpfirmtrans).Name("GRPFIRMTRANS")
                .Member(m => m.ExchinfoInternalReference).Name("EXCHINFO_INTERNAL_REFERENCE")
                .Member(m => m.ExchinfoFicheRef).Name("EXCHINFO_FICHE_REF")
                .Member(m => m.ExchinfoAddDiscounts).Name("EXCHINFO_ADD_DISCOUNTS")
                .Member(m => m.ExchinfoTotalDiscount).Name("EXCHINFO_TOTAL_DISCOUNTS")
                .Member(m => m.ExchinfoTotalDiscounted).Name("EXCHINFO_TOTAL_DISCOUNTED")
                .Member(m => m.ExchinfoAddExpenses).Name("EXCHINFO_ADD_EXPENSES")
                .Member(m => m.ExchinfoTotalExpenses).Name("EXCHINFO_TOTAL_EXPENSES")
                .Member(m => m.ExchinfoDistExpense).Name("EXCHINFO_DIST_EXPENSE")
                .Member(m => m.ExchinfoTotalDepozito).Name("EXCHINFO_TOTAL_DEPOZITO")
                .Member(m => m.ExchinfoTotalPromotions).Name("EXCHINFO_TOTAL_PROMOTIONS")
                .Member(m => m.ExchinfoVatIncGross).Name("EXCHINFO_VAT_INC_GROSS")
                .Member(m => m.ExchinfoTotalVat).Name("EXCHINFO_TOTAL_VAT")
                .Member(m => m.ExchinfoGrossTotal).Name("EXCHINFO_GROSS_TOTAL")
                .Member(m => m.ExchinfoTotalAddTax).Name("EXCHINFO_TOTAL_ADD_TAX")
                .Member(m => m.ExchinfoTotalExAddTax).Name("EXCHINFO_TOTAL_EX_ADD_TAX")
                .Member(m => m.ExchinfoBagkur).Name("EXCHINFO_BAGKUR")
                .Member(m => m.ExchinfoStopaj).Name("EXCHINFO_STOPAJ")
                .Member(m => m.ExchinfoSsdf).Name("EXCHINFO_SSDF")
                .Member(m => m.ExchinfoBorsa).Name("EXCHINFO_BORSA")
                .Member(m => m.ExchinfoKomisyon).Name("EXCHINFO_KOMISYON")
                .Member(m => m.ExchinfoKomKdv).Name("EXCHINFO_KOM_KDV")
                .Member(m => m.ExchinfoEk1).Name("EXCHINFO_EK1")
                .Member(m => m.ExchinfoEk2).Name("EXCHINFO_EK2")
                .Member(m => m.ExchinfoEk3).Name("EXCHINFO_EK3")
                .Member(m => m.ExchinfoEk4).Name("EXCHINFO_EK4")
                .Member(m => m.ExchinfoEk5).Name("EXCHINFO_EK5")
                .Member(m => m.AccFicheSiteid).Name("ACC_FICHE_SITEID")
                .Member(m => m.ShipDate).Name("SHIP_DATE")
                .Member(m => m.ShipTime).Name("SHIP_TIME")
                .Member(m => m.AutofillSlDetails).Name("AUTOFILL_SLDETAILS")
                .Member(m => m.Reltransfcref).Name("RELTRANSFCREF")
                .Member(m => m.Fromtransfer).Name("FROMTRANSFER")
                .Member(m => m.Status).Name("STATUS")
                .Member(m => m.LocControlOff).Name("LOC_CONTROL_OFF")
                .Member(m => m.CancelAutoGlProc).Name("CANCEL_AUTO_GL_PROC")
                .Member(m => m.EbookDocdate).Name("EBOOK_DOCDATE")
                .Member(m => m.EbookNodocument).Name("EBOOK_NODOCUMENT")
                .Member(m => m.EbookDocnr).Name("EBOOK_DOCNR")
                .Member(m => m.EbookDoctype).Name("EBOOK_DOCTYPE")
                .Member(m => m.EbookExplain).Name("EBOOK_EXPLAIN")
                .Member(m => m.EbookPaytype).Name("EBOOK_PAYTYPE")
                .Member(m => m.EbookNopay).Name("EBOOK_NOPAY")
                .Member(m => m.Transactions).Name("TRANSACTIONS")
                .Member(m => m.DefnFldsList).Name("DEFNFLDSLIST")
                .Member(m => m.DemandPeggings).Name("DEMANDPEGGINGS")
                .Member(m => m.Edespatch).Name("EDESPATCH")
                .Member(m => m.EinvoiceDriverName1).Name("EINVOICE_DRIVERNAME1")
                .Member(m => m.EinvoiceDriverSurname1).Name("EINVOICE_DRIVERSURNAME1")
                .Member(m => m.EinvoiceDriverTckno1).Name("EINVOICE_DRIVERTCKNO1")
                .Member(m => m.EinvoicePlateNum1).Name("EINVOICE_PLATENUM1")
                .Member(m => m.EinvoiceChassisNum1).Name("EINVOICE_CHASSISNUM1")
                ;
        }
    }
}
