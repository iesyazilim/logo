using System.ComponentModel.DataAnnotations;

namespace Ies.LogoApp.Entities
{
    public interface IPagedRequestDto : IDto
    {
        [Range(1, int.MaxValue)]
        int Page { get; set; }

        int PageSize { get; set; }
    }
}
