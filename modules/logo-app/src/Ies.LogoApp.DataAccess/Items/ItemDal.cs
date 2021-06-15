using Ies.Logo.Core.Configuration;
using Ies.LogoApp.Abstract;

namespace Ies.LogoApp.Items
{
    public class ItemDal : ListDalBase<GetItemListDto>, IItemDal
    {
        public ItemDal(ILogoConnectionConfiguration configuration) : base(configuration)
        {
            QueryBase = @"
            WITH List AS
            (
                SELECT 
                 LOGICALREF Id
                ,CODE Code
                ,NAME Name
                ,NAME3 Name2
                ,NAME4 Name3
                ,ACTIVE Active
                FROM LG_{0}_ITEMS
            )";
        }

    }
}
