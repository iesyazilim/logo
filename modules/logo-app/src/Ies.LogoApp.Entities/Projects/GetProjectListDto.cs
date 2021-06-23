namespace Ies.LogoApp.Projects
{
    public class GetProjectListDto : IDto
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
    }
}
