using Apcef.Api.Attributes;
using Apcef.Domain.Abstractions.Application;
using Microsoft.AspNetCore.Mvc;

namespace Apcef.Api.Controllers
{
    [ApiController]
    [Route("/v1/web-app/")]
    public class WebAppController : ControllerBase
    {
        private readonly IWebAppApplication _application;

        public WebAppController(IWebAppApplication application)
        {
            ArgumentNullException.ThrowIfNull(application, nameof(application));

            _application = application;
        }

        [HttpGet("modalities")]
        public async Task<IActionResult> GetAllModalities()
        {
            var result = await _application.GetAllModalities();

            return Ok(result);
        }

    }
}