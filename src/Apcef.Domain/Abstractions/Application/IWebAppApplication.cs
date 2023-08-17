using Apcef.Domain.Arguments.Response;

namespace Apcef.Domain.Abstractions.Application
{
    public interface IWebAppApplication
    {
        IEnumerable<GetAllModalitiesResponse> GetAllModalities();

        IEnumerable<GetRounds> GetRoundsByModalityId(Guid modalityId);

        IEnumerable<GetMatches> GetMatches(Guid roundId, Guid modalityId);

        IEnumerable<GetPointsPerGroup> GetPointsPerGroup(Guid groupId, Guid modalityId);
    }
}
