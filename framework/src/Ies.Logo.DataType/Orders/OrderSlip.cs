using System;
using Ies.Logo.DataType.AggregateRoot;

namespace Ies.Logo.DataType.Orders
{
    [Serializable]
    public class OrderSlip : AuditedAggregateRoot
    {
        public virtual bool IsSales { get; set; }

        #region Implementation

        #endregion

        #region SubClasses

        #endregion

        public override string GetRootElementName()
        {
            switch (IsSales)
            {
                case false:
                    return "PURCHASE_ORDERS";

                case true:
                    return "SALES_ORDERS";

                default:
                    return "UNKOWN";
            }
        }
    }
}
