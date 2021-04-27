using System;

namespace Logo.DataType.Auditing
{
    public interface IMayHaveCreator
    {
        Nullable<short> CreatorId { get; }
    }
}
