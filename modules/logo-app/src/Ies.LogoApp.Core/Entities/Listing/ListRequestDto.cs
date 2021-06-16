using System;
using Allegory.Standart.Filter.Concrete;

namespace Ies.LogoApp.Core.Entities
{
    [Serializable]
    public class ListRequestDto : IDto
    {
        public string OrderBy { get; set; }

        public Condition Conditions { get; set; }
    }
}
