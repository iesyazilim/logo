using System;
using Ies.Logo.DataType.Infrastructure;

namespace Ies.Logo.DataType.WhParams
{
    public interface IWhParam : ILogo
    {
        Nullable<int> WhNumber { get; set; }
    }
}
