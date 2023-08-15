using Apcef.Domain.Abstractions.Repository.General;
using Apcef.Domain.Arguments.Request;
using Microsoft.AspNetCore.Mvc;

namespace Apcef.Api.Controllers.WebAdm
{
    [ApiController]
    [Route("/v1/auth/")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _authRepository;
        public AuthController(IAuthRepository authRepository)
        {
            ArgumentNullException.ThrowIfNull(authRepository);

            _authRepository = authRepository;
        }
        [HttpPost("validate")]
        public async Task<IActionResult> ValidateUser([FromBody]Login login, CancellationToken cancellationToken)
        {
            var token = _authRepository.GenerateAccessToken(login, cancellationToken);
            if(token is null)
            {
                return BadRequest("Usuário inválido");
            }
            return Ok(new { token });
        }

    }
}
