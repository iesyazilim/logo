using System;
using Logo.DataType.Infrastructure;

namespace Logo.DataType.Items
{
    [Serializable]
    public class ItemSubstitute : ILogo, IDataSiteId, IDataReference
    {
        public virtual Nullable<int> LineNo { get; set; }
        public virtual Nullable<int> Priority { get; set; }
        public virtual Nullable<decimal> ConvFact1 { get; set; }
        public virtual Nullable<decimal> ConvFact2 { get; set; }
        public virtual Nullable<decimal> MinQuantity { get; set; }
        public virtual Nullable<decimal> MaxQuantity { get; set; }
        public virtual Nullable<DateTime> BegDate { get; set; }
        public virtual Nullable<DateTime> EndDate { get; set; }
        public virtual string SubsCode { get; set; }
        public virtual string MainCode { get; set; }
        public virtual string MainVrntCode { get; set; }
        public virtual string SubsVrntCode { get; set; }

        #region Implementation
        public virtual Nullable<int> DataReference { get; set; }
        public virtual Nullable<int> DataSiteId { get; set; }
        #endregion
    }
}
