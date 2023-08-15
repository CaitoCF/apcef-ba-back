using Apcef.Api.Controllers.Base;
using Apcef.Domain.Abstractions.Repository;
using Apcef.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Apcef.Api.Controllers.WebAdm
{
    [Route("/v1/web-adm/round/")]
    public class RoundController : WebAdmController<Round>
    {
        public RoundController(IRepository<Round> repository) : base(repository)
        {
        }
    }
}
