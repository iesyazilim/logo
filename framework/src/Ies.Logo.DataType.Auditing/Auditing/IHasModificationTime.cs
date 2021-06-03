using System;

namespace Ies.Logo.DataType.Auditing
{
    public interface IHasModificationDate
    {
        Nullable<DateTime> LastModificationDate { get; set; }
    }
    public interface IHasModificationTime : IHasModificationDate
    {
        Nullable<short> LastModificationHour { get; set; }
        Nullable<short> LastModificationMinute { get; set; }
        Nullable<short> LastModificationSecond { get; set; }
    }
}
