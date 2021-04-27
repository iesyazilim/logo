using System;
using Logo.DataType.Infrastructure;

namespace Logo.DataType.WhParams
{
    public interface IWhParam : ILogo
    {
        Nullable<int> WhNumber { get; set; }
    }
}
