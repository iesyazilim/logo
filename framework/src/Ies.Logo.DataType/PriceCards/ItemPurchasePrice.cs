using ExtendedXmlSerializer.Configuration;
using Ies.Logo.Core;
using Ies.Logo.DataType.AggregateRoot;
using Ies.Logo.DataType.PriceCards.Divisions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ies.Logo.DataType.PriceCards
{
    [Serializable]
    public class ItemPurchasePrice : AuditedAggregateRoot
    {
        public static LogoObjectType XmlRoot => LogoObjectType.ITEM_PURCHASE_PRICE;
        public virtual string Code { get; set; }
        public virtual string ItemCode { get; set; }
        public virtual string ClientCode { get; set; }
        public virtual Nullable<decimal> Price { get; set; }
        public virtual string UnitCode { get; set; }
        public virtual short VatIncluded { get; set; }
        public virtual Nullable<DateTime> StartDate { get; set; }
        public virtual Nullable<DateTime> EndDate { get; set; }
        public virtual Nullable<short> UnitConvert { get; set; }
        public virtual Nullable<int> StartTime { get; set; }
        public virtual Nullable<int> EndTime { get; set; }
        public virtual string Definition { get; set; }
        public virtual Nullable<short> Active { get; set; }
        public virtual Nullable<short> Branch { get; set; }
        public virtual Nullable<short> AllDivision { get; set; }
        #region SubClasses
        public virtual List<DivisionStr> Divisions { get; set; }
        #endregion
    }
}
