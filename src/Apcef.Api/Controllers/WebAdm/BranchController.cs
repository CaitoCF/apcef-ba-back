using Apcef.Api.Controllers.Base;
using Apcef.Domain.Abstractions.Repository;
using Apcef.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Apcef.Api.Controllers.WebAdm
{
    [Route("/v1/web-adm/branch/")]
    public class BranchController : WebAdmController<Branch>
    {
        public BranchController(IRepository<Branch> repository) : base(repository)
        {
        }
    }
}
