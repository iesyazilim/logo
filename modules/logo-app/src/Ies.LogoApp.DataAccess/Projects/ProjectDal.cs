using Ies.Logo.Core.Configuration;
using Ies.LogoApp.Abstract;

namespace Ies.LogoApp.Projects
{
    public class ProjectDal : LogoAppListDalBase<GetProjectListDto>, IProjectDal
    {
        public ProjectDal(ILogoConnectionConfiguration configuration) : base(configuration)
        {
            QueryBase = @"WITH List AS
            (
                SELECT 

                PROJECT.LOGICALREF Id
                ,PROJECT.CODE Code
                ,PROJECT.NAME Name

                FROM LG_{firm}_PROJECT PROJECT

            )";
        }
    }
}
