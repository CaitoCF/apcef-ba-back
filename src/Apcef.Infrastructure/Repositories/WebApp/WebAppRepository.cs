using Apcef.Domain.Abstractions.Repository.WebApp;
using Apcef.Domain.Arguments.Response;
using Apcef.Domain.Entities;

namespace Apcef.Infrastructure.Repositories.WebApp
{
    public class WebAppRepository : IWebAppRepository
    {
        private List<Modality> modalities;
        private List<Branch> branches;
        private List<Team> teams;
        private List<Match> matches;
        private List<Group> groups;
        private List<Round> rounds;

        public WebAppRepository()
        {
            modalities = new List<Modality>();
            branches = new List<Branch>();
            teams = new List<Team>();
            matches = new List<Match>();
            groups = new List<Group>();
            rounds = new List<Round>();
        }

        public IEnumerable<Modality> GetAllModalities()
        {
            return modalities;
        }
        public IEnumerable<Branch> GetAllBranches()
        {
            return branches;
        }
        public IEnumerable<Team> GetAllTeams()
        {
            return teams;
        }
        public IEnumerable<Match> GetAllMatches()
        {
            return matches;
        }
        public IEnumerable<Group> GetAllGroups()
        {
            return groups;
        }
        public IEnumerable<Round> GetAllRounds()
        {
            return rounds;
        }

        public void RefreshData(
            IEnumerable<Modality> newModalities,
            IEnumerable<Branch> newBranches,
            IEnumerable<Team> newTeams,
            IEnumerable<Group> newGroups,
            IEnumerable<Round> newRounds,
            IEnumerable<Match> newMatches
            )
        {
            modalities.Clear();
            groups.Clear();
            rounds.Clear();
            matches.Clear();
            teams.Clear();
            branches.Clear();

            modalities = newModalities.ToList();
            branches = newBranches.ToList();
            teams = newTeams.ToList();
            groups = newGroups.ToList();
            rounds = newRounds.ToList();
            matches = newMatches.ToList();
        }

    }
}
