using System.Threading.Tasks;
using Ies.Logo.DataType.Infrastructure;
using Ies.Logo.ServiceAdapter;

namespace Ies.Logo.Manager
{
    public interface ILogoCrudService<TEntity> : ILogoService where TEntity : ILogoBase, new()
    {
        Task<TEntity> GetAsync(int id);
        Task<string> GetXmlAsync(int id);
        Task<int> AddOrUpdateAsync(TEntity entity, bool autoSet = true, Parameter parameter = null);
        Task DeleteAsync(int id);
    }
}
