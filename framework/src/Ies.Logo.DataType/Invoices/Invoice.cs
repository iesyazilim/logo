using System;
using System.Collections.Generic;
using Ies.Logo.Core;
using Ies.Logo.DataType.AggregateRoot;
using Ies.Logo.DataType.DefinitionFields;
using Ies.Logo.DataType.Dispatches;
using Ies.Logo.DataType.Infrastructure;
using Ies.Logo.DataType.Payments;

namespace Ies.Logo.DataType.Invoices
{
    [Serializable]
    public class Invoice : AuditedAggregateRoot, ISpecialCode, ICancelled, INotes, IPaymentCode, IDivision, IDepartment, ITradingGroup, IDataSiteId, IFactory, IProjectCode, IApprove, IGlobalId, IDataNo
    {
        public string DataNumber { get => Number; set => Number = value; }
        public virtual string Number { get; set; }
        public virtual InvoiceType Type { get; set; }
        public virtual string DocTrackNr { get; set; }
        public virtual Nullable<DateTime> Date { get; set; }
        public virtual Nullable<int> Time { get; set; }
        public virtual string DocNumber { get; set; }
        public virtual string ArpCode { get; set; }
        public virtual string ArpCodeShpm { get; set; }
        public virtual string ShiplocCode { get; set; }
        public virtual string OhpCode { get; set; }
        public virtual string GlCode { get; set; }
        public virtual Nullable<short> SourceWh { get; set; }
        public virtual Nullable<int> SourceCostGrp { get; set; }
        public virtual Nullable<short> GlPosted { get; set; }
        public virtual Nullable<short> PostFlags { get; set; }
        public virtual Nullable<decimal> VatRate { get; set; }
        public virtual Nullable<decimal> AddDiscounts { get; set; }
        public virtual Nullable<decimal> TotalDiscounts { get; set; }
        public virtual Nullable<decimal> TotalDiscounted { get; set; }
        public virtual Nullable<decimal> AddExpenses { get; set; }
        public virtual Nullable<decimal> TotalExpenses { get; set; }
        public virtual Nullable<decimal> ExpenseDistrb { get; set; }
        public virtual Nullable<decimal> TotalDeposited { get; set; }
        public virtual Nullable<decimal> TotalPromotions { get; set; }
        public virtual Nullable<decimal> TotalGrossVinc { get; set; }
        public virtual Nullable<decimal> TotalGross { get; set; }
        public virtual Nullable<decimal> TotalVat { get; set; }
        public virtual Nullable<decimal> TotalNet { get; set; }
        public virtual Nullable<decimal> InterestAccrd { get; set; }
        public virtual Nullable<short> CurrInvoice { get; set; }
        public virtual Nullable<decimal> TcXrate { get; set; }
        public virtual Nullable<decimal> TcNet { get; set; }
        public virtual Nullable<decimal> RcXrate { get; set; }
        public virtual Nullable<decimal> RcNet { get; set; }
        public virtual Nullable<short> SinglePayment { get; set; }
        public virtual Nullable<int> PrintCounter { get; set; }
        public virtual Nullable<short> VatIncludedGrs { get; set; }
        public virtual Nullable<int> AccFicheRef { get; set; }
        public virtual Nullable<short> PriceUpdNeg { get; set; }
        public virtual string SalesmanCode { get; set; }
        public virtual string ShipmentType { get; set; }
        public virtual string ShipmentAgent { get; set; }
        public virtual string TrackNr { get; set; }
        public virtual Nullable<int> CurrselTotals { get; set; }
        public virtual Nullable<int> CurrselDetails { get; set; }
        public virtual Nullable<int> TextInc { get; set; }
        public virtual Nullable<decimal> StopajRate { get; set; }
        public virtual Nullable<decimal> SsdfRate { get; set; }
        public virtual Nullable<decimal> BorsaRate { get; set; }
        public virtual Nullable<decimal> KomisyonRate { get; set; }
        public virtual Nullable<decimal> KomkdvRate { get; set; }
        public virtual Nullable<decimal> BagkurRate { get; set; }
        public virtual Nullable<decimal> Stopaj { get; set; }
        public virtual Nullable<decimal> Ssdf { get; set; }
        public virtual Nullable<decimal> Borsa { get; set; }
        public virtual Nullable<decimal> Komisyon { get; set; }
        public virtual Nullable<decimal> Komkdv { get; set; }
        public virtual Nullable<decimal> Bagkur { get; set; }
        public virtual Nullable<decimal> Ek1Per { get; set; }
        public virtual Nullable<decimal> Ek1 { get; set; }
        public virtual Nullable<decimal> Ek2Per { get; set; }
        public virtual Nullable<decimal> Ek2 { get; set; }
        public virtual Nullable<decimal> Ek3Per { get; set; }
        public virtual Nullable<decimal> Ek3 { get; set; }
        public virtual Nullable<decimal> Ek4Per { get; set; }
        public virtual Nullable<decimal> Ek4 { get; set; }
        public virtual Nullable<decimal> Ek5Per { get; set; }
        public virtual Nullable<decimal> Ek5 { get; set; }
        public virtual string StopajAcc { get; set; }
        public virtual string SsdfAcc { get; set; }
        public virtual string BorsaAcc { get; set; }
        public virtual string KomisyonAcc { get; set; }
        public virtual string KomkdvAcc { get; set; }
        public virtual string BagkurAcc { get; set; }
        public virtual string StopajCost { get; set; }
        public virtual string SsdfCost { get; set; }
        public virtual string BorsaCost { get; set; }
        public virtual string KomisyonCost { get; set; }
        public virtual string KomkdvCost { get; set; }
        public virtual string BagkurCost { get; set; }
        public virtual Nullable<short> KomType { get; set; }
        public virtual string Ek1Acc { get; set; }
        public virtual string Ek2Acc { get; set; }
        public virtual string Ek3Acc { get; set; }
        public virtual string Ek4Acc { get; set; }
        public virtual string Ek5Acc { get; set; }
        public virtual string Ek1Cost { get; set; }
        public virtual string Ek2Cost { get; set; }
        public virtual string Ek3Cost { get; set; }
        public virtual string Ek4Cost { get; set; }
        public virtual string Ek5Cost { get; set; }
        public virtual Nullable<int> Costofsalefcref { get; set; }
        public virtual Nullable<short> DlvClient { get; set; }
        public virtual Nullable<int> OpStatus { get; set; }
        public virtual Nullable<decimal> TotalAddTax { get; set; }
        public virtual Nullable<int> PaymentType { get; set; }
        public virtual Nullable<int> AccountedCnt { get; set; }
        public virtual Nullable<decimal> InflationIdx { get; set; }
        public virtual string CashTranGrpNo { get; set; }
        public virtual Nullable<int> CashTranGrpLineNo { get; set; }
        public virtual Nullable<decimal> CashInfldx { get; set; }
        public virtual Nullable<short> FromExim { get; set; }
        public virtual string CashOrgLogoId { get; set; }
        public virtual string FrgTypeCode { get; set; }
        public virtual Nullable<int> EximFicheType { get; set; }
        public virtual Nullable<int> WfLowCardRef { get; set; }
        public virtual Nullable<int> Status { get; set; }
        public virtual Nullable<int> DeductionPart1 { get; set; }
        public virtual Nullable<int> DeductionPart2 { get; set; }
        public virtual Nullable<int> DataLinkReference { get; set; }
        public virtual Nullable<decimal> TotalExAddTax { get; set; }
        public virtual Nullable<short> ExAccounted { get; set; }
        public virtual Nullable<short> FromBank { get; set; }
        public virtual Nullable<short> AffectCollatrl { get; set; }
        public virtual Nullable<short> FromOrdWithPay { get; set; }
        public virtual Nullable<short> GrpFirmTrans { get; set; }
        public virtual Nullable<short> AffectRisk { get; set; }
        public virtual Nullable<decimal> ExchinfoAddDiscounts { get; set; }
        public virtual Nullable<decimal> ExchinfoTotalDiscounts { get; set; }
        public virtual Nullable<decimal> ExchinfoTotalDiscounted { get; set; }
        public virtual Nullable<decimal> ExchinfoAddExpenses { get; set; }
        public virtual Nullable<decimal> ExchinfoTotalExpenses { get; set; }
        public virtual Nullable<decimal> ExchinfoDistExpense { get; set; }
        public virtual Nullable<decimal> ExchinfoTotalDepozito { get; set; }
        public virtual Nullable<decimal> ExchinfoTotalPromotions { get; set; }
        public virtual Nullable<decimal> ExchinfoVatIncGross { get; set; }
        public virtual Nullable<decimal> ExchinfoTotalVat { get; set; }
        public virtual Nullable<decimal> ExchinfoGrossTotal { get; set; }
        public virtual Nullable<decimal> ExchinfoTotalAddTax { get; set; }
        public virtual Nullable<decimal> ExchinfoTotalExAddTax { get; set; }
        public virtual Nullable<decimal> ExchinfoBagkur { get; set; }
        public virtual Nullable<decimal> ExchinfoStopaj { get; set; }
        public virtual Nullable<decimal> ExchinfoSsdf { get; set; }
        public virtual Nullable<decimal> ExchinfoBorsa { get; set; }
        public virtual Nullable<decimal> ExchinfoKomisyon { get; set; }
        public virtual Nullable<decimal> ExchinfoKomkdv { get; set; }
        public virtual Nullable<decimal> ExchinfoEk1 { get; set; }
        public virtual Nullable<decimal> ExchinfoEk2 { get; set; }
        public virtual Nullable<decimal> ExchinfoEk3 { get; set; }
        public virtual Nullable<decimal> ExchinfoEk4 { get; set; }
        public virtual Nullable<decimal> ExchinfoEk5 { get; set; }
        public virtual Nullable<short> ControlInfo { get; set; }
        public virtual Nullable<int> PosTransferInfo { get; set; }
        public virtual Nullable<short> TaxFreeCheck { get; set; }
        public virtual string PassportNo { get; set; }
        public virtual string CreditCardNo { get; set; }
        public virtual string CreditCardNumber { get; set; }
        public virtual Nullable<int> AccFicheSiteId { get; set; }
        public virtual Nullable<short> Entrust { get; set; }
        public virtual Nullable<DateTime> DocDate { get; set; }
        public virtual Nullable<short> AutofillSlDetails { get; set; }
        public virtual Nullable<short> Einvoice { get; set; }
        public virtual Nullable<short> EarchivedetrInsteadofdesp { get; set; }
        public virtual Nullable<short> EInstedOfDispatch { get; set; }
        public virtual string EarchivedetrDrivername1 { get; set; }
        public virtual string EinvoiceDrivername1 { get; set; }
        public virtual string EarchivedetrDriverSurname1 { get; set; }
        public virtual string EinvoiceDriverSurname1 { get; set; }
        public virtual string EarchivedetrDriverTckno1 { get; set; }
        public virtual string EinvoiceDriverTckno1 { get; set; }
        public virtual string EarchivedetrPlatenum1 { get; set; }
        public virtual string EinvoicePlatenum1 { get; set; }
        public virtual string EarchivedetrChassisNum1 { get; set; }
        public virtual string EinvoiceChassisNum1 { get; set; }
        public virtual Nullable<short> EbookDoctype { get; set; }
        public virtual Nullable<int> ProfileId { get; set; }
        public virtual Nullable<int> Estatus { get; set; }
        public virtual Nullable<DateTime> EstartDate { get; set; }
        public virtual Nullable<DateTime> Eenddate { get; set; }
        public virtual string Edescription { get; set; }
        public virtual Nullable<decimal> Eduration { get; set; }
        public virtual Nullable<int> EdurationType { get; set; }
        public virtual string PayplanGlobalCode { get; set; }
        public virtual string TrcurrGlobalCode { get; set; }
        public virtual string EdtcurrGlobalCode { get; set; }
        public virtual Nullable<short> CancelAutoGlProc { get; set; }
        public virtual Nullable<short> Devir { get; set; }
        public virtual Nullable<short> LocControlOff { get; set; }
        public virtual Nullable<short> CantCreDeduct { get; set; }
        public virtual string VatExceptReason { get; set; }
        public virtual string VatExceptCode { get; set; }
        public virtual string AddTaxExceptReason { get; set; }
        public virtual string AddTaxExceptCode { get; set; }
        public virtual Nullable<short> EinvoiceType { get; set; }
        public virtual string TotalNetStr { get; set; }
        public virtual string TrNetStr { get; set; }
        public virtual string CampaignCode { get; set; }
        public virtual string ShiplocDef { get; set; }
        public virtual Nullable<short> EximVat { get; set; }
        public virtual string SerialCode { get; set; }
        public virtual Nullable<int> EarchivedetrLogicalref { get; set; }
        public virtual Nullable<int> EarchivedetrInvoiceref { get; set; }
        public virtual string EarchivedetrInstallmentNumber { get; set; }
        public virtual Nullable<int> EarchivedetrEarchiveStatus { get; set; }
        public virtual Nullable<int> EarchivedetrSendmod { get; set; }
        public virtual string EarchivedetrIntsaleaddr { get; set; }
        public virtual string EarchivedetrIntpaymentdesc { get; set; }
        public virtual Nullable<int> EarchivedetrIntpaymentType { get; set; }
        public virtual string EarchivedetrIntpaymentAgent { get; set; }
        public virtual string EarchivedetrIntpaymentDate { get; set; }
        public virtual string DelvryCode { get; set; }

        #region Implementation
        public virtual string AuthCode { get; set; }
        public virtual string AuxilCode { get; set; }
        public virtual Nullable<short> Cancelled { get; set; }
        public virtual string Notes1 { get; set; }
        public virtual string Notes2 { get; set; }
        public virtual string Notes3 { get; set; }
        public virtual string Notes4 { get; set; }
        public virtual string PaymentCode { get; set; }
        public virtual Nullable<short> Division { get; set; }
        public virtual Nullable<short> Department { get; set; }
        public virtual Nullable<short> Factory { get; set; }
        public virtual string TradingGrp { get; set; }
        public virtual Nullable<int> DataSiteId { get; set; }
        public virtual string ProjectCode { get; set; }
        public virtual Nullable<short> Approve { get; set; }
        public virtual Nullable<DateTime> ApproveDate { get; set; }
        public virtual string GlobalId { get; set; }
        #endregion

        #region SubClasses
        public virtual List<Transaction> Transactions { get; set; }
        public virtual List<DefnFld> GeniusFldsList { get; set; }
        public virtual List<Payment> PaymentList { get; set; }
        public virtual List<DefnFld> DefnFldsList { get; set; }
        public virtual List<Intel> IntelList { get; set; }
        public virtual List<PreAccLn> PreAccLines { get; set; }
        public virtual List<Dispatch> Dispatches { get; set; }
        public virtual List<OkcInfo> OkcInfoList { get; set; }
        #endregion

        public override LogoObjectType GetRootElementName()
        {
            switch (Type)
            {
                case InvoiceType.Purchase:
                case InvoiceType.PurchaseService:
                case InvoiceType.PurchaseProforma:
                case InvoiceType.PurchaseReturn:
                case InvoiceType.PurchasePriceDifference:
                default:
                    return LogoObjectType.PURCHASE_INVOICES;

                case InvoiceType.SalesRetailReturn:
                case InvoiceType.SalesWholesaleReturn:
                case InvoiceType.SalesRetail:
                case InvoiceType.SalesWholesale:
                case InvoiceType.SalesService:
                case InvoiceType.SalesProforma:
                case InvoiceType.SalesPriceDifference:
                    return LogoObjectType.SALES_INVOICES;

            }
        }
    }
}
