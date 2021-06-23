using System;
using Allegory.Standart.Filter.Concrete;

namespace Ies.LogoApp.Entities
{
    [Serializable]
    public class FilterDto : IFilterDto
    {
        public Condition Conditions { get; set; }
    }
}
