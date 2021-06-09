using System.Threading.Tasks;
using Ies.Logo.DataType.Infrastructure;

namespace Ies.Logo.Manager
{
    public interface ILogoCrudService<TEntity> : ILogoService where TEntity : ILogoBase, new()
    {
        Task<TEntity> GetAsync(int id);
        Task<int> AddOrUpdateAsync(TEntity entity, bool autoSet = true);
        Task DeleteAsync(int id);
    }
}
