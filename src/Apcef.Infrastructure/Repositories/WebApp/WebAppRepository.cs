using Apcef.Domain.Abstractions.Repository.WebApp;
using Apcef.Domain.Arguments.Response;

namespace Apcef.Infrastructure.Repositories.WebApp
{
    public class WebAppRepository : IWebAppRepository
    {
        private List<GetAllModalitiesResponse> modalities;

        public WebAppRepository()
        {
            modalities = new List<GetAllModalitiesResponse>();
        }

        public IEnumerable<GetAllModalitiesResponse> GetAllModalities()
        {
            return modalities;
        }

        public void RefreshModalities(IEnumerable<GetAllModalitiesResponse> newModalities)
        {
            modalities.Clear();

            modalities = newModalities.ToList();
        }

    }
}
