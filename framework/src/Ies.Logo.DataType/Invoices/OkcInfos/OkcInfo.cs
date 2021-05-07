using System;
using Ies.Logo.DataType.Infrastructure;

namespace Ies.Logo.DataType.Invoices
{
    [Serializable]
    public class OkcInfo : ILogo
    {
        public virtual Nullable<int> FicheType { get; set; }
        public virtual string FicheNumber { get; set; }
        public virtual Nullable<DateTime> Date { get; set; }
        public virtual Nullable<DateTime> Time { get; set; }
        public virtual string SerialNumber { get; set; }
        public virtual string ZNumber { get; set; }
        public virtual string FixedValue { get; set; }
        public virtual Nullable<int> LineNumber { get; set; }
    }
}
