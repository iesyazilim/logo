using Allegory.Standart.Filter.Concrete;

namespace Ies.LogoApp.Entities
{
    public interface IFilterDto : IDto
    {
        Condition Conditions { get; set; }
    }
}
