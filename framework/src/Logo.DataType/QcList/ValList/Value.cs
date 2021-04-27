using System;
using Logo.DataType.Infrastructure;

namespace Logo.DataType.QcList
{
    [Serializable]
    public class Value : ILogo, ICancelled
    {
        public virtual Nullable<int> AsgnType { get; set; }
        public virtual Nullable<int> QcRevNo { get; set; }
        public virtual Nullable<int> Qtype { get; set; }
        public virtual Nullable<int> LineNr { get; set; }
        public virtual Nullable<decimal> Amount { get; set; }
        public virtual Nullable<decimal> Qvalue { get; set; }
        public virtual Nullable<short> Confirmed { get; set; }
        public virtual Nullable<DateTime> Qdate { get; set; }
        public virtual Nullable<short> Cancelled { get; set; }
        public virtual string Qcode { get; set; }
        public virtual string Qname { get; set; }
        public virtual string ValCode { get; set; }
        public virtual string ValName { get; set; }
        public virtual Nullable<decimal> NomValue { get; set; }
        public virtual Nullable<decimal> MinValue { get; set; }
        public virtual Nullable<decimal> MaxValue { get; set; }
        public virtual string Munit { get; set; }
        public virtual string Qunit { get; set; }
        public virtual Nullable<decimal> Frequency { get; set; }
        public virtual Nullable<decimal> Counter { get; set; }
        public virtual Nullable<decimal> SampleSize { get; set; }
    }
}
