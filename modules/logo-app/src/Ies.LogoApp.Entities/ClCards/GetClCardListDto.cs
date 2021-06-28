namespace Ies.LogoApp.ClCards
{
    public class GetClCardListDto : IDto
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Definition { get; set; }
        public bool Active { get; set; }
    }
}
