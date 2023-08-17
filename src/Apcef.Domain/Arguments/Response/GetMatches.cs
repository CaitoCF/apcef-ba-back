namespace Apcef.Domain.Arguments.Response
{
    public class GetMatches
    {
        public string firstTeamName { get; set; }
        public string secondTeamName { get; set; }
        public int firstTeamScore { get; set; }
        public int secondTeamScore { get; set; }
        public DateTime matchDate { get; set; }
        public string placeName { get; set; }
        public int order { get; set; }

    }
}
