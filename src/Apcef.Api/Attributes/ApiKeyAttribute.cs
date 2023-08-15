using Apcef.Domain.Abstractions.Repository.General;
using Apcef.Infrastructure.Repositories.General;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Apcef.Api.Attributes
{
    [AttributeUsage(validOn: AttributeTargets.Class | AttributeTargets.Method)]

    public class ApiKeyAttribute : Attribute, IAsyncActionFilter
    {
        private const string ApiKeyName = "api-key";

        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            if (!context.HttpContext.Request.Headers.TryGetValue(ApiKeyName, out var extractedApiKey))
            {
                context.Result = new ContentResult()
                {
                    StatusCode = 401,
                    Content = "ApiKey não encontrada"
                };
                return;
            }

            bool isValidParse = Guid.TryParse(extractedApiKey, out var key);

            if(!isValidParse)
            {
                context.Result = new ContentResult()
                {
                    StatusCode = 403,
                    Content = "Token inválido"
                };
                return;
            }

            bool isUserAuthenticated = ValidateToken(key);

            if (!isUserAuthenticated)
            {
                context.Result = new ContentResult()
                {
                    StatusCode = 403,
                    Content = "Acesso não autorizado"
                };
                return;
            }

            await next();
        }

        public bool ValidateToken(Guid token)
        {
            return TokensRepository.tokens.Contains(token);
        }
    }
}
