using System.Threading.Tasks;
using Ies.Logo.DataType.Infrastructure;
using Ies.Logo.DataType.Xml;
using Ies.Logo.ServiceAdapter;

namespace Ies.Logo.Repositories
{
    public class LogoRepository<TEntity> : ILogoRepository<TEntity> where TEntity : ILogoBase, new()
    {
        protected ILogoObjectService LogoObjectService { get; }

        public LogoRepository(ILogoObjectService logoObjectService)
        {
            LogoObjectService = logoObjectService;
        }

        public virtual int AddOrUpdate(TEntity entity, bool autoSet = true, Parameter parameter = null) => LogoObjectService.AppendDataObjectAsync(entity.Serialize(autoSet), (int)entity.GetRootElementName(), parameter).GetAwaiter().GetResult();
        public virtual void Delete(int id) => LogoObjectService.DeleteDataObjectAsync((int)new TEntity().GetRootElementName(), id).GetAwaiter().GetResult();
        public virtual TEntity Get(int id)
        {
            string xml = LogoObjectService.ReadDataObjectAsync((int)new TEntity().GetRootElementName(), id).GetAwaiter().GetResult();
            return xml.Deserialize<TEntity>();
        }
        public string GetXml(int id) => LogoObjectService.ReadDataObjectAsync((int)new TEntity().GetRootElementName(), id).GetAwaiter().GetResult();

        public async virtual Task<int> AddOrUpdateAsync(TEntity entity, bool autoSet = true, Parameter parameter = null) => await LogoObjectService.AppendDataObjectAsync(entity.Serialize(autoSet), (int)entity.GetRootElementName(), parameter);
        public async virtual Task DeleteAsync(int id) => await LogoObjectService.DeleteDataObjectAsync((int)new TEntity().GetRootElementName(), id);
        public async virtual Task<TEntity> GetAsync(int id)
        {
            string xml = await LogoObjectService.ReadDataObjectAsync((int)new TEntity().GetRootElementName(), id);
            return xml.Deserialize<TEntity>();
        }
        public async virtual Task<string> GetXmlAsync(int id) => await LogoObjectService.ReadDataObjectAsync((int)new TEntity().GetRootElementName(), id);

    }
}
