using System;
using System.Threading.Tasks;
using Allegory.Standart.Filter.Concrete;
using Ies.Logo.Core.Configuration;
using Ies.LogoApp.Core.Entities;

namespace Ies.LogoApp.Items
{
    public class ItemDal : DalBase, IItemDal
    {
        public ItemDal(ILogoConnectionConfiguration configuration) : base(configuration) { }

        public Task<long> CountAsync(Condition conditions)
        {
            throw new NotImplementedException();
        }

        public Task<PagedResultDto<GetItemListDto>> GetListAsync(PagedRequestDto pagedRequest)
        {
            throw new NotImplementedException();
        }
    }
}
