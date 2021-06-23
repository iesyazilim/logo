using Ies.Logo.DataType.Projects;
using Ies.LogoApp.Abstract;
using Ies.LogoApp.Projects;
using Microsoft.AspNetCore.Mvc;

namespace Ies.LogoApp.Controllers
{
    [Route("api/logo-app/project")]
    [ApiController]
    public class ProjectController : LogoAppControllerBase<Project, GetProjectListDto>
    {
        private readonly IProjectService _projectService;

        public ProjectController(IProjectService projectService) : base(projectService)
        {
            _projectService = projectService;
        }
    }
}
