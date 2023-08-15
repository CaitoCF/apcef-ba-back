using Apcef.Api.Controllers.Base;
using Apcef.Domain.Abstractions.Repository;
using Apcef.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Apcef.Api.Controllers.WebAdm
{
    [Route("/v1/web-adm/group/")]
    public class GroupController : WebAdmController<Group>
    {
        public GroupController(IRepository<Group> repository) : base(repository)
        {
        }
    }
}
