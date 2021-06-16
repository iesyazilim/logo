using System;
using Allegory.Standart.Filter.Concrete;

namespace Ies.LogoApp.Core.Entities
{
    [Serializable]
    public class DetailedPagedRequestDto : PagedRequestDto
    {
        public string OrderBy { get; set; }

        public Condition Conditions { get; set; }
    }
}
