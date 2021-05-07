namespace Ies.Logo.DataType.Infrastructure
{
    public interface IAuthCode
    {
        string AuthCode { get; set; }
    }

    public interface IAuxilCode
    {
        string AuxilCode { get; set; }
    }

    public interface IDetailedAuxilCode : IAuxilCode
    {
        string AuxilCode2 { get; set; }
        string AuxilCode3 { get; set; }
        string AuxilCode4 { get; set; }
        string AuxilCode5 { get; set; }
    }

    public interface ISpecialCode : IAuthCode, IAuxilCode
    {

    }
}
