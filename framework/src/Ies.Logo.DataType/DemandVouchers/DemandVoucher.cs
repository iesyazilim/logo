using System;
using System.Collections.Generic;
using Ies.Logo.DataType.AggregateRoot;
using Ies.Logo.DataType.Infrastructure;

namespace Ies.Logo.DataType.DemandVouchers
{
    [Serializable]
    public class DemandVoucher : AuditedAggregateRoot
    {
        public static string XmlRoot => "DEMAND_FICHES";

        #region Implementation

        #endregion

        #region SubClasses
        public virtual List<Transaction> Transactions { get; set; }
        #endregion
    }
}
