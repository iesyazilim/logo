using System;
using Allegory.Standart.Filter.Concrete;

namespace Ies.LogoApp.Entities
{
    [Serializable]
    public class DetailedPagedRequestDto : PagedRequestDto
    {
        public string OrderBy { get; set; }

        public Condition Conditions { get; set; }
    }
}
