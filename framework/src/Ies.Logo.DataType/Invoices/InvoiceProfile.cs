﻿using ExtendedXmlSerializer;
using ExtendedXmlSerializer.Configuration;
using Ies.Logo.DataType.Xml;

namespace Ies.Logo.DataType.Invoices
{
    public class InvoiceProfile : IConfigurationProfile
    {
        public static InvoiceProfile Default { get; } = new InvoiceProfile();

        private InvoiceProfile() { }

        public IConfigurationContainer Get(IConfigurationContainer parameter)
        {
            var configuration = parameter.Type<Invoice>();

            Configure(configuration);

            return configuration;
        }

        public static void Configure<T>(ITypeConfiguration<T> typeConfigurations) where T : Invoice
        {
            typeConfigurations.Configure();
            typeConfigurations.Name<T>("INVOICE");

            typeConfigurations
                .Member(m => m.Number).Name("NUMBER")
                .Member(m => m.Type).Name("TYPE")
                .Member(m => m.Transactions).Name("TRANSACTIONS")
                .Member(m => m.GeniusFldsList).Name("GENIUSFLDSLIST")
                .Member(m => m.PaymentList).Name("PAYMENT_LIST")
                .Member(m => m.DefnFldsList).Name("DEFNFLDSLIST")
                .Member(m => m.IntelList).Name("INTEL_LIST")
                .Member(m => m.PreAccLines).Name("PREACCLINES")
                .Member(m => m.Dispatches).Name("DISPATCHES")
                .Member(m => m.OkcInfoList).Name("OKCINFO_LIST")
                .Member(m => m.DocTrackNr).Name("DOC_TRACK_NR")
                .Member(m => m.Date).Name("DATE")
                .Member(m => m.Time).Name("TIME")
                .Member(m => m.DocNumber).Name("DOC_NUMBER")
                .Member(m => m.ArpCode).Name("ARP_CODE")
                .Member(m => m.ArpCodeShpm).Name("ARP_CODE_SHPM")
                .Member(m => m.ShiplocCode).Name("SHIPLOC_CODE")
                .Member(m => m.OhpCode).Name("OHP_CODE")
                .Member(m => m.GlCode).Name("GL_CODE")
                .Member(m => m.SourceWh).Name("SOURCE_WH")
                .Member(m => m.SourceCostGrp).Name("SOURCE_COST_GRP")
                .Member(m => m.GlPosted).Name("GL_POSTED")
                .Member(m => m.PostFlags).Name("POST_FLAGS")
                .Member(m => m.VatRate).Name("VAT_RATE")
                .Member(m => m.AddDiscounts).Name("ADD_DISCOUNTS")
                .Member(m => m.TotalDiscounts).Name("TOTAL_DISCOUNTS")
                .Member(m => m.TotalDiscounted).Name("TOTAL_DISCOUNTED")
                .Member(m => m.AddExpenses).Name("ADD_EXPENSES")
                .Member(m => m.TotalExpenses).Name("TOTAL_EXPENSES")
                .Member(m => m.ExpenseDistrb).Name("EXPENSE_DISTRB")
                .Member(m => m.TotalDeposited).Name("TOTAL_DEPOSITED")
                .Member(m => m.TotalPromotions).Name("TOTAL_PROMOTIONS")
                .Member(m => m.TotalGrossVinc).Name("TOTAL_GROSSVINC")
                .Member(m => m.TotalVat).Name("TOTAL_VAT")
                .Member(m => m.TotalGross).Name("TOTAL_GROSS")
                .Member(m => m.TotalNet).Name("TOTAL_NET")
                .Member(m => m.InterestAccrd).Name("INTEREST_ACCRD")
                .Member(m => m.CurrInvoice).Name("CURR_INVOICE")
                .Member(m => m.TcXrate).Name("TC_XRATE")
                .Member(m => m.TcNet).Name("TC_NET")
                .Member(m => m.RcXrate).Name("RC_XRATE")
                .Member(m => m.RcNet).Name("RC_NET")
                .Member(m => m.SinglePayment).Name("SINGLE_PAYMENT")
                .Member(m => m.PrintCounter).Name("PRINT_COUNTER")
                .Member(m => m.VatIncludedGrs).Name("VAT_INCLUDED_GRS")
                .Member(m => m.AccFicheRef).Name("ACCFICHEREF")
                .Member(m => m.PriceUpdNeg).Name("PRICE_UPD_NEG")
                .Member(m => m.SalesmanCode).Name("SALESMAN_CODE")
                .Member(m => m.ShipmentType).Name("SHIPMENT_TYPE")
                .Member(m => m.ShipmentAgent).Name("SHIPPING_AGENT")
                .Member(m => m.TrackNr).Name("TRACK_NR")
                .Member(m => m.CurrselTotals).Name("CURRSEL_TOTALS")
                .Member(m => m.CurrselDetails).Name("CURRSEL_DETAILS")
                .Member(m => m.TextInc).Name("TEXTINC")
                .Member(m => m.StopajRate).Name("STOPAJ_RATE")
                .Member(m => m.SsdfRate).Name("SSDF_RATE")
                .Member(m => m.BorsaRate).Name("BORSA_RATE")
                .Member(m => m.KomisyonRate).Name("KOMISYON_RATE")
                .Member(m => m.KomkdvRate).Name("KOMKDV_RATE")
                .Member(m => m.BagkurRate).Name("BAGKUR_RATE")
                .Member(m => m.Stopaj).Name("STOPAJ")
                .Member(m => m.Ssdf).Name("SSDF")
                .Member(m => m.Borsa).Name("BORSA")
                .Member(m => m.Komisyon).Name("KOMISYON")
                .Member(m => m.Komkdv).Name("KOMKDV")
                .Member(m => m.Bagkur).Name("BAGKUR")
                .Member(m => m.Ek1Per).Name("EK1_PER")
                .Member(m => m.Ek1).Name("EK1")
                .Member(m => m.Ek2Per).Name("EK2_PER")
                .Member(m => m.Ek2).Name("EK2")
                .Member(m => m.Ek3Per).Name("EK3_PER")
                .Member(m => m.Ek3).Name("EK3")
                .Member(m => m.Ek4Per).Name("EK4_PER")
                .Member(m => m.Ek4).Name("EK4")
                .Member(m => m.Ek5Per).Name("EK5_PER")
                .Member(m => m.Ek5).Name("EK5")
                .Member(m => m.StopajAcc).Name("STOPAJACC")
                .Member(m => m.SsdfAcc).Name("SSDFACC")
                .Member(m => m.BorsaAcc).Name("BORSAACC")
                .Member(m => m.KomisyonAcc).Name("KOMISYONACC")
                .Member(m => m.KomkdvAcc).Name("KOMKDVACC")
                .Member(m => m.BagkurAcc).Name("BAGKURACC")
                .Member(m => m.StopajCost).Name("STOPAJCOST")
                .Member(m => m.SsdfCost).Name("SSDFCOST")
                .Member(m => m.BorsaCost).Name("BORSACOST")
                .Member(m => m.KomisyonCost).Name("KOMISYONCOST")
                .Member(m => m.KomkdvCost).Name("KOMKDVCOST")
                .Member(m => m.BagkurCost).Name("BAGKURCOST")
                .Member(m => m.KomType).Name("KOM_TYPE")
                .Member(m => m.Ek1Acc).Name("EK1ACC")
                .Member(m => m.Ek2Acc).Name("EK2ACC")
                .Member(m => m.Ek3Acc).Name("EK3ACC")
                .Member(m => m.Ek4Acc).Name("EK4ACC")
                .Member(m => m.Ek5Acc).Name("EK5ACC")
                .Member(m => m.Ek1Cost).Name("EK1COST")
                .Member(m => m.Ek2Cost).Name("EK2COST")
                .Member(m => m.Ek3Cost).Name("EK3COST")
                .Member(m => m.Ek4Cost).Name("EK4COST")
                .Member(m => m.Ek5Cost).Name("EK5COST")
                .Member(m => m.Costofsalefcref).Name("COSTOFSALEFCREF")
                .Member(m => m.DlvClient).Name("DLV_CLIENT")
                .Member(m => m.OpStatus).Name("OP_STATUS")
                .Member(m => m.TotalAddTax).Name("TOTAL_ADD_TAX")
                .Member(m => m.PaymentType).Name("PAYMENT_TYPE")
                .Member(m => m.AccountedCnt).Name("ACCOUNTED_CNT")
                .Member(m => m.InflationIdx).Name("INFLATION_IDX")
                .Member(m => m.CashTranGrpNo).Name("CASH_TRAN_GRP_NO")
                .Member(m => m.CashTranGrpLineNo).Name("CASH_TRAN_GRPLINE_NO")
                .Member(m => m.CashInfldx).Name("CASH_INFLDX")
                .Member(m => m.FromExim).Name("FROM_EXIM")
                .Member(m => m.CashOrgLogoId).Name("CASH_ORGLOGOID")
                .Member(m => m.FrgTypeCode).Name("FRG_TYP_CODE")
                .Member(m => m.EximFicheType).Name("EXIM_FICHE_TYPE")
                .Member(m => m.WfLowCardRef).Name("WFLOWCARDREF")
                .Member(m => m.Status).Name("STATUS")
                .Member(m => m.DeductionPart1).Name("DEDUCTIONPART1")
                .Member(m => m.DeductionPart2).Name("DEDUCTIONPART2")
                .Member(m => m.DataLinkReference).Name("DATA_LINK_REFERENCE")
                .Member(m => m.TotalExAddTax).Name("TOTALEXADDTAX")
                .Member(m => m.ExAccounted).Name("EXACCOUNTED")
                .Member(m => m.FromBank).Name("FROMBANK")
                .Member(m => m.AffectCollatrl).Name("AFFECT_COLLATRL")
                .Member(m => m.FromOrdWithPay).Name("FROMORDWITHPAY")
                .Member(m => m.GrpFirmTrans).Name("GRPFIRMTRANS")
                .Member(m => m.AffectRisk).Name("AFFECT_RISK")
                .Member(m => m.ExchinfoAddDiscounts).Name("EXCHINFO_ADD_DISCOUNTS")
                .Member(m => m.ExchinfoTotalDiscounts).Name("EXCHINFO_TOTAL_DISCOUNTS")
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
                .Member(m => m.ExchinfoKomkdv).Name("EXCHINFO_KOM_KDV")
                .Member(m => m.ExchinfoEk1).Name("EXCHINFO_EK1")
                .Member(m => m.ExchinfoEk2).Name("EXCHINFO_EK2")
                .Member(m => m.ExchinfoEk3).Name("EXCHINFO_EK3")
                .Member(m => m.ExchinfoEk4).Name("EXCHINFO_EK4")
                .Member(m => m.ExchinfoEk5).Name("EXCHINFO_EK5")
                .Member(m => m.ControlInfo).Name("CONTROL_INFO")
                .Member(m => m.PosTransferInfo).Name("POS_TRANSFER_INFO")
                .Member(m => m.TaxFreeCheck).Name("TAX_FREE_CHECK")
                .Member(m => m.PassportNo).Name("PASSPORT_NO")
                .Member(m => m.CreditCardNo).Name("CREDIT_CARD_NO")
                .Member(m => m.CreditCardNumber).Name("CREDIT_CARD_NUMBER")
                .Member(m => m.AccFicheSiteId).Name("ACC_FICHE_SITEID")
                .Member(m => m.Entrust).Name("ENTRUST")
                .Member(m => m.DocDate).Name("DOC_DATE")
                .Member(m => m.AutofillSlDetails).Name("AUTOFILL_SLDETAILS")
                .Member(m => m.Einvoice).Name("EINVOICE")
                .Member(m => m.EarchivedetrInsteadofdesp).Name("EARCHIVEDETR_INSTEADOFDESP")
                .Member(m => m.EInstedOfDispatch).Name("EINSTEAD_OF_DISPATCH")
                .Member(m => m.EarchivedetrDrivername1).Name("EARCHIVEDETR_DRIVERNAME1")
                .Member(m => m.EinvoiceDrivername1).Name("EINVOICE_DRIVERNAME1")
                .Member(m => m.EarchivedetrDriverSurname1).Name("EARCHIVEDETR_DRIVERSURNAME1")
                .Member(m => m.EinvoiceDriverSurname1).Name("EINVOICE_DRIVERSURNAME1")
                .Member(m => m.EarchivedetrDriverTckno1).Name("EARCHIVEDETR_DRIVERTCKNO1")
                .Member(m => m.EinvoiceDriverTckno1).Name("EINVOICE_DRIVERTCKNO1")
                .Member(m => m.EarchivedetrPlatenum1).Name("EARCHIVEDETR_PLATENUM1")
                .Member(m => m.EinvoicePlatenum1).Name("EINVOICE_PLATENUM1")
                .Member(m => m.EarchivedetrChassisNum1).Name("EARCHIVEDETR_CHASSISNUM1")
                .Member(m => m.EinvoiceChassisNum1).Name("EINVOICE_CHASSISNUM1")
                .Member(m => m.EbookDoctype).Name("EBOOK_DOCTYPE")
                .Member(m => m.ProfileId).Name("PROFILE_ID")
                .Member(m => m.Estatus).Name("ESTATUS")
                .Member(m => m.EstartDate).Name("ESTARTDATE")
                .Member(m => m.Eenddate).Name("EENDDATE")
                .Member(m => m.Edescription).Name("EDESCRIPTION")
                .Member(m => m.Eduration).Name("EDURATION")
                .Member(m => m.EdurationType).Name("EDURATION_TYPE")
                .Member(m => m.PayplanGlobalCode).Name("PAYPLAN_GLOBAL_CODE")
                .Member(m => m.TrcurrGlobalCode).Name("TRCURR_GLOBAL_CODE")
                .Member(m => m.EdtcurrGlobalCode).Name("EDTCURR_GLOBAL_CODE")
                .Member(m => m.CancelAutoGlProc).Name("CANCEL_AUTO_GL_PROC")
                .Member(m => m.Devir).Name("DEVIR")
                .Member(m => m.LocControlOff).Name("LOC_CONTROL_OFF")
                .Member(m => m.CantCreDeduct).Name("CANT_CRE_DEDUCT")
                .Member(m => m.VatExceptReason).Name("VATEXCEPT_REASON")
                .Member(m => m.VatExceptCode).Name("VATEXCEPT_CODE")
                .Member(m => m.AddTaxExceptReason).Name("ADDTAXEXCEPT_REASON")
                .Member(m => m.AddTaxExceptCode).Name("ADDTAXEXCEPT_CODE")
                .Member(m => m.EinvoiceType).Name("EINVOICE_TYPE")
                .Member(m => m.TotalNetStr).Name("TOTAL_NET_STR")
                .Member(m => m.TrNetStr).Name("TR_NET_STR")
                .Member(m => m.CampaignCode).Name("CAMPAIGN_CODE")
                .Member(m => m.ShiplocDef).Name("SHIPLOC_DEF")
                .Member(m => m.EximVat).Name("EXIMVAT")
                .Member(m => m.SerialCode).Name("SERIAL_CODE")
                .Member(m => m.EarchivedetrLogicalref).Name("EARCHIVEDETR_LOGICALREF")
                .Member(m => m.EarchivedetrInvoiceref).Name("EARCHIVEDETR_INVOICEREF")
                .Member(m => m.EarchivedetrInstallmentNumber).Name("EARCHIVEDETR_INSTALLMENTNUMBER")
                .Member(m => m.EarchivedetrEarchiveStatus).Name("EARCHIVEDETR_EARCHIVESTATUS")
                .Member(m => m.EarchivedetrSendmod).Name("EARCHIVEDETR_SENDMOD")
                .Member(m => m.EarchivedetrIntsaleaddr).Name("EARCHIVEDETR_INTSALESADDR")
                .Member(m => m.EarchivedetrIntpaymentdesc).Name("EARCHIVEDETR_INTPAYMENTDESC")
                .Member(m => m.EarchivedetrIntpaymentType).Name("EARCHIVEDETR_INTPAYMENTTYPE")
                .Member(m => m.EarchivedetrIntpaymentAgent).Name("EARCHIVEDETR_INTPAYMENTAGENT")
                .Member(m => m.EarchivedetrIntpaymentDate).Name("EARCHIVEDETR_INTPAYMENTDATE")
                .Member(m => m.DelvryCode).Name("DELIVERY_CODE")
                .Member(m => m.Itext).Name("ITEXT")
                ;
        }
    }
}
