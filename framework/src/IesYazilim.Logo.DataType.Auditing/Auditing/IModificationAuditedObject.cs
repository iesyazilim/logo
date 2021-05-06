using System;

namespace IesYazilim.Logo.DataType.Auditing
{
    public interface IModificationAuditedObject : IHasModificationTime
    {
        Nullable<short> LastModifierId { get; }
    }
}
