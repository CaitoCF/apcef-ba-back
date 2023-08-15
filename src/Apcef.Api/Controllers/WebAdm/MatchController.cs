using Apcef.Api.Controllers.Base;
using Apcef.Domain.Abstractions.Repository;
using Apcef.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Apcef.Api.Controllers.WebAdm
{
    [Route("/v1/web-adm/match/")]
    public class MatchController : WebAdmController<Match>
    {
        public MatchController(IRepository<Match> repository) : base(repository)
        {
        }
    }
}
