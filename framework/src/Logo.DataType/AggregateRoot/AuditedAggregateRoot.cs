﻿using System;
using Logo.DataType.Auditing;

namespace Logo.DataType.AggregateRoot
{
    [Serializable]
    public abstract class AuditedAggregateRoot : CreationAuditedAggregateRoot, IAuditedObject
    {
        public virtual Nullable<short> LastModifierId { get; set; }
        public virtual Nullable<DateTime> LastModificationDate { get; set; }
        public virtual Nullable<short> LastModificationHour { get; set; }
        public virtual Nullable<short> LastModificationMinute { get; set; }
        public virtual Nullable<short> LastModificationSecond { get; set; }
    }
}
