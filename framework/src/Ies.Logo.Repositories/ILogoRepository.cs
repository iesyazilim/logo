using System.Threading.Tasks;
using Ies.Logo.DataType.Infrastructure;

namespace Ies.Logo.Repositories
{
    public interface ILogoRepository { }

    public interface ILogoRepository<TEntity> where TEntity : ILogoBase, new()
    {
        TEntity Get(int id);
        string GetXml(int id);
        int AddOrUpdate(TEntity entity, bool autoSet = true);
        void Delete(int id);

        Task<TEntity> GetAsync(int id);
        Task<string> GetXmlAsync(int id);
        Task<int> AddOrUpdateAsync(TEntity entity, bool autoSet = true);
        Task DeleteAsync(int id);
    }
}
