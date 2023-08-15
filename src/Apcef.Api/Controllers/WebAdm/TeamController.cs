using Apcef.Api.Controllers.Base;
using Apcef.Domain.Abstractions.Repository;
using Apcef.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Apcef.Api.Controllers.WebAdm
{
    [Route("/v1/web-adm/team/")]
    public class TeamController : WebAdmController<Team>
    {
        public TeamController(IRepository<Team> repository) : base(repository)
        {
        }
    }
}
