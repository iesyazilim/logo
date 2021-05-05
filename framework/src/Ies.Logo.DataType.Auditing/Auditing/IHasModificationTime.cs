using System;

namespace Ies.Logo.DataType.Auditing
{
    public interface IHasModificationDate
    {
        Nullable<DateTime> LastModificationDate { get; }
    }
    public interface IHasModificationTime : IHasModificationDate
    {
        Nullable<short> LastModificationHour { get; }
        Nullable<short> LastModificationMinute { get; }
        Nullable<short> LastModificationSecond { get; }
    }
}
