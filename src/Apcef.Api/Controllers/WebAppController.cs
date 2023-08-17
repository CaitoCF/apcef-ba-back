using Apcef.Api.Attributes;
using Apcef.Domain.Abstractions.Application;
using Apcef.Domain.Arguments.Request;
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
            var result = _application.GetAllModalities();

            return Ok(result);
        }

        [HttpGet("rounds/{modalityId}")]
        public async Task<IActionResult> GetRounds([FromRoute]Guid modalityId)
        {
            var result = _application.GetRoundsByModalityId(modalityId);

            return Ok(result);
        }

        [HttpGet("points-per-group")]
        public async Task<IActionResult> GetPointsPerGroup([FromQuery]GetPointsPerGroupRequest request)
        {
            var result = _application.GetPointsPerGroup(request.GroupId, request.ModalityId);

            return Ok(result);
        }

        [HttpGet("rounds/matches")]
        public async Task<IActionResult> GetMatches([FromQuery] GetMatchesRequest request)
        {
            var result = _application.GetMatches(request.RoundId, request.ModalityId);

            return Ok(result);
        }

    }
}