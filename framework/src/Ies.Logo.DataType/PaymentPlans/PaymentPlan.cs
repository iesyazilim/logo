using System;
using System.Collections.Generic;
using Ies.Logo.DataType.AggregateRoot;

namespace Ies.Logo.DataType.PaymentPlans
{
    [Serializable]
    public class PaymentPlan : AuditedAggregateRoot
    {
        public static string XmlRoot => "PAYMENT_PLANS";


        #region Impelementation

        #endregion

        #region SubClasses
        public virtual List<Term> PaymentTerms { get; set; }
        #endregion
    }
}
