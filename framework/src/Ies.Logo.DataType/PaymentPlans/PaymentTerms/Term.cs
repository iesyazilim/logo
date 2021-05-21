using System;
using Ies.Logo.DataType.Infrastructure;

namespace Ies.Logo.DataType.PaymentPlans
{
    public class Term : ILogo
    {
        public virtual Nullable<int> Lineno{ get; set; }
        public virtual Nullable<int> AfterDays{ get; set; }
        public virtual string Formula{ get; set; }
        public virtual string Condition{ get; set; }
        public virtual string Day{ get; set; }
        public virtual string Month{ get; set; }
        public virtual string Year{ get; set; }
        public virtual Nullable<decimal> RoundBase{ get; set; }
        public virtual Nullable<DateTime> AbsoluteDate{ get; set; }
        public virtual Nullable<short> DateSelector{ get; set; }
        public virtual Nullable<decimal> DiscRate{ get; set; }
        public virtual Nullable<int> PaymentType{ get; set; }
        public virtual string BankaccCode{ get; set; }
        public virtual string RepayplanCode{ get; set; }
        public virtual Nullable<int> TrCurr{ get; set; }
        public virtual string GlobalCode{ get; set; }
    }
}
