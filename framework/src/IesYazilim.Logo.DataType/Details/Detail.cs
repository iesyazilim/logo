using System;
using System.Collections.Generic;
using IesYazilim.Logo.DataType.Infrastructure;
using IesYazilim.Logo.DataType.SlDetails;

namespace IesYazilim.Logo.DataType.Details
{
    [Serializable]
    public class Detail : ILogo, IGlCodes, IOhpCodes, IAuxilCode, IConvFacts, ICancelled, IDataSiteId, IDataReference, IGlobalId
    {
        public virtual string ItemCode { get; set; }
        public virtual Nullable<short> LineType { get; set; }
        public virtual Nullable<short> Detline { get; set; }
        public virtual Nullable<short> DetailLevel { get; set; }
        public virtual Nullable<short> DiscexpCalc { get; set; }
        public virtual Nullable<int> LineNumber { get; set; }
        public virtual Nullable<int> OrderReference { get; set; }
        public virtual Nullable<int> OrderSite { get; set; }
        public virtual string DelvryCode { get; set; }
        public virtual Nullable<decimal> Quantity { get; set; }
        public virtual Nullable<decimal> Price { get; set; }
        public virtual Nullable<decimal> Total { get; set; }
        public virtual Nullable<decimal> NetTotal { get; set; }
        public virtual Nullable<short> CurrPrice { get; set; }
        public virtual Nullable<decimal> PcPrice { get; set; }
        public virtual Nullable<short> CurrTrans { get; set; }
        public virtual Nullable<decimal> TcXrate { get; set; }
        public virtual Nullable<decimal> RcXrate { get; set; }
        public virtual Nullable<decimal> TcostDistr { get; set; }
        public virtual Nullable<decimal> DiscountDistr { get; set; }
        public virtual Nullable<decimal> ExpenseDistr { get; set; }
        public virtual Nullable<decimal> PromotionDistr { get; set; }
        public virtual Nullable<decimal> DiscountPerc { get; set; }
        public virtual string Description { get; set; }
        public virtual Nullable<short> VatIncluded { get; set; }
        public virtual Nullable<decimal> VatPerc { get; set; }
        public virtual Nullable<decimal> VatAmnt { get; set; }
        public virtual Nullable<decimal> VatBase { get; set; }
        public virtual Nullable<short> Composite { get; set; }
        public virtual Nullable<short> RetCostType { get; set; }
        public virtual Nullable<short> RetCost { get; set; }
        public virtual Nullable<short> CurrRetCost { get; set; }
        public virtual Nullable<short> OutCost { get; set; }
        public virtual Nullable<short> CurrOutCost { get; set; }
        public virtual Nullable<int> SourceReference { get; set; }
        public virtual string FaregCode { get; set; }
        public virtual Nullable<short> FaStatus { get; set; }
        public virtual Nullable<decimal> PriceAdjustment { get; set; }
        public virtual Nullable<decimal> CostAdjustmentPr { get; set; }
        public virtual Nullable<decimal> NegprcAdjustment { get; set; }
        public virtual Nullable<decimal> RcPrjadjust { get; set; }
        public virtual Nullable<decimal> RcCostadjust { get; set; }
        public virtual string OutputIdcode { get; set; }
        public virtual Nullable<decimal> CostRate { get; set; }
        public virtual Nullable<short> QcStatus { get; set; }
        public virtual Nullable<decimal> VendComm { get; set; }
        public virtual Nullable<decimal> PrevOutCost { get; set; }
        public virtual string CostOfSaleGlCode { get; set; }
        public virtual string PurchGlCode { get; set; }
        public virtual string CostOfSaleOhpCode { get; set; }
        public virtual string PurchOhpCode { get; set; }
        public virtual Nullable<decimal> PrevOutCostCurr { get; set; }
        public virtual Nullable<decimal> EuVatAmount { get; set; }
        public virtual Nullable<int> EuVatStatus { get; set; }
        public virtual Nullable<decimal> PrRate { get; set; }
        public virtual Nullable<decimal> AddTaxRate { get; set; }
        public virtual Nullable<decimal> AddTaxConvFact { get; set; }
        public virtual Nullable<decimal> AddTaxAmount { get; set; }
        public virtual Nullable<decimal> AddTaxPrCost { get; set; }
        public virtual Nullable<decimal> AddTaxRetCost { get; set; }
        public virtual Nullable<decimal> AddTaxRetCostCurr { get; set; }
        public virtual Nullable<decimal> GrossuInfo1 { get; set; }
        public virtual Nullable<decimal> GrossuInfo2 { get; set; }
        public virtual Nullable<decimal> AddTaxPrCostCurr { get; set; }
        public virtual Nullable<int> AddTaxAccRef { get; set; }
        public virtual Nullable<int> AddTaxCenterRef { get; set; }
        public virtual Nullable<short> AddTaxAmntIsUpd { get; set; }
        public virtual Nullable<int> PlnSttransPerNr { get; set; }
        public virtual Nullable<decimal> PordClsPlnAmnt { get; set; }
        public virtual Nullable<int> PlnSttransReference{ get; set; }
        public virtual Nullable<int> PlnAmount { get; set; }
        public virtual Nullable<decimal> InflationIdx { get; set; }
        public virtual Nullable<decimal> PrdordTotCoeff { get; set; }
        public virtual Nullable<decimal> DempeggedAmnt { get; set; }
        public virtual Nullable<decimal> StdUnitCost { get; set; }
        public virtual Nullable<decimal> StdrpUnitCost { get; set; }
        public virtual Nullable<decimal> Infldx { get; set; }
        public virtual string CostdiffAccCode { get; set; }
        public virtual string CostdiffCenCode { get; set; }
        public virtual Nullable<decimal> AddtaxDiscAmnt { get; set; }
        public virtual string OrgLogoId { get; set; }
        public virtual string EximFicheNo { get; set; }
        public virtual Nullable<int> EximFileLineNr { get; set; }
        public virtual Nullable<int> Month { get; set; }
        public virtual Nullable<int> Year { get; set; }
        public virtual Nullable<short> Pordsymountln { get; set; }
        public virtual Nullable<decimal> Exaddtaxrate { get; set; }
        public virtual Nullable<decimal> Exaddtaxconvf { get; set; }
        public virtual string ExAddTaxaCode { get; set; }
        public virtual string ExAddTaxCcode { get; set; }
        public virtual string OthrAddTaxaCode { get; set; }
        public virtual string OthrAddTaxCcode { get; set; }
        public virtual Nullable<decimal> ExAddTaxAmnt { get; set; }
        public virtual Nullable<short> AffectCollatrl { get; set; }
        public virtual Nullable<decimal> EdtPrice { get; set; }
        public virtual Nullable<short> EdtCurr { get; set; }
        public virtual Nullable<short> AddTaxEffectKdv { get; set; }
        public virtual Nullable<short> AffectRisk { get; set; }
        public virtual Nullable<decimal> ExclinePrice { get; set; }
        public virtual Nullable<decimal> ExclineTotal { get; set; }
        public virtual Nullable<decimal> ExclineDistCost { get; set; }
        public virtual Nullable<decimal> ExclineDistDisc { get; set; }
        public virtual Nullable<decimal> ExclineDistExp { get; set; }
        public virtual Nullable<decimal> ExclineDistProm { get; set; }
        public virtual Nullable<decimal> ExclineVatAmount { get; set; }
        public virtual Nullable<decimal> ExclineVatMatrah { get; set; }
        public virtual Nullable<decimal> ExclineLineNet { get; set; }
        public virtual Nullable<decimal> ExclineDistAddExp { get; set; }
        public virtual Nullable<decimal> ExclineNetDiscAmount    { get; set; }
        public virtual Nullable<decimal> ExclineVatCalcDiff { get; set; }
        public virtual Nullable<decimal> ExclineEuVatAmount { get; set; }
        public virtual Nullable<decimal> ExclineAddTaxAmount { get; set; }
        public virtual Nullable<decimal> ExclineAddTaxConvFact { get; set; }
        public virtual Nullable<decimal> ExclineAddTaxDiscAmount { get; set; }
        public virtual Nullable<decimal> ExclineExAddTaxAmount { get; set; }
        public virtual Nullable<decimal> ExclineExAddTaxConvf { get; set; }
        public virtual Nullable<decimal> AddTaxVatMatrah { get; set; }
        public virtual Nullable<decimal> ExclineAddTaxVatMatrah { get; set; }
        public virtual string AddTaxGlobalCode { get; set; }
        public virtual string UnitGlobalCode { get; set; }
        public virtual string PayplGlobalCode { get; set; }
        public virtual string PrcurrGlobalCode { get; set; }
        public virtual string TrcurrGlobalCode { get; set; }
        public virtual string EdtcurrGlobalCode { get; set; }
        public virtual string Prclistcode { get; set; }
        public virtual Nullable<int> Prclisttype { get; set; }
        public virtual string AddTaxExceptReason { get; set; }
        public virtual string AddTaxExceptCode { get; set; }
        public virtual string GlobalId { get; set; }
        public virtual Nullable<int> DeducationPart1 { get; set; }
        public virtual Nullable<int> DeducationPart2 { get; set; }
        public virtual string Guid { get; set; }

        #region Implementation
        public virtual string GlCode1 { get; set; }
        public virtual string GlCode2 { get; set; }
        public virtual string GlCode3 { get; set; }
        public virtual string GlCode4 { get; set; }
        public virtual string GlCode5 { get; set; }
        public virtual string OhpCode1 { get; set; }
        public virtual string OhpCode2 { get; set; }
        public virtual string OhpCode3 { get; set; }
        public virtual string OhpCode4 { get; set; }
        public virtual string OhpCode5 { get; set; }
        public virtual string AuxilCode { get; set; }
        public virtual string UnitCode { get; set; }
        public virtual Nullable<decimal> UnitConv1 { get; set; }
        public virtual Nullable<decimal> UnitConv2 { get; set; }
        public virtual Nullable<decimal> UnitConv3 { get; set; }
        public virtual Nullable<decimal> UnitConv4 { get; set; }
        public virtual Nullable<decimal> UnitConv5 { get; set; }
        public virtual Nullable<decimal> UnitConv6 { get; set; }
        public virtual Nullable<decimal> UnitConv7 { get; set; }
        public virtual Nullable<decimal> UnitConv8 { get; set; }
        public virtual Nullable<short> Cancelled { get; set; }
        public virtual Nullable<int> DataSiteId { get; set; }
        public virtual Nullable<int> DataReference { get; set; }
        #endregion

        #region SubClasses
        public virtual List<SerialLotTrn> SlDetails { get; set; }
        #endregion
    }
}
