using Apcef.Domain.Abstractions.Application;
using Apcef.Domain.Abstractions.Repository;
using Apcef.Domain.Abstractions.Repository.WebApp;
using Apcef.Domain.Entities;
using System.Net;

namespace Apcef.Application
{
    public class AppDataApplication : IAppDataApplication
    {
        private readonly IRepository<Modality> _modalityRepository;
        private readonly IRepository<Branch> _branchRepository;
        private readonly IRepository<Team> _teamRepository;
        private readonly IRepository<Group> _groupRepository;
        private readonly IRepository<Round> _roundRepository;
        private readonly IRepository<Match> _matchRepository;
        private readonly IWebAppRepository _webAppDataRepository;

        public AppDataApplication(
            IRepository<Modality> modalityRepository,
            IRepository<Branch> branchRepository,
            IRepository<Team> teamRepository,
            IRepository<Group> groupRepository,
            IRepository<Round> roundRepository,
            IRepository<Match> matchRepository,
            IWebAppRepository webAppDataRepository
            )
        {
            ArgumentNullException.ThrowIfNull(modalityRepository);
            ArgumentNullException.ThrowIfNull(branchRepository);
            ArgumentNullException.ThrowIfNull(teamRepository);
            ArgumentNullException.ThrowIfNull(groupRepository);
            ArgumentNullException.ThrowIfNull(roundRepository);
            ArgumentNullException.ThrowIfNull(matchRepository);
            ArgumentNullException.ThrowIfNull(webAppDataRepository);

            _modalityRepository = modalityRepository;
            _branchRepository = branchRepository;
            _teamRepository = teamRepository;
            _groupRepository = groupRepository;
            _roundRepository = roundRepository;
            _matchRepository = matchRepository;
            _webAppDataRepository = webAppDataRepository;

        }

        public async Task<(HttpStatusCode statusCode, string message)> UpdateRepositoryData(CancellationToken cancellationToken)
        {
            var modalities = await _modalityRepository.GetAll(cancellationToken);
            var branches = await _branchRepository.GetAll(cancellationToken);
            var teams = await _teamRepository.GetAll(cancellationToken);
            var groups = await _groupRepository.GetAll(cancellationToken);
            var rounds = await _roundRepository.GetAll(cancellationToken);
            var matches = await _matchRepository.GetAll(cancellationToken);

            _webAppDataRepository.RefreshData(modalities, branches, teams, groups, rounds, matches);

            return (HttpStatusCode.OK, "Atualizado com sucesso");

        }
    }
}
