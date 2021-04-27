﻿using System;
using Logo.DataType.Auditing;
using Logo.DataType.Infrastructure;

namespace Logo.DataType.AggregateRoot
{
    [Serializable]
    public abstract class CreationAuditedAggregateRoot : LogoBase, ICreationAuditedObject
    {
        public virtual Nullable<short> CreationHour { get; set; }
        public virtual Nullable<short> CreationMinute { get; set; }
        public virtual Nullable<short> CreationSecond { get; set; }
        public virtual Nullable<DateTime> CreationDate { get; set; }
        public virtual Nullable<short> CreatorId { get; set; }
    }
}
