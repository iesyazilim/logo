using System;
using Ies.Logo.DataType.Infrastructure;

namespace Ies.Logo.DataType.Payments
{
    public class DiscPaytr : ILogo, IDataSiteId, IDataReference
    {
        public virtual Nullable<int> TrCode { get; set; }
        public virtual Nullable<int> ModuleNr { get; set; }
        public virtual Nullable<int> Tsign { get; set; }
        public virtual Nullable<decimal> DiscRate { get; set; }
        public virtual Nullable<DateTime> DiscDueDate { get; set; }
        public virtual Nullable<int> WfStatus { get; set; }

        #region Implementation
        public virtual Nullable<int> DataSiteId { get; set; }
        public virtual Nullable<int> DataReference { get; set; }
        public virtual Nullable<int> InternalReference { get; set; }
        #endregion
    }
}
