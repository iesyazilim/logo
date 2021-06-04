using System.Collections.Generic;

namespace Ies.LogoApp.Entities.Items
{
    public class ItemDto : IDto
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public List<UnitDto> Units { get; set; }
    }
}
