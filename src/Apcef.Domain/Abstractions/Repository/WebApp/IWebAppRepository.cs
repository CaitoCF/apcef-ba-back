using Apcef.Domain.Arguments.Response;
using Apcef.Domain.Entities;

namespace Apcef.Domain.Abstractions.Repository.WebApp
{
    public interface IWebAppRepository
    {
        IEnumerable<Modality> GetAllModalities();
        IEnumerable<Branch> GetAllBranches();
        IEnumerable<Team> GetAllTeams();
        IEnumerable<Match> GetAllMatches();
        IEnumerable<Group> GetAllGroups();
        IEnumerable<Round> GetAllRounds();
        void RefreshData(
            IEnumerable<Modality> newModalities,
            IEnumerable<Branch> newBranches,
            IEnumerable<Team> newTeams,
            IEnumerable<Group> newGroups,
            IEnumerable<Round> newRounds,
            IEnumerable<Match> newMatches);
    }
}
