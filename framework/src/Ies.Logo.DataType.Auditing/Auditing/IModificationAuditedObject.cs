using System;

namespace Ies.Logo.DataType.Auditing
{
    public interface IModificationAuditedObject : IHasModificationTime
    {
        Nullable<short> LastModifierId { get; }
    }
}
