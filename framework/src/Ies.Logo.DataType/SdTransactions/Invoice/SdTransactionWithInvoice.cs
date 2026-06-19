using Ies.Logo.Core;
using Ies.Logo.DataType.Invoices;
using System;
using System.Collections.Generic;

namespace Ies.Logo.DataType.SdTransactions
{
    [Serializable]
    public class SdTransactionWithInvoice : SdTransaction
    {
        public static new LogoObjectType XmlRoot => SdTransaction.XmlRoot;

        public List<Invoice> AttachmentInvoices { get; set; }
    }
}
