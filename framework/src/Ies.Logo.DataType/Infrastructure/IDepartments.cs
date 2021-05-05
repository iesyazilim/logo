using System;

namespace Ies.Logo.DataType.Infrastructure
{
    public interface ISourceIndex
    {
        Nullable<short> SourceIndex { get; set; }
    }

    public interface IDivision
    {
        Nullable<short> Division { get; set; }
    }

    public interface IDepartment
    {
        Nullable<short> Department { get; set; }
    }

    public interface IFactory
    {
        Nullable<short> Factory { get; set; }
    }
}
