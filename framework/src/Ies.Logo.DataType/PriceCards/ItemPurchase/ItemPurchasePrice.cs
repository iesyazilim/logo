using ExtendedXmlSerializer.Configuration;
using Ies.Logo.Core;
using Ies.Logo.DataType.AggregateRoot;
using Ies.Logo.DataType.PriceCards.Divisions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ies.Logo.DataType.PriceCards.ItemPurchase
{
    [Serializable]
    public class ItemPurchasePrice : AuditedAggregateRoot
    {
        public static LogoObjectType XmlRoot => LogoObjectType.ITEM_PURCHASE_PRICE;
        public virtual string Code { get; set; }
        public virtual string ItemCode { get; set; }
        public virtual string ClientCode { get; set; }
        public virtual decimal? Price { get; set; }
        public virtual string UnitCode { get; set; }
        public virtual short VatIncluded { get; set; }
        public virtual DateTime? StartDate { get; set; }
        public virtual DateTime? EndDate { get; set; }
        public virtual short? UnitConvert { get; set; }
        public virtual int? StartTime { get; set; }
        public virtual int? EndTime { get; set; }
        public virtual string Definition { get; set; }
        public virtual short? Active { get; set; }
        public virtual short? Branch { get; set; }
        public virtual short? AllDivision { get; set; }
        #region SubClasses
        public virtual List<DivisionStr> Divisions { get; set; }
        #endregion
    }
}
