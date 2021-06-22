using Ies.LogoApp.Core;

namespace Ies.LogoApp.Items
{
    public class GetItemListDto : IDto
    {
        public int Id { get; set; }
        public short CardType { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Name2 { get; set; }
        public string Name3 { get; set; }
        public string MainUnitCode { get; set; }
        public string SpecialCode { get; set; }
        public string GroupCode { get; set; }
        public string ProducerCode { get; set; }
        public decimal OnhandStock { get; set; }
        public decimal ReservedStock { get; set; }
        public bool Active { get; set; }
    }
}
