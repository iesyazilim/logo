namespace Ies.MultiFirm.ClCards
{
    public class GetClCardListDto : IDto
    {
        public int DataReference { get; set; }
        public string Code { get; set; }
        public string Definition { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public bool Active { get; set; }
    }
}
