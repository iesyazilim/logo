using System;
using System.Collections.Generic;
using System.Text;
using Ies.Logo.DataType.AggregateRoot;

namespace Ies.Logo.DataType.SdTransactions
{
    [Serializable]
    public class SdTransaction : AuditedAggregateRoot
    {
        public static string XmlRoot => "SD_TRANSACTIONS";

        #region Implementation

        #endregion

        #region SubClasses
        public virtual ArpVouchers.Transaction AttachmentArp { get; set; }
        #endregion
    }
}
