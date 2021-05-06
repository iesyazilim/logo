using System;

namespace IesYazilim.Logo.DataType.Auditing
{
    public interface IMayHaveCreator
    {
        Nullable<short> CreatorId { get; }
    }
}
