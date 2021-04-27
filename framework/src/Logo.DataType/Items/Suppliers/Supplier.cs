using System;
using Logo.DataType.Infrastructure;

namespace Logo.DataType.Items
{
    [Serializable]
    public class Supplier : ILogo, ITradingGroup
    {
        public virtual Nullable<int> SupplyType { get; set; }
        public virtual Nullable<int> Priority { get; set; }
        public virtual Nullable<int> LineNo { get; set; }
        public virtual Nullable<int> ClCardType { get; set; }
        public virtual Nullable<int> QccCheck { get; set; }
        public virtual Nullable<decimal> LeadTime { get; set; }
        public virtual Nullable<decimal> MinQuantity { get; set; }
        public virtual Nullable<decimal> MaxQuantity { get; set; }
        public virtual Nullable<DateTime> BegDate{ get; set; }
        public virtual Nullable<int> Specialized { get; set; }
        public virtual string IcustSupCode { get; set; }
        public virtual string IcustSupName { get; set; }
        public virtual Nullable<decimal> QtyDepLeadTime { get; set; }
        public virtual string ArpCode { get; set; }
        public virtual string PacketCode { get; set; }
        public virtual Nullable<decimal> PackagingAmnt { get; set; }
        public virtual string UnitCode { get; set; }
        public virtual string UnitsetCode { get; set; }
        public virtual Nullable<int> PacketUseType { get; set; }
        public virtual Nullable<decimal> OrdPerc { get; set; }
        public virtual Nullable<int> OrdFrec { get; set; }

        #region Implementation
        public virtual string TradingGrp { get; set; }
        #endregion
    }
}
