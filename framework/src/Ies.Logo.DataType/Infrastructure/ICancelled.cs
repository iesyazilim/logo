using System;

namespace Ies.Logo.DataType.Infrastructure
{
    public interface ICancelled
    {
        Nullable<short> Cancelled { get; set; }
    }
}
