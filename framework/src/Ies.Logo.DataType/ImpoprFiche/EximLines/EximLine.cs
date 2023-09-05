using Ies.Logo.DataType.CampaingInfos;
using Ies.Logo.DataType.DefinitionFields;
using Ies.Logo.DataType.Details;
using Ies.Logo.DataType.Infrastructure;
using Ies.Logo.DataType.Invoices;
using Ies.Logo.DataType.QcList;
using Ies.Logo.DataType.SlDetails;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ies.Logo.DataType.ImpoprFiche.EximLines
{
    [Serializable]
    public class EximLine : ILogo, ISourceIndex, IOhpCodes, IGlCodes, IPaymentCode, IAuxilCode, IConvFacts, ICancelled, IDataSiteId, IDataReference, IFactory, IProjectCode, IGlobalId
    {
        public virtual Nullable<short> Type { get; set; }
        public virtual string MasterCode { get; set; }
        public virtual string MasterDef { get; set; }
        public virtual Nullable<short> DiscExpCalc { get; set; }
        public virtual Nullable<int> SourceCostGrp { get; set; }
        public virtual Nullable<int> OrderReference { get; set; }
        public virtual Nullable<int> OrderSite { get; set; }
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
        public virtual Nullable<short> VatIncluded { get; set; }
        public virtual Nullable<decimal> VatRate { get; set; }
        public virtual Nullable<decimal> VatAmount { get; set; }
        public virtual Nullable<decimal> VatBase { get; set; }
        public virtual Nullable<decimal> VatAdjustment { get; set; }
        public virtual Nullable<short> Billed { get; set; }
        public virtual Nullable<decimal> TotalNet { get; set; }
        public virtual string DispatchNumber { get; set; }
        public virtual Nullable<int> DistOrdSiteId { get; set; }
        public virtual Nullable<int> DistOrdReference { get; set; }
        public virtual string CostOfSaleGlCode { get; set; }
        public virtual string PurchGlCode { get; set; }
        public virtual string CostOfSaleOhpCode { get; set; }
        public virtual string PurchOhpCode { get; set; }
        public virtual Nullable<decimal> PrRate { get; set; }
        public virtual Nullable<short> EdtCurr { get; set; }
        public virtual Nullable<decimal> EdtPrice { get; set; }
        public virtual Nullable<decimal> AddTaxDiscAmnt { get; set; }
        public virtual string OrgLogoId { get; set; }
        public virtual string SalesmanCode { get; set; }
        public virtual Nullable<short> TransExpLine { get; set; }
        public virtual Nullable<short> InsExpLine { get; set; }
        public virtual string DiibCode { get; set; }
        public virtual Nullable<int> Month { get; set; }
        public virtual Nullable<int> Year { get; set; }
        public virtual string VariantCode { get; set; }
        public virtual string VariantName { get; set; }
        public virtual Nullable<short> AffectRisk { get; set; }
        public virtual string AddTaxGlobalCode { get; set; }
        public virtual string UnitGlobalCode { get; set; }
        public virtual string PayplGlobalCode { get; set; }
        public virtual string PrcurrGlobalCode { get; set; }
        public virtual string TrcurrGlobalCode { get; set; }
        public virtual string EdtcurrGlobalCode { get; set; }
        public virtual Nullable<short> CanDeduct { get; set; }
        public virtual string Guid { get; set; }
        public virtual string AuxilCode2 { get; set; }
        public virtual string VatExceptReason { get; set; }
        public virtual string VatExceptCode { get; set; }
        public virtual string DeductCode { get; set; }
        public virtual string DeductDef { get; set; }
        public virtual Nullable<int> DeductionPart1 { get; set; }
        public virtual Nullable<int> DeductionPart2 { get; set; }
        public virtual Nullable<decimal> DeductionTot { get; set; }
        public virtual Nullable<decimal> DeductionTotTc { get; set; }
        public virtual string Barcode { get; set; }
        public virtual Nullable<int> MultAddTax { get; set; }
        public virtual Nullable<int> EximFicheType { get; set; }
        public virtual Nullable<int> EximProcNo { get; set; }
        public virtual string EximCustomDocNo { get; set; }
        public virtual Nullable<DateTime> EximCustomDocDate { get; set; }
        public virtual Nullable<int> EximCountryType { get; set; }
        public virtual string EximCountryCode { get; set; }

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
        public virtual Nullable<int> InternalReference { get; set; }
        public virtual string ProjectCode { get; set; }
        public virtual string GlobalId { get; set; }

        #endregion

        #region SubClasses
        public virtual List<Detail> Details { get; set; }
        public virtual List<CampaingInfo> CampaingInfos { get; set; }
        public virtual List<DefnFld> DefnFldsList { get; set; }
        #endregion
    }
}
