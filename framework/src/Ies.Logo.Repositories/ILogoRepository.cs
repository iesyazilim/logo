using System.Threading.Tasks;
using Ies.Logo.DataType.Infrastructure;
using Ies.Logo.ServiceAdapter;

namespace Ies.Logo.Repositories
{
    public interface ILogoRepository { }

    public interface ILogoRepository<TEntity> where TEntity : ILogoBase, new()
    {
        TEntity Get(int id);
        string GetXml(int id);
        int AddOrUpdate(TEntity entity, bool autoSet = true, Parameter parameter = null);
        void Delete(int id);

        Task<TEntity> GetAsync(int id);
        Task<string> GetXmlAsync(int id);
        Task<int> AddOrUpdateAsync(TEntity entity, bool autoSet = true, Parameter parameter = null);
        Task DeleteAsync(int id);
    }
}
