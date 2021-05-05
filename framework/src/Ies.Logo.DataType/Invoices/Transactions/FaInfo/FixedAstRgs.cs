using System;
using Ies.Logo.DataType.Infrastructure;

namespace Ies.Logo.DataType.Invoices
{
    [Serializable]
    public class FixedAstRgs : ILogo, IDivision, IDepartment, ICancelled, IApprove
    {
        public virtual string Code { get; set; }
        public virtual Nullable<short> Transfer { get; set; }
        public virtual Nullable<DateTime> DateAcquired { get; set; }
        public virtual Nullable<DateTime> DateDeprstart { get; set; }
        public virtual Nullable<DateTime> DateDeprstart2 { get; set; }
        public virtual Nullable<decimal> Quantity { get; set; }
        public virtual Nullable<decimal> QuantityOut { get; set; }
        public virtual Nullable<decimal> AcqValue { get; set; }
        public virtual Nullable<decimal> VatAmount { get; set; }
        public virtual Nullable<int> VatPostDur { get; set; }
        public virtual Nullable<decimal> DeprRate { get; set; }
        public virtual Nullable<int> DeprDur { get; set; }
        public virtual Nullable<short> DeprType { get; set; }
        public virtual Nullable<short> Revaluate { get; set; }
        public virtual Nullable<short> RevDepr { get; set; }
        public virtual Nullable<short> DeprType2 { get; set; }
        public virtual Nullable<decimal> DeprRate2 { get; set; }
        public virtual Nullable<int> DeprDur2 { get; set; }
        public virtual Nullable<short> Revaluate2 { get; set; }
        public virtual Nullable<short> RevDepr2 { get; set; }
        public virtual Nullable<short> PartialDepr { get; set; }
        public virtual Nullable<decimal> RcXrate { get; set; }
        public virtual Nullable<decimal> RcAcqValue { get; set; }
        public virtual Nullable<decimal> TotalExpenses { get; set; }
        public virtual Nullable<decimal> AccumDepr { get; set; }
        public virtual Nullable<decimal> AccumReval { get; set; }
        public virtual Nullable<decimal> RcTotalExpn { get; set; }
        public virtual Nullable<decimal> RcAccumDepr { get; set; }
        public virtual Nullable<decimal> RcAccumReval { get; set; }
        public virtual Nullable<decimal> OpenReval { get; set; }
        public virtual Nullable<decimal> OpenDepr { get; set; }
        public virtual Nullable<decimal> OpenRevDepr { get; set; }
        public virtual Nullable<decimal> OpenReval2 { get; set; }
        public virtual Nullable<decimal> OpenDepr2 { get; set; }
        public virtual Nullable<decimal> OpenRevDepr2 { get; set; }
        public virtual Nullable<decimal> RcOpenRev { get; set; }
        public virtual Nullable<decimal> RcOpenDepr { get; set; }
        public virtual Nullable<decimal> RcOpenRevDepr { get; set; }
        public virtual Nullable<decimal> RcOpenRev2 { get; set; }
        public virtual Nullable<decimal> RcOpenDepr2 { get; set; }
        public virtual Nullable<decimal> RcOpenRevDepr2 { get; set; }
        public virtual Nullable<short> PartDep2 { get; set; }
        public virtual Nullable<decimal> DiffPrice { get; set; }
        public virtual Nullable<decimal> DiffrepPrice { get; set; }
        public virtual Nullable<short> DiscIncl { get; set; }
        public virtual Nullable<decimal> DiscRate { get; set; }
        public virtual Nullable<short> AnnualDistVal { get; set; }
        public virtual Nullable<decimal> InfBasedValue { get; set; }
        public virtual string RegTypeCode { get; set; }
        public virtual string RegTypeDef { get; set; }
        public virtual string RegExpensCode { get; set; }
        public virtual string RegExpensDef { get; set; }

        #region Implementation
        public virtual Nullable<short> Division { get; set; }
        public virtual Nullable<short> Department { get; set; }
        public virtual Nullable<short> Cancelled { get; set; }
        public virtual Nullable<short> Approve { get; set; }
        public virtual Nullable<DateTime> ApproveDate { get; set; }
        #endregion
    }
}
