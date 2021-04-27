using System;
using Logo.DataType.Infrastructure;

namespace Logo.DataType.WhParams
{
    [Serializable]
    public class ItemWhParam : WhParam
    {
        public virtual Nullable<decimal> MinLevel { get; set; }
        public virtual Nullable<decimal> MaxLevel { get; set; }
        public virtual Nullable<decimal> SafetyLevel { get; set; }
        public virtual string LocationCode { get; set; }
        public virtual Nullable<DateTime> PeriodCloseDate { get; set; }
        public virtual Nullable<int> AbcCode { get; set; }
        public virtual Nullable<short> IOFlag { get; set; }
        public virtual Nullable<short> MinLevelFlag { get; set; }
        public virtual Nullable<short> MaxLevelFlag { get; set; }
        public virtual Nullable<short> SafetyLevelFlag { get; set; }
        public virtual Nullable<short> BackOrderFlag { get; set; }
        public virtual Nullable<short> OutFlag { get; set; }
        public virtual Nullable<short> Clas { get; set; }
        public virtual string DominantCode { get; set; }
        public virtual Nullable<short> DominantFlag { get; set; }
        public virtual Nullable<int> ProcureInven { get; set; }
    }
}
