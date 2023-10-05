using System.Threading.Tasks;
using Ies.Logo.Core.Configuration;
using Ies.Logo.DataType.Infrastructure;
using Ies.Logo.Repositories;
using Ies.Logo.ServiceAdapter;

namespace Ies.Logo.Manager
{
    public class LogoCrudManager<TEntity> : LogoManager, ILogoCrudService<TEntity> where TEntity : ILogoBase, new()
    {
        protected ILogoRepository<TEntity> Repository { get; }

        public LogoCrudManager(ILogoConnectionConfiguration configuration, ILogoRepository<TEntity> repository) : base(configuration)
        {
            Repository = repository;
        }

        public virtual async Task<int> AddOrUpdateAsync(TEntity entity, bool autoSet = true, Parameter parameter = null) => await Repository.AddOrUpdateAsync(entity, autoSet, parameter);

        public virtual async Task DeleteAsync(int id) => await Repository.DeleteAsync(id);

        public virtual async Task<TEntity> GetAsync(int id) => await Repository.GetAsync(id);

        public virtual async Task<string> GetXmlAsync(int id) => await Repository.GetXmlAsync(id);
    }
}
