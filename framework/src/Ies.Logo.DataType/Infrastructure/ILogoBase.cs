namespace Ies.Logo.DataType.Infrastructure
{
    public interface ILogo { }

    public interface ILogoBase : ILogo, IDataReference
    {
        Dbop Dbop { get; set; }
        string Guid { get; set; }
        string LogoId { get; set; }
        string OrgLogoId { get; set; }

        string GetRootElementName();
    }
}
