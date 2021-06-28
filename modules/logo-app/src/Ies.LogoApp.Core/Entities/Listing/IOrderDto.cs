using Allegory.Standart.Filter.Concrete;

namespace Ies.LogoApp.Entities
{
    public interface IOrderDto : IDto
    {
        Sort OrderBy { get; set; }
    }
}
