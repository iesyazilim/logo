using System;
using System.Collections.Generic;
using Ies.Logo.DataType.DefinitionFields;
using Ies.Logo.DataType.Details;
using Ies.Logo.DataType.Infrastructure;
using Ies.Logo.DataType.SlDetails;

namespace Ies.Logo.DataType.MaterialSlips
{
    [Serializable]
    public class Transaction : ILogo, ISourceIndex, IGlCodes, IOhpCodes, IAuxilCode, ICancelled, IDataSiteId, IDataReference, IProjectCode, IGlobalId
    {
        public virtual string ItemCode { get; set; }
        public virtual Nullable<short> LineType { get; set; }
        public virtual Nullable<short> DetailLevel { get; set; }
        public virtual Nullable<short> DiscexpCalc { get; set; }
        public virtual Nullable<int> PrordSite { get; set; }
        public virtual Nullable<int> PrordReference { get; set; }
        public virtual Nullable<int> Sourcecostgrp { get; set; }
        public virtual Nullable<int> Destindex { get; set; }
        public virtual Nullable<int> Destcostgrp { get; set; }
        public virtual Nullable<int> Factorynr { get; set; }
        public virtual Nullable<int> LineNumber { get; set; }
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
        public virtual string UnitCode { get; set; }
        public virtual Nullable<decimal> UnitConv1 { get; set; }
        public virtual Nullable<decimal> UnitConv2 { get; set; }
        public virtual Nullable<decimal> UnitConv3 { get; set; }
        public virtual Nullable<decimal> UnitConv4 { get; set; }
        public virtual Nullable<decimal> UnitConv5 { get; set; }
        public virtual Nullable<decimal> UnitConv6 { get; set; }
        public virtual Nullable<decimal> UnitConv7 { get; set; }
        public virtual Nullable<decimal> UnitConv8 { get; set; }
        public virtual Nullable<short> VatIncluded { get; set; }
        public virtual Nullable<decimal> VatPerc { get; set; }
        public virtual Nullable<decimal> VatAmnt { get; set; }
        public virtual Nullable<decimal> VatBase { get; set; }
        public virtual Nullable<short> Composit { get; set; }
        public virtual Nullable<short> RetCostType { get; set; }
        public virtual Nullable<decimal> RetCost { get; set; }
        public virtual Nullable<decimal> CurrRetCost { get; set; }
        public virtual Nullable<decimal> OutCost { get; set; }
        public virtual Nullable<decimal> CurrOutCost { get; set; }
        public virtual Nullable<decimal> RetQuantity { get; set; }
        public virtual string FaregCode { get; set; }
        public virtual Nullable<short> FaStatus { get; set; }
        public virtual Nullable<decimal> CostAdjustmentPr { get; set; }
        public virtual Nullable<short> NegprcAdjustment { get; set; }
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
        public virtual Nullable<decimal> AddTaxPrcost { get; set; }
        public virtual Nullable<decimal> AddTaxRetcost { get; set; }
        public virtual Nullable<decimal> AddTaxRetcostcurr { get; set; }
        public virtual Nullable<decimal> GrossUInfo1 { get; set; }
        public virtual Nullable<decimal> GrossUInfo2 { get; set; }
        public virtual Nullable<decimal> AddTaxPrCostCurr { get; set; }
        public virtual Nullable<short> AddTaxAmntIsUpd { get; set; }
        public virtual Nullable<int> PlnSttransPerNr { get; set; }
        public virtual Nullable<decimal> PordClsPlnAmnt { get; set; }
        public virtual Nullable<int> PlnSttransReference { get; set; }
        public virtual Nullable<decimal> PlnAmount { get; set; }
        public virtual Nullable<decimal> InflationIdx { get; set; }
        public virtual Nullable<decimal> PrdordTotCoef { get; set; }
        public virtual Nullable<decimal> DempeggedAmnt { get; set; }
        public virtual Nullable<decimal> StdunitCost { get; set; }
        public virtual Nullable<decimal> StdrpunitCost { get; set; }
        public virtual Nullable<decimal> Infldx { get; set; }
        public virtual string CostdiffAcccode { get; set; }
        public virtual string CostdiffCencode { get; set; }
        public virtual Nullable<decimal> AddtaxdiscAmnt { get; set; }
        public virtual string OrgLogoId { get; set; }
        public virtual string EximFicheno { get; set; }
        public virtual Nullable<int> EximFilelinenr { get; set; }
        public virtual Nullable<int> Orglinkref { get; set; }
        public virtual Nullable<short> Pordsymoutln { get; set; }
        public virtual Nullable<decimal> Exaddtaxrate { get; set; }
        public virtual Nullable<decimal> Exaddtaxconvf { get; set; }
        public virtual string Exaddtaxacode { get; set; }
        public virtual string Exaddtaxccode { get; set; }
        public virtual string Othraddtaxacode { get; set; }
        public virtual string Othraddtaxccode { get; set; }
        public virtual Nullable<decimal> Exaddtaxamnt { get; set; }
        public virtual Nullable<short> AffectCollatrl { get; set; }
        public virtual string Variantcode { get; set; }
        public virtual string Variantname { get; set; }
        public virtual Nullable<short> Canconfig { get; set; }
        public virtual Nullable<decimal> EdtPrice { get; set; }
        public virtual Nullable<short> EdtCurr { get; set; }
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
        public virtual Nullable<decimal> ExclineNetDiscAmount { get; set; }
        public virtual Nullable<decimal> ExclineVatCalcDiff { get; set; }
        public virtual Nullable<decimal> ExclineEuVatAmount { get; set; }
        public virtual Nullable<decimal> ExclineAddTaxAmount { get; set; }
        public virtual Nullable<decimal> ExclineAddTaxConvFact { get; set; }
        public virtual Nullable<decimal> ExclineAddTaxDiscAmount { get; set; }
        public virtual Nullable<decimal> ExclineExAddTaxAmount { get; set; }
        public virtual Nullable<decimal> ExclineExAddTaxConvf { get; set; }
        public virtual Nullable<decimal> AddTaxVatMatrah{ get; set; }
        public virtual Nullable<decimal> ExclineAddTaxVatMatrah{ get; set; }
        public virtual Nullable<int> Reltranslnref{ get; set; }
        public virtual Nullable<short> Fromtransfer{ get; set; }
        public virtual Nullable<int> MainMtReference{ get; set; }
        public virtual Nullable<int> MainMtSiteid{ get; set; }
        public virtual string Prclistcode{ get; set; }
        public virtual Nullable<int> Prclisttype{ get; set; }
        public virtual string FaplGlCode{ get; set; }
        public virtual string FaplOhpCode{ get; set; }
        public virtual string AuxilCode2 { get; set; }

        #region Implementation
        public virtual Nullable<short> SourceIndex { get; set; }
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
        public virtual Nullable<short> Cancelled { get; set; }
        public virtual Nullable<int> DataSiteId { get; set; }
        public virtual Nullable<int> DataReference { get; set; }
        public virtual string ProjectCode { get; set; }
        public virtual string GlobalId { get; set; }
        #endregion

        #region SubClasses
        public virtual List<SerialLotTrn> SlDetails { get; set; }
        public virtual List<Detail> Details { get; set; }
        public virtual List<DefnFld> DefnFldsList { get; set; }
        #endregion
    }
}
