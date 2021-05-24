using System;
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
        public virtual BankVouchers.Transaction AttachmentBank { get; set; }
        public virtual Invoices.Invoice AttachmentInvoice { get; set; }
        #endregion
    }
}
