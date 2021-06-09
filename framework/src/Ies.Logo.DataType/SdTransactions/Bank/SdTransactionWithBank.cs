using System;
using System.Collections.Generic;
using Ies.Logo.Core;
using Ies.Logo.DataType.BankVouchers;

namespace Ies.Logo.DataType.SdTransactions
{
    [Serializable]
    public class SdTransactionWithBank : SdTransaction
    {
        public static new LogoObjectType XmlRoot => SdTransaction.XmlRoot;

        public List<Transaction> AttachmentBanks => new List<Transaction> { AttachmentBank };
        public virtual Transaction AttachmentBank { get; set; }
    }
}
