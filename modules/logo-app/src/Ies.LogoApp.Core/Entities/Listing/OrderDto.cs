using System;
using Allegory.Standart.Filter.Concrete;

namespace Ies.LogoApp.Entities
{
    [Serializable]
    public class OrderDto : IOrderDto
    {
        public Sort OrderBy { get; set; }
    }
}
