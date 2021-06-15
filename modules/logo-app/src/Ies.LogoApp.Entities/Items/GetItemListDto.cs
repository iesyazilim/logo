using Ies.LogoApp.Core;

namespace Ies.LogoApp.Items
{
    public class GetItemListDto : IDto
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Name2 { get; set; }
        public string Name3 { get; set; }
        public bool Active { get; set; }
    }
}
