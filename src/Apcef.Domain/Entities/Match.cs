using Apcef.Domain.Entities.Base;

namespace Apcef.Domain.Entities
{
    public class Match : Entity
    {

        public string PlaceName { get; set; }
        public Guid ModalityId { get; set; }
        public Guid FirstTeamId { get; set; }
        public Guid SecondTeamId { get; set; }
        public int Order { get; set; }
        public DateTime MatchDate { get; set; }
        public int FirstTeamScore { get; set; }
        public int SecondTeamScore { get; set; }
        public Guid RoundId { get; set; }

    }
}
