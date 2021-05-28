using System;
using System.Collections.Generic;
using Ies.Logo.Core;
using Ies.Logo.DataType.AggregateRoot;
using Ies.Logo.DataType.Infrastructure;

namespace Ies.Logo.DataType.PaymentPlans
{
    [Serializable]
    public class PaymentPlan : AuditedAggregateRoot, IRecordStatus, ISpecialCode, IDataSiteId
    {
        public static LogoObjectType XmlRoot => LogoObjectType.PAYMENT_PLANS;

        public virtual string Code { get; set; }
        public virtual string Description { get; set; }
        public virtual Nullable<decimal> EarlyIntrate { get; set; }
        public virtual Nullable<decimal> LateIntrate { get; set; }
        public virtual Nullable<int> Counter { get; set; }
        public virtual Nullable<short> WorkDays { get; set; }
        public virtual string PpGroupCode { get; set; }
        public virtual string CrdcardCode { get; set; }
        public virtual Nullable<int> PpGroupRef { get; set; }
        public virtual string GlobalCode { get; set; }

        #region Implementation
        public virtual Nullable<short> RecordStatus { get; set; }
        public virtual string AuthCode { get; set; }
        public virtual string AuxilCode { get; set; }
        public virtual Nullable<int> DataSiteId { get; set; }
        #endregion

        #region SubClasses
        public virtual List<Term> PaymentTerms { get; set; }
        public virtual List<DiscPayln> DiscList { get; set; }
        #endregion
    }
}
