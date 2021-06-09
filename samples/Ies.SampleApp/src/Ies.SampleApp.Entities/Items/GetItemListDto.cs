namespace Ies.SampleApp.Items
{
    public class GetItemListDto : IDto
    {
        public int DataReference { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
    }
}
