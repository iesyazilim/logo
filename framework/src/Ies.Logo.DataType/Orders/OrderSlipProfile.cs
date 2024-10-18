using ExtendedXmlSerializer;
using ExtendedXmlSerializer.Configuration;
using Ies.Logo.DataType.Xml;

namespace Ies.Logo.DataType.Orders
{
    public class OrderSlipProfile : IConfigurationProfile
    {
        public static OrderSlipProfile Default { get; } = new OrderSlipProfile();

        private OrderSlipProfile() { }

        public IConfigurationContainer Get(IConfigurationContainer parameter)
        {
            var configuration = parameter.Type<OrderSlip>();

            Configure(configuration);

            return configuration;
        }

        public static void Configure<T>(ITypeConfiguration<T> typeConfigurations) where T : OrderSlip
        {
            typeConfigurations.Configure();
            typeConfigurations.Name<T>("ORDER_SLIP");

            typeConfigurations
                .Member(m => m.IsSales).Ignore()
                .Member(m => m.Number).Name("NUMBER")
                .Member(m => m.DocTrackNr).Name("DOC_TRACK_NR")
                .Member(m => m.Date).Name("DATE")
                .Member(m => m.Time).Name("TIME")
                .Member(m => m.DocNumber).Name("DOC_NUMBER")
                .Member(m => m.ArpCode).Name("ARP_CODE")
                .Member(m => m.ArpCodeShpm).Name("ARP_CODE_SHPM")
                .Member(m => m.ShiplocCode).Name("SHIPLOC_CODE")
                .Member(m => m.GlCode).Name("GL_CODE")
                .Member(m => m.OhpCode).Name("OHP_CODE")
                .Member(m => m.SourceWh).Name("SOURCE_WH")
                .Member(m => m.SourceCostGrp).Name("SOURCE_COST_GRP")
                .Member(m => m.AddDiscounts).Name("ADD_DISCOUNTS")
                .Member(m => m.TotalDiscounts).Name("TOTAL_DISCOUNTS")
                .Member(m => m.TotalDiscounted).Name("TOTAL_DISCOUNTED")
                .Member(m => m.AddExpenses).Name("ADD_EXPENSES")
                .Member(m => m.TotalExpenses).Name("TOTAL_EXPENSES")
                .Member(m => m.TotalPromotions).Name("TOTAL_PROMOTIONS")
                .Member(m => m.TotalVat).Name("TOTAL_VAT")
                .Member(m => m.TotalGross).Name("TOTAL_GROSS")
                .Member(m => m.TotalNet).Name("TOTAL_NET")
                .Member(m => m.RcRate).Name("RC_RATE")
                .Member(m => m.RcNet).Name("RC_NET")
                .Member(m => m.Paydefref).Name("PAYDEFREF")
                .Member(m => m.PrintCounter).Name("PRINT_COUNTER")
                .Member(m => m.OrderStatus).Name("ORDER_STATUS")
                .Member(m => m.SalesmanCode).Name("SALESMAN_CODE")
                .Member(m => m.ShipmentType).Name("SHIPMENT_TYPE")
                .Member(m => m.ShippingAgent).Name("SHIPPING_AGENT")
                .Member(m => m.CurrselTotals).Name("CURRSEL_TOTAL")
                .Member(m => m.CurrselDetails).Name("CURRSEL_DETAILS")
                .Member(m => m.CustOrdNo).Name("CUST_ORD_NO")
                .Member(m => m.DlvClient).Name("DLV_CLIENT")
                .Member(m => m.DocTrackingNr).Name("DOC_TRACKING_NR")
                .Member(m => m.OfferReference).Name("OFFER_REFERENCE")
                .Member(m => m.OffaltReference).Name("OFFALT_REFERENCE")
                .Member(m => m.OfferTyp).Name("OFFER_TYP")
                .Member(m => m.OfferAltnr).Name("OFFER_ALTNR")
                .Member(m => m.CurrTranactin).Name("CURR_TRANSACTIN")
                .Member(m => m.Einvoice).Name("EINVOICE")
                .Member(m => m.EinvoiceProfileId).Name("EINVOICE_PROFILEID")
                .Member(m => m.EarchivedetrSendmod).Name("EARCHIVEDETR_SENDMOD")
                .Member(m => m.EarchivedetrIntpaymenttype).Name("EARCHIVEDETR_INTPAYMENTTYPE")
                .Member(m => m.EarchivedetrInsteadofdesp).Name("EARCHIVEDETR_INSTEADOFDESP")
                .Member(m => m.EarchivedetrIntpaymentdate).Name("EARCHIVEDETR_INTPAYMENTDATE")
                .Member(m => m.TcRate).Name("TC_RATE")
                .Member(m => m.WithPayment).Name("WITH_PAYMENT")
                .Member(m => m.Wflowcardref).Name("WFLOWCARDREF")
                .Member(m => m.OpStatus).Name("OP_STATUS")
                .Member(m => m.UpdCurr).Name("UPD_CURR")
                .Member(m => m.UpdTrcurr).Name("UPD_TRCURR")
                .Member(m => m.AffectCollatrl).Name("AFFECT_COLLATRL")
                .Member(m => m.TotalAddTax).Name("TOTAL_ADD_TAX")
                .Member(m => m.TotalExAddTax).Name("TOTAL_EX_ADD_TAX")
                .Member(m => m.AffectRisk).Name("AFFECT_RISK")
                .Member(m => m.PaymentType).Name("PAYMENT_TYPE")
                .Member(m => m.FcStatusName).Name("FC_STATUS_NAME")
                .Member(m => m.DeductionPart1).Name("DEDUCTIONPART1")
                .Member(m => m.DeductionPart2).Name("DEDUCTIONPART2")
                .Member(m => m.CampaignCode).Name("CAMPAIGN_CODE")
                .Member(m => m.Transactions).Name("TRANSACTIONS")
                .Member(m => m.PaymentList).Name("PAYMENT_LIST")
                .Member(m => m.DefnFldsList).Name("DEFNFLDSLIST")
                .Member(m => m.DemandPeggings).Name("DEMANDPEGGINGS")
                .Member(m => m.Itext).Name("ITEXT")
                ;
        }
    }
}
