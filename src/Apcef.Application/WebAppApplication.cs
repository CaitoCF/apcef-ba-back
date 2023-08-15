using Apcef.Domain.Abstractions.Application;
using Apcef.Domain.Abstractions.Repository.WebApp;
using Apcef.Domain.Arguments.Response;

namespace Apcef.Application
{
    public class WebAppApplication : IWebAppApplication
    {
        private readonly IWebAppRepository _repository;

        public WebAppApplication(IWebAppRepository repository)
        {
            ArgumentNullException.ThrowIfNull(repository, nameof(repository));

            _repository = repository;

        }

        public async Task<IEnumerable<GetAllModalitiesResponse>> GetAllModalities()
        {
            throw new NotImplementedException();
        }
    }
}
