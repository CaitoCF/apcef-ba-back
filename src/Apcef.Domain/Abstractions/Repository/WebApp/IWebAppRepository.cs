using Apcef.Domain.Arguments.Response;

namespace Apcef.Domain.Abstractions.Repository.WebApp
{
    public interface IWebAppRepository
    {
        IEnumerable<GetAllModalitiesResponse> GetAllModalities();

    }
}
