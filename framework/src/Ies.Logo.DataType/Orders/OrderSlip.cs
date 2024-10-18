using System;
using System.Collections.Generic;
using Ies.Logo.Core;
using Ies.Logo.DataType.AggregateRoot;
using Ies.Logo.DataType.DefinitionFields;
using Ies.Logo.DataType.DemandPeggings;
using Ies.Logo.DataType.Infrastructure;
using Ies.Logo.DataType.Payments;

namespace Ies.Logo.DataType.Orders
{
    [Serializable]
    public class OrderSlip : AuditedAggregateRoot, ISpecialCode, INotes, IPaymentCode, IDivision, IDepartment, ITradingGroup, IDataSiteId, IFactory, ICancelled, IProjectCode, IApprove, IGlobalId, IDataNo
    {
        public virtual bool IsSales { get; set; }
        public string DataNumber { get => Number; set => Number = value; }
        public virtual string Number { get; set; }
        public virtual string DocTrackNr { get; set; }
        public virtual Nullable<DateTime> Date { get; set; }
        public virtual Nullable<int> Time { get; set; }
        public virtual string DocNumber { get; set; }
        public virtual string ArpCode { get; set; }
        public virtual string ArpCodeShpm { get; set; }
        public virtual string ShiplocCode { get; set; }
        public virtual string GlCode { get; set; }
        public virtual string OhpCode { get; set; }
        public virtual Nullable<short> SourceWh { get; set; }
        public virtual Nullable<int> SourceCostGrp { get; set; }
        public virtual Nullable<decimal> AddDiscounts { get; set; }
        public virtual Nullable<decimal> TotalDiscounts { get; set; }
        public virtual Nullable<decimal> TotalDiscounted { get; set; }
        public virtual Nullable<decimal> AddExpenses { get; set; }
        public virtual Nullable<decimal> TotalExpenses { get; set; }
        public virtual Nullable<decimal> TotalPromotions { get; set; }
        public virtual Nullable<decimal> TotalVat { get; set; }
        public virtual Nullable<decimal> TotalGross { get; set; }
        public virtual Nullable<decimal> TotalNet { get; set; }
        public virtual Nullable<decimal> RcRate { get; set; }
        public virtual Nullable<decimal> RcNet { get; set; }
        public virtual Nullable<int> Paydefref { get; set; }
        public virtual Nullable<int> PrintCounter { get; set; }
        public virtual Nullable<int> OrderStatus { get; set; }
        public virtual string SalesmanCode { get; set; }
        public virtual string ShipmentType { get; set; }
        public virtual string ShippingAgent { get; set; }
        public virtual Nullable<int> CurrselTotals { get; set; }
        public virtual Nullable<int> CurrselDetails { get; set; }
        public virtual string CustOrdNo { get; set; }
        public virtual Nullable<short> DlvClient { get; set; }
        public virtual string DocTrackingNr { get; set; }
        public virtual Nullable<int> OfferReference { get; set; }
        public virtual Nullable<int> OffaltReference { get; set; }
        public virtual Nullable<int> OfferTyp { get; set; }
        public virtual Nullable<int> OfferAltnr { get; set; }
        public virtual Nullable<short> CurrTranactin { get; set; }
        public virtual Nullable<short> Einvoice { get; set; }
        public virtual Nullable<short> EinvoiceProfileId { get; set; }
        public virtual Nullable<short> EarchivedetrSendmod { get; set; }
        public virtual Nullable<short> EarchivedetrIntpaymenttype { get; set; }
        public virtual Nullable<short> EarchivedetrInsteadofdesp { get; set; }
        public virtual Nullable<DateTime> EarchivedetrIntpaymentdate { get; set; }
        public virtual Nullable<decimal> TcRate { get; set; }
        public virtual Nullable<short> WithPayment { get; set; }
        public virtual Nullable<int> Wflowcardref { get; set; }
        public virtual Nullable<int> OpStatus { get; set; }
        public virtual Nullable<short> UpdCurr { get; set; }
        public virtual Nullable<short> UpdTrcurr { get; set; }
        public virtual Nullable<short> AffectCollatrl { get; set; }
        public virtual Nullable<decimal> TotalAddTax { get; set; }
        public virtual Nullable<decimal> TotalExAddTax { get; set; }
        public virtual Nullable<short> AffectRisk { get; set; }
        public virtual Nullable<int> PaymentType { get; set; }
        public virtual string FcStatusName { get; set; }
        public virtual Nullable<int> DeductionPart1 { get; set; }
        public virtual Nullable<int> DeductionPart2 { get; set; }
        public virtual string CampaignCode { get; set; }
        public virtual string Itext { get; set; }

        #region Implementation
        public virtual string AuthCode { get; set; }
        public virtual string AuxilCode { get; set; }
        public virtual string Notes1 { get; set; }
        public virtual string Notes2 { get; set; }
        public virtual string Notes3 { get; set; }
        public virtual string Notes4 { get; set; }
        public virtual string PaymentCode { get; set; }
        public virtual Nullable<short> Division { get; set; }
        public virtual Nullable<short> Department { get; set; }
        public virtual string TradingGrp { get; set; }
        public virtual Nullable<int> DataSiteId { get; set; }
        public virtual Nullable<short> Factory { get; set; }
        public virtual Nullable<short> Cancelled { get; set; }
        public virtual string ProjectCode { get; set; }
        public virtual Nullable<short> Approve { get; set; }
        public virtual Nullable<DateTime> ApproveDate { get; set; }
        public virtual string GlobalId { get; set; }
        #endregion

        #region SubClasses
        public virtual List<Transaction> Transactions { get; set; }
        public virtual List<Payment> PaymentList { get; set; }
        public virtual List<DefnFld> DefnFldsList { get; set; }
        public virtual List<DemandPegging> DemandPeggings { get; set; }
        #endregion

        public override LogoObjectType GetRootElementName()
        {
            switch (IsSales)
            {
                case false:
                default:
                    return LogoObjectType.PURCHASE_ORDERS;

                case true:
                    return LogoObjectType.SALES_ORDERS;
            }
        }
    }
}
