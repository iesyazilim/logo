using System;
using System.Collections.Generic;
using Ies.Logo.Core;
using Ies.Logo.DataType.AggregateRoot;
using Ies.Logo.DataType.DefinitionFields;
using Ies.Logo.DataType.Infrastructure;
using Ies.Logo.DataType.Invoices;

namespace Ies.Logo.DataType.Dispatches
{
    [Serializable]
    public class Dispatch : AuditedAggregateRoot, ISpecialCode, IFactory, IDivision, IDepartment, ICancelled, INotes, IPaymentCode, ITradingGroup, IDataSiteId, IProjectCode, IApprove, IGlobalId
    {
        public virtual string Number { get; set; }
        public virtual DispatchType Type { get; set; }
        public virtual string DocTrackNr { get; set; }
        public virtual Nullable<DateTime> Date { get; set; }
        public virtual Nullable<int> Time { get; set; }
        public virtual string DocNumber { get; set; }
        public virtual Nullable<DateTime> DocDate { get; set; }
        public virtual string InvoiceNumber { get; set; }
        public virtual string ArpCode { get; set; }
        public virtual string ArpCodeShpm { get; set; }
        public virtual string ShiplocCode { get; set; }
        public virtual string GlCode { get; set; }
        public virtual string OhpCode { get; set; }
        public virtual string PorderNumber { get; set; }
        public virtual Nullable<short> SourceType { get; set; }
        public virtual Nullable<short> SourceWh { get; set; }
        public virtual string SourceWsCode { get; set; }
        public virtual Nullable<int> SourceCostGrp { get; set; }
        public virtual Nullable<short> DestType { get; set; }
        public virtual Nullable<short> DestWh { get; set; }
        public virtual string DestWsCode { get; set; }
        public virtual Nullable<int> DestCostGrp { get; set; }
        public virtual Nullable<short> DestDivision { get; set; }
        public virtual Nullable<short> DestDepartment { get; set; }
        public virtual Nullable<short> DestFactory { get; set; }
        public virtual Nullable<int> ProdStatus { get; set; }
        public virtual Nullable<short> Invoiced { get; set; }
        public virtual Nullable<short> GlPosted { get; set; }
        public virtual Nullable<short> InvoiceType { get; set; }
        public virtual Nullable<decimal> AddDiscounts { get; set; }
        public virtual Nullable<decimal> TotalDiscounts { get; set; }
        public virtual Nullable<decimal> TotalDiscounted { get; set; }
        public virtual Nullable<decimal> AddExpenses { get; set; }
        public virtual Nullable<decimal> TotalExpenses { get; set; }
        public virtual Nullable<decimal> TotalDeposited { get; set; }
        public virtual Nullable<decimal> TotalPromotions { get; set; }
        public virtual Nullable<decimal> TotalVat { get; set; }
        public virtual Nullable<decimal> TotalGross { get; set; }
        public virtual Nullable<decimal> TotalNet { get; set; }
        public virtual Nullable<short> Einvoice { get; set; }
        public virtual Nullable<short> EinvoiceType { get; set; }
        public virtual string EinvoiceDriverName1 { get; set; }
        public virtual string EinvoiceDriverSurname1 { get; set; }
        public virtual string EinvoiceDriverTckno1 { get; set; }
        public virtual string EinvoicePlateNum1 { get; set; }
        public virtual string EinvoiceChassisNum1 { get; set; }
        public virtual Nullable<short> EarchivedetrSendmod { get; set; }
        public virtual Nullable<short> EarchivedetrIntpaymentType { get; set; }
        public virtual string EarchivedetrDriverName1 { get; set; }
        public virtual string EarchivedetrDriverSurname1 { get; set; }
        public virtual string EarchivedetrDriverTckno1 { get; set; }
        public virtual string EarchivedetrPlateNum1 { get; set; }
        public virtual string EarchivedetrChassisNum1 { get; set; }
        public virtual string VatExceptReason { get; set; }
        public virtual string VatExceptCode { get; set; }
        public virtual Nullable<decimal> RcRate { get; set; }
        public virtual Nullable<decimal> RcNet { get; set; }
        public virtual Nullable<int> PrintCounter { get; set; }
        public virtual string SalesmanCode { get; set; }
        public virtual Nullable<short> GlPostCancl { get; set; }
        public virtual string ShipmentType { get; set; }
        public virtual string ShippingAgent { get; set; }
        public virtual string TrackNr { get; set; }
        public virtual Nullable<int> CurrselTotals { get; set; }
        public virtual Nullable<int> CurrselDetails { get; set; }
        public virtual Nullable<short> TextInc { get; set; }
        public virtual string OrigNumber { get; set; }
        public virtual Nullable<short> DlvClient { get; set; }
        public virtual string DocTrackingNr { get; set; }
        public virtual string UDocTrackingNr { get; set; }
        public virtual Nullable<short> AddTaxCalc { get; set; }
        public virtual Nullable<decimal> TotalAddTax { get; set; }
        public virtual string VaAccCode { get; set; }
        public virtual string VaCenterCode { get; set; }
        public virtual Nullable<short> FromExim { get; set; }
        public virtual string FrgTypeCode { get; set; }
        public virtual Nullable<int> EximWhFicheRef { get; set; }
        public virtual string EximWhFicheNo { get; set; }
        public virtual Nullable<short> CurrTransaction { get; set; }
        public virtual Nullable<decimal> TcRate { get; set; }
        public virtual Nullable<int> WfLowCrdref { get; set; }
        public virtual Nullable<short> UpdCurr { get; set; }
        public virtual Nullable<short> UpdTrCurr { get; set; }
        public virtual Nullable<decimal> TotalExAddTax { get; set; }
        public virtual Nullable<short> AffectCollatrl { get; set; }
        public virtual Nullable<int> Status { get; set; }
        public virtual Nullable<short> GrpFirmTrans { get; set; }
        public virtual Nullable<int> DeductionPart1 { get; set; }
        public virtual Nullable<int> DeductionPart2 { get; set; }
        public virtual Nullable<short> AffectRisk { get; set; }
        public virtual Nullable<decimal> ExchinfoAddDiscounts { get; set; }
        public virtual Nullable<decimal> ExchinfoTotalDiscounts { get; set; }
        public virtual Nullable<decimal> ExchinfoTotalDiscounted { get; set; }
        public virtual Nullable<decimal> ExchinfoAddExpenses { get; set; }
        public virtual Nullable<decimal> ExchinfoTotalExpenses { get; set; }
        public virtual Nullable<decimal> ExchinfoDistExpenses { get; set; }
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
        public virtual Nullable<decimal> ExchinfoKomKdv { get; set; }
        public virtual Nullable<decimal> ExchinfoEk1 { get; set; }
        public virtual Nullable<decimal> ExchinfoEk2 { get; set; }
        public virtual Nullable<decimal> ExchinfoEk3 { get; set; }
        public virtual Nullable<decimal> ExchinfoEk4 { get; set; }
        public virtual Nullable<decimal> ExchinfoEk5 { get; set; }
        public virtual Nullable<int> DispStatus { get; set; }
        public virtual Nullable<DateTime> ShipDate { get; set; }
        public virtual Nullable<int> ShipTime { get; set; }
        public virtual Nullable<int> DocTime { get; set; }
        public virtual Nullable<short> Edespatch { get; set; }
        public virtual Nullable<short> EdespatchStatus { get; set; }
        public virtual Nullable<short> AutofillSlDetails { get; set; }
        public virtual Nullable<int> MainMfReference { get; set; }
        public virtual Nullable<int> MainMfSiteId { get; set; }
        public virtual Nullable<short> LockControlDef { get; set; }
        public virtual string CampaingCode { get; set; }

        #region Implementation
        public virtual string AuthCode { get; set; }
        public virtual string AuxilCode { get; set; }
        public virtual Nullable<short> Factory { get; set; }
        public virtual Nullable<short> Division { get; set; }
        public virtual Nullable<short> Department { get; set; }
        public virtual Nullable<short> Cancelled { get; set; }
        public virtual string Notes1 { get; set; }
        public virtual string Notes2 { get; set; }
        public virtual string Notes3 { get; set; }
        public virtual string Notes4 { get; set; }
        public virtual string PaymentCode { get; set; }
        public virtual string TradingGrp { get; set; }
        public virtual Nullable<int> DataSiteId { get; set; }
        public virtual string ProjectCode { get; set; }
        public virtual Nullable<short> Approve { get; set; }
        public virtual Nullable<DateTime> ApproveDate { get; set; }
        public virtual string GlobalId { get; set; }
        #endregion

        #region SubClasses
        public virtual List<Transaction> Transactions { get; set; }
        public virtual List<DefnFld> DefnFldsList { get; set; }
        #endregion

        public override LogoObjectType GetRootElementName()
        {
            switch (Type)
            {
                case DispatchType.Purchase:
                case DispatchType.ConsignmentInDispatch:
                case DispatchType.PurchaseReturn:
                case DispatchType.ConsignmentInReturnDispatch:
                    return LogoObjectType.PURCHASE_DISPATCHES;

                case DispatchType.SalesRetailReturn:
                case DispatchType.SalesWholesaleReturn:
                case DispatchType.ConsignmentOutReturnDispatch:
                case DispatchType.SalesRetail:
                case DispatchType.SalesWholesale:
                case DispatchType.ConsignmentOutDispatch:
                    return LogoObjectType.SALES_DISPATCHES;

                default:
                    return LogoObjectType.UNKNOWN;
            }
        }
    }
}
