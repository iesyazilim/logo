using System.Collections.Generic;
using Ies.Logo.DataType.AggregateRoot;
using Ies.Logo.DataType.GlLinks;
using Ies.Logo.DataType.Units;
using Ies.Logo.DataType.WhParams;

namespace Ies.Logo.DataType.Services
{
    public class Service : AuditedAggregateRoot
    {
        public virtual ServiceCardType CardType { get; set; }

        #region Implementation 

        #endregion

        #region SubClasses
        public virtual List<ServiceWhParam> WhParams { get; set; }
        public virtual List<ServiceUnit> Units { get; set; }
        public virtual List<GlLink> GlLinks { get; set; }
        #endregion

        public override string GetRootElementName()
        {
            switch (CardType)
            {
                case ServiceCardType.Purchase:
                case ServiceCardType.PurchaseGroup:
                    return "PURCHASE_SERVICES";

                case ServiceCardType.Sales:
                case ServiceCardType.SalesGroup:
                    return "SALES_SERVICES";

                default:
                    return "UNKOWN";
            }
        }
    }
}
