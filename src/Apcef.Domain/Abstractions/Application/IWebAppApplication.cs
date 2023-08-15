using Apcef.Domain.Arguments.Response;

namespace Apcef.Domain.Abstractions.Application
{
    public interface IWebAppApplication
    {
        Task<IEnumerable<GetAllModalitiesResponse>> GetAllModalities();
    }
}
