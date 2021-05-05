using System;

namespace Ies.Logo.DataType.Auditing
{
    public interface IMayHaveCreator
    {
        Nullable<short> CreatorId { get; }
    }
}
