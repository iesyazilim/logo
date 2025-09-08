using Ies.Logo.Core;
using Ies.Logo.DataType.Invoices;
using System;
using System.Collections.Generic;

namespace Ies.Logo.DataType.BankVouchers
{
    [Serializable]
    public class BankVoucherWithInvoice : BankVoucher
    {
        public static new LogoObjectType XmlRoot => BankVoucher.XmlRoot;

        public virtual string BnAccCode { get; set; }
        public List<Invoice> AttachmentInvoices { get; set; }
    }
}
