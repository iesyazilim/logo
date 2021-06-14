using System;
using Ies.Logo.DataType.Infrastructure;

namespace Ies.Logo.DataType.SalesPeople
{
    public class Cls : ILogo, IInternalReference
    {
        public virtual Nullable<int> LineNo { get; set; }
        public virtual string Code { get; set; }
        public virtual string Name { get; set; }
        public virtual Nullable<DateTime> BegDate { get; set; }
        public virtual Nullable<byte> VisitDay { get; set; }
        public virtual Nullable<int> VisitPeriod { get; set; }
        public virtual string ShipCode { get; set; }
        public virtual Nullable<int> ClLineNo { get; set; }

        #region Implementation
        public virtual Nullable<int> InternalReference { get; set; }
        #endregion
    }
}
