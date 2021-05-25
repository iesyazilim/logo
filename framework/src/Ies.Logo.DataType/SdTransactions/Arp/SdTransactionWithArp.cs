using System;
using System.Collections.Generic;
using Ies.Logo.DataType.ArpVouchers;

namespace Ies.Logo.DataType.SdTransactions
{
    [Serializable]
    public class SdTransactionWithArp : SdTransaction
    {
        public static new string XmlRoot => SdTransaction.XmlRoot;

        public List<Transaction> AttachmentArps => new List<Transaction> { AttachmentArp };
        public virtual Transaction AttachmentArp { get; set; }
    }
}
