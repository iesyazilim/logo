using Ies.Logo.DataType.Infrastructure;
using Ies.Logo.ServiceAdapter;
using System.Threading.Tasks;

namespace Ies.Logo.Manager
{
    public interface ILogoCrudService<TEntity> : ILogoService where TEntity : ILogoBase, new()
    {
        Task<TEntity> GetAsync(int id);
        Task<string> GetXmlAsync(int id);
        Task<int> AddOrUpdateAsync(TEntity entity, bool autoSet = true, Parameter parameter = null, bool overrideParameterWithNull = false);
        Task DeleteAsync(int id);
    }
}
