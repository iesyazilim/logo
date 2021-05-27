using System;
using System.Collections.Generic;
using Ies.Logo.DataType.AggregateRoot;
using Ies.Logo.DataType.DefinitionFields;
using Ies.Logo.DataType.DemandPeggings;
using Ies.Logo.DataType.Infrastructure;

namespace Ies.Logo.DataType.MaterialSlips
{
    [Serializable]
    public class Slip : AuditedAggregateRoot, ISpecialCode, ICancelled, ITradingGroup, IDataSiteId, IProjectCode, IApprove, IGlobalId
    {
        public static string XmlRoot => "MATERIAL_SLIPS";

        public virtual Nullable<int> Group { get; set; }
        public virtual Nullable<int> Type { get; set; }
        public virtual string Number { get; set; }
        public virtual string DocTrackNr { get; set; }
        public virtual Nullable<DateTime> Date { get; set; }
        public virtual Nullable<int> Time { get; set; }
        public virtual string DocNumber { get; set; }
        public virtual Nullable<short> SourceType { get; set; }
        public virtual Nullable<int> SourceWh { get; set; }
        public virtual string SourceWscode { get; set; }
        public virtual string SpoDetailCode { get; set; }
        public virtual Nullable<int> SrcpolnReference { get; set; }
        public virtual Nullable<int> SourceCostGrp { get; set; }
        public virtual Nullable<short> DestType { get; set; }
        public virtual Nullable<int> DestWh { get; set; }
        public virtual string DestWscode { get; set; }
        public virtual string DpoDetailCode { get; set; }
        public virtual Nullable<int> DestpolnReference { get; set; }
        public virtual Nullable<int> DestCostGrp { get; set; }
        public virtual Nullable<int> SourceFactoryNr { get; set; }
        public virtual Nullable<int> SourceDivisionNr { get; set; }
        public virtual Nullable<int> SourceDepartmentNr { get; set; }
        public virtual Nullable<int> DestDivisionNr { get; set; }
        public virtual Nullable<int> DestDepartmentNr { get; set; }
        public virtual Nullable<int> DestFactory { get; set; }
        public virtual Nullable<int> PorderStatus { get; set; }
        public virtual Nullable<short> FyTransfer { get; set; }
        public virtual Nullable<short> GlStatus { get; set; }
        public virtual Nullable<short> XrateStatus { get; set; }
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
        public virtual string Footnote1 { get; set; }
        public virtual string Footnote2 { get; set; }
        public virtual string Footnote3 { get; set; }
        public virtual string Footnote4 { get; set; }
        public virtual Nullable<decimal> RcRate { get; set; }
        public virtual Nullable<decimal> RcNet { get; set; }
        public virtual Nullable<int> PrintCounter { get; set; }
        public virtual Nullable<int> Accficheref { get; set; }
        public virtual Nullable<short> GlCancelled { get; set; }
        public virtual string ShipmentType { get; set; }
        public virtual string ShippingAgent { get; set; }
        public virtual string TrackNr { get; set; }
        public virtual Nullable<int> CurrselTotals { get; set; }
        public virtual Nullable<int> CurrselDetails { get; set; }
        public virtual Nullable<short> Textinc { get; set; }
        public virtual Nullable<short> AddTaxCalc { get; set; }
        public virtual Nullable<decimal> TotalAddTax { get; set; }
        public virtual string UDocTrackingNr { get; set; }
        public virtual string VaAcccode { get; set; }
        public virtual string VaCentercode { get; set; }
        public virtual Nullable<short> FromExim { get; set; }
        public virtual string FrgTypCode { get; set; }
        public virtual Nullable<decimal> Totalexaddtax { get; set; }
        public virtual Nullable<short> AffectCollatrl { get; set; }
        public virtual Nullable<int> Qprodfcref { get; set; }
        public virtual Nullable<short> Grpfirmtrans { get; set; }
        public virtual Nullable<int> ExchinfoInternalReference { get; set; }
        public virtual Nullable<int> ExchinfoFicheRef { get; set; }
        public virtual Nullable<decimal> ExchinfoAddDiscounts { get; set; }
        public virtual Nullable<decimal> ExchinfoTotalDiscount { get; set; }
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
        public virtual Nullable<decimal> ExchinfoKomKdv { get; set; }
        public virtual Nullable<decimal> ExchinfoEk1 { get; set; }
        public virtual Nullable<decimal> ExchinfoEk2 { get; set; }
        public virtual Nullable<decimal> ExchinfoEk3 { get; set; }
        public virtual Nullable<decimal> ExchinfoEk4 { get; set; }
        public virtual Nullable<decimal> ExchinfoEk5 { get; set; }
        public virtual Nullable<int> AccFicheSiteid { get; set; }
        public virtual Nullable<DateTime> ShipDate { get; set; }
        public virtual Nullable<int> ShipTime { get; set; }
        public virtual Nullable<short> AutofillSlDetails { get; set; }
        public virtual Nullable<int> Reltransfcref { get; set; }
        public virtual Nullable<short> Fromtransfer { get; set; }
        public virtual Nullable<int> Status { get; set; }
        public virtual Nullable<short> LocControlOff { get; set; }
        public virtual Nullable<short> CancelAutoGlProc { get; set; }
        public virtual Nullable<DateTime> EbookDocdate { get; set; }
        public virtual Nullable<short> EbookNodocument { get; set; }
        public virtual string EbookDocnr { get; set; }
        public virtual Nullable<int> EbookDoctype { get; set; }
        public virtual string EbookExplain { get; set; }
        public virtual string EbookPaytype { get; set; }
        public virtual Nullable<short> EbookNopay { get; set; }

        #region Implementation
        public virtual string AuthCode { get; set; }
        public virtual string AuxilCode { get; set; }
        public virtual Nullable<short> Cancelled { get; set; }
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
        public virtual List<DemandPegging> DemandPeggings { get; set; }
        #endregion
    }
}
