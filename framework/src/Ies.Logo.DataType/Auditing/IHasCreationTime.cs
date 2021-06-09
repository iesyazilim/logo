using System;

namespace Ies.Logo.DataType.Auditing
{
    public interface IHasCreationDate
    {
        Nullable<DateTime> CreationDate { get; set; }
    }
    public interface IHasCreationTime : IHasCreationDate
    {
        Nullable<short> CreationHour { get; set; }
        Nullable<short> CreationMinute { get; set; }
        Nullable<short> CreationSecond { get; set; }
    }
}
