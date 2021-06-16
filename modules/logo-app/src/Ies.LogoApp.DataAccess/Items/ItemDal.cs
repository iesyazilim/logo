﻿using Ies.Logo.Core.Configuration;
using Ies.LogoApp.Abstract;

namespace Ies.LogoApp.Items
{
    public class ItemDal : LogoAppListDalBase<GetItemListDto>, IItemDal
    {
        public ItemDal(ILogoConnectionConfiguration configuration) : base(configuration)
        {
            QueryBase = @"WITH List AS
            (
                SELECT 
                 LOGICALREF Id
                ,CODE Code
                ,NAME Name
                ,NAME3 Name2
                ,NAME4 Name3
                ,ACTIVE Active
                FROM LG_{firm}_ITEMS 
                WHERE CARDTYPE<>22
            )";
        }

    }
}
