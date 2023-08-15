using Apcef.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Apcef.Infrastructure.TableMapping
{
    public class RoundMap : BaseMap
    {
        public RoundMap(ModelBuilder modelBuilder)
        {
            ConfigureDefaults<Round>("tb_round",modelBuilder);

            modelBuilder.Entity<Round>().Property(p => p.Name).HasColumnName("name");

            modelBuilder.Entity<Round>().Property(p => p.ModalityId).HasColumnName("modality_id");

        }

    }
}
