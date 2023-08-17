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

        public IEnumerable<GetAllModalitiesResponse> GetAllModalities()
        {
            var modalities = _repository.GetAllModalities();

            return modalities.Select(s => new GetAllModalitiesResponse
            {
                Id = s.Id,
                Name = s.Name
            }).ToList();
        }

        public IEnumerable<GetMatches> GetMatches(Guid roundId, Guid modalityId)
        {
            var matches = _repository
                .GetAllMatches()
                .Where(w => w.RoundId == roundId && w.ModalityId == modalityId)
                .ToList();

            var allTeams = _repository
                .GetAllTeams()
                .Where(w => w.ModalityId == modalityId)
                .ToList();

            var response = (from m in matches
                           join ft in allTeams
                           on m.FirstTeamId equals ft.Id
                           join st in allTeams
                           on m.SecondTeamId equals st.Id
                           select new GetMatches
                           {
                               firstTeamName = ft.Name,
                               secondTeamName = st.Name,
                               firstTeamScore = m.FirstTeamScore,
                               secondTeamScore = m.SecondTeamScore,
                               matchDate = m.MatchDate,
                               order = m.Order,
                               placeName = m.PlaceName
                           }).OrderBy(o => o.matchDate).ToList();

            for(int i =0; i < response.Count;i++)
            {
                response[i].order = i + 1;
            }

            return response;
        }

        public IEnumerable<GetPointsPerGroup> GetPointsPerGroup(Guid groupId, Guid modalityId)
        {
            var teams = _repository
                .GetAllTeams()
                .Where(w => w.GroupId == groupId && w.ModalityId == modalityId)
                .ToList();

            var response = teams.Select(s => new GetPointsPerGroup
            {
                teamName = s.Name,
                points = s.Points,
                order = 1
            }).OrderBy(o => o.points).ToList();

            for(int i =0; i < response.Count; i++)
            {
                response[i].order = i+1;
            }

            return response;

        }

        public IEnumerable<GetRounds> GetRoundsByModalityId(Guid modalityId)
        {
            return _repository.GetAllRounds().Where(w => w.ModalityId==modalityId).Select(s => new GetRounds
            {
                id = s.Id,
                name = s.Name,
            });
        }
    }
}
