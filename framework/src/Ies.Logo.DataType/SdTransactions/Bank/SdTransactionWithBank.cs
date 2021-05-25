using System.Collections.Generic;
using Ies.Logo.DataType.BankVouchers;

namespace Ies.Logo.DataType.SdTransactions
{
    public class SdTransactionWithBank : SdTransaction
    {
        public static new string XmlRoot => SdTransaction.XmlRoot;

        public List<Transaction> AttachmentBanks => new List<Transaction> { AttachmentBank };
        public virtual Transaction AttachmentBank { get; set; }
    }
}
