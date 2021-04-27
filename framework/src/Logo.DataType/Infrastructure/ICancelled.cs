using System;

namespace Logo.DataType.Infrastructure
{
    public interface ICancelled
    {
        Nullable<short> Cancelled { get; set; }
    }
}
