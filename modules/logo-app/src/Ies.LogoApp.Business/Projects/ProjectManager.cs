using Ies.Logo.Core.Configuration;
using Ies.Logo.DataType.Projects;
using Ies.Logo.Repositories;
using Ies.LogoApp.Abstract;

namespace Ies.LogoApp.Projects
{
    public class ProjectManager : LogoAppManagerBase<Project, GetProjectListDto>, IProjectService
    {
        protected IProjectDal ProjectDal { get; }

        public ProjectManager(
           ILogoConnectionConfiguration configuration,
           ILogoRepository<Project> repository,
           IProjectDal projectDal)
           : base(configuration, repository, projectDal)
        {
            ProjectDal = projectDal;
        }
    }
}
