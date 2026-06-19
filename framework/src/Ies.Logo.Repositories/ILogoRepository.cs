using Ies.Logo.DataType.Infrastructure;
using Ies.Logo.ServiceAdapter;
using System.Threading.Tasks;

namespace Ies.Logo.Repositories
{
    public interface ILogoRepository { }

    public interface ILogoRepository<TEntity> where TEntity : ILogoBase, new()
    {
        TEntity Get(int id);
        string GetXml(int id);
        int AddOrUpdate(TEntity entity, bool autoSet = true, Parameter parameter = null, bool overrideParameterWithNull = false);
        void Delete(int id);

        Task<TEntity> GetAsync(int id);
        Task<string> GetXmlAsync(int id);
        Task<int> AddOrUpdateAsync(TEntity entity, bool autoSet = true, Parameter parameter = null, bool overrideParameterWithNull = false);
        Task DeleteAsync(int id);
    }
}
