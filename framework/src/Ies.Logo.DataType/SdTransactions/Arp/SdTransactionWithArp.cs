using System;
using System.Collections.Generic;
using Ies.Logo.Core;
using Ies.Logo.DataType.ArpVouchers;

namespace Ies.Logo.DataType.SdTransactions
{
    [Serializable]
    public class SdTransactionWithArp : SdTransaction
    {
        public static new LogoObjectType XmlRoot => SdTransaction.XmlRoot;

        public List<Transaction> AttachmentArps { get; set; }
    }
}
