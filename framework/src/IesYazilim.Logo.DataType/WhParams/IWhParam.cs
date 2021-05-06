using System;
using IesYazilim.Logo.DataType.Infrastructure;

namespace IesYazilim.Logo.DataType.WhParams
{
    public interface IWhParam : ILogo
    {
        Nullable<int> WhNumber { get; set; }
    }
}
