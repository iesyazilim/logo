using System;

namespace Ies.LogoApp.Entities
{
    [Serializable]
    public class OrderDto : IOrderDto
    {
        public string OrderBy { get; set; }
    }
}
