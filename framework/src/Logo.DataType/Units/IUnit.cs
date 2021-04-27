using Logo.DataType.Infrastructure;

namespace Logo.DataType.Units
{
    public interface IUnit : ILogo
    {
        string UnitCode { get; set; }
    }
}
