using Ies.Logo.DataType.Infrastructure;

namespace Ies.Logo.DataType.Units
{
    public interface IUnit : ILogo
    {
        string UnitCode { get; set; }
    }
}
