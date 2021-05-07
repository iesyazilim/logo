using System;
using System.Collections.Generic;
using Ies.Logo.DataType.Infrastructure;

namespace Ies.Logo.DataType.Payments
{
    [Serializable]
    public class Payment : ILogo
    {
        public virtual Nullable<DateTime> Date { get; set; }
        public virtual Nullable<int> ModuleNr { get; set; }
        public virtual Nullable<int> Sign { get; set; }
        public virtual Nullable<int> TrCode { get; set; }
        public virtual Nullable<decimal> Total { get; set; }
        public virtual Nullable<int> Days { get; set; }
        public virtual Nullable<decimal> LatelyIntRate { get; set; }
        public virtual Nullable<DateTime> ProcDate { get; set; }
        public virtual Nullable<decimal> TrRate { get; set; }
        public virtual Nullable<short> Modified { get; set; }
        public virtual Nullable<DateTime> DiscountDueDate { get; set; }
        public virtual Nullable<int> DisctrdelList { get; set; }
        public virtual Nullable<int> PayNo { get; set; }
        public virtual Nullable<decimal> PosComsn { get; set; }
        public virtual string BankAccCode { get; set; }
        public virtual Nullable<int> PaymentType { get; set; }
        public virtual Nullable<decimal> NetTotal { get; set; }
        public virtual Nullable<short> RepayplnApplied { get; set; }
        public virtual string RepayplanCode { get; set; }
        public virtual string LineExp { get; set; }

        #region SubClasses
        public virtual List<DiscPaytr> DisctrList { get; set; }
        #endregion
    }
}
