using Apcef.Api.Controllers.Base;
using Apcef.Domain.Abstractions.Repository;
using Apcef.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Apcef.Api.Controllers.WebAdm
{
    [Route("/v1/web-adm/modality/")]
    public class ModalityController : WebAdmController<Modality>
    {
        public ModalityController(IRepository<Modality> repository) : base(repository)
        {
        }
    }
}
