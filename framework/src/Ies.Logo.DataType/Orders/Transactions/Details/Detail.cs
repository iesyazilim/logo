using System;
using Ies.Logo.DataType.Infrastructure;

namespace Ies.Logo.DataType.Orders
{
    [Serializable]
    public class Detail : ILogo, IAuxilCode, IPaymentCode, IDivision, IDepartment, IDataSiteId, IDataReference, IFactory, IGlobalId
    {
        public virtual Nullable<short> Type { get; set; }
        public virtual string MasterCode{ get; set; }
        public virtual Nullable<short> DetailLevel{ get; set; }
        public virtual Nullable<short> CalcType{ get; set; }
        public virtual string OhpCode1{ get; set; }
        public virtual string OhpCode2 { get; set; }
        public virtual string GlCode1 { get; set; }
        public virtual string GlCode2 { get; set; }
        public virtual string DelvryCode{ get; set; }
        public virtual Nullable<decimal> Quantity { get; set; }
        public virtual Nullable<decimal> Price { get; set; }
        public virtual Nullable<decimal> Total { get; set; }
        public virtual Nullable<decimal> QuantityShipped{ get; set; }
        public virtual Nullable<decimal> DiscountRate{ get; set; }
        public virtual Nullable<decimal> CostDistr{ get; set; }
        public virtual Nullable<decimal> DiscountDistr{ get; set; }
        public virtual Nullable<decimal> ExpenseDistr{ get; set; }
        public virtual Nullable<decimal> PromotionDistr { get; set; }
        public virtual Nullable<decimal> VatRate{ get; set; }
        public virtual Nullable<decimal> VatAmount{ get; set; }
        public virtual Nullable<decimal> VatBase{ get; set; }
        public virtual string TransDescription{ get; set; }
        public virtual string UnitCode { get; set; }
        public virtual Nullable<decimal> UnitConv1 { get; set; }
        public virtual Nullable<decimal> UnitConv2 { get; set; }
        public virtual Nullable<decimal> UnitConv3 { get; set; }
        public virtual Nullable<decimal> UnitConv4 { get; set; }
        public virtual Nullable<decimal> UnitConv5 { get; set; }
        public virtual Nullable<decimal> UnitConv6 { get; set; }
        public virtual Nullable<decimal> UnitConv7 { get; set; }
        public virtual Nullable<decimal> UnitConv8 { get; set; }
        public virtual Nullable<short> VatIncluded{ get; set; }
        public virtual Nullable<short> OrderClosed{ get; set; }
        public virtual Nullable<short> OrderReserve{ get; set; }
        public virtual Nullable<DateTime> DueDate{ get; set; }
        public virtual Nullable<short> CurrPrice{ get; set; }
        public virtual Nullable<decimal> PcPrice{ get; set; }
        public virtual Nullable<decimal> RcXrate{ get; set; }
        public virtual Nullable<short> Composite{ get; set; }
        public virtual Nullable<short> SourceWh { get; set; }
        public virtual Nullable<int> SourceCostGrp{ get; set; }
        public virtual Nullable<decimal> TotalNet{ get; set; }
        public virtual Nullable<short> Produced{ get; set; }
        public virtual Nullable<int> ReasonForNotShp{ get; set; }
        public virtual Nullable<decimal> DemPeggedAmnt { get; set; }
        public virtual Nullable<short> Textinc{ get; set; }
        public virtual Nullable<short> AffectCollatrl{ get; set; }
        public virtual Nullable<int> VariantRef { get; set; }
        public virtual string VariantCode { get; set; }
        public virtual string VariantName { get; set; }
        public virtual Nullable<short> Canconfig{ get; set; }
        public virtual Nullable<int> Priority{ get; set; }
        public virtual Nullable<decimal> AddTaxRate { get; set; }
        public virtual Nullable<decimal> AddTaxConvfact{ get; set; }
        public virtual Nullable<decimal> AddTaxAmount{ get; set; }
        public virtual Nullable<short> AddTaxAmtisupd{ get; set; }
        public virtual Nullable<decimal> AddTaxDiscAmount{ get; set; }
        public virtual Nullable<decimal> ExAddTaxRate { get; set; }
        public virtual Nullable<decimal> ExAddTaxConvf { get; set; }
        public virtual Nullable<decimal> ExAddTaxAmount { get; set; }
        public virtual Nullable<int> EuVatStatus{ get; set; }
        public virtual Nullable<short> AddTaxEffectKdv{ get; set; }
        public virtual Nullable<short> AffectRisk{ get; set; }
        public virtual Nullable<decimal> EdtPrice{ get; set; }
        public virtual Nullable<short> EdtCurr{ get; set; }
        public virtual Nullable<DateTime> OrgDueDate{ get; set; }
        public virtual Nullable<decimal> OrgQuantity{ get; set; }
        public virtual Nullable<decimal> OrgPrice{ get; set; }
        public virtual string AuxilCode2{ get; set; }
        public virtual Nullable<DateTime> ReserveDate{ get; set; }
        public virtual string Prclistcode{ get; set; }
        public virtual Nullable<int> Prclisttype{ get; set; }
        public virtual Nullable<int> DeductionPart1{ get; set; }
        public virtual Nullable<int> DeductionPart2 { get; set; }

        #region Implementation
        public virtual string AuxilCode { get; set; }
        public virtual string PaymentCode { get; set; }
        public virtual Nullable<short> Division { get; set; }
        public virtual Nullable<short> Department { get; set; }
        public virtual Nullable<int> DataSiteId { get; set; }
        public virtual Nullable<int> DataReference { get; set; }
        public virtual Nullable<short> Factory { get; set; }
        public virtual string GlobalId { get; set; }
        #endregion

        #region SubClasses

        #endregion
    }
}
