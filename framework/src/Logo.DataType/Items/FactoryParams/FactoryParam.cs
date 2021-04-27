using System;
using Logo.DataType.Infrastructure;

namespace Logo.DataType.Items
{
    [Serializable]
    public class FactoryParam : ILogo
    {
        public virtual Nullable<int> FactoryNr { get; set; }
        public virtual Nullable<int> Specialized { get; set; }
        public virtual Nullable<int> ProcureClass { get; set; }
        public virtual Nullable<int> LowLevelCode { get; set; }
        public virtual Nullable<short> DivLotSize { get; set; }
        public virtual Nullable<short> MrpCntrl { get; set; }
        public virtual Nullable<int> PlanPolicy { get; set; }
        public virtual Nullable<int> LotSizingMtd { get; set; }
        public virtual Nullable<int> LotSizingMtd2 { get; set; }
        public virtual Nullable<decimal> FixedLotSize { get; set; }
        public virtual Nullable<decimal> FixedLotSize2 { get; set; }
        public virtual Nullable<decimal> Yield { get; set; }
        public virtual Nullable<decimal> Yield2 { get; set; }
        public virtual Nullable<decimal> MinOrderQty { get; set; }
        public virtual Nullable<decimal> MinOrderQty2 { get; set; }
        public virtual Nullable<decimal> MaxOrderQty { get; set; }
        public virtual Nullable<decimal> MaxOrderQty2 { get; set; }
        public virtual Nullable<decimal> MultOrderQty { get; set; }
        public virtual Nullable<decimal> MultOrderQty2 { get; set; }
        public virtual Nullable<decimal> MinOrderDay { get; set; }
        public virtual Nullable<decimal> MaxOrderDay { get; set; }
        public virtual Nullable<decimal> ReOrderPoint { get; set; }
        public virtual Nullable<short> AutoMtrIssue { get; set; }
        public virtual string DefSeriLotNo { get; set; }
        public virtual Nullable<int> AutoLotMtd { get; set; }
        public virtual Nullable<int>LotParty { get; set; }
        public virtual Nullable<decimal> OutLotSize { get; set; }
        public virtual Nullable<int> CountFormPs { get; set; }
    }
}
