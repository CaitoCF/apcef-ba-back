using Apcef.Domain.Arguments.Request;

namespace Apcef.Domain.Abstractions.Repository.General
{
    public interface IAuthRepository
    {
        Guid? GenerateAccessToken(Login login, CancellationToken cancellationToken);

    }
}
