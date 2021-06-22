using Ies.Logo.Core.Configuration;
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

                ITEMS.LOGICALREF Id
                ,ITEMS.CARDTYPE CardType
                ,ITEMS.CODE Code
                ,ITEMS.NAME Name
                ,ITEMS.NAME3 Name2
                ,ITEMS.NAME4 Name3
                ,UNITL.CODE MainUnitCode
                ,ITEMS.SPECODE SpecialCode
                ,ITEMS.STGRPCODE GroupCode
                ,ITEMS.PRODUCERCODE ProducerCode
                ,ISNULL(GNTOTST.ONHAND,0) OnhandStock
                ,ISNULL(GNTOTST.RESERVED,0) ReservedStock
                ,ITEMS.ACTIVE Active

                FROM LG_{firm}_ITEMS 
                LEFT JOIN LG_{firm}_UNITSETF UNITF ON UNITF.LOGICALREF=ITEMS.UNITSETREF
                LEFT JOIN LG_{firm}_UNITSETL UNITL ON UNITF.LOGICALREF=UNITL.UNITSETREF AND UNITL.MAINUNIT=1
                LEFT JOIN LV_{firm}_{period}_GNTOTST GNTOTST ON  ITEMS.LOGICALREF=GNTOTST.STOCKREF AND INVENNO=-1 

                WHERE CARDTYPE<>22
            )";
        }

    }
}
