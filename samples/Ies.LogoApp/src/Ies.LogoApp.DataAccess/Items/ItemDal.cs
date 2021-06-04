using System;
using Allegory.Standart.Filter.Concrete;
using Ies.Logo.Core.Configuration;
using Ies.LogoApp.Entities.Items;

namespace Ies.LogoApp.DataAccess.Items
{
    public class ItemDal : IItemDal
    {
        protected ILogoConnectionConfiguration Configuration { get; }

        public ItemDal(ILogoConnectionConfiguration configuration)
        {
            Configuration = configuration;
        }

        public ItemDto GetAsync(Condition conditions = null)
        {
            throw new NotImplementedException();
        }
    }
}
