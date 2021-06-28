using Ies.Logo.Core.Configuration;
using Ies.LogoApp.Abstract;

namespace Ies.LogoApp.ClCards
{
    public class ClCardDal : LogoAppListDalBase<GetClCardListDto>, IClCardDal
    {
        public ClCardDal(ILogoConnectionConfiguration configuration) : base(configuration)
        {
            QueryBase = @"WITH List AS
            (
                SELECT 

                CLCARDS.LOGICALREF Id
                ,CLCARDS.CODE Code
                ,CLCARDS.DEFINITION_ Definition
                ,CLCARDS.ACTIVE Active

                FROM LG_{firm}_CLCARD CLCARDS

                WHERE CLCARDS.CARDTYPE<>22
            )";
        }
    }
}
