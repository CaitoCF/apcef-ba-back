using Apcef.Api.Attributes;
using Apcef.Domain.Abstractions.Application;
using Microsoft.AspNetCore.Mvc;
using static System.Net.Mime.MediaTypeNames;

namespace Apcef.Api.Controllers
{
    [ApiController]
    [Route("/v1/app-data/")]
    [ApiKey]
    public class AppDataController : ControllerBase
    {
        private readonly IAppDataApplication _appDataApplication;

        public AppDataController(IAppDataApplication appDataApplication)
        {
            ArgumentNullException.ThrowIfNull(appDataApplication, nameof(appDataApplication));

            _appDataApplication = appDataApplication;
        }

        [HttpPost("refresh-data")]
        [ApiKey]
        public async Task<IActionResult> RefreshData(CancellationToken cancellationToken)
        {
            var result = await _appDataApplication.UpdateRepositoryData(cancellationToken);

            return StatusCode((int)result.statusCode,result.message);
        }
    }
}
