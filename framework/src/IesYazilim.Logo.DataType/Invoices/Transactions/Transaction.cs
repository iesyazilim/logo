using System;
using System.Collections.Generic;
using IesYazilim.Logo.DataType.CampaingInfos;
using IesYazilim.Logo.DataType.DefinitionFields;
using IesYazilim.Logo.DataType.Details;
using IesYazilim.Logo.DataType.Infrastructure;
using IesYazilim.Logo.DataType.QcList;
using IesYazilim.Logo.DataType.SlDetails;

namespace IesYazilim.Logo.DataType.Invoices
{
    [Serializable]
    public class Transaction : ILogo, ISourceIndex, IOhpCodes, IGlCodes, IPaymentCode, IAuxilCode, IConvFacts, ICancelled, IDataSiteId, IDataReference, IFactory, IProjectCode, IGlobalId
    {
        public virtual Nullable<short> Type { get; set; }
        public virtual string MasterCode { get; set; }
        public virtual string MasterDef { get; set; }
        public virtual Nullable<short> DetailLevel { get; set; }
        public virtual Nullable<short> DiscExpCalc { get; set; }
        public virtual Nullable<int> SourceCostGrp { get; set; }
        public virtual Nullable<int> OrderReference { get; set; }
        public virtual Nullable<int> OrderSite { get; set; }
        public virtual string PromotionCode { get; set; }
        public virtual string DelvryCode { get; set; }
        public virtual Nullable<decimal> Quantity { get; set; }
        public virtual Nullable<decimal> Price { get; set; }
        public virtual Nullable<decimal> Total { get; set; }
        public virtual Nullable<short> CurrPrice { get; set; }
        public virtual Nullable<decimal> PcPrice { get; set; }
        public virtual Nullable<short> CurrTransaction { get; set; }
        public virtual Nullable<decimal> TcXrate { get; set; }
        public virtual Nullable<decimal> RcXrate { get; set; }
        public virtual Nullable<decimal> CostDistr { get; set; }
        public virtual string DiscountDistr { get; set; }
        public virtual Nullable<decimal> ExpenseDistr { get; set; }
        public virtual Nullable<decimal> PromotionDistr { get; set; }
        public virtual Nullable<decimal> DiscountRate { get; set; }
        public virtual Nullable<decimal> BaseAmount { get; set; }
        public virtual string Description { get; set; }
        public virtual Nullable<decimal> UnitConv9 { get; set; }
        public virtual Nullable<short> VatIncluded { get; set; }
        public virtual Nullable<decimal> VatRate { get; set; }
        public virtual Nullable<decimal> VatAmount { get; set; }
        public virtual Nullable<decimal> VatBase { get; set; }
        public virtual Nullable<decimal> VatAdjustment { get; set; }
        public virtual Nullable<short> Billed { get; set; }
        public virtual Nullable<short> Composite { get; set; }
        public virtual Nullable<short> RetCostType { get; set; }
        public virtual Nullable<decimal> RetCost { get; set; }
        public virtual Nullable<decimal> TcRetCost { get; set; }
        public virtual Nullable<decimal> OutCost { get; set; }
        public virtual Nullable<decimal> TcOutCost { get; set; }
        public virtual Nullable<int> SourceSite { get; set; }
        public virtual Nullable<int> SourceReference { get; set; }
        public virtual string FixastCode { get; set; }
        public virtual Nullable<short> FixastStatus { get; set; }
        public virtual Nullable<decimal> TotalNet { get; set; }
        public virtual Nullable<decimal> PriceUpdCost { get; set; }
        public virtual Nullable<short> PriceUpdNeg { get; set; }
        public virtual Nullable<decimal> ProdExpnDistr { get; set; }
        public virtual Nullable<decimal> RcPriceUpd { get; set; }
        public virtual Nullable<decimal> RcPriceUpdCost { get; set; }
        public virtual string OutputCode { get; set; }
        public virtual Nullable<decimal> CostRate { get; set; }
        public virtual Nullable<short> QcOk { get; set; }
        public virtual Nullable<short> NetDscFlag { get; set; }
        public virtual Nullable<decimal> NetDscRate { get; set; }
        public virtual Nullable<decimal> NetDscAmount { get; set; }
        public virtual string DispatchNumber { get; set; }
        public virtual Nullable<int> DistOrdSiteId { get; set; }
        public virtual Nullable<int> DistOrdReference { get; set; }
        public virtual Nullable<decimal> CampaingPoint { get; set; }
        public virtual string PromClasItemCode { get; set; }
        public virtual Nullable<decimal> VendComm { get; set; }
        public virtual Nullable<decimal> PrevOutCost { get; set; }
        public virtual string CostOfSaleGlCode{ get; set; }
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
        public virtual Nullable<short> AddTaxAmntIsUpd { get; set; }
        public virtual Nullable<int> PlnSttransPerNr { get; set; }
        public virtual Nullable<decimal> PordClsPlnAmnt { get; set; }
        public virtual Nullable<int> PlnSttransReference { get; set; }
        public virtual Nullable<decimal> PlnAmount { get; set; }
        public virtual Nullable<decimal> InflationIdx { get; set; }
        public virtual Nullable<short> EdtCurr { get; set; }
        public virtual Nullable<decimal> EdtPrice { get; set; }
        public virtual Nullable<decimal> PrdordTotCoef { get; set; }
        public virtual Nullable<decimal> DempeggedAmnt { get; set; }
        public virtual Nullable<decimal> StdunitCost { get; set; }
        public virtual Nullable<decimal> StdrpunitCost { get; set; }
        public virtual Nullable<decimal> Infldx { get; set; }
        public virtual string CostdiffAccCode { get; set; }
        public virtual string CostdiffCenCode { get; set; }
        public virtual Nullable<decimal> AddTaxDiscAmnt { get; set; }
        public virtual string OrgLogoId { get; set; }
        public virtual string EximFicheNo { get; set; }
        public virtual string SalesmanCode { get; set; }
        public virtual Nullable<int> EximFicheType { get; set; }
        public virtual Nullable<short> TransExpLine { get; set; }
        public virtual Nullable<short> InsExpLine { get; set; }
        public virtual Nullable<int> EximProcNo { get; set; }
        public virtual string EximFileCode { get; set; }
        public virtual Nullable<int> EximFileLineNr { get; set; }
        public virtual string EximWhFicheNo { get; set; }
        public virtual Nullable<int> EximWhFicheLnno { get; set; }
        public virtual string DiibCode { get; set; }
        public virtual Nullable<int> Month { get; set; }
        public virtual Nullable<int> Year { get; set; }
        public virtual Nullable<short> Pordsymoutln { get; set; }
        public virtual Nullable<decimal> ExAddTaxRate { get; set; }
        public virtual Nullable<decimal> ExAddTaxConvf { get; set; }
        public virtual string ExAddTaxaCode { get; set; }
        public virtual string ExAddTaxcCode { get; set; }
        public virtual string OthrAddTaxaCode { get; set; }
        public virtual string OthrAddTaxcCode { get; set; }
        public virtual Nullable<decimal> ExAddTaxAmnt { get; set; }
        public virtual Nullable<short> AffectCollatrl { get; set; }
        public virtual Nullable<short> FromOrdWithPay { get; set; }
        public virtual string VariantCode { get; set; }
        public virtual string VariantName { get; set; }
        public virtual Nullable<short> CanConfig { get; set; }
        public virtual Nullable<short> AddTaxEffectKdv { get; set; }
        public virtual Nullable<short> AffectRisk { get; set; }
        public virtual Nullable<decimal> AddTaxVatMatrah { get; set; }
        public virtual Nullable<decimal> ExchlineAddTaxVatMatrah { get; set; }
        public virtual string AddTaxCode { get; set; }
        public virtual string AddTaxGlobalCode { get; set; }
        public virtual string UnitGlobalCode { get; set; }
        public virtual string PayplGlobalCode { get; set; }
        public virtual string PrcurrGlobalCode { get; set; }
        public virtual string TrcurrGlobalCode { get; set; }
        public virtual string EdtcurrGlobalCode { get; set; }
        public virtual Nullable<short> CanDeduct { get; set; }
        public virtual Nullable<int> MainMtReference { get; set; }
        public virtual Nullable<int> MainMtSiteId { get; set; }
        public virtual string PrclistCode { get; set; }
        public virtual Nullable<int> PrclistType { get; set; }
        public virtual string FaplGlCode { get; set; }
        public virtual string FaplOhpCode { get; set; }
        public virtual string Guid { get; set; }
        public virtual string FadGlCode { get; set; }
        public virtual string AuxilCode2 { get; set; }
        public virtual string VatExceptReason { get; set; }
        public virtual string VatExceptCode { get; set; }
        public virtual string AddTaxExceptReason { get; set; }
        public virtual string AddTaxExceptCode { get; set; }
        public virtual string DeductCode { get; set; }
        public virtual string DeductDef { get; set; }
        public virtual Nullable<int> DeductionPart1 { get; set; }
        public virtual Nullable<int> DeductionPart2 { get; set; }
        public virtual Nullable<decimal> DeductionTot { get; set; }
        public virtual Nullable<decimal> DeductionTotTc { get; set; }
        public virtual string Barcode { get; set; }

        #region Implementation
        public virtual Nullable<short> SourceIndex { get; set; }
        public virtual Nullable<short> Factory { get; set; }
        public virtual string OhpCode1 { get; set; }
        public virtual string OhpCode2 { get; set; }
        public virtual string OhpCode3 { get; set; }
        public virtual string OhpCode4 { get; set; }
        public virtual string OhpCode5 { get; set; }
        public virtual string GlCode1 { get; set; }
        public virtual string GlCode2 { get; set; }
        public virtual string GlCode3 { get; set; }
        public virtual string GlCode4 { get; set; }
        public virtual string GlCode5 { get; set; }
        public virtual string PaymentCode { get; set; }
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
        public virtual string ProjectCode { get; set; }
        public virtual string GlobalId { get; set; }

        #endregion

        #region SubClasses
        public virtual List<FixedAstRgs> FaInfo { get; set; }
        public virtual List<SerialLotTrn> SlDetails { get; set; }
        public virtual List<Detail> Details { get; set; }
        public virtual List<QccValueEntry> QcList { get; set; }
        public virtual List<CampaingInfo> CampaingInfos { get; set; }
        public virtual List<DefnFld> GeniusFldsList { get; set; }
        public virtual List<DefnFld> DefnFldsList { get; set; }
        public virtual List<DefnFld> FaregDefnFldList { get; set; }
        public virtual List<PreAccLn> PreAccLines { get; set; }

        #endregion
    }
}
