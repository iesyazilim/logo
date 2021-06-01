using System.Threading.Tasks;

namespace Ies.Logo.ServiceAdapter
{
    public interface ILogoObjectService
    {
        string FirmNumber { get; }
        string FirmPeriod { get; }

        Task<int> AppendDataObjectAsync(string xml, int dataType = -1);
        Task DeleteDataObjectAsync(int dataType, int dataReference);
        Task<string> ReadDataObjectAsync(int dataType, int dataReference);
    }
}
