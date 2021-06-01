using System;
using Ies.Logo.DataType.Infrastructure;

namespace Ies.Logo.DataType.PaymentPlans
{
    public class DiscPayln : ILogo, IDataReference, IDataSiteId
    {
        public virtual string Day{ get; set; }
        public virtual Nullable<decimal> Discrate{ get; set; }
        public virtual Nullable<int> Wfstatus{ get; set; }

        #region Implementation
        public virtual Nullable<int> DataReference { get; set; }
        public virtual Nullable<int> InternalReference { get; set; }
        public virtual Nullable<int> DataSiteId { get; set; }
        #endregion
    }
}
