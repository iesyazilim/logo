using System;
using System.Collections.Generic;
using Ies.Logo.Core;
using Ies.Logo.DataType.AggregateRoot;
using Ies.Logo.DataType.DefinitionFields;
using Ies.Logo.DataType.GlLinks;
using Ies.Logo.DataType.Infrastructure;
using Ies.Logo.DataType.Units;
using Ies.Logo.DataType.WhParams;

namespace Ies.Logo.DataType.Items
{
    [Serializable]
    public class Item : AuditedAggregateRoot, IRecordStatus, IGroupCode, ISpecialCode, IPaymentCode, IProjectCode, IDetailedAuxilCode, IGlobalId, IDataNo
    {
        public static LogoObjectType XmlRoot => LogoObjectType.ITEMS;

        public virtual string Code { get; set; }
        public virtual string Name { get; set; }
        public virtual string Name2 { get; set; }
        public virtual string Name3 { get; set; }
        public virtual string Name4 { get; set; }
        public virtual ItemCardType CardType { get; set; }
        public virtual string ProducerCode { get; set; }
        public virtual Nullable<int> ClassType { get; set; }
        public virtual Nullable<int> UsefPurchasing { get; set; }
        public virtual Nullable<int> UsefSales { get; set; }
        public virtual Nullable<int> UsefMm { get; set; }
        public virtual Nullable<decimal> Vat { get; set; }
        public virtual Nullable<decimal> SelVat { get; set; }
        public virtual Nullable<decimal> ReturnVat { get; set; }
        public virtual Nullable<decimal> SelprVat { get; set; }
        public virtual Nullable<decimal> ReturnprVat { get; set; }
        public virtual Nullable<short> TrackType { get; set; }
        public virtual Nullable<short> LocationTracking { get; set; }
        public virtual Nullable<short> Tool { get; set; }
        public virtual Nullable<short> AutoIncsl { get; set; }
        public virtual Nullable<short> LotsDivisible { get; set; }
        public virtual Nullable<decimal> ShelfLife { get; set; }
        public virtual Nullable<int> ShelfDate { get; set; }
        public virtual Nullable<int> DeprecType { get; set; }
        public virtual Nullable<int> DeprecType2 { get; set; }
        public virtual Nullable<decimal> DeprecRate { get; set; }
        public virtual Nullable<decimal> DeprecRate2 { get; set; }
        public virtual Nullable<int> DeprecDuration { get; set; }
        public virtual Nullable<int> DeprecDuration2 { get; set; }
        public virtual Nullable<decimal> SalvageVal { get; set; }
        public virtual Nullable<decimal> SalvageValue { get; set; }
        public virtual Nullable<short> RevalFlag { get; set; }
        public virtual Nullable<short> RevalFlag2 { get; set; }
        public virtual Nullable<short> RevdeprecFlag { get; set; }
        public virtual Nullable<short> RevdeprecFlag2 { get; set; }
        public virtual Nullable<short> PartialDeprec { get; set; }
        public virtual Nullable<short> PartialDeprec2 { get; set; }
        public virtual Nullable<short> Approved { get; set; }
        public virtual string UnitsetCode { get; set; }
        public virtual string QccsetCode { get; set; }
        public virtual Nullable<decimal> DistributedAmount { get; set; }
        public virtual string UniversalId { get; set; }
        public virtual Nullable<short> DistLotUnits { get; set; }
        public virtual Nullable<short> CombLotUnits { get; set; }
        public virtual Nullable<decimal> DistPoint { get; set; }
        public virtual Nullable<short> CanUseInTrans { get; set; }
        public virtual string IsoNr { get; set; }
        public virtual string GroupNr { get; set; }
        public virtual string ProdCountry { get; set; }
        public virtual Nullable<int> ExtAccFlags { get; set; }
        public virtual string AddTaxCode { get; set; }
        public virtual Nullable<decimal> MultiAddTax { get; set; }
        public virtual Nullable<short> Packet { get; set; }
        public virtual Nullable<short> LidConfirmed { get; set; }
        public virtual string GtipCode { get; set; }
        public virtual string B2CCode { get; set; }
        public virtual string MarkCode { get; set; }
        public virtual Nullable<short> Img2Inc { get; set; }
        public virtual string ExpctGnr { get; set; }
        public virtual Nullable<int> ExtcrdFlags { get; set; }
        public virtual Nullable<decimal> MinOrdAmnt { get; set; }
        #region Freight
        public virtual string FreightPlace { get; set; }
        public virtual string FreightTypeCode1 { get; set; }
        public virtual string FreightTypeCode2 { get; set; }
        public virtual string FreightTypeCode3 { get; set; }
        public virtual string FreightTypeCode4 { get; set; }
        public virtual string FreightTypeCode5 { get; set; }
        public virtual string FreightTypeCode6 { get; set; }
        public virtual string FreightTypeCode7 { get; set; }
        public virtual string FreightTypeCode8 { get; set; }
        public virtual string FreightTypeCode9 { get; set; }
        public virtual string FreightTypeCode10 { get; set; }
        public virtual Nullable<int> FreightTypeDef1 { get; set; }
        public virtual Nullable<int> FreightTypeDef2 { get; set; }
        public virtual Nullable<int> FreightTypeDef3 { get; set; }
        public virtual Nullable<int> FreightTypeDef4 { get; set; }
        public virtual Nullable<int> FreightTypeDef5 { get; set; }
        public virtual Nullable<int> FreightTypeDef6 { get; set; }
        public virtual Nullable<int> FreightTypeDef7 { get; set; }
        public virtual Nullable<int> FreightTypeDef8 { get; set; }
        public virtual Nullable<int> FreightTypeDef9 { get; set; }
        public virtual Nullable<int> FreightTypeDef10 { get; set; }
        #endregion
        public virtual Nullable<decimal> QprodAmnt { get; set; }
        public virtual Nullable<int> QprodSourceIndex { get; set; }
        public virtual Nullable<decimal> LostFactor { get; set; }
        public virtual string ExpCategory { get; set; }
        public virtual string EanBarcode { get; set; }
        public virtual string DeprClassType { get; set; }
        public virtual Nullable<int> WflowCardRef { get; set; }
        public virtual Nullable<short> CodeChanged { get; set; }
        public virtual Nullable<decimal> AvrWhDuration { get; set; }
        public virtual Nullable<short> ImageInc { get; set; }
        public virtual Nullable<int> Image1Size { get; set; }
        public virtual Nullable<int> Image2Size { get; set; }
        public virtual Nullable<short> CanConfigure { get; set; }
        public virtual string Charset { get; set; }
        public virtual string CharsetName { get; set; }
        public virtual Nullable<int> VgenDataReference { get; set; }
        public virtual string ConsCode { get; set; }
        public virtual Nullable<short> UpdateChilds { get; set; }
        #region Deduction
        public virtual Nullable<short> CanDeduct { get; set; }
        public virtual Nullable<int> SaleDeductionPart1 { get; set; }
        public virtual Nullable<int> SaleDeductionPart2 { get; set; }
        public virtual Nullable<int> PurchDeductionPart1 { get; set; }
        public virtual Nullable<int> PurchDeductionPart2 { get; set; }
        #endregion
        public virtual Nullable<short> Expense { get; set; }
        public virtual Nullable<decimal> EximTax1 { get; set; }
        public virtual Nullable<decimal> EximTax2 { get; set; }
        public virtual Nullable<decimal> EximTax3 { get; set; }
        public virtual Nullable<decimal> EximTax4 { get; set; }
        public virtual Nullable<decimal> EximTax5 { get; set; }
        public virtual string ReyonCode { get; set; }
        public virtual Nullable<int> KdvDeptNr { get; set; }
        public virtual Nullable<int> Scales { get; set; }
        public virtual Nullable<int> ScaleNr { get; set; }
        public virtual string Origin { get; set; }
        public virtual Nullable<short> AppSpeVatMatrah { get; set; }
        public virtual Nullable<short> FltImage1 { get; set; }
        public virtual Nullable<short> FltImage2 { get; set; }
        public virtual string CategoryId { get; set; }
        public virtual string CategoryName { get; set; }
        #region Keyword
        public virtual string Keyword1 { get; set; }
        public virtual string Keyword2 { get; set; }
        public virtual string Keyword3 { get; set; }
        public virtual string Keyword4 { get; set; }
        public virtual string Keyword5 { get; set; }
        #endregion
        public virtual string SubsGoodCode { get; set; }

        #region Implementation
        public virtual Nullable<short> RecordStatus { get; set; }
        public virtual string GroupCode { get; set; }
        public virtual string AuthCode { get; set; }
        public virtual string AuxilCode { get; set; }
        public virtual string AuxilCode2 { get; set; }
        public virtual string AuxilCode3 { get; set; }
        public virtual string AuxilCode4 { get; set; }
        public virtual string AuxilCode5 { get; set; }
        public virtual string PaymentCode { get; set; }
        public virtual string ProjectCode { get; set; }
        public virtual string GlobalId { get; set; }
        public string DataNumber { get => Code; set => Code = value; }
        #endregion

        #region SubClasses
        public virtual List<FactoryParam> FactoryParams { get; set; }
        public virtual List<ItemWhParam> WhParams { get; set; }
        public virtual List<Characteristic> Characteristics { get; set; }
        public virtual List<Class> DominantClasses { get; set; }
        public virtual List<ItemUnit> Units { get; set; }
        public virtual List<Composite> Composites { get; set; }
        public virtual List<GlLink> GlLinks { get; set; }
        public virtual List<Supplier> Suppliers { get; set; }
        public virtual List<QProd> QProds { get; set; }
        public virtual List<DefnFld> GeniusFldsList { get; set; }
        public virtual List<DefnFld> DefnFldsList { get; set; }
        public virtual List<VrntException> VrntExceptions { get; set; }
        public virtual List<VrntCodeTemp> VrntCodeTemps { get; set; }
        public virtual List<VrntCodeTemp> VrntExcpTemps { get; set; }
        public virtual List<ItemSubstitute> Alternatives { get; set; }
        #endregion
    }
}
