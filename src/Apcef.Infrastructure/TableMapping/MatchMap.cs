using Apcef.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Apcef.Infrastructure.TableMapping
{
    public class MatchMap : BaseMap
    {

        public MatchMap(ModelBuilder modelBuilder)
        {
            ConfigureDefaults<Match>("tb_match", modelBuilder);


            modelBuilder.Entity<Match>().Property(p => p.PlaceName).HasColumnName("place_name");
            modelBuilder.Entity<Match>().Property(p => p.ModalityId).HasColumnName("modality_id");
            modelBuilder.Entity<Match>().Property(p => p.FirstTeamId).HasColumnName("first_team_id");
            modelBuilder.Entity<Match>().Property(p => p.SecondTeamId).HasColumnName("second_team_id");
            modelBuilder.Entity<Match>().Property(p => p.FirstTeamScore).HasColumnName("first_team_score");
            modelBuilder.Entity<Match>().Property(p => p.SecondTeamScore).HasColumnName("second_team_score");
            modelBuilder.Entity<Match>().Property(p => p.Order).HasColumnName("order");
            modelBuilder.Entity<Match>().Property(p => p.MatchDate).HasColumnName("match_date");
            modelBuilder.Entity<Match>().Property(p => p.RoundId).HasColumnName("round_id");

        }

    }
}
