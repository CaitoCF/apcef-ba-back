using Apcef.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Apcef.Infrastructure.TableMapping
{
    public class TeamMap : BaseMap
    {

        public TeamMap(ModelBuilder modelBuilder)
        {
            ConfigureDefaults<Team>("tb_team",modelBuilder);
        
            
            modelBuilder.Entity<Team>().Property(p => p.Name).HasColumnName("name");
            modelBuilder.Entity<Team>().Property(p => p.ModalityId).HasColumnName("modality_id");
            modelBuilder.Entity<Team>().Property(p => p.Points).HasColumnName("points");
            modelBuilder.Entity<Team>().Property(p => p.BranchId).HasColumnName("branch_id");
            modelBuilder.Entity<Team>().Property(p => p.GroupId).HasColumnName("group_id");
        }

    }
}
