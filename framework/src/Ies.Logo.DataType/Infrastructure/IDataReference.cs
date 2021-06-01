using System;

namespace Ies.Logo.DataType.Infrastructure
{
    public interface IInternalReference
    {
        Nullable<int> InternalReference { get; set; }
    }
    public interface IDataReference : IInternalReference
    {
        Nullable<int> DataReference { get; set; }
    }
}
