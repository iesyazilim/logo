using System;
using Ies.Logo.DataType.Infrastructure;

namespace Ies.Logo.DataType.Invoices
{
    public class Intel : ILogo
    {
        public virtual string InvoiceInfo1 { get; set; }
        public virtual string InvoiceInfo2 { get; set; }
        public virtual string InvoiceInfo3 { get; set; }
        public virtual string InvoiceInfo4 { get; set; }
        public virtual string InvoiceInfo5 { get; set; }
        public virtual string InvoiceInfo6 { get; set; }
        public virtual string InvoiceInfo7 { get; set; }
        public virtual string InvoiceInfo8 { get; set; }
        public virtual string InvoiceInfo9 { get; set; }
        public virtual string InvoiceInfo10 { get; set; }
        public virtual string IntelDesc { get; set; }
        public virtual Nullable<int> LineNum { get; set; }
    }
}
