﻿using System;
using Ies.Logo.Core;
using Ies.Logo.DataType.AggregateRoot;
using Ies.Logo.DataType.Infrastructure;

namespace Ies.Logo.DataType.SerialLotRecords
{
    [Serializable]
    public class ItemSerialLot : AuditedAggregateRoot, IDataSiteId, IDataNo
    {
        public static LogoObjectType XmlRoot => LogoObjectType.SERIAL_LOT_RECORDS;

        public virtual string ItemCode { get; set; }
        public virtual Nullable<int> Type { get; set; }
        public string DataNumber { get => Code; set => Code = value; }
        public virtual string Code { get; set; }
        public virtual string Description { get; set; }
        public virtual Nullable<int> WfStatus { get; set; }
        public virtual string VariantCode { get; set; }

        #region Implementation
        public virtual Nullable<int> DataSiteId { get; set; }
        #endregion
    }
}
