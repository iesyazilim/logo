using System;
using System.Collections.Generic;
using Ies.Logo.DataType.Invoices;

namespace Ies.Logo.DataType.SdTransactions
{
    [Serializable]
    public class SdTransactionWithInvoice : SdTransaction
    {
        public static new string XmlRoot => SdTransaction.XmlRoot;

        public List<Invoice> AttachmentInvoices => new List<Invoice> { AttachmentInvoice };
        public virtual Invoice AttachmentInvoice { get; set; }
    }
}
