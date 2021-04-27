﻿using System;

namespace Logo.DataType.Auditing
{
    public interface IModificationAuditedObject : IHasModificationTime
    {
        Nullable<short> LastModifierId { get; }
    }
}
