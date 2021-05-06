using IesYazilim.Logo.DataType.Infrastructure;

namespace IesYazilim.Logo.DataType.Units
{
    public interface IUnit : ILogo
    {
        string UnitCode { get; set; }
    }
}
