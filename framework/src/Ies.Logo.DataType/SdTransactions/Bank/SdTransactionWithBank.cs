using Ies.Logo.Core;
using Ies.Logo.DataType.BankVouchers;
using System;
using System.Collections.Generic;

namespace Ies.Logo.DataType.SdTransactions
{
    [Serializable]
    public class SdTransactionWithBank : SdTransaction
    {
        public static new LogoObjectType XmlRoot => SdTransaction.XmlRoot;

        public List<Transaction> AttachmentBanks { get; set; }
    }
}
