using System;

namespace Ies.Logo.DataType.Auditing
{
    public interface IHasCreationDate
    {
        Nullable<DateTime> CreationDate { get; }
    }
    public interface IHasCreationTime : IHasCreationDate
    {
        Nullable<short> CreationHour { get; }
        Nullable<short> CreationMinute { get; }
        Nullable<short> CreationSecond { get; }
    }
}
