using System.Net;

namespace Apcef.Domain.Abstractions.Application
{
    public interface IAppDataApplication
    {
        Task<(HttpStatusCode statusCode, string message)> UpdateRepositoryData(CancellationToken cancellationToken);
    }
}
